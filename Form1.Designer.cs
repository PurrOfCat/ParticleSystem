
namespace ParticleSystem
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.tbMove = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblMove = new System.Windows.Forms.Label();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.tbParticlesPerTick = new System.Windows.Forms.TrackBar();
            this.lblSpreading = new System.Windows.Forms.Label();
            this.lblParticlesPerTick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParticlesPerTick)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(613, 460);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(633, 76);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(202, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Value = 90;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // tbMove
            // 
            this.tbMove.Location = new System.Drawing.Point(633, 373);
            this.tbMove.Maximum = 400;
            this.tbMove.Minimum = 200;
            this.tbMove.Name = "tbMove";
            this.tbMove.Size = new System.Drawing.Size(202, 45);
            this.tbMove.TabIndex = 2;
            this.tbMove.Value = 200;
            this.tbMove.Scroll += new System.EventHandler(this.tbMove_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDirection.Location = new System.Drawing.Point(676, 53);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(112, 20);
            this.lblDirection.TabIndex = 3;
            this.lblDirection.Text = "Направление";
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMove.Location = new System.Drawing.Point(676, 350);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(117, 20);
            this.lblMove.TabIndex = 4;
            this.lblMove.Text = "Перемещение";
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(633, 177);
            this.tbSpreading.Maximum = 359;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(202, 45);
            this.tbSpreading.TabIndex = 5;
            this.tbSpreading.Value = 100;
            this.tbSpreading.Scroll += new System.EventHandler(this.tbSpreading_Scroll);
            // 
            // tbParticlesPerTick
            // 
            this.tbParticlesPerTick.Location = new System.Drawing.Point(635, 274);
            this.tbParticlesPerTick.Maximum = 50;
            this.tbParticlesPerTick.Name = "tbParticlesPerTick";
            this.tbParticlesPerTick.Size = new System.Drawing.Size(200, 45);
            this.tbParticlesPerTick.TabIndex = 6;
            this.tbParticlesPerTick.Scroll += new System.EventHandler(this.tbParticlesPerTick_Scroll);
            // 
            // lblSpreading
            // 
            this.lblSpreading.AutoSize = true;
            this.lblSpreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSpreading.Location = new System.Drawing.Point(669, 154);
            this.lblSpreading.Name = "lblSpreading";
            this.lblSpreading.Size = new System.Drawing.Size(129, 20);
            this.lblSpreading.TabIndex = 7;
            this.lblSpreading.Text = "Распределение";
            // 
            // lblParticlesPerTick
            // 
            this.lblParticlesPerTick.AutoSize = true;
            this.lblParticlesPerTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblParticlesPerTick.Location = new System.Drawing.Point(635, 251);
            this.lblParticlesPerTick.Name = "lblParticlesPerTick";
            this.lblParticlesPerTick.Size = new System.Drawing.Size(200, 20);
            this.lblParticlesPerTick.TabIndex = 8;
            this.lblParticlesPerTick.Text = "Количество частиц в тик";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 484);
            this.Controls.Add(this.lblParticlesPerTick);
            this.Controls.Add(this.lblSpreading);
            this.Controls.Add(this.tbParticlesPerTick);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbMove);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Система частиц";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParticlesPerTick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.TrackBar tbMove;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.TrackBar tbParticlesPerTick;
        private System.Windows.Forms.Label lblSpreading;
        private System.Windows.Forms.Label lblParticlesPerTick;
    }
}

