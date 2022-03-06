
namespace classwork0403
{
    partial class settings
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
            this.backgroundset = new System.Windows.Forms.GroupBox();
            this.foregroundset = new System.Windows.Forms.GroupBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.okbutton = new System.Windows.Forms.Button();
            this.lastforeground = new System.Windows.Forms.GroupBox();
            this.chooselabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundset.SuspendLayout();
            this.foregroundset.SuspendLayout();
            this.lastforeground.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundset
            // 
            this.backgroundset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backgroundset.Controls.Add(this.foregroundset);
            this.backgroundset.Location = new System.Drawing.Point(64, 27);
            this.backgroundset.Margin = new System.Windows.Forms.Padding(4);
            this.backgroundset.Name = "backgroundset";
            this.backgroundset.Padding = new System.Windows.Forms.Padding(4);
            this.backgroundset.Size = new System.Drawing.Size(751, 458);
            this.backgroundset.TabIndex = 0;
            this.backgroundset.TabStop = false;
            // 
            // foregroundset
            // 
            this.foregroundset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.foregroundset.Controls.Add(this.cancelbutton);
            this.foregroundset.Controls.Add(this.okbutton);
            this.foregroundset.Controls.Add(this.lastforeground);
            this.foregroundset.Controls.Add(this.label1);
            this.foregroundset.Location = new System.Drawing.Point(47, 35);
            this.foregroundset.Name = "foregroundset";
            this.foregroundset.Size = new System.Drawing.Size(602, 377);
            this.foregroundset.TabIndex = 0;
            this.foregroundset.TabStop = false;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelbutton.ForeColor = System.Drawing.Color.Violet;
            this.cancelbutton.Location = new System.Drawing.Point(335, 332);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(138, 39);
            this.cancelbutton.TabIndex = 2;
            this.cancelbutton.Text = "Отмена";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // okbutton
            // 
            this.okbutton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okbutton.ForeColor = System.Drawing.Color.Violet;
            this.okbutton.Location = new System.Drawing.Point(171, 332);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(86, 38);
            this.okbutton.TabIndex = 1;
            this.okbutton.Text = "Ок";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // lastforeground
            // 
            this.lastforeground.BackColor = System.Drawing.Color.Plum;
            this.lastforeground.Controls.Add(this.chooselabel);
            this.lastforeground.Controls.Add(this.radioButton1);
            this.lastforeground.Location = new System.Drawing.Point(113, 66);
            this.lastforeground.Name = "lastforeground";
            this.lastforeground.Size = new System.Drawing.Size(383, 237);
            this.lastforeground.TabIndex = 1;
            this.lastforeground.TabStop = false;
            // 
            // chooselabel
            // 
            this.chooselabel.AutoSize = true;
            this.chooselabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooselabel.ForeColor = System.Drawing.Color.Teal;
            this.chooselabel.Location = new System.Drawing.Point(52, 92);
            this.chooselabel.Name = "chooselabel";
            this.chooselabel.Size = new System.Drawing.Size(329, 31);
            this.chooselabel.TabIndex = 1;
            this.chooselabel.Text = "Использовать настройки";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.radioButton1.Location = new System.Drawing.Point(58, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(130, 56);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вкл/Выкл\r\n\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(68, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сделайте выбор";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.backgroundset);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "settings";
            this.Text = "settings";
            this.backgroundset.ResumeLayout(false);
            this.foregroundset.ResumeLayout(false);
            this.foregroundset.PerformLayout();
            this.lastforeground.ResumeLayout(false);
            this.lastforeground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox backgroundset;
        private System.Windows.Forms.GroupBox foregroundset;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.GroupBox lastforeground;
        private System.Windows.Forms.Label chooselabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}