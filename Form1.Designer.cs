namespace TPExamen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnafficher = new System.Windows.Forms.Button();
            this.cbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.txtreponse = new System.Windows.Forms.TextBox();
            this.lblreponse = new System.Windows.Forms.Label();
            this.txtop2 = new System.Windows.Forms.TextBox();
            this.txtop3 = new System.Windows.Forms.TextBox();
            this.txtop1 = new System.Windows.Forms.TextBox();
            this.op3 = new System.Windows.Forms.Label();
            this.op2 = new System.Windows.Forms.Label();
            this.op1 = new System.Windows.Forms.Label();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.lblquestion = new System.Windows.Forms.Label();
            this.btnexamen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnexamen);
            this.panel1.Controls.Add(this.btnafficher);
            this.panel1.Controls.Add(this.cbx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.btnannuler);
            this.panel1.Controls.Add(this.btnvalider);
            this.panel1.Controls.Add(this.btnsupprimer);
            this.panel1.Controls.Add(this.btnmodifier);
            this.panel1.Controls.Add(this.btnajouter);
            this.panel1.Controls.Add(this.txtreponse);
            this.panel1.Controls.Add(this.lblreponse);
            this.panel1.Controls.Add(this.txtop2);
            this.panel1.Controls.Add(this.txtop3);
            this.panel1.Controls.Add(this.txtop1);
            this.panel1.Controls.Add(this.op3);
            this.panel1.Controls.Add(this.op2);
            this.panel1.Controls.Add(this.op1);
            this.panel1.Controls.Add(this.txtquestion);
            this.panel1.Controls.Add(this.lblquestion);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 500);
            this.panel1.TabIndex = 0;
            // 
            // btnafficher
            // 
            this.btnafficher.Location = new System.Drawing.Point(544, 427);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(116, 38);
            this.btnafficher.TabIndex = 19;
            this.btnafficher.Text = "Afficher";
            this.btnafficher.UseVisualStyleBackColor = true;
            this.btnafficher.Click += new System.EventHandler(this.btnafficher_Click);
            // 
            // cbx
            // 
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(648, 81);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(275, 33);
            this.cbx.TabIndex = 18;
            this.cbx.SelectedIndexChanged += new System.EventHandler(this.cbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id question :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(172, 78);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(286, 31);
            this.txtid.TabIndex = 16;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(839, 427);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(110, 38);
            this.btnannuler.TabIndex = 15;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(694, 427);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(110, 38);
            this.btnvalider.TabIndex = 14;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(389, 427);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(118, 38);
            this.btnsupprimer.TabIndex = 13;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(235, 427);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(118, 38);
            this.btnmodifier.TabIndex = 12;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(83, 427);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(116, 38);
            this.btnajouter.TabIndex = 11;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // txtreponse
            // 
            this.txtreponse.Location = new System.Drawing.Point(648, 217);
            this.txtreponse.Multiline = true;
            this.txtreponse.Name = "txtreponse";
            this.txtreponse.Size = new System.Drawing.Size(275, 30);
            this.txtreponse.TabIndex = 10;
            this.txtreponse.TextChanged += new System.EventHandler(this.txtreponse_TextChanged);
            // 
            // lblreponse
            // 
            this.lblreponse.AutoSize = true;
            this.lblreponse.Location = new System.Drawing.Point(539, 220);
            this.lblreponse.Name = "lblreponse";
            this.lblreponse.Size = new System.Drawing.Size(101, 25);
            this.lblreponse.TabIndex = 9;
            this.lblreponse.Text = "Reponse :";
            this.lblreponse.Click += new System.EventHandler(this.lblreponse_Click);
            // 
            // txtop2
            // 
            this.txtop2.Location = new System.Drawing.Point(172, 273);
            this.txtop2.Name = "txtop2";
            this.txtop2.Size = new System.Drawing.Size(286, 30);
            this.txtop2.TabIndex = 8;
            // 
            // txtop3
            // 
            this.txtop3.Location = new System.Drawing.Point(172, 328);
            this.txtop3.Name = "txtop3";
            this.txtop3.Size = new System.Drawing.Size(286, 30);
            this.txtop3.TabIndex = 7;
            // 
            // txtop1
            // 
            this.txtop1.Location = new System.Drawing.Point(172, 217);
            this.txtop1.Name = "txtop1";
            this.txtop1.Size = new System.Drawing.Size(286, 30);
            this.txtop1.TabIndex = 6;
            // 
            // op3
            // 
            this.op3.AutoSize = true;
            this.op3.Location = new System.Drawing.Point(38, 331);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(86, 25);
            this.op3.TabIndex = 5;
            this.op3.Text = "Option 3";
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Location = new System.Drawing.Point(38, 278);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(86, 25);
            this.op2.TabIndex = 4;
            this.op2.Text = "Option 2";
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Location = new System.Drawing.Point(38, 222);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(86, 25);
            this.op1.TabIndex = 3;
            this.op1.Text = "Option 1";
            // 
            // txtquestion
            // 
            this.txtquestion.Location = new System.Drawing.Point(172, 118);
            this.txtquestion.Multiline = true;
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(286, 31);
            this.txtquestion.TabIndex = 2;
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(38, 118);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(117, 25);
            this.lblquestion.TabIndex = 1;
            this.lblquestion.Text = "Question    :";
            // 
            // btnexamen
            // 
            this.btnexamen.Location = new System.Drawing.Point(839, 318);
            this.btnexamen.Name = "btnexamen";
            this.btnexamen.Size = new System.Drawing.Size(110, 38);
            this.btnexamen.TabIndex = 20;
            this.btnexamen.Text = "Examen";
            this.btnexamen.UseVisualStyleBackColor = true;
            this.btnexamen.Click += new System.EventHandler(this.btnexamen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 500);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblreponse;
        private System.Windows.Forms.TextBox txtop2;
        private System.Windows.Forms.TextBox txtop3;
        private System.Windows.Forms.TextBox txtop1;
        private System.Windows.Forms.Label op3;
        private System.Windows.Forms.Label op2;
        private System.Windows.Forms.Label op1;
        private System.Windows.Forms.TextBox txtquestion;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.TextBox txtreponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnafficher;
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.Button btnexamen;
    }
}

