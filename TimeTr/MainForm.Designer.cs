
namespace TimeTr
{
    partial class MainForm
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
            this.project2Btn = new System.Windows.Forms.Button();
            this.proj1Btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.project1Pause = new System.Windows.Forms.Button();
            this.project2Pause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // project2Btn
            // 
            this.project2Btn.Location = new System.Drawing.Point(30, 91);
            this.project2Btn.Name = "project2Btn";
            this.project2Btn.Size = new System.Drawing.Size(91, 23);
            this.project2Btn.TabIndex = 1;
            this.project2Btn.Text = "Project 2 Start";
            this.project2Btn.UseVisualStyleBackColor = true;
            this.project2Btn.Click += new System.EventHandler(this.project2Btn_Click);
            // 
            // proj1Btn
            // 
            this.proj1Btn.Location = new System.Drawing.Point(30, 52);
            this.proj1Btn.Name = "proj1Btn";
            this.proj1Btn.Size = new System.Drawing.Size(91, 22);
            this.proj1Btn.TabIndex = 0;
            this.proj1Btn.Text = "Project 1 Start";
            this.proj1Btn.UseVisualStyleBackColor = true;
            this.proj1Btn.Click += new System.EventHandler(this.project1Btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 3;
            // 
            // project1Pause
            // 
            this.project1Pause.Location = new System.Drawing.Point(293, 52);
            this.project1Pause.Name = "project1Pause";
            this.project1Pause.Size = new System.Drawing.Size(91, 22);
            this.project1Pause.TabIndex = 4;
            this.project1Pause.Text = "Pause";
            this.project1Pause.UseVisualStyleBackColor = true;
            this.project1Pause.Click += new System.EventHandler(this.project1Pause_Click);
            // 
            // project2Pause
            // 
            this.project2Pause.Location = new System.Drawing.Point(293, 93);
            this.project2Pause.Name = "project2Pause";
            this.project2Pause.Size = new System.Drawing.Size(91, 23);
            this.project2Pause.TabIndex = 5;
            this.project2Pause.Text = "Pause";
            this.project2Pause.UseVisualStyleBackColor = true;
            this.project2Pause.Click += new System.EventHandler(this.project2Pause_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 173);
            this.Controls.Add(this.project2Pause);
            this.Controls.Add(this.project1Pause);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.project2Btn);
            this.Controls.Add(this.proj1Btn);
            this.Name = "MainForm";
            this.Text = "Multi project time tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button project2Btn;
        private System.Windows.Forms.Button proj1Btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button project1Pause;
        private System.Windows.Forms.Button project2Pause;
    }
}

