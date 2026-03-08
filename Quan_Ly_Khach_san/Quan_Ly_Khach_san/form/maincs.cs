using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms.DataVisualization.Charting;

namespace Quan_Ly_Khach_san.form
{
    public partial class frmMain : Form
    {
        Random rd = new Random();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 101; i <= 200; i++)
            {
                CreateRoom(i);
            }
           
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picname.Width, pictureBox1.Height);
            picname.Region = new Region(path);
        }

        //tao bieu do
       
       
        private int tong()
        {
            return flpl.Controls.Count;
        }
        private void CreateRoom(int roomNumber)
        {
            Panel roomPanel = new Panel();
            roomPanel.Width = 120;
            roomPanel.Height = 90;
            roomPanel.BorderStyle = BorderStyle.FixedSingle;
            roomPanel.Margin = new Padding(10);

            Label status = new Label();
            status.ForeColor = Color.Black;
            status.Font = new Font("Arial", 8, FontStyle.Bold);
            status.Location = new Point(5, 5);


            // Random trạng thái phòng

            int state = rd.Next(1, 4);

            if (state == 1)
            {
                roomPanel.BackColor = Color.LightGreen;
                status.Text = "CLEAN";
                status.ForeColor = Color.Green;
            }
            else if (state == 2)
            {
                roomPanel.BackColor = Color.LightCoral;
                status.Text = "DIRTY";
                status.ForeColor = Color.Red;
            }
            else
            {
                roomPanel.BackColor = Color.LightGray;
                status.Text = "BOOKED";
                status.ForeColor = Color.Black;
            }

            Label number = new Label();
            number.Text = roomNumber.ToString();
            number.Font = new Font("Arial", 16, FontStyle.Bold);
            number.AutoSize = true;
            number.Location = new Point(35, 35);

            roomPanel.Controls.Add(status);
            roomPanel.Controls.Add(number);

            roomPanel.Tag = roomNumber;
            roomPanel.Cursor = Cursors.Hand;
            roomPanel.Click += Room_Click;

            flpl.Controls.Add(roomPanel);
        }
        private void Room_Click(object sender, EventArgs e)
        {
            Panel room = sender as Panel;
            int roomNumber = (int)room.Tag;

            frmDatPhong f = new frmDatPhong(roomNumber);
            f.Show();
        }

        private void flpl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbphong_Click(object sender, EventArgs e)
        {
        frmPhong frmPhong = new frmPhong();
            frmPhong.ShowDialog();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbdash_Click(object sender, EventArgs e)
        {
            lbthongke.Visible = false;
            lbflex.Text = "DashBoard";
            txttimkiem.Visible = false;
            cbtimkiem.Visible = false;
           
            lbflex.Text = "Dashboard";

          

        }

       
    }
}
