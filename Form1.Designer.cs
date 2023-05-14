namespace OOP_Lab_4_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.labelABC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(87, 202);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(152, 20);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            this.textBoxA.Leave += new System.EventHandler(this.textBoxA_Leave);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(87, 251);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownA.TabIndex = 1;
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            this.numericUpDownA.Leave += new System.EventHandler(this.numericUpDownA_Leave);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(87, 297);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(152, 45);
            this.trackBarA.TabIndex = 2;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(321, 297);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(152, 45);
            this.trackBarB.TabIndex = 3;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(542, 297);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(152, 45);
            this.trackBarC.TabIndex = 4;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBarC_Scroll);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(321, 202);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(152, 20);
            this.textBoxB.TabIndex = 5;
            this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxB_KeyDown);
            this.textBoxB.Leave += new System.EventHandler(this.textBoxB_Leave);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(542, 202);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(152, 20);
            this.textBoxC.TabIndex = 6;
            this.textBoxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
            this.textBoxC.Leave += new System.EventHandler(this.textBoxC_Leave);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(321, 250);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownB.TabIndex = 7;
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownB_ValueChanged);
            this.numericUpDownB.Leave += new System.EventHandler(this.numericUpDownB_Leave);
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(542, 250);
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownC.TabIndex = 8;
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownC_ValueChanged);
            this.numericUpDownC.Leave += new System.EventHandler(this.numericUpDownC_Leave);
            // 
            // labelABC
            // 
            this.labelABC.AutoSize = true;
            this.labelABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelABC.Location = new System.Drawing.Point(113, 54);
            this.labelABC.Name = "labelABC";
            this.labelABC.Size = new System.Drawing.Size(570, 108);
            this.labelABC.TabIndex = 9;
            this.labelABC.Text = "A <= B <= C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelABC);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.Label labelABC;
    }
}

