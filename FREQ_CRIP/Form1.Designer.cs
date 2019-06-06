namespace FREQ_CRIP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ShifrText = new System.Windows.Forms.TextBox();
            this.Text = new System.Windows.Forms.TextBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.button_unShifr = new System.Windows.Forms.Button();
            this.button_Shifr = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShifrText
            // 
            this.ShifrText.Location = new System.Drawing.Point(196, 305);
            this.ShifrText.Name = "ShifrText";
            this.ShifrText.Size = new System.Drawing.Size(456, 20);
            this.ShifrText.TabIndex = 14;
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(196, 125);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(456, 20);
            this.Text.TabIndex = 13;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(148, 211);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(189, 20);
            this.keyBox.TabIndex = 12;
            // 
            // button_unShifr
            // 
            this.button_unShifr.Location = new System.Drawing.Point(371, 232);
            this.button_unShifr.Name = "button_unShifr";
            this.button_unShifr.Size = new System.Drawing.Size(124, 23);
            this.button_unShifr.TabIndex = 11;
            this.button_unShifr.Text = "Расшифровать";
            this.button_unShifr.UseVisualStyleBackColor = true;
            // 
            // button_Shifr
            // 
            this.button_Shifr.Location = new System.Drawing.Point(371, 189);
            this.button_Shifr.Name = "button_Shifr";
            this.button_Shifr.Size = new System.Drawing.Size(124, 23);
            this.button_Shifr.TabIndex = 10;
            this.button_Shifr.Text = "Зашифровать";
            this.button_Shifr.UseVisualStyleBackColor = true;
            this.button_Shifr.Click += new System.EventHandler(this.button_Shifr_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog2";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(658, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(724, 605);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 629);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ShifrText);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.button_unShifr);
            this.Controls.Add(this.button_Shifr);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShifrText;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button button_unShifr;
        private System.Windows.Forms.Button button_Shifr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

