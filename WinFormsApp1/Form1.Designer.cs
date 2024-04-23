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
            SuspendLayout();
            // 
            // lb_distance
            // 
            lb_distance.AutoSize = true;
            lb_distance.Location = new Point(18, 13);
            lb_distance.Margin = new Padding(4, 0, 4, 0);
            lb_distance.Name = "lb_distance";
            lb_distance.Size = new Size(94, 28);
            lb_distance.TabIndex = 0;
            lb_distance.Text = "Distance";
            // 
            // tB_distance
            // 
            tB_distance.Location = new Point(18, 45);
            tB_distance.Margin = new Padding(4);
            tB_distance.Name = "tB_distance";
            tB_distance.Size = new Size(325, 34);
            tB_distance.TabIndex = 1;
            tB_distance.KeyPress += tB_distance_KeyPress;
            // 
            // tB_averageFuelConsumption
            // 
            tB_averageFuelConsumption.Location = new Point(18, 127);
            tB_averageFuelConsumption.Margin = new Padding(4);
            tB_averageFuelConsumption.Name = "tB_averageFuelConsumption";
            tB_averageFuelConsumption.Size = new Size(325, 34);
            tB_averageFuelConsumption.TabIndex = 3;
            tB_averageFuelConsumption.KeyPress += tB_averageFuelConsumption_KeyPress;
            // 
            // lb_averageFuelConsumption
            // 
            lb_averageFuelConsumption.AutoSize = true;
            lb_averageFuelConsumption.Location = new Point(18, 95);
            lb_averageFuelConsumption.Margin = new Padding(4, 0, 4, 0);
            lb_averageFuelConsumption.Name = "lb_averageFuelConsumption";
            lb_averageFuelConsumption.Size = new Size(266, 28);
            lb_averageFuelConsumption.TabIndex = 2;
            lb_averageFuelConsumption.Text = "Average Fuel Consumption";
            // 
            // tB_costOfOneLiter
            // 
            tB_costOfOneLiter.Location = new Point(18, 207);
            tB_costOfOneLiter.Margin = new Padding(4);
            tB_costOfOneLiter.Name = "tB_costOfOneLiter";
            tB_costOfOneLiter.Size = new Size(325, 34);
            tB_costOfOneLiter.TabIndex = 5;
            tB_costOfOneLiter.KeyPress += tB_costOfOneLiter_KeyPress;
            // 
            // lb_costOfOneLiter
            // 
            lb_costOfOneLiter.AutoSize = true;
            lb_costOfOneLiter.Location = new Point(18, 175);
            lb_costOfOneLiter.Margin = new Padding(4, 0, 4, 0);
            lb_costOfOneLiter.Name = "lb_costOfOneLiter";
            lb_costOfOneLiter.Size = new Size(175, 28);
            lb_costOfOneLiter.TabIndex = 4;
            lb_costOfOneLiter.Text = "Cost Of One Liter";
            // 
            // btn_Enter
            // 
            btn_Enter.Location = new Point(249, 264);
            btn_Enter.Name = "btn_Enter";
            btn_Enter.Size = new Size(94, 34);
            btn_Enter.TabIndex = 6;
            btn_Enter.Text = "Enter";
            btn_Enter.UseVisualStyleBackColor = true;
            btn_Enter.Click += btn_Enter_Click;
            // 
            // lb_sumGrivna
            // 
            lb_sumGrivna.AutoSize = true;
            lb_sumGrivna.Location = new Point(462, 45);
            lb_sumGrivna.Name = "lb_sumGrivna";
            lb_sumGrivna.Size = new Size(164, 28);
            lb_sumGrivna.TabIndex = 7;
            lb_sumGrivna.Text = "Sum in hryvnias";
            // 
            // tb_sumhrivna
            // 
            tb_sumhrivna.Enabled = false;
            tb_sumhrivna.Location = new Point(462, 82);
            tb_sumhrivna.Name = "tb_sumhrivna";
            tb_sumhrivna.Size = new Size(125, 34);
            tb_sumhrivna.TabIndex = 8;
            // 
            // tb_sumdollar
            // 
            tb_sumdollar.Enabled = false;
            tb_sumdollar.Location = new Point(462, 170);
            tb_sumdollar.Name = "tb_sumdollar";
            tb_sumdollar.Size = new Size(125, 34);
            tb_sumdollar.TabIndex = 10;
            // 
            // lb_sumDolar
            // 
            lb_sumDolar.AutoSize = true;
            lb_sumDolar.Location = new Point(462, 133);
            lb_sumDolar.Name = "lb_sumDolar";
            lb_sumDolar.Size = new Size(138, 28);
            lb_sumDolar.TabIndex = 9;
            lb_sumDolar.Text = "Sum in dollar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(795, 391);
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
    }
}
