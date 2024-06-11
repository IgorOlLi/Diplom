namespace Diplom
{
    partial class BaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьГолосованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьМашинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проголосуйте за";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Проголосовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 240);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьГолосованиеToolStripMenuItem,
            this.добавитьМашинуToolStripMenuItem,
            this.посмотретьРезультатыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьГолосованиеToolStripMenuItem
            // 
            this.добавитьГолосованиеToolStripMenuItem.Name = "добавитьГолосованиеToolStripMenuItem";
            this.добавитьГолосованиеToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.добавитьГолосованиеToolStripMenuItem.Text = "Добавить голосование";
            this.добавитьГолосованиеToolStripMenuItem.Click += new System.EventHandler(this.изменитьГолосованиеToolStripMenuItem_Click);
            // 
            // добавитьМашинуToolStripMenuItem
            // 
            this.добавитьМашинуToolStripMenuItem.Name = "добавитьМашинуToolStripMenuItem";
            this.добавитьМашинуToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.добавитьМашинуToolStripMenuItem.Text = "Добавить машину";
            this.добавитьМашинуToolStripMenuItem.Click += new System.EventHandler(this.добавитьМашинуToolStripMenuItem_Click);
            // 
            // посмотретьРезультатыToolStripMenuItem
            // 
            this.посмотретьРезультатыToolStripMenuItem.Name = "посмотретьРезультатыToolStripMenuItem";
            this.посмотретьРезультатыToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.посмотретьРезультатыToolStripMenuItem.Text = "Посмотреть результаты";
            this.посмотретьРезультатыToolStripMenuItem.Click += new System.EventHandler(this.посмотретьРезультатыToolStripMenuItem_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(12, 415);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(321, 23);
            this.hideButton.TabIndex = 8;
            this.hideButton.Text = "Перейти в рабочий режим";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(339, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 373);
            this.panel1.TabIndex = 9;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Base_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьГолосованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьМашинуToolStripMenuItem;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem посмотретьРезультатыToolStripMenuItem;
    }
}

