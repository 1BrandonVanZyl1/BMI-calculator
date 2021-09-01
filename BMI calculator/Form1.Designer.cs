
namespace BMI_calculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.patientidTbox = new System.Windows.Forms.TextBox();
            this.weightTbox = new System.Windows.Forms.TextBox();
            this.heightTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bmiTbox = new System.Windows.Forms.TextBox();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.idElabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height (m)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientidTbox
            // 
            this.patientidTbox.Location = new System.Drawing.Point(280, 69);
            this.patientidTbox.Name = "patientidTbox";
            this.patientidTbox.Size = new System.Drawing.Size(157, 22);
            this.patientidTbox.TabIndex = 4;
            // 
            // weightTbox
            // 
            this.weightTbox.Location = new System.Drawing.Point(280, 136);
            this.weightTbox.Name = "weightTbox";
            this.weightTbox.Size = new System.Drawing.Size(157, 22);
            this.weightTbox.TabIndex = 5;
            // 
            // heightTbox
            // 
            this.heightTbox.Location = new System.Drawing.Point(280, 193);
            this.heightTbox.Name = "heightTbox";
            this.heightTbox.Size = new System.Drawing.Size(157, 22);
            this.heightTbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Weight (Kg)";
            // 
            // bmiTbox
            // 
            this.bmiTbox.Location = new System.Drawing.Point(560, 135);
            this.bmiTbox.Name = "bmiTbox";
            this.bmiTbox.Size = new System.Drawing.Size(77, 22);
            this.bmiTbox.TabIndex = 8;
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.ForeColor = System.Drawing.Color.Black;
            this.bmiLabel.Location = new System.Drawing.Point(669, 138);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(0, 16);
            this.bmiLabel.TabIndex = 9;
            // 
            // idElabel
            // 
            this.idElabel.AutoSize = true;
            this.idElabel.ForeColor = System.Drawing.Color.Red;
            this.idElabel.Location = new System.Drawing.Point(277, 94);
            this.idElabel.Name = "idElabel";
            this.idElabel.Size = new System.Drawing.Size(0, 16);
            this.idElabel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "BMI";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idElabel);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.bmiTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heightTbox);
            this.Controls.Add(this.weightTbox);
            this.Controls.Add(this.patientidTbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox patientidTbox;
        private System.Windows.Forms.TextBox weightTbox;
        private System.Windows.Forms.TextBox heightTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bmiTbox;
        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.Label idElabel;
        private System.Windows.Forms.Label label4;
    }
}

