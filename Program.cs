using System;

namespace escrevendoCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            // Letras  ->  Número 
            // ABC    ->  2 
            // DEF    ->  3 
            // GHI    ->  4 
            // JKL    ->  5 
            // MNO    ->  6 
            // PQRS    ->  7 
            // TUV    ->  8 
            // WXYZ   ->  9 
            // Espaço -> 0 
            // letras iguais _

            string frase = "", fraseTraduzida = null;

            frase = Console.ReadLine().ToUpper();
            if(frase.Length > 255){
                Console.WriteLine("Máximo de 255 caracteres");
            }else{
                Array palavras = frase.Split(" ");
                string palavra = null;
                if(palavras.Length < 2){
                    foreach (var item in palavras)
                    {
                        palavra = item.ToString();
                    }
                    for(int i = 0; i < palavra.Length; i++){
                        
                        switch (palavra[i])
                        {
                            case 'A' : fraseTraduzida = fraseTraduzida + string.Concat("2"); break;
                            case 'B' : fraseTraduzida = fraseTraduzida + string.Concat("22"); break;
                            case 'C' : fraseTraduzida = fraseTraduzida + string.Concat("222"); break;
                            case 'D' : fraseTraduzida = fraseTraduzida + string.Concat("3"); break;
                            case 'E' : fraseTraduzida = fraseTraduzida + string.Concat("33"); break;
                            case 'F' : fraseTraduzida = fraseTraduzida + string.Concat("333"); break;
                            case 'G' : fraseTraduzida = fraseTraduzida + string.Concat("4"); break;
                            case 'H' : fraseTraduzida = fraseTraduzida + string.Concat("44"); break;
                            case 'I' : fraseTraduzida = fraseTraduzida + string.Concat("444"); break;
                            case 'J' : fraseTraduzida = fraseTraduzida + string.Concat("5"); break;
                            case 'K' : fraseTraduzida = fraseTraduzida + string.Concat("55"); break;
                            case 'L' : fraseTraduzida = fraseTraduzida + string.Concat("555"); break;
                            case 'M' : fraseTraduzida = fraseTraduzida + string.Concat("6"); break;
                            case 'N' : fraseTraduzida = fraseTraduzida + string.Concat("66"); break;
                            case 'O' : fraseTraduzida = fraseTraduzida + string.Concat("666"); break;
                            case 'P' : fraseTraduzida = fraseTraduzida + string.Concat("7"); break;
                            case 'Q' : fraseTraduzida = fraseTraduzida + string.Concat("77"); break;
                            case 'R' : fraseTraduzida = fraseTraduzida + string.Concat("777"); break;
                            case 'S' : fraseTraduzida = fraseTraduzida + string.Concat("8"); break;
                            case 'T' : fraseTraduzida = fraseTraduzida + string.Concat("88"); break;
                            case 'U' : fraseTraduzida = fraseTraduzida + string.Concat("888"); break;
                            case 'V' : fraseTraduzida = fraseTraduzida + string.Concat("9"); break;
                            case 'W' : fraseTraduzida = fraseTraduzida + string.Concat("99"); break;
                            case 'X' : fraseTraduzida = fraseTraduzida + string.Concat("999"); break;
                            case 'Y' : fraseTraduzida = fraseTraduzida + string.Concat("9999"); break;
                            case 'Z' : fraseTraduzida = fraseTraduzida + string.Concat("99999"); break;
                            default: Console.WriteLine("Letra não identificada : " + palavra[i]); break;
                        }
                        int j = 0;
                        if(i == palavra.Length - 1){
                            j = i;
                        }else{
                            j = i +1;
                        }
                        if(palavra[i].ToString() == palavra[j].ToString()){
                            fraseTraduzida = fraseTraduzida + string.Concat("_");
                        }
                        
                    }
                    // fraseTraduzida = fraseTraduzida.Substring(palavra.Length);
                    // Console.WriteLine("TESTE :"+ fraseTraduzida);

                     string bio = "Mahesh Chand is a founder of C# Corner. Mahesh is also an author, " +    
                        "speaker, and software architect. Mahesh founded C# Corner in 2000.";    
                
                    // Get first 12 characters substring from a string    
                    string authorName = bio.Substring(12);    
                    Console.WriteLine(authorName);    
                }else{
                    foreach (var item in palavras)
                    {
                    palavra = item.ToString();
                    //Transformar palavra em números                                                                      
                    for(int i = 0; i >= palavra.Length; i++){
                        Console.Write("@");
                        switch (palavra[i])
                        {
                            case 'A' : fraseTraduzida = fraseTraduzida + string.Concat("2"); break;
                            case 'B' : fraseTraduzida = fraseTraduzida + string.Concat("22"); break;
                            case 'C' : fraseTraduzida = fraseTraduzida + string.Concat("222"); break;
                            case 'D' : fraseTraduzida = fraseTraduzida + string.Concat("3"); break;
                            case 'E' : fraseTraduzida = fraseTraduzida + string.Concat("33"); break;
                            case 'F' : fraseTraduzida = fraseTraduzida + string.Concat("333"); break;
                            case 'G' : fraseTraduzida = fraseTraduzida + string.Concat("4"); break;
                            case 'H' : fraseTraduzida = fraseTraduzida + string.Concat("44"); break;
                            case 'I' : fraseTraduzida = fraseTraduzida + string.Concat("444"); break;
                            case 'J' : fraseTraduzida = fraseTraduzida + string.Concat("5"); break;
                            case 'K' : fraseTraduzida = fraseTraduzida + string.Concat("55"); break;
                            case 'L' : fraseTraduzida = fraseTraduzida + string.Concat("555"); break;
                            case 'M' : fraseTraduzida = fraseTraduzida + string.Concat("6"); break;
                            case 'N' : fraseTraduzida = fraseTraduzida + string.Concat("66"); break;
                            case 'O' : fraseTraduzida = fraseTraduzida + string.Concat("666"); break;
                            case 'P' : fraseTraduzida = fraseTraduzida + string.Concat("7"); break;
                            case 'Q' : fraseTraduzida = fraseTraduzida + string.Concat("77"); break;
                            case 'R' : fraseTraduzida = fraseTraduzida + string.Concat("777"); break;
                            case 'S' : fraseTraduzida = fraseTraduzida + string.Concat("8"); break;
                            case 'T' : fraseTraduzida = fraseTraduzida + string.Concat("88"); break;
                            case 'U' : fraseTraduzida = fraseTraduzida + string.Concat("888"); break;
                            case 'V' : fraseTraduzida = fraseTraduzida + string.Concat("9"); break;
                            case 'W' : fraseTraduzida = fraseTraduzida + string.Concat("99"); break;
                            case 'X' : fraseTraduzida = fraseTraduzida + string.Concat("999"); break;
                            case 'Y' : fraseTraduzida = fraseTraduzida + string.Concat("9999"); break;
                            case 'Z' : fraseTraduzida = fraseTraduzida + string.Concat("99999"); break;
                            default: Console.WriteLine("Letra não identificada : " + palavra[i]); break;
                        }
                    }
                }
                
                
                }
                Console.WriteLine(fraseTraduzida);
            }

        }
    }
}
