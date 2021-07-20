
namespace My_Calendar
{
    partial class AddEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbHour = new System.Windows.Forms.Label();
            this.btnMinDown = new System.Windows.Forms.Button();
            this.btnHourDown = new System.Windows.Forms.Button();
            this.btnMinUp = new System.Windows.Forms.Button();
            this.btnHourUp = new System.Windows.Forms.Button();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbMin);
            this.panel1.Controls.Add(this.lbHour);
            this.panel1.Location = new System.Drawing.Point(17, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 75);
            this.label1.TabIndex = 13;
            this.label1.Text = ":";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.BackColor = System.Drawing.Color.White;
            this.lbMin.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(171, 1);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(98, 75);
            this.lbMin.TabIndex = 8;
            this.lbMin.Text = "01";
            this.lbMin.Click += new System.EventHandler(this.lbMin_Click);
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.BackColor = System.Drawing.Color.LightGray;
            this.lbHour.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.Location = new System.Drawing.Point(27, 1);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(98, 75);
            this.lbHour.TabIndex = 7;
            this.lbHour.Text = "12";
            this.lbHour.Click += new System.EventHandler(this.lbHour_Click);
            // 
            // btnMinDown
            // 
            this.btnMinDown.FlatAppearance.BorderSize = 0;
            this.btnMinDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinDown.Location = new System.Drawing.Point(196, 174);
            this.btnMinDown.Name = "btnMinDown";
            this.btnMinDown.Size = new System.Drawing.Size(75, 27);
            this.btnMinDown.TabIndex = 12;
            this.btnMinDown.Text = "button4";
            this.btnMinDown.UseVisualStyleBackColor = true;
            this.btnMinDown.Click += new System.EventHandler(this.btnMinDown_Click);
            // 
            // btnHourDown
            // 
            this.btnHourDown.FlatAppearance.BorderSize = 0;
            this.btnHourDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHourDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHourDown.Location = new System.Drawing.Point(52, 176);
            this.btnHourDown.Name = "btnHourDown";
            this.btnHourDown.Size = new System.Drawing.Size(75, 27);
            this.btnHourDown.TabIndex = 11;
            this.btnHourDown.Text = "button3";
            this.btnHourDown.UseVisualStyleBackColor = true;
            this.btnHourDown.Click += new System.EventHandler(this.btnHourDown_Click);
            // 
            // btnMinUp
            // 
            this.btnMinUp.FlatAppearance.BorderSize = 0;
            this.btnMinUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinUp.Location = new System.Drawing.Point(196, 56);
            this.btnMinUp.Name = "btnMinUp";
            this.btnMinUp.Size = new System.Drawing.Size(75, 27);
            this.btnMinUp.TabIndex = 10;
            this.btnMinUp.Text = "button2";
            this.btnMinUp.UseVisualStyleBackColor = true;
            this.btnMinUp.Click += new System.EventHandler(this.btnMinUp_Click);
            // 
            // btnHourUp
            // 
            this.btnHourUp.FlatAppearance.BorderSize = 0;
            this.btnHourUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHourUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHourUp.Location = new System.Drawing.Point(52, 56);
            this.btnHourUp.Name = "btnHourUp";
            this.btnHourUp.Size = new System.Drawing.Size(75, 27);
            this.btnHourUp.TabIndex = 9;
            this.btnHourUp.Text = "button1";
            this.btnHourUp.UseVisualStyleBackColor = true;
            this.btnHourUp.Click += new System.EventHandler(this.btnHourUp_Click);
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.Location = new System.Drawing.Point(17, 298);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(112, 30);
            this.btnSaveEvent.TabIndex = 1;
            this.btnSaveEvent.Text = "Save";
            this.btnSaveEvent.UseVisualStyleBackColor = true;
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(17, 243);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(304, 20);
            this.tbDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add new event";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(14, 227);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 13;
            this.lbDescription.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 30);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHourDown);
            this.Controls.Add(this.btnMinDown);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.btnSaveEvent);
            this.Controls.Add(this.btnMinUp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHourUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEvent_FormClosing);
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinDown;
        private System.Windows.Forms.Button btnHourDown;
        private System.Windows.Forms.Button btnMinUp;
        private System.Windows.Forms.Button btnHourUp;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button btnCancel;
    }
}