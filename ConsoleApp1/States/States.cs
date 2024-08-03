namespace ConsoleApp1
{
    class State
    {
        Stack<State> states;

        public State( Stack<State> states )
        {
            this.states = states;
        }
    }
}