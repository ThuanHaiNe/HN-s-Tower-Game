using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HN_s_Tower_Game
{
   
    public partial class Form1 : Form
    {

        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _ButtonPlay_Click(object sender, EventArgs e)
        {
            //Mo form game play
            GamePlay gameplay = new GamePlay();
            gameplay.Show();
            this.Hide();

            






        }

        private void _btmDoKho_Click(object sender, EventArgs e)
        {
            Level open = new Level();
            open.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
