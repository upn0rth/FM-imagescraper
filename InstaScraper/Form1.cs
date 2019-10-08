Add-Type -Path "C:\Users\JoMa\Desktop\Classes.cs"

$obj = New-Object Sample
$obj2 = New-Object Sample

$obj.GetType().GetMethod("MyMethod").MakeGenericMethod([String]).Invoke($obj, "Test Message")
$obj.GetType().GetMethod("MyMethod").MakeGenericMethod([Double]).Invoke($obj, "Test Message")

$result = $obj2.pop()

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

public class Sample
{
    public static string MyMethod<T>( string anArgument )
    {
        return string.Format( "Generic type is {0} with argument {1}", typeof(T), anArgument );
    }
	
	
	public void pop(){
		
		Form testff = new Form();
		testff.ShowDialog();
		
	}
}
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace InstaScraper
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += Form1_MouseWheel;


        }

        List<string> list = new List<string>();
        string path = "";
        int keywordCheck = 0;

        AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        AutoCompleteStringCollection sourcePass = new AutoCompleteStringCollection();
        AutoCompleteStringCollection sourceKeyword = new AutoCompleteStringCollection();
        AutoCompleteStringCollection sourceFolder = new AutoCompleteStringCollection();
        AutoCompleteStringCollection sourceName = new AutoCompleteStringCollection();


        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            metroRadioButton1.Visible = false;
            metroRadioButton2.Visible = false;
            metroRadioButton4.Visible = false;
            metroCheckBox2.Visible = false;

            Invoke(new Action(() => richTextBox3.AppendText("Current Version 2.0.5.0 - (Remake of GUI)" + Environment.NewLine)));//Update URL list with links


            richTextBox1.Height = 134;
            richTextBox1.Left = 15;
            richTextBox1.Top = 21;
            toolStripLabel2.Text = "2.0.4.0";
            groupBox4.Enabled = true;
            groupBox54.Enabled = false;
            metroCheckBox1.Visible = false;
            groupBox23.Enabled = false;
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            if (resolution.Height < 901)
            {
                this.AutoScroll = true;
            }

           



            try
            {
                //string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/key.txt";
                //string path2 = new Uri(path).LocalPath;

                string path4 = Environment.ExpandEnvironmentVariables("%AppData%\\FM-imagescraper-key\\key.txt");

                string key = File.ReadAllText(path4, Encoding.UTF8);
                List<string> keys = new List<string>();

                keys.Add("c2fdsa05Om");
                keys.Add("Gs0AuUUY2t");
                keys.Add("9l9Nb4hC9k");
                keys.Add("hrJnIgEAdG");
                keys.Add("kTrPaMVOwg");
                keys.Add("bBI52FZlBQ");
                keys.Add("CdWV6Ct0Wd");
                keys.Add("DacBjuT2h8");
                keys.Add("njMUbeCM25");
                keys.Add("srDkvtANj0");

                foreach (var lol in keys)
                {

                    if ((lol + Environment.NewLine) == key)
                    {
                        toolStripLabel1.Text = "Activated";
                        groupBox4.Enabled = true;
                        toolStripTextBox1.Visible = false;
                        toolStripButton1.Visible = false;
                    }

                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Ready to work." + Environment.NewLine)));//Update URL list with links

            }
            catch (Exception ex)
            {

            }



        }



        private void button6_Click(object sender, EventArgs e)
        {
            backgroundWorker2.CancelAsync();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == true)
            {
                backgroundWorker1.CancelAsync();
            }
            if (backgroundWorker2.IsBusy == true)
            {
                backgroundWorker2.CancelAsync();
            }
            if (backgroundWorker3.IsBusy == true)
            {
                backgroundWorker3.CancelAsync();
            }
            if (backgroundWorker4.IsBusy == true)
            {
                backgroundWorker4.CancelAsync();
            }
            if (backgroundWorker5.IsBusy == true)
            {
                backgroundWorker5.CancelAsync();
            }
            if (backgroundWorker6.IsBusy == true)
            {
                backgroundWorker6.CancelAsync();
            }
            if (backgroundWorker7.IsBusy == true)
            {
                backgroundWorker7.CancelAsync();
            }
            if (backgroundWorker8.IsBusy == true)
            {
                backgroundWorker8.CancelAsync();
            }
            if (backgroundWorker9.IsBusy == true)
            {
                backgroundWorker9.CancelAsync();
            }
            if (backgroundWorker10.IsBusy == true)
            {
                backgroundWorker10.CancelAsync();
            }
            if (backgroundWorker11.IsBusy == true)
            {
                backgroundWorker11.CancelAsync();
            }
            if (backgroundWorker12.IsBusy == true)
            {
                backgroundWorker12.CancelAsync();
            }
            if (backgroundWorker13.IsBusy == true)
            {
                backgroundWorker13.CancelAsync();
            }
            if (backgroundWorker14.IsBusy == true)
            {
                backgroundWorker14.CancelAsync();
            }
            if (backgroundWorker15.IsBusy == true)
            {
                backgroundWorker15.CancelAsync();
            }
            if (backgroundWorker16.IsBusy == true)
            {
                backgroundWorker16.CancelAsync();
            }
            if (backgroundWorker17.IsBusy == true)
            {
                backgroundWorker17.CancelAsync();
            }
            if (backgroundWorker18.IsBusy == true)
            {
                backgroundWorker18.CancelAsync();
            }
            if (backgroundWorker19.IsBusy == true)
            {
                backgroundWorker19.CancelAsync();
            }
            if (backgroundWorker20.IsBusy == true)
            {
                backgroundWorker20.CancelAsync();
            }
            if (backgroundWorker21.IsBusy == true)
            {
                backgroundWorker21.CancelAsync();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            metroCheckBox1.Visible = false;
            metroCheckBox1.Enabled = false;
            metroCheckBox1.Checked = false;
            groupBox54.Enabled = false;
            groupBox23.Enabled = false;
            textBox22.Text = "";
            textBox52.Text = "";
            textBox53.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
            textBox24.Text = "";
            richTextBox2.Text = "";
            richTextBox1.Text = "";
        }


        //--------------------------------------Instagram------------------------------------------------------

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                textBox1.Text = fbd.SelectedPath;

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

          


            string userName = textBox52.Text;
            string userPassword = textBox53.Text;

            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();
            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            } ));


            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }

            if (metroRadioButton4.Checked == true)
            {
                keywordList.Add("post");
            }

            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                backgroundWorker1.WorkerReportsProgress = true; //Needed for progressbar
                int progress = 1;
                int maxImg = 0;
                int loaded = 0;
                string renderedContent = "";
                int max = 0;

                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";
                var options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");

                //string options2 = "";

                //var service2 = ChromeDriverService.CreateDefaultService();

                //ChromeOptions option2 = new ChromeOptions();

                //service2.HideCommandPromptWindow = true;
                //option2.AddArgument("--headless");
                //option2.AddArgument("--window-size=1920,1080");
                //option2.AddArguments("--no-sandbox");

                //ChromeDriver driver = new ChromeDriver(service2, option2);

                //--------------------------------------Initialize page------------------------------------------------------

                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {
                    if (metroRadioButton1.Checked == true)
                    {

                        try
                        {
                            //if (rgx.IsMatch(keyword) == true)
                            //{
                            var url = Uri.EscapeUriString(keyword);

                            driver.Navigate().GoToUrl("https://www.instagram.com/" + url + "/");


                            //}
                            //else if(rgx.IsMatch(keyword) == false)
                            //{
                            //    driver.Navigate().GoToUrl("https://www.instagram.com/explore/tags/dota/");

                            //    IWebElement query = driver.FindElement(By.XPath("//*[contains(@class, '_5ayw3')]/input"));
                            //    query.SendKeys(keyword);

                            //    query.SendKeys(OpenQA.Selenium.Keys.Enter);
                            //    query.SendKeys(OpenQA.Selenium.Keys.Enter);
                            //}

                        }
                        catch (Exception ex)
                        {
                          //  Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links

                        }
                    }
                    else if (metroRadioButton2.Checked == true)
                    {


                        try
                        {
                            //driver.Navigate().GoToUrl("https://www.instagram.com/");

                            //driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[2]/p/a")).Click();

                            //IWebElement query = driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[1]/div/form/div[1]/input"));
                            //query.SendKeys(userName);

                            //IWebElement query2 = driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[1]/div/form/div[2]/input"));
                            //query2.SendKeys(userPassword);

                            //driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[1]/div/form/span[1]/button")).Click();

                            //Thread.Sleep(10000);



                            //if (rgx.IsMatch(keyword) == true)
                            //{
                            var url = Uri.EscapeUriString(keyword);
                            driver.Navigate().GoToUrl("https://www.instagram.com/explore/tags/" + url + "/");

                            //}
                            //else if (rgx.IsMatch(keyword) == false)
                            //{
                            //    driver.Navigate().GoToUrl("https://www.instagram.com/explore/tags/dota/");

                            //    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Page 34535345343534345534534534534d properly, please try again" + Environment.NewLine)));//Update URL list with links


                            //    IWebElement query = driver.FindElement(By.XPath("//*[contains(@class, '_5ayw3')]/input"));
                            //    query.SendKeys(keyword);

                            //    query.SendKeys(OpenQA.Selenium.Keys.Enter);
                            //   query.SendKeys(OpenQA.Selenium.Keys.Enter);


                            //        driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenhhhhhhhhshot.png", ImageFormat.Png);

                            //}




                            //     driver.FindElement(By.XPath("//*[contains(@class, '_5ayw3')]/input")).SendKeys(OpenQA.Selenium.Keys.Enter);



                        }
                        catch (Exception ex)
                        {
                          //  Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links

                        }
                    }
                    else if (metroRadioButton4.Checked == true)
                    {
                        try
                        {

                            driver.Navigate().GoToUrl("https://www.instagram.com/");

                            // driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[2]/p/a")).Click();

                            //     driver.FindElement(By.XPath("(//*[contains(@class, '_76e0u')]/a)[1]")).Click();
                            driver.FindElement(By.XPath("//*[contains(@class, '_g9ean')]/a")).Click();


                            IWebElement query = driver.FindElement(By.XPath("(//*[contains(@class, '_sjplo')])[1]/input"));
                            query.SendKeys(userName);

                            IWebElement query2 = driver.FindElement(By.XPath("(//*[contains(@class, '_sjplo')])[2]/input"));
                            query2.SendKeys(userPassword);

                            //       driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot399.png", ImageFormat.Png);


                            driver.FindElement(By.XPath("(//*[contains(@class, '_qv64e')])[1]")).Click();

                            Thread.Sleep(10000);
                        }
                        catch (Exception ty)
                        {
                       //     Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ty + Environment.NewLine)));//Update URL list with links

                        }


                        //     driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot35.png", ImageFormat.Png);



                        try
                        {

                            driver.Navigate().GoToUrl("https://www.instagram.com/" + userName + "/saved/");



                            //     driver.FindElement(By.XPath("//*[contains(@class, '_deuoy')]/button")).Click();

                            //     driver.FindElement(By.XPath("//*[contains(@class, 'coreSpriteDesktopNavProfile')]")).Click();

                            //    //    driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot44.png", ImageFormat.Png);


                            Thread.Sleep(5000);
                            //    driver.FindElement(By.XPath("(//*[contains(@class, '_2e96w')]/a)[2]")).Click();

                            //   driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot64.png", ImageFormat.Png);


                        }
                        catch (Exception ex)
                        {
                        //    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links

                        }



                    }

                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                    try
                    {
                        driver.FindElement(By.XPath("//*[contains(@class, '_deuoy')]/button")).Click();

                        driver.FindElement(By.XPath("//*[contains(@class, 'coreSpriteDesktopNavProfile')]")).Click();

                        //   driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot44.png", ImageFormat.Png);


                        Thread.Sleep(5000);
                        driver.FindElement(By.XPath("(//*[contains(@class, '_2e96w')]/a)[2]")).Click();

                    }
                    catch (Exception ex)
                    {
                    //    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links

                    }
                    // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot37.png", ImageFormat.Png);


                    //--------------------------------------Initialize page------------------------------------------------------

                    //---------------------------------------Load content--------------------------------------------------------

                    //    driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot3.png", ImageFormat.Png);


                    try
                    {
                        driver.FindElement(By.XPath("//*[contains(@class, '_1cr2e')]")).Click();

                    }
                    catch (Exception yl)
                    {
                    //    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + yl + Environment.NewLine)));//Update URL list with links

                    }

                    //         driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot35.png", ImageFormat.Png);
                    int y = 0;
                    do
                    {

                        for (int i = 0; i < 10; i++)
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(500);
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 700)");
                            Thread.Sleep(500);
                        }

                        //        driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot55.png", ImageFormat.Png);


                        //    break;

                        try
                        {
                            renderedContent = renderedContent + driver.PageSource;
                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//img/@src");

                            if (loaded == aTags1.Count)
                            {
                                break;
                            }

                            if (theNumber != 0)
                            {
                                maxImg = theNumber;
                                max = maxImg;
                            }
                            else if (theNumber == 0)
                            {
                                max = 10000;
                            }


                            loaded = aTags1.Count;
                        }
                        catch (Exception ex)
                        {
                      //      Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Page not loaded properly, please try again" + Environment.NewLine)));//Update URL list with links
                            break;
                        }



                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links


                    } while (loaded < max);

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " images.." + Environment.NewLine)));//Update URL list with links

                    //  driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot3.png", ImageFormat.Png);

                    //---------------------------------------Load content--------------------------------------------------------

                    //-------------------------------------Download content------------------------------------------------------

                    try
                    {

                        HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                        doc2.LoadHtml(renderedContent);
                        int desc = 0;
                        HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//img/@src");
                        HtmlNodeCollection aTags3 = doc2.DocumentNode.SelectNodes("//img/@alt");

                        int imageNumber = 1;
                        string replaceNewline = "";

                        if (metroCheckBox2.Checked == true)
                        {
                            using (System.IO.StreamWriter file =
                                                                       new System.IO.StreamWriter(folder + "/Descs.csv", true))
                            {

                                file.WriteLine("ImageNumber" + "," + "Descriptions");
                            }
                        }

                        int counter = 1;

                        foreach (var aTag in aTags2)
                        {
                            Invoke(new Action(() => metroLabel11.Text = "Downloading " + counter + @"/" + max));
                            counter++;

                            if (imageNumber == (max + 1))
                            {
                                break;
                            }
                            Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (max)));

                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading: " + aTag.Attributes["src"].Value + Environment.NewLine)));//Update URL list with links


                            if (backgroundWorker1.CancellationPending == false)
                            {

                                try
                                {
                                    using (WebClient webClient = new WebClient())
                                    {

                                        var result = webClient.DownloadData(aTag.InnerHtml + aTag.Attributes["src"].Value);
                                        var contentType = webClient.ResponseHeaders["Content-Type"];
                                        contentType = contentType.Replace("image/", "");

                                        if (textBox4.Text == "")
                                        {
                                            webClient.DownloadFile(aTag.InnerHtml + aTag.Attributes["src"].Value, folder + "/" + keyword + imageNumber + "." + contentType);//Downloads the images

                                            if (metroCheckBox2.Checked == true)
                                            {
                                                using (System.IO.StreamWriter file =
                                                                        new System.IO.StreamWriter(folder + "/" + keyword + ".txt", true))
                                                {
                                                    file.WriteLine(imageNumber + ". - " + aTags3[desc].Attributes["alt"].Value + Environment.NewLine);
                                                }
                                                using (System.IO.StreamWriter file =
                                                                       new System.IO.StreamWriter(folder + "/Descs.csv", true))
                                                {
                                                    replaceNewline = Regex.Replace(aTags3[desc].Attributes["alt"].Value, @"\r\n?|\n", "");

                                                    file.WriteLine(imageNumber + "," + replaceNewline + Environment.NewLine);
                                                }

                                            }


                                        }
                                        else if (textBox4.Text != "")
                                        {
                                            webClient.DownloadFile(aTag.InnerHtml + aTag.Attributes["src"].Value, folder + "/" + textBox4.Text + noName + imageNumber + "." + contentType);//Downloads the images

                                            if (metroCheckBox2.Checked == true)
                                            {
                                                using (System.IO.StreamWriter file =
                                                                        new System.IO.StreamWriter(folder + "/Descs.txt", true))
                                                {
                                                    file.WriteLine(imageNumber + ". - " + aTags3[desc].Attributes["alt"].Value + Environment.NewLine);
                                                }

                                                using (System.IO.StreamWriter file =
                                                                        new System.IO.StreamWriter(folder + "/Descs.csv", true))
                                                {
                                                    replaceNewline = Regex.Replace(aTags3[desc].Attributes["alt"].Value, @"\r\n?|\n", "");

                                                    file.WriteLine(imageNumber + "," + replaceNewline + Environment.NewLine);
                                                }


                                            }

                                        }
                                        desc++;
                                    }

                                }
                                catch (Exception ex)
                                {
                                  //  Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links

                                }



                                progress++;
                                imageNumber++;
                                Invoke(new Action(() => backgroundWorker1.ReportProgress(progress)));
                            }
                            else if (backgroundWorker1.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }

                            //-------------------------------------Download content------------------------------------------------------

                        }
                    }
                    catch (Exception ex)
                    {
                     //   Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links

                    }


                }

            }

            // driver.Manage().Window.Size = new Size(1920, 1000);




        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }


        //--------------------------------------Instagram------------------------------------------------------

        //----------------------------------------Google-------------------------------------------------------

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
           

            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 600;
            }

            

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();
            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;


            foreach (var keyword in keywordList)
            {
                noName++;

                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images - " + keyword + Environment.NewLine)));//Update URL list with links
                backgroundWorker2.WorkerReportsProgress = true; //Needed for progressbar
                int progress = 1;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;
                string yrl = "";

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }


                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";

                if(keyword.Contains(" "))
                {
                    keyword.Replace(" ","+");
                }

                if (theNumber != 1)
                {
                    yrl = keyword;

                }
                else if (theNumber == 1)
                {
                    yrl = System.Text.RegularExpressions.Regex.Match(keyword, @"^(.*?)\;").Groups[1].Value;
                    Invoke(new Action(() => textBox4.Text = System.Text.RegularExpressions.Regex.Match(keyword, @"\;(.*)").Groups[1].Value));//Update URL list with links

                }



                //Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + keyword + Environment.NewLine)));//Update URL list with links
                //Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " +  yrl + Environment.NewLine)));//Update URL list with links


                //      Invoke(new Action(() => richTextBox4.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + yrl + Environment.NewLine)));//Update URL list with links


                PhantomJSOptions options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:26.0) Gecko/20100101 Firefox/26.0");


                //---------------------------------------Initialize content--------------------------------------------------------

                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {

                    if (metroCheckBox4.Checked == true)
                    {
                        driver.Navigate().GoToUrl("https://www.google.com/search?q=" + yrl + "&hl=sv&tbm=isch&source=lnt&tbs=sur:fc&sa=X&ved=0ahUKEwiKiO6a39PbAhXEJSwKHeVaBToQpwUIHw&biw=1246&bih=967&dpr=1");

                        Thread.Sleep(5000);

                       // Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "fdgfdgdfdg" + Environment.NewLine)));//Update URL list with links


                    }
                    else if (metroCheckBox4.Checked == false)
                    {
                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));

                        //try
                        //{
                        driver.Navigate().GoToUrl("https://www.google.com/search?q=" + yrl + "&hl=sv&source=lnms&tbm=isch&sa=X&ved=0ahUKEwidipC-9q3cAhWHO5oKHS45A0UQ_AUICigB&biw=1278&bih=960");

                        //Thread.Sleep(5000);

                        //IWebElement query = driver.FindElement(By.XPath("//*[contains(@id, 'gs_lc0')]/input[1]"));
                        //query.SendKeys(yrl);

                        //driver.FindElement(By.XPath("//*[contains(@id, 'gs_lc0')]/input[1]")).SendKeys(OpenQA.Selenium.Keys.Enter);

                        //Thread.Sleep(5000);

                        //driver.FindElement(By.XPath("(//*[contains(@class, 'q qs')])[1]")).Click();

                    //    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "aaaaaaaaaaaaaaaaaaaadfdg" + Environment.NewLine)));//Update URL list with links

                    }




                    //      ((IJavaScriptExecutor)driver).ExecuteScript("(function() { var elems5 = document.getElementsByClassName('gsfi'); elems5[0].click(); })()");

                    Thread.Sleep(5000);

                   // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\a11122.png", ImageFormat.Png);


                      //   driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshotgooooggr.png", ImageFormat.Png);


                    //     Thread.Sleep(10000);

                    //}
                    //catch (Exception ex)
                    //{

                    //}
                    int loaded = 0;
                    string renderedContent = "";

                    for (int j = 0; j < 1; j++)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(1000);
                        }

                        try
                        {
                            driver.FindElement(By.XPath("//*[@id='smb']")).Click();
                        }
                        catch (Exception ex)
                        {
                          //  Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Page not loaded properly, please try again" + Environment.NewLine)));//Update URL list with links
                           // break;
                        }
                        

                        for (int i = 0; i < 10; i++)
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(1000);
                        }

                        //-------------------------------------Initialize content----------------------------------------------------

                        //---------------------------------------Load content--------------------------------------------------------

                        try
                        {
                            renderedContent = driver.PageSource;
                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[@id='rg_s']/div/div/text()");

                            if (loaded == aTags1.Count)
                            {
                                break;
                            }


                            loaded = aTags1.Count;

                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links
                        }
                        catch (Exception ex)
                        {

                        }


                    }

                    //---------------------------------------Load content--------------------------------------------------------

                    //-------------------------------------Download content------------------------------------------------------

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + theNumber + " images" + Environment.NewLine)));//Update URL list with links


                    try
                    {
                        HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                        doc2.LoadHtml(renderedContent);
                        HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//*[@id='rg_s']/div/div/text()");
                        int imageNumber = 1;

                        string url = "";

                        int counter = 1;

                        foreach (var aTag in aTags2)
                        {
                            Invoke(new Action(() => metroLabel11.Text = "Downloading " + counter + @"/" + loaded));
                            counter++;
                            if (imageNumber == (theNumber + 1))
                            {
                                break;
                            }

                            if (backgroundWorker2.CancellationPending == false)
                            {
                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + System.Text.RegularExpressions.Regex.Match(aTag.InnerHtml + aTag.InnerText, "\"ou\":\\s*?\"([^\"]+)\"").Groups[1].Value + Environment.NewLine))); //Update URL list with links
                                url = System.Text.RegularExpressions.Regex.Match(DateTime.Now.ToString("HH:mm:ss tt") + ": " + aTag.InnerHtml + aTag.InnerText, "\"ou\":\\s*?\"([^\"]+)\"").Groups[1].Value;
                              
                                try
                                {

                                    ServicePointManager.Expect100Continue = true;
                                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                                    using (WebClient webClient = new WebClient())
                                    {


                                        var result = webClient.DownloadData(url);
                                        var contentType = webClient.ResponseHeaders["Content-Type"];
                                        contentType = contentType.Replace("image/", "");
                                        int ett = 0;

                                        try {
                                            ett = Convert.ToInt32(textBox24.Text);
                                        }
                                        catch (Exception s)
                                        {

                                        }


                                        if (textBox4.Text == "" && ett != 1)
                                        {
                                            webClient.DownloadFile(System.Text.RegularExpressions.Regex.Match(aTag.InnerHtml + aTag.InnerText, "\"ou\":\\s*?\"([^\"]+)\"").Groups[1].Value, folder + "/" + keyword + imageNumber + "." + contentType); //Downloads the images
                                        }

                                        else if (textBox4.Text != "" && ett == 1)
                                        {
                                            string name = System.Text.RegularExpressions.Regex.Match(keyword, @"\;(.*)").Groups[1].Value;
                                            webClient.DownloadFile(System.Text.RegularExpressions.Regex.Match(aTag.InnerHtml + aTag.InnerText, "\"ou\":\\s*?\"([^\"]+)\"").Groups[1].Value, folder + "/" + name + "." + contentType); //Downloads the images
                                        }
                                        else if (textBox4.Text != "")
                                        {

                                            webClient.DownloadFile(System.Text.RegularExpressions.Regex.Match(aTag.InnerHtml + aTag.InnerText, "\"ou\":\\s*?\"([^\"]+)\"").Groups[1].Value, folder + "/" + textBox4.Text + noName + imageNumber + "." + contentType); //Downloads the images
                                          //  mybt = new UserControl1(folder + "/" + textBox4.Text + noName + imageNumber + "." + contentType, keyword + imageNumber);
                                        }


                                    }
                                    imageNumber++;


                                }
                                catch (Exception ex)
                                {
                                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine))); //Update URL list with links

                                }
                                //progress++;
                                //Invoke(new Action(() => backgroundWorker2.ReportProgress(progress)));



                            }
                            else if (backgroundWorker2.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }
                           

                        }
                    }
                    catch (Exception ex)
                    {

                    }

                    //-------------------------------------Download content------------------------------------------------------
                }
            }

            
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        //----------------------------------------Google-------------------------------------------------------

        //-----------------------------------------Bing--------------------------------------------------------


        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }

            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                backgroundWorker3.WorkerReportsProgress = true; //Needed for progressbar
                int progress = 1;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";
                int loaded = 0;
                string renderedContent = "";

                PhantomJSOptions options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:26.0) Gecko/20100101 Firefox/26.0");


                //---------------------------------------Initialize content--------------------------------------------------------

                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {

                    try
                    {
                        var url = Uri.EscapeUriString(keyword);

                        driver.Navigate().GoToUrl("https://www.bing.com/images/search?q=" + keyword + "&qs=n&form=QBLH&scope=images&pq=" + url + "&sc=8-3&sp=-1&sk=&cvid=4925674AF89749FFA68F006756252AA7");
                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    }
                    catch (Exception ex)
                    {

                    }

                    for (int j = 0; j < 2; j++)
                    {

                        for (int i = 0; i < 10; i++)
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(1000);
                        }

                        try
                        {
                            renderedContent = driver.PageSource;

                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[@class='imgpt']/a/@m");

                            try
                            {
                            }
                            catch (NullReferenceException ef)
                            {
                                break;
                            }

                            loaded = aTags1.Count;

                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links
                        }
                        catch (Exception ex)
                        {

                        }

                    }

                    //---------------------------------------Initialize content--------------------------------------------------------



                    //driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);

                    //---------------------------------------Load content--------------------------------------------------------

                    try
                    {

                        HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                        doc2.LoadHtml(renderedContent);
                        HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//*[@class='imgpt']/a/@m");
                        int imageNumber = 1;
                        int counter = 1;

                        foreach (var aTag in aTags2)
                        {
                            Invoke(new Action(() => metroLabel11.Text = "Downloading " + counter + @"/" + loaded));
                            counter++;
                            Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (loaded)));
                            if (imageNumber == (theNumber + 1))
                            {
                                break;
                            }

                            string bingg2 = "";

                            if (backgroundWorker3.CancellationPending == false)
                            {
                                string bingg = aTag.Attributes["m"].Value;
                                string bingreg = System.Text.RegularExpressions.Regex.Match(bingg, "murl&quot;:&quot;([^;]*)&quot;,&quot;turl").Groups[1].Value;
                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + bingreg + Environment.NewLine))); //Update URL list with links+

                                if (bingreg != "")
                                {
                                    try
                                    {
                                        using (WebClient webClient = new WebClient())
                                        {
                                            var result = webClient.DownloadData(bingreg);
                                            var contentType = webClient.ResponseHeaders["Content-Type"];
                                            contentType = contentType.Replace("image/", "");

                                            try
                                            {

                                                if (textBox4.Text == "")
                                                {
                                                    webClient.DownloadFile(bingreg, folder + "/" + keyword + imageNumber + "." + contentType); //Downloads the images
                                                }
                                                else if (textBox4.Text != "")
                                                {
                                                    webClient.DownloadFile(bingreg, folder + "/" + textBox4.Text + imageNumber + "." + contentType); //Downloads the images
                                                }

                                                imageNumber++;
                                            }
                                            catch (Exception ex)
                                            {

                                            }
                                        }

                                    }
                                    catch (WebException ex)
                                    {

                                    }
                                }


                                progress++;
                                Invoke(new Action(() => backgroundWorker3.ReportProgress(progress)));

                              
                            }
                            else if (backgroundWorker3.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                    }

                    //---------------------------------------Load content--------------------------------------------------------

                }
            }

            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            backgroundWorker3.CancelAsync();
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        //-----------------------------------------Bing--------------------------------------------------------

        //----------------------------------------Twitter------------------------------------------------------


        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;


            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                backgroundWorker4.WorkerReportsProgress = true; //Needed for progressbar
                int progress = 1;
                int max = 1000;

                if (theNumber != 0)
                {
                    max = Convert.ToInt32(textBox24.Text);
                }

                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";

                var service2 = ChromeDriverService.CreateDefaultService();

                ChromeOptions option2 = new ChromeOptions();

                service2.HideCommandPromptWindow = true;
                option2.AddArgument("--headless");
                option2.AddArgument("--window-size=1920,1080");
                option2.AddArguments("--no-sandbox");

                ChromeDriver driver = new ChromeDriver(service2, option2);

                //---------------------------------------Initialize content--------------------------------------------------------

                PhantomJSOptions options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:26.0) Gecko/20100101 Firefox/26.0");

      
                    var url = Uri.EscapeUriString(keyword);

                    driver.Navigate().GoToUrl("https://twitter.com/" + url);

                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    int loaded = 0;
                    string renderedContent = "";

                    do
                    {


                        for (int i = 0; i < 10; i++)
                        {

                        try
                        {
                            //    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "aaab" + loaded + Environment.NewLine)));//Update URL list with links

                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(1000);
                        }
                        catch (InvalidOperationException yt)
                        {
                            break;
                        }

                    }


                        try
                        {
                            renderedContent = driver.PageSource;

                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[@class='content']/div/div//img/@src");


                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + aTags1.Count + Environment.NewLine)));//Update URL list with links


                            try
                            {
                            }
                            catch (NullReferenceException g)
                            {

                            }

                            if (loaded == aTags1.Count)
                            {
                                break;
                            }

                            loaded = aTags1.Count;

                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links
                        }
                        catch (Exception ex)
                        {

                        }


                    } while (max > loaded);


                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " images.." + Environment.NewLine)));//Update URL list with links


                    //---------------------------------------Initialize content--------------------------------------------------------



                    //-----------------------------------------Load content------------------------------------------------------------

                    try
                    {
                        HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                        doc2.LoadHtml(renderedContent);
                        HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//*[@class='content']/div/div//img/@src");
                        int imageNumber = 1;

                        foreach (var aTag in aTags2)
                        {
                            if (imageNumber == (max + 1))
                            {
                                break;
                            }
                            Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (max)));


                            if (backgroundWorker4.CancellationPending == false)
                            {
                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + aTag.InnerHtml + aTag.Attributes["src"].Value + Environment.NewLine)));//Update URL list with links

                                try
                                {
                                    using (WebClient webClient = new WebClient())
                                    {
                                        var result = webClient.DownloadData(aTag.InnerHtml + aTag.Attributes["src"].Value);
                                        var contentType = webClient.ResponseHeaders["Content-Type"];
                                        contentType = contentType.Replace("image/", "");

                                        try
                                        {

                                            if (textBox4.Text == "")
                                            {
                                                webClient.DownloadFile(aTag.InnerHtml + aTag.Attributes["src"].Value, folder + "/" + keyword + imageNumber + "." + contentType);//Downloads the images
                                            }
                                            else if (textBox4.Text != "")
                                            {
                                                webClient.DownloadFile(aTag.InnerHtml + aTag.Attributes["src"].Value, folder + "/" + textBox4.Text + imageNumber + "." + contentType);//Downloads the images
                                            }


                                           

                                            imageNumber++;
                                        }
                                        catch (Exception ex)
                                        {
                                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                        }
                                    }

                                }
                                catch (WebException ex)
                                {
                                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                }
                                progress++;
                                Invoke(new Action(() => backgroundWorker1.ReportProgress(progress)));
                            }
                            else if (backgroundWorker4.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }

                        }

                    }
                    catch (Exception ex)
                    {

                    }
                
            }

           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            backgroundWorker4.CancelAsync();
        }

        //----------------------------------------Twitter------------------------------------------------------

        //----------------------------------------Imgurl------------------------------------------------------

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 1000;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                backgroundWorker1.WorkerReportsProgress = true; //Needed for progressbar
                int progress = 1;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";


                //----------------------------------------Initialize content------------------------------------------------------

                PhantomJSOptions options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:26.0) Gecko/20100101 Firefox/26.0");

                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {
                    driver.Manage().Window.Size = new Size(1920, 100000);

                    var url = Uri.EscapeUriString(keyword);

                    //if (metroCheckBox3.Checked == false)
                    //{
                     //   driver.Navigate().GoToUrl("http://imgur.com/search?q=" + url);
                    //}
                    //else if (metroCheckBox3.Checked == true)
                    //{
                        driver.Navigate().GoToUrl(url);
                    //}



                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    int loaded = 0;
                    string renderedContent = "";



                    do
                    {

                        for (int i = 0; i < 5; i++)
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(1000);
                        }

                        try
                        {
                            driver.FindElement(By.XPath("//*[@id='load-more']")).Click();

                        }
                        catch (NoSuchElementException ex)
                        {

                        }
                        catch (WebDriverException xe)
                        {

                        }

                        //for (int i = 0; i < 5; i++)
                        //{
                        //    try
                        //    {
                        //        ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                        //        Thread.Sleep(1000);
                        //    }
                        //    catch (Exception eg)
                        //    {

                        //    }

                        //}


                        try
                        {


                            renderedContent = driver.PageSource;

                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'image-list-link')]/img/@src");

                            loaded = aTags1.Count;

                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links

                            if (loaded > theNumber)
                            {
                                break;
                            }


                        }
                        catch (Exception ex)
                        {

                            try
                            {


                                renderedContent = driver.PageSource;

                                HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                                doc1.LoadHtml(renderedContent);
                                HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'image')]/img/@src");


                                if (loaded == aTags1.Count)
                                {
                                    break;
                                }

                                loaded = aTags1.Count;

                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links

                                if (loaded > theNumber)
                                {
                                    break;
                                }
                                


                            }
                            catch (Exception exd)
                            {

                            }
                        }

                    } while (loaded < theNumber);

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + theNumber + " images.." +  Environment.NewLine)));//Update URL list with links


                    //----------------------------------------Initialize content------------------------------------------------------


                    //------------------------------------------Load content----------------------------------------------------------

                    try
                    {

                        HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                        doc2.LoadHtml(renderedContent);
                        HtmlNodeCollection aTags2;
                        aTags2 = doc2.DocumentNode.SelectNodes("//*[contains(@class, 'image-list-link')]/img/@src");
                        int imageNumber = 1;
                        string realType = "";

                        if (aTags2 == null)
                        {
                            aTags2 = doc2.DocumentNode.SelectNodes("//*[contains(@class, 'image')]/img/@src");

                        }

                        foreach (var aTag in aTags2)
                        {
                            if (imageNumber == (theNumber + 1))
                            {
                                break;
                            }
                            Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (loaded)));


                            if (backgroundWorker5.CancellationPending == false)
                            {
                                string http = "http:";
                                string imgurll = aTag.InnerHtml + aTag.Attributes["src"].Value;
                                string imgurlTrim = imgurll.Replace("b.jpg", ".jpg");
                                http += imgurlTrim;

                                try
                                {
                                    using (MyWebClient webClient = new MyWebClient())
                                    {
                                        webClient.Proxy = null;
                                        // var result = webClient.DownloadData(http);
                                        // var contentType = webClient.ResponseHeaders["Content-Type"];
                                        // contentType = contentType.Replace("image/", "");

                                        try
                                        {
                                            string http2 = "http:";
                                            string imgurll2 = aTag.InnerHtml + aTag.Attributes["src"].Value;
                                            string imgurlTrim2 = imgurll2.Replace("b.jpg", ".jpg");

                                            if (textBox4.Text == "")
                                            {
                                                http2 += imgurlTrim2;
                                                //webClient.DownloadFile(http2, textBox11.Text + "/" + textBox10.Text + imageNumber + "." + "jpg");//Downloads the images                                     
                                                //webClient.Dispose();

                                                WebRequest objRequest = System.Net.HttpWebRequest.Create(http2);
                                                WebResponse objResponse = objRequest.GetResponse();
                                                var contentType = objResponse.ContentType;
                                                contentType = contentType.Replace("image/", "");
                                                realType = http2.Replace("jpg", contentType);
                                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + realType + Environment.NewLine)));//Update URL list with links   
                                                //Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + http + Environment.NewLine)));//Update URL list with links   



                                                byte[] buffer = new byte[32768];
                                                using (Stream input = objResponse.GetResponseStream())
                                                {
                                                    using (FileStream output = new FileStream(folder + "/" + keyword + imageNumber + "." + contentType,
                                                    FileMode.CreateNew))
                                                    {
                                                        int bytesRead;

                                                        while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                                                        {
                                                            output.Write(buffer, 0, bytesRead);
                                                        }
                                                    }
                                                }



                                            }
                                            else if (textBox4.Text != "")
                                            {
                                                http2 += imgurlTrim2;
                                                //webClient.DownloadFile(http2, textBox11.Text + "/" + textBox17.Text + imageNumber + "." + "jpg");//Downloads the images

                                                WebRequest objRequest = System.Net.HttpWebRequest.Create(http2);
                                                WebResponse objResponse = objRequest.GetResponse();
                                                var contentType = objResponse.ContentType;
                                                contentType = contentType.Replace("image/", "");
                                                realType = http2.Replace("jpg", contentType);
                                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + realType + Environment.NewLine)));//Update URL list with links   


                                                byte[] buffer = new byte[32768];
                                                using (Stream input = objResponse.GetResponseStream())
                                                {
                                                    using (FileStream output = new FileStream(folder + "/" + textBox4.Text + noName + imageNumber + "." + contentType,
                                                    FileMode.CreateNew))
                                                    {
                                                        int bytesRead;

                                                        while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                                                        {
                                                            output.Write(buffer, 0, bytesRead);
                                                        }
                                                    }
                                                }



                                            }

                                           


                                            imageNumber++;
                                        }
                                        catch (Exception ex)
                                        {
                                            imageNumber++;

                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    imageNumber++;

                                }
                                progress++;
                                Invoke(new Action(() => backgroundWorker5.ReportProgress(progress)));
                            }
                            else if (backgroundWorker5.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                    }

                    //------------------------------------------Load content----------------------------------------------------------


                }
            }

            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            backgroundWorker5.CancelAsync();
        }

        //----------------------------------------Imgurl------------------------------------------------------

        //----------------------------------------Tumblr------------------------------------------------------

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();
            int theNumber = 0;
            int theLoop = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 1000;
            }

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                int progress = 1;
                int page = 1;
                int imageNumber = 1;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));
                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";

                //------------------------------------------Initialize content----------------------------------------------------------

                PhantomJSOptions options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Linux; U; Android 4.0.3; ko-kr; LG-L160L Build/IML74K) AppleWebkit/534.30 (KHTML, like Gecko) Version/4.0 Mobile Safari/534.30");



                do
                {

                    

                    using (IWebDriver driver = new PhantomJSDriver(service, options))
                    {
                        if (backgroundWorker6.CancellationPending == false)
                        {



                            try
                            {


                                driver.Navigate().GoToUrl(keyword + "page/" + page);

                                Thread.Sleep(5000);

                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + keyword + "page/" + page + Environment.NewLine)));//Update URL list with links


                                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                                int loaded = 0;
                                string renderedContent = "";
                                renderedContent = driver.PageSource;
                                HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                                doc1.LoadHtml(renderedContent);
                                HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//img/@src");
                                loaded = aTags1.Count;

                                // Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links



                                HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                                doc2.LoadHtml(renderedContent);
                                HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//img/@src");

                                foreach (var aTag in aTags2)
                                {
                                    Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (loaded)));

                                    //if (imageNumber == (theNumber + 1))
                                    //{
                                    //    theLoop++;
                                    //    if (theLoop == 2)
                                    //    {
                                    //        break;
                                    //    }

                                    //}

                                    if (theNumber == (imageNumber - 1))
                                    {
                                        break;
                                    }

                                    if (backgroundWorker6.CancellationPending == false)
                                    {
                                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + aTag.InnerHtml + aTag.Attributes["src"].Value + Environment.NewLine)));//Update URL list with links

                                        try
                                        {
                                            using (WebClient webClient = new WebClient())
                                            {
                                                //var result = webClient.DownloadData(aTag.InnerHtml + aTag.Attributes["src"].Value);
                                                //var contentType = webClient.ResponseHeaders["Content-Type"];
                                                //Int64 bytes_total = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);
                                                //contentType = contentType.Replace("image/", "");

                                                //if (bytes_total > 4000)
                                                //{
                                                try
                                                {

                                                    if (textBox4.Text == "")
                                                    {
                                                        webClient.DownloadFile(aTag.InnerHtml + aTag.Attributes["src"].Value, folder + "/" + "image" + imageNumber + "." + "jpg");//Downloads the images
                                                    }
                                                    else if (textBox4.Text != "")
                                                    {
                                                        webClient.DownloadFile(aTag.InnerHtml + aTag.Attributes["src"].Value, folder + "/" + textBox4.Text + noName + imageNumber + "." + "jpg");//Downloads the images
                                                    }



                                                    imageNumber++;
                                                }
                                                catch (Exception ex)
                                                {
                                                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                                }
                                                //}
                                                

                                            }

                                        }
                                        catch (WebException ex)
                                        {
                                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                        }
                                        progress++;
                                        Invoke(new Action(() => backgroundWorker6.ReportProgress(progress)));
                                    }
                                    else if (backgroundWorker6.CancellationPending == true)
                                    {
                                        e.Cancel = true;
                                        break;
                                    }

                                }
                                page++;
                            }
                            catch (Exception ex)
                            {
                            }
                        }

                        driver.Close();

                    }


                } while (imageNumber < theNumber);

 


                        //------------------------------------------Initialize content----------------------------------------------------------

                    
                
            }

          
        }

        private void button22_Click(object sender, EventArgs e)
        {
            backgroundWorker6.CancelAsync();
        }

        private void backgroundWorker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        //----------------------------------------Tumblr------------------------------------------------------


        //---------------------------------------Universal----------------------------------------------------


        private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                int progress = 1;
                int maxImg = 0;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";
                var options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:16.0) Gecko/20121026 Firefox/16.0");


                //------------------------------------------Initialize content----------------------------------------------------------

                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {
                    var url = Uri.EscapeUriString(keyword);

                    driver.Navigate().GoToUrl(url);
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                    int loaded = 0;
                    string renderedContent = "";
                    int max = 0;
                    int page = 2;

                    do
                    {

                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                        Thread.Sleep(500);
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 700)");
                        Thread.Sleep(1000);

                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));


                        try
                        {
                            renderedContent += driver.PageSource;

                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes(textBox22.Text);

                            if (loaded == aTags1.Count)
                            {
                                break;
                            }

                            if (theNumber != 0)
                            {
                                maxImg = int.Parse(textBox24.Text);
                                max = maxImg;
                            }
                            else if (theNumber == 0)
                            {
                                max = 1000;
                            }


                            loaded = aTags1.Count;

                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links
                        }
                        catch (Exception ex)
                        {

                        }


                        try
                        {
                            driver.FindElement(By.XPath(@"//a[text()='" + page + "']")).Click();
                            page++;
                        }
                        catch (Exception ex)
                        {
                          //  Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links

                        }

                    } while (loaded < max);

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " images.." + Environment.NewLine)));//Update URL list with links


                    //------------------------------------------Initialize content----------------------------------------------------------

                    //--------------------------------------------Load content--------------------------------------------------------------

                    try
                    {
                        HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                        doc2.LoadHtml(renderedContent);
                        HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes(textBox22.Text);
                        int imageNumber = 1;

                        foreach (var aTag in aTags2)
                        {
                            if (imageNumber == (max + 1))
                            {
                                break;
                            }
                            Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (max)));


                            if (backgroundWorker7.CancellationPending == false)
                            {
                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + aTag.InnerHtml + aTag.Attributes["src"].Value + Environment.NewLine)));//Update URL list with links

                                try
                                {
                                    using (WebClient webClient = new WebClient())
                                    {

                                        var result = webClient.DownloadData(aTag.InnerHtml + aTag.Attributes["src"].Value);
                                        var contentType = webClient.ResponseHeaders["Content-Type"];
                                        Int64 bytes_total = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);
                                        contentType = contentType.Replace("image/", "");


                                        if (bytes_total > 4000)
                                        {

                                            if (textBox4.Text == "")
                                            {
                                                webClient.DownloadFile(aTag.InnerHtml + aTag.Attributes["src"].Value, folder + "/" + "Image" + imageNumber + "." + contentType);//Downloads the images
                                            }
                                            else if (textBox4.Text != "")
                                            {
                                                webClient.DownloadFile(aTag.InnerHtml + aTag.Attributes["src"].Value, folder + "/" + textBox4.Text + imageNumber + "." + contentType);//Downloads the images
                                            }
                                        }

                                    }

                                }
                                catch (Exception ex)
                                {

                                }

                                

                                progress++;
                                imageNumber++;
                            }
                            else if (backgroundWorker1.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }

                    //--------------------------------------------Load content--------------------------------------------------------------

                }
            }

            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";
        }

        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";
        }

        private void backgroundWorker5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";
        }

        private void backgroundWorker5_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void backgroundWorker6_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";
        }

        private void backgroundWorker7_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void backgroundWorker7_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";
        }

        private void backgroundWorker8_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword2 in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                int progress = 1;
                int page = 1;
                int imageNumber = 1;
                string keyword = keyword2;
                keyword = Regex.Replace(keyword, " ", "+");
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));
                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";


                //------------------------------------------Initialize content----------------------------------------------------------

                PhantomJSOptions options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:26.0) Gecko/20100101 Firefox/26.0");

                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {



                    for (int o = 0; o < 50; o++)
                    {

                        if (backgroundWorker8.CancellationPending == false)
                        {

                            try
                            {
                                if (keyword.Contains(" "))
                                {
                                    keyword.Replace(" ","+");
                                }
                                var url = Uri.EscapeUriString(keyword);

                                driver.Navigate().GoToUrl("https://pixabay.com/sv/photos/?q=" + url + "&image_type=&min_width=&min_height=&cat=&pagi=" + page);


                                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                                int loaded = 0;
                                string renderedContent = "";
                                renderedContent = driver.PageSource;
                                HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                                doc1.LoadHtml(renderedContent);
                                HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[@class='item']/a/img/@srcset");
                                loaded = aTags1.Count;

                             //   Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links



                                HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                                doc2.LoadHtml(renderedContent);
                                HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//*[@class='item']/a/img/@srcset");

                                foreach (var aTag in aTags2)
                                {
                                    Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (loaded)));

                                    if (imageNumber == (theNumber + 1))
                                    {
                                        break;
                                    }

                                    if (backgroundWorker8.CancellationPending == false)
                                    {
                                        string pix = aTag.InnerHtml + aTag.Attributes["src"].Value;
                                        pix = pix.Replace("__340.jpg", "_960_720.jpg");

                                        if (pix != "/static/img/blank.gif")
                                        {
                                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + pix + Environment.NewLine)));//Update URL list with links

                                            try
                                            {
                                                using (WebClient webClient = new WebClient())
                                                {
                                                    var result = webClient.DownloadData(aTag.InnerHtml + aTag.Attributes["src"].Value);
                                                    var contentType = webClient.ResponseHeaders["Content-Type"];
                                                    Int64 bytes_total = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);
                                                    contentType = contentType.Replace("image/", "");

                                                    if (bytes_total > 10000)
                                                    {
                                                        try
                                                        {

                                                            if (textBox4.Text == "")
                                                            {
                                                                webClient.DownloadFile(pix, folder + "/" + keyword + imageNumber + "." + contentType);//Downloads the images
                                                            }
                                                            else if (textBox4.Text != "")
                                                            {
                                                                webClient.DownloadFile(pix, folder + "/" + textBox4.Text + noName + imageNumber + "." + contentType);//Downloads the images
                                                            }



                                                            imageNumber++;
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                                        }
                                                    }
                                                    


                                                }

                                            }
                                            catch (WebException ex)
                                            {
                                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                            }
                                        }


                                        progress++;

                                    }
                                    else if (backgroundWorker8.CancellationPending == true)
                                    {
                                        e.Cancel = true;
                                        break;
                                    }

                                }
                                page++;
                            }
                            catch (Exception ex)
                            {

                            }
                        }


                        //------------------------------------------Initialize content----------------------------------------------------------

                    }
                }
            }

           
        }

        private void button30_Click(object sender, EventArgs e)
        {
            backgroundWorker8.CancelAsync();
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker9_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                backgroundWorker9.WorkerReportsProgress = true; //Needed for progressbar
                int progress = 1;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";

                PhantomJSOptions options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:26.0) Gecko/20100101 Firefox/26.0");


                //---------------------------------------Initialize content--------------------------------------------------------

                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {

                    try
                    {
                        var url = Uri.EscapeUriString(keyword);

                        driver.Navigate().GoToUrl("https://www.pexels.com/search/" + url + "/");

                    }
                    catch (Exception ex)
                    {

                    }


                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    int loaded = 0;
                    string renderedContent = "";

                    for (int j = 0; j < 5; j++)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(1000);
                        }

                        for (int i = 0; i < 10; i++)
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(1000);
                        }

                        //-------------------------------------Initialize content----------------------------------------------------

                        //---------------------------------------Load content--------------------------------------------------------

                        try
                        {
                            renderedContent = driver.PageSource;
                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("/html/body/div/div/div/article/a/img/@data-pin-media");

                            if (loaded == aTags1.Count)
                            {
                                break;
                            }
                            if(theNumber < loaded)
                            {
                                break;
                            }


                            loaded = aTags1.Count;

                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links
                        }
                        catch (Exception ex)
                        {

                        }


                    }

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + theNumber + " images" + Environment.NewLine)));//Update URL list with links


                    //---------------------------------------Load content--------------------------------------------------------

                    //-------------------------------------Download content------------------------------------------------------

                    try
                    {
                        HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                        doc2.LoadHtml(renderedContent);
                        HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("/html/body/div/div/div/article/a/img/@data-pin-media");
                        int imageNumber = 1;
                        string url = "";
                        string picture = "";

                        foreach (var aTag in aTags2)
                        {

                            Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (loaded)));

                            if (imageNumber == (theNumber + 1))
                            {
                                break;
                            }

                            if (backgroundWorker9.CancellationPending == false)
                            {
                                picture = aTag.InnerHtml + aTag.Attributes["data-pin-media"].Value;
                                picture = picture.Replace("800", "1920");
                                picture = picture.Replace("1200", "1080");
                                picture = picture.Replace("compress", "compress.jpg");

                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + picture + Environment.NewLine))); //Update URL list with links

                                try
                                {
                                    using (WebClient webClient = new WebClient())
                                    {


                                        if (textBox4.Text == "")
                                        {
                                            webClient.DownloadFile(picture, folder + "/" + keyword + imageNumber + ".jpg"); //Downloads the images
                                        }
                                        else if (textBox4.Text != "")
                                        {
                                            webClient.DownloadFile(picture, folder + "/" + textBox4.Text + noName + imageNumber + ".jpg"); //Downloads the images
                                        }


                                    }
                                    imageNumber++;


                                }
                                catch (Exception ex)
                                {

                                }
                                progress++;
                                Invoke(new Action(() => backgroundWorker9.ReportProgress(progress)));

                              

                            }
                            else if (backgroundWorker9.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                    }

                    //-------------------------------------Download content------------------------------------------------------

                }
            }

           
        }

        private void backgroundWorker9_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void button34_Click(object sender, EventArgs e)
        {
            backgroundWorker9.CancelAsync();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            backgroundWorker10.RunWorkerAsync(2000); //Start workthread
        }

        private void backgroundWorker10_DoWork(object sender, DoWorkEventArgs e)
        {


            var files = Directory.GetFiles(textBox32.Text, "*.*", SearchOption.AllDirectories);
            int number = 1;
            List<string> imageFiles = new List<string>();
            foreach (string filename in files)
            {
                if (Regex.IsMatch(filename, @".jpg|.jpeg|.png|.gif$"))
                    imageFiles.Add(filename);
            }

            foreach (var images in imageFiles)
            {
                int one = 0;
                int two = 0;
                double three = 0;
                int four = 0;

                using (Image image = Image.FromFile(images))
                using (Image watermarkImage = Image.FromFile(textBox33.Text))
                using (Graphics imageGraphics = Graphics.FromImage(image))
                using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
                {

                    if (metroRadioButton7.Checked == true) // top left
                    {
                        one = 0;
                        two = 0;
                    }
                    else if (metroRadioButton9.Checked == true) // center
                    {
                        one = (image.Width / 2 - watermarkImage.Width / 2);
                        two = (image.Height / 2 - watermarkImage.Height / 2);
                    }
                    else if (metroRadioButton8.Checked == true) // bottom right
                    {
                        one = (image.Width - watermarkImage.Width);
                        two = (image.Height - watermarkImage.Height);
                    }
                    else if (metroRadioButton11.Checked == true) // Bottom left
                    {
                        three = image.Height * 0.80;
                        four = (int)three;
                        one = 0;
                        two = four;
                    }

                    int x = one;
                    int y = two;

                    Invoke(new Action(() => richTextBox2.Text = x + " " + y));

                    watermarkBrush.TranslateTransform(x, y);
                    imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width + 1, watermarkImage.Height)));
                    image.Save(textBox34.Text + "/Image" + number + ".jpg");
                }
                number++;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                textBox32.Text = fbd.SelectedPath;

            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                textBox33.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }

        }

        private void button40_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                textBox34.Text = fbd.SelectedPath;

            }
        }

        private void backgroundWorker10_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void backgroundWorker11_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                int progress = 1;
                int page = 1;
                int imageNumber = 1;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));
                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";


                //------------------------------------------Initialize content----------------------------------------------------------

                PhantomJSOptions options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:33.0) Gecko/20120101 Firefox/33.0");

                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {



                    for (int o = 0; o < 50; o++)
                    {

                        if (backgroundWorker11.CancellationPending == false)
                        {

                            try
                            {
                                var url = Uri.EscapeUriString(keyword);

                                driver.Navigate().GoToUrl("http://barnimages.com/page/" + page + "/?s=" + url + "&submit=Search");

                                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                                int loaded = 0;
                                string renderedContent = "";
                                renderedContent = driver.PageSource;
                                HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                                doc1.LoadHtml(renderedContent);
                                HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'inpost')]//img/@srcset");
                                loaded = aTags1.Count;

                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links



                                HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                                doc2.LoadHtml(renderedContent);
                                HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//*[contains(@class, 'inpost')]//img/@srcset");

                                foreach (var aTag in aTags2)
                                {

                                    Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (loaded)));

                                    if (imageNumber == (theNumber + 1))
                                    {
                                        break;
                                    }

                                    if (backgroundWorker11.CancellationPending == false)
                                    {
                                        string bingg = aTag.InnerHtml + aTag.Attributes["srcset"].Value;
                                        string bingreg = System.Text.RegularExpressions.Regex.Match(bingg, @"^(.*?)\,").Groups[1].Value;
                                        bingreg = bingreg.Replace("-768x512", "");


                                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + bingreg + Environment.NewLine)));//Update URL list with links

                                        try
                                        {
                                            using (WebClient webClient = new WebClient())
                                            {

                                                try
                                                {

                                                    if (textBox4.Text == "")
                                                    {
                                                        webClient.DownloadFile(bingreg, folder + "/" + keyword + imageNumber + ".jpg");//Downloads the images
                                                    }
                                                    else if (textBox4.Text != "")
                                                    {
                                                        webClient.DownloadFile(bingreg, folder + "/" + textBox4.Text + noName + imageNumber + ".jpg");//Downloads the images
                                                    }



                                                    imageNumber++;
                                                }
                                                catch (Exception ex)
                                                {
                                                    //Invoke(new Action(() => richTextBox7.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                                }

                                           

                                            }

                                        }
                                        catch (WebException ex)
                                        {
                                            // Invoke(new Action(() => richTextBox7.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                        }



                                        progress++;

                                    }
                                    else if (backgroundWorker11.CancellationPending == true)
                                    {
                                        e.Cancel = true;
                                        break;
                                    }

                                }
                                page++;
                            }
                            catch (Exception ex)
                            {

                            }
                        }


                        //------------------------------------------Initialize content----------------------------------------------------------
                        if (imageNumber == (theNumber + 1))
                        {
                            break;
                        }
                    }
                }
            }

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            backgroundWorker11.CancelAsync();

        }

        private void backgroundWorker11_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";
        }

        private void backgroundWorker12_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword in keywordList)
            {

                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading videos.." + Environment.NewLine)));//Update URL list with links
                backgroundWorker1.WorkerReportsProgress = true; //Needed for progressbar
                int progress = 1;
                int maxImg = 0;
                int loaded = 0;
                int max = 0;
                string renderedContent = "";
                string renderedContent2 = "";

                if (theNumber != 0)
                {
                    max = theNumber;
                }
                else if (theNumber == 0)
                {
                    max = 500;
                }

                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

              //  PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                //if (metroToggle2.Checked == true)
                //{
                //    service.Proxy = proxyIp;
                //    service.ProxyType = "http";
                //    service.ProxyAuthentication = auth;
                //}

                //service.HideCommandPromptWindow = true;
                //service.IgnoreSslErrors = true;
                //service.SslProtocol = "any";
                //var options = new PhantomJSOptions();
                //options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/25.0");


                //string options2 = "";

                //var service2 = ChromeDriverService.CreateDefaultService();

                //ChromeOptions option2 = new ChromeOptions();

                //service2.HideCommandPromptWindow = true;
                //option2.AddArgument("--headless");
                //option2.AddArgument("--window-size=1920,1080");
                //option2.AddArguments("--no-sandbox");

                //ChromeDriver driver = new ChromeDriver(service2, option2);

                var options = new ChromeOptions();
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();


                options.AddArguments("--headless", "window-size=1024,768", "--no-sandbox", "--disable-dev-shm-usage");

                service.HideCommandPromptWindow = true;

                //--------------------------------------Initialize page------------------------------------------------------
                using (ChromeDriver driver = new ChromeDriver(service, options))
                {
                    if (metroRadioButton1.Checked == true)
                    {
                        try
                        {
                            var url = Uri.EscapeUriString(keyword);

                            driver.Navigate().GoToUrl("https://www.instagram.com/" + url + "/");

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    else if (metroRadioButton2.Checked == true)
                    {
                        try
                        {
                            //driver.Navigate().GoToUrl("https://www.instagram.com/");

                            //driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[2]/p/a")).Click();

                            //IWebElement query = driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[1]/div/form/div[1]/input"));
                            //query.SendKeys(userName);

                            //IWebElement query2 = driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[1]/div/form/div[2]/input"));
                            //query2.SendKeys(userPassword);

                            //driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[1]/div/form/span[1]/button")).Click();

                            //Thread.Sleep(10000);




                            driver.Navigate().GoToUrl("https://www.instagram.com/explore/tags/" + keyword + "/");

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    else if (metroRadioButton4.Checked == true)
                    {
                        string userName = textBox52.Text;
                        string userPassword = textBox53.Text;

                        driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/");
                        Thread.Sleep(3000);

                        // driver.FindElement(By.XPath("(//*[contains(@class, '_5f5mN')])[1]")).Click();


                        //  driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);


                        // driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[2]/p/a")).Click();

                        // driver.FindElement(By.XPath("(//*[contains(@class, '_76e0u')]/a)[1]")).Click();


                        IWebElement query = driver.FindElement(By.XPath("(//*[contains(@class, 'f0n8F ')])[1]/input"));
                        query.SendKeys(userName);

                        IWebElement query2 = driver.FindElement(By.XPath("(//*[contains(@class, 'f0n8F ')])[2]/input"));
                        query2.SendKeys(userPassword);

                        driver.FindElement(By.XPath("(//*[contains(@class, '_5f5mN')])[1]")).Click();

                        Thread.Sleep(6000);

                        //  driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot2.png", ImageFormat.Png);


                        // driver.FindElement(By.XPath("//*[contains(@class, '_deuoy')]/button")).Click();

                        driver.Navigate().GoToUrl("https://www.instagram.com/" + userName + "/saved/");




                    }

                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                    try
                    {
                        driver.FindElement(By.XPath("//*[contains(@class, '_1cr2e')]")).Click();
                    }
                    catch (Exception ex)
                    {
                        //  Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links
                    }

                    try
                    {
                        driver.FindElement(By.XPath("//*[contains(@class, '_5f5mN')]")).Click();
                    }
                    catch (Exception ex)
                    {
                        //  Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links
                    }

                    // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot2.png", ImageFormat.Png);


                    //--------------------------------------Initialize page------------------------------------------------------

                    //---------------------------------------Load content--------------------------------------------------------
                    int imageNumber = 1;
                    int videos = 0;
                    int links = 0;

                 //   driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\aas.png", ImageFormat.Png);


                    do
                    {
                        try
                        {
                          //  driver.FindElement(By.XPath("//*[contains(@class, '_1cr2e')]")).Click();

                        }
                        catch (Exception li)
                        {
                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + li + Environment.NewLine)));//Update URL list with links

                        }

                        do
                        {
                            //for (int i = 0; i < 20; i++)
                            //{
                            //    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            //    Thread.Sleep(500);
                            //    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 700)");
                            //    Thread.Sleep(500);
                            //}
                            renderedContent = driver.PageSource;
                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags4 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'coreSpriteVideoIconLarge')]");
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'v1Nh3')]/a/@href");


                            try
                            {
                                if (videos == aTags1.Count)
                                {
                                    links = aTags1.Count;
                                    break;
                                }
                                videos = aTags1.Count;
                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": Videos Loaded: " + videos + Environment.NewLine)));//Update URL list with links

                                links = aTags1.Count;
                            }
                            catch (Exception lol)
                            {
                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + lol + Environment.NewLine)));//Update URL list with links

                            }



                        } while (videos < max);


                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " videos.." + Environment.NewLine)));//Update URL list with links

                     //   Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + driver.Url + Environment.NewLine)));//Update URL list with links

                       // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshotav.png", ImageFormat.Png);


                        try
                        {

                            //try
                            //{
                            //    driver.FindElement(By.XPath("//*[contains(@class, '_u3xlu')]")).Click();

                            //}
                            //catch (Exception d)
                            //{
                            //    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + d + Environment.NewLine)));//Update URL list with links
                            //}

                            //  renderedContent = driver.PageSource;
                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'v1Nh3')]/a/@href");
                            int i = 0;
                            string word = "";
                            string word2 = "";
                            int u = 0;
                            int desc = 0;
                            string replaceNewline;

                            if (aTags1 != null)
                            {

                            }

                            if (metroCheckBox2.Checked == true)
                            {
                                using (System.IO.StreamWriter file =
                                                                           new System.IO.StreamWriter(folder + "/Descs.csv", true))
                                {

                                    file.WriteLine("ImageNumber" + "," + "Descriptions");
                                }
                            }

                            foreach (var vid in aTags1)
                            {


                                //if (aTags3[u] != null)
                                //{

                                //word2 = aTags3[i].OuterHtml;
                                //Match m = Regex.Match(word2, @"\b(Video)\b");
                                //word = m.Value;

                                Invoke(new Action(() => metroLabel4.Text = "Working video: " + imageNumber + "/" + (loaded)));


                                if (backgroundWorker12.CancellationPending != true)
                                {

                                    driver.Navigate().GoToUrl("https://www.instagram.com" + vid.Attributes["href"].Value);
                                    Thread.Sleep(4000);

                                //    driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshotavb.png", ImageFormat.Png);


                                    renderedContent2 = driver.PageSource;
                                    HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                                    doc2.LoadHtml(renderedContent2);
                                    HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//video/@src");
                                    HtmlNodeCollection aTags21 = doc2.DocumentNode.SelectNodes("//*[contains(@class, 'Xl2Pu')]/li[1]");

                                    if (metroCheckBox2.Checked == true)
                                    {
                                        using (System.IO.StreamWriter file =
                                                                new System.IO.StreamWriter(folder + "/" + keyword + ".txt", true))
                                        {
                                            file.WriteLine(imageNumber + ". - " + aTags21[desc].InnerText + Environment.NewLine);
                                        }
                                        using (System.IO.StreamWriter file =
                                                                       new System.IO.StreamWriter(folder + "/Descs.csv", true))
                                        {
                                            replaceNewline = Regex.Replace(aTags21[desc].Attributes["alt"].Value, @"\r\n?|\n", "");

                                            file.WriteLine(imageNumber + "," + replaceNewline + Environment.NewLine);
                                        }


                                    }

                                    if (aTags2 != null)
                                    {


                                        foreach (var aTag in aTags2)
                                        {
                                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + aTag.InnerHtml + aTag.Attributes["src"].Value + Environment.NewLine)));//Update URL list with links
                                            using (WebClient webClient = new WebClient())
                                            {

                                                if (textBox4.Text == "")
                                                {
                                                    webClient.DownloadFile(aTag.InnerHtml + aTag.Attributes["src"].Value, folder + "/" + keyword + imageNumber + ".mp4");//Downloads the images
                                                }
                                                else if (textBox4.Text != "")
                                                {
                                                    webClient.DownloadFile(aTag.InnerHtml + aTag.Attributes["src"].Value, folder + "/" + textBox4.Text + noName + imageNumber + ".mp4");//Downloads the images
                                                }
                                                imageNumber++;
                                            }
                                        }
                                        i++;
                                        u++;
                                    }


                                    //}
                                    //i++;
                                    //u++;
                                }
                                //i++;
                                //u++;


                                if (max == (imageNumber - 1))
                                {
                                    break;
                                }
                            }

                            desc++;




                            loaded = aTags1.Count;
                            // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);
                        }
                        catch (Exception ex)
                        {
                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links
                                                                                                                                                      //// break;
                        }



                        // Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links


                    } while (1000 < max);
                }




                    


                
            }

           
        }

        private void button46_Click(object sender, EventArgs e)
        {
            backgroundWorker12.CancelAsync();

        }

        private void backgroundWorker12_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";
        }

        private void backgroundWorker13_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;

                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                int progress = 1;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));
                int index = 1;
                int imageNumber = 1;
                string amp = "";
                int max = 0;
                int count = 0;
                int loop = 0;

                if (theNumber != 0)
                {
                    max = theNumber;
                }
                else if (theNumber == 0)
                {
                    max = 500;
                }

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";


                //---------------------------------------Initialize content--------------------------------------------------------

                PhantomJSOptions options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");

                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {
                    var url = Uri.EscapeUriString(keyword);

                    driver.Navigate().GoToUrl(url);

                    Thread.Sleep(7000);

                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));

                    // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot2.png", ImageFormat.Png);

                    int loaded = 0;
                    string renderedContent = "";

                    if (theNumber == 0)
                    {
                        max = 500;

                    }
                    else if (theNumber != 0)
                    {
                        max = Convert.ToInt32(textBox24.Text);
                    }

                    loop = max;

                    do
                    {
                        try
                        {
                            for (int u = 0; u < 5; u++)
                            {

                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                                Thread.Sleep(1000);
                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 700)");
                                Thread.Sleep(1000);
                            }

                        }
                        catch (InvalidOperationException yt)
                        {
                            break;
                        }

                        //   driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);


                        renderedContent = driver.PageSource;

                        HtmlAgilityPack.HtmlDocument doc5 = new HtmlAgilityPack.HtmlDocument();
                        doc5.LoadHtml(renderedContent);
                        HtmlNodeCollection aTags6 = doc5.DocumentNode.SelectNodes("//*[contains(@class, '_2eea')]/a");

                        try
                        {
                            if (count == aTags6.Count)
                            {
                                break;
                            }

                            count = aTags6.Count;
                        }
                        catch (NullReferenceException uj)
                        {

                        }

                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + count + Environment.NewLine)));//Update URL list with links


                    } while (count < max);

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " images.." + Environment.NewLine)));//Update URL list with links


                    loop = count;

                    for (int j = 1; j < loop; j++)
                    {

                        try
                        {
                            driver.FindElement(By.XPath("//*[contains(@class, '_2eea')][" + j + "]/a")).Click();
                        }
                        catch (Exception ex)
                        {

                        }



                        try
                        {
                            if (renderedContent == driver.PageSource)
                            {

                            }
                            else if (renderedContent != driver.PageSource)
                            {
                                renderedContent = driver.PageSource;

                                HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                                doc1.LoadHtml(renderedContent);
                                HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'spotlight')]/@src");

                                driver.FindElement(By.XPath("//*[@id='photos_snowlift']/div[2]/div/a/i")).Click();


                                foreach (var aTag in aTags1)
                                {
                                    if (imageNumber == (max + 1))
                                    {
                                        break;
                                    }
                                    Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (max)));


                                    amp = aTag.Attributes["src"].Value;
                                    amp = amp.Replace("amp;", "");

                                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Image loaded: " + amp + Environment.NewLine)));//Update URL list with links

                                    try
                                    {


                                        if (backgroundWorker13.CancellationPending == false)
                                        {
                                            try
                                            {
                                                using (WebClient webClient = new WebClient())
                                                {

                                                    try
                                                    {

                                                        if (textBox4.Text == "")
                                                        {

                                                            webClient.DownloadFile(amp, folder + "/" + "image" + imageNumber + ".jpg");//Downloads the images
                                                        }
                                                        else if (textBox4.Text != "")
                                                        {
                                                            webClient.DownloadFile(amp, folder + "/" + textBox4.Text + imageNumber + ".jpg");//Downloads the images
                                                        }


                                                       

                                                        imageNumber++;
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                                    }
                                                }

                                            }
                                            catch (WebException ex)
                                            {
                                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                            }
                                            progress++;
                                           // Invoke(new Action(() => backgroundWorker4.ReportProgress(progress)));
                                        }
                                        else if (backgroundWorker13.CancellationPending == true)
                                        {
                                            e.Cancel = true;
                                            break;
                                        }



                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                }
                            }


                        }
                        catch (Exception ex)
                        {

                        }

                        if (imageNumber == (max + 1))
                        {
                            break;
                        }
                    }

                    //---------------------------------------Initialize content--------------------------------------------------------



                    //-----------------------------------------Load content------------------------------------------------------------


                }
            }

            
        }

        private void backgroundWorker13_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";

        }

        private void button50_Click(object sender, EventArgs e)
        {
            backgroundWorker13.CancelAsync();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            backgroundWorker14.RunWorkerAsync(2000); //Start workthread
        }

        private void backgroundWorker14_DoWork(object sender, DoWorkEventArgs e)
        {
            

            Invoke(new Action(() => richTextBox13.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " + "Testing proxy.." + Environment.NewLine)));
            string proxy = metroTextBox1.Text;
            string renderedContent = "";
            string IP = "";

            PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

            string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
            string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

            if (metroToggle2.Checked == true)
            {
                service.Proxy = proxyIp;
                service.ProxyType = "http";
                service.ProxyAuthentication = auth;
            }

            service.HideCommandPromptWindow = true;
            service.IgnoreSslErrors = true;
            service.SslProtocol = "any";
            var options = new PhantomJSOptions();
            options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/30.0.1599.17 Safari/537.36");

            using (IWebDriver driver = new PhantomJSDriver(service, options))
            {

                driver.Navigate().GoToUrl("https://www.ipchicken.com/");

                Thread.Sleep(10000);

                renderedContent = driver.PageSource;

                HtmlAgilityPack.HtmlDocument doc4 = new HtmlAgilityPack.HtmlDocument();
                doc4.LoadHtml(renderedContent);
                HtmlNodeCollection aTags4 = doc4.DocumentNode.SelectNodes("(/html/body/table[2]/tbody/tr/td[3]/p[2]/font/b/text())[1]");

                IP = aTags4[0].InnerText.Trim();

                if (aTags4 != null)
                {
                    Invoke(new Action(() => richTextBox13.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " + "Returned IP: " + IP + Environment.NewLine)));
                }
                else if (aTags4 == null)
                {
                    Invoke(new Action(() => richTextBox13.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " + "No response from proxy." + Environment.NewLine)));
                }

            }


        }

        private void backgroundWorker15_DoWork(object sender, DoWorkEventArgs e)
        {
            string userName = textBox52.Text;
            string userPassword = textBox53.Text;

            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }

            if (metroRadioButton4.Checked == true)
            {
                keywordList.Add("post");
            }

            int noName = 0;
            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                backgroundWorker15.WorkerReportsProgress = true; //Needed for progressbar
                int progress = 1;
                int maxImg = 0;
                int loaded = 0;
                string renderedContent = "";
                string renderedContent2 = "";
                int max = 0;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                try
                {
                    var options = new ChromeOptions();
                    ChromeDriverService service = ChromeDriverService.CreateDefaultService();


                    options.AddArguments("--headless", "window-size=1024,768", "--no-sandbox", "--disable-dev-shm-usage");

                    service.HideCommandPromptWindow = true;






                    //PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();



                    //string proxy = metroTextBox1.Text;

                    //string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                    //string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;
                    //if (metroToggle2.Checked == true)
                    //{
                    //    service.Proxy = proxyIp;
                    //    service.ProxyType = "http";
                    //    service.ProxyAuthentication = auth;
                    //}



                    //service.HideCommandPromptWindow = true;
                    //service.IgnoreSslErrors = true;
                    //service.SslProtocol = "any";
                    //var options = new PhantomJSOptions();
                    //options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (iPhone; CPU iPhone OS 6_0 like Mac OS X) AppleWebKit/536.26 (KHTML, like Gecko) Version/6.0 Mobile/10A5376e Safari/8536.25");


                    //--------------------------------------Initialize page------------------------------------------------------


                    using (ChromeDriver driver = new ChromeDriver(service, options))
                    {


                        driver.Manage().Window.Size = new Size(3000, 20000);

                        if (metroRadioButton1.Checked == true)
                        {
                            try
                            {
                                var url = Uri.EscapeUriString(keyword);

                                driver.Navigate().GoToUrl("https://www.instagram.com/" + url + "/");

                            }
                            catch (Exception ex)
                            {
                                Invoke(new Action(() => richTextBox2.AppendText(ex + Environment.NewLine)));//Update URL list with links

                            }
                        }
                        else if (metroRadioButton2.Checked == true)
                        {
                            try
                            {
                                //driver.Navigate().GoToUrl("https://www.instagram.com/");

                                //driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[2]/p/a")).Click();

                                //IWebElement query = driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[1]/div/form/div[1]/input"));
                                //query.SendKeys(userName);

                                //IWebElement query2 = driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[1]/div/form/div[2]/input"));
                                //query2.SendKeys(userPassword);

                                //driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[1]/div/form/span[1]/button")).Click();

                                //Thread.Sleep(10000);


                                var url = Uri.EscapeUriString(keyword);


                                driver.Navigate().GoToUrl("https://www.instagram.com/explore/tags/" + url + "/");

                            }
                            catch (Exception ex)
                            {
                           //     Invoke(new Action(() => richTextBox2.AppendText(ex + Environment.NewLine)));//Update URL list with links

                            }

                        }
                        else if (metroRadioButton4.Checked == true)
                        {
                            driver.Navigate().GoToUrl("https://www.instagram.com/");

                            // driver.FindElement(By.XPath("//*[@id='react-root']/section/main/article/div[2]/div[2]/p/a")).Click();

                            driver.FindElement(By.XPath("(//*[contains(@class, '_76e0u')]/a)[1]")).Click();


                            IWebElement query = driver.FindElement(By.XPath("(//*[contains(@class, '_sjplo')])[1]/input"));
                            query.SendKeys(userName);

                            IWebElement query2 = driver.FindElement(By.XPath("(//*[contains(@class, '_sjplo')])[2]/input"));
                            query2.SendKeys(userPassword);

                            driver.FindElement(By.XPath("(//*[contains(@class, '_qv64e')])[1]")).Click();

                            Thread.Sleep(10000);

                            driver.FindElement(By.XPath("//*[contains(@class, '_deuoy')]/button")).Click();



                        }

                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                        try
                        {


                            driver.FindElement(By.XPath("//*[contains(@class, 'coreSpriteDesktopNavProfile')]")).Click();

                            Thread.Sleep(5000);
                            driver.FindElement(By.XPath("(//*[contains(@class, '_2e96w')]/a)[2]")).Click();

                        }
                        catch (Exception ex)
                        {
                         //   Invoke(new Action(() => richTextBox2.AppendText(ex + Environment.NewLine)));//Update URL list with links
                        }

                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(120));

                        Thread.Sleep(5000);
                        //  driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot11.png", ImageFormat.Png);


                        //try
                        //{
                        //    driver.FindElement(By.XPath("//*[contains(@class, '_1cr2e')]")).Click();
                        //}
                        //catch (Exception ex)
                        //{
                        //    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Page not loaded properly, please try again" + Environment.NewLine)));//Update URL list with links
                        //}


                        //--------------------------------------Initialize page------------------------------------------------------

                        //---------------------------------------Load content--------------------------------------------------------
                        int imageNumber = 1;
                        int videos = 0;

                        if (theNumber == 0)
                        {
                            max = 10000;
                        }
                        else if (theNumber != 0)
                        {
                            max = Convert.ToInt32(textBox24.Text);
                        }

                        //   driver.FindElement(By.XPath("//*[contains(@class, '_1cr2e')]")).Click();

                        do
                        {
                            for (int u = 0; u < 10; u++)
                            {
                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                                Thread.Sleep(500);
                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 700)");
                                Thread.Sleep(500);
                            }
                            renderedContent = renderedContent + driver.PageSource;
                            HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                            doc2.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags4 = doc2.DocumentNode.SelectNodes("//*[contains(@class, 'v1Nh3 kIKUG  _bz0w')]/a/@href");

                            //   driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);




                            try
                            {
                                if (videos == aTags4.Count)
                                {
                                    break;
                                }

                                videos = aTags4.Count;
                            }
                            catch (Exception g)
                            {

                                //Invoke(new Action(() => richTextBox2.AppendText(g + Environment.NewLine)));//Update URL list with links

                            }
                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": Images Loaded: " + videos + Environment.NewLine)));//Update URL list with links


                        } while (videos < max);

                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " images.." + Environment.NewLine)));//Update URL list with links


                        try
                        {
                            //  renderedContent = driver.PageSource;
                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'v1Nh3 kIKUG  _bz0w')]/a/@href");
                            int i = 0;
                            string desc = "";
                            string userNames = "";
                            if (metroCheckBox2.Checked == true)
                            {
                                using (System.IO.StreamWriter file =
                                                                           new System.IO.StreamWriter(folder + "/Descs.csv", true))
                                {

                                    file.WriteLine("ImageNumber" + "," + "Descriptions");
                                }
                            }

                            // Invoke(new Action(() => richTextBox14.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": Images Loaded: " + aTags1.Count + Environment.NewLine)));//Update URL list with links

                            foreach (var vid in aTags1)
                            {
                                int lol = 0;

                                if (imageNumber > max)
                                {
                                    break;
                                }
                                Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (max)));


                                if (backgroundWorker15.CancellationPending != true)
                                {

                                    driver.Navigate().GoToUrl("https://www.instagram.com" + vid.Attributes["href"].Value);
                                    Thread.Sleep(4000);



                                    //  driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot44" + lol +".png", ImageFormat.Png);
                                    lol++;

                                    string repText = "";
                                    renderedContent2 = driver.PageSource;
                                    HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                                    doc2.LoadHtml(renderedContent2);
                                    HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//*[contains(@class, 'KL4Bh')]/img/@src");
                                    HtmlNodeCollection aTags3 = doc2.DocumentNode.SelectNodes("(//*[contains(@class, 'C4VMK')]/span)[1]");
                                    HtmlNodeCollection aTags5 = doc2.DocumentNode.SelectNodes("//*[contains(@class, '_eeohz')]/a/@title");
                                    string replaceNewline = "";

                                    repText = System.Text.RegularExpressions.Regex.Match(renderedContent2, @"936},{src:(.*),config_width:1080").Groups[1].Value;


                                    //*[contains(@class, '_0')]/div/div[2]/div/div/div/div/div[3]/div/form


                                    if (aTags2 != null)
                                    {
                                        foreach (var aTag in aTags2)
                                        {

                                            if (aTags3 == null)
                                            {
                                                desc = "No description";
                                            }
                                            else if (aTags3 != null)
                                            {
                                                desc = aTags3[0].InnerText;
                                            }
                                            desc = Regex.Replace(desc, @"\<.*?\>", "");

                                            if (aTags5 != null)
                                            {
                                                userNames = aTags5[0].Attributes["title"].Value;
                                            }

                                            try
                                            {

                                                using (WebClient webClient = new WebClient())
                                                {

                                                    if (textBox4.Text == "")
                                                    {
                                                        webClient.DownloadFile(repText, folder + "/" + keyword + imageNumber + ".jpg");//Downloads the images

                                                        if (metroCheckBox2.Checked == true)
                                                        {


                                                            using (System.IO.StreamWriter file =
                                                                        new System.IO.StreamWriter(folder + "/" + keyword + ".txt", true))
                                                            {

                                                                file.WriteLine(imageNumber + ". " + userNames + Environment.NewLine + desc + Environment.NewLine);
                                                            }
                                                            using (System.IO.StreamWriter file =
                                                                           new System.IO.StreamWriter(folder + "/Descs.csv", true))
                                                            {
                                                                replaceNewline = Regex.Replace(desc, @"\r\n?|\n", "");
                                                                replaceNewline = Regex.Replace(replaceNewline, @",", ".");


                                                                file.WriteLine(imageNumber + "," + replaceNewline + Environment.NewLine);
                                                            }
                                                        }

                                                    }
                                                    else if (textBox4.Text != "")
                                                    {

                                                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + aTag.InnerHtml + aTag.Attributes["src"].Value + Environment.NewLine)));//Update URL list with links


                                                        webClient.DownloadFile(aTag.InnerHtml + aTag.Attributes["src"].Value, folder + "/" + textBox4.Text + noName + imageNumber + ".jpg");//Downloads the images

                                                        if (metroCheckBox2.Checked == true)
                                                        {
                                                            using (System.IO.StreamWriter file =
                                                                        new System.IO.StreamWriter(folder + "/Descs.txt", true))
                                                            {
                                                                file.WriteLine(imageNumber + ". " + userNames + Environment.NewLine + desc + Environment.NewLine);
                                                            }
                                                            using (System.IO.StreamWriter file =
                                                                           new System.IO.StreamWriter(folder + "/Descs.csv", true))
                                                            {
                                                                replaceNewline = Regex.Replace(desc, @"\r\n?|\n", "");

                                                                file.WriteLine(imageNumber + "," + replaceNewline + Environment.NewLine);
                                                            }
                                                        }
                                                    }


                                                    imageNumber++;
                                                }
                                            }

                                            catch (NullReferenceException eec)
                                            {
                                                //using (System.IO.StreamWriter file =
                                                //                       new System.IO.StreamWriter(textBox47.Text + "/Descs.txt", true))
                                                //{
                                                //    file.WriteLine(imageNumber + ". - Unavailable" + Environment.NewLine);
                                                //}
                                                imageNumber++;
                                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + eec + Environment.NewLine)));//Update URL list with links

                                            }
                                        }
                                    }





                                }
                                i++;
                            }



                            max = 1000;



                            loaded = aTags1.Count;
                            // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);
                        }
                        catch (Exception ex)
                        {
                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Page not loaded properly, please try again" + Environment.NewLine)));//Update URL list with links
                        }
                    }
                }
                catch (Exception lol)
                {
               //     Invoke(new Action(() => richTextBox2.AppendText(lol + Environment.NewLine)));//Update URL list with links

                }

               

                    



                  //  Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links



                
            }




        }

        private void button55_Click(object sender, EventArgs e)
        {
            backgroundWorker15.CancelAsync();
        }

        private void backgroundWorker15_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";
        }

        private void backgroundWorker16_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }

            int noName = 0;


            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                string userName = textBox52.Text;
                string userPassword = textBox53.Text;
                int progress = 1;
                int maxImg = 0;
                int loaded = 0;
                string renderedContent = "";
                string renderedContent2 = "";
                int max = 0;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";
                var options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");

            //    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "dd" + Environment.NewLine)));//Update URL list with links

                var service2 = ChromeDriverService.CreateDefaultService();

                ChromeOptions option2 = new ChromeOptions();

                service2.HideCommandPromptWindow = true;
                option2.AddArgument("--headless");
                option2.AddArgument("--window-size=1920,1080");
                option2.AddArguments("--no-sandbox");

                //--------------------------------------Initialize page------------------------------------------------------


                using (ChromeDriver driver = new ChromeDriver(service2, option2))
                {


                    try
                    {
                        driver.Navigate().GoToUrl("https://www.pinterest.se/login/");
                        driver.Manage().Window.Size = new Size(1024, 10000);

                    }
                    catch (Exception ex)
                    {

                    }

                    Thread.Sleep(2000);
                  //  driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\a\aaaaaascreenshot.png", ImageFormat.Png);


                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(120));

                    try
                    {

                      //      driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\aaaaaascreenshot.png", ImageFormat.Png);


                        IWebElement query = driver.FindElement(By.XPath("//*[contains(@type, 'email')]"));
                        query.SendKeys(userName);

                        //   driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenssdfsdhot.png", ImageFormat.Png);


                        IWebElement query2 = driver.FindElement(By.XPath("//*[contains(@type, 'password')]"));
                        query2.SendKeys(userPassword);

                        //  driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screensdfsdshot.png", ImageFormat.Png);


                        driver.FindElement(By.XPath("//*[contains(@type, 'submit')]")).Click();


                        Thread.Sleep(5000);

                    //      driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\a\abc.png", ImageFormat.Png);


                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": You are logged in.." + Environment.NewLine)));//Update URL list with links


                        if (metroCheckBox1.Checked == true)
                        {
                            try
                            {
                                driver.Navigate().GoToUrl("https://www.pinterest.se/categories/popular/");

                            }
                            catch (Exception rr)
                            {
                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + rr + Environment.NewLine)));//Update URL list with links

                            }
                        }
                        else if (metroCheckBox1.Checked == false)
                        {
                            var url = Uri.EscapeUriString(keyword);
                            Regex rgx = new Regex(@"https:");

                            if(url.Contains(" "))
                            {
                                url.Replace(" ", "%20");
                            }

                            if (rgx.IsMatch(url) == true)
                            {
                                driver.Navigate().GoToUrl(url);
                            }
                            else if (rgx.IsMatch(url) == false)
                            {
                                driver.Navigate().GoToUrl("https://www.pinterest.se/search/pins/?q=" + url + "&rs=typed&term_meta[]=" + url + "%7Ctyped");
                            }

                        }

                    }
                    catch (Exception eg)
                    {
                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + eg + Environment.NewLine)));//Update URL list with links
                    }


                    //--------------------------------------Initialize page------------------------------------------------------

                    //---------------------------------------Load content--------------------------------------------------------
                    int imageNumber = 0;
                    int videos = 0;

                    if (theNumber == 0)
                    {
                        max = 10000;
                    }
                    else if (theNumber != 0)
                    {
                        max = Convert.ToInt32(textBox24.Text);
                    }

                    HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                    HtmlNodeCollection aTags4 = doc1.DocumentNode.SelectNodes("//*[contains(@class, '_4f _h _z7 _4q')]/img/@src");
                    List<string> withDupes = new List<string>();
                    List<string> noDupes = new List<string>();

                    do
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(500);
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 700)");
                            Thread.Sleep(500);
                        }
                        renderedContent = renderedContent + driver.PageSource;
                        doc1.LoadHtml(renderedContent);
                        aTags4 = doc1.DocumentNode.SelectNodes("//*[contains(@class, '_4f _h _xu _4q')]/img/@src");

                              //        driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot444.png", ImageFormat.Png);

                        if (aTags4 != null)
                        {
                            foreach (var tag in aTags4)
                            {
                                withDupes.Add(tag.Attributes["src"].Value);
                            }

                            noDupes = withDupes.Distinct().ToList();

                            if (videos == noDupes.Count)
                            {
                                break;
                            }
                            videos = noDupes.Count;
                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": Images Loaded: " + videos + Environment.NewLine)));//Update URL list with links
                        }

                       


                    } while (videos < max);

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " images.." + Environment.NewLine)));//Update URL list with links


                    try
                    {
                        //HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                        //doc1.LoadHtml(renderedContent);
                        //HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, '_mh _28 _3x _2k')]/@src");
                        int i = 0;

                        string original = "";
                        List<string> originals = new List<string>();
                        bool notD = false;

                        foreach (var aTag in noDupes)
                        {

                           
                            if (imageNumber == (max + 1))
                            {
                                break;
                            }
                            Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (max)));

                            original = aTag;
                            original = original.Replace("236x","originals");

                            if (backgroundWorker16.CancellationPending != true)
                            {

                                //driver.Navigate().GoToUrl("https://www.pinterest.com" + vid.Attributes["href"].Value);
                                //Thread.Sleep(4000);


                                //renderedContent2 = driver.PageSource;
                                //HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                                //doc2.LoadHtml(renderedContent2);
                                //HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("(//*[contains(@class, '_0 _25 _2p _2i')]/img/@src)[2]");

                                //driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);



                                if (aTags4 != null && notD == false)
                                {
                                    //foreach (var aTag in aTags1)
                                    //{

                                        try
                                        {

                                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + original + Environment.NewLine)));//Update URL list with links
                                            using (WebClient webClient = new WebClient())
                                            {

                                                if (textBox4.Text == "")
                                                {
                                                    webClient.DownloadFile(original, folder + "/" + "image" + imageNumber + ".jpg");//Downloads the images



                                                }
                                                else if (textBox4.Text != "")
                                                {
                                                    webClient.DownloadFile(original, folder + "/" + textBox4.Text + noName + imageNumber + ".jpg");//Downloads the images


                                                }
                                                

                                                imageNumber++;
                                            }
                                        }

                                        catch (Exception eec)
                                        {
                                            //using (System.IO.StreamWriter file =
                                            //                       new System.IO.StreamWriter(textBox47.Text + "/Descs.txt", true))
                                            //{
                                            //    file.WriteLine(imageNumber + ". - Unavailable" + Environment.NewLine);
                                            //}
                                            //imageNumber++;

                                        }
                                    //}
                                }





                            }
                            i++;
                        }



                        max = 1000;



                        loaded = aTags4.Count;
                        // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links
                    }



                }
            }

            
        }

        private void button58_Click(object sender, EventArgs e)
        {
            backgroundWorker16.CancelAsync();

        }

        private void backgroundWorker17_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images.." + Environment.NewLine)));//Update URL list with links
                                                                                                                                                                                                   //backgroundWorker1.WorkerReportsProgress = true; //Needed for progressbar
                                                                                                                                                                                                   //metroProgressBar1.Value = 0;
                int progress = 1;
                int maxImg = 0;
                int loaded = 0;
                string renderedContent = "";
                int max = 0;
                string userName = textBox52.Text;
                string userPassword = textBox53.Text;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";
                var options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_3) AppleWebKit/537.75.14 (KHTML, like Gecko) Version/7.0.3 Safari/7046A194A");


                //--------------------------------------Initialize page------------------------------------------------------


                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {

                    //try
                    //{
                    //    driver.Navigate().GoToUrl("http://weheartit.com/login");
                    //    driver.Manage().Window.Size = new Size(1024, 2000);
                    //}
                    //catch (Exception ex)
                    //{

                    //}


                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(120));

                    //try
                    //{
                    //    //IWebElement query = driver.FindElement(By.XPath("(//*[contains(@class, 'new_user')]/input)[1]"));
                    //    //query.SendKeys(userName);

                    //    //IWebElement query2 = driver.FindElement(By.XPath("(//*[contains(@class, 'new_user')]/input)[2]"));
                    //    //query2.SendKeys(userPassword);

                    //    //driver.FindElement(By.XPath("(//*[contains(@class, 'new_user')]/input)[3]")).Click();

                    //    var url = Uri.EscapeUriString(keyword);

                    //    driver.Navigate().GoToUrl("http://weheartit.com/search/entries?utf8=%E2%9C%93&ac=0&query=" + url);

                    //   // driver.FindElement(By.XPath("//*[contains(@class, 'grid-flex-justified')]/a")).Click();

                    //}
                    //catch (Exception eg)
                    //{
                    //   // Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": Failed to login, check you account info" + Environment.NewLine)));//Update URL list with links
                    //}




                    //--------------------------------------Initialize page------------------------------------------------------

                    //---------------------------------------Load content--------------------------------------------------------
                    int loop = 1;
                    do
                    {
                        var url = Uri.EscapeUriString(keyword);
                        driver.Navigate().GoToUrl("http://weheartit.com/search/entries?utf8=%E2%9C%93&ac=0&query=" + url + "&page=" + loop);
                        loop++;

                        for (int i = 0; i < 10; i++)
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(500);
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 700)");
                            Thread.Sleep(500);
                        }


                        try
                        {
                            renderedContent += driver.PageSource;
                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'entry-thumbnail')]/@src");

                            if (loaded == aTags1.Count)
                            {
                                break;
                            }

                            if (theNumber != 0)
                            {
                                maxImg = int.Parse(textBox24.Text);
                                max = maxImg;
                            }
                            else if (theNumber == 0)
                            {
                                max = 10000;
                            }


                            loaded = aTags1.Count;
                            // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);
                        }
                        catch (Exception ex)
                        {
                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Page not loaded properly, please try again" + Environment.NewLine)));//Update URL list with links
                            break;
                        }



                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links


                    } while (loaded < max);

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " images.." + Environment.NewLine)));//Update URL list with links


                    //---------------------------------------Load content--------------------------------------------------------

                    //-------------------------------------Download content------------------------------------------------------

                    try
                    {

                        HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                        doc2.LoadHtml(renderedContent);
                        int desc = 0;
                        string result = "";
                        HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//*[contains(@class, 'entry-thumbnail')]/@src");

                        int imageNumber = 1;

                        foreach (var aTag in aTags2)
                        {
                            if (imageNumber == (max + 1))
                            {
                                break;
                            }
                            Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (max)));


                            if (backgroundWorker16.CancellationPending == false)
                            {
                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + aTag.InnerHtml + aTag.Attributes["src"].Value + Environment.NewLine)));//Update URL list with links

                                try
                                {
                                    using (WebClient webClient = new WebClient())
                                    {

                                        result = aTag.Attributes["src"].Value;
                                        result = Regex.Replace(result, "superthumb", "large");


                                        if (textBox4.Text == "")
                                        {
                                            webClient.DownloadFile(result, folder + "/" + keyword + imageNumber + ".jpg");//Downloads the images


                                        }
                                        else if (textBox4.Text != "")
                                        {
                                            webClient.DownloadFile(result, folder + "/" + textBox4.Text + noName + imageNumber + ".jpg");//Downloads the images

                                        }
                                    }

                                }
                                catch (Exception ex)
                                {

                                }

                               

                                progress++;
                                imageNumber++;
                                Invoke(new Action(() => backgroundWorker1.ReportProgress(progress)));
                            }
                            else if (backgroundWorker1.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }

                            //-------------------------------------Download content------------------------------------------------------

                        }
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }

           
        }

        private void button63_Click(object sender, EventArgs e)
        {
            backgroundWorker17.CancelAsync();

        }

        private void backgroundWorker16_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";

        }

        private void backgroundWorker17_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";

        }

        private void backgroundWorker18_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                backgroundWorker18.WorkerReportsProgress = true; //Needed for progressbar
                int progress = 1;
                int maxImg = 0;
                int loaded = 0;
                string renderedContent = "";
                int max = 0;
                string bigImg = "";
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";
                var options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_3) AppleWebKit/537.75.14 (KHTML, like Gecko) Version/7.0.3 Safari/7046A194A");


                //--------------------------------------Initialize page------------------------------------------------------


                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));


                    try
                    {
                        var url = Uri.EscapeUriString(keyword);

                        driver.Navigate().GoToUrl("https://alpha.wallhaven.cc/search?q=" + url + "&categories=111&purity=100&sorting=favorites&order=desc");

                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Page not loaded properly, please try again" + Environment.NewLine)));//Update URL list with links
                    }





                    //--------------------------------------Initialize page------------------------------------------------------

                    //---------------------------------------Load content--------------------------------------------------------

                    do
                    {

                        for (int i = 0; i < 20; i++)
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(500);
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 700)");
                            Thread.Sleep(500);
                        }

                        try
                        {
                            renderedContent = driver.PageSource;
                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'loaded')]/@src");

                            if (loaded == aTags1.Count)
                            {
                                break;
                            }

                            if (theNumber != 0)
                            {
                                maxImg = int.Parse(textBox24.Text);
                                max = maxImg;
                            }
                            else if (theNumber == 0)
                            {
                                max = 5000;
                            }


                            loaded = aTags1.Count;
                            // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);
                        }
                        catch (Exception ex)
                        {
                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Page not loaded properly, please try again" + Environment.NewLine)));//Update URL list with links
                            break;
                        }



                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links


                    } while (loaded < max);

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " images.." + Environment.NewLine)));//Update URL list with links


                    //---------------------------------------Load content--------------------------------------------------------

                    //-------------------------------------Download content------------------------------------------------------

                    try
                    {

                        HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                        doc2.LoadHtml(renderedContent);
                        int desc = 0;
                        HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//*[contains(@class, 'loaded')]/@src");

                        int imageNumber = 1;

                        foreach (var aTag in aTags2)
                        {
                            if (imageNumber == (max + 1))
                            {
                                break;
                            }
                            Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (max)));


                            bigImg = aTag.Attributes["src"].Value;
                            bigImg = bigImg.Replace("alpha", "wallpapers");
                            bigImg = bigImg.Replace("thumb/small", "full");
                            bigImg = bigImg.Replace("th-", "wallhaven-");

                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + bigImg + Environment.NewLine)));//Update URL list with links


                            if (backgroundWorker18.CancellationPending == false)
                            {

                                try
                                {
                                    using (WebClient webClient = new WebClient())
                                    {

                                        var result = webClient.DownloadData(bigImg);
                                        var contentType = webClient.ResponseHeaders["Content-Type"];
                                        contentType = contentType.Replace("image/", "");

                                        if (textBox4.Text == "")
                                        {
                                            webClient.DownloadFile(bigImg, folder + "/" + keyword + noName + imageNumber + "." + contentType);//Downloads the images

                                        }
                                        else if (textBox4.Text != "")
                                        {
                                            webClient.DownloadFile(bigImg, folder + "/" + textBox4.Text + imageNumber + "." + contentType);//Downloads the images

                                        }
                                        desc++;
                                    }

                                }
                                catch (Exception ex)
                                {
                                     Invoke(new Action(() => richTextBox1.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links

                                }

                               

                                progress++;
                                imageNumber++;
                                Invoke(new Action(() => backgroundWorker18.ReportProgress(progress)));
                            }
                            else if (backgroundWorker18.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }

                            //-------------------------------------Download content------------------------------------------------------

                        }
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }

          
        }

        private void backgroundWorker18_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";
        }

        private void button67_Click(object sender, EventArgs e)
        {
            backgroundWorker18.CancelAsync();
        }

        private void backgroundWorker18_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Refresh();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            backgroundWorker16.RunWorkerAsync(2000);

        }

        private void backgroundWorker19_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                backgroundWorker19.WorkerReportsProgress = true; //Needed for progressbar
                int progress = 1;
                int maxImg = 0;
                int loaded = 0;
                string renderedContent = "";
                int max = 0;
                string bigImg = "";
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));
                int page = 2;
                List<string> linkList = new List<string>();

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }
                string widwall = "http://wallpaperswide.com/download";

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";
                var options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_3) AppleWebKit/537.75.14 (KHTML, like Gecko) Version/7.0.3 Safari/7046A194A");


                //--------------------------------------Initialize page------------------------------------------------------


                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));


                    try
                    {
                        var url = Uri.EscapeUriString(keyword);

                        driver.Navigate().GoToUrl("http://wallpaperswide.com/search.html?q=" + url);

                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Page not loaded properly, please try again" + Environment.NewLine)));//Update URL list with links
                    }





                    //--------------------------------------Initialize page------------------------------------------------------

                    //---------------------------------------Load content--------------------------------------------------------

                    do
                    {

                        try
                        {
                            IWebElement query = driver.FindElement(By.XPath("(//*[contains(@class, 'input-text')])[1]"));
                            query.SendKeys("k");
                        }
                        catch (Exception yu)
                        {

                        }

                        try
                        {
                            renderedContent = driver.PageSource;
                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'thumb')]/a/@href");



                            if (theNumber != 0)
                            {
                                maxImg = int.Parse(textBox24.Text);
                                max = maxImg;
                            }
                            else if (theNumber == 0)
                            {
                                max = 5000;
                            }

                            foreach (var atag in aTags1)
                            {
                                bigImg = atag.Attributes["href"].Value;
                                bigImg = bigImg.Replace("s.html", "-1920x1080");
                                widwall = widwall + bigImg;


                                linkList.Add(widwall);

                                bigImg = "";
                                widwall = "http://wallpaperswide.com/download";
                            }

                            //   loaded = loaded + aTags1.Count;
                            // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);
                        }
                        catch (Exception ex)
                        {
                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Page not loaded properly, please try again" + Environment.NewLine)));//Update URL list with links
                            break;
                        }



                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + linkList.Count + Environment.NewLine)));//Update URL list with links


                        try
                        {
                            driver.Navigate().GoToUrl("http://wallpaperswide.com/search/page/" + page + "?q=" + keyword);
                        }
                        catch (Exception fr)
                        {

                        }

                        //   driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);


                        page++;


                    } while (linkList.Count < max);

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " images.." + Environment.NewLine)));//Update URL list with links


                    //---------------------------------------Load content--------------------------------------------------------

                    //-------------------------------------Download content------------------------------------------------------

                    try
                    {

                        int imageNumber = 1;

                        foreach (var aTag in linkList)
                        {

                            if (imageNumber == (max + 1))
                            {
                                break;
                            }
                            Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (max)));

                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + aTag + Environment.NewLine)));//Update URL list with links


                            if (backgroundWorker19.CancellationPending == false)
                            {

                                try
                                {
                                    using (WebClient webClient = new WebClient())
                                    {

                                        if (textBox4.Text == "")
                                        {
                                            webClient.DownloadFile(aTag, folder + "/" + keyword + imageNumber + ".jpg");//Downloads the images

                                        }
                                        else if (textBox4.Text != "")
                                        {
                                            webClient.DownloadFile(aTag, folder + "/" + textBox4.Text + imageNumber + ".jpg");//Downloads the images

                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    // Invoke(new Action(() => richTextBox17.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + bigImg + Environment.NewLine)));//Update URL list with links

                                }

                               

                                progress++;
                                imageNumber++;
                         //       Invoke(new Action(() => backgroundWorker18.ReportProgress(progress)));
                            }
                            else if (backgroundWorker18.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }

                            //-------------------------------------Download content------------------------------------------------------

                        }
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
            
        }

        private void button71_Click(object sender, EventArgs e)
        {
            backgroundWorker19.CancelAsync();
        }

        private void backgroundWorker20_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }
            int noName = 0;

            foreach (var keyword in keywordList)
            {
                noName++;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                int progress = 1;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));
                int index = 1;
                int imageNumber = 1;
                string amp = "";
                int max = 0;
                int count = 0;
                int loop = 0;
                int numberOfImages = 0;

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";


                //---------------------------------------Initialize content--------------------------------------------------------

                PhantomJSOptions options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:26.0) Gecko/20100101 Firefox/26.0");

                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));

                    driver.Navigate().GoToUrl("https://vk.com/");

                    IWebElement query = driver.FindElement(By.XPath("(//*[contains(@name, 'email')])[2]"));
                    query.SendKeys(textBox52.Text);

                    IWebElement query2 = driver.FindElement(By.XPath("(//*[contains(@name, 'pass')])[2]"));
                    query2.SendKeys(textBox53.Text);

                    driver.FindElement(By.XPath("//*[contains(@class, 'index_login_button')]")).Click();

                    Thread.Sleep(10000);

                    var url = Uri.EscapeUriString(keyword);


                    driver.Navigate().GoToUrl("https://vk.com/" + url);

                    int loaded = 0;
                    string renderedContent = "";

                    if (theNumber == 0)
                    {
                        max = 500;
                    }
                    else if (theNumber != 0)
                    {
                        max = Convert.ToInt32(textBox24.Text);
                    }

                    loop = max;

                    HtmlAgilityPack.HtmlDocument doc5 = new HtmlAgilityPack.HtmlDocument();

                    HtmlNodeCollection aTags6 = doc5.DocumentNode.SelectNodes("//*[contains(@class, 'photos_row')]/a/@href");

                    do
                    {
                        try
                        {
                            for (int u = 0; u < 5; u++)
                            {

                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                                Thread.Sleep(1000);
                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 700)");
                                Thread.Sleep(1000);
                            }

                        }
                        catch (InvalidOperationException yt)
                        {
                            break;
                        }

                        //   driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);


                        renderedContent = driver.PageSource;
                        doc5.LoadHtml(renderedContent);
                        aTags6 = doc5.DocumentNode.SelectNodes("//*[contains(@class, 'photos_row')]/a/@href");

                        try
                        {
                            if (count == aTags6.Count)
                            {
                                break;
                            }

                            count = aTags6.Count;
                        }
                        catch (NullReferenceException uj)
                        {

                        }

                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + count + Environment.NewLine)));//Update URL list with links


                    } while (count < max);

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " images.." + Environment.NewLine)));//Update URL list with links


                    foreach (var link in aTags6)
                    {
                        if (imageNumber == (max + 1))
                        {
                            break;
                        }
                        Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (max)));


                        try
                        {
                            driver.Navigate().GoToUrl("https://vk.com" + link.Attributes["href"].Value);
                        }
                        catch (Exception ex)
                        {

                        }



                        try
                        {
                            if (renderedContent == driver.PageSource)
                            {

                            }
                            else if (renderedContent != driver.PageSource)
                            {
                                renderedContent = driver.PageSource;

                                HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                                doc1.LoadHtml(renderedContent);
                                HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@id, 'pv_photo')]/img/@src");

                                foreach (var aTag in aTags1)
                                {
                                    amp = aTag.Attributes["src"].Value;
                                    // amp = amp.Replace("amp;", "");



                                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Image loaded: " + amp + Environment.NewLine)));//Update URL list with links

                                    try
                                    {


                                        if (backgroundWorker13.CancellationPending == false)
                                        {
                                            try
                                            {
                                                using (WebClient webClient = new WebClient())
                                                {

                                                    try
                                                    {

                                                        if (textBox4.Text == "")
                                                        {

                                                            webClient.DownloadFile(amp, folder + "/" + keyword + imageNumber + ".jpg");//Downloads the images
                                                        }
                                                        else if (textBox4.Text != "")
                                                        {
                                                            webClient.DownloadFile(amp, folder + "/" + textBox4.Text + noName + imageNumber + ".jpg");//Downloads the images
                                                        }


                                                       

                                                        imageNumber++;
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                                    }
                                                }

                                            }
                                            catch (WebException ex)
                                            {
                                                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + Environment.NewLine)));//Update URL list with links

                                            }
                                            numberOfImages++;
                                            progress++;
                                            // Invoke(new Action(() => backgroundWorker4.ReportProgress(progress)));
                                        }
                                        else if (backgroundWorker20.CancellationPending == true)
                                        {
                                            e.Cancel = true;
                                            break;
                                        }



                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                }
                            }


                        }
                        catch (Exception ex)
                        {

                        }
                    }


                    //---------------------------------------Initialize content--------------------------------------------------------



                    //-----------------------------------------Load content------------------------------------------------------------
                }
            }

           
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void button78_Click(object sender, EventArgs e)
        {

            source.Add(textBox52.Text);
            sourcePass.Add(textBox53.Text);
            sourceKeyword.Add(textBox2.Text);
            sourceFolder.Add(textBox1.Text);
            sourceName.Add(textBox4.Text);

            // Create and initialize the text box. 

            textBox52.AutoCompleteCustomSource = source;
            textBox53.AutoCompleteCustomSource = sourcePass;
            textBox2.AutoCompleteCustomSource = sourceKeyword;
            textBox1.AutoCompleteCustomSource = sourceFolder;
            textBox4.AutoCompleteCustomSource = sourceName;

            if (richTextBox1.Text != null)
            {
                Invoke(new Action(() => richTextBox1.AppendText(Environment.NewLine)));//Update URL list with links
            }


            if (metroRadioButton4.Checked == true && textBox52.Text == null || textBox53.Text == null)
            {
                MessageBox.Show("Put in your account information.");
            }
            else if (textBox24.Text != "")
            {

                if (IsDigitsOnly(textBox24.Text) == false)
                {
                    MessageBox.Show("You can only use digits when you want to set max number.");
                }
                else if (IsDigitsOnly(textBox24.Text) == true)
                {

                    if (metroRadioButton12.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else if (richTextBox1.Text.Contains("#"))
                            {
                                MessageBox.Show("Don't have to use a hashtag.");
                            }
                            else
                            {

                            


                               if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }
                                if (metroRadioButton1.Checked == false && metroRadioButton2.Checked == false && metroRadioButton4.Checked == false)
                                {
                                    MessageBox.Show("Check either Profile, Hashtag or Saved posts");
                                }
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Provide a profile/keyword");
                                }                          
                                else if (textBox1.Text != "" && richTextBox1.Text != "" && (metroRadioButton1.Checked == true || metroRadioButton2.Checked == true || metroRadioButton4.Checked == true))
                                {

                             //   backgroundWorker1.RunWorkerAsync(2000); //Start workthread


                                if (backgroundWorker1.IsBusy != true)
                                {


                                    backgroundWorker1.RunWorkerAsync(2000); //Start workthread

                                }
                                }
                            }
                        }
                        else if (metroRadioButton14.Checked == true)
                        {

                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else if (richTextBox1.Text.Contains("#"))
                            {
                                MessageBox.Show("Don't have to use a hashtag.");
                            }
                            else
                            {

                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }
                                if (!IsDigitsOnly(textBox24.Text) || textBox24.Text == "")
                                {
                                    MessageBox.Show("Select how many videos to download");
                                }
                                if (metroRadioButton1.Checked == false && metroRadioButton2.Checked == false && metroRadioButton4.Checked !=true)
                                {
                                    MessageBox.Show("Check either Profile or Hashtag");
                                }
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Provide a profile/keyword");
                                }
                                if (metroRadioButton4.Checked == true && textBox52.Text == null && textBox53.Text == null)
                                {
                                    MessageBox.Show("Enter account information");
                                }
                                else if (textBox1.Text != "" && richTextBox1.Text != "" && (metroRadioButton1.Checked == true || metroRadioButton2.Checked == true || metroRadioButton4.Checked == true))
                                {

                                    if (backgroundWorker12.IsBusy != true)
                                    {
                                        backgroundWorker12.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                        }
                        }
                        else if (metroRadioButton13.Checked == true)
                        {

                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else if (richTextBox1.Text.Contains("#"))
                            {
                                MessageBox.Show("Don't have to use a hashtag.");
                            }
                            else
                            {

                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }
                                if (metroRadioButton1.Checked == false && metroRadioButton2.Checked == false && metroRadioButton4.Checked == false)
                                {
                                    MessageBox.Show("Check either Profile, Hashtag or Saved posts");
                                }
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Provide a profile/keyword");
                                }
                                if (metroRadioButton4.Checked == true && textBox52.Text == null && textBox53.Text == null)
                                {
                                    MessageBox.Show("Enter account information");
                                }
                                else if (textBox1.Text != "" && richTextBox1.Text != "" && (metroRadioButton1.Checked == true || metroRadioButton2.Checked == true || metroRadioButton4.Checked == true))
                                {

                                    if (backgroundWorker15.IsBusy != true)
                                    {
                                        backgroundWorker15.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                        }
                        }
                        else if (metroRadioButton15.Checked == true)
                        {

                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else
                            {
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter a Profile");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (richTextBox1.Text != "" && textBox1.Text != "")
                                {
                                    if (backgroundWorker4.IsBusy != true)
                                    {
                                        backgroundWorker4.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton16.Checked == true)
                        {

                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else
                            {
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter a keyword");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (richTextBox1.Text != "" && textBox1.Text != "")
                                {
                                    if (backgroundWorker5.IsBusy != true)
                                    {
                                        backgroundWorker5.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton17.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else
                            {
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter a URL");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (textBox1.Text != "" && richTextBox1.Text != "")
                                {
                                    if (backgroundWorker6.IsBusy != true)
                                    {
                                        backgroundWorker6.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton18.Checked == true)
                        {
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Provide a keyword");
                            }
                            else if (richTextBox1.Text != "" && textBox1.Text != "")
                            {
                                if (backgroundWorker8.IsBusy != true)
                                {
                                    backgroundWorker8.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                        else if (metroRadioButton19.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else
                            {
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter a keyword");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (richTextBox1.Text != "" && textBox1.Text != "")
                                {
                                    if (backgroundWorker9.IsBusy != true)
                                    {
                                        backgroundWorker9.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton20.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else
                            {
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter a keyword");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (richTextBox1.Text != "" && textBox1.Text != "")
                                {
                                    if (backgroundWorker11.IsBusy != true)
                                    {
                                        backgroundWorker11.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton21.Checked == true)
                        {
                                if (richTextBox1.Text.Contains(" "))
                                {
                                  //  MessageBox.Show("You cant have any whitespaces.");

                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter a keyword");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (richTextBox1.Text != "" && textBox1.Text != "")
                                {
                                    if (backgroundWorker2.IsBusy != true)
                                    {
                                        backgroundWorker2.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                            else
                            {
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter a keyword");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (richTextBox1.Text != "" && textBox1.Text != "")
                                {
                                    if (backgroundWorker2.IsBusy != true)
                                    {
                                        backgroundWorker2.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton22.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else
                            {
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter a Profile");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (richTextBox1.Text != "" && textBox1.Text != "")
                                {
                                    if (backgroundWorker13.IsBusy != true)
                                    {
                                        backgroundWorker13.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton23.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else
                            {
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter a keyword");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (textBox1.Text != "" && richTextBox1.Text != "")
                                {
                                    if (backgroundWorker3.IsBusy != true)
                                    {
                                        backgroundWorker3.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton24.Checked == true)
                        {
                            if (!backgroundWorker16.IsBusy && metroCheckBox1.Checked != true)
                            {

                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Provide a profile/keyword");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }
                                if (textBox52.Text == "")
                                {
                                    MessageBox.Show("Provide an account name");
                                }
                                if (textBox53.Text == "")
                                {
                                    MessageBox.Show("Provide an account password");
                                }
                                else if (textBox1.Text != "" && textBox52.Text != "" && textBox53.Text != "")
                                {
                                    if (backgroundWorker16.IsBusy != true)
                                    {
                                        backgroundWorker16.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                            else if (!backgroundWorker16.IsBusy && metroCheckBox1.Checked == true)
                            {
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (textBox52.Text == "")
                                {
                                    MessageBox.Show("Provide an account name");
                                }
                                if (textBox53.Text == "")
                                {
                                    MessageBox.Show("Provide an account password");
                                }
                                else if (textBox1.Text != "" && textBox52.Text != "" && textBox53.Text != "")
                                {
                                    if (backgroundWorker16.IsBusy != true)
                                    {
                                        backgroundWorker16.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton25.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Provide a keyword");
                            }
                            //if (textBox52.Text == "")
                            //{
                            //    MessageBox.Show("Provide an account name");
                            //}
                            //if (textBox53.Text == "")
                            //{
                            //    MessageBox.Show("Provide an account password");
                            //}
                            if (richTextBox1.Text != "" && textBox1.Text != "")
                            {
                                if (backgroundWorker17.IsBusy != true)
                                {
                                    backgroundWorker17.RunWorkerAsync(2000); //Start workthread
                                }
                            }

                        }
                        else if (metroRadioButton26.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }

                            else
                            {

                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Provide a profile/keyword");
                                }
                                else if (richTextBox1.Text != "" && textBox1.Text != "")
                                {
                                    if (backgroundWorker18.IsBusy != true)
                                    {
                                        backgroundWorker18.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton27.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }

                            else
                            {

                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Provide a profile/keyword");
                                }
                                else if (textBox1.Text != "" && richTextBox1.Text != "")
                                {
                                    if (backgroundWorker19.IsBusy != true)
                                    {
                                        backgroundWorker19.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton5.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }

                            else
                            {

                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Provide a profile/keyword");
                                }
                                else if (textBox1.Text != "" && richTextBox1.Text != "")
                                {
                                    if (backgroundWorker23.IsBusy != true)
                                    {
                                        backgroundWorker23.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                    else if (metroRadioButton28.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else
                            {
                                if (textBox52.Text == "")
                                {
                                    MessageBox.Show("Provide an account name");
                                }
                                if (textBox53.Text == "")
                                {
                                    MessageBox.Show("Provide an account password");
                                }
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter an Album Url");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (richTextBox1.Text != "" && textBox1.Text != "")
                                {
                                    if (backgroundWorker20.IsBusy != true)
                                    {
                                        backgroundWorker20.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton3.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else
                            {
                                if (textBox52.Text == "")
                                {
                                    MessageBox.Show("Provide an account name");
                                }
                                if (textBox53.Text == "")
                                {
                                    MessageBox.Show("Provide an account password");
                                }
                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter a URL");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }

                                if (richTextBox1.Text != "" && textBox1.Text != "")
                                {
                                    if (backgroundWorker21.IsBusy != true)
                                    {
                                        backgroundWorker21.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                        else if (metroRadioButton29.Checked == true)
                        {
                            if (richTextBox1.Text.Contains(" "))
                            {
                                MessageBox.Show("You cant have any whitespaces.");
                            }
                            else
                            {

                                if (richTextBox1.Text == "")
                                {
                                    MessageBox.Show("Enter a URL");
                                }
                                if (textBox1.Text == "")
                                {
                                    MessageBox.Show("Select a save folder");
                                }
                                if (textBox22.Text == "")
                                {
                                    MessageBox.Show("Enter an Xpath");
                                }

                                if (richTextBox1.Text != "" && textBox1.Text != "" && textBox22.Text != "")
                                {
                                    if (backgroundWorker7.IsBusy != true)
                                    {
                                        backgroundWorker7.RunWorkerAsync(2000); //Start workthread
                                    }
                                }
                            }
                        }
                    }
                

            }
            else if (textBox24.Text == "")
            {

               

                    if (metroRadioButton12.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else if (richTextBox1.Text.Contains("#"))
                        {
                            MessageBox.Show("Don't have to use a hashtag.");
                        }
                        else
                        {

                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }
                            if (metroRadioButton1.Checked == false && metroRadioButton2.Checked == false)
                            {
                                MessageBox.Show("Check either Profile or Hashtag");
                            }
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Provide a profile/keyword");
                            }
                            if (metroRadioButton4.Checked == true && textBox52.Text != null && textBox53.Text != null)
                            {
                                MessageBox.Show("Enter account information");
                            }
                            else if (textBox1.Text != "" && richTextBox1.Text != "" && (metroRadioButton1.Checked == true || metroRadioButton2.Checked == true || metroRadioButton4.Checked == true))
                            {

                                if (backgroundWorker1.IsBusy != true)
                                {
                                    backgroundWorker1.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                    }
                    }
                    else if (metroRadioButton3.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else
                        {
                            if (textBox52.Text == "")
                            {
                                MessageBox.Show("Provide an account name");
                            }
                            if (textBox53.Text == "")
                            {
                                MessageBox.Show("Provide an account password");
                            }
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Enter a URL");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }

                            if (richTextBox1.Text != "" && textBox1.Text != "")
                            {
                                if (backgroundWorker21.IsBusy != true)
                                {
                                    backgroundWorker21.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton14.Checked == true)
                    {

                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else if (richTextBox1.Text.Contains("#"))
                        {
                            MessageBox.Show("Don't have to use a hashtag.");
                        }
                        else
                        {

                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }
                            if (!IsDigitsOnly(textBox24.Text) || textBox24.Text == "")
                            {
                                MessageBox.Show("Select how many videos to download");
                            }
                            if (metroRadioButton1.Checked == false && metroRadioButton2.Checked == false)
                            {
                                MessageBox.Show("Check either Profile or Hashtag");
                            }
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Provide a profile/keyword");
                            }
                            if (metroRadioButton4.Checked == true && textBox52.Text != null && textBox53.Text != null)
                            {
                                MessageBox.Show("Enter account information");
                            }
                            else if (textBox1.Text != "" && richTextBox1.Text != "" && (metroRadioButton1.Checked == true || metroRadioButton2.Checked == true || metroRadioButton4.Checked == true))
                            {

                                if (backgroundWorker12.IsBusy != true)
                                {
                                    backgroundWorker12.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                    }
                    }
                    else if (metroRadioButton13.Checked == true)
                    {

                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else if (richTextBox1.Text.Contains("#"))
                        {
                            MessageBox.Show("Don't have to use a hashtag.");
                        }
                        else
                        {

                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }
                            if (metroRadioButton1.Checked == false && metroRadioButton2.Checked == false && metroRadioButton4.Checked == false)
                            {
                                MessageBox.Show("Check either Profile, Hashtag or saved Posts");
                            }
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Provide a profile/keyword");
                            }
                            if (metroRadioButton4.Checked == true && textBox52.Text == null && textBox53.Text == null)
                            {
                                MessageBox.Show("Enter account information");
                            }
                            else if (textBox1.Text != "" && richTextBox1.Text != "" && (metroRadioButton1.Checked == true || metroRadioButton2.Checked == true || metroRadioButton4.Checked == true))
                            {

                                if (backgroundWorker15.IsBusy != true)
                                {
                                    backgroundWorker15.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                    }
                    }
                    else if (metroRadioButton15.Checked == true)
                    {

                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else
                        {
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Enter a Profile");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }

                            if (richTextBox1.Text != "" && textBox1.Text != "")
                            {
                                if (backgroundWorker4.IsBusy != true)
                                {
                                    backgroundWorker4.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton16.Checked == true)
                    {

                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else
                        {
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Enter a keyword");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }

                            if (richTextBox1.Text != "" && textBox1.Text != "")
                            {
                                if (backgroundWorker5.IsBusy != true)
                                {
                                    backgroundWorker5.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton17.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else
                        {
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Enter a URL");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }

                            if (textBox1.Text != "" && richTextBox1.Text != "")
                            {
                                if (backgroundWorker6.IsBusy != true)
                                {
                                    backgroundWorker6.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton18.Checked == true)
                    {
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Select a save folder");
                        }
                        if (richTextBox1.Text == "")
                        {
                            MessageBox.Show("Provide a keyword");
                        }
                        else if (richTextBox1.Text != "" && textBox1.Text != "")
                        {
                            if (backgroundWorker8.IsBusy != true)
                            {
                                backgroundWorker8.RunWorkerAsync(2000); //Start workthread
                            }
                        }
                    }
                    else if (metroRadioButton19.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else
                        {
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Enter a keyword");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }

                            if (richTextBox1.Text != "" && textBox1.Text != "")
                            {
                                if (backgroundWorker9.IsBusy != true)
                                {
                                    backgroundWorker9.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton20.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else
                        {
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Enter a keyword");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }

                            if (richTextBox1.Text != "" && textBox1.Text != "")
                            {
                                if (backgroundWorker11.IsBusy != true)
                                {
                                    backgroundWorker11.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton21.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                        //  MessageBox.Show("You cant have any whitespaces.");

                        if (richTextBox1.Text == "")
                        {
                            MessageBox.Show("Enter a keyword");
                        }
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Select a save folder");
                        }

                        if (richTextBox1.Text != "" && textBox1.Text != "")
                        {
                            if (backgroundWorker2.IsBusy != true)
                            {
                                backgroundWorker2.RunWorkerAsync(2000); //Start workthread
                            }
                        }
                    }
                        else
                        {
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Enter a keyword");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }

                            if (richTextBox1.Text != "" && textBox1.Text != "")
                            {
                                if (backgroundWorker2.IsBusy != true)
                                {
                                    backgroundWorker2.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton22.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else
                        {
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Enter a Profile");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }

                            if (richTextBox1.Text != "" && textBox1.Text != "")
                            {
                                if (backgroundWorker13.IsBusy != true)
                                {
                                    backgroundWorker13.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton23.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else
                        {
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Enter a keyword");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }

                            if (textBox1.Text != "" && richTextBox1.Text != "")
                            {
                                if (backgroundWorker3.IsBusy != true)
                                {
                                    backgroundWorker3.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton24.Checked == true)
                    {
                        if (!backgroundWorker16.IsBusy && metroCheckBox1.Checked != true)
                        {

                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Provide a profile/keyword");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }
                            if (textBox52.Text == "")
                            {
                                MessageBox.Show("Provide an account name");
                            }
                            if (textBox53.Text == "")
                            {
                                MessageBox.Show("Provide an account password");
                            }
                            else if (textBox1.Text != "" && textBox52.Text != "" && textBox53.Text != "")
                            {
                                if (backgroundWorker16.IsBusy != true)
                                {
                                    backgroundWorker16.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                        else if (!backgroundWorker16.IsBusy && metroCheckBox1.Checked == true)
                        {
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }

                            if (textBox52.Text == "")
                            {
                                MessageBox.Show("Provide an account name");
                            }
                            if (textBox53.Text == "")
                            {
                                MessageBox.Show("Provide an account password");
                            }
                            else if (textBox1.Text != "" && textBox52.Text != "" && textBox53.Text != "")
                            {
                                if (backgroundWorker16.IsBusy != true)
                                {
                                    backgroundWorker16.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton25.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Select a save folder");
                        }
                        if (richTextBox1.Text == "")
                        {
                            MessageBox.Show("Provide a keyword");
                        }
                      
                        if (richTextBox1.Text != "" && textBox1.Text != "")
                        {
                            if (backgroundWorker17.IsBusy != true)
                            {
                                backgroundWorker17.RunWorkerAsync(2000); //Start workthread
                            }
                        }

                    }
                    else if (metroRadioButton26.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }

                        else
                        {

                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Provide a profile/keyword");
                            }
                            else if (richTextBox1.Text != "" && textBox1.Text != "")
                            {
                                if (backgroundWorker18.IsBusy != true)
                                {
                                    backgroundWorker18.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton27.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }

                        else
                        {

                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Provide a profile/keyword");
                            }
                            else if (textBox1.Text != "" && richTextBox1.Text != "")
                            {
                                if (backgroundWorker19.IsBusy != true)
                                {
                                    backgroundWorker19.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton28.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else
                        {
                            if (textBox52.Text == "")
                            {
                                MessageBox.Show("Provide an account name");
                            }
                            if (textBox53.Text == "")
                            {
                                MessageBox.Show("Provide an account password");
                            }
                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Enter an Album Url");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }

                            if (richTextBox1.Text != "" && textBox1.Text != "")
                            {
                                if (backgroundWorker20.IsBusy != true)
                                {
                                    backgroundWorker20.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                    else if (metroRadioButton29.Checked == true)
                    {
                        if (richTextBox1.Text.Contains(" "))
                        {
                            MessageBox.Show("You cant have any whitespaces.");
                        }
                        else
                        {

                            if (richTextBox1.Text == "")
                            {
                                MessageBox.Show("Enter a URL");
                            }
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Select a save folder");
                            }
                            if (textBox22.Text == "")
                            {
                                MessageBox.Show("Enter an Xpath");
                            }

                            if (richTextBox1.Text != "" && textBox1.Text != "" && textBox22.Text != "")
                            {
                                if (backgroundWorker7.IsBusy != true)
                                {
                                    backgroundWorker7.RunWorkerAsync(2000); //Start workthread
                                }
                            }
                        }
                    }
                
            }

        }

        private void metroRadioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton15.Checked == true)
            {
                button2.Text = "Add profile";
                textBox2.Text = "Put profile name here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Profile";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox25.Enabled = true;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;

                metroRadioButton3.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton18.Checked = false;
                metroRadioButton19.Checked = false;
                metroRadioButton20.Checked = false;
                metroRadioButton24.Checked = false;
                metroRadioButton26.Checked = false;
                metroRadioButton27.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;
                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }

        }

        private void metroRadioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton16.Checked == true)
            {
                button2.Text = "Add URL";
                // metroCheckBox3.Visible = true;
                textBox2.Text = "Put URL here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "URL";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;
                groupBox25.Enabled = true;

                metroRadioButton3.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton22.Checked = false;
                metroRadioButton17.Checked = false;
                metroRadioButton25.Checked = false;
                metroRadioButton28.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;
                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }
            else if (metroRadioButton16.Checked == false)
            {
                metroCheckBox3.Visible = false;
            }


        }

        private void metroRadioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton17.Checked == true)
            {
                button2.Text = "Add URL";
                groupBox25.Enabled = true;
                textBox2.Text = "Put URL here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "URL";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;

                metroRadioButton3.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton18.Checked = false;
                metroRadioButton19.Checked = false;
                metroRadioButton20.Checked = false;
                metroRadioButton24.Checked = false;
                metroRadioButton26.Checked = false;
                metroRadioButton27.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;
                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }


        }

        private void metroRadioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton18.Checked == true)
            {
                button2.Text = "Add keyword";
                textBox2.Text = "Put keyword here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Keyword";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox25.Enabled = true;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;

                metroRadioButton3.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton22.Checked = false;
                metroRadioButton17.Checked = false;
                metroRadioButton25.Checked = false;
                metroRadioButton28.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }

        }

        private void metroRadioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton19.Checked == true)
            {
                button2.Text = "Add keyword";
                textBox2.Text = "Put keyword here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Keyword";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox25.Enabled = true;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;

                metroRadioButton3.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton22.Checked = false;
                metroRadioButton17.Checked = false;
                metroRadioButton25.Checked = false;
                metroRadioButton28.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }
        }

        private void metroRadioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton20.Checked == true)
            {
                button2.Text = "Add keyword";
                textBox2.Text = "Put keyword here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Keyword";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox25.Enabled = true;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;

                metroRadioButton3.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton22.Checked = false;
                metroRadioButton17.Checked = false;
                metroRadioButton25.Checked = false;
                metroRadioButton28.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }

        }

        private void metroRadioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton21.Checked == true)
            {
                button2.Text = "Add keyword";
                textBox2.Text = "Put keyword here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Keyword";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox25.Enabled = true;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;

                metroRadioButton3.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton18.Checked = false;
                metroRadioButton19.Checked = false;
                metroRadioButton20.Checked = false;
                metroRadioButton24.Checked = false;
                metroRadioButton26.Checked = false;
                metroRadioButton27.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton22.Checked = false;
                metroRadioButton17.Checked = false;
                metroRadioButton25.Checked = false;
                metroRadioButton28.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

                metroCheckBox4.Visible = true;


            }

        }

        private void metroRadioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton22.Checked == true)
            {
                button2.Text = "Add album";
                textBox2.Text = "Put album URL here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Album Url";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;

                metroRadioButton3.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton18.Checked = false;
                metroRadioButton19.Checked = false;
                metroRadioButton20.Checked = false;
                metroRadioButton24.Checked = false;
                metroRadioButton26.Checked = false;
                metroRadioButton27.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;
                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }

        }

        private void metroRadioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton23.Checked == true)
            {
                button2.Text = "Add keyword";
                textBox2.Text = "Put keyword here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Keyword";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox25.Enabled = true;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;

                metroRadioButton3.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton18.Checked = false;
                metroRadioButton19.Checked = false;
                metroRadioButton20.Checked = false;
                metroRadioButton24.Checked = false;
                metroRadioButton26.Checked = false;
                metroRadioButton27.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton22.Checked = false;
                metroRadioButton17.Checked = false;
                metroRadioButton25.Checked = false;
                metroRadioButton28.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }

        }

        private void metroRadioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton24.Checked == true)
            {
                button2.Text = "Add keyword";
                textBox2.Text = "Put keyword here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Keyword";
                groupBox54.Enabled = true;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                metroCheckBox1.Visible = true;
                groupBox23.Enabled = false;
                metroCheckBox2.Enabled = false;
                groupBox25.Enabled = true;

                metroRadioButton3.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton22.Checked = false;
                metroRadioButton17.Checked = false;
                metroRadioButton25.Checked = false;
                metroRadioButton28.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }
        }

        private void metroRadioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton25.Checked == true)
            {
                button2.Text = "Add keyword";
                textBox2.Text = "Put keyword here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Keyword";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;
                groupBox25.Enabled = true;

                metroRadioButton3.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton18.Checked = false;
                metroRadioButton19.Checked = false;
                metroRadioButton20.Checked = false;
                metroRadioButton24.Checked = false;
                metroRadioButton26.Checked = false;
                metroRadioButton27.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;
            }
        }

        private void metroRadioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton26.Checked == true)
            {
                button2.Text = "Add keyword";
                textBox2.Text = "Put keyword here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Keyword";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;
                groupBox25.Enabled = true;

                metroRadioButton3.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton22.Checked = false;
                metroRadioButton17.Checked = false;
                metroRadioButton25.Checked = false;
                metroRadioButton28.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }


        }

        private void metroRadioButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton27.Checked == true)
            {
                button2.Text = "Add keyword";
                textBox2.Text = "Put keyword here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Keyword";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;
                groupBox25.Enabled = true;

                metroRadioButton3.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton22.Checked = false;
                metroRadioButton17.Checked = false;
                metroRadioButton25.Checked = false;
                metroRadioButton28.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }

        }

        private void metroRadioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton28.Checked == true)
            {
                button2.Text = "Add album";
                textBox2.Text = "Put album URL here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Album Url";
                groupBox54.Enabled = true;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                metroCheckBox1.Visible = false;
                groupBox23.Enabled = false;
                metroCheckBox2.Enabled = false;
                groupBox25.Enabled = true;

                metroRadioButton3.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton18.Checked = false;
                metroRadioButton19.Checked = false;
                metroRadioButton20.Checked = false;
                metroRadioButton24.Checked = false;
                metroRadioButton26.Checked = false;
                metroRadioButton27.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }


        }

        private void metroRadioButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton29.Checked == true)
            {
                button2.Text = "Add URL";
                textBox2.Text = "Put URL here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "URL";
                groupBox23.Enabled = true;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;

                metroRadioButton3.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton18.Checked = false;
                metroRadioButton19.Checked = false;
                metroRadioButton20.Checked = false;
                metroRadioButton24.Checked = false;
                metroRadioButton26.Checked = false;
                metroRadioButton27.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton22.Checked = false;
                metroRadioButton17.Checked = false;
                metroRadioButton25.Checked = false;
                metroRadioButton28.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            List<string> keys = new List<string>();

            keys.Add("c2fdsa05Om");
            keys.Add("Gs0AuUUY2t");
            keys.Add("9l9Nb4hC9k");
            keys.Add("hrJnIgEAdG");
            keys.Add("kTrPaMVOwg");
            keys.Add("bBI52FZlBQ");
            keys.Add("CdWV6Ct0Wd");
            keys.Add("DacBjuT2h8");
            keys.Add("njMUbeCM25");
            keys.Add("srDkvtANj0");


            foreach (var key in keys)
            {

                if (toolStripTextBox1.Text == key)
                {
                    toolStripTextBox1.Visible = false;
                    toolStripButton1.Visible = false;
                    toolStripLabel1.Text = "Activated";
                    groupBox4.Enabled = true;
                    //string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/key.txt";
                    //string path2 = new Uri(path).LocalPath;

                    string path3 = Environment.ExpandEnvironmentVariables("%AppData%\\FM-imagescraper-key");
                    System.IO.Directory.CreateDirectory(path3);

                    string path4 = Environment.ExpandEnvironmentVariables("%AppData%\\FM-imagescraper-key\\key.txt");
                    using (StreamWriter writer = new StreamWriter(path4))
                    {
                        writer.WriteLine(key);
                    }
                }
            }


            if (groupBox4.Enabled != true)
            {
                MessageBox.Show("Invalid key");

            }
        }

        private void metroRadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
        }

        private void metroRadioButton12_CheckedChanged(object sender, EventArgs e)
        {

            if (metroRadioButton12.Checked == true)
            {
                button2.Text = "Add keyword";
                textBox2.Text = "Put keyword or profile here";
                metroLabel1.Text = "Profile/Hashtag";
                metroRadioButton1.Enabled = true;
                metroRadioButton2.Enabled = true;
                metroRadioButton4.Enabled = true;
                metroCheckBox1.Visible = false;
                richTextBox1.Text = "Don't mix Profiles and Hashtags";
                richTextBox1.Enabled = true;
                metroCheckBox2.Enabled = true;
                groupBox54.Enabled = false;
                groupBox25.Enabled = true;

                metroRadioButton16.Checked = false;
                metroRadioButton18.Checked = false;
                metroRadioButton19.Checked = false;
                metroRadioButton20.Checked = false;
                metroRadioButton24.Checked = false;
                metroRadioButton26.Checked = false;
                metroRadioButton27.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton3.Checked = false;
                metroRadioButton5.Checked = false;

                metroRadioButton1.Visible = true;
                metroRadioButton2.Visible = true;
                metroRadioButton4.Visible = true;
                metroCheckBox2.Visible = true;

                richTextBox1.Height = 90;
                richTextBox1.Left = 15;
                richTextBox1.Top = 65;

            }


        }

        private void metroRadioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if(metroRadioButton13.Checked == true)
            {
                textBox2.Text = "Put keyword or profile here";
                metroLabel1.Text = "Profile/Hashtag";
                metroRadioButton1.Enabled = true;
                metroRadioButton2.Enabled = true;
                metroRadioButton4.Enabled = true;
                richTextBox1.Text = "Don't mix Profiles and Hashtags";
                richTextBox1.Enabled = true;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = true;
                groupBox54.Enabled = false;
                groupBox25.Enabled = true;

                metroRadioButton3.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton18.Checked = false;
                metroRadioButton19.Checked = false;
                metroRadioButton20.Checked = false;
                metroRadioButton24.Checked = false;
                metroRadioButton26.Checked = false;
                metroRadioButton27.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = true;
                metroRadioButton2.Visible = true;
                metroRadioButton4.Visible = true;
                metroCheckBox2.Visible = true;

                richTextBox1.Height = 90;
                richTextBox1.Left = 15;
                richTextBox1.Top = 65;

            }


        }

        private void metroRadioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton14.Checked == true)
            {
                textBox2.Text = "Put keyword or profile here";
                metroLabel1.Text = "Profile/Hashtag";
                metroRadioButton1.Enabled = true;
                metroRadioButton2.Enabled = true;
                metroRadioButton4.Enabled = true;
                richTextBox1.Text = "Don't mix Profiles and Hashtags";
                richTextBox1.Enabled = true;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = true;
                groupBox54.Enabled = false;
                groupBox25.Enabled = true;

                metroRadioButton3.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton18.Checked = false;
                metroRadioButton19.Checked = false;
                metroRadioButton20.Checked = false;
                metroRadioButton24.Checked = false;
                metroRadioButton26.Checked = false;
                metroRadioButton27.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton5.Checked = false;


                metroRadioButton1.Visible = true;
                metroRadioButton2.Visible = true;
                metroRadioButton4.Visible = true;
                metroCheckBox2.Visible = true;

                richTextBox1.Height = 90;
                richTextBox1.Left = 15;
                richTextBox1.Top = 65;

            }


        }
        private void Form1_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Process proc in Process.GetProcessesByName("PhantomJS"))
            {
                proc.Kill();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Don't mix Profiles and Hashtags")
            {
                richTextBox1.Text = "";
            }

            if (!textBox2.Text.Contains("#"))
            {
                Invoke(new Action(() => richTextBox1.AppendText(textBox2.Text + Environment.NewLine)));//Update URL list with links
                keywordCheck = 0;
            }
            else if (textBox2.Text.Contains("#"))
            {
                MessageBox.Show("You don't need to use \"#\"");
            }
          
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            metroRadioButton1.Enabled = false;
            metroRadioButton2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Remember to place each keyword on a new line.");

            OpenFileDialog openFileDialog = new OpenFileDialog();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    string currentLine;
                    // currentLine will be null when the StreamReader reaches the end of file
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        // Search, case insensitive, if the currentLine contains the searched keyword
                     
                            richTextBox1.Text += currentLine + Environment.NewLine;
                        
                    }
                }
            }

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    if (openFileDialog.FileName.Contains(".txt"))
            //    {
            //        path = openFileDialog.FileName;

            //        List<string> Log = new List<string>();
            //        Log = File.ReadLines(path).ToList();

            //        richTextBox1.Lines = Log.ToArray();
            //        keywordCheck = 1;

            //    }
            //    else if (!openFileDialog.FileName.Contains("Posts"))
            //    {
            //        MessageBox.Show("Please choose a text file(.txt)");
            //    }

            //}
        }



        private void button4_Click(object sender, EventArgs e)
        {

            Form testff = new Form2();

            testff.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker21_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }

            foreach (var keyword in keywordList)
            {


                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading videos." + Environment.NewLine)));//Update URL list with links
                int progress = 1;
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));
                int index = 1;
                int imageNumber = 1;
                string amp = "";
                int max = 0;
                int count = 0;
                int loop = 0;
                string userName = textBox52.Text;
                string userPassword = textBox53.Text;
                string video = "";

                if (theNumber != 0)
                {
                    max = theNumber;
                }
                else if (theNumber == 0)
                {
                    max = 500;
                }

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";


                //---------------------------------------Initialize content--------------------------------------------------------

                PhantomJSOptions options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");

                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {
                    driver.Manage().Window.Size = new Size(1920, 1080);


                    try
                    {
                        driver.Navigate().GoToUrl("https://www.facebook.com/");

                        IWebElement query = driver.FindElement(By.XPath("//*[contains(@type, 'email')]"));
                        query.SendKeys(userName);

                        IWebElement query2 = driver.FindElement(By.XPath("(//*[contains(@id, 'pass')])[1]"));
                        query2.SendKeys(userPassword);

                        driver.FindElement(By.XPath("(//*[contains(@type, 'submit')])[1]")).Click();

                        Thread.Sleep(10000);

                      //  driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot1.png", ImageFormat.Png);


                    }
                    catch (Exception ex)
                    {

                    }
                    var url = Uri.EscapeUriString(keyword);

                    driver.Navigate().GoToUrl(url);

                    Thread.Sleep(7000);

                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));

                    try
                    {
                        driver.FindElement(By.XPath("//*[contains(@class, '_3v4j')]/div/div/a")).Click();
                    }
                    catch (Exception io)
                    {

                    }



                  //   driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot5.png", ImageFormat.Png);

                    int loaded = 0;
                    string renderedContent = "";

                    if (theNumber == 0)
                    {
                        max = 500;

                    }
                    else if (theNumber != 0)
                    {
                        max = Convert.ToInt32(textBox24.Text);
                    }

                    loop = max;

                    do
                    {
                        try
                        {
                            for (int u = 0; u < 5; u++)
                            {

                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                                Thread.Sleep(1000);
                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 700)");
                                Thread.Sleep(1000);

                                driver.FindElement(By.XPath("//*[contains(@class, '_3v4j')]/div/div/a")).Click();

                            }

                        }
                        catch (InvalidOperationException yt)
                        {
                            break;
                        }

                        //   driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);


                        renderedContent = driver.PageSource;

                        HtmlAgilityPack.HtmlDocument doc5 = new HtmlAgilityPack.HtmlDocument();
                        doc5.LoadHtml(renderedContent);
                        HtmlNodeCollection aTags6 = doc5.DocumentNode.SelectNodes("//*[contains(@class, 'uiGrid')]//a[2]/@href");

                        try
                        {
                            if (count == aTags6.Count)
                            {
                                break;
                            }

                            count = aTags6.Count;
                        }
                        catch (NullReferenceException uj)
                        {

                        }

                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "videos loaded: " + count + Environment.NewLine)));//Update URL list with links


                    } while (count < max);

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " videos.." + Environment.NewLine)));//Update URL list with links


                    loop = count;

                    for (int j = 1; j < loop; j++)
                    {
                        renderedContent = driver.PageSource;

                       // driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);


                        HtmlAgilityPack.HtmlDocument doc5 = new HtmlAgilityPack.HtmlDocument();
                        doc5.LoadHtml(renderedContent);
                        HtmlNodeCollection aTags6 = doc5.DocumentNode.SelectNodes("//*[contains(@class, 'uiGrid')]//a[2]/@href");

                        try
                        {

                            foreach (var link in aTags6)
                            {
                                driver.Navigate().GoToUrl("https://m.facebook.com" + link.Attributes["href"].Value);

                                Thread.Sleep(5000);

                                //  driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot.png", ImageFormat.Png);
                                //  Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "https://m.facebook.com" + link.Attributes["href"].Value + Environment.NewLine)));//Update URL list with links

                                // ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementsByClassName('_1o0y').click();");

                                Thread.Sleep(5000);



                                try
                                {

                                    renderedContent = driver.PageSource;

                                    HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                                    doc1.LoadHtml(renderedContent);
                                    HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, '_53mw')]/@data-store");

                                    foreach (var aTag in aTags1)
                                    {


                                        video = System.Text.RegularExpressions.Regex.Match(aTag.Attributes["data-store"].Value, @"src&quot;:&quot;([^;]*)(....................................................)").Groups[1].Value;
                                        video = video + System.Text.RegularExpressions.Regex.Match(aTag.Attributes["data-store"].Value, @"src&quot;:&quot;([^;]*)(....................................................)").Groups[2].Value;



                                        video = video.Replace(@"\/", "/");
                                        video = video.Replace(@"&amp;oh=", "&oh=");
                                        video = video.Replace(@"&amp;oe=", "&oe=");


                                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Video loaded: " + video + Environment.NewLine)));//Update URL list with links



                                        if (imageNumber == (max + 1))
                                        {
                                            break;
                                        }
                                        Invoke(new Action(() => metroLabel4.Text = "Working video: " + imageNumber + "/" + (max)));



                                        try
                                        {


                                            if (backgroundWorker21.CancellationPending == false)
                                            {
                                                try
                                                {
                                                    using (WebClient webClient = new WebClient())
                                                    {

                                                        try
                                                        {

                                                            if (textBox4.Text == "")
                                                            {

                                                                webClient.DownloadFile(video, folder + "/" + "video" + imageNumber + ".mp4");//Downloads the images
                                                                //mybt = new UserControl1(folder + "/" + "video" + imageNumber + ".mp4", "video" + imageNumber);
                                                                //Invoke(new Action(() => flowLayoutPanel1.Controls.Add(mybt)));
                                                            }
                                                            else if (textBox4.Text != "")
                                                            {
                                                                webClient.DownloadFile(video, folder + "/" + textBox4.Text + imageNumber + ".mp4");//Downloads the images
                                                                //mybt = new UserControl1(folder + "/" + textBox4.Text + imageNumber + ".mp4", keyword + imageNumber);
                                                                //Invoke(new Action(() => flowLayoutPanel1.Controls.Add(mybt)));
                                                            }


                                                          

                                                            imageNumber++;
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            //    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + ex + Environment.NewLine)));//Update URL list with links

                                                        }
                                                    }

                                                }
                                                catch (WebException ex)
                                                {
                                                    //  Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Something went wrong, please wait" + ex + Environment.NewLine)));//Update URL list with links

                                                }
                                                progress++;
                                                Invoke(new Action(() => backgroundWorker4.ReportProgress(progress)));
                                            }
                                            else if (backgroundWorker21.CancellationPending == true)
                                            {
                                                e.Cancel = true;
                                                break;
                                            }



                                        }
                                        catch (Exception ex)
                                        {

                                        }
                                    }



                                }
                                catch (Exception ex)
                                {

                                }

                                if ((imageNumber - 1) == max)
                                {
                                    break;
                                }

                            }
                        }
                        catch (Exception ty)
                        {

                        }


                    }

                    //---------------------------------------Initialize content--------------------------------------------------------



                    //-----------------------------------------Load content------------------------------------------------------------


                }
            }

        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton3.Checked == true)
            {
                button2.Text = "Add album";
                richTextBox1.Text = "";
                textBox2.Text = "Put video album URL here";
                groupBox54.Enabled = true;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                metroCheckBox2.Enabled = false;

                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;
                metroRadioButton5.Checked = false;


                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

             

            }
        }

        private void backgroundWorker21_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";

        }

        private void backgroundWorker14_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";

        }

        private void backgroundWorker19_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";

        }

        private void backgroundWorker20_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            List<string> keys = new List<string>();

            keys.Add("c2fdsa05Om");
            keys.Add("Gs0AuUUY2t");
            keys.Add("9l9Nb4hC9k");
            keys.Add("hrJnIgEAdG");
            keys.Add("kTrPaMVOwg");
            keys.Add("bBI52FZlBQ");
            keys.Add("CdWV6Ct0Wd");
            keys.Add("DacBjuT2h8");
            keys.Add("njMUbeCM25");
            keys.Add("srDkvtANj0");


            foreach (var key in keys)
            {

                if (toolStripTextBox1.Text == key)
                {
                    toolStripTextBox1.Visible = false;
                    toolStripButton1.Visible = false;
                    textBox3.Visible = false;
                    button6.Visible = false;
                    toolStripLabel1.Text = "Activated";
                    groupBox4.Enabled = true;
                    //string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/key.txt";
                    //string path2 = new Uri(path).LocalPath;

                    string path3 = Environment.ExpandEnvironmentVariables("%AppData%\\FM-imagescraper-key");
                    System.IO.Directory.CreateDirectory(path3);

                    string path4 = Environment.ExpandEnvironmentVariables("%AppData%\\FM-imagescraper-key\\key.txt");
                    using (StreamWriter writer = new StreamWriter(path4))
                    {
                        writer.WriteLine(key);
                    }
                }
            }


            if (groupBox4.Enabled != true)
            {
                MessageBox.Show("Invalid key");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form testff = new Form3();

            testff.Show();
        }

        private void backgroundWorker22_DoWork(object sender, DoWorkEventArgs e)
        {
            using (FileStream fs = File.Create(textBox1.Text + "/urls.txt"))
            {
                fs.Close();
            }
            Invoke(new Action(() => File.WriteAllLines(textBox1.Text + "/urls.txt", richTextBox2.Lines)));


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null || textBox1.Text != "")
            {
                if (!backgroundWorker22.IsBusy)
                {
                    backgroundWorker22.RunWorkerAsync(2000);
                }
            }
            else if (textBox1.Text == null || textBox1.Text == "")
            {
                MessageBox.Show("Please select a folder to store the URLs.");

            }
           

        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton4.Checked == true)
            {
                groupBox54.Enabled = true;
                richTextBox1.Text = "posts";
                button2.Enabled = false;
                button3.Enabled = false;
                metroRadioButton5.Checked = false;

            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                groupBox54.Enabled = false;
                richTextBox1.Text = "Don't mix Profiles and Hashtags";
                button2.Enabled = true;
                button3.Enabled = true;
                metroRadioButton5.Checked = false;

            }
        }

        private void backgroundWorker8_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";

        }

        private void backgroundWorker9_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroLabel26.Text = "Ready..";

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked == true)
            {
                groupBox54.Enabled = false;
                richTextBox1.Text = "Don't mix Profiles and Hashtags";
                button2.Enabled = true;
                button3.Enabled = true;
                metroRadioButton5.Checked = false;

            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void metroRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton5.Checked == true)
            {
                button2.Text = "Add keyword";
                textBox2.Text = "Put keyword here";
                richTextBox1.Text = "";
                richTextBox1.Enabled = true;
                metroLabel1.Text = "Keyword";
                groupBox54.Enabled = false;
                metroRadioButton1.Enabled = false;
                metroRadioButton2.Enabled = false;
                metroRadioButton4.Enabled = false;
                groupBox23.Enabled = false;
                metroCheckBox1.Visible = false;
                metroCheckBox2.Enabled = false;
                groupBox25.Enabled = true;

                metroRadioButton3.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton16.Checked = false;
                metroRadioButton22.Checked = false;
                metroRadioButton17.Checked = false;
                metroRadioButton25.Checked = false;
                metroRadioButton28.Checked = false;
                metroRadioButton21.Checked = false;
                metroRadioButton23.Checked = false;
                metroRadioButton29.Checked = false;
                metroRadioButton27.Checked = false;


                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroRadioButton4.Visible = false;
                metroCheckBox2.Visible = false;

                richTextBox1.Height = 134;
                richTextBox1.Left = 15;
                richTextBox1.Top = 21;

            }
        }

        private void backgroundWorker23_DoWork(object sender, DoWorkEventArgs e)
        {
            int theNumber = 0;
            try
            {
                theNumber = Convert.ToInt32(textBox24.Text);

            }
            catch (Exception sdf)
            {
                theNumber = 0;
            }

            string folder = textBox1.Text;
            List<String> keywordList = new List<String>();

            Invoke(new Action(() => {

                foreach (var line in richTextBox1.Lines)
                {
                    keywordList.Add(line);
                }

            }));

            if (keywordCheck == 0)
            {
                keywordList.Remove(keywordList.Last());
            }

            foreach (var keyword in keywordList)
            {
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Loading images." + Environment.NewLine)));//Update URL list with links
                backgroundWorker18.WorkerReportsProgress = true; //Needed for progressbar
                int progress = 1;
                int maxImg = 0;
                int loaded = 0;
                string renderedContent = "";
                int max = 0;
                string bigImg = "";
                Invoke(new Action(() => metroLabel26.Text = "Working keyword " + keyword + ".."));

                PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();

                string proxy = metroTextBox1.Text;

                string auth = System.Text.RegularExpressions.Regex.Match(proxy, @"\-(.*)").Groups[1].Value;
                string proxyIp = System.Text.RegularExpressions.Regex.Match(proxy, @"(.*?)\-").Groups[1].Value;

                if (metroToggle2.Checked == true)
                {
                    service.Proxy = proxyIp;
                    service.ProxyType = "http";
                    service.ProxyAuthentication = auth;
                }

                service.HideCommandPromptWindow = true;
                service.IgnoreSslErrors = true;
                service.SslProtocol = "any";
                var options = new PhantomJSOptions();
                options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Linux; <Android Version>; <Build Tag etc.>) AppleWebKit/<WebKit Rev> (KHTML, like Gecko) Chrome/<Chrome Rev> Mobile Safari/<WebKit Rev>");


                //--------------------------------------Initialize page------------------------------------------------------


                using (IWebDriver driver = new PhantomJSDriver(service, options))
                {
                    driver.Manage().Window.Size = new Size(1920, 1000);

                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));


                    try
                    {
                        var url = Uri.EscapeUriString(keyword);

                        driver.Navigate().GoToUrl("https://unsplash.com/search/photos/" + url);

                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Page not loaded properly, please try again" + Environment.NewLine)));//Update URL list with links
                    }


                    Thread.Sleep(10000);


                    //--------------------------------------Initialize page------------------------------------------------------

                    //---------------------------------------Load content--------------------------------------------------------



                    do
                    {

                        for (int i = 0; i < 20; i++)
                        {
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                            Thread.Sleep(500);
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 700)");
                            Thread.Sleep(500);
                        }

                        try
                        {
                            renderedContent = driver.PageSource;
                            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                            doc1.LoadHtml(renderedContent);
                            HtmlNodeCollection aTags1 = doc1.DocumentNode.SelectNodes("//*[contains(@class, 'KW7g_')]/@data-ofi-src");

                            

                            if (loaded == aTags1.Count)
                            {
                                break;
                            }

                            if (theNumber != 0)
                            {
                                maxImg = int.Parse(textBox24.Text);
                                max = maxImg;
                            }
                            else if (theNumber == 0)
                            {
                                max = 5000;
                            }


                            //foreach (var lol in aTags1)
                            //{
                            //    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + lol.Attributes["data-ofi-src"].Value + Environment.NewLine)));//Update URL list with links

                            //}

                            //  driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot1.png", ImageFormat.Png);


                            loaded = aTags1.Count;
                        }
                        catch (Exception ex)
                        {
                          //  Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links
                            break;
                        }

           

                        Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Images loaded: " + loaded + Environment.NewLine)));//Update URL list with links


                    } while (loaded < max);

                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Downloading " + max + " images.." + Environment.NewLine)));//Update URL list with links


                    //---------------------------------------Load content--------------------------------------------------------

                    //-------------------------------------Download content------------------------------------------------------

                    try
                    {
                 //       driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\screenshot2.png", ImageFormat.Png);


                        HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                        doc2.LoadHtml(renderedContent);
                        int desc = 0;
                        HtmlNodeCollection aTags2 = doc2.DocumentNode.SelectNodes("//*[contains(@class, 'KW7g_')]/@data-ofi-src");

                        int imageNumber = 1;

                        foreach (var aTag in aTags2)
                        {
                            if (imageNumber == (max + 1))
                            {
                                break;
                            }
                            Invoke(new Action(() => metroLabel4.Text = "Working image: " + imageNumber + "/" + (max)));


                            bigImg = aTag.Attributes["data-ofi-src"].Value;
                            bigImg = bigImg.Replace("dpr=1&auto=format&fit=crop&w=376&h=251&q=60&cs=tinysrgb", "");

                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + bigImg + Environment.NewLine)));//Update URL list with links


                            if (backgroundWorker18.CancellationPending == false)
                            {

                                try
                                {
                                    using (WebClient webClient = new WebClient())
                                    {

                                        var result = webClient.DownloadData(bigImg);
                                        var contentType = webClient.ResponseHeaders["Content-Type"];
                                        contentType = contentType.Replace("image/", "");

                                        if (textBox4.Text == "")
                                        {
                                            webClient.DownloadFile(bigImg, folder + "/" + keyword + imageNumber + "." + contentType);//Downloads the images

                                        }
                                        else if (textBox4.Text != "")
                                        {
                                            webClient.DownloadFile(bigImg, folder + "/" + textBox4.Text + imageNumber + "." + contentType);//Downloads the images

                                        }
                                        desc++;
                                    }

                                }
                                catch (Exception ex)
                                {
                                   // Invoke(new Action(() => richTextBox1.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + ex + Environment.NewLine)));//Update URL list with links

                                }

                               

                                progress++;
                                imageNumber++;
                                Invoke(new Action(() => backgroundWorker18.ReportProgress(progress)));
                            }
                            else if (backgroundWorker18.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }

                            //-------------------------------------Download content------------------------------------------------------

                        }
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                textBox7.Text = fbd.SelectedPath;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker24.IsBusy)
            {
                if (textBox7.Text == "" || textBox6.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Height, width and folder cant be empty.");
                }
                else
                {
                    backgroundWorker24.RunWorkerAsync(2000);

                }

            }
        }

        private void backgroundWorker24_DoWork(object sender, DoWorkEventArgs e)
        {

            var files = Directory.GetFiles(textBox7.Text, "*.*", SearchOption.AllDirectories);
            int number = 1;
            List<string> imageFiles = new List<string>();
            foreach (string filename in files)
            {
                if (Regex.IsMatch(filename, @".jpg|.jpeg|.png|.gif$"))
                    imageFiles.Add(filename);
            }

            string beforeHeight = textBox5.Text;
            int height = Convert.ToInt32(beforeHeight);

            string beforeWidth = textBox6.Text;
            int width = Convert.ToInt32(beforeWidth);


            Image lol;

            foreach (var images in imageFiles)
            {

                try
                {

                    lol = Image.FromFile(images);

                    lol = ResizeImage(lol, width, height);

                    lol.Save(textBox7.Text + "/Image" + number + ".jpg");

                    number++;
                }
                catch (Exception f)
                {

                }

             
            }




        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker25.IsBusy)
            {
                if (textBox9.Text == "")
                {
                    MessageBox.Show("Please select a folder to save the image.");
                }
                else
                {
                    backgroundWorker25.RunWorkerAsync(2000);

                }

            }
        }

        private void backgroundWorker25_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string water = textBox9.Text;

                Image lol;

                Font font = new Font("Times New Roman", 48.0f);
                Color black = Color.FromName("black");
                Color white = Color.FromName("white");


                lol = DrawText(water, font, white, black);

                lol.Save(textBox8.Text + "/watermark.jpg");
            }
            catch (Exception f)
            {

            }

            


        }

        private Image DrawText(String text, Font font, Color textColor, Color backColor)
        {
            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            //measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString(text, font);

            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap((int)textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(backColor);

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            drawing.DrawString(text, font, textBrush, 0, 0);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                textBox8.Text = fbd.SelectedPath;

            }
        }

        private void textBox52_Leave(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            backgroundWorker26.RunWorkerAsync(2000);
        }

        private void backgroundWorker26_DoWork(object sender, DoWorkEventArgs e)
        {
            var service = ChromeDriverService.CreateDefaultService();

            ChromeOptions option = new ChromeOptions();

            service.HideCommandPromptWindow = true; option.AddArgument("--headless");
            option.AddArgument("--window-size=1920,2080");


            ChromeDriver driver = new ChromeDriver(service, option);
            string adress = "";



            driver.Navigate().GoToUrl("https://www.instagram.com/monsterenergy/?hl=sv");

            string renderedContent = driver.PageSource;

            //    driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\aaa.png");

            Thread.Sleep(5000);

            //     driver.TakeScreenshot().SaveAsFile(@"C:\Users\joma\Desktop\aaac.png");

            HtmlAgilityPack.HtmlDocument doc5 = new HtmlAgilityPack.HtmlDocument();
            doc5.LoadHtml(renderedContent);
            HtmlNodeCollection aTags6 = doc5.DocumentNode.SelectNodes("//img/@src");

            foreach (var lol in aTags6)
            {
                Invoke(new Action(() => richTextBox2.AppendText(lol.Attributes["src"].Value + Environment.NewLine)));

            }

            // string html = "<style>h2, h3 {display: inline;margin - right: 50px;}</style><html><h1> " + aTags6[0].InnerText + "</h1><h3>Utv.i dag %</h3><h3>Utv.i dag SEK</h3><h3>Köp</h3><h3>Sälj</h3><h3>Senast</h3><h3>Högst</h3><h3>Lägst</h3><h3>Tid</h3></br><h2 style = 'color: #009ECF;'>" + aTags7[0].InnerText + "</h2><h2 style = 'color: #009ECF;'>" + aTags8[0].InnerText + "</h2><h2>" + aTags9[0].InnerText + "</h2><h2>" + aTags10[0].InnerText + "</h2><h2>" + aTags11[0].InnerText + "</h2><h2>" + aTags12[0].InnerText + "</h2><h2>" + aTags13[0].InnerText + "</h2></html> ";

            //  string test = aTags6[0].InnerText + aTags7[0].InnerText + aTags8[0].InnerText + aTags9[0].InnerText + aTags10[0].InnerText + aTags11[0].InnerText + aTags12[0].InnerText;

            //  string test2 = "<style>h2, h3 {display: inline; text-align: center;}</style><html><h1>" + aTags6[0].InnerText + "</h1><div style = '1000px;'><div style = 'width: 150px; float:left;'><div style = 'display: inline;'><h3>Utv.i dag %</h3></div></br><div style = 'display: inline;'><h2 style = 'color: #009ECF;'>" + aTags7[0].InnerText + "</h2></div></div><div style = 'width: 150px; float:left;'><div style = 'display: inline;'><h3>Utv.i dag SEK</h3></div></br><div style = 'display: inline;'><h2 style = 'color: #009ECF;'>" + aTags8[0].InnerText + "</h2></div></div><div style = 'width: 150px; margin-left: 0px; float:left;'><div style = 'display: inline;'><h3> Köp </h3></div></br><div style = 'display: inline;'><h2>" + aTags9[0].InnerText + "</h2></div></div><div style = 'width: 150px; margin-left: 0px; float:left;'><div style = 'display: inline;'><h3> Sälj </h3></div></br><div style = 'display: inline;'><h2>" + aTags10[0].InnerText + "</h2></div></div><div style = 'width: 150px; margin-left: 0px; float:left;'><div style = 'display: inline;'><h3> Senast </h3></div></br><div style = 'display: inline;'><h2>" + aTags11[0].InnerText + "</h2></div></div><div style = 'width: 150px; margin-left: 0px; float:left;'><div style = 'display: inline;'><h3> Tid </h3></div></br><div style = 'display: inline;'><h2> " + aTags12[0].InnerText + "</h2></div></div></div></html>";


          




            driver.Quit();
        }

        private void backgroundWorker27_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                ChromeDriverService service = ChromeDriverService.CreateDefaultService();

            //var options = new ChromeOptions
            //{
            //    BinaryLocation = @"F:\visual studio\InstaScraper - new 2018-07-21\InstaScraper\bin\Debug\chromedriver.exe",


            //};
            Invoke(new Action(() => richTextBox2.AppendText(Path.GetDirectoryName(Application.ExecutablePath) + Environment.NewLine)));//Update URL list with links

            var options = new ChromeOptions();


            options.AddArguments("--headless", "window-size=1024,768", "--no-sandbox", "--disable-dev-shm-usage");

            service.HideCommandPromptWindow = true;

 

           
                ChromeDriver driver = new ChromeDriver(service, options);


                driver.Navigate().GoToUrl("https://www.instagram.com/explore/tags/dog");
                string renderedContent;
                Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": Images Loaded: " + Environment.NewLine)));//Update URL list with links


                renderedContent = driver.PageSource;
                HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                doc2.LoadHtml(renderedContent);
                HtmlNodeCollection aTags4 = doc2.DocumentNode.SelectNodes("//*[contains(@class, 'v1Nh3 kIKUG  _bz0w')]/a/@href");



                foreach (var lol in aTags4)
                {
                    string renderedContent2 = "";
                    Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": Images Loaded: " + lol.Attributes["href"].Value + Environment.NewLine)));//Update URL list with links

                    driver.Navigate().GoToUrl("https://www.instagram.com" + lol.Attributes["href"].Value);
                    Thread.Sleep(4000);


                    renderedContent2 = driver.PageSource;
                    HtmlAgilityPack.HtmlDocument doc3 = new HtmlAgilityPack.HtmlDocument();
                    doc3.LoadHtml(renderedContent2);
                    HtmlNodeCollection aTags2 = doc3.DocumentNode.SelectNodes("//*[contains(@class, 'KL4Bh')]/img/@src");


                    if (aTags2 != null)
                    {

                        foreach (var lol2 in aTags2)
                        {
                            Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": Images Loaded: " + lol2.Attributes["src"].Value + Environment.NewLine)));//Update URL list with links



                        }
                    }



                }
            }
            catch (Exception f)
            {
                Invoke(new Action(() => richTextBox2.AppendText(f + Environment.NewLine)));//Update URL list with links

            }




        }

        private void button15_Click(object sender, EventArgs e)
        {
            backgroundWorker27.RunWorkerAsync(2000);
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=F4Y4VNPC67N8L&source=url");



        }
    }

   
}
