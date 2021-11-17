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
    
    public partial class GamePlay : Form
    {
        public int NumOfDisks = 3;
        TimeSpan time;
        private int Sobuoc = 0;
        PictureBox[] disks;
        Stack<PictureBox> disksA, disksB, disksC, FirstClick, SecondClick;
        const int FirstDisks_Y = 338, FirstDisks_X = 34, DisksHeight = 30;

        public GamePlay()
        {
            InitializeComponent();
            disks = new PictureBox[] { pic1, pic2, pic3, pic4, pic5 };
            _Tru_1.Tag = disksA = new Stack<PictureBox>();
            _Tru_2.Tag = disksB = new Stack<PictureBox>();
            _Tru_3.Tag = disksC = new Stack<PictureBox>();

        }
        void LoadSobuoc(int sobuoc)
        {
            _StepScore.Text = " " + Sobuoc;

        }

        private void StepLabel_Click(object sender, EventArgs e)
        {

        }





        private void _Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        

        private void _Tru_Click(object sender, EventArgs e)
        {
            Message.Text = "\n";
            PictureBox clickTru = (PictureBox)sender;
            Stack<PictureBox> disksOfClickTru = (Stack<PictureBox>)clickTru.Tag;

            if (FirstClick == null)
            {
                if (disksOfClickTru.Count == 0) return;
                FirstClick = disksOfClickTru;
                clickTru.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (SecondClick == null)
            {
                if (disksOfClickTru == FirstClick)
                {
                    FirstClick = null;
                    clickTru.BorderStyle = BorderStyle.None;
                    return;

                }
                SecondClick = disksOfClickTru;
                ProcessMovingDisk(clickTru);

            }
        }
        
        private void ProcessMovingDisk(PictureBox ClickTru)
        {
            if (SecondClick.Count == 0)
            {
                MoveDisk(new Point(ClickTru.Location.X + FirstDisks_X, FirstDisks_Y));

            }
            else
            {
                PictureBox firstTop = FirstClick.Peek();
                PictureBox seconTop = SecondClick.Peek();
                if (int.Parse(firstTop.Tag.ToString()) < int.Parse(seconTop.Tag.ToString()))
                    MoveDisk(new Point(seconTop.Location.X, seconTop.Location.Y - DisksHeight));
                else
                {
                    SecondClick = null;
                }
            }
        }
        public void MoveDisk(Point point)
        {
            PictureBox firsttopdisk = FirstClick.Pop();
            firsttopdisk.Location = point;
            SecondClick.Push(firsttopdisk);

            Message.Text = "\n Di chuyển thành công !";
            Sobuoc++;
            LoadSobuoc(Sobuoc);
            FirstClick = SecondClick = null;
            _Tru_1.BorderStyle = _Tru_2.BorderStyle = _Tru_3.BorderStyle = BorderStyle.None;
            if (disksC.Count == NumOfDisks)
            {
                _DauHang.PerformClick();
                Message.Text = "\nChúc Mừng Bạn Đã Hoàn Thành !";
                MessageBox.Show("Chúc Mừng Bạn Đã Hoàn Thành !", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Tru_1.Enabled = false;
                _Tru_2.Enabled = false;
                _Tru_3.Enabled = false;
            }
            if (disksB.Count == NumOfDisks)
            {
                _DauHang.PerformClick();
                Message.Text = "\nChúc Mừng Bạn Đã Hoàn Thành !";
                MessageBox.Show("Chúc Mừng Bạn Đã Hoàn Thành !", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Tru_1.Enabled = false;
                _Tru_2.Enabled = false;
                _Tru_3.Enabled = false;
            }

        }

        private void picDisk_Click(object sender, EventArgs e)
        {
            PictureBox clickDisk = (PictureBox)sender;
            if (disksA.Contains(clickDisk))
            {
                _Tru_Click(_Tru_1, new EventArgs());
               
            }
            else if (disksB.Contains(clickDisk))
            {
                _Tru_Click(_Tru_2, new EventArgs());
            }
            else if (disksC.Contains(clickDisk))
            {
                _Tru_Click(_Tru_3, new EventArgs());
            }
        }

        private void _Luatchoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Luật chơi: \n- Mỗi lần di chỉ được di chuyển 1 đĩa trên cùng của cọc.\n - Đĩa nằm trên phải nhỏ hơn đĩa nằm dưới.",
                            "Luật Chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void _ChoiLai_Click(object sender, EventArgs e)
        {
            _Tru_1.Enabled = true;
            _Tru_2.Enabled = true;
            _Tru_3.Enabled = true;

            CountTime.Stop();
            foreach (PictureBox disks in disks)
            {
                disks.Visible = false;
            }
            time = new TimeSpan(0);
            lblTime.Text = "Thời Gian: 00:00:00";
            Sobuoc = 0;
            LoadSobuoc(Sobuoc);
            Message.Text = " ";
            disksA.Clear(); disksB.Clear(); disksC.Clear();
            FirstClick = SecondClick = null;
            Form1 _form = new Form1();
            int x = _Tru_1.Location.X + FirstDisks_X;
            int y = FirstDisks_Y;
            for(int i = NumOfDisks - 1; i >= 0 ;i--)
            {
                disks[i].Location = new Point(x, y);
                disks[i].Visible = true;
                disksA.Push(disks[i]);
                y -= DisksHeight;
            }
            CountTime.Start();

        }

        private void _TrangChu_Click(object sender, EventArgs e)
        {
            Sobuoc = 0;
            LoadSobuoc(Sobuoc);
            Message.Text = " ";

            Form1 _form1 = new Form1();
            _form1.Show();
            this.Close();
        }
        private void CountTime_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            lblTime.Text = string.Format("Thời Gian: {0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);

        }
        private void lblTime_Click(object sender, EventArgs e)
        {
           
        }

        private void _DauHang_Click(object sender, EventArgs e)
        {
            CountTime.Stop();
            _ChoiLai.Text = "Chơi Lại";

        }
    }
}
