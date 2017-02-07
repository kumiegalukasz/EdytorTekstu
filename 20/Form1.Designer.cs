namespace _20
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNowy = new System.Windows.Forms.ToolStripMenuItem();
            this.otwózToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wstawPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemKoniec_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemKopiuj = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWytnij = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWklej = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKopiujformat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWklejformat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemZaznaczwszystko = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCzcionka = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Okno = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNowy,
            this.otwózToolStripMenuItem,
            this.wstawPlikToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.drukujToolStripMenuItem,
            this.menuItemKoniec_Click});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // menuItemNowy
            // 
            this.menuItemNowy.Name = "menuItemNowy";
            this.menuItemNowy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemNowy.Size = new System.Drawing.Size(148, 22);
            this.menuItemNowy.Text = "&Nowy";
            this.menuItemNowy.Click += new System.EventHandler(this.menuItemNowy_Click);
            // 
            // otwózToolStripMenuItem
            // 
            this.otwózToolStripMenuItem.Name = "otwózToolStripMenuItem";
            this.otwózToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.otwózToolStripMenuItem.Text = "&Otwóz";
            this.otwózToolStripMenuItem.Click += new System.EventHandler(this.otwózToolStripMenuItem_Click);
            // 
            // wstawPlikToolStripMenuItem
            // 
            this.wstawPlikToolStripMenuItem.Name = "wstawPlikToolStripMenuItem";
            this.wstawPlikToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.wstawPlikToolStripMenuItem.Text = "&Wstaw plik";
            this.wstawPlikToolStripMenuItem.Click += new System.EventHandler(this.wstawPlikToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.zapiszToolStripMenuItem.Text = "&Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Z&apisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.drukujToolStripMenuItem.Text = "Drukuj";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // menuItemKoniec_Click
            // 
            this.menuItemKoniec_Click.Name = "menuItemKoniec_Click";
            this.menuItemKoniec_Click.Size = new System.Drawing.Size(148, 22);
            this.menuItemKoniec_Click.Text = "Za&kończ";
            this.menuItemKoniec_Click.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemKopiuj,
            this.menuItemWytnij,
            this.menuItemWklej,
            this.menuKopiujformat,
            this.menuItemWklejformat,
            this.menuItemZaznaczwszystko});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // menuItemKopiuj
            // 
            this.menuItemKopiuj.Name = "menuItemKopiuj";
            this.menuItemKopiuj.Size = new System.Drawing.Size(166, 22);
            this.menuItemKopiuj.Text = "&Kopiuj";
            this.menuItemKopiuj.Click += new System.EventHandler(this.menuItemKopiuj_Click);
            // 
            // menuItemWytnij
            // 
            this.menuItemWytnij.Name = "menuItemWytnij";
            this.menuItemWytnij.Size = new System.Drawing.Size(166, 22);
            this.menuItemWytnij.Text = "Wyt&nij";
            this.menuItemWytnij.Click += new System.EventHandler(this.menuItemWytnij_Click);
            // 
            // menuItemWklej
            // 
            this.menuItemWklej.Name = "menuItemWklej";
            this.menuItemWklej.Size = new System.Drawing.Size(166, 22);
            this.menuItemWklej.Text = "Wkl&ej";
            this.menuItemWklej.Click += new System.EventHandler(this.menuItemWklej_Click);
            // 
            // menuKopiujformat
            // 
            this.menuKopiujformat.Name = "menuKopiujformat";
            this.menuKopiujformat.Size = new System.Drawing.Size(166, 22);
            this.menuKopiujformat.Text = "Kopiuj format";
            this.menuKopiujformat.Click += new System.EventHandler(this.kopiujFormatToolStripMenuItem_Click);
            // 
            // menuItemWklejformat
            // 
            this.menuItemWklejformat.Name = "menuItemWklejformat";
            this.menuItemWklejformat.Size = new System.Drawing.Size(166, 22);
            this.menuItemWklejformat.Text = "Wklej format";
            this.menuItemWklejformat.Click += new System.EventHandler(this.menuItemWklejformat_Click);
            // 
            // menuItemZaznaczwszystko
            // 
            this.menuItemZaznaczwszystko.Name = "menuItemZaznaczwszystko";
            this.menuItemZaznaczwszystko.Size = new System.Drawing.Size(166, 22);
            this.menuItemZaznaczwszystko.Text = "Z&aznacz wszystko";
            this.menuItemZaznaczwszystko.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCzcionka});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // menuItemCzcionka
            // 
            this.menuItemCzcionka.Name = "menuItemCzcionka";
            this.menuItemCzcionka.Size = new System.Drawing.Size(122, 22);
            this.menuItemCzcionka.Text = "&Czcionka";
            this.menuItemCzcionka.Click += new System.EventHandler(this.menuItemCzcionka_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytorToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // edytorToolStripMenuItem
            // 
            this.edytorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjeToolStripMenuItem});
            this.edytorToolStripMenuItem.Name = "edytorToolStripMenuItem";
            this.edytorToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.edytorToolStripMenuItem.Text = "Edytor";
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.informacjeToolStripMenuItem.Text = "i&nformacje";
            this.informacjeToolStripMenuItem.Click += new System.EventHandler(this.informacjeToolStripMenuItem_Click);
            // 
            // Okno
            // 
            this.Okno.Location = new System.Drawing.Point(12, 50);
            this.Okno.Name = "Okno";
            this.Okno.Size = new System.Drawing.Size(734, 249);
            this.Okno.TabIndex = 1;
            this.Okno.Text = "";
            this.Okno.TextChanged += new System.EventHandler(this.Okno_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = " (*.txt)|*.txt";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 350);
            this.Controls.Add(this.Okno);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNowy;
        private System.Windows.Forms.ToolStripMenuItem otwózToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wstawPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemKoniec_Click;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemKopiuj;
        private System.Windows.Forms.ToolStripMenuItem menuItemWytnij;
        private System.Windows.Forms.ToolStripMenuItem menuItemWklej;
        private System.Windows.Forms.ToolStripMenuItem menuKopiujformat;
        private System.Windows.Forms.ToolStripMenuItem menuItemWklejformat;
        private System.Windows.Forms.ToolStripMenuItem menuItemZaznaczwszystko;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemCzcionka;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox Okno;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
    }
}

