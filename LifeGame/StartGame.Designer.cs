namespace LifeGame
{
    partial class StartGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.CellBox = new System.Windows.Forms.ComboBox();
            this.GridBox = new System.Windows.Forms.ComboBox();
            this.Grid_size = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(170, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CellBox
            // 
            this.CellBox.FormattingEnabled = true;
            this.CellBox.Location = new System.Drawing.Point(202, 124);
            this.CellBox.Name = "CellBox";
            this.CellBox.Size = new System.Drawing.Size(121, 21);
            this.CellBox.TabIndex = 1;
            // 
            // GridBox
            // 
            this.GridBox.FormattingEnabled = true;
            this.GridBox.Location = new System.Drawing.Point(202, 191);
            this.GridBox.Name = "GridBox";
            this.GridBox.Size = new System.Drawing.Size(121, 21);
            this.GridBox.TabIndex = 2;
            // 
            // Grid_size
            // 
            this.Grid_size.AutoSize = true;
            this.Grid_size.ForeColor = System.Drawing.Color.AliceBlue;
            this.Grid_size.Location = new System.Drawing.Point(199, 93);
            this.Grid_size.Name = "Grid_size";
            this.Grid_size.Size = new System.Drawing.Size(84, 13);
            this.Grid_size.TabIndex = 4;
            this.Grid_size.Text = "Величина мира";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(199, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Величина клетки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(199, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Частота обновления";
            // 
            // TimeBox
            // 
            this.TimeBox.FormatString = "N2";
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Location = new System.Drawing.Point(202, 273);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(121, 21);
            this.TimeBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(102, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "GAME OF LIFE";
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid_size);
            this.Controls.Add(this.GridBox);
            this.Controls.Add(this.CellBox);
            this.Controls.Add(this.button1);
            this.Name = "StartGame";
            this.Text = "StartGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CellBox;
        private System.Windows.Forms.ComboBox GridBox;
        private System.Windows.Forms.Label Grid_size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TimeBox;
        private System.Windows.Forms.Label label1;
    }
}