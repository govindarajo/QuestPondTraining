namespace RegExLearning
{
    partial class RegExForm
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
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(135, 58);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(529, 29);
            this.textBoxValue.TabIndex = 0;
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Location = new System.Drawing.Point(136, 130);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(529, 29);
            this.textBoxExpression.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Location = new System.Drawing.Point(22, 58);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(63, 25);
            this.Value.TabIndex = 3;
            this.Value.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expression";
            // 
            // RegExForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxExpression);
            this.Controls.Add(this.textBoxValue);
            this.Name = "RegExForm";
            this.Text = "RegExForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.Label label2;
    }
}