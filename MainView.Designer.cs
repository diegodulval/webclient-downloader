namespace WebClientDownload
{
    partial class MainView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tbxFilepath = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.tbxUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button.Location = new System.Drawing.Point(57, 79);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(406, 29);
            this.button.TabIndex = 0;
            this.button.Text = "Baixar";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_ClickAsync);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar.Location = new System.Drawing.Point(57, 124);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(406, 40);
            this.progressBar.TabIndex = 1;
            this.progressBar.UseWaitCursor = true;
            // 
            // tbxFilepath
            // 
            this.tbxFilepath.BackColor = System.Drawing.SystemColors.Control;
            this.tbxFilepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFilepath.Location = new System.Drawing.Point(57, 42);
            this.tbxFilepath.Name = "tbxFilepath";
            this.tbxFilepath.Size = new System.Drawing.Size(200, 20);
            this.tbxFilepath.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(403, 217);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 3;
            // 
            // tbxUri
            // 
            this.tbxUri.BackColor = System.Drawing.SystemColors.Control;
            this.tbxUri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUri.Location = new System.Drawing.Point(263, 42);
            this.tbxUri.Name = "tbxUri";
            this.tbxUri.Size = new System.Drawing.Size(200, 20);
            this.tbxUri.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filepath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "URI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxUri);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbxFilepath);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox tbxFilepath;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbxUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

