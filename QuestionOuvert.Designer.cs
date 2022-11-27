namespace TPExamen
{
    partial class QuestionOuvert
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.txtreponse = new System.Windows.Forms.TextBox();
            this.lblreponse = new System.Windows.Forms.Label();
            this.lblquestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtquestion = new System.Windows.Forms.TextBox();
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
            // 
            // cbx
            // 
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(540, 148);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(358, 33);
            this.cbx.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id question :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(178, 150);
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
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(495, 417);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(110, 38);
            this.btnvalider.TabIndex = 14;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(347, 417);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(117, 38);
            this.btnsupprimer.TabIndex = 13;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(199, 417);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(118, 38);
            this.btnmodifier.TabIndex = 12;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(54, 417);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(116, 38);
            this.btnajouter.TabIndex = 11;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            // 
            // txtreponse
            // 
            this.txtreponse.Location = new System.Drawing.Point(178, 265);
            this.txtreponse.Multiline = true;
            this.txtreponse.Name = "txtreponse";
            this.txtreponse.Size = new System.Drawing.Size(286, 32);
            this.txtreponse.TabIndex = 10;
            // 
            // lblreponse
            // 
            this.lblreponse.AutoSize = true;
            this.lblreponse.Location = new System.Drawing.Point(39, 272);
            this.lblreponse.Name = "lblreponse";
            this.lblreponse.Size = new System.Drawing.Size(116, 25);
            this.lblreponse.TabIndex = 9;
            this.lblreponse.Text = "Reponse    :";
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(39, 209);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(117, 25);
            this.lblquestion.TabIndex = 1;
            this.lblquestion.Text = "Question    :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
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
            this.panel1.Controls.Add(this.txtquestion);
            this.panel1.Controls.Add(this.lblquestion);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 480);
            this.panel1.TabIndex = 1;
            // 
            // txtquestion
            // 
            this.txtquestion.Location = new System.Drawing.Point(178, 203);
            this.txtquestion.Multiline = true;
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(286, 31);
            this.txtquestion.TabIndex = 2;
            // 
            // QuestionOuvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 475);
            this.Controls.Add(this.panel1);
            this.Name = "QuestionOuvert";
            this.Text = "QuestionOuvert";
            this.Load += new System.EventHandler(this.QuestionOuvert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnafficher;
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.TextBox txtreponse;
        private System.Windows.Forms.Label lblreponse;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtquestion;
    }
}