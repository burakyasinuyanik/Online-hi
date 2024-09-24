using Program.Models;

namespace Program;

class Program
{
    static void Main(string[] args)
    {

        AppUser appUser =new AppUser();
        UserType userType=new UserType();
        userType.Name="Admin";
        appUser.UserType=userType;































        Console.WriteLine(appUser.UserType.Name);
        
       
            
    }
}
