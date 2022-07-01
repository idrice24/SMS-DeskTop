
namespace SMS
{
    partial class Teacher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listOfTeach = new System.Windows.Forms.Button();
            this.addTeach = new System.Windows.Forms.Button();
            this.dashboardform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listOfTeach);
            this.panel1.Controls.Add(this.addTeach);
            this.panel1.Controls.Add(this.dashboardform);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 509);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOfTeach
            // 
            this.listOfTeach.Location = new System.Drawing.Point(38, 198);
            this.listOfTeach.Name = "listOfTeach";
            this.listOfTeach.Size = new System.Drawing.Size(128, 23);
            this.listOfTeach.TabIndex = 15;
            this.listOfTeach.Text = "List of Teach";
            this.listOfTeach.UseVisualStyleBackColor = true;
            this.listOfTeach.Click += new System.EventHandler(this.button3_Click);
            // 
            // addTeach
            // 
            this.addTeach.Location = new System.Drawing.Point(38, 135);
            this.addTeach.Name = "addTeach";
            this.addTeach.Size = new System.Drawing.Size(128, 23);
            this.addTeach.TabIndex = 14;
            this.addTeach.Text = "Add Teach";
            this.addTeach.UseVisualStyleBackColor = true;
            this.addTeach.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashboardform
            // 
            this.dashboardform.Location = new System.Drawing.Point(38, 83);
            this.dashboardform.Name = "dashboardform";
            this.dashboardform.Size = new System.Drawing.Size(128, 23);
            this.dashboardform.TabIndex = 13;
            this.dashboardform.Text = "DASHBOARD";
            this.dashboardform.UseVisualStyleBackColor = true;
            this.dashboardform.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "MANAGE. TEACHERS";
            // 
            // mainpanel
            // 
            this.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainpanel.Controls.Add(this.label2);
            this.mainpanel.Location = new System.Drawing.Point(198, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(888, 509);
            this.mainpanel.TabIndex = 1;
            this.mainpanel.TabStop = true;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(127, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "welcome to teachers management";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1089, 513);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Name = "Teacher";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TEACHER";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button listOfTeach;
        private System.Windows.Forms.Button addTeach;
        private System.Windows.Forms.Button dashboardform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}