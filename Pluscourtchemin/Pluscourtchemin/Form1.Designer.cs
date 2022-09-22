namespace Pluscourtchemin
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxXInit = new System.Windows.Forms.TextBox();
            this.textBoxYinit = new System.Windows.Forms.TextBox();
            this.buttonAstar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonInit1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxXFinal = new System.Windows.Forms.TextBox();
            this.textBoxYFinal = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonInit2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFermes = new System.Windows.Forms.Label();
            this.labelOuverts = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonInit3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxXInit
            // 
            this.textBoxXInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXInit.Location = new System.Drawing.Point(289, 53);
            this.textBoxXInit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXInit.Name = "textBoxXInit";
            this.textBoxXInit.Size = new System.Drawing.Size(58, 34);
            this.textBoxXInit.TabIndex = 1;
            this.textBoxXInit.Text = "0";
            // 
            // textBoxYinit
            // 
            this.textBoxYinit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYinit.Location = new System.Drawing.Point(376, 53);
            this.textBoxYinit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYinit.Name = "textBoxYinit";
            this.textBoxYinit.Size = new System.Drawing.Size(58, 34);
            this.textBoxYinit.TabIndex = 2;
            this.textBoxYinit.Text = "6";
            // 
            // buttonAstar
            // 
            this.buttonAstar.Enabled = false;
            this.buttonAstar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAstar.Location = new System.Drawing.Point(425, 121);
            this.buttonAstar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAstar.Name = "buttonAstar";
            this.buttonAstar.Size = new System.Drawing.Size(99, 50);
            this.buttonAstar.TabIndex = 3;
            this.buttonAstar.Text = "A*";
            this.buttonAstar.UseVisualStyleBackColor = true;
            this.buttonAstar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "X initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y initial";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(966, 33);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 324);
            this.listBox1.TabIndex = 6;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1186, 33);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(201, 324);
            this.treeView1.TabIndex = 7;
            // 
            // buttonInit1
            // 
            this.buttonInit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInit1.Location = new System.Drawing.Point(6, 17);
            this.buttonInit1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInit1.Name = "buttonInit1";
            this.buttonInit1.Size = new System.Drawing.Size(216, 75);
            this.buttonInit1.TabIndex = 8;
            this.buttonInit1.Text = "Initialisation environnement 1";
            this.buttonInit1.UseVisualStyleBackColor = true;
            this.buttonInit1.Click += new System.EventHandler(this.buttonInit1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "X final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y final";
            // 
            // textBoxXFinal
            // 
            this.textBoxXFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXFinal.Location = new System.Drawing.Point(514, 53);
            this.textBoxXFinal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXFinal.Name = "textBoxXFinal";
            this.textBoxXFinal.Size = new System.Drawing.Size(51, 30);
            this.textBoxXFinal.TabIndex = 13;
            this.textBoxXFinal.Text = "15";
            // 
            // textBoxYFinal
            // 
            this.textBoxYFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYFinal.Location = new System.Drawing.Point(590, 53);
            this.textBoxYFinal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYFinal.Name = "textBoxYFinal";
            this.textBoxYFinal.Size = new System.Drawing.Size(51, 30);
            this.textBoxYFinal.TabIndex = 14;
            this.textBoxYFinal.Text = "15";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pluscourtchemin.Properties.Resources.légende;
            this.pictureBox2.Location = new System.Drawing.Point(898, 409);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 201);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // buttonInit2
            // 
            this.buttonInit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInit2.Location = new System.Drawing.Point(6, 115);
            this.buttonInit2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInit2.Name = "buttonInit2";
            this.buttonInit2.Size = new System.Drawing.Size(216, 75);
            this.buttonInit2.TabIndex = 16;
            this.buttonInit2.Text = "Initialisation environnement 2";
            this.buttonInit2.UseVisualStyleBackColor = true;
            this.buttonInit2.Click += new System.EventHandler(this.buttonInit2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(905, 684);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nb noeuds fermés :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(905, 728);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nb noeuds ouverts :";
            // 
            // labelFermes
            // 
            this.labelFermes.AutoSize = true;
            this.labelFermes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFermes.Location = new System.Drawing.Point(1177, 684);
            this.labelFermes.Name = "labelFermes";
            this.labelFermes.Size = new System.Drawing.Size(0, 29);
            this.labelFermes.TabIndex = 19;
            // 
            // labelOuverts
            // 
            this.labelOuverts.AutoSize = true;
            this.labelOuverts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOuverts.Location = new System.Drawing.Point(1177, 728);
            this.labelOuverts.Name = "labelOuverts";
            this.labelOuverts.Size = new System.Drawing.Size(0, 29);
            this.labelOuverts.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(975, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Chemin solution";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1194, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Arbre d\'exploration";
            // 
            // buttonInit3
            // 
            this.buttonInit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInit3.Location = new System.Drawing.Point(6, 212);
            this.buttonInit3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInit3.Name = "buttonInit3";
            this.buttonInit3.Size = new System.Drawing.Size(216, 75);
            this.buttonInit3.TabIndex = 23;
            this.buttonInit3.Text = "Initialisation environnement 3";
            this.buttonInit3.UseVisualStyleBackColor = true;
            this.buttonInit3.Click += new System.EventHandler(this.buttonInit3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(270, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 29);
            this.label9.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 768);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonInit3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelOuverts);
            this.Controls.Add(this.labelFermes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonInit2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxYFinal);
            this.Controls.Add(this.textBoxXFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonInit1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAstar);
            this.Controls.Add(this.textBoxYinit);
            this.Controls.Add(this.textBoxXInit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Recherche du plus court chemin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxXInit;
        private System.Windows.Forms.TextBox textBoxYinit;
        private System.Windows.Forms.Button buttonAstar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonInit1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxXFinal;
        private System.Windows.Forms.TextBox textBoxYFinal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonInit2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFermes;
        private System.Windows.Forms.Label labelOuverts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonInit3;
        private System.Windows.Forms.Label label9;
    }
}

