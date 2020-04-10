using AjaxControlToolkit.HtmlEditor;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleHackApp
{
    public partial class Page4 : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyCard.txt");

        public Page4()
        {
            InitializeComponent();

            if (File.Exists(_fileName))
            {
                fname.Text = File.ReadAllText(_fileName);
                lname.Text = File.ReadAllText(_fileName);
                address1.Text = File.ReadAllText(_fileName);
                pcode.Text = File.ReadAllText(_fileName);
                telnum.Text = File.ReadAllText(_fileName);
                email.Text = File.ReadAllText(_fileName);
                altcont.Text = File.ReadAllText(_fileName);
            }
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            File.WriteAllText(_fileName, fname.text);
            File.WriteAllText(_fileName, lname.text);
            File.WriteAllText(_fileName, address1.text);
            File.WriteAllText(_fileName, pcode.text);
            File.WriteAllText(_fileName, telnum.text);
            File.WriteAllText(_fileName, email.text);
            File.WriteAllText(_fileName, altcont.text);
        }

        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            fname.Text = string.Empty;
            lname.Text = string.Empty;
            address1.Text = string.Empty;
            pcode.Text = string.Empty;
            telnum.Text = string.Empty;
            email.Text = string.Empty;
            altcont.Text = string.Empty;
        }
    }
}