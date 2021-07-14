
namespace TestEx
{
    partial class AddForm
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
            this.AF_SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DC_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Country_textBox = new System.Windows.Forms.TextBox();
            this.AF_UndoBtn = new System.Windows.Forms.Button();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AF_SaveBtn
            // 
            this.AF_SaveBtn.Location = new System.Drawing.Point(43, 217);
            this.AF_SaveBtn.Name = "AF_SaveBtn";
            this.AF_SaveBtn.Size = new System.Drawing.Size(99, 23);
            this.AF_SaveBtn.TabIndex = 0;
            this.AF_SaveBtn.Text = "Сохранить";
            this.AF_SaveBtn.UseVisualStyleBackColor = true;
            this.AF_SaveBtn.Click += new System.EventHandler(this.AF_SaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата создания";
            // 
            // DC_textBox
            // 
            this.DC_textBox.Location = new System.Drawing.Point(148, 72);
            this.DC_textBox.Name = "DC_textBox";
            this.DC_textBox.Size = new System.Drawing.Size(208, 20);
            this.DC_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Страна";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(148, 117);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(208, 20);
            this.Name_textBox.TabIndex = 5;
            // 
            // Country_textBox
            // 
            this.Country_textBox.Location = new System.Drawing.Point(148, 165);
            this.Country_textBox.Name = "Country_textBox";
            this.Country_textBox.Size = new System.Drawing.Size(208, 20);
            this.Country_textBox.TabIndex = 6;
            // 
            // AF_UndoBtn
            // 
            this.AF_UndoBtn.Location = new System.Drawing.Point(161, 217);
            this.AF_UndoBtn.Name = "AF_UndoBtn";
            this.AF_UndoBtn.Size = new System.Drawing.Size(75, 23);
            this.AF_UndoBtn.TabIndex = 7;
            this.AF_UndoBtn.Text = "Отмена";
            this.AF_UndoBtn.UseVisualStyleBackColor = true;
            this.AF_UndoBtn.Click += new System.EventHandler(this.AF_UndoBtn_Click);
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(148, 25);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(208, 20);
            this.ID_textbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 267);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AF_UndoBtn);
            this.Controls.Add(this.Country_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DC_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AF_SaveBtn);
            this.Name = "AddForm";
            this.Text = "Добавление нового элемента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AF_SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DC_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Country_textBox;
        private System.Windows.Forms.Button AF_UndoBtn;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.Label label4;
    }
}