
namespace LifeGame
{
    partial class GameGui
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridUI = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.generation_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gridUI
            // 
            this.gridUI.AutoSize = true;
            this.gridUI.Location = new System.Drawing.Point(142, 54);
            this.gridUI.Name = "gridUI";
            this.gridUI.Size = new System.Drawing.Size(525, 277);
            this.gridUI.TabIndex = 0;
            this.gridUI.TabStop = false;
            this.gridUI.Text = "groupBox1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // StopButton
            // 
            this.StopButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.StopButton.Location = new System.Drawing.Point(203, 362);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(101, 32);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "PAUSE";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.StartButton.Location = new System.Drawing.Point(351, 362);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 32);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.ClearButton.Location = new System.Drawing.Point(498, 362);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(97, 32);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // generation_text
            // 
            this.generation_text.Location = new System.Drawing.Point(531, 28);
            this.generation_text.Name = "generation_text";
            this.generation_text.Size = new System.Drawing.Size(136, 20);
            this.generation_text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(428, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поколение:";
            // 
            // GameGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generation_text);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.gridUI);
            this.Name = "GameGui";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad_UI);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gridUI;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox generation_text;
        private System.Windows.Forms.Label label1;
    }
}

