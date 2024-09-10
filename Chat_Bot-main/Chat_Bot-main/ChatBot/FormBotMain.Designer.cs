
/// @author Kyvukin N.D
/// Реализация чат-бота
namespace ChatBot
{
    partial class FormBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBot));
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Send = new System.Windows.Forms.Button();
            this.ToolStripMenuItem_SaveInFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_WriteFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_CleanDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_author = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_instruction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(37, 32);
            this.textBox_Answer.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Answer.Multiline = true;
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.ReadOnly = true;
            this.textBox_Answer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Answer.Size = new System.Drawing.Size(497, 228);
            this.textBox_Answer.TabIndex = 0;
            this.textBox_Answer.TabStop = false;
            // 
            // textBox_Question
            // 
            this.textBox_Question.Location = new System.Drawing.Point(37, 288);
            this.textBox_Question.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(395, 22);
            this.textBox_Question.TabIndex = 1;
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(570, 30);
            this.menuStrip_main.TabIndex = 3;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_SaveInFile,
            this.ToolStripMenuItem_WriteFromFile,
            this.ToolStripMenuItem_CleanDialog});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_author,
            this.ToolStripMenuItem_instruction});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // button_Send
            // 
            this.button_Send.AutoSize = true;
            this.button_Send.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_Send.BackgroundImage = global::ChatBot.Properties.Resources.image_send;
            this.button_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Send.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Send.Location = new System.Drawing.Point(453, 267);
            this.button_Send.Margin = new System.Windows.Forms.Padding(4);
            this.button_Send.Name = "button_Send";
            this.button_Send.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button_Send.Size = new System.Drawing.Size(81, 61);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = false;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // ToolStripMenuItem_SaveInFile
            // 
            this.ToolStripMenuItem_SaveInFile.Image = global::ChatBot.Properties.Resources.icons8_сохранить_как_48;
            this.ToolStripMenuItem_SaveInFile.Name = "ToolStripMenuItem_SaveInFile";
            this.ToolStripMenuItem_SaveInFile.Size = new System.Drawing.Size(265, 26);
            this.ToolStripMenuItem_SaveInFile.Text = "Сохранить историю чата";
            this.ToolStripMenuItem_SaveInFile.Click += new System.EventHandler(this.сохранитьИсториюЧатаToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_WriteFromFile
            // 
            this.ToolStripMenuItem_WriteFromFile.Image = global::ChatBot.Properties.Resources.icons8_загрузить_64;
            this.ToolStripMenuItem_WriteFromFile.Name = "ToolStripMenuItem_WriteFromFile";
            this.ToolStripMenuItem_WriteFromFile.Size = new System.Drawing.Size(265, 26);
            this.ToolStripMenuItem_WriteFromFile.Text = "Загрузить чат из файла";
            this.ToolStripMenuItem_WriteFromFile.Click += new System.EventHandler(this.загрузитьЧатИзФайлаToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_CleanDialog
            // 
            this.ToolStripMenuItem_CleanDialog.Image = global::ChatBot.Properties.Resources.icons8_корзина_48;
            this.ToolStripMenuItem_CleanDialog.Name = "ToolStripMenuItem_CleanDialog";
            this.ToolStripMenuItem_CleanDialog.Size = new System.Drawing.Size(265, 26);
            this.ToolStripMenuItem_CleanDialog.Text = "Очистить чат";
            this.ToolStripMenuItem_CleanDialog.Click += new System.EventHandler(this.очиститьЧатToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_author
            // 
            this.ToolStripMenuItem_author.Image = global::ChatBot.Properties.Resources.icons8_авторские_права_64;
            this.ToolStripMenuItem_author.Name = "ToolStripMenuItem_author";
            this.ToolStripMenuItem_author.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_author.Text = "Об авторе";
            this.ToolStripMenuItem_author.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_instruction
            // 
            this.ToolStripMenuItem_instruction.Image = global::ChatBot.Properties.Resources.icons8_руководство_пользователя_64;
            this.ToolStripMenuItem_instruction.Name = "ToolStripMenuItem_instruction";
            this.ToolStripMenuItem_instruction.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_instruction.Text = "Инструкция";
            this.ToolStripMenuItem_instruction.Click += new System.EventHandler(this.инструкцияToolStripMenuItem_Click);
            // 
            // FormBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 341);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Question);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.menuStrip_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_main;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBot";
            this.Text = "Чат";
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_author;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveInFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_WriteFromFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CleanDialog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_instruction;
    }
}

