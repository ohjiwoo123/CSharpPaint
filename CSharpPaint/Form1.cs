using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPaint
{
    // enum enumShape { Line, Circle, Rectangle };
    public partial class Form1 : Form
    {
        public bool m_bDrag;
        public bool m_bFill;
        public bool m_bBold;
        public int x, y, x2, y2;
        public static Point startPoint;
        public static Point endPoint;
        public int m_nShape;
        Shape MyShape = new Shape(startPoint, endPoint, false, false, 0);
        List<Shape> ar = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
            startPoint.X = 0;
            startPoint.Y = 0;
            endPoint.X = 0;
            endPoint.Y = 0;
            m_nShape = 0;
            m_bFill = false;
            m_bDrag = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Empty);
            Pen pen = new Pen(Color.Black);

            for (int i = 0; i < ar.Count; i++)
            {
                float w = Math.Abs(ar[i].startPoint.X - ar[i].endPoint.X);
                float h = Math.Abs(ar[i].startPoint.Y - ar[i].endPoint.Y);

                if (ar[i].m_bFill)
                {
                    brush = new SolidBrush(Color.Red);
                }

                if (ar[i].m_bBold)
                {
                    pen.Width = 8.0F;
                }

                switch (ar[i].m_nShape)
                {
                    case 0:
                        e.Graphics.DrawLine(pen, ar[i].startPoint, ar[i].endPoint);
                        break;
                    case 1:
                        if (ar[i].endPoint.X > ar[i].startPoint.X)
                        {
                            if (ar[i].endPoint.Y > ar[i].startPoint.Y)
                            {
                                e.Graphics.DrawEllipse(pen, ar[i].startPoint.X, ar[i].startPoint.Y, w, h);
                                e.Graphics.FillEllipse(brush, ar[i].startPoint.X, ar[i].startPoint.Y, w, h);
                            }
                            else
                            {
                                e.Graphics.DrawEllipse(pen, ar[i].startPoint.X, ar[i].endPoint.Y, w, h);
                                e.Graphics.FillEllipse(brush, ar[i].startPoint.X, ar[i].endPoint.Y, w, h);
                            }
                        }
                        else
                        {
                            if (ar[i].endPoint.Y > ar[i].startPoint.Y)
                            {
                                e.Graphics.DrawEllipse(pen, ar[i].endPoint.X, ar[i].startPoint.Y, w, h);
                                e.Graphics.FillEllipse(brush, ar[i].endPoint.X, ar[i].startPoint.Y, w, h);
                            }
                            else
                            {
                                e.Graphics.DrawEllipse(pen, ar[i].endPoint.X, ar[i].endPoint.Y, w, h);
                                e.Graphics.FillEllipse(brush, ar[i].endPoint.X, ar[i].endPoint.Y, w, h);
                            }
                        }
                        break;
                    case 2:
                        if (ar[i].endPoint.X > ar[i].startPoint.X)
                        {
                            if (ar[i].endPoint.Y > ar[i].startPoint.Y)
                            {
                                e.Graphics.DrawRectangle(pen, ar[i].startPoint.X, ar[i].startPoint.Y, w, h);
                                e.Graphics.FillRectangle(brush, ar[i].startPoint.X, ar[i].startPoint.Y, w, h);
                            }
                            else
                            {
                                e.Graphics.DrawRectangle(pen, ar[i].startPoint.X, ar[i].startPoint.Y, w, h);
                                e.Graphics.FillRectangle(brush, ar[i].startPoint.X, ar[i].endPoint.Y, w, h);
                            }
                        }
                        else
                        {
                            if (ar[i].endPoint.Y > ar[i].startPoint.Y)
                            {
                                e.Graphics.DrawRectangle(pen, ar[i].endPoint.X, ar[i].startPoint.Y, w, h);
                                e.Graphics.FillRectangle(brush, ar[i].endPoint.X, ar[i].startPoint.Y, w, h);
                            }
                            else
                            {
                                e.Graphics.DrawRectangle(pen, ar[i].endPoint.X, ar[i].endPoint.Y, w, h);
                                e.Graphics.FillRectangle(brush, ar[i].endPoint.X, ar[i].endPoint.Y, w, h);
                            }
                        }
                        break;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Shape MyShape = new Shape(startPoint, endPoint, false, false, 0);
            if (e.Button == MouseButtons.Left)
            {
                m_bDrag = true;
                startPoint = new Point(e.X, e.Y);
                MyShape.startPoint = startPoint;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (m_bDrag)
                {
                    endPoint = new Point(e.X, e.Y);
                    MyShape.endPoint = endPoint;
                    Invalidate();
                }
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (m_bDrag)
                {
                    endPoint = new Point(e.X, e.Y);
                    MyShape.endPoint = endPoint;
                    MyShape.startPoint = startPoint;
                    MyShape.m_bFill = m_bFill;
                    MyShape.m_bBold = m_bBold;
                    MyShape.m_nShape = m_nShape;
                    //Shape Myshape = new Shape(startPoint, endPoint, m_bFill, m_bBold, m_nShape);
                    ar.Add(MyShape);
                    Invalidate();

                    // Point 값들 초기화 
                    startPoint.X = 0;
                    startPoint.Y = 0;
                    endPoint.X = 0;
                    endPoint.Y = 0;

                    // 객체에 추가한 후에 m_bFill, m_bBold, m_nShape 는 상태를 유지하고 x,y값은 초기화해서 shape class를 다시 할당 
                    MyShape = new Shape(startPoint, endPoint, m_bFill, m_bBold, m_nShape);
                    // Invalidate();
                    m_bDrag = false;
                }
            }
        }

        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            switch (m_nShape)
            {
                case 0:
                    직선ToolStripMenuItem.Checked = true;
                    원ToolStripMenuItem.Checked = false;
                    네모ToolStripMenuItem.Checked = false;
                    break;
                case 1:
                    원ToolStripMenuItem.Checked = true;
                    직선ToolStripMenuItem.Checked = false;
                    네모ToolStripMenuItem.Checked = false;
                    break;
                case 2:
                    네모ToolStripMenuItem.Checked = true;
                    직선ToolStripMenuItem.Checked = false;
                    원ToolStripMenuItem.Checked = false;
                    break;
            }

            if (m_bBold)
            {
                굵게ToolStripMenuItem.Checked = true;
            }

            else
            {
                굵게ToolStripMenuItem.Checked = false;
            }

            if (m_bFill)
            {
                채우기ToolStripMenuItem.Checked = true;
            }
            else
            {
                채우기ToolStripMenuItem.Checked = false;
            }

        }

        private void 직선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 직선
            m_nShape = 0;
        }
        private void 원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 원
            m_nShape = 1;
        }
        private void 네모ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 사각형
            m_nShape = 2;
        }
        private void 채우기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_bFill)
            {
                m_bFill = false;
            }
            else
            {
                m_bFill = true;
            }
        }

        private void 굵게ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_bBold)
            {
                m_bBold = false;
            }
            else
            {
                m_bBold = true;
            }
        }
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Shape Myshape = new Shape(startPoint, endPoint, m_bFill, m_bBold, m_nShape);

            FileStream fs = new FileStream(@"c:\Temp\Paint.dat",   // file path
                                                FileMode.Create,    // file mode
                                                FileAccess.Write);  // file access
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(ar.Count);

            for (int i = 0; i < ar.Count; i++)
            {
                Shape Myshape = new Shape(ar[i].startPoint, ar[i].endPoint, ar[i].m_bFill, ar[i].m_bBold, ar[i].m_nShape);
                bw.Write(ar[i].startPoint.X);
                bw.Write(ar[i].startPoint.Y);
                bw.Write(ar[i].endPoint.X);
                bw.Write(ar[i].endPoint.Y);
                bw.Write(ar[i].m_bFill);
                bw.Write(ar[i].m_bBold);
                bw.Write(ar[i].m_nShape);
            }
            // 초기화 
            ar.Clear();
            // 파일 닫기 
            bw.Close();
            fs.Close();
            MessageBox.Show("저장이 완료되었습니다.");
        }

        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"c:\Temp\Paint.dat",   // file path
                                                FileMode.Open,    // file mode
                                                FileAccess.Read);  // file access
            BinaryReader br = new BinaryReader(fs);

            int count = br.ReadInt32();

            for(int i=0; i< count; i++)
            {
                startPoint.X = br.ReadInt32();
                startPoint.Y = br.ReadInt32();
                endPoint.X = br.ReadInt32();
                endPoint.Y = br.ReadInt32();
                m_bFill = br.ReadBoolean();
                m_bBold = br.ReadBoolean();
                m_nShape = br.ReadInt32();
                Shape Myshape = new Shape(startPoint, endPoint, m_bFill, m_bBold, m_nShape);
                ar.Add(Myshape);
                Invalidate();
            }
            // 로드가 끝난 후 값 초기화 
            startPoint.X = 0;
            startPoint.Y = 0;
            endPoint.X = 0;
            endPoint.Y = 0;
            // 객체에 추가한 후에 m_bFill, m_bBold, m_nShape 는 상태를 유지하고 x,y값은 초기화해서 shape class를 다시 할당 
            MyShape = new Shape(startPoint, endPoint, m_bFill, m_bBold, m_nShape);

            // 파일 닫기 
            br.Close();
            fs.Close();
            MessageBox.Show("불러오기가 완료되었습니다.");
        }
    }
    class Shape  
    {
        public Point startPoint { get; set; }
        public Point endPoint { get; set; }
        public bool m_bFill { get; set; }
        public bool m_bBold { get; set; }
        public int m_nShape { get; set; }

        public Shape(Point _startPoint, Point _endPoint, bool _m_bFill, bool _m_bBold, int _m_nShape)
        {
            startPoint = _startPoint;
            endPoint = _endPoint;
            m_bFill = _m_bFill;
            m_bBold = _m_bBold;
            m_nShape = _m_nShape;
        }
    }
}
