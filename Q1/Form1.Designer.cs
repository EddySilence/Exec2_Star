namespace Q1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.leftButton = new System.Windows.Forms.Button();
			this.rightButton = new System.Windows.Forms.Button();
			this.equalButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(306, 37);
			this.inputTextBox.MaxLength = 2;
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(100, 22);
			this.inputTextBox.TabIndex = 0;
			// 
			// resultTextBox
			// 
			this.resultTextBox.Location = new System.Drawing.Point(179, 116);
			this.resultTextBox.Multiline = true;
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.Size = new System.Drawing.Size(364, 303);
			this.resultTextBox.TabIndex = 1;
			// 
			// leftButton
			// 
			this.leftButton.Location = new System.Drawing.Point(306, 87);
			this.leftButton.Name = "leftButton";
			this.leftButton.Size = new System.Drawing.Size(75, 23);
			this.leftButton.TabIndex = 2;
			this.leftButton.Text = "靠左三角形";
			this.leftButton.UseVisualStyleBackColor = true;
			this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
			// 
			// rightButton
			// 
			this.rightButton.Location = new System.Drawing.Point(225, 87);
			this.rightButton.Name = "rightButton";
			this.rightButton.Size = new System.Drawing.Size(75, 23);
			this.rightButton.TabIndex = 3;
			this.rightButton.Text = "靠右三角形";
			this.rightButton.UseVisualStyleBackColor = true;
			this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
			// 
			// equalButton
			// 
			this.equalButton.Location = new System.Drawing.Point(387, 87);
			this.equalButton.Name = "equalButton";
			this.equalButton.Size = new System.Drawing.Size(75, 23);
			this.equalButton.TabIndex = 4;
			this.equalButton.Text = "等腰三角形";
			this.equalButton.UseVisualStyleBackColor = true;
			this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(187, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "請輸入1~10的數字：";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.equalButton);
			this.Controls.Add(this.rightButton);
			this.Controls.Add(this.leftButton);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.inputTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.TextBox resultTextBox;
		private System.Windows.Forms.Button leftButton;
		private System.Windows.Forms.Button rightButton;
		private System.Windows.Forms.Button equalButton;
		private System.Windows.Forms.Label label1;
	}
}

