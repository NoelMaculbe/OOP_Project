using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        { 
            InitializeComponent();
        }


      
            transwin.Details.Name = this.cmbItem.Text;
            transwin.Details.Description = "Gold;";
           

            Calculations b = new Calculations();

            Product necklace = new Product();
            necklace.Price = 5000;
            necklace.Items = 3;
            necklace.MonthlyInterestRate = 1.3M;

            Product earrings = new Product();
            earrings.Price = 1500;
            earrings.Items = 5;
            earrings.MonthlyInterestRate = 0.5M;

            Product rings = new Product();
            rings.Price = 2000;
            rings.Items = 8;
            rings.MonthlyInterestRate = 0.7M;

            Product bracelet = new Product();
            bracelet.Price = 3000;
            bracelet.Items = 4;
            bracelet.MonthlyInterestRate = 1;

            switch (cmbItem.Text)
            {
                case "Necklace":
                    if (Convert.ToInt32(this.txtNumItems) > necklace.Items)
                    {
                        MessageBox.Show("Can't Process...");
                        break;
                    }
                    else
                    {
                        PrintDetails(necklace.Name, Convert.ToInt32(this.txtNumItems), b.CalculateInterest(necklace.Price, necklace.MonthlyInterestRate), b.CalculateAccruedAmount(necklace.Price, necklace.MonthlyInterestRate, this.txtDueDate.Text, Convert.ToInt32(this.txtNumItems)));
                        break;
                    }

                case "Earrings":
                    if (Convert.ToInt32(this.txtNumItems) > earrings.Items)
                    {
                        MessageBox.Show("Can't Process...");
                        break;
                    }
                    else
                    {
                        PrintDetails(earrings.Name, Convert.ToInt32(this.txtNumItems), b.CalculateInterest(earrings.Price, earrings.MonthlyInterestRate), b.CalculateAccruedAmount(earrings.Price, earrings.MonthlyInterestRate, this.txtDueDate.Text, Convert.ToInt32(this.txtNumItems)));
                        break;
                    }

                case "Rings":
                    if (Convert.ToInt32(this.txtNumItems) > rings.Items)
                    {
                        MessageBox.Show("Can't Process...");
                        break;
                    }
                    else
                    {
                        PrintDetails(rings.Name, Convert.ToInt32(this.txtNumItems), b.CalculateInterest(rings.Price, rings.MonthlyInterestRate), b.CalculateAccruedAmount(rings.Price, rings.MonthlyInterestRate, this.txtDueDate.Text, Convert.ToInt32(this.txtNumItems)));
                        break;
                    }

                case "Bracelet":
                    if (Convert.ToInt32(this.txtNumItems) > bracelet.Items)
                    {
                        MessageBox.Show("Can't Process...");
                        break;
                    }
                    else
                    {
                        PrintDetails(bracelet.Name, Convert.ToInt32(this.txtNumItems), b.CalculateInterest(bracelet.Price, bracelet.MonthlyInterestRate), b.CalculateAccruedAmount(bracelet.Price, bracelet.MonthlyInterestRate, this.txtDueDate.Text, Convert.ToInt32(this.txtNumItems)));
                        break;
                    }

            }



         transwin.Show();
        }

        public void PrintDetails(string name, int itemNum, decimal interest, decimal accruedAmount)
        {
            Console.WriteLine("Jewelry Purchased: " + name);
            Console.WriteLine("Number of items purchased: " + itemNum);
            Console.WriteLine("Your Interest is: " + interest);
            Console.WriteLine("Your Accrued Amount is: " + accruedAmount);
        
        }
       
    }
}
    

