namespace WfMetronome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.interval = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.total_ticks = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tempo = new System.Windows.Forms.NumericUpDown();
            this.ppqn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signature = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Beat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.interval);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.total_ticks);
            this.panel1.Controls.Add(this.duration);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tempo);
            this.panel1.Controls.Add(this.ppqn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.signature);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 123);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // interval
            // 
            this.interval.AutoSize = true;
            this.interval.Location = new System.Drawing.Point(502, 79);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(0, 16);
            this.interval.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Interval  :";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(337, 79);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(18, 16);
            this.total.TabIndex = 10;
            this.total.Text = "0";
            // 
            // total_ticks
            // 
            this.total_ticks.AutoSize = true;
            this.total_ticks.Location = new System.Drawing.Point(193, 79);
            this.total_ticks.Name = "total_ticks";
            this.total_ticks.Size = new System.Drawing.Size(138, 16);
            this.total_ticks.TabIndex = 9;
            this.total_ticks.Text = "Total Ticks :";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(125, 79);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(28, 16);
            this.duration.TabIndex = 8;
            this.duration.Text = "0s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Duration :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tempo
            // 
            this.tempo.Location = new System.Drawing.Point(192, 31);
            this.tempo.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(120, 23);
            this.tempo.TabIndex = 5;
            this.tempo.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.tempo.ValueChanged += new System.EventHandler(this.tempo_ValueChanged);
            // 
            // ppqn
            // 
            this.ppqn.FormattingEnabled = true;
            this.ppqn.Items.AddRange(new object[] {
            "12",
            "24",
            "48"});
            this.ppqn.Location = new System.Drawing.Point(334, 31);
            this.ppqn.Name = "ppqn";
            this.ppqn.Size = new System.Drawing.Size(121, 24);
            this.ppqn.TabIndex = 4;
            this.ppqn.Text = "24";
            this.ppqn.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "PPQN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Signature";
            // 
            // signature
            // 
            this.signature.FormattingEnabled = true;
            this.signature.Items.AddRange(new object[] {
            "4:4",
            "2:4",
            "3:4"});
            this.signature.Location = new System.Drawing.Point(14, 31);
            this.signature.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(150, 24);
            this.signature.TabIndex = 0;
            this.signature.Text = "4:4";
            this.signature.SelectedIndexChanged += new System.EventHandler(this.signature_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tick";
            // 
            // Beat
            // 
            this.Beat.AutoSize = true;
            this.Beat.Location = new System.Drawing.Point(125, 169);
            this.Beat.Name = "Beat";
            this.Beat.Size = new System.Drawing.Size(38, 16);
            this.Beat.TabIndex = 5;
            this.Beat.Text = "Bar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Elapsed Time (seconds)";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(560, 31);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 13;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(678, 322);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Beat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Midi PPQN Clock &  Metronome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ppqn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox signature;
        private System.Windows.Forms.NumericUpDown tempo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label total_ticks;
        private System.Windows.Forms.Label interval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Beat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button reset;
    }
}

