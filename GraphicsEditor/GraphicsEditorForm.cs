using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    public partial class GraphicsEditorForm : Form
    {
        private readonly Pen _pen;
        private readonly Canvas _canvas;
        private DrawingMode _drawingMode;
        
        public GraphicsEditorForm()
        {
            InitializeComponent();
            _pen = new Pen(Color.Black, widthTrackBar.Value);
            _canvas = new Canvas();
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

        private void lineButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void canvasPanel_MouseClick(object sender, MouseEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}