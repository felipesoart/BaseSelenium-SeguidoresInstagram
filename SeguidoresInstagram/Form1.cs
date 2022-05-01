using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = System.Windows.Forms.Keys;


namespace SeguidoresInstagram
{
    public partial class Form1 : Form
    {

        //private IJavaScriptExecutor js;        
       
        string dataVerificacao =ConfigurationManager.AppSettings["Version"].Replace("a", "1").Replace("s", "2").Replace("d", "3").Replace("f", "4").Replace("g", "5")
            .Replace("z", "6").Replace("x", "7").Replace("c", "8").Replace("v", "9").Replace("b", "0")
            + "/01/20" + ConfigurationManager.AppSettings["Version2"].Replace("a", "1").Replace("s", "2").Replace("d", "3").Replace("f", "4").Replace("g", "5")
            .Replace("z", "6").Replace("x", "7").Replace("c", "8").Replace("v", "9").Replace("b", "0") + " 12:00:00 AM";//se a dataGoogleWeb for < dataVerificacao a licenca é false(deixa sempre um mes a mas do dia atual)
        

        public Form1()
        {
            try
            {
                string hostNameconfiga = ConfigurationManager.AppSettings["hostName"];
                string hostNameSistema = Environment.MachineName;
                InitializeComponent();
                IWebDriver driver = new ChromeDriver(@"C:\");
                driver.Navigate().GoToUrl("https://www.google.com/search?client=opera&q=data&sourceid=opera&ie=UTF-8&oe=UTF-8&pccc=1");

                if (!driver.Title.Equals("data - Pesquisa Google"))
                {
                    throw new Exception("Esta não é a página de entrada");
                }

                IWebElement data = driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div[1]/div/span"));

                var cultureInfo = new CultureInfo("pt-BR");
                string dateString = data.Text.Replace(" de ", " ");
                DateTime dataGoogleWeb = DateTime.Parse(dateString, cultureInfo);

                driver.Quit();

                if (DateTime.Parse(dataVerificacao) >= dataGoogleWeb && hostNameSistema == hostNameconfiga)
                {
                    iniciarSeguir.Enabled = true;
                    button1.Enabled = true;
                }
                else
                {
                    iniciarSeguir.Enabled = false;
                    button1.Enabled = false;
                }
            }
            catch (Exception)
            {
                throw;
            }     
            
        }

        private void iniciarSeguir_Click(object sender, EventArgs e)
        {
            seguir();
        }

        public void seguir()
        {
            IWebDriver driver = new ChromeDriver(@"C:\");
            //driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/");
            driver.Navigate().GoToUrl("https://www.instagram.com");
            
            if (!driver.Title.Equals("Instagram"))
            {
                throw new Exception("Esta não é a página de entrada");
            }

            driver.Manage().Window.Maximize();//deixa a tela grande
            System.Threading.Thread.Sleep(20000);//espera 30s
            //js = (IJavaScriptExecutor)driver;

            driver.Navigate().GoToUrl("https://www.instagram.com/" + txtPesquisar.Text + "/");
            //4 para clicar em um botao         
            //IWebElement element = driver.FindElement(By.ClassName("XTCLo"));

            //element.SendKeys(txtPesquisar.Text);  //variavel do pesquisar
                                               
            System.Threading.Thread.Sleep(4000);//espera 30s
            
            //IWebElement primeiroElementoLista = driver.FindElement(By.ClassName("-qQT3"));
            //primeiroElementoLista.Click();
            //System.Threading.Thread.Sleep(5000);
            IWebElement seguidores = driver.FindElement(By.XPath("/html/body/div[1]/section/main/div/header/section/ul/li[2]/a"));
            seguidores.Click();

            System.Threading.Thread.Sleep((int)tempoEspera.Value); // inicia com 15000 (15s) e vai ate 60000 (60s)
            int nl = (int)numeroLinha.Value; // inicia com 2 e vai ate 20000
                       
            for (int i = 0; i < 500; i++)
            {
                
                //  IWebElement seguir = driver.FindElement(By.XPath("/ html / body / div[6] / div / div / div[2] / ul / div / li["+nl+"] / div / div[3] / button"));
                //IWebElement seguir = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div[2]/ul/div/li[1]/div/div[3]/button;
                //    seguir.Click();
                //    System.Threading.Thread.Sleep(3000);

                //verificar
                //var seguindo = driver.FindElement(By.CssSelector(".HoLwm"));

                //var seguindo = driver.FindElement(By.XPath("/html/body/div[7]/div/div/div/div[3]/button[2]"));
                //var seguir = driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP"));

                //driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Click();
                // System.Threading.Thread.Sleep(15000);
                //12 decer ou subir o scroll - isgrP
                //System.Threading.Thread.Sleep(3000);
                // var seguir = driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP"));
                //var seguir = driver.FindElement(By.CssSelector(".sqdOP"));
                //driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Click();             

                System.Threading.Thread.Sleep(3000);

                if (driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Text == "Seguindo"
                || driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Text == "Solicitado"
                || driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Text == "A seguir"
                || driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Text == "Pedido enviado")

                {
                    driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Click();
                    System.Threading.Thread.Sleep(3000);
                    driver.FindElement(By.CssSelector(".HoLwm")).Click();
                    System.Threading.Thread.Sleep(8000);

                    nl++;
                }
                else
                {
                    System.Threading.Thread.Sleep(3000);
                    driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Click();
                    System.Threading.Thread.Sleep(8000);

                    nl++;
                }

            }

            driver.Quit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seguindo();
        }

        public void seguindo()
        {
            IWebDriver driver = new ChromeDriver(@"C:\");
            //driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/");
            driver.Navigate().GoToUrl("https://www.instagram.com");
            System.Threading.Thread.Sleep(3000);
            if (!driver.Title.Equals("Instagram"))
            {
                throw new Exception("Esta não é a página de entrada");
            }

            driver.Manage().Window.Maximize();//deixa a tela grande
            System.Threading.Thread.Sleep(20000);//espera 30s
                                                 //js = (IJavaScriptExecutor)driver;


            driver.Navigate().GoToUrl("https://www.instagram.com/"+ txtPesquisar2.Text +"/");

            //4 para clicar em um botao         
            //IWebElement element = driver.FindElement(By.ClassName("XTCLo"));

            //element.SendKeys(txtPesquisar.Text);  //variavel do pesquisar

            System.Threading.Thread.Sleep(4000);//espera 30s

            //IWebElement primeiroElementoLista = driver.FindElement(By.ClassName("-qQT3"));
            //primeiroElementoLista.Click();
            //System.Threading.Thread.Sleep(5000);
            IWebElement seguindo = driver.FindElement(By.XPath("/html/body/div[1]/section/main/div/header/section/ul/li[3]/a"));
            seguindo.Click();


            System.Threading.Thread.Sleep((int)tempoEspera2.Value); // inicia com 15000 (15s) e vai ate 60000 (60s)
            int nl = (int)numeroLinha2.Value; // inicia com 1 e vai ate 20000
                                              //IWebElement div = ;

            //IWebElement seguindo = driver.FindElement(By.XPath("/html/body/div[1]/section/main/div/header/section/ul/li[3]/a"));


            //IJavaScriptExecutor js = div as IJavaScriptExecutor;
            //IJavaScriptExecutor js = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div[3]")) as IJavaScriptExecutor;

            
            for (int i = 0; i < 500; i++)
            {              

                //  IWebElement seguir = driver.FindElement(By.XPath("/ html / body / div[6] / div / div / div[2] / ul / div / li["+nl+"] / div / div[3] / button"));
                //IWebElement seguir = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div[2]/ul/div/li[1]/div/div[3]/button;
                //    seguir.Click();
                //    System.Threading.Thread.Sleep(3000);

                //verificar
                //var seguindo = driver.FindElement(By.CssSelector(".HoLwm"));

                //var seguindo = driver.FindElement(By.XPath("/html/body/div[7]/div/div/div/div[3]/button[2]"));
                //var seguir = driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP"));

                //driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Click();
                // System.Threading.Thread.Sleep(15000);
                //12 decer ou subir o scroll - isgrP
                //System.Threading.Thread.Sleep(3000);
                // var seguir = driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP"));
                //var seguir = driver.FindElement(By.CssSelector(".sqdOP"));
                //driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Click();            

                //js.ExecuteScript("window.scrollBy(0,50);");
                System.Threading.Thread.Sleep(3000);
               
                    driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Click();
                    System.Threading.Thread.Sleep(3000);
                    driver.FindElement(By.CssSelector(".-Cab_")).Click();
                    System.Threading.Thread.Sleep(8000);

                    nl++;
               
                //else
                //{
                //    System.Threading.Thread.Sleep(3000);
                //    driver.FindElement(By.CssSelector("li:nth-child(" + nl + ") .sqdOP")).Click();
                //    System.Threading.Thread.Sleep(12000);

                //    nl++;
                //}

            }

            driver.Quit();
        }

        
    }
}
