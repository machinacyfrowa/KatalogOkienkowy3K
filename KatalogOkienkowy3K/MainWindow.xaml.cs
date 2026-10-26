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

namespace KatalogOkienkowy3K
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //stwórz listę kilku produktów - części komputerowych
            List<Produkt> produkty = new List<Produkt>
            {
                new Produkt("Procesor Intel Core i9", 1500.00, "Procesory", 10),
                new Produkt("Karta graficzna NVIDIA GeForce RTX 3080", 4000.00, "Karty graficzne", 5),
                new Produkt("Płyta główna ASUS ROG Strix Z590-E", 1200.00, "Płyty główne", 8),
                new Produkt("Pamięć RAM Corsair Vengeance LPX 16GB", 400.00, "Pamięci RAM", 20),
                new Produkt("Dysk SSD Samsung 970 EVO Plus 1TB", 600.00, "Dyski SSD", 15)
            };

            EtykietaLiczbaProduktow.Text = $"Liczba produktów: {produkty.Count}";
            EtykietaWartoscMagazynu.Text = $"Wartość magazynu: {Produkt.ObliczWartoscMagazynu(produkty):f2} zł";
        }
    }
}