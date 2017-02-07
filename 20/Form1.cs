using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace _20
{
    
    public partial class Form1 : Form
    {
        private String nazwaPliku = "";
        private Font czcionka;
        private Color kolor;
        private PageSettings ustawieniaStrony = new PageSettings();
        private Font printFont = new Font("Arial", 12);
        private string tekstDoDruku;
        public Form1()
        {
            InitializeComponent();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//zakończenie programu
        }

        private void menuItemWytnij_Click(object sender, EventArgs e)
        {
            Okno.Cut();//wycięcie zaznaczonego tekstu
        }

        private void menuItemKopiuj_Click(object sender, EventArgs e)
        {
            Okno.Copy();//kopiowanie zaznaczonego tektsu
        }

        private void menuItemWklej_Click(object sender, EventArgs e)
        {
            Okno.Paste();//wklejanie zaznaczonego tekstu
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Okno.SelectAll();//zaznaczenie całego tekstu
        }

        private void kopiujFormatToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            czcionka = Okno.SelectionFont;
            //zapamiętanie właściwości czcionki z zaznaczonego obszaru
            kolor = Okno.SelectionColor; //zapamiętanie właściwości czcionki z zaznaczonego obszaru
        }

        private void Okno_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuItemWklejformat_Click(object sender, EventArgs e)
        {
            Okno.SelectionFont = czcionka;
            //ustawienie właściwości czcionki według wcześniej zapamietanych cech
            Okno.SelectionColor = kolor;
            // ustawienie koloru czcionki według wcześniej zapamiętanej wartości
        }

        private void menuItemNowy_Click(object sender, EventArgs e)
        {
            Okno.Clear();//wyczyszczenie okna
        }

        private void menuItemCzcionka_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Okno.SelectionFont = fontDialog1.Font;
                //ustawienie w oknie dialogowym właściwości czcionki
                Okno.SelectionColor = fontDialog1.Color;
                //ustawienie w oknie dialogowym koloru czcionki
                Okno.Select(Okno.Text.Length, 0);
                //ustawienie zaznaczenia
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edytor tekstu wersja 1.0\n\rAutor: Marian Mysior.","Informacje",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void otwózToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otworz(true);
        }
        private void otworz(bool czyste)
        {
            FileStream plik;
            StreamReader stCzyt;
            //wykonaj, jeżeli wybrano OK w oknie dialogowym
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //wyczyść Okno, jeżeli czyste =true
                if (czyste) Okno.Clear();
                //podstawienie nazwy pliku
                nazwaPliku = openFileDialog1.FileName;
                //utworzenie obiektu "pliku"
                //i otwarcie skojarzonego z nim pliku
                plik = new FileStream(nazwaPliku, FileMode.Open, FileAccess.Read, FileShare.None);
                //utworzenie strumienia do odczytu
                //ze skojarzonego  nim pliku
                stCzyt = new StreamReader(plik);
                //podstawienie łańcucha odczytanego z pliku
                Okno.Text += stCzyt.ReadToEnd();
                //zamknięcie strumienia i pliku
                stCzyt.Close();
                plik.Close();
            }
        }
        private void zapisz(bool nazwa)
        {
            FileStream plik;
            StreamWriter stZapis;
            //wykonaj, jeżeli nazwa=true i nazwaPliku jest pusta
            if (nazwa || (nazwaPliku == ""))
                //wykonaj, jeżeli wybrano OK w oknie dialogowym
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    //podstawienie nazwy pliku
                    nazwaPliku = saveFileDialog1.FileName + ".txt";
                //w przeciwnym wypadku(wybrano rezygnację z zapisu) wyjdz z metody
                else return;
            //wykonaj, jezeli plik o podanej nazwie istnieje i wybrano rezygnację z nadpisania go
            if (File.Exists(nazwaPliku) && MessageBox.Show("Plik istnieje-czy zapisać zmiany?",
                "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                return;
            plik = new FileStream(nazwaPliku, FileMode.Create, FileAccess.Write, FileShare.None);

            stZapis = new StreamWriter(plik);

            //zapis do pliku
            stZapis.Write(Okno.Text);
            stZapis.Close();
            plik.Close();

        }

        private void wstawPlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otworz(false);
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zapisz(false);
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zapisz(true);
        }
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Okno.Width = this.Size.Width - 25;
            Okno.Height = this.Size.Height - 120;
        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //określenie ustawień strony
            printDocument1.DefaultPageSettings = ustawieniaStrony;

            //przypisanie tekstu do druku
            tekstDoDruku = Okno.Text;

            //przekazanie dokumentu do okna drukowania
            printDialog1.Document = printDocument1;

            //uruchom drukowanie, jezeli nacisnieto OK
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }
    }
}
