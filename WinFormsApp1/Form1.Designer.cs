namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_distance = new Label();
            tB_distance = new TextBox();
            tB_averageFuelConsumption = new TextBox();
            lb_averageFuelConsumption = new Label();
            tB_costOfOneLiter = new TextBox();
            lb_costOfOneLiter = new Label();
            btn_Enter = new Button();
            lb_sumGrivna = new Label();
            tb_sumhrivna = new TextBox();
            tb_sumdollar = new TextBox();
            lb_sumDolar = new Label();
            tb_carBrand = new TextBox();
            lb_carBrend = new Label();
            tb_model = new TextBox();
            lB_model = new Label();
            SuspendLayout();
            // 
            // lb_distance
            // 
            lb_distance.Anchor = AnchorStyles.None;
            lb_distance.AutoSize = true;
            lb_distance.Location = new Point(32, 21);
            lb_distance.Margin = new Padding(4, 0, 4, 0);
            lb_distance.Name = "lb_distance";
            lb_distance.Size = new Size(94, 28);
            lb_distance.TabIndex = 0;
            lb_distance.Text = "Distance";
            // 
            // tB_distance
            // 
            tB_distance.Anchor = AnchorStyles.None;
            tB_distance.Location = new Point(32, 53);
            tB_distance.Margin = new Padding(4);
            tB_distance.Name = "tB_distance";
            tB_distance.Size = new Size(325, 34);
            tB_distance.TabIndex = 1;
            tB_distance.KeyPress += tB_distance_KeyPress;
            // 
            // tB_averageFuelConsumption
            // 
            tB_averageFuelConsumption.Anchor = AnchorStyles.None;
            tB_averageFuelConsumption.Location = new Point(32, 135);
            tB_averageFuelConsumption.Margin = new Padding(4);
            tB_averageFuelConsumption.Name = "tB_averageFuelConsumption";
            tB_averageFuelConsumption.Size = new Size(325, 34);
            tB_averageFuelConsumption.TabIndex = 3;
            tB_averageFuelConsumption.KeyPress += tB_averageFuelConsumption_KeyPress;
            // 
            // lb_averageFuelConsumption
            // 
            lb_averageFuelConsumption.Anchor = AnchorStyles.None;
            lb_averageFuelConsumption.AutoSize = true;
            lb_averageFuelConsumption.Location = new Point(32, 103);
            lb_averageFuelConsumption.Margin = new Padding(4, 0, 4, 0);
            lb_averageFuelConsumption.Name = "lb_averageFuelConsumption";
            lb_averageFuelConsumption.Size = new Size(266, 28);
            lb_averageFuelConsumption.TabIndex = 2;
            lb_averageFuelConsumption.Text = "Average Fuel Consumption";
            // 
            // tB_costOfOneLiter
            // 
            tB_costOfOneLiter.Anchor = AnchorStyles.None;
            tB_costOfOneLiter.Location = new Point(32, 215);
            tB_costOfOneLiter.Margin = new Padding(4);
            tB_costOfOneLiter.Name = "tB_costOfOneLiter";
            tB_costOfOneLiter.Size = new Size(325, 34);
            tB_costOfOneLiter.TabIndex = 5;
            tB_costOfOneLiter.KeyPress += tB_costOfOneLiter_KeyPress;
            // 
            // lb_costOfOneLiter
            // 
            lb_costOfOneLiter.Anchor = AnchorStyles.None;
            lb_costOfOneLiter.AutoSize = true;
            lb_costOfOneLiter.Location = new Point(32, 183);
            lb_costOfOneLiter.Margin = new Padding(4, 0, 4, 0);
            lb_costOfOneLiter.Name = "lb_costOfOneLiter";
            lb_costOfOneLiter.Size = new Size(175, 28);
            lb_costOfOneLiter.TabIndex = 4;
            lb_costOfOneLiter.Text = "Cost Of One Liter";
            // 
            // btn_Enter
            // 
            btn_Enter.Anchor = AnchorStyles.None;
            btn_Enter.Location = new Point(144, 361);
            btn_Enter.Name = "btn_Enter";
            btn_Enter.Size = new Size(154, 43);
            btn_Enter.TabIndex = 6;
            btn_Enter.Text = "Enter";
            btn_Enter.UseVisualStyleBackColor = true;
            btn_Enter.Click += btn_Enter_Click;
            // 
            // lb_sumGrivna
            // 
            lb_sumGrivna.Anchor = AnchorStyles.None;
            lb_sumGrivna.AutoSize = true;
            lb_sumGrivna.Location = new Point(32, 444);
            lb_sumGrivna.Name = "lb_sumGrivna";
            lb_sumGrivna.Size = new Size(164, 28);
            lb_sumGrivna.TabIndex = 7;
            lb_sumGrivna.Text = "Sum in hryvnias";
            // 
            // tb_sumhrivna
            // 
            tb_sumhrivna.Anchor = AnchorStyles.None;
            tb_sumhrivna.Enabled = false;
            tb_sumhrivna.Location = new Point(32, 481);
            tb_sumhrivna.Name = "tb_sumhrivna";
            tb_sumhrivna.Size = new Size(125, 34);
            tb_sumhrivna.TabIndex = 8;
            // 
            // tb_sumdollar
            // 
            tb_sumdollar.Anchor = AnchorStyles.None;
            tb_sumdollar.Enabled = false;
            tb_sumdollar.Location = new Point(265, 481);
            tb_sumdollar.Name = "tb_sumdollar";
            tb_sumdollar.Size = new Size(125, 34);
            tb_sumdollar.TabIndex = 10;
            // 
            // lb_sumDolar
            // 
            lb_sumDolar.Anchor = AnchorStyles.None;
            lb_sumDolar.AutoSize = true;
            lb_sumDolar.Location = new Point(265, 444);
            lb_sumDolar.Name = "lb_sumDolar";
            lb_sumDolar.Size = new Size(138, 28);
            lb_sumDolar.TabIndex = 9;
            lb_sumDolar.Text = "Sum in dollar";
            // 
            // tb_carBrand
            // 
            tb_carBrand.Anchor = AnchorStyles.None;
            tb_carBrand.Location = new Point(32, 288);
            tb_carBrand.Margin = new Padding(4);
            tb_carBrand.Name = "tb_carBrand";
            tb_carBrand.Size = new Size(175, 34);
            tb_carBrand.TabIndex = 12;
            // 
            // lb_carBrend
            // 
            lb_carBrend.Anchor = AnchorStyles.None;
            lb_carBrend.AutoSize = true;
            lb_carBrend.Location = new Point(32, 256);
            lb_carBrend.Margin = new Padding(4, 0, 4, 0);
            lb_carBrend.Name = "lb_carBrend";
            lb_carBrend.Size = new Size(105, 28);
            lb_carBrend.TabIndex = 11;
            lb_carBrend.Text = "Car Brand";
            // 
            // tb_model
            // 
            tb_model.Anchor = AnchorStyles.None;
            tb_model.Location = new Point(228, 288);
            tb_model.Margin = new Padding(4);
            tb_model.Name = "tb_model";
            tb_model.Size = new Size(175, 34);
            tb_model.TabIndex = 14;
            // 
            // lB_model
            // 
            lB_model.Anchor = AnchorStyles.None;
            lB_model.AutoSize = true;
            lB_model.Location = new Point(228, 256);
            lB_model.Margin = new Padding(4, 0, 4, 0);
            lB_model.Name = "lB_model";
            lB_model.Size = new Size(72, 28);
            lB_model.TabIndex = 13;
            lB_model.Text = "Model";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(456, 541);
            Controls.Add(tb_model);
            Controls.Add(lB_model);
            Controls.Add(tb_carBrand);
            Controls.Add(lb_carBrend);
            Controls.Add(tb_sumdollar);
            Controls.Add(lb_sumDolar);
            Controls.Add(tb_sumhrivna);
            Controls.Add(lb_sumGrivna);
            Controls.Add(btn_Enter);
            Controls.Add(tB_costOfOneLiter);
            Controls.Add(lb_costOfOneLiter);
            Controls.Add(tB_averageFuelConsumption);
            Controls.Add(lb_averageFuelConsumption);
            Controls.Add(tB_distance);
            Controls.Add(lb_distance);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_distance;
        private TextBox tB_distance;
        private TextBox tB_averageFuelConsumption;
        private Label lb_averageFuelConsumption;
        private TextBox tB_costOfOneLiter;
        private Label lb_costOfOneLiter;
        private Button btn_Enter;
        private Label lb_sumGrivna;
        private TextBox tb_sumhrivna;
        private TextBox tb_sumdollar;
        private Label lb_sumDolar;
        private TextBox tb_carBrand;
        private Label lb_carBrend;
        private TextBox tb_model;
        private Label lB_model;
    }
}
