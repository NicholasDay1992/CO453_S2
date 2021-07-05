using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    class NetworkApp
    {
        int PostCount = 0;
        NewsFeed news = new NewsFeed();

        string[] menuChoices = { "Add", "Display" };
        public NetworkApp()
        {
            while(true)
            {
                DisplayMenu();
                GetChoice();
            }
        }
        public void DisplayMenu()
        {
            ConsoleHelper.OutputMenu(menuChoices);
            
        }
        public void GetChoice()
        {
            string input = Console.ReadLine();
            ExecuteChoice(input);
        }

        public void ExecuteChoice(string choice)
        {
            if (choice == "Add")
            {
                string author = ConsoleHelper.InputString("Please enter the Author: ");
                string message = ConsoleHelper.InputString("Please enter a message: ");
                PostCount++;
                MessagePost post = new MessagePost(author, message, PostCount);
                news.AddMessagePost(post);
                Console.WriteLine("Message added");
            }
            if (choice == "Display")
            {
                news.Display();
            }
        }

    }

}
