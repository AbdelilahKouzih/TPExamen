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
            this.btnafficher = new System.Windows.Forms.Button();
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
            this.lblquestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.lblfin = new System.Windows.Forms.Label();
            this.txtfin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnafficher
            // 
            this.btnafficher.Location = new System.Drawing.Point(785, 417);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(113, 38);
            this.btnafficher.TabIndex = 19;
            this.btnafficher.Text = "Afficher";
            this.btnafficher.UseVisualStyleBackColor = true;
            this.btnafficher.Click += new System.EventHandler(this.btnafficher_Click);
            // 
            // cbx
            // 
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(618, 146);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(358, 33);
            this.cbx.TabIndex = 18;
            // 
            // lblex
            // 
            this.lblex.AutoSize = true;
            this.lblex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblex.Location = new System.Drawing.Point(38, 156);
            this.lblex.Name = "lblex";
            this.lblex.Size = new System.Drawing.Size(139, 25);
            this.lblex.TabIndex = 17;
            this.lblex.Text = "Id examen      :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(215, 146);
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
            this.txtdebut.Location = new System.Drawing.Point(215, 265);
            this.txtdebut.Multiline = true;
            this.txtdebut.Name = "txtdebut";
            this.txtdebut.Size = new System.Drawing.Size(286, 32);
            this.txtdebut.TabIndex = 10;
            // 
            // lblreponse
            // 
            this.lblreponse.AutoSize = true;
            this.lblreponse.Location = new System.Drawing.Point(39, 272);
            this.lblreponse.Name = "lblreponse";
            this.lblreponse.Size = new System.Drawing.Size(142, 25);
            this.lblreponse.TabIndex = 9;
            this.lblreponse.Text = "date de debut :";
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(39, 209);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(138, 25);
            this.lblquestion.TabIndex = 1;
            this.lblquestion.Text = "Questiones    :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txtfin);
            this.panel1.Controls.Add(this.lblfin);
            this.panel1.Controls.Add(this.btnafficher);
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
            this.panel1.Controls.Add(this.lblquestion);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 489);
            this.panel1.TabIndex = 2;
            // 
            // txtquestion
            // 
            this.txtquestion.Location = new System.Drawing.Point(215, 203);
            this.txtquestion.Multiline = true;
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(286, 31);
            this.txtquestion.TabIndex = 2;
            // 
            // lblfin
            // 
            this.lblfin.AutoSize = true;
            this.lblfin.Location = new System.Drawing.Point(39, 335);
            this.lblfin.Name = "lblfin";
            this.lblfin.Size = new System.Drawing.Size(143, 25);
            this.lblfin.TabIndex = 20;
            this.lblfin.Text = "date de fin       :";
            // 
            // txtfin
            // 
            this.txtfin.Location = new System.Drawing.Point(215, 328);
            this.txtfin.Multiline = true;
            this.txtfin.Name = "txtfin";
            this.txtfin.Size = new System.Drawing.Size(286, 32);
            this.txtfin.TabIndex = 21;
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

        private System.Windows.Forms.Button btnafficher;
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
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfin;
        private System.Windows.Forms.Label lblfin;
        private System.Windows.Forms.TextBox txtquestion;
    }
}