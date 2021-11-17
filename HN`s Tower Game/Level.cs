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
    public partial class Level : Form
    {
       GamePlay _gameplay = new GamePlay();
        
        public Level()
        {
            InitializeComponent();
            
        }
        int load3()
        {
            return 3;
        }
         
        private void _Easy_Click(object sender, EventArgs e)
        {
            _gameplay.NumOfDisks = 3;

            this.Close();


        }

        private void _Normal_Click(object sender, EventArgs e)
        {


            _gameplay.NumOfDisks = 4;
            this.Close();
        }

        private void _Hard_Click(object sender, EventArgs e)
        {
            _gameplay.NumOfDisks = 5;
            this.Close();
        }
    }
}
