namespace guess_the_password_hack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "X", "X", "X", "X" };
            int passwordFirst, passwordSecond, passwordThree, passwordLast; 
            int programmPasswordFirst=0,programmPasswordSecond=0,programmPasswordThree=0,programmPasswordLast=0, rounds = 0;
            Random random = new Random();
            passwordFirst = random.Next() & 9;
            passwordSecond = random.Next() & 9;
            passwordThree = random.Next() & 9;
            passwordLast = random.Next() & 9;
            //Console.WriteLine($"Пароль {passwordFirst}{passwordSecond}{passwordThree}{passwordLast}"); // небольшая отладка
            while (arr[0]=="X" || arr[1]=="X" || arr[2] == "X" || arr[3] == "X")
            {
                rounds++;

                
                if (programmPasswordFirst== passwordFirst)
                {
                    arr[0] = passwordFirst.ToString();
                }
                if (programmPasswordSecond == passwordSecond)
                {
                    arr[1] = passwordSecond.ToString();
                }
                if (programmPasswordThree == passwordThree)
                {
                    arr[2] = passwordThree.ToString();
                }
                if (programmPasswordLast == passwordLast)
                {
                    arr[3] = passwordLast.ToString();
                }
                programmPasswordFirst++;
                programmPasswordSecond++;
                programmPasswordThree++;
                programmPasswordLast++;
            }
            Console.WriteLine($"Пароль {arr[0]}{arr[1]}{arr[2]}{arr[3]} подобран с {rounds}-й попытки");
        }
    }
}
