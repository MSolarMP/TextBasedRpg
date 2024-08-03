using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace ConsoleApp1
{
    class Game
    {
        //Variables
        private bool end;
        public bool End
        {
            get { return end; }
            set { end = value; }
        }

         private Stack<State> states = new Stack<State>();

        private void initVariables()
        {
            this.end = false;
        }

        private void initStates()
        {
             this.states.Clear();
            this.states.Push(new State(this.states));
        }


        //Constructors and Destructors
        public Game()
        {
            this.initVariables();
            this.initStates();

            Console.WriteLine("Hello from the Game Class");
        }

        public void Run()
        {
              while (this.end == false)
            {
                Console.WriteLine("Type an option: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                    this.end = true;
                else
                    Console.WriteLine("You inputted: " + number);
            }

            Console.WriteLine("Ending Game...");
        }
    }
}