using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoard
{
    public partial class Form1 : Form
    {
        
        int top = 0;
        int left = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CrtChssBoard_Click(object sender, EventArgs e)
        {
            AddPnlBtnClick();
        }
        private void AddPnlBtnClick ()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Panel[,] panel = new Panel[8, 8];
                    panel[i, j] = new Panel();
                    panel[i, j].Width = 70;
                    panel[i, j].Height = 70;
                    panel[i, j].Left = left;
                    panel[i, j].Top = top;
                    this.Controls.Add(panel[i, j]);
                    left += 70;
                    if ((i + j) % 2 == 0)
                    {
                        panel[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        panel[i, j].BackColor = Color.White;
                    }
                }
                top += 70;
                left = 0;
            }
        }
    }
}

