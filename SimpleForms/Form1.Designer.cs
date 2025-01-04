namespace SimpleForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetSafe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetUnsafe = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtIdUnsafe1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(50, 10);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(156, 8);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Press";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(334, 56);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(388, 340);
            this.txtResponse.TabIndex = 4;
            this.txtResponse.Text = "";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(156, 56);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 5;
            this.btnGetAll.Text = "Press";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Get All:";
            // 
            // btnGetSafe
            // 
            this.btnGetSafe.Location = new System.Drawing.Point(156, 122);
            this.btnGetSafe.Name = "btnGetSafe";
            this.btnGetSafe.Size = new System.Drawing.Size(75, 23);
            this.btnGetSafe.TabIndex = 7;
            this.btnGetSafe.Text = "Press";
            this.btnGetSafe.UseVisualStyleBackColor = true;
            this.btnGetSafe.Click += new System.EventHandler(this.btnGetSafe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Masked:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "No Mask:";
            // 
            // btnGetUnsafe
            // 
            this.btnGetUnsafe.Location = new System.Drawing.Point(156, 151);
            this.btnGetUnsafe.Name = "btnGetUnsafe";
            this.btnGetUnsafe.Size = new System.Drawing.Size(75, 23);
            this.btnGetUnsafe.TabIndex = 10;
            this.btnGetUnsafe.Text = "Press";
            this.btnGetUnsafe.UseVisualStyleBackColor = true;
            this.btnGetUnsafe.Click += new System.EventHandler(this.btnGetUnsafe_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(103, 122);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(47, 20);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // txtIdUnsafe1
            // 
            this.txtIdUnsafe1.Location = new System.Drawing.Point(103, 153);
            this.txtIdUnsafe1.Name = "txtIdUnsafe1";
            this.txtIdUnsafe1.Size = new System.Drawing.Size(47, 20);
            this.txtIdUnsafe1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdUnsafe1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnGetUnsafe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetSafe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RichTextBox txtResponse;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetSafe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetUnsafe;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txtIdUnsafe1;
        private System.Windows.Forms.Label label5;
    }
}

