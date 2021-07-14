
namespace TestEx
{
    partial class MainForm
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
            this.Main_Add = new System.Windows.Forms.Button();
            this.Main_Edit = new System.Windows.Forms.Button();
            this.Main_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Main_AddCountry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Add
            // 
            this.Main_Add.Location = new System.Drawing.Point(48, 403);
            this.Main_Add.Name = "Main_Add";
            this.Main_Add.Size = new System.Drawing.Size(75, 23);
            this.Main_Add.TabIndex = 0;
            this.Main_Add.Text = "Добавить";
            this.Main_Add.UseVisualStyleBackColor = true;
            this.Main_Add.Click += new System.EventHandler(this.Main_Add_Click);
            // 
            // Main_Edit
            // 
            this.Main_Edit.Location = new System.Drawing.Point(236, 403);
            this.Main_Edit.Name = "Main_Edit";
            this.Main_Edit.Size = new System.Drawing.Size(108, 23);
            this.Main_Edit.TabIndex = 1;
            this.Main_Edit.Text = "Редактировать";
            this.Main_Edit.UseVisualStyleBackColor = true;
            this.Main_Edit.Click += new System.EventHandler(this.Main_Edit_Click);
            // 
            // Main_Delete
            // 
            this.Main_Delete.Location = new System.Drawing.Point(142, 403);
            this.Main_Delete.Name = "Main_Delete";
            this.Main_Delete.Size = new System.Drawing.Size(75, 23);
            this.Main_Delete.TabIndex = 2;
            this.Main_Delete.Text = "Удалить";
            this.Main_Delete.UseVisualStyleBackColor = true;
            this.Main_Delete.Click += new System.EventHandler(this.Main_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 373);
            this.dataGridView1.TabIndex = 3;
            // 
            // Main_AddCountry
            // 
            this.Main_AddCountry.Location = new System.Drawing.Point(651, 403);
            this.Main_AddCountry.Name = "Main_AddCountry";
            this.Main_AddCountry.Size = new System.Drawing.Size(137, 23);
            this.Main_AddCountry.TabIndex = 4;
            this.Main_AddCountry.Text = "Добавить страну";
            this.Main_AddCountry.UseVisualStyleBackColor = true;
            this.Main_AddCountry.Click += new System.EventHandler(this.Main_AddCountry_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main_AddCountry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Main_Delete);
            this.Controls.Add(this.Main_Edit);
            this.Controls.Add(this.Main_Add);
            this.Name = "MainForm";
            this.Text = "TestEX";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Main_Add;
        private System.Windows.Forms.Button Main_Edit;
        private System.Windows.Forms.Button Main_Delete;
        private System.Windows.Forms.Button Main_AddCountry;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

