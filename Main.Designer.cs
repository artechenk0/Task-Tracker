namespace Tracker2000
{
    partial class Main
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.serviceController2 = new System.ServiceProcess.ServiceController();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonImportant = new System.Windows.Forms.Button();
            this.buttonMounth = new System.Windows.Forms.Button();
            this.buttonWeek = new System.Windows.Forms.Button();
            this.buttonYesterday = new System.Windows.Forms.Button();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.MenuPanel.Controls.Add(this.InfoPanel);
            this.MenuPanel.Controls.Add(this.buttonImportant);
            this.MenuPanel.Controls.Add(this.buttonMounth);
            this.MenuPanel.Controls.Add(this.buttonWeek);
            this.MenuPanel.Controls.Add(this.buttonYesterday);
            this.MenuPanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.MenuPanel.Location = new System.Drawing.Point(0, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(223, 581);
            this.MenuPanel.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.button1);
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(230, 70);
            this.InfoPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(40, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "TRACKER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1147, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonImportant
            // 
            this.buttonImportant.Location = new System.Drawing.Point(15, 273);
            this.buttonImportant.Name = "buttonImportant";
            this.buttonImportant.Size = new System.Drawing.Size(191, 32);
            this.buttonImportant.TabIndex = 3;
            this.buttonImportant.Text = "Важное";
            this.buttonImportant.UseVisualStyleBackColor = true;
            this.buttonImportant.Click += new System.EventHandler(this.ButtonImportant);
            // 
            // buttonMounth
            // 
            this.buttonMounth.Location = new System.Drawing.Point(15, 235);
            this.buttonMounth.Name = "buttonMounth";
            this.buttonMounth.Size = new System.Drawing.Size(191, 32);
            this.buttonMounth.TabIndex = 2;
            this.buttonMounth.Text = "Месяц";
            this.buttonMounth.UseVisualStyleBackColor = true;
            this.buttonMounth.Click += new System.EventHandler(this.ButtonMounth);
            // 
            // buttonWeek
            // 
            this.buttonWeek.Location = new System.Drawing.Point(15, 197);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Size = new System.Drawing.Size(191, 32);
            this.buttonWeek.TabIndex = 1;
            this.buttonWeek.Text = "Неделя";
            this.buttonWeek.UseVisualStyleBackColor = true;
            this.buttonWeek.Click += new System.EventHandler(this.ButtonWeek);
            // 
            // buttonYesterday
            // 
            this.buttonYesterday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonYesterday.Location = new System.Drawing.Point(15, 159);
            this.buttonYesterday.Name = "buttonYesterday";
            this.buttonYesterday.Size = new System.Drawing.Size(191, 32);
            this.buttonYesterday.TabIndex = 0;
            this.buttonYesterday.Text = "Сегодня";
            this.buttonYesterday.UseVisualStyleBackColor = true;
            this.buttonYesterday.Click += new System.EventHandler(this.ButtonYesterday);
            // 
            // DataPanel
            // 
            this.DataPanel.Location = new System.Drawing.Point(220, 75);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(1018, 522);
            this.DataPanel.TabIndex = 1;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.ExitButton);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Location = new System.Drawing.Point(220, 2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1018, 70);
            this.panelTitle.TabIndex = 4;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(906, 21);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 29);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exitbutton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(469, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "TASKS";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 573);
            this.ControlBox = false;
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Tracker";
            this.MenuPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.ServiceProcess.ServiceController serviceController2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button buttonImportant;
        private System.Windows.Forms.Button buttonMounth;
        private System.Windows.Forms.Button buttonWeek;
        private System.Windows.Forms.Button buttonYesterday;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
    }
}

