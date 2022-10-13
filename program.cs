class program{
    static void Main(string[]args){
        PrintMenuSceen();
    }
    static void PrintMenuSceen(){
        noLogiMenu();
    }
    public static void noLogiMenu(){
        
        Console.WriteLine("Welcome to Idia CAMP 2022 registration system");
        Console.WriteLine("**************************************************");
        Console.WriteLine("1 for Register");
        Console.WriteLine("2 for Show attendees");
        Console.WriteLine("3 for Login");
        Console.WriteLine("4 for Exist");
        Console.WriteLine("**************************************************");
       
        int n = int.Parse(Console.ReadLine());
        switch(n){
            case 1:{RegisterMenu();break;}
            case 2:{Allcurrents();break;}
            case 3:{LoginMenu();break;}
            case 4:break;
            default: break;
        }

        
    }
     public static void LoginMenu(){
        
        Console.WriteLine("Welcome to Idia CAMP 2022");
        Console.WriteLine("1 for Register");
        Console.WriteLine("2 for show all current students");
        Console.WriteLine("3 for show students");
        Console.WriteLine("4 for show teachers");
        Console.WriteLine("5 for Log Out");

        int n = int.Parse(Console.ReadLine());
        switch(n){
            case 1:{RegisterMenu();break;}
            case 2:{PrintCamp(1);break;}
            case 3:{PrintCamp(2);break;}
            case 4:{PrintCamp(3);break;}
            case 5:break;
            default: break;
        }
        
    }
   
}