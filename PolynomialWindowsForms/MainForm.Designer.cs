namespace PolynomialWindowsForms
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartPoly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrintPoly = new System.Windows.Forms.TextBox();
            this.buttonCreatePoly = new System.Windows.Forms.Button();
            this.textBoxCreatePoly = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrintPoly2 = new System.Windows.Forms.TextBox();
            this.buttonOperator = new System.Windows.Forms.Button();
            this.domainOperator = new System.Windows.Forms.DomainUpDown();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonClearGraf = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreateGraf = new System.Windows.Forms.Button();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxCreateGraf = new System.Windows.Forms.TextBox();
            this.buttonShowTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoly)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPoly
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPoly.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPoly.Legends.Add(legend1);
            this.chartPoly.Location = new System.Drawing.Point(12, 12);
            this.chartPoly.Name = "chartPoly";
            this.chartPoly.Size = new System.Drawing.Size(937, 694);
            this.chartPoly.TabIndex = 0;
            this.chartPoly.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Polynomial";
            this.chartPoly.Titles.Add(title1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPrintPoly);
            this.groupBox1.Controls.Add(this.buttonCreatePoly);
            this.groupBox1.Controls.Add(this.textBoxCreatePoly);
            this.groupBox1.Location = new System.Drawing.Point(955, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание полинома";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вывод:";
            // 
            // textBoxPrintPoly
            // 
            this.textBoxPrintPoly.Location = new System.Drawing.Point(6, 92);
            this.textBoxPrintPoly.Name = "textBoxPrintPoly";
            this.textBoxPrintPoly.ReadOnly = true;
            this.textBoxPrintPoly.Size = new System.Drawing.Size(287, 22);
            this.textBoxPrintPoly.TabIndex = 2;
            // 
            // buttonCreatePoly
            // 
            this.buttonCreatePoly.Location = new System.Drawing.Point(299, 29);
            this.buttonCreatePoly.Name = "buttonCreatePoly";
            this.buttonCreatePoly.Size = new System.Drawing.Size(93, 38);
            this.buttonCreatePoly.TabIndex = 1;
            this.buttonCreatePoly.Text = "Создать";
            this.buttonCreatePoly.UseVisualStyleBackColor = true;
            this.buttonCreatePoly.Click += new System.EventHandler(this.buttonCreatePoly_Click);
            // 
            // textBoxCreatePoly
            // 
            this.textBoxCreatePoly.Location = new System.Drawing.Point(6, 37);
            this.textBoxCreatePoly.Name = "textBoxCreatePoly";
            this.textBoxCreatePoly.Size = new System.Drawing.Size(287, 22);
            this.textBoxCreatePoly.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxPrintPoly2);
            this.groupBox2.Controls.Add(this.buttonOperator);
            this.groupBox2.Controls.Add(this.domainOperator);
            this.groupBox2.Controls.Add(this.textBoxB);
            this.groupBox2.Controls.Add(this.textBoxA);
            this.groupBox2.Location = new System.Drawing.Point(955, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции над полиномом";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вывод:";
            // 
            // textBoxPrintPoly2
            // 
            this.textBoxPrintPoly2.Location = new System.Drawing.Point(10, 136);
            this.textBoxPrintPoly2.Name = "textBoxPrintPoly2";
            this.textBoxPrintPoly2.ReadOnly = true;
            this.textBoxPrintPoly2.Size = new System.Drawing.Size(283, 22);
            this.textBoxPrintPoly2.TabIndex = 4;
            // 
            // buttonOperator
            // 
            this.buttonOperator.Location = new System.Drawing.Point(299, 42);
            this.buttonOperator.Name = "buttonOperator";
            this.buttonOperator.Size = new System.Drawing.Size(93, 38);
            this.buttonOperator.TabIndex = 3;
            this.buttonOperator.Text = "Посчитать";
            this.buttonOperator.UseVisualStyleBackColor = true;
            this.buttonOperator.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // domainOperator
            // 
            this.domainOperator.Items.Add("+");
            this.domainOperator.Items.Add("-");
            this.domainOperator.Items.Add("*");
            this.domainOperator.Items.Add("/");
            this.domainOperator.Location = new System.Drawing.Point(10, 51);
            this.domainOperator.Name = "domainOperator";
            this.domainOperator.Size = new System.Drawing.Size(120, 22);
            this.domainOperator.TabIndex = 2;
            this.domainOperator.Text = "Оператор";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(10, 79);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(283, 22);
            this.textBoxB.TabIndex = 1;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(10, 22);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(283, 22);
            this.textBoxA.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonClearGraf);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonCreateGraf);
            this.groupBox3.Controls.Add(this.textBoxTo);
            this.groupBox3.Controls.Add(this.textBoxFrom);
            this.groupBox3.Controls.Add(this.textBoxCreateGraf);
            this.groupBox3.Location = new System.Drawing.Point(955, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 130);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Построение графика";
            // 
            // buttonClearGraf
            // 
            this.buttonClearGraf.Location = new System.Drawing.Point(299, 72);
            this.buttonClearGraf.Name = "buttonClearGraf";
            this.buttonClearGraf.Size = new System.Drawing.Size(93, 39);
            this.buttonClearGraf.TabIndex = 6;
            this.buttonClearGraf.Text = "Очистить";
            this.buttonClearGraf.UseVisualStyleBackColor = true;
            this.buttonClearGraf.Click += new System.EventHandler(this.buttonClearGraf_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "До";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "От";
            // 
            // buttonCreateGraf
            // 
            this.buttonCreateGraf.Location = new System.Drawing.Point(299, 22);
            this.buttonCreateGraf.Name = "buttonCreateGraf";
            this.buttonCreateGraf.Size = new System.Drawing.Size(93, 38);
            this.buttonCreateGraf.TabIndex = 3;
            this.buttonCreateGraf.Text = "Построить";
            this.buttonCreateGraf.UseVisualStyleBackColor = true;
            this.buttonCreateGraf.Click += new System.EventHandler(this.buttonCreateGraf_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(178, 69);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(100, 22);
            this.textBoxTo.TabIndex = 2;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(39, 69);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(100, 22);
            this.textBoxFrom.TabIndex = 1;
            // 
            // textBoxCreateGraf
            // 
            this.textBoxCreateGraf.Location = new System.Drawing.Point(10, 22);
            this.textBoxCreateGraf.Name = "textBoxCreateGraf";
            this.textBoxCreateGraf.Size = new System.Drawing.Size(283, 22);
            this.textBoxCreateGraf.TabIndex = 0;
            // 
            // buttonShowTask
            // 
            this.buttonShowTask.Location = new System.Drawing.Point(1058, 565);
            this.buttonShowTask.Name = "buttonShowTask";
            this.buttonShowTask.Size = new System.Drawing.Size(190, 55);
            this.buttonShowTask.TabIndex = 4;
            this.buttonShowTask.Text = "Показать задание";
            this.buttonShowTask.UseVisualStyleBackColor = true;
            this.buttonShowTask.Click += new System.EventHandler(this.buttonShowTask_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 718);
            this.Controls.Add(this.buttonShowTask);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartPoly);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartPoly)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPoly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCreatePoly;
        private System.Windows.Forms.TextBox textBoxCreatePoly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrintPoly;
        private System.Windows.Forms.DomainUpDown domainOperator;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrintPoly2;
        private System.Windows.Forms.Button buttonOperator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreateGraf;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxCreateGraf;
        private System.Windows.Forms.Button buttonClearGraf;
        private System.Windows.Forms.Button buttonShowTask;
    }
}

