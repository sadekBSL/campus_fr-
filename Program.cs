using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    static void Main(string[] args)
    {
        // Instancier le navigateur Chrome
        IWebDriver navigateur = new ChromeDriver();

        // Ouvrir la page Kayak
        navigateur.Navigate().GoToUrl("https://www.kayak.fr/");

        // Attendre que la page se charge complètement (optionnel)
        System.Threading.Thread.Sleep(5000); // Attendre 2 secondes

        // Identifier le bouton et cliquer dessus
        IWebElement bouton = navigateur.FindElement(By.XPath("/html/body/div[5]/div/div[2]/div/div/div[3]/div/div[1]/button[1]/div/div"));
        bouton.Click();

        // Attendre que l'utilisateur appuie sur la touche Entrée avant de fermer le navigateur (optionnel)
        Console.WriteLine("Appuyez sur Entrée pour fermer le navigateur...");
        Console.ReadLine();

        // Fermer le navigateur
        navigateur.Quit();
    }
}
