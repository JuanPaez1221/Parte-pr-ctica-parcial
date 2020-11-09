using FirstFantasy.Classes.Equipment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFantasy
{
    /// <summary>
    /// Lógica de interacción para Attack.xaml
    /// </summary>
    public partial class Attack : Page
    {
        public Attack() 
        {
            InitializeComponent();
        }
        private void btnattack_Click(object sender, RoutedEventArgs e)
        {           

            txtattack.Text = $"you have dealt {Home.personaje.Attack()} damage.";
        }
        void fillingDataGridUsingDataTable()
        {
            DataTable dt = new DataTable();
            DataColumn Item = new DataColumn("Item", typeof(string));
            DataColumn Description = new DataColumn("Description", typeof(string));
            ;

            dt.Columns.Add(Item);
            dt.Columns.Add(Description);


            DataRow PrimerRow = dt.NewRow();
            PrimerRow[0] = $"Potion (Health)";
            PrimerRow[1] = $"more 10 Health";
            
            DataRow SegundoRow = dt.NewRow();
            SegundoRow[0] = $"Potion (Agility)";
            SegundoRow[1] = $"more 10 Agility";
            
            DataRow TercerRow = dt.NewRow();
            TercerRow[0] = $"Diamond Armor";
            TercerRow[1] = $"Resistance = 20,Health = 80, Agility = 20";

            
            DataRow CuartoRow = dt.NewRow();
            CuartoRow[0] = "The Chosen one Armor";
            CuartoRow[1] = $"Resistance = 30,Health = 100, Agility = 40";

            DataRow QuintoRow = dt.NewRow();
            CuartoRow[0] = "scimitar of wrath";
            CuartoRow[1] = $"Daño = 32";
            
            DataRow SextoRow = dt.NewRow();
            CuartoRow[0] = "Master sword";
            CuartoRow[1] = $"Daño = 60";

            dt.Rows.Add(PrimerRow);
            dt.Rows.Add(SegundoRow);
            dt.Rows.Add(TercerRow);
            dt.Rows.Add(CuartoRow);
            dt.Rows.Add(QuintoRow);
            dt.Rows.Add(SextoRow);

            dtginvent.ItemsSource = dt.DefaultView;

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.fillingDataGridUsingDataTable();
        }

       

            
    }
}