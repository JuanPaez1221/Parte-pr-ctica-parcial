using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Player;
using FirstFantasy.Interfaces;
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

namespace FirstFantasy
{

    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        Character myCharacter;
        public Home()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            bool xd = true;
            foreach (var user in FileManager.ReadAllLines())
            {
                if (user == txtName.Text)
                {
                    xd = false;
                    MessageBox.Show("El nombre de este personaje ya está en uso, prueba con otro. ");
                    break;
                }

            }
            if (xd)
            {
                FileManager.WriteFile(txtName.Text);
                string[] lines = FileManager.ReadAllLines();
                TxtOutput.Text = $"You created a named character: {txtName.Text}\nClass: {CboxCharacter.Text}\nChosen Weapon: {CboxWeapon.Text}\nUsing: {CboxArmor.Text}, with these specifications: {myCharacter.Armor.Armordescription()}";

            }

            

            switch (CboxCharacter.SelectedIndex)
            {
                case 1:
                    myCharacter = new Cleric();
                    break;

                case 2:
                    myCharacter = new Fighter();
                    break;

                case 3:
                    myCharacter = new Rogue();
                    break;

                case 4:
                    myCharacter = new Wizard();
                    break;

                default:
                    myCharacter = null;
                    MessageBox.Show("You MUST select a type");
                    break;

            }
            switch (CboxWeapon.SelectedIndex)
            {
                case 1:
                    myCharacter.Weapon = new Axe();
                    break;

                case 3:
                    myCharacter.Weapon = new Dagger();
                    break;

                case 2:
                    myCharacter.Weapon = new Sword();
                    break;

                case 4:
                    myCharacter.Weapon = new Wand();
                    break;

                default:

                    MessageBox.Show("You MUST select a weapon");
                    break;

            }
            switch (CboxArmor.SelectedIndex)
            {

                case 1:
                    myCharacter.Armor = new Leather_Armor();
                    break;

                case 2:
                    myCharacter.Armor = new NeymarJr_Armor();
                    break;

                case 3:
                    myCharacter.Armor = new Silver_Armor();
                    break;

                default:

                    MessageBox.Show("You MUST select a Armor");
                    break;

            }

        }
        public static Character personaje;
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.Mainframe.NavigationService.Navigate(new Attack());
            personaje = myCharacter;
        }

    }
}
