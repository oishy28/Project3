namespace Car_Rental_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_User_Id = new System.Windows.Forms.Label();
            this.lbl_Car = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_User_name = new System.Windows.Forms.Label();
            this.lbl_User_add = new System.Windows.Forms.Label();
            this.lbl_User_Des = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_User_id_Save = new System.Windows.Forms.TextBox();
            this.txt_User_Name_save = new System.Windows.Forms.TextBox();
            this.txt_User_ad_Save = new System.Windows.Forms.TextBox();
            this.txt_User_Des_save = new System.Windows.Forms.TextBox();
            this.txt_Car_Name_Save = new System.Windows.Forms.TextBox();
            this.txt_car_Model_save = new System.Windows.Forms.TextBox();
            this.txt_num_CAr_Save = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_User_name_his = new System.Windows.Forms.Label();
            this.lbl_user_ad_his = new System.Windows.Forms.Label();
            this.lbl_rented_car_his = new System.Windows.Forms.Label();
            this.lbl_User_destination_his = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_Car_model_his = new System.Windows.Forms.Label();
            this.lbl_available_unit = new System.Windows.Forms.Label();
            this.txt_search_Userid_his = new System.Windows.Forms.TextBox();
            this.txt_search_car_name_his = new System.Windows.Forms.TextBox();
            this.txt_userid_rent = new System.Windows.Forms.TextBox();
            this.txt_carname_rent = new System.Windows.Forms.TextBox();
            this.btn_save_user = new System.Windows.Forms.Button();
            this.btn_save_car = new System.Windows.Forms.Button();
            this.btn_Rent = new System.Windows.Forms.Button();
            this.btn_show_user_history = new System.Windows.Forms.Button();
            this.btn_show_car_history = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(477, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental System";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl.Location = new System.Drawing.Point(39, 114);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(59, 20);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "USER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(348, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(684, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User History";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(684, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Car History";
            // 
            // lbl_User_Id
            // 
            this.lbl_User_Id.AutoSize = true;
            this.lbl_User_Id.Location = new System.Drawing.Point(43, 160);
            this.lbl_User_Id.Name = "lbl_User_Id";
            this.lbl_User_Id.Size = new System.Drawing.Size(46, 13);
            this.lbl_User_Id.TabIndex = 5;
            this.lbl_User_Id.Text = "User ID:";
            // 
            // lbl_Car
            // 
            this.lbl_Car.AutoSize = true;
            this.lbl_Car.Location = new System.Drawing.Point(349, 160);
            this.lbl_Car.Name = "lbl_Car";
            this.lbl_Car.Size = new System.Drawing.Size(57, 13);
            this.lbl_Car.TabIndex = 6;
            this.lbl_Car.Text = "Car Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Model:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Number Of Cars:";
            // 
            // lbl_User_name
            // 
            this.lbl_User_name.AutoSize = true;
            this.lbl_User_name.Location = new System.Drawing.Point(43, 200);
            this.lbl_User_name.Name = "lbl_User_name";
            this.lbl_User_name.Size = new System.Drawing.Size(63, 13);
            this.lbl_User_name.TabIndex = 9;
            this.lbl_User_name.Text = "User Name:";
            // 
            // lbl_User_add
            // 
            this.lbl_User_add.AutoSize = true;
            this.lbl_User_add.Location = new System.Drawing.Point(43, 240);
            this.lbl_User_add.Name = "lbl_User_add";
            this.lbl_User_add.Size = new System.Drawing.Size(48, 13);
            this.lbl_User_add.TabIndex = 10;
            this.lbl_User_add.Text = "Address:";
            // 
            // lbl_User_Des
            // 
            this.lbl_User_Des.AutoSize = true;
            this.lbl_User_Des.Location = new System.Drawing.Point(43, 283);
            this.lbl_User_Des.Name = "lbl_User_Des";
            this.lbl_User_Des.Size = new System.Drawing.Size(63, 13);
            this.lbl_User_Des.TabIndex = 11;
            this.lbl_User_Des.Text = "Destination:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "User ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 488);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Car Name:";
            // 
            // txt_User_id_Save
            // 
            this.txt_User_id_Save.Location = new System.Drawing.Point(127, 153);
            this.txt_User_id_Save.Name = "txt_User_id_Save";
            this.txt_User_id_Save.Size = new System.Drawing.Size(100, 20);
            this.txt_User_id_Save.TabIndex = 14;
            // 
            // txt_User_Name_save
            // 
            this.txt_User_Name_save.Location = new System.Drawing.Point(127, 193);
            this.txt_User_Name_save.Name = "txt_User_Name_save";
            this.txt_User_Name_save.Size = new System.Drawing.Size(100, 20);
            this.txt_User_Name_save.TabIndex = 15;
            // 
            // txt_User_ad_Save
            // 
            this.txt_User_ad_Save.Location = new System.Drawing.Point(127, 233);
            this.txt_User_ad_Save.Name = "txt_User_ad_Save";
            this.txt_User_ad_Save.Size = new System.Drawing.Size(100, 20);
            this.txt_User_ad_Save.TabIndex = 16;
            // 
            // txt_User_Des_save
            // 
            this.txt_User_Des_save.Location = new System.Drawing.Point(127, 276);
            this.txt_User_Des_save.Name = "txt_User_Des_save";
            this.txt_User_Des_save.Size = new System.Drawing.Size(100, 20);
            this.txt_User_Des_save.TabIndex = 17;
            // 
            // txt_Car_Name_Save
            // 
            this.txt_Car_Name_Save.Location = new System.Drawing.Point(437, 153);
            this.txt_Car_Name_Save.Name = "txt_Car_Name_Save";
            this.txt_Car_Name_Save.Size = new System.Drawing.Size(100, 20);
            this.txt_Car_Name_Save.TabIndex = 18;
            // 
            // txt_car_Model_save
            // 
            this.txt_car_Model_save.Location = new System.Drawing.Point(437, 193);
            this.txt_car_Model_save.Name = "txt_car_Model_save";
            this.txt_car_Model_save.Size = new System.Drawing.Size(100, 20);
            this.txt_car_Model_save.TabIndex = 19;
            // 
            // txt_num_CAr_Save
            // 
            this.txt_num_CAr_Save.Location = new System.Drawing.Point(437, 233);
            this.txt_num_CAr_Save.Name = "txt_num_CAr_Save";
            this.txt_num_CAr_Save.Size = new System.Drawing.Size(100, 20);
            this.txt_num_CAr_Save.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "User ID:";
            // 
            // lbl_User_name_his
            // 
            this.lbl_User_name_his.AutoSize = true;
            this.lbl_User_name_his.Location = new System.Drawing.Point(685, 193);
            this.lbl_User_name_his.Name = "lbl_User_name_his";
            this.lbl_User_name_his.Size = new System.Drawing.Size(60, 13);
            this.lbl_User_name_his.TabIndex = 22;
            this.lbl_User_name_his.Text = "User Name";
            // 
            // lbl_user_ad_his
            // 
            this.lbl_user_ad_his.AutoSize = true;
            this.lbl_user_ad_his.Location = new System.Drawing.Point(685, 233);
            this.lbl_user_ad_his.Name = "lbl_user_ad_his";
            this.lbl_user_ad_his.Size = new System.Drawing.Size(48, 13);
            this.lbl_user_ad_his.TabIndex = 23;
            this.lbl_user_ad_his.Text = "Address:";
            // 
            // lbl_rented_car_his
            // 
            this.lbl_rented_car_his.AutoSize = true;
            this.lbl_rented_car_his.Location = new System.Drawing.Point(685, 267);
            this.lbl_rented_car_his.Name = "lbl_rented_car_his";
            this.lbl_rented_car_his.Size = new System.Drawing.Size(64, 13);
            this.lbl_rented_car_his.TabIndex = 24;
            this.lbl_rented_car_his.Text = "Rented Car:";
            // 
            // lbl_User_destination_his
            // 
            this.lbl_User_destination_his.AutoSize = true;
            this.lbl_User_destination_his.Location = new System.Drawing.Point(685, 298);
            this.lbl_User_destination_his.Name = "lbl_User_destination_his";
            this.lbl_User_destination_his.Size = new System.Drawing.Size(63, 13);
            this.lbl_User_destination_his.TabIndex = 25;
            this.lbl_User_destination_his.Text = "Destination:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(685, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Car Name:";
            // 
            // lbl_Car_model_his
            // 
            this.lbl_Car_model_his.AutoSize = true;
            this.lbl_Car_model_his.Location = new System.Drawing.Point(685, 449);
            this.lbl_Car_model_his.Name = "lbl_Car_model_his";
            this.lbl_Car_model_his.Size = new System.Drawing.Size(39, 13);
            this.lbl_Car_model_his.TabIndex = 27;
            this.lbl_Car_model_his.Text = "Model:";
            // 
            // lbl_available_unit
            // 
            this.lbl_available_unit.AutoSize = true;
            this.lbl_available_unit.Location = new System.Drawing.Point(685, 488);
            this.lbl_available_unit.Name = "lbl_available_unit";
            this.lbl_available_unit.Size = new System.Drawing.Size(75, 13);
            this.lbl_available_unit.TabIndex = 28;
            this.lbl_available_unit.Text = "Available Unit:";
            // 
            // txt_search_Userid_his
            // 
            this.txt_search_Userid_his.Location = new System.Drawing.Point(761, 150);
            this.txt_search_Userid_his.Name = "txt_search_Userid_his";
            this.txt_search_Userid_his.Size = new System.Drawing.Size(100, 20);
            this.txt_search_Userid_his.TabIndex = 29;
            // 
            // txt_search_car_name_his
            // 
            this.txt_search_car_name_his.Location = new System.Drawing.Point(761, 412);
            this.txt_search_car_name_his.Name = "txt_search_car_name_his";
            this.txt_search_car_name_his.Size = new System.Drawing.Size(100, 20);
            this.txt_search_car_name_his.TabIndex = 30;
            // 
            // txt_userid_rent
            // 
            this.txt_userid_rent.Location = new System.Drawing.Point(288, 430);
            this.txt_userid_rent.Name = "txt_userid_rent";
            this.txt_userid_rent.Size = new System.Drawing.Size(100, 20);
            this.txt_userid_rent.TabIndex = 31;
            // 
            // txt_carname_rent
            // 
            this.txt_carname_rent.Location = new System.Drawing.Point(288, 481);
            this.txt_carname_rent.Name = "txt_carname_rent";
            this.txt_carname_rent.Size = new System.Drawing.Size(100, 20);
            this.txt_carname_rent.TabIndex = 32;
            // 
            // btn_save_user
            // 
            this.btn_save_user.BackColor = System.Drawing.Color.White;
            this.btn_save_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_user.ForeColor = System.Drawing.Color.Red;
            this.btn_save_user.Location = new System.Drawing.Point(152, 324);
            this.btn_save_user.Name = "btn_save_user";
            this.btn_save_user.Size = new System.Drawing.Size(75, 23);
            this.btn_save_user.TabIndex = 33;
            this.btn_save_user.Text = "Save";
            this.btn_save_user.UseVisualStyleBackColor = false;
            this.btn_save_user.Click += new System.EventHandler(this.btn_save_user_Click);
            // 
            // btn_save_car
            // 
            this.btn_save_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_car.ForeColor = System.Drawing.Color.Red;
            this.btn_save_car.Location = new System.Drawing.Point(462, 274);
            this.btn_save_car.Name = "btn_save_car";
            this.btn_save_car.Size = new System.Drawing.Size(75, 23);
            this.btn_save_car.TabIndex = 34;
            this.btn_save_car.Text = "Save";
            this.btn_save_car.UseVisualStyleBackColor = true;
            this.btn_save_car.Click += new System.EventHandler(this.btn_save_car_Click);
            // 
            // btn_Rent
            // 
            this.btn_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rent.ForeColor = System.Drawing.Color.Red;
            this.btn_Rent.Location = new System.Drawing.Point(313, 516);
            this.btn_Rent.Name = "btn_Rent";
            this.btn_Rent.Size = new System.Drawing.Size(75, 23);
            this.btn_Rent.TabIndex = 35;
            this.btn_Rent.Text = "Rent";
            this.btn_Rent.UseVisualStyleBackColor = true;
            this.btn_Rent.Click += new System.EventHandler(this.btn_Rent_Click);
            // 
            // btn_show_user_history
            // 
            this.btn_show_user_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_user_history.ForeColor = System.Drawing.Color.Red;
            this.btn_show_user_history.Location = new System.Drawing.Point(934, 147);
            this.btn_show_user_history.Name = "btn_show_user_history";
            this.btn_show_user_history.Size = new System.Drawing.Size(167, 23);
            this.btn_show_user_history.TabIndex = 36;
            this.btn_show_user_history.Text = "Show User History";
            this.btn_show_user_history.UseVisualStyleBackColor = true;
            this.btn_show_user_history.Click += new System.EventHandler(this.btn_show_user_history_Click);
            // 
            // btn_show_car_history
            // 
            this.btn_show_car_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_car_history.ForeColor = System.Drawing.Color.Red;
            this.btn_show_car_history.Location = new System.Drawing.Point(934, 407);
            this.btn_show_car_history.Name = "btn_show_car_history";
            this.btn_show_car_history.Size = new System.Drawing.Size(167, 23);
            this.btn_show_car_history.TabIndex = 37;
            this.btn_show_car_history.Text = "Show Car History";
            this.btn_show_car_history.UseVisualStyleBackColor = true;
            this.btn_show_car_history.Click += new System.EventHandler(this.btn_show_car_history_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 561);
            this.Controls.Add(this.btn_show_car_history);
            this.Controls.Add(this.btn_show_user_history);
            this.Controls.Add(this.btn_Rent);
            this.Controls.Add(this.btn_save_car);
            this.Controls.Add(this.btn_save_user);
            this.Controls.Add(this.txt_carname_rent);
            this.Controls.Add(this.txt_userid_rent);
            this.Controls.Add(this.txt_search_car_name_his);
            this.Controls.Add(this.txt_search_Userid_his);
            this.Controls.Add(this.lbl_available_unit);
            this.Controls.Add(this.lbl_Car_model_his);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_User_destination_his);
            this.Controls.Add(this.lbl_rented_car_his);
            this.Controls.Add(this.lbl_user_ad_his);
            this.Controls.Add(this.lbl_User_name_his);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_num_CAr_Save);
            this.Controls.Add(this.txt_car_Model_save);
            this.Controls.Add(this.txt_Car_Name_Save);
            this.Controls.Add(this.txt_User_Des_save);
            this.Controls.Add(this.txt_User_ad_Save);
            this.Controls.Add(this.txt_User_Name_save);
            this.Controls.Add(this.txt_User_id_Save);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_User_Des);
            this.Controls.Add(this.lbl_User_add);
            this.Controls.Add(this.lbl_User_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Car);
            this.Controls.Add(this.lbl_User_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_User_Id;
        private System.Windows.Forms.Label lbl_Car;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_User_name;
        private System.Windows.Forms.Label lbl_User_add;
        private System.Windows.Forms.Label lbl_User_Des;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_User_id_Save;
        private System.Windows.Forms.TextBox txt_User_Name_save;
        private System.Windows.Forms.TextBox txt_User_ad_Save;
        private System.Windows.Forms.TextBox txt_User_Des_save;
        private System.Windows.Forms.TextBox txt_Car_Name_Save;
        private System.Windows.Forms.TextBox txt_car_Model_save;
        private System.Windows.Forms.TextBox txt_num_CAr_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_User_name_his;
        private System.Windows.Forms.Label lbl_user_ad_his;
        private System.Windows.Forms.Label lbl_rented_car_his;
        private System.Windows.Forms.Label lbl_User_destination_his;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_Car_model_his;
        private System.Windows.Forms.Label lbl_available_unit;
        private System.Windows.Forms.TextBox txt_search_Userid_his;
        private System.Windows.Forms.TextBox txt_search_car_name_his;
        private System.Windows.Forms.TextBox txt_userid_rent;
        private System.Windows.Forms.TextBox txt_carname_rent;
        private System.Windows.Forms.Button btn_save_user;
        private System.Windows.Forms.Button btn_save_car;
        private System.Windows.Forms.Button btn_Rent;
        private System.Windows.Forms.Button btn_show_user_history;
        private System.Windows.Forms.Button btn_show_car_history;
    }
}

