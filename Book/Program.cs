public class Program {
    static void Main (string []args){
        string[] Name_U = data.Name_University();
        string[] Name_L = data.Name_Library();
        string[] Name_A = data.Name_Add ();
        string[] Name_N = data.Name_Number();
        string[] Name = data.Name_Name();
        string[] LastName = data.Last_Name();
        string[] Id_Number = data.Id_User();

        Console.Write("Input Menu : ");
        char input = char.Parse(Console.ReadLine());

        if (input == 'a'){
            for (int i = 0; i<5 ;i++){
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine(("University Name : {0}"),Name_U[i]);
                Console.WriteLine(("Library name : {0}"),Name_L[i]);
                Console.WriteLine(("University Name : {0}"),Name_A[i]);
                Console.WriteLine(("University Name : {0}"),Name_N[i]);
                Console.WriteLine("_______________________________________________________________________");
            }
        }
        else if (input == 'b'){
            for(int i = 0;i <5 ;i++){
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine(("University Name : {0}"),Name_U[i]);
                Console.WriteLine(("Name : {0}"),Name[i]);
                Console.WriteLine(("Last_Name : {0}"),LastName[i]);
                Console.WriteLine(("ID User : {0}"),Id_Number[i]);
                Console.WriteLine("_______________________________________________________________________");
            }
        }
        else if (input == 'c'){
            double[] sumFT = CalFT.Sum_FT();
            //double[] sumPT = CalPT.Sum_PT();

                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine(("University Name : {0}"),Name_U[3]);
                Console.WriteLine(("Library name : {0}"),Name_L[3]);
                Console.WriteLine(("FT sum : {0}"),sumFT[3]);
                //Console.WriteLine(("Price Fi : {0}"),sumPT[4]);
                Console.WriteLine("_______________________________________________________________________");
        }
        else{
            Console.WriteLine("Error");
        }
    }
}