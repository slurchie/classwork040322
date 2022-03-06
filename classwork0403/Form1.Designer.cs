
namespace classwork0403
{
    partial class Form1
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
            this.firstvkladka = new System.Windows.Forms.TabControl();
            this.firstvkaldka = new System.Windows.Forms.TabPage();
            this.settingsButton = new System.Windows.Forms.Button();
            this.linkGit = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.backwall = new System.Windows.Forms.GroupBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.desText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.famText = new System.Windows.Forms.TextBox();
            this.desLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.famLabel = new System.Windows.Forms.Label();
            this.secondVkladka = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.DataGridView();
            this.famColomn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColomn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desColomn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdVkladka = new System.Windows.Forms.TabPage();
            this.firstvkladka.SuspendLayout();
            this.firstvkaldka.SuspendLayout();
            this.backwall.SuspendLayout();
            this.secondVkladka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // firstvkladka
            // 
            this.firstvkladka.Controls.Add(this.firstvkaldka);
            this.firstvkladka.Controls.Add(this.secondVkladka);
            this.firstvkladka.Controls.Add(this.thirdVkladka);
            this.firstvkladka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstvkladka.Location = new System.Drawing.Point(0, 0);
            this.firstvkladka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstvkladka.Name = "firstvkladka";
            this.firstvkladka.SelectedIndex = 0;
            this.firstvkladka.Size = new System.Drawing.Size(800, 450);
            this.firstvkladka.TabIndex = 0;
            this.firstvkladka.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.firstvkladka_MouseDoubleClick);
            // 
            // firstvkaldka
            // 
            this.firstvkaldka.BackColor = System.Drawing.Color.Plum;
            this.firstvkaldka.Controls.Add(this.settingsButton);
            this.firstvkaldka.Controls.Add(this.linkGit);
            this.firstvkaldka.Controls.Add(this.label1);
            this.firstvkaldka.Controls.Add(this.backwall);
            this.firstvkaldka.Location = new System.Drawing.Point(4, 25);
            this.firstvkaldka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstvkaldka.Name = "firstvkaldka";
            this.firstvkaldka.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstvkaldka.Size = new System.Drawing.Size(792, 421);
            this.firstvkaldka.TabIndex = 0;
            this.firstvkaldka.Text = "Вкладка 1";
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.LightBlue;
            this.settingsButton.Location = new System.Drawing.Point(631, 380);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(100, 28);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.settingsButton_MouseClick);
            // 
            // linkGit
            // 
            this.linkGit.AutoSize = true;
            this.linkGit.Location = new System.Drawing.Point(233, 359);
            this.linkGit.Name = "linkGit";
            this.linkGit.Size = new System.Drawing.Size(365, 17);
            this.linkGit.TabIndex = 8;
            this.linkGit.TabStop = true;
            this.linkGit.Text = "https://www.youtube.com/watch?v=wNhrsZrOWoQ&t=783s";
            this.linkGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGit_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ссылка на гит:";
            // 
            // backwall
            // 
            this.backwall.BackColor = System.Drawing.Color.Violet;
            this.backwall.Controls.Add(this.savebutton);
            this.backwall.Controls.Add(this.desText);
            this.backwall.Controls.Add(this.nameText);
            this.backwall.Controls.Add(this.famText);
            this.backwall.Controls.Add(this.desLabel);
            this.backwall.Controls.Add(this.nameLabel);
            this.backwall.Controls.Add(this.famLabel);
            this.backwall.Location = new System.Drawing.Point(20, 6);
            this.backwall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backwall.Name = "backwall";
            this.backwall.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backwall.Size = new System.Drawing.Size(699, 313);
            this.backwall.TabIndex = 0;
            this.backwall.TabStop = false;
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.savebutton.Location = new System.Drawing.Point(419, 254);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(117, 34);
            this.savebutton.TabIndex = 6;
            this.savebutton.Text = "Сохранить";
            this.savebutton.UseVisualStyleBackColor = false;
           
            // 
            // desText
            // 
            this.desText.Location = new System.Drawing.Point(185, 146);
            this.desText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desText.Name = "desText";
            this.desText.Size = new System.Drawing.Size(100, 22);
            this.desText.TabIndex = 5;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(185, 96);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 22);
            this.nameText.TabIndex = 4;
            // 
            // famText
            // 
            this.famText.Location = new System.Drawing.Point(185, 47);
            this.famText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.famText.Name = "famText";
            this.famText.Size = new System.Drawing.Size(100, 22);
            this.famText.TabIndex = 3;
            // 
            // desLabel
            // 
            this.desLabel.AutoSize = true;
            this.desLabel.Location = new System.Drawing.Point(51, 151);
            this.desLabel.Name = "desLabel";
            this.desLabel.Size = new System.Drawing.Size(74, 17);
            this.desLabel.TabIndex = 2;
            this.desLabel.Text = "Описание";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 98);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            // 
            // famLabel
            // 
            this.famLabel.AutoSize = true;
            this.famLabel.Location = new System.Drawing.Point(51, 52);
            this.famLabel.Name = "famLabel";
            this.famLabel.Size = new System.Drawing.Size(70, 17);
            this.famLabel.TabIndex = 0;
            this.famLabel.Text = "Фамилия";
            // 
            // secondVkladka
            // 
            this.secondVkladka.Controls.Add(this.tabInfo);
            this.secondVkladka.Location = new System.Drawing.Point(4, 25);
            this.secondVkladka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondVkladka.Name = "secondVkladka";
            this.secondVkladka.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondVkladka.Size = new System.Drawing.Size(792, 421);
            this.secondVkladka.TabIndex = 1;
            this.secondVkladka.Text = "Вкладка 2";
            this.secondVkladka.UseVisualStyleBackColor = true;
            // 
            // tabInfo
            // 
            this.tabInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.famColomn,
            this.nameColomn,
            this.desColomn});
            this.tabInfo.GridColor = System.Drawing.Color.LightCoral;
            this.tabInfo.Location = new System.Drawing.Point(11, 10);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.RowHeadersWidth = 51;
            this.tabInfo.Size = new System.Drawing.Size(459, 185);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabInfo_Load);
            // 
            // famColomn
            // 
            this.famColomn.Frozen = true;
            this.famColomn.HeaderText = "Фамилия";
            this.famColomn.MinimumWidth = 6;
            this.famColomn.Name = "famColomn";
            this.famColomn.ReadOnly = true;
            this.famColomn.Width = 125;
            // 
            // nameColomn
            // 
            this.nameColomn.Frozen = true;
            this.nameColomn.HeaderText = "Имя";
            this.nameColomn.MinimumWidth = 6;
            this.nameColomn.Name = "nameColomn";
            this.nameColomn.ReadOnly = true;
            this.nameColomn.Width = 125;
            // 
            // desColomn
            // 
            this.desColomn.Frozen = true;
            this.desColomn.HeaderText = "Описание";
            this.desColomn.MinimumWidth = 6;
            this.desColomn.Name = "desColomn";
            this.desColomn.ReadOnly = true;
            this.desColomn.Width = 125;
            // 
            // thirdVkladka
            // 
            this.thirdVkladka.Location = new System.Drawing.Point(4, 25);
            this.thirdVkladka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thirdVkladka.Name = "thirdVkladka";
            this.thirdVkladka.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thirdVkladka.Size = new System.Drawing.Size(792, 421);
            this.thirdVkladka.TabIndex = 2;
            this.thirdVkladka.Text = "+";
            this.thirdVkladka.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.firstvkladka);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.firstvkladka.ResumeLayout(false);
            this.firstvkaldka.ResumeLayout(false);
            this.firstvkaldka.PerformLayout();
            this.backwall.ResumeLayout(false);
            this.backwall.PerformLayout();
            this.secondVkladka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl firstvkladka;
        private System.Windows.Forms.TabPage firstvkaldka;
        private System.Windows.Forms.TabPage secondVkladka;
        private System.Windows.Forms.TabPage thirdVkladka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox backwall;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label desLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label famLabel;
        private System.Windows.Forms.LinkLabel linkGit;
        private System.Windows.Forms.DataGridView tabInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn famColomn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColomn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desColomn;
        private System.Windows.Forms.Button settingsButton;
        public System.Windows.Forms.TextBox desText;
        public System.Windows.Forms.TextBox nameText;
        public System.Windows.Forms.TextBox famText;
    }
}

