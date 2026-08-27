
namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.accuracyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.initialApproximationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yakobiLabel = new System.Windows.Forms.Label();
            this.zeidelLabel = new System.Windows.Forms.Label();
            this.readFileButton = new System.Windows.Forms.Button();
            this.generateMatrixButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkingLabel = new System.Windows.Forms.Label();
            this.ResidialNormLabel = new System.Windows.Forms.Label();
            this.middleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accuracyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialApproximationChart)).BeginInit();
            this.SuspendLayout();
            // 
            // accuracyChart
            // 
            this.accuracyChart.Location = new System.Drawing.Point(12, 95);
            this.accuracyChart.Name = "accuracyChart";
            this.accuracyChart.Size = new System.Drawing.Size(451, 372);
            this.accuracyChart.TabIndex = 0;
            this.accuracyChart.Text = "chart1";
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title7.Name = "Title1";
            title7.Text = "Зависимость числа итераций от точности";
            this.accuracyChart.Titles.Add(title7);
            this.accuracyChart.Visible = false;
            // 
            // initialApproximationChart
            // 
            this.initialApproximationChart.Location = new System.Drawing.Point(481, 95);
            this.initialApproximationChart.Name = "initialApproximationChart";
            this.initialApproximationChart.Size = new System.Drawing.Size(451, 372);
            this.initialApproximationChart.TabIndex = 1;
            this.initialApproximationChart.Text = "chart1";
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title8.Name = "Title1";
            title8.Text = "Зависимость числа итераций от начального приближения";
            this.initialApproximationChart.Titles.Add(title8);
            this.initialApproximationChart.Visible = false;
            // 
            // yakobiLabel
            // 
            this.yakobiLabel.AutoSize = true;
            this.yakobiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yakobiLabel.Location = new System.Drawing.Point(12, 470);
            this.yakobiLabel.Name = "yakobiLabel";
            this.yakobiLabel.Size = new System.Drawing.Size(51, 20);
            this.yakobiLabel.TabIndex = 2;
            this.yakobiLabel.Text = "label1";
            this.yakobiLabel.Visible = false;
            // 
            // zeidelLabel
            // 
            this.zeidelLabel.AutoSize = true;
            this.zeidelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeidelLabel.Location = new System.Drawing.Point(12, 499);
            this.zeidelLabel.Name = "zeidelLabel";
            this.zeidelLabel.Size = new System.Drawing.Size(51, 20);
            this.zeidelLabel.TabIndex = 3;
            this.zeidelLabel.Text = "label1";
            this.zeidelLabel.Visible = false;
            // 
            // readFileButton
            // 
            this.readFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readFileButton.Location = new System.Drawing.Point(12, 5);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(451, 34);
            this.readFileButton.TabIndex = 4;
            this.readFileButton.Text = "Прочитать данные из файла";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // generateMatrixButton
            // 
            this.generateMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateMatrixButton.Location = new System.Drawing.Point(481, 5);
            this.generateMatrixButton.Name = "generateMatrixButton";
            this.generateMatrixButton.Size = new System.Drawing.Size(451, 34);
            this.generateMatrixButton.TabIndex = 5;
            this.generateMatrixButton.Text = "Сгенерировать матрицу случайным образом";
            this.generateMatrixButton.UseVisualStyleBackColor = true;
            this.generateMatrixButton.Click += new System.EventHandler(this.generateMatrixButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(477, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество переменных:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(678, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "1000";
            // 
            // checkingLabel
            // 
            this.checkingLabel.AutoSize = true;
            this.checkingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkingLabel.Location = new System.Drawing.Point(216, 71);
            this.checkingLabel.Name = "checkingLabel";
            this.checkingLabel.Size = new System.Drawing.Size(491, 20);
            this.checkingLabel.TabIndex = 8;
            this.checkingLabel.Text = "Достаточное условие сходимости метода Якоби выполняется.";
            this.checkingLabel.Visible = false;
            // 
            // ResidialNormLabel
            // 
            this.ResidialNormLabel.AutoSize = true;
            this.ResidialNormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidialNormLabel.Location = new System.Drawing.Point(12, 525);
            this.ResidialNormLabel.Name = "ResidialNormLabel";
            this.ResidialNormLabel.Size = new System.Drawing.Size(38, 20);
            this.ResidialNormLabel.TabIndex = 9;
            this.ResidialNormLabel.Text = "Res";
            this.ResidialNormLabel.Visible = false;
            // 
            // middleLabel
            // 
            this.middleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleLabel.Location = new System.Drawing.Point(477, 525);
            this.middleLabel.Name = "middleLabel";
            this.middleLabel.Size = new System.Drawing.Size(455, 61);
            this.middleLabel.TabIndex = 10;
            this.middleLabel.Text = "Среднее отношения суммы модулей недиагональных \r\nэлементов строки к модулю диагон" +
    "ального\r\nэлемента —";
            this.middleLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 595);
            this.Controls.Add(this.middleLabel);
            this.Controls.Add(this.ResidialNormLabel);
            this.Controls.Add(this.checkingLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateMatrixButton);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.zeidelLabel);
            this.Controls.Add(this.yakobiLabel);
            this.Controls.Add(this.initialApproximationChart);
            this.Controls.Add(this.accuracyChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accuracyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialApproximationChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart accuracyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart initialApproximationChart;
        private System.Windows.Forms.Label yakobiLabel;
        private System.Windows.Forms.Label zeidelLabel;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Button generateMatrixButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label checkingLabel;
        private System.Windows.Forms.Label ResidialNormLabel;
        private System.Windows.Forms.Label middleLabel;
    }
}

