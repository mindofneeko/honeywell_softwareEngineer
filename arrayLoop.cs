using System;

class Program
{
    static void Main()
    {
        // Reverse the array
        // Loop through the Array adding value to new array if IndexOf is found ie != 0
        // 
        
        string[] input = new string[] {"f","e","d","c","c","b","a"};
        foreach(var item in input) {
            Console.WriteLine(item);
        }
        Console.WriteLine("| Break |");
        string[] output = new string[input.Length];
        int counter =0;
        for (int i = input.Length - 1; i >= 0; i--) {
            if (Array.IndexOf(output, input[i]) == -1){
            output[counter] = input[i];
            counter++;
            }
            
        }
         foreach(var item in output) {
            Console.WriteLine(item);
        }
        //Console.WriteLine(input);
                                     
        
        Console.WriteLine("Hello, world!");
}
