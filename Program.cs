using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        arr.Sort();
        int yarim = (arr.Count/2)+1;
        int beste4 = arr.Count-(arr.Count/5)*2;
        int sayac = 0;
        int sayac1 =0;
        int deger = -1;
        int adet=0;
        for(int i=adet; i<=arr.Count-1; i++)
        {
            if(adet >= beste4)
            {
                break;
            }
            for( int j=adet; j <= arr.Count-1; j++)
            {                
                if(arr[i] == arr[j])
                {
                    sayac++;                  
                    
                }
                
                else
                {
                    adet += sayac;
                    break;
                }
            }
            
            if(sayac > sayac1)
            {
                if(sayac >= yarim)
                {
                    deger = arr[i];
                    break;
                }
                if(deger < arr[i])
                {
                  sayac1 = sayac;
                  deger = arr[i];
                  
                }

            }
            sayac = 0;
        }
        
        return deger;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
