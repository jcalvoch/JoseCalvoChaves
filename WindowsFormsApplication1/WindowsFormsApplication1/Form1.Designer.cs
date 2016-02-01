namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPush = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHolaMundo = new System.Windows.Forms.TextBox();
            this.textBoxI = new System.Windows.Forms.TextBox();
            this.textBoxMyString = new System.Windows.Forms.TextBox();
            this.textBoxArray = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(255, 253);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(75, 23);
            this.buttonPush.TabIndex = 0;
            this.buttonPush.Text = "Push me";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aplicación Hola Mundo";
            // 
            // textBoxHolaMundo
            // 
            this.textBoxHolaMundo.Location = new System.Drawing.Point(28, 74);
            this.textBoxHolaMundo.Name = "textBoxHolaMundo";
            this.textBoxHolaMundo.Size = new System.Drawing.Size(100, 20);
            this.textBoxHolaMundo.TabIndex = 2;
            // 
            // textBoxI
            // 
            this.textBoxI.Location = new System.Drawing.Point(28, 115);
            this.textBoxI.Name = "textBoxI";
            this.textBoxI.Size = new System.Drawing.Size(100, 20);
            this.textBoxI.TabIndex = 3;
            // 
            // textBoxMyString
            // 
            this.textBoxMyString.Location = new System.Drawing.Point(28, 154);
            this.textBoxMyString.Name = "textBoxMyString";
            this.textBoxMyString.Size = new System.Drawing.Size(100, 20);
            this.textBoxMyString.TabIndex = 4;
            this.textBoxMyString.TextChanged += new System.EventHandler(this.textBoxMyString_TextChanged);
            // 
            // textBoxArray
            // 
            this.textBoxArray.Location = new System.Drawing.Point(28, 196);
            this.textBoxArray.Name = "textBoxArray";
            this.textBoxArray.Size = new System.Drawing.Size(100, 20);
            this.textBoxArray.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 323);
            this.Controls.Add(this.textBoxArray);
            this.Controls.Add(this.textBoxMyString);
            this.Controls.Add(this.textBoxI);
            this.Controls.Add(this.textBoxHolaMundo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPush);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHolaMundo;
        private System.Windows.Forms.TextBox textBoxI;
        private System.Windows.Forms.TextBox textBoxMyString;
        private System.Windows.Forms.TextBox textBoxArray;
    }
}

