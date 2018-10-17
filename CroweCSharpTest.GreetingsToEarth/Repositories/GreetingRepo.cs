using CroweCSharpTest.GreetingsToEarthWebsite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CroweCSharpTest.GreetingsToEarthWebsite.Repositories
{
    public class GreetingRepo
    {

        private const string GREETING_DEFAULT = "Hello World";

        public Greeting GetGreeting()
        {

            var retGreeting = new Greeting();

            string value = ConfigurationManager.AppSettings["GreetingText"];

            if (!string.IsNullOrEmpty(value))
                retGreeting.Text = value;
            else
                retGreeting.Text = GREETING_DEFAULT;

            value = ConfigurationManager.AppSettings["GreetingTitle"];

            if (!string.IsNullOrEmpty(value))
                retGreeting.Title = value;
            else
                retGreeting.Title = GREETING_DEFAULT;
            
            return retGreeting;

        }
    }
}