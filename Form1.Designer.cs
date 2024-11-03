namespace PianoSense
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.starting_record_button = new System.Windows.Forms.Button();
            this.stopping_record_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "song name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "playing date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "playing times:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 22);
            this.textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(530, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(530, 22);
            this.textBox2.TabIndex = 5;
            // 
            // starting_record_button
            // 
            this.starting_record_button.Location = new System.Drawing.Point(83, 322);
            this.starting_record_button.Name = "starting_record_button";
            this.starting_record_button.Size = new System.Drawing.Size(212, 170);
            this.starting_record_button.TabIndex = 6;
            this.starting_record_button.Text = "record song";
            this.starting_record_button.UseVisualStyleBackColor = true;
            this.starting_record_button.Click += new System.EventHandler(this.starting_record_button_Click);
            // 
            // stopping_record_button
            // 
            this.stopping_record_button.Location = new System.Drawing.Point(356, 322);
            this.stopping_record_button.Name = "stopping_record_button";
            this.stopping_record_button.Size = new System.Drawing.Size(199, 170);
            this.stopping_record_button.TabIndex = 7;
            this.stopping_record_button.Text = "stop song";
            this.stopping_record_button.UseVisualStyleBackColor = true;
            this.stopping_record_button.Click += new System.EventHandler(this.stopping_record_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 161);
            this.button3.TabIndex = 8;
            this.button3.Text = "result";
            this.button3.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 545);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.stopping_record_button);
            this.Controls.Add(this.starting_record_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button starting_record_button;
        private System.Windows.Forms.Button stopping_record_button;
        private System.Windows.Forms.Button button3;
    }
}

