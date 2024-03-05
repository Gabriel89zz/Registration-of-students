namespace Registration_of_students_and_teachers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtId = new TextBox();
            txtNumber = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 27);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 0;
            label1.Text = "Register information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label2.Location = new Point(219, 100);
            label2.Name = "label2";
            label2.Size = new Size(97, 22);
            label2.TabIndex = 1;
            label2.Text = "Full Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label3.Location = new Point(219, 154);
            label3.Name = "label3";
            label3.Size = new Size(47, 22);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label4.Location = new Point(219, 201);
            label4.Name = "label4";
            label4.Size = new Size(134, 22);
            label4.TabIndex = 3;
            label4.Text = "Phone number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label5.Location = new Point(219, 245);
            label5.Name = "label5";
            label5.Size = new Size(31, 22);
            label5.TabIndex = 4;
            label5.Text = "Id:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft YaHei UI", 12F);
            txtName.Location = new Point(381, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(164, 28);
            txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Microsoft YaHei UI", 12F);
            txtAge.Location = new Point(381, 153);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(164, 28);
            txtAge.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft YaHei UI", 12F);
            txtId.Location = new Point(381, 247);
            txtId.Name = "txtId";
            txtId.Size = new Size(164, 28);
            txtId.TabIndex = 8;
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Microsoft YaHei UI", 12F);
            txtNumber.Location = new Point(381, 200);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(164, 28);
            txtNumber.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(344, 311);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(92, 51);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtId);
            Controls.Add(txtNumber);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtId;
        private TextBox txtNumber;
        private Button btnRegister;
    }
}
