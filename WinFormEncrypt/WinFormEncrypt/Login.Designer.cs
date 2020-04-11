namespace WinFormEncrypt
{
	partial class Login
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
			this.txtLogEmail = new System.Windows.Forms.TextBox();
			this.txtLogPw = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSignIn = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(43, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Email";
			// 
			// txtLogEmail
			// 
			this.txtLogEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtLogEmail.Location = new System.Drawing.Point(46, 69);
			this.txtLogEmail.Name = "txtLogEmail";
			this.txtLogEmail.Size = new System.Drawing.Size(195, 22);
			this.txtLogEmail.TabIndex = 1;
			// 
			// txtLogPw
			// 
			this.txtLogPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtLogPw.Location = new System.Drawing.Point(46, 157);
			this.txtLogPw.Name = "txtLogPw";
			this.txtLogPw.Size = new System.Drawing.Size(195, 22);
			this.txtLogPw.TabIndex = 3;
			this.txtLogPw.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(43, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// btnSignIn
			// 
			this.btnSignIn.BackColor = System.Drawing.Color.Teal;
			this.btnSignIn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSignIn.ForeColor = System.Drawing.Color.White;
			this.btnSignIn.Location = new System.Drawing.Point(87, 206);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(108, 39);
			this.btnSignIn.TabIndex = 4;
			this.btnSignIn.Text = "Sign In";
			this.btnSignIn.UseVisualStyleBackColor = false;
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.Color.Teal;
			this.btnRegister.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRegister.ForeColor = System.Drawing.Color.White;
			this.btnRegister.Location = new System.Drawing.Point(87, 267);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(108, 39);
			this.btnRegister.TabIndex = 5;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = false;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(285, 331);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnSignIn);
			this.Controls.Add(this.txtLogPw);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLogEmail);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLogEmail;
		private System.Windows.Forms.TextBox txtLogPw;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSignIn;
		private System.Windows.Forms.Button btnRegister;
	}
}