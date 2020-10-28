using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

            int c=4;
          string sair="", status="";
          double Peso=0, Altura=0, IMC=0;
           do
         {
          Console.Clear();
          Box("Indice de massa corparal",6,15,10,0);

          print("Digite sua altura em m.:",15,0,04,5);
          Altura = Convert.ToDouble(Console.ReadLine());
          print("Digite seu peso em Kg..:",15,0,04,6);
          Peso = Convert.ToDouble(Console.ReadLine());
          IMC=Peso/(Altura*Altura);

            if      (IMC < 17)     {status="  Muito abaixo do peso "; c=01;}
            else if (IMC <= 18.49) {status="    Abaixo do peso     "; c=09;}
            else if (IMC <= 24.99) {status="      Peso normal      "; c=10;}
            else if (IMC <= 29.99) {status="     Acima do peso     "; c=02;}
            else if (IMC <= 34.99) {status="      Obesidade I      "; c=06;}
            else if (IMC <= 39.99) {status=" Obesidade II (severa) "; c=12;}
            else if (IMC >= 40)    {status="Obesidade III (mórbida)"; c=04;}
           print($" Seu IMC é {IMC:N}kg/m²  ",0,c,33,5);
           print(status,0,c,33,6);

           print("Outro? (s)",15,0,0,8);
           sair=Console.ReadLine().ToUpper();
         } while (sair=="S");
            Console.Clear();
        }// main  



          
           



        

         static void Box( String S2,int Cor_Caixa, int Cor_Letra, int X, int Y)//  Texto dentro da caixa    
         {
         int tamanho = S2.Length; 
         Console.SetCursorPosition(X, Y);
         string lin = new string('*', tamanho+4); 
         string vazio = new string(' ',tamanho+2);
           // imprime Caixa
         ConsoleColor CorCaixa = (ConsoleColor)Cor_Caixa;
         Console.ForegroundColor = CorCaixa;
         Console.SetCursorPosition(X, Y);Console.WriteLine(lin);         
         Console.SetCursorPosition(X, Y+1);Console.Write($"*{vazio}*");         
         Console.SetCursorPosition(X, Y+2);Console.Write(lin);   
          // imprime Titulo
         ConsoleColor CorLetra = (ConsoleColor)Cor_Letra;
         Console.ForegroundColor = CorLetra;
         Console.SetCursorPosition(X+2, Y+1);
         Console.WriteLine(S2);
         //proxima coordenadas        
         Console.ResetColor();  
         Console.SetCursorPosition(0, Y+4);
        }// Fecha Box

       static void print(String S, int COR_Caracter,int COR_Fundo, int X,int Y)
        {
         ConsoleColor CorC = (ConsoleColor)COR_Caracter;
         ConsoleColor CorF = (ConsoleColor)COR_Fundo;
         Console.ForegroundColor = CorC;
         Console.BackgroundColor = CorF;
         Console.SetCursorPosition(X, Y);
         Console.Write(S);
         Console.ResetColor();
        }//fecha print
    }
}
