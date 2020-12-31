
namespace Lesson7
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
            this.Plus1 = new System.Windows.Forms.Button();
            this.MultiplyX2 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DropToDeafult = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Plus1
            // 
            this.Plus1.Enabled = false;
            this.Plus1.Location = new System.Drawing.Point(188, 17);
            this.Plus1.Name = "Plus1";
            this.Plus1.Size = new System.Drawing.Size(104, 23);
            this.Plus1.TabIndex = 0;
            this.Plus1.Text = "+1";
            this.Plus1.UseVisualStyleBackColor = true;
            this.Plus1.Click += new System.EventHandler(this.Plus1Button);
            // 
            // MultiplyX2
            // 
            this.MultiplyX2.Enabled = false;
            this.MultiplyX2.Location = new System.Drawing.Point(188, 50);
            this.MultiplyX2.Name = "MultiplyX2";
            this.MultiplyX2.Size = new System.Drawing.Size(104, 23);
            this.MultiplyX2.TabIndex = 1;
            this.MultiplyX2.Text = "x2";
            this.MultiplyX2.UseVisualStyleBackColor = true;
            this.MultiplyX2.Click += new System.EventHandler(this.MultiplyButton);
            // 
            // Back
            // 
            this.Back.Enabled = false;
            this.Back.Location = new System.Drawing.Point(188, 79);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(104, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.BackButton);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ваше число: ";
            // 
            // Play
            // 
            this.Play.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Play.Location = new System.Drawing.Point(298, 17);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(194, 85);
            this.Play.TabIndex = 4;
            this.Play.Text = "Играть";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.PlayButton);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Загаданное число:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.MultiplyX2);
            this.panel1.Controls.Add(this.DropToDeafult);
            this.panel1.Controls.Add(this.Play);
            this.panel1.Controls.Add(this.Plus1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 114);
            this.panel1.TabIndex = 9;
            // 
            // DropToDeafult
            // 
            this.DropToDeafult.Location = new System.Drawing.Point(498, 47);
            this.DropToDeafult.Name = "DropToDeafult";
            this.DropToDeafult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DropToDeafult.Size = new System.Drawing.Size(104, 25);
            this.DropToDeafult.TabIndex = 8;
            this.DropToDeafult.Text = "Сброс";
            this.DropToDeafult.UseVisualStyleBackColor = true;
            this.DropToDeafult.Click += new System.EventHandler(this.DropTOdefault);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus1;
        private System.Windows.Forms.Button MultiplyX2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DropToDeafult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

