
namespace Tracker2000
{
    partial class UserInterface
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TaskInput = new System.Windows.Forms.MaskedTextBox();
            this.TaskOutput = new System.Windows.Forms.ListBox();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(148, 452);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(172, 28);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Добавить задачу";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAppend);
            // 
            // TaskInput
            // 
            this.TaskInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TaskInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskInput.Location = new System.Drawing.Point(326, 456);
            this.TaskInput.Name = "TaskInput";
            this.TaskInput.Size = new System.Drawing.Size(404, 20);
            this.TaskInput.TabIndex = 2;
            // 
            // TaskOutput
            // 
            this.TaskOutput.BackColor = System.Drawing.SystemColors.Control;
            this.TaskOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskOutput.FormattingEnabled = true;
            this.TaskOutput.ItemHeight = 24;
            this.TaskOutput.Location = new System.Drawing.Point(148, 52);
            this.TaskOutput.Name = "TaskOutput";
            this.TaskOutput.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.TaskOutput.Size = new System.Drawing.Size(760, 364);
            this.TaskOutput.TabIndex = 3;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(736, 452);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(172, 28);
            this.ButtonRemove.TabIndex = 4;
            this.ButtonRemove.Text = "Удалить";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonDelete);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.TaskOutput);
            this.Controls.Add(this.TaskInput);
            this.Controls.Add(this.ButtonAdd);
            this.Name = "UserInterface";
            this.Size = new System.Drawing.Size(996, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.MaskedTextBox TaskInput;
        private System.Windows.Forms.Button ButtonRemove;
        public System.Windows.Forms.ListBox TaskOutput;
    }
}
