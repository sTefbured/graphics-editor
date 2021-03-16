﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricPrimitives;

namespace GraphicsEditor
{
    public partial class GraphicsEditorForm : Form
    {
        private readonly Pen _pen;
        private readonly Canvas _canvas;
        private Shape _currentShape;
        private Point _lastPoint;
        
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

        //TODO: implement initializing _currentShape with new Line object
        private void lineButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        //TODO: implement initializing _currentShape with new Rectangle object
        private void rectangleButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        //TODO: implement initializing _currentShape with new Circle object
        private void circleButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            loadFileDialog.ShowDialog(this);
            _canvas.Load(loadFileDialog.FileName);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog(this);
            _canvas.Save(saveFileDialog.FileName);
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            _canvas.Show(canvasPanel.CreateGraphics());
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
                canvasPanel.Invalidate();
            }
        }
    }
}