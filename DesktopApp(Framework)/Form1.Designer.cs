namespace DesktopApp_Framework_
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.FinalBox = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(195, 204);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(151, 72);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // FinalBox
            // 
            this.FinalBox.Location = new System.Drawing.Point(94, 325);
            this.FinalBox.Multiline = true;
            this.FinalBox.Name = "FinalBox";
            this.FinalBox.Size = new System.Drawing.Size(363, 55);
            this.FinalBox.TabIndex = 1;
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(360, 106);
            this.Box2.Multiline = true;
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(151, 55);
            this.Box2.TabIndex = 2;
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(31, 106);
            this.Box1.Multiline = true;
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(151, 55);
            this.Box1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter first number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter second number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.FinalBox);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox FinalBox;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

