﻿using System;
using System.Drawing;
using System.Windows.Forms;
using GeometricPrimitives;
using GraphicsEditor.Controller;

namespace GraphicsEditor.View
{
    public partial class GraphicsEditorView : Form
    {
        private readonly Pen _pen;
        private readonly CanvasController _canvasController;
        private readonly ShapeTypesController _shapeTypesController;
        private Shape _currentShape;
        private Point _lastPoint;
        
        public GraphicsEditorView()
        {
            InitializeComponent();
            _pen = new Pen(Color.Black, widthTrackBar.Value);
            _canvasController = new CanvasController();
            _shapeTypesController = new ShapeTypesController();
            colorPanel.BackColor = _pen.Color;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            penColorDialog.ShowDialog(this);
            _pen.Color = penColorDialog.Color;
            colorPanel.BackColor = penColorDialog.Color;
        }

        private void widthTrackBar_Scroll(object sender, EventArgs e)
        {
            _pen.Width = widthTrackBar.Value;
            penWidthPanel.Invalidate();
        }

        private void penWidthPanel_Paint(object sender, PaintEventArgs e)
        {
            int x = penWidthPanel.Width / 2 - (int)_pen.Width / 2;
            int y = penWidthPanel.Height / 2 - (int)_pen.Width / 2;
            penWidthPanel.CreateGraphics()
                         .FillEllipse(Brushes.Black, x, y, _pen.Width, _pen.Width);
        }

        private void geometricPrimitiveButton_Click(object sender, EventArgs e)
        {
            Type shapeType = Type.GetType(((Button) sender).Text);
            if (shapeType != null)
            {
                _currentShape = (Shape)Activator.CreateInstance(shapeType);
            }
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
            _canvasController.Show(canvasPanel.CreateGraphics());
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                Invalidate();
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
                //_currentShape.SetBounds(_lastPoint, e.Location);
                //_canvasController.AddShape(_currentShape);
                canvasPanel.Invalidate();
            }
        }

        private void addPrimitiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadPrimitiveDialog.ShowDialog(this);
            string path = loadPrimitiveDialog.FileName;
            _shapeTypesController.AddFromAssembly(path);
            //TODO: add button
        }
    }
}