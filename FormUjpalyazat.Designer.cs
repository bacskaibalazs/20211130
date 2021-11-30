
namespace _20211130
{
    partial class FormUjpalyazat
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelhuf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnujhirdetes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"A\" kategória értékkeret:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "\"C\" kategória értékkeret:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 14);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(73, 146);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(155, 20);
            this.tbA.TabIndex = 4;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(73, 208);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(155, 20);
            this.tbC.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(29, 20);
            this.textBox3.TabIndex = 6;
            // 
            // labelhuf
            // 
            this.labelhuf.AutoSize = true;
            this.labelhuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelhuf.Location = new System.Drawing.Point(234, 146);
            this.labelhuf.Name = "labelhuf";
            this.labelhuf.Size = new System.Drawing.Size(44, 20);
            this.labelhuf.TabIndex = 7;
            this.labelhuf.Text = "HUF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(234, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "HUF";
            // 
            // btnujhirdetes
            // 
            this.btnujhirdetes.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnujhirdetes.FlatAppearance.BorderSize = 2;
            this.btnujhirdetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnujhirdetes.Location = new System.Drawing.Point(73, 268);
            this.btnujhirdetes.Name = "btnujhirdetes";
            this.btnujhirdetes.Size = new System.Drawing.Size(203, 51);
            this.btnujhirdetes.TabIndex = 9;
            this.btnujhirdetes.Text = "Új pályázat hirdetése";
            this.btnujhirdetes.UseVisualStyleBackColor = true;
            // 
            // FormUjpalyazat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 597);
            this.Controls.Add(this.btnujhirdetes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelhuf);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUjpalyazat";
            this.Text = "Új pályázat rögzítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelhuf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnujhirdetes;
    }
}