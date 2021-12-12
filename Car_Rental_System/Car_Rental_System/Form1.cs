using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRS_Dependencies;

namespace Car_Rental_System
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_user_Click(object sender, EventArgs e)
        {
            User dummy_user = new User();
            dummy_user.UserID = txt_User_id_Save.Text;
            dummy_user.UserName = txt_User_Name_save.Text;
            dummy_user.Address = txt_User_ad_Save.Text;
            dummy_user.Destination = txt_User_Des_save.Text;

            users.Add(dummy_user);

            MessageBox.Show("User has been saved Successfully!!!");
        }

        private void btn_save_car_Click(object sender, EventArgs e)
        {
            Car dummy_car = new Car();
            dummy_car.CarName = txt_Car_Name_Save.Text;
            dummy_car.Model = txt_car_Model_save.Text;
            dummy_car.NumberofCArs = txt_num_CAr_Save.Text;

            cars.Add(dummy_car);
            MessageBox.Show("Car has been added Successfully!!!");
        }

        private void btn_show_car_history_Click(object sender, EventArgs e)
        {
            string search_car_name = txt_search_car_name_his.Text;

            foreach(Car Car in cars)
            {
                if(Car.CarName == search_car_name)
                {
                    lbl_available_unit.Text = "Available Unit: " + Car.NumberofCArs;
                    lbl_Car_model_his.Text = "Model: " + Car.Model;

                }
                       }
        }

        private void btn_Rent_Click(object sender, EventArgs e)
        {
            string rented_user_id = txt_userid_rent.Text;
            string rented_car = txt_carname_rent.Text;
            foreach(User User in users)
            {
                if (User.UserID == rented_user_id)
                {
                   foreach(Car Car in cars)
                    {
                        if(Car.CarName == rented_car)
                        {
                            User.UserRentedCar = rented_car;
                            int n = Convert.ToInt32(Car.NumberofCArs);
                            n = n - 1;
                            Car.NumberofCArs = Convert.ToString(n);
                            break;
                        }
                    }
                }
            }
            MessageBox.Show("Car has been Rented for the user!!");
        }

        private void btn_show_user_history_Click(object sender, EventArgs e)
        {
            string search_id = txt_search_Userid_his.Text;
            foreach(User User in users)
            {
                lbl_User_name_his.Text = "User Name : " + User.UserName;
                lbl_user_ad_his.Text =  "Address: " + User.Address;
                lbl_rented_car_his.Text = "Rented Car : " + User.UserRentedCar;
                lbl_User_destination_his.Text = "Destination : " + User.Destination;
            }
        }
    }
}
