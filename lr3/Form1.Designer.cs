namespace lr3
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
            this.productList = new System.Windows.Forms.ListBox();
            this.product1 = new System.Windows.Forms.CheckBox();
            this.product2 = new System.Windows.Forms.CheckBox();
            this.product3 = new System.Windows.Forms.CheckBox();
            this.createOrder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.productQuantity1 = new System.Windows.Forms.NumericUpDown();
            this.productQuantity2 = new System.Windows.Forms.NumericUpDown();
            this.productQuantity3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity3)).BeginInit();
            this.SuspendLayout();
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(93, 49);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(222, 95);
            this.productList.TabIndex = 0;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // product1
            // 
            this.product1.AutoSize = true;
            this.product1.Location = new System.Drawing.Point(321, 58);
            this.product1.Name = "product1";
            this.product1.Size = new System.Drawing.Size(15, 14);
            this.product1.TabIndex = 1;
            this.product1.UseVisualStyleBackColor = true;
            this.product1.CheckedChanged += new System.EventHandler(this.product1_CheckedChanged);
            // 
            // product2
            // 
            this.product2.AutoSize = true;
            this.product2.Location = new System.Drawing.Point(321, 81);
            this.product2.Name = "product2";
            this.product2.Size = new System.Drawing.Size(15, 14);
            this.product2.TabIndex = 2;
            this.product2.UseVisualStyleBackColor = true;
            // 
            // product3
            // 
            this.product3.AutoSize = true;
            this.product3.Location = new System.Drawing.Point(321, 104);
            this.product3.Name = "product3";
            this.product3.Size = new System.Drawing.Size(15, 14);
            this.product3.TabIndex = 3;
            this.product3.UseVisualStyleBackColor = true;
            // 
            // createOrder
            // 
            this.createOrder.Location = new System.Drawing.Point(205, 150);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(75, 23);
            this.createOrder.TabIndex = 4;
            this.createOrder.Text = "Заказать";
            this.createOrder.UseVisualStyleBackColor = true;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 192);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(223, 215);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // productQuantity1
            // 
            this.productQuantity1.Location = new System.Drawing.Point(535, 58);
            this.productQuantity1.Name = "productQuantity1";
            this.productQuantity1.Size = new System.Drawing.Size(120, 20);
            this.productQuantity1.TabIndex = 6;
            this.productQuantity1.ValueChanged += new System.EventHandler(this.productQuantity1_ValueChanged);
            // 
            // productQuantity2
            // 
            this.productQuantity2.Location = new System.Drawing.Point(535, 81);
            this.productQuantity2.Name = "productQuantity2";
            this.productQuantity2.Size = new System.Drawing.Size(120, 20);
            this.productQuantity2.TabIndex = 7;
            // 
            // productQuantity3
            // 
            this.productQuantity3.Location = new System.Drawing.Point(535, 102);
            this.productQuantity3.Name = "productQuantity3";
            this.productQuantity3.Size = new System.Drawing.Size(120, 20);
            this.productQuantity3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productQuantity3);
            this.Controls.Add(this.productQuantity2);
            this.Controls.Add(this.productQuantity1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createOrder);
            this.Controls.Add(this.product3);
            this.Controls.Add(this.product2);
            this.Controls.Add(this.product1);
            this.Controls.Add(this.productList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.CheckBox product1;
        private System.Windows.Forms.CheckBox product2;
        private System.Windows.Forms.CheckBox product3;
        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown productQuantity1;
        private System.Windows.Forms.NumericUpDown productQuantity2;
        private System.Windows.Forms.NumericUpDown productQuantity3;
    }
}

