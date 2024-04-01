namespace JogoGourmet
{
    partial class InputDialog
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
            labelDialog = new Label();
            buttonOk = new Button();
            buttonCancelar = new Button();
            textBoxDialog = new TextBox();
            SuspendLayout();
            // 
            // labelDialog
            // 
            labelDialog.Location = new Point(-1, 17);
            labelDialog.Name = "labelDialog";
            labelDialog.Size = new Size(361, 15);
            labelDialog.TabIndex = 0;
            labelDialog.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(92, 88);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(194, 88);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 2;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxDialog
            // 
            textBoxDialog.Anchor = AnchorStyles.None;
            textBoxDialog.Location = new Point(92, 45);
            textBoxDialog.Name = "textBoxDialog";
            textBoxDialog.Size = new Size(177, 23);
            textBoxDialog.TabIndex = 3;
            textBoxDialog.TextAlign = HorizontalAlignment.Center;
            // 
            // InputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 138);
            Controls.Add(textBoxDialog);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Controls.Add(labelDialog);
            Name = "InputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDialog;
        private Button buttonOk;
        private Button buttonCancelar;
        private TextBox textBoxDialog;
    }
}