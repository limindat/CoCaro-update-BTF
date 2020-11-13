using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class Form1 : Form
    {
        private int Chedo;
        Bitmap cusor;
        private Co_Caro _Co_Caro;
        private Graphics grp;
        private int OF;
        Pen pen = new Pen(Color.Black);
        
        public Form1()
        {
            InitializeComponent();
            rb_Caro.Enabled = false;
            rb_Gomoku.Enabled = false;
            _Co_Caro = new Co_Caro();
            rb_Gomoku.Checked=true;
            
            //_Co_Caro.KTM_O_Co();
            grp = pn_Banco.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            Chedo = rb_Caro.Checked == true ? 0 : 1;
            
            cusor = new Bitmap(Properties.Resources.Cusor, new Size(60, 60));
            this.Cursor = new Cursor(cusor.GetHicon());
        }
        // Bàn cờ
        #region Bàn cờ
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _Co_Caro.Ve_Ban_Co(grp);
            _Co_Caro.Ve_Lai_Quan_Co(grp);
        }
        private void pn_Banco_MouseClick(object sender, MouseEventArgs e)
        {

            rb_Caro.Enabled = false;
            rb_Gomoku.Enabled = false;
            if (!_Co_Caro.San_Sang)
                return;
            if (_Co_Caro.Danh_Co(e.X, e.Y, grp))
            {
                if (_Co_Caro.Check_Game(Chedo))
                    _Co_Caro.Game_Over();
                else
                {
                    if (_Co_Caro.Che_Do_Choi == 2)
                    {
                        _Co_Caro.StartCom(grp);
                        if (_Co_Caro.Check_Game(Chedo))
                            _Co_Caro.Game_Over();
                    }
                }
            }
            lb_P1Win.Text = "Player1: " + _Co_Caro.diem1;
            lb_P2Win.Text = "Player2: " + _Co_Caro.diem2;
        }
        #endregion

        //P v P
        #region PvP
        private void bt_PVP_Click(object sender, EventArgs e)
        {
            PvP();
        }

        private void playerVsPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PvP();
        }
        private void PvP()
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn chơi mới không?", "Cờ Caro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                rb_Caro.Enabled = true;
                rb_Gomoku.Enabled = true;
                grp.Clear(pn_Banco.BackColor);
                Chedo = rb_Caro.Checked == true ? 0 : 1;
                _Co_Caro.StartPVP(grp);
                OF = 2;
                lb_P1Win.Text = "Player1: 0 ";
                lb_P2Win.Text = "Player2: 0 ";
            }
        }
        #endregion

        // P v C
        #region P v C
        private void playerVsComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PvC();
        }

        private void bt_PVC_Click(object sender, EventArgs e)
        {
            PvC();
        }
        private void PvC()
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn chơi mới không?", "Cờ Caro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                grp.Clear(pn_Banco.BackColor);
                _Co_Caro.StartPVC(grp);
                OF = 2;
                lb_P1Win.Text = "Player1: 0 ";
                lb_P2Win.Text = "Player2: 0 ";
            }
        }
        #endregion

        //Undo,Redo
        #region Undo, Redo
        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_Co_Caro.Che_Do_Choi == 1)
            {
                _Co_Caro.Undo(grp, pn_Banco.BackColor);
                if (_Co_Caro.Luot_Di == 1)
                    _Co_Caro.O--;
                else
                    _Co_Caro.X--;
            }
            else
            {
                _Co_Caro.Undo(grp, pn_Banco.BackColor);
                _Co_Caro.Undo(grp, pn_Banco.BackColor);
                _Co_Caro.O--;
                _Co_Caro.X--;
            }
        }
        private void redoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_Co_Caro.Che_Do_Choi == 1)
            {
                _Co_Caro.Redo(grp);
            }
            else
            {
                _Co_Caro.Redo(grp);
                _Co_Caro.Redo(grp);
            }
        }
        #endregion

        // Color
        #region Color
        private void colorOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                Co_Caro.penO = new Pen(dlgColor.Color, 2f);
                _Co_Caro.Ve_Ban_Co(grp);
                _Co_Caro.Ve_Lai_Quan_Co(grp);
            }
        }

        private void colorXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                Co_Caro.penX = new Pen(dlgColor.Color, 2f);
                _Co_Caro.Ve_Ban_Co(grp);
                _Co_Caro.Ve_Lai_Quan_Co(grp);
            }
        }

        private void colorLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                Co_Caro.pen = new Pen(dlgColor.Color);
                _Co_Caro.Ve_Ban_Co(grp);
            }
        }
        private void colorFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
                this.BackColor = dlgColor.Color;
        }

        private void colorChessbroadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
                pn_Banco.BackColor = dlgColor.Color;
        }
        #endregion

        // Exit game
        #region Exit game
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có muốn thoát không?", "Cờ caro", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
                this.Close();
        }
        private void bt_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có muốn thoát không?", "Cờ caro", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
                this.Close();
        }
        #endregion

        // About game
        #region About game
        private void aboutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            String Msg = "Game Cờ Caro trí tuệ nhân tạo" + Environment.NewLine + "Design by nhóm 4"
                + Environment.NewLine + "Ver 1.0";
            MessageBox.Show(Msg, "Thông tin game Cờ Caro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Msg = "Game gồm 2 luật chơi và 3 chế độ chơi chính:" + Environment.NewLine + "- Luật chơi:"
                + Environment.NewLine + "+ Luật Caro (Luật chặn 2 đầu): Bên nào tạo được các hàng, côt, đường chéo gồm 5 hoặc nhiều hơn 5 quân liên tiếp cùng loại mà không bị chặn ở 2 đầu sẽ chiến thắng (Tức là các hàng, cột, đường chéo dạng XOOOOOX hay OXXXXXO sẽ không thắng) "
                + Environment.NewLine + "+ Luật Gomoku (Tự do): Bên nào tạo được các hàng, côt, đường chéo gồm 5 hoặc nhiều hơn 5 quân liên tiếp cùng loại sẽ chiến thắng"
                + Environment.NewLine + "- Chế độ chơi:"
                + Environment.NewLine + "+ Player vs Player:"
                + Environment.NewLine + "+ Battle Fill:"
                + Environment.NewLine + "+ Player vs Computer:";
            MessageBox.Show(Msg, "Cách chơi game Cờ Caro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        //Che do choi
        #region Chedo
        private void rb_Gomoku_CheckedChanged(object sender, EventArgs e)
        {
            Chedo = 1;
        }
        private void rb_Caro_CheckedChanged(object sender, EventArgs e)
        {
            Chedo = 0;
        }
        #endregion
        private void mess_Chedo()
        {
            if (Chedo == 0)
            {
                MessageBox.Show("Caro");
            }
            else
            {
                MessageBox.Show("Gomoku");
            }
        }

        private void pn_Banco_Paint(object sender, PaintEventArgs e)
        {

        }
        //P v P BTF
        #region PvP BTF
        private void bt_BF_Click(object sender, EventArgs e)
        {
            BTF();
        }
        private void BTF()
        {
            
            DialogResult dlr = MessageBox.Show("Bạn có muốn chơi mới không?", "Cờ Caro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                rb_Caro.Enabled = true;
                rb_Gomoku.Enabled = true;
                grp.Clear(pn_Banco.BackColor);
                Chedo = rb_Caro.Checked == true ? 0 : 1;
                _Co_Caro.StartPVPBTF(grp);
                OF = 2;
                lb_P1Win.Text = "Player1: 0 " ;
                lb_P2Win.Text = "Player2: 0 " ;


            }
        }
        #endregion

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            lb_P1Win.Text = "Player1: " + _Co_Caro.diem1;
            lb_P2Win.Text = "Player2: " + _Co_Caro.diem2;
        }
    }
}