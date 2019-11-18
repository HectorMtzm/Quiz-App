using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Quizz_App.DataModels;

namespace Quizz_App.Helper
{
    public class QuizzHelper
    {
        List<Questions> History;
        List<Questions> Business;
        List<Questions> Geography;
        List<Questions> Space;
        List<Questions> Engineering;
        List<Questions> Programming;

        void initializeHistory()
        {
            History = new List<Questions>();
            History.Add(new Questions { QuizQuestion = "World War I began in which year?",
                Answer = "1914",
                OptionA = "1923", OptionB = "1938",
                OptionC = "1917", OptionD = "1914"});
            History.Add(new Questions
            {
                QuizQuestion = "Adolf Hitler was born in which country? ",
                Answer = "Austria",
                OptionA = "France", OptionB = "Germany",
                OptionC = "Austria", OptionD = "Hungary"
            });
            History.Add(new Questions
            {
                QuizQuestion = "John F. Kennedy was assassinated in:",
                Answer = "Dallas",
                OptionA = "New York", OptionB = "Austin",
                OptionC = "Dallas", OptionD = "Miami"
            });
            History.Add(new Questions
            {
                QuizQuestion = "Who fought in the war of 1812? ",
                Answer = "Andrew Jackson",
                OptionA = "Arthur Wellsley", OptionB = "Otto von Bismarck",
                OptionC = "Napoleon", OptionD = "Andrew Jackson"
            });
            History.Add(new Questions
            {
                QuizQuestion = "Which general famously stated 'I shall return?'",
                Answer = "Douglas MacArthur",
                OptionA = "Omar Bradley", OptionB = "George Patton",
                OptionC = "Bull Halsey", OptionD = "Douglas MacArthur"
            });
        }

        void initilizeGeography()
        {
            Geography = new List<Questions>();
            Geography.Add(new Questions
            {
                QuizQuestion = "Which of the following colours does NOT appear on the South African flag?",
                Answer = "Orange",
                OptionA = "Green",
                OptionB = "Black",
                OptionC = "Orange",
                OptionD = "Red"
            });
            Geography.Add(new Questions
            {
                QuizQuestion = "What is the capital of Australia? ",
                Answer = "Canberra",
                OptionA = "Canberra",
                OptionB = "Melbourne",
                OptionC = "Adelaide",
                OptionD = "Sydney"
            });
            Geography.Add(new Questions
            {
                QuizQuestion = "By area, what is the smallest country on the planet?",
                Answer = "Vatican City",
                OptionA = "Vatican City",
                OptionB = "Monaco",
                OptionC = "Nauru",
                OptionD = "Peru"
            });
            Geography.Add(new Questions
            {
                QuizQuestion = "Which of the following countries does NOT share a border with Brazil? ",
                Answer = "Chile",
                OptionA = "Argentina",
                OptionB = "Bolivia",
                OptionC = "Peru",
                OptionD = "Chile"
            });
            Geography.Add(new Questions
            {
                QuizQuestion = "What is the name of the tallest uninterrupted waterfall in the world? ",
                Answer = "Angel Fallas",
                OptionA = "Niagara Fallas",
                OptionB = "Angel Fallas",
                OptionC = "Uruguay national falls",
                OptionD = "Triangle falls"
            });
        }

        void initilizeBusiness()
        {
            Business = new List<Questions>();
            Business.Add(new Questions
            {
                QuizQuestion = "This country was Mexico's second-largest importing partner in terms of US dollars in 2017, only behind the United States. ",
                Answer = "China",
                OptionA = "China",
                OptionB = "Brazil",
                OptionC = "Japan",
                OptionD = "Canada"
            });
            Business.Add(new Questions
            {
                QuizQuestion = "This country has the highest proven reserves of crude oil.",
                Answer = "Venezuela",
                OptionA = "United States",
                OptionB = "Saudi Arabia",
                OptionC = "Venezuela",
                OptionD = "Iran"
            });
            Business.Add(new Questions
            {
                QuizQuestion = "Which one of the following countries gained its independence most recently?",
                Answer = "South Sudan",
                OptionA = "East Timor",
                OptionB = "Kosovo",
                OptionC = "Palau",
                OptionD = "South Sudan"
            });
            Business.Add(new Questions
            {
                QuizQuestion = "Which country has the highest industrial production growth rate in the world?",
                Answer = "Libya",
                OptionA = "Sierre Leone",
                OptionB = "Libya",
                OptionC = "Yemen",
                OptionD = "Kyrgystan"
            });
            Business.Add(new Questions
            {
                QuizQuestion = "This is the largest stock exchange in the world in terms of market capitalization.",
                Answer = "NYSE",
                OptionA = "TOE",
                OptionB = "NASDAQ",
                OptionC = "HKSE",
                OptionD = "NYSE"
            });
        }

        void initilizeProgramming()
        {
            Programming = new List<Questions>();
            Programming.Add(new Questions
            {
                QuizQuestion = "",
                Answer = "",
                OptionA = "",
                OptionB = "",
                OptionC = "",
                OptionD = ""
            });
            Programming.Add(new Questions
            {
                QuizQuestion = "",
                Answer = "",
                OptionA = "",
                OptionB = "",
                OptionC = "",
                OptionD = ""
            });
            Programming.Add(new Questions
            {
                QuizQuestion = "",
                Answer = "",
                OptionA = "",
                OptionB = "",
                OptionC = "",
                OptionD = ""
            });
            Programming.Add(new Questions
            {
                QuizQuestion = "",
                Answer = "",
                OptionA = "",
                OptionB = "",
                OptionC = "",
                OptionD = ""
            });
            Programming.Add(new Questions
            {
                QuizQuestion = "",
                Answer = "",
                OptionA = "",
                OptionB = "",
                OptionC = "",
                OptionD = ""
            });
        }

        void initilizeEngineering()
        {
            Engineering = new List<Questions>();
            Engineering.Add(new Questions
            {
                QuizQuestion = "",
                Answer = "",
                OptionA = "",
                OptionB = "",
                OptionC = "",
                OptionD = ""
            });
            Engineering.Add(new Questions
            {
                QuizQuestion = "",
                Answer = "",
                OptionA = "",
                OptionB = "",
                OptionC = "",
                OptionD = ""
            });
            Engineering.Add(new Questions
            {
                QuizQuestion = "",
                Answer = "",
                OptionA = "",
                OptionB = "",
                OptionC = "",
                OptionD = ""
            });
            Engineering.Add(new Questions
            {
                QuizQuestion = "",
                Answer = "",
                OptionA = "",
                OptionB = "",
                OptionC = "",
                OptionD = ""
            });
            Engineering.Add(new Questions
            {
                QuizQuestion = "",
                Answer = "",
                OptionA = "",
                OptionB = "",
                OptionC = "",
                OptionD = ""
            });
        }

        void initilizeSpace()
        {
            Space = new List<Questions>();
            Space.Add(new Questions
            {
                QuizQuestion = "Who was the first man to ever walk on the Moon?",
                Answer = "Niel Armstrong",
                OptionA = "Uchenna Nnodim",
                OptionB = "Niel Armstrong",
                OptionC = "Benjamin Franklin",
                OptionD = "Pele Pele"
            });
            Space.Add(new Questions
            {
                QuizQuestion = "The coldest and farthest Planet from the Sun is ?",
                Answer = "Pluto",
                OptionA = "Earth",
                OptionB = "Pluto",
                OptionC = "Neptune",
                OptionD = "Saturn"
            });
            Space.Add(new Questions
            {
                QuizQuestion = "The galaxy that contains Solar System which Earth belongs to is called what?",
                Answer = "Milky Way",
                OptionA = "Chocolate Path",
                OptionB = "Phantom Zone",
                OptionC = "Milky Way",
                OptionD = "Solar Container"
            });
            Space.Add(new Questions
            {
                QuizQuestion = "How many days does it take the Earth to complete her orbit",
                Answer = "365 Days",
                OptionA = "365 Days",
                OptionB = "30 Days",
                OptionC = "272 Days",
                OptionD = "None of the Above"
            });
            Space.Add(new Questions
            {
                QuizQuestion = "An explosion which leads to gigantic explosion throwing star's outer layers are thrown out is called",
                Answer = "Supernova",
                OptionA = "Black hole",
                OptionB = "Double ring",
                OptionC = "Massive Explosion",
                OptionD = "Supernova"
            });
        }

        public List<Questions> GetQuizQuestions(string topic)
        {
            List<Questions> quizList = new List<Questions>();

            switch (topic)
            {
                case "History":
                    initializeHistory();
                    return History;

                case "Space":
                    initilizeSpace();
                    return Space;

                case "Business":
                    initilizeBusiness();
                    return Business;

                case "Programming":
                    initilizeProgramming();
                    return Programming;

                case "Engineering":
                    initilizeEngineering();
                    return Engineering;

                case "Geography":
                    initilizeGeography();
                    return Geography;

                default:
                    return quizList;

            }
        }

        public string GetTopicDescription(string topic)
        {
            string topicDescription="";

            switch (topic)
            {
                case "History":
                    topicDescription = "History is cool";
                    break;

                case "Space":
                    topicDescription = "Space is cool";
                    break;

                case "Programming":
                    topicDescription = "Programming is cool";
                    break;

                case "Business":
                    topicDescription = "Business is cool";
                    break;

                case "Engineering":
                    topicDescription = "Engineering is cool";
                    break;

                case "Geography":
                    topicDescription = "Geography is cool";
                    break;

            }

            return topicDescription;
        }

        public int GetImage(string topic)
        {
            int imageFailedId = 0;
            switch (topic)
            {
                case "History":
                    return Resource.Drawable.history;

                case "Space":
                    return Resource.Drawable.space;

                case "Business":
                    return Resource.Drawable.business;

                case "Programming":
                    return Resource.Drawable.programming;

                case "Engineering":
                    return Resource.Drawable.engineering;

                case "Geography":
                    return Resource.Drawable.geography;

                default:
                    return imageFailedId;
            }
        }
    }
}