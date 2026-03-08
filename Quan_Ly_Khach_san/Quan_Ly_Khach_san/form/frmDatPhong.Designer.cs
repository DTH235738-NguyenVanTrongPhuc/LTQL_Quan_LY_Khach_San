namespace Quan_Ly_Khach_san.form
{
    partial class frmDatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelRoom = new Label();
            SuspendLayout();
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Location = new Point(12, 9);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(50, 20);
            labelRoom.TabIndex = 0;
            labelRoom.Text = "label1";
            // 
            // frmDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRoom);
            Name = "frmDatPhong";
            Text = "frmDatPhong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRoom;
    }
}