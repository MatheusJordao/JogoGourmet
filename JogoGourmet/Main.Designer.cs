namespace JogoGourmet
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button buttonIniciarJogo;
            labelMain = new Label();
            buttonIniciarJogo = new Button();
            SuspendLayout();
            // 
            // buttonIniciarJogo
            // 
            buttonIniciarJogo.Location = new Point(187, 93);
            buttonIniciarJogo.Name = "buttonIniciarJogo";
            buttonIniciarJogo.Size = new Size(75, 23);
            buttonIniciarJogo.TabIndex = 1;
            buttonIniciarJogo.Text = "OK";
            buttonIniciarJogo.UseVisualStyleBackColor = true;
            buttonIniciarJogo.Click += buttonIniciarJogo_Click;
            // 
            // labelMain
            // 
            labelMain.Anchor = AnchorStyles.Top;
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMain.Location = new Point(31, 27);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(392, 32);
            labelMain.TabIndex = 0;
            labelMain.Text = "Pense em um prato que você gosta";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 154);
            Controls.Add(buttonIniciarJogo);
            Controls.Add(labelMain);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo Gourmet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMain;
    }
}
