using System.Text.RegularExpressions;

namespace UnicodeConverter
{
    public partial class MainForm : Form
    {
        public static MainForm appForm = new MainForm();
        public MainForm()
        {
            InitializeComponent();
            appForm = this;
        }

        //changing text content
        private void TextRTB_TextChanged(object sender, EventArgs e)
        {
            bool IgnoreSpace = ConfigurationManager.AppSetting["IgnoreWhitespace"] == "True";

            try
            {
                string Unicode = "", Decimal = "";

                foreach (char Chr in TextRTB.Text)
                {
                    if (IgnoreSpace && (Chr == '\n' || Chr == '\r' || Chr == '\t' || Chr == ' '))
                    {
                        Unicode += Chr;
                        Decimal += Chr;
                    }
                    else
                    {
                        Unicode += ConfigurationManager.AppSetting["UnicodePrefix"] + ((int)Chr).ToString("x4") + ConfigurationManager.AppSetting["UnicodePostfix"];
                        Decimal += ConfigurationManager.AppSetting["DecimalPrefix"] + ((int)Chr).ToString("d5") + ConfigurationManager.AppSetting["DecimalPostfix"];
                    }
                }

                UnicodeRTB.TextChanged -= new EventHandler(UnicodeRTB_TextChanged);
                DecimalRTB.TextChanged -= new EventHandler(DecimalRTB_TextChanged);
                UnicodeRTB.Text = Unicode;
                DecimalRTB.Text = Decimal;
                UnicodeRTB.TextChanged += new EventHandler(UnicodeRTB_TextChanged);
                DecimalRTB.TextChanged += new EventHandler(DecimalRTB_TextChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //changing Unicode content
        private void UnicodeRTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Text = "", Decimal = "";

                MatchCollection Unicodes = Regex.Matches(UnicodeRTB.Text, ConfigurationManager.AppSetting["UnicodePrefix"] + @"(?<1>[0-9A-Za-z]{1,4})" + ConfigurationManager.AppSetting["UnicodePostfix"], RegexOptions.IgnoreCase);
                foreach (Match Unicode in Unicodes)
                {
                    string HexaValue = Unicode.Groups[1].Value;
                    Text += Convert.ToChar(Int32.Parse(HexaValue, System.Globalization.NumberStyles.HexNumber)).ToString();
                    Decimal += ConfigurationManager.AppSetting["DecimalPrefix"] + int.Parse(HexaValue, System.Globalization.NumberStyles.HexNumber).ToString("d5") + ConfigurationManager.AppSetting["DecimalPostfix"];
                }

                TextRTB.TextChanged -= new EventHandler(TextRTB_TextChanged);
                DecimalRTB.TextChanged -= new EventHandler(DecimalRTB_TextChanged);
                TextRTB.Text = Text;
                DecimalRTB.Text = Decimal;
                TextRTB.TextChanged += new System.EventHandler(TextRTB_TextChanged);
                DecimalRTB.TextChanged += new System.EventHandler(DecimalRTB_TextChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //changing decimal content
        private void DecimalRTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Text = "", Unicode = "";
                MatchCollection Decimals = Regex.Matches(DecimalRTB.Text, ConfigurationManager.AppSetting["DecimalPrefix"] + @"(?<1>[0-9A-Za-z]{1,5})" + ConfigurationManager.AppSetting["DecimalPostfix"], RegexOptions.IgnoreCase);
                foreach (Match Decimal in Decimals)
                {
                    int DecimalValue = Convert.ToInt32(Decimal.Groups[1].Value);
                    Unicode += ConfigurationManager.AppSetting["UnicodePrefix"] + ((int)DecimalValue).ToString("x4") + ConfigurationManager.AppSetting["UnicodePostfix"];
                    Text += char.ConvertFromUtf32(DecimalValue);
                }

                TextRTB.TextChanged -= new EventHandler(TextRTB_TextChanged);
                UnicodeRTB.TextChanged -= new EventHandler(UnicodeRTB_TextChanged);
                TextRTB.Text = Text;
                UnicodeRTB.Text = Unicode;
                TextRTB.TextChanged += new EventHandler(TextRTB_TextChanged);
                UnicodeRTB.TextChanged += new EventHandler(UnicodeRTB_TextChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}