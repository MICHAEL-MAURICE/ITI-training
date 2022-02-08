namespace sss
{
    partial class Form1
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
            this.dgv_students = new System.Windows.Forms.DataGridView();
            this.Fn_txt = new System.Windows.Forms.TextBox();
            this.Ln_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.Fname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_students
            // 
            this.dgv_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_students.Location = new System.Drawing.Point(0, 213);
            this.dgv_students.Name = "dgv_students";
            this.dgv_students.Size = new System.Drawing.Size(803, 237);
            this.dgv_students.TabIndex = 0;
            // 
            // Fn_txt
            // 
            this.Fn_txt.Location = new System.Drawing.Point(102, 32);
            this.Fn_txt.Name = "Fn_txt";
            this.Fn_txt.Size = new System.Drawing.Size(100, 20);
            this.Fn_txt.TabIndex = 1;
            // 
            // Ln_txt
            // 
            this.Ln_txt.Location = new System.Drawing.Point(315, 32);
            this.Ln_txt.Name = "Ln_txt";
            this.Ln_txt.Size = new System.Drawing.Size(100, 20);
            this.Ln_txt.TabIndex = 2;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(497, 35);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(329, 163);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 7;
            this.add.Text = "button1";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(35, 38);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(39, 13);
            this.Fname.TabIndex = 8;
            this.Fname.Text = "Fname";
            this.Fname.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.add);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.Ln_txt);
            this.Controls.Add(this.Fn_txt);
            this.Controls.Add(this.dgv_students);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_students;
        private System.Windows.Forms.TextBox Fn_txt;
        private System.Windows.Forms.TextBox Ln_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

