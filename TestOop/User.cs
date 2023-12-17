using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class User
    {
        public string userName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

        public  void AddUser(List <User> users)
        {
            
            Console.WriteLine("====================== Add User ======================");
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Email: ");
            string Email = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            string PhoneNumber = Console.ReadLine();
            User newUser = new User()
            {
                userName = Name,
                email = Email,
                phoneNumber = PhoneNumber
            };
            users.Add(newUser);
            Console.WriteLine("====================== User information Entered ======================");
            Console.WriteLine($"Name: {newUser.userName}\nEmail: {newUser.email}\nPhone Number:  {newUser.phoneNumber}");
            Console.WriteLine("========================================================");
        }
        public  void UpdateUser(List<User> users)
        {
            Console.WriteLine("============================ Update User ===============================");
            Console.Write("Enter Phone Number For Edite User: ");
            string PhoneNumber = Console.ReadLine();
            User NumberCheck = users.FirstOrDefault(x => x.phoneNumber == PhoneNumber);
            if (NumberCheck != null)
            {
                Console.WriteLine("[1]Edite Name\n[2]Edite Email\n[3]Edite Phone Number");
                int chose = int.Parse(Console.ReadLine());
                if (chose == 1)
                {
                    Console.Write("Edite Name: ");
                    string name = Console.ReadLine();
                    NumberCheck.userName = name;
                }
                else if (chose == 2)
                {
                    Console.Write("Edite Email: ");
                    string email = Console.ReadLine();
                    NumberCheck.email = email;
                }
                else if (chose == 3)
                {
                    Console.Write("Edite Phone Number: ");
                    string phoneNumber = Console.ReadLine();
                    NumberCheck.phoneNumber = phoneNumber;
                }

                else
                {
                    Console.WriteLine("======================================================================================");
                    Console.WriteLine("                                 Invaled Number                                      ");
                    Console.WriteLine("======================================================================================");

                }

                Console.WriteLine("======================= Information After Update ===================");
                Console.WriteLine($"Name: {NumberCheck.userName}");
                Console.WriteLine($"Email: {NumberCheck.email}");
                Console.WriteLine($"Phone Number: {NumberCheck.phoneNumber}");
                Console.WriteLine("======================================================================================");

            }
            else
                Console.WriteLine("No Number Like This.");
        }
        public  void PrintAllUsers(List<User> users)
        {
            int count = 1;
            Console.WriteLine("======================= Information From All Users ==================================");
            
                if (users.Count == 0)
                {
                Console.WriteLine("======================================================================================");
                Console.WriteLine("                    No User Has Been Created                                           ");
                Console.WriteLine("======================================================================================");
            }
            foreach (User user in users)
                {
                    Console.WriteLine($"Name: {user.userName}\nEmail:{user.email}\nPhone Number: {user.phoneNumber}");
                if (count < users.Count())
                {
                    Console.WriteLine("--------------------");
                }
                if (count == users.Count())
                { Console.WriteLine("======================================================================================"); }
                count++;

            }


            
        }
        public  void DeleteUser(List<User> users)
        {
            Console.WriteLine("=======================  Delete Users ==================================");
            Console.Write("Enter Phone Number For Edite User: ");
            string PhoneNumber = Console.ReadLine(); 
            User NumberCheck = users.FirstOrDefault(x=>x.phoneNumber == PhoneNumber);
            if (NumberCheck != null)
            {
                users.Remove(NumberCheck);
                Console.WriteLine("======================================================================================");
                Console.WriteLine("                           Number Has Been Deleted                                    ");
                Console.WriteLine("======================================================================================");
            }
            else
            {
                Console.WriteLine("======================================================================================");
                Console.WriteLine("                           No Number Like This.");
                Console.WriteLine("======================================================================================");
            }
        }
    }
}
