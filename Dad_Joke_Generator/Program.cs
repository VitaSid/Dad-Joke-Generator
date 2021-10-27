using System;
using System.Collections.Generic;

namespace Dad_Joke_Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> questions = new List<string>
            {
                "Dad, did you get a haircut?",
                "How do you get a squirrel to like you?",
                "Why don't eggs tell jokes?",
                "What do you call someone with no body and no nose?",
                "Why couldn't the bicycle stand up by itself",
                "What kind of shoes do ninjas wear?",
                "How does a penguin build its house?",
                "Why did the math book look so sad?",
                "How many tickles does it take to make an octopus laugh?",
                "Did you hear about the guy who invented the knock-knock joke?"
            };

            List<string> punchlines = new List<string>
            {
                "No, I got them all cut!",
                "Act like a nut.",
                "They'd crack each other up.",
                "Nobody knows.",
                "It was two tired.",
                "Sneakers!",
                "Igloos it together.",
                "Because of all of its problems!",
                "Ten tickles.",
                "He won the 'no-bell' prize."
            };

            var game = "y";
            while (game == "y")
            {
                Console.WriteLine("Please, select from these options:");
                Console.WriteLine("Enter 'all', if you would like to see all jokes.");
                Console.WriteLine("Enter 'random', if you would like to see a random joke.");
                Console.WriteLine("Enter 'chosen', if you would like to see a joke of your choice.");
                Console.WriteLine("Enter 'count', if you would like to know a number of jokes that we have.");
                Console.WriteLine("Enter 'mix', if you would like to see randomly paired question and punchline.");
                                                
                string usersChoice = Console.ReadLine();

                if (usersChoice == "all")
                {
                    for (int i = 0; i < questions.Count; i++)
                    {
                        Console.Write(questions[i] + " ");
                        Console.WriteLine(punchlines[i]);
                    } 
                }
                else if (usersChoice == "random")
                {
                    var random = new Random();
                    int index = random.Next(questions.Count);
                    Console.Write(questions[index] + " ");
                    Console.Write(punchlines[index] + " ");                    
                }
                else if (usersChoice == "chosen")
                {
                    Console.WriteLine("Enter index from 0 to 9.");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.Write(questions[index] + " ");
                    Console.Write(punchlines[index] + " ");                  
                }
                else if (usersChoice == "count")
                {
                    Console.WriteLine("We have " + punchlines.Count + " dad jokes in this game.");                    
                }
                else if (usersChoice == "mix")
                {
                    var random = new Random();
                    int indexQuestions = random.Next(questions.Count);
                    int indexPunchlines = random.Next(punchlines.Count);
                    Console.Write(questions[indexQuestions] + " ");
                    Console.Write(punchlines[indexPunchlines] + " ");                    
                }                                
                Console.WriteLine("\nTry one more time? Enter 'y', if yes, any other key, if no.");
                game = Console.ReadLine();                
            }
        }                                                                                                                                 
    }
            //     Part Two - Documentation.
            //
            //     Open Visual Studio Code Editor.
            //     Click on selection "Open project or solution".
            //     Double click on the folder Dad_Joke_Generator.
            //     Double click on the file Dad_Joke_Generator.sln.
            //     Click on the "Start" button at the top of the Visual Studio window top.
            //     Follow further instructions in the Console. 
}

