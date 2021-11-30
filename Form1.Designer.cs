
namespace _20211130
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnujpalyazat = new System.Windows.Forms.Button();
            this.btnkilepes = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keretosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakszama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakosszege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.keretosszeg,
            this.szamlakszama,
            this.szamlakosszege});
            this.dgv.Location = new System.Drawing.Point(129, 61);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(667, 377);
            this.dgv.TabIndex = 0;
            // 
            // btnujpalyazat
            // 
            this.btnujpalyazat.BackColor = System.Drawing.Color.Green;
            this.btnujpalyazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnujpalyazat.ForeColor = System.Drawing.Color.White;
            this.btnujpalyazat.Location = new System.Drawing.Point(129, 469);
            this.btnujpalyazat.Name = "btnujpalyazat";
            this.btnujpalyazat.Size = new System.Drawing.Size(220, 95);
            this.btnujpalyazat.TabIndex = 1;
            this.btnujpalyazat.Text = "Új pályázat";
            this.btnujpalyazat.UseVisualStyleBackColor = false;
            this.btnujpalyazat.Click += new System.EventHandler(this.btnujpalyazat_Click);
            // 
            // btnkilepes
            // 
            this.btnkilepes.BackColor = System.Drawing.Color.Red;
            this.btnkilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnkilepes.ForeColor = System.Drawing.Color.White;
            this.btnkilepes.Location = new System.Drawing.Point(576, 469);
            this.btnkilepes.Name = "btnkilepes";
            this.btnkilepes.Size = new System.Drawing.Size(220, 95);
            this.btnkilepes.TabIndex = 2;
            this.btnkilepes.Text = "Kilépés";
            this.btnkilepes.UseVisualStyleBackColor = false;
            this.btnkilepes.Click += new System.EventHandler(this.btnkilepes_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // keretosszeg
            // 
            this.keretosszeg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keretosszeg.HeaderText = "keretösszeg";
            this.keretosszeg.Name = "keretosszeg";
            // 
            // szamlakszama
            // 
            this.szamlakszama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szamlakszama.HeaderText = "Számlák száma";
            this.szamlakszama.Name = "szamlakszama";
            // 
            // szamlakosszege
            // 
            this.szamlakosszege.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szamlakosszege.HeaderText = "számlák összege";
            this.szamlakosszege.Name = "szamlakosszege";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 599);
            this.Controls.Add(this.btnkilepes);
            this.Controls.Add(this.btnujpalyazat);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Pályázatok állapota";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnujpalyazat;
        private System.Windows.Forms.Button btnkilepes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn keretosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakszama;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakosszege;
    }
}

