namespace TPExamen
{
    partial class Examen
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
            this.cbx = new System.Windows.Forms.ComboBox();
            this.lblex = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.txtdebut = new System.Windows.Forms.TextBox();
            this.lblreponse = new System.Windows.Forms.Label();
            this.lblquestionouvert = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndi = new System.Windows.Forms.Button();
            this.btnouvert = new System.Windows.Forms.Button();
            this.btnqcm = new System.Windows.Forms.Button();
            this.txtqcm = new System.Windows.Forms.TextBox();
            this.txtouvert = new System.Windows.Forms.TextBox();
            this.lblqcm = new System.Windows.Forms.Label();
            this.lbldi = new System.Windows.Forms.Label();
            this.txtfin = new System.Windows.Forms.TextBox();
            this.lblfin = new System.Windows.Forms.Label();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx
            // 
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(802, 67);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(358, 33);
            this.cbx.TabIndex = 18;
            // 
            // lblex
            // 
            this.lblex.AutoSize = true;
            this.lblex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblex.Location = new System.Drawing.Point(38, 67);
            this.lblex.Name = "lblex";
            this.lblex.Size = new System.Drawing.Size(139, 25);
            this.lblex.TabIndex = 17;
            this.lblex.Text = "Id examen      :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(300, 67);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(286, 31);
            this.txtid.TabIndex = 16;
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(639, 417);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(113, 38);
            this.btnannuler.TabIndex = 15;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(495, 417);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(110, 38);
            this.btnvalider.TabIndex = 14;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(347, 417);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(117, 38);
            this.btnsupprimer.TabIndex = 13;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(199, 417);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(118, 38);
            this.btnmodifier.TabIndex = 12;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(54, 417);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(116, 38);
            this.btnajouter.TabIndex = 11;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // txtdebut
            // 
            this.txtdebut.Location = new System.Drawing.Point(300, 157);
            this.txtdebut.Multiline = true;
            this.txtdebut.Name = "txtdebut";
            this.txtdebut.Size = new System.Drawing.Size(286, 32);
            this.txtdebut.TabIndex = 10;
            // 
            // lblreponse
            // 
            this.lblreponse.AutoSize = true;
            this.lblreponse.Location = new System.Drawing.Point(35, 164);
            this.lblreponse.Name = "lblreponse";
            this.lblreponse.Size = new System.Drawing.Size(142, 25);
            this.lblreponse.TabIndex = 9;
            this.lblreponse.Text = "date de debut :";
            // 
            // lblquestionouvert
            // 
            this.lblquestionouvert.AutoSize = true;
            this.lblquestionouvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestionouvert.Location = new System.Drawing.Point(38, 313);
            this.lblquestionouvert.Name = "lblquestionouvert";
            this.lblquestionouvert.Size = new System.Drawing.Size(196, 25);
            this.lblquestionouvert.TabIndex = 1;
            this.lblquestionouvert.Text = "id question ouvert     :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btndi);
            this.panel1.Controls.Add(this.btnouvert);
            this.panel1.Controls.Add(this.btnqcm);
            this.panel1.Controls.Add(this.txtqcm);
            this.panel1.Controls.Add(this.txtouvert);
            this.panel1.Controls.Add(this.lblqcm);
            this.panel1.Controls.Add(this.lbldi);
            this.panel1.Controls.Add(this.txtfin);
            this.panel1.Controls.Add(this.lblfin);
            this.panel1.Controls.Add(this.cbx);
            this.panel1.Controls.Add(this.lblex);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.btnannuler);
            this.panel1.Controls.Add(this.btnvalider);
            this.panel1.Controls.Add(this.btnsupprimer);
            this.panel1.Controls.Add(this.btnmodifier);
            this.panel1.Controls.Add(this.btnajouter);
            this.panel1.Controls.Add(this.txtdebut);
            this.panel1.Controls.Add(this.lblreponse);
            this.panel1.Controls.Add(this.txtquestion);
            this.panel1.Controls.Add(this.lblquestionouvert);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 489);
            this.panel1.TabIndex = 2;
            // 
            // btndi
            // 
            this.btndi.Location = new System.Drawing.Point(1079, 325);
            this.btndi.Name = "btndi";
            this.btndi.Size = new System.Drawing.Size(113, 39);
            this.btndi.TabIndex = 28;
            this.btndi.Text = "DCM";
            this.btndi.UseVisualStyleBackColor = true;
            this.btndi.Click += new System.EventHandler(this.btndi_Click);
            // 
            // btnouvert
            // 
            this.btnouvert.Location = new System.Drawing.Point(1079, 268);
            this.btnouvert.Name = "btnouvert";
            this.btnouvert.Size = new System.Drawing.Size(113, 39);
            this.btnouvert.TabIndex = 27;
            this.btnouvert.Text = "Q.Ouvert";
            this.btnouvert.UseVisualStyleBackColor = true;
            this.btnouvert.Click += new System.EventHandler(this.btnouvert_Click);
            // 
            // btnqcm
            // 
            this.btnqcm.Location = new System.Drawing.Point(1079, 209);
            this.btnqcm.Name = "btnqcm";
            this.btnqcm.Size = new System.Drawing.Size(113, 39);
            this.btnqcm.TabIndex = 26;
            this.btnqcm.Text = "QCM";
            this.btnqcm.UseVisualStyleBackColor = true;
            this.btnqcm.Click += new System.EventHandler(this.btnqcm_Click);
            // 
            // txtqcm
            // 
            this.txtqcm.Location = new System.Drawing.Point(300, 255);
            this.txtqcm.Multiline = true;
            this.txtqcm.Name = "txtqcm";
            this.txtqcm.Size = new System.Drawing.Size(286, 31);
            this.txtqcm.TabIndex = 25;
            // 
            // txtouvert
            // 
            this.txtouvert.Location = new System.Drawing.Point(300, 307);
            this.txtouvert.Multiline = true;
            this.txtouvert.Name = "txtouvert";
            this.txtouvert.Size = new System.Drawing.Size(286, 31);
            this.txtouvert.TabIndex = 24;
            // 
            // lblqcm
            // 
            this.lblqcm.AutoSize = true;
            this.lblqcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqcm.Location = new System.Drawing.Point(38, 261);
            this.lblqcm.Name = "lblqcm";
            this.lblqcm.Size = new System.Drawing.Size(170, 25);
            this.lblqcm.TabIndex = 23;
            this.lblqcm.Text = "id question QCM :";
            // 
            // lbldi
            // 
            this.lbldi.AutoSize = true;
            this.lbldi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldi.Location = new System.Drawing.Point(35, 116);
            this.lbldi.Name = "lbldi";
            this.lbldi.Size = new System.Drawing.Size(238, 25);
            this.lbldi.TabIndex = 22;
            this.lbldi.Text = "id question dichotomique :";
            this.lbldi.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtfin
            // 
            this.txtfin.Location = new System.Drawing.Point(300, 202);
            this.txtfin.Multiline = true;
            this.txtfin.Name = "txtfin";
            this.txtfin.Size = new System.Drawing.Size(286, 32);
            this.txtfin.TabIndex = 21;
            // 
            // lblfin
            // 
            this.lblfin.AutoSize = true;
            this.lblfin.Location = new System.Drawing.Point(35, 209);
            this.lblfin.Name = "lblfin";
            this.lblfin.Size = new System.Drawing.Size(143, 25);
            this.lblfin.TabIndex = 20;
            this.lblfin.Text = "date de fin       :";
            // 
            // txtquestion
            // 
            this.txtquestion.Location = new System.Drawing.Point(300, 110);
            this.txtquestion.Multiline = true;
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(286, 31);
            this.txtquestion.TabIndex = 2;
            // 
            // Examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 486);
            this.Controls.Add(this.panel1);
            this.Name = "Examen";
            this.Text = "Examen";
            this.Load += new System.EventHandler(this.Examen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.Label lblex;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.TextBox txtdebut;
        private System.Windows.Forms.Label lblreponse;
        private System.Windows.Forms.Label lblquestionouvert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfin;
        private System.Windows.Forms.Label lblfin;
        private System.Windows.Forms.TextBox txtquestion;
        private System.Windows.Forms.TextBox txtqcm;
        private System.Windows.Forms.TextBox txtouvert;
        private System.Windows.Forms.Label lblqcm;
        private System.Windows.Forms.Label lbldi;
        private System.Windows.Forms.Button btndi;
        private System.Windows.Forms.Button btnouvert;
        private System.Windows.Forms.Button btnqcm;
    }
}