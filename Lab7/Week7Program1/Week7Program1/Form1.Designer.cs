namespace Week7Program1
{
    partial class Form1
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
            this.box1 = new System.Windows.Forms.GroupBox();
            this.teaCoffee = new System.Windows.Forms.CheckBox();
            this.drinks = new System.Windows.Forms.CheckBox();
            this.pizza = new System.Windows.Forms.CheckBox();
            this.sushi = new System.Windows.Forms.CheckBox();
            this.cereal = new System.Windows.Forms.CheckBox();
            this.bananaBread = new System.Windows.Forms.CheckBox();
            this.juice = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cerealPrice = new System.Windows.Forms.Label();
            this.sushiPrice = new System.Windows.Forms.Label();
            this.pizzaPrice = new System.Windows.Forms.Label();
            this.drinksPrice = new System.Windows.Forms.Label();
            this.bananaBreadPrice = new System.Windows.Forms.Label();
            this.juicePrice = new System.Windows.Forms.Label();
            this.teaCoffeePrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.Controls.Add(this.teaCoffeePrice);
            this.box1.Controls.Add(this.juicePrice);
            this.box1.Controls.Add(this.bananaBreadPrice);
            this.box1.Controls.Add(this.drinksPrice);
            this.box1.Controls.Add(this.pizzaPrice);
            this.box1.Controls.Add(this.sushiPrice);
            this.box1.Controls.Add(this.cerealPrice);
            this.box1.Controls.Add(this.label3);
            this.box1.Controls.Add(this.label2);
            this.box1.Controls.Add(this.juice);
            this.box1.Controls.Add(this.bananaBread);
            this.box1.Controls.Add(this.cereal);
            this.box1.Controls.Add(this.sushi);
            this.box1.Controls.Add(this.pizza);
            this.box1.Controls.Add(this.drinks);
            this.box1.Controls.Add(this.teaCoffee);
            this.box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box1.Location = new System.Drawing.Point(24, 70);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(343, 347);
            this.box1.TabIndex = 0;
            this.box1.TabStop = false;
            this.box1.Text = "Menu";
            this.box1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // teaCoffee
            // 
            this.teaCoffee.AutoSize = true;
            this.teaCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teaCoffee.Location = new System.Drawing.Point(18, 65);
            this.teaCoffee.Name = "teaCoffee";
            this.teaCoffee.Size = new System.Drawing.Size(117, 24);
            this.teaCoffee.TabIndex = 0;
            this.teaCoffee.Text = "Tea/Coffee";
            this.teaCoffee.UseVisualStyleBackColor = true;
            this.teaCoffee.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // drinks
            // 
            this.drinks.AutoSize = true;
            this.drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinks.Location = new System.Drawing.Point(18, 310);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(79, 24);
            this.drinks.TabIndex = 1;
            this.drinks.Text = "Drinks";
            this.drinks.UseVisualStyleBackColor = true;
            // 
            // pizza
            // 
            this.pizza.AutoSize = true;
            this.pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizza.Location = new System.Drawing.Point(18, 268);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(71, 24);
            this.pizza.TabIndex = 2;
            this.pizza.Text = "Pizza";
            this.pizza.UseVisualStyleBackColor = true;
            // 
            // sushi
            // 
            this.sushi.AutoSize = true;
            this.sushi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sushi.Location = new System.Drawing.Point(18, 226);
            this.sushi.Name = "sushi";
            this.sushi.Size = new System.Drawing.Size(73, 24);
            this.sushi.TabIndex = 3;
            this.sushi.Text = "Sushi";
            this.sushi.UseVisualStyleBackColor = true;
            // 
            // cereal
            // 
            this.cereal.AutoSize = true;
            this.cereal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cereal.Location = new System.Drawing.Point(18, 187);
            this.cereal.Name = "cereal";
            this.cereal.Size = new System.Drawing.Size(80, 24);
            this.cereal.TabIndex = 4;
            this.cereal.Text = "Cereal";
            this.cereal.UseVisualStyleBackColor = true;
            // 
            // bananaBread
            // 
            this.bananaBread.AutoSize = true;
            this.bananaBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bananaBread.Location = new System.Drawing.Point(18, 146);
            this.bananaBread.Name = "bananaBread";
            this.bananaBread.Size = new System.Drawing.Size(143, 24);
            this.bananaBread.TabIndex = 5;
            this.bananaBread.Text = "Banana Bread";
            this.bananaBread.UseVisualStyleBackColor = true;
            // 
            // juice
            // 
            this.juice.AutoSize = true;
            this.juice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juice.Location = new System.Drawing.Point(18, 106);
            this.juice.Name = "juice";
            this.juice.Size = new System.Drawing.Size(70, 24);
            this.juice.TabIndex = 6;
            this.juice.Text = "Juice";
            this.juice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price $";
            // 
            // cerealPrice
            // 
            this.cerealPrice.AutoSize = true;
            this.cerealPrice.Location = new System.Drawing.Point(264, 191);
            this.cerealPrice.Name = "cerealPrice";
            this.cerealPrice.Size = new System.Drawing.Size(44, 20);
            this.cerealPrice.TabIndex = 9;
            this.cerealPrice.Text = "5.50";
            // 
            // sushiPrice
            // 
            this.sushiPrice.AutoSize = true;
            this.sushiPrice.Location = new System.Drawing.Point(264, 230);
            this.sushiPrice.Name = "sushiPrice";
            this.sushiPrice.Size = new System.Drawing.Size(44, 20);
            this.sushiPrice.TabIndex = 10;
            this.sushiPrice.Text = "3.00";
            // 
            // pizzaPrice
            // 
            this.pizzaPrice.AutoSize = true;
            this.pizzaPrice.Location = new System.Drawing.Point(264, 272);
            this.pizzaPrice.Name = "pizzaPrice";
            this.pizzaPrice.Size = new System.Drawing.Size(44, 20);
            this.pizzaPrice.TabIndex = 11;
            this.pizzaPrice.Text = "9.00";
            // 
            // drinksPrice
            // 
            this.drinksPrice.AutoSize = true;
            this.drinksPrice.Location = new System.Drawing.Point(264, 314);
            this.drinksPrice.Name = "drinksPrice";
            this.drinksPrice.Size = new System.Drawing.Size(44, 20);
            this.drinksPrice.TabIndex = 12;
            this.drinksPrice.Text = "3.50";
            // 
            // bananaBreadPrice
            // 
            this.bananaBreadPrice.AutoSize = true;
            this.bananaBreadPrice.Location = new System.Drawing.Point(264, 150);
            this.bananaBreadPrice.Name = "bananaBreadPrice";
            this.bananaBreadPrice.Size = new System.Drawing.Size(44, 20);
            this.bananaBreadPrice.TabIndex = 13;
            this.bananaBreadPrice.Text = "2.50";
            // 
            // juicePrice
            // 
            this.juicePrice.AutoSize = true;
            this.juicePrice.Location = new System.Drawing.Point(264, 110);
            this.juicePrice.Name = "juicePrice";
            this.juicePrice.Size = new System.Drawing.Size(44, 20);
            this.juicePrice.TabIndex = 14;
            this.juicePrice.Text = "3.50";
            // 
            // teaCoffeePrice
            // 
            this.teaCoffeePrice.AutoSize = true;
            this.teaCoffeePrice.Location = new System.Drawing.Point(264, 69);
            this.teaCoffeePrice.Name = "teaCoffeePrice";
            this.teaCoffeePrice.Size = new System.Drawing.Size(44, 20);
            this.teaCoffeePrice.TabIndex = 15;
            this.teaCoffeePrice.Text = "4.80";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(251, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.Text = "Student Restaurant Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox box1;
        private System.Windows.Forms.CheckBox teaCoffee;
        private System.Windows.Forms.Label teaCoffeePrice;
        private System.Windows.Forms.Label juicePrice;
        private System.Windows.Forms.Label bananaBreadPrice;
        private System.Windows.Forms.Label drinksPrice;
        private System.Windows.Forms.Label pizzaPrice;
        private System.Windows.Forms.Label sushiPrice;
        private System.Windows.Forms.Label cerealPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox juice;
        private System.Windows.Forms.CheckBox bananaBread;
        private System.Windows.Forms.CheckBox cereal;
        private System.Windows.Forms.CheckBox sushi;
        private System.Windows.Forms.CheckBox pizza;
        private System.Windows.Forms.CheckBox drinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

