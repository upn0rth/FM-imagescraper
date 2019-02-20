using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaScraper
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync(2000);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker2.IsBusy == false)
            {
                backgroundWorker2.RunWorkerAsync(2000);
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke(new Action(() => richTextBox1.AppendText("starting" + Environment.NewLine)));//Update URL list with links

            PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();
            string realType = "";

            service.HideCommandPromptWindow = true;
            service.IgnoreSslErrors = true;
            service.SslProtocol = "any";
            var options = new PhantomJSOptions();
            options.AddAdditionalCapability("phantomjs.page.settings.userAgent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/25.0");

            using (IWebDriver driver = new PhantomJSDriver(service,options))
            {
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
                string renderedContent = "";

                driver.Navigate().GoToUrl("http://amateurfap.net");

                Thread.Sleep(5000);

                for (int i = 2; i < 10000; i++)
                {
                  
                    renderedContent = driver.PageSource;
                    HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                    doc1.LoadHtml(renderedContent);
                    HtmlNodeCollection aTags4 = doc1.DocumentNode.SelectNodes("//img/@src");

                    if (aTags4 != null)
                    {
                        foreach (var link in aTags4)
                        {

                            WebRequest objRequest = System.Net.HttpWebRequest.Create(link.Attributes["src"].Value);
                            WebResponse objResponse = objRequest.GetResponse();
                            var contentType = objResponse.ContentType;
                            contentType = contentType.Replace("image/", "");
                            // realType = link.Attributes["src"].Value.Replace("jpg", contentType);
                            Invoke(new Action(() => richTextBox2.AppendText(contentType + Environment.NewLine)));//Update URL list with links


                            if (contentType.Contains("jpg"))
                            {
                                Invoke(new Action(() => richTextBox2.AppendText(link.Attributes["src"].Value + Environment.NewLine)));//Update URL list with links

                                try
                                {
                                    byte[] buffer = new byte[32768];
                                    using (Stream input = objResponse.GetResponseStream())
                                    {
                                        using (FileStream output = new FileStream(@"C:/Users/JoMa/Desktop/images" + "/" + "image" + i + "." + contentType,
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
                                catch (Exception s)
                                {

                                }
                            }

                            //Invoke(new Action(() => richTextBox2.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + http + Environment.NewLine)));//Update URL list with links   
                            
                        }
                    }

                    try
                    {
                        driver.FindElement(By.XPath("//a[text()='" + i + "']")).Click();
                    }
                    catch (Exception lol)
                    {
                        Invoke(new Action(() => richTextBox1.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "No more pages found. " + Environment.NewLine)));//Update URL list with links
                    }

                    Invoke(new Action(() => richTextBox1.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Moving to next page(" + i + ")" + Environment.NewLine)));//Update URL list with links

                    i++;





                }





            }
        }
    }
}
