using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GeometricPrimitives;
using GraphicsEditor.Controller;
using GraphicsEditor.Repository;

namespace GraphicsEditor.View
{
    public partial class GraphicsEditorForm : Form
    {
        private readonly Pen _pen;
        private readonly CanvasController _canvasController;
        private readonly ShapeTypesController _shapeTypesController;
        private Shape _currentShape;
        private Point _lastPoint;

        private const String defaultLinePath = "../../../../Line/bin/Debug/net5.0-windows/Line.dll";
        private const String defaultRectanglePath = "../../../../Rectangle/bin/Debug/net5.0-windows/Rectangle.dll";

        public GraphicsEditorForm()
        {
            InitializeComponent();

            var shapeTypesRepository = new ShapeTypesRepository();
            var shapeRepository = new ShapeRepository(shapeTypesRepository);
            _canvasController = new CanvasController(shapeRepository);
            _shapeTypesController = new ShapeTypesController(shapeTypesRepository);
            _pen = new Pen(Color.Black, widthTrackBar.Value);
            colorPanel.BackColor = _pen.Color;

            ICollection<Type> types = _shapeTypesController.AddFromAssembly(defaultLinePath);
            AddPrimitiveButtons(types);
            types = _shapeTypesController.AddFromAssembly(defaultRectanglePath);
            AddPrimitiveButtons(types);
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            penColorDialog.ShowDialog(this);
            _pen.Color = penColorDialog.Color;
            _currentShape.SetPen(_pen);
            colorPanel.BackColor = penColorDialog.Color;
        }

        private void widthTrackBar_Scroll(object sender, EventArgs e)
        {
            _pen.Width = widthTrackBar.Value;
            _currentShape.SetPen(_pen);
            penWidthPanel.Refresh();
        }

        private void penWidthPanel_Paint(object sender, PaintEventArgs e)
        {
            int x = penWidthPanel.Width / 2 - (int) _pen.Width / 2;
            int y = penWidthPanel.Height / 2 - (int) _pen.Width / 2;
            penWidthPanel.CreateGraphics()
                .FillEllipse(Brushes.Black, x, y, _pen.Width, _pen.Width);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            loadFileDialog.ShowDialog(this);
            _canvasController.Load(loadFileDialog.FileName);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog(this);
            _canvasController.Save(saveFileDialog.FileName);
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            _canvasController.Show(e.Graphics);
            _currentShape?.Draw(e.Graphics);
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _currentShape.SetBounds(_lastPoint, e.Location);
                canvasPanel.Refresh();
            }
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _lastPoint = e.Location;
            }
        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _currentShape.SetBounds(_lastPoint, e.Location);
                _canvasController.AddShape(_currentShape);
                _currentShape = (Shape) Activator.CreateInstance(_currentShape.GetType(), _pen);
                canvasPanel.Refresh();
            }
        }

        private void addPrimitiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadPrimitiveDialog.ShowDialog(this);
            string path = loadPrimitiveDialog.FileName;
            ICollection<Type> types = _shapeTypesController.AddFromAssembly(path);
            AddPrimitiveButtons(types);
        }

        private void AddPrimitiveButtons(ICollection<Type> primitiveTypes)
        {
            foreach (var type in primitiveTypes)
            {
                if (type.IsSubclassOf(typeof(Shape)))
                {
                    RadioButton button = new RadioButton
                    {
                        Text = type.Name,
                        Appearance = Appearance.Button,
                        AccessibleDescription = type.AssemblyQualifiedName
                    };
                    button.Click += geometricPrimitiveButton_Click;
                    primitivesPanel.Controls.Add(button);
                }
            }
        }

        private void geometricPrimitiveButton_Click(object sender, EventArgs e)
        {
            Type shapeType = Type.GetType(((RadioButton) sender).AccessibleDescription);
            if (shapeType != null)
            {
                _currentShape = (Shape) Activator.CreateInstance(shapeType, _pen);
            }
        }
    }
}