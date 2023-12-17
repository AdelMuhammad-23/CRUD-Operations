using CRUD;
    internal class program
{
        static bool endloop = false;
    static void Main(string[] args) 
    {
        
        List<User> users = new List<User>();
        User user = new User();
        while (endloop !=true)
        {
            Console.WriteLine("[1]Create\n[2]Reade\n[3]Update\n[4]Delete");
            string input = Console.ReadLine();
            int chose;

            if ( int.TryParse(input,out chose))
            {
                
            }
            if (chose == 1)
            {
                user.AddUser(users);
            }
            else if (chose == 2)
            {
                user.PrintAllUsers(users);
            }
            else if (chose == 3)
            {
                user.UpdateUser(users);
            }
            else if (chose == 4)
            {
                user.DeleteUser(users);
            }
            else
            {

                Console.WriteLine("========================================================");
                Console.WriteLine("                     Invaled Number                     ");
                Console.WriteLine("========================================================");
            }
            EndProgram(users);

        } 
}


    static void EndProgram(List<User> users)
    {
        Console.WriteLine("Do You Want to do something else?");
        Console.WriteLine("Enter Y for Yes || N for No");
        string chose = Console.ReadLine();
        if (chose == "Y" || chose == "y") 
        {
            Console.WriteLine("========================================================");
        }
        else
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("                     Finished.                           ");
            Console.WriteLine("========================================================");
            endloop = true;
        }

    }
}