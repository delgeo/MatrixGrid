using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FormMatrixGrid : Form
    {
        // Add the member variables

        public int m_width; // width of the grid cell
        public int m_Height; // height of the grid cell
        public int m_NoOfRows; // No of Rows
        public int m_NoOfCols; // No of Columns
        public int m_XOffset; // Offset from which drawing start
        public int m_YOffset;
        public int m_GridMaxSize;
        public int i, j, k, m_Count;

        public const int DEFAULT_X_OFFSET = 100;
        public const int DEFAULT_Y_OFFSET = 100;
        public const int DEFAULT_NO_ROWS = 4;
        public const int DEFAULT_NO_COLS = 4;
        public const int DEFAULT_WIDTH = 60;
        public const int DEFAULT_HEIGHT = 60;

        public FormMatrixGrid()
        {
            Initialize();
            InitializeComponent();
        }

        public void Initialize()
        {
            m_NoOfRows = DEFAULT_NO_ROWS;
            m_NoOfCols = DEFAULT_NO_COLS;
            m_width = DEFAULT_WIDTH;
            m_Height = DEFAULT_HEIGHT;
            m_XOffset = DEFAULT_X_OFFSET;
            m_YOffset = DEFAULT_Y_OFFSET;
            m_Count = 2;
        }

        private void DrawGrid(int m_GridMaxSize)
        {
            Graphics boardLayout = this.CreateGraphics();
            Pen layoutPen = new Pen(Color.Red);
            layoutPen.Width = 5;

            //boardLayout.DrawLine(layoutPen, 50, 50, 100, 50);
            for (i = 0; i <= m_GridMaxSize; i++)
            {
                StatusLabel.Text = i.ToString();
                int X = DEFAULT_X_OFFSET;
                int Y = DEFAULT_Y_OFFSET;
                // Draw the rows
                for (j = 0; j <= i; j++)
                {
                    boardLayout.DrawLine(layoutPen, X, Y, X + this.m_width * i, Y);
                    Y = Y + m_Height;
                }

                // Draw the cols
                X = DEFAULT_X_OFFSET;
                Y = DEFAULT_Y_OFFSET;
                // Draw the rows
                for (k = 0; k <= i; k++)
                {
                    boardLayout.DrawLine(layoutPen, X, Y, X, Y + this.m_Height * i);
                    X = X + this.m_width;
                }
                if (i > 1)
                {
                    Thread.Sleep(700);
                }

            }
        }

        public void ThreadCounter()
        {
            try
            {
                while (true)
                {
                    m_Count++;
                    if (bThreadStatus && m_Count > m_GridMaxSize)
                    {
                        m_Count = 2;

                    }
                    Invalidate();
                    DrawGrid(m_GridMaxSize);
                }
            }
            catch (Exception exe)
            {

            }


        }
        private void FormMatrixGrid_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
        }

        private void toolStripButtonPlay_Click(object sender, EventArgs e)
        {
            MatrixGrid = new Thread(new ThreadStart(ThreadCounter));
            MatrixGrid.Start();
            bThreadStatus = true;
        }

        private void toolStripButtonPause_Click(object sender, EventArgs e)
        {
            bThreadStatus = false;
            MatrixGrid.Suspend();

        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            bThreadStatus = true;
            MatrixGrid.Abort();
            this.Refresh();
        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 2;
            this.Refresh();
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 3;
            this.Refresh();
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 4;
            this.Refresh();
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 5;
            this.Refresh();
        }

        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 6;
            this.Refresh();
        }

        private void x7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 7;
            this.Refresh();
        }

        private void x8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 8;
            this.Refresh();

        }

        private void playMenuItem_Click(object sender, EventArgs e)
        {
            MatrixGrid = new Thread(new ThreadStart(ThreadCounter));
            MatrixGrid.Start();
            bThreadStatus = true;
        }

        private void pauseMenuItem_Click(object sender, EventArgs e)
        {
            bThreadStatus = false;
            MatrixGrid.Suspend();
        }

        private void stopMenuItem_Click(object sender, EventArgs e)
        {
            bThreadStatus = true;
            MatrixGrid.Abort();
            this.Refresh();
        }

        private void MenuItem2x2_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 2;
            this.Refresh();
        }

        private void MenuItem3x3_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 3;
            this.Refresh();
        }

        private void MenuItem4x4_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 4;
            this.Refresh();
        }

        private void MenuItem5x5_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 5;
            this.Refresh();
        }

        private void MenuItem6x6_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 6;
            this.Refresh();
        }

        private void MenuItem7x7_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 7;
            this.Refresh();
        }

        private void MenuItem8x8_Click(object sender, EventArgs e)
        {
            m_GridMaxSize = 8;
            this.Refresh();
        }

        private void playMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Play the selected Grid";
        }

        private void pauseMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Pause the Grid currently running";
        }

        private void stopMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Stop the Grid currently running";
        }

        private void exitApplicationToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Exit the application";
        }

        private void MenuItem2x2_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 2x2 grid";
        }

        private void MenuItem3x3_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 3x3 grid";
        }

        private void MenuItem4x4_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 4x4 grid";
        }

        private void MenuItem5x5_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 5x5 grid";
        }

        private void MenuItem6x6_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 6x6 grid";
        }

        private void MenuItem7x7_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 7x7 grid";
        }

        private void MenuItem8x8_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 8x8 grid";
        }

        private void aboutMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "About Application/Developer";
        }

        private void applicationMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "About Application";
        }

        private void developerMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "About Developer";
        }

        private void actionsMenu_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select Operation from items";
        }

        private void matrixGridMenu_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select your Grid size";
        }

        private void helpMenu_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Know your application";
        }

        private void toolStripButtonPlay_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Play the selected Grid";
        }

        private void toolStripButtonPause_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Pause the Grid currently running";
        }

        private void toolStripButtonStop_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Stop the Grid currently running";
        }

        private void toolStripDropDownButton1_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select your Grid size";
        }

        private void x2ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 2x2 grid";
        }

        private void x3ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 3x3 grid";
        }

        private void x4ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 4x4 grid";
        }

        private void x5ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 5x5 grid";
        }

        private void x6ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 6x6 grid";
        }

        private void x7ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 7x7 grid";
        }

        private void x8ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Select 8x8 grid";
        }

        private void actionsMenu_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void matrixGridMenu_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void helpMenu_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void playMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void pauseMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void stopMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void exitApplicationToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void MenuItem2x2_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void MenuItem3x3_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void MenuItem4x4_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void MenuItem5x5_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void MenuItem6x6_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void MenuItem7x7_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void MenuItem8x8_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void aboutMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void applicationMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void developerMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void toolStripButtonPlay_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void toolStripButtonPause_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void toolStripButtonStop_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void toolStripDropDownButton1_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void x2ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void x3ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void x4ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void x5ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void x6ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void x7ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void x8ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = String.Empty;
        }

        private void applicationMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Rights Reserved with KTS", "About Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void developerMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is developed by Delna", "About Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
