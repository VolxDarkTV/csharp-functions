namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {


           //Parte 1




           //Stampa Array

            //int[] array = new int[] { 1, 2, 3 };


            //StampaArray(array);

            //void StampaArray(int[] array)
            //{
            //    Console.Write("[");
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.Write(array[i]);
            //        if (i < array.Length - 1)
            //        {
            //            Console.Write(", ");
            //        }
            //    }
            //    Console.WriteLine("]");
            //}


           //Quadrato numero

            //int numero = 5;

            //CubeNumber(numero);

            //void CubeNumber(int n)
            //{
            //    n *= n;

            //    Console.WriteLine(n);
            //}


           //Eleva Array Quadrato

            //int[] numeri = new int[] { 1, 2, 3 };

            //int[] cubeArray = CubeArray(numeri

            //int[] CubeArray(int[] array)
            //{
            //    int[] copiaArray = (int[])array.Clone();
            //    for (int i = 0; i < copiaArray.Length; i++)
            //    {
            //        copiaArray[i] *= copiaArray[i];
            //    }

            //    //Stampa l'array
            //    Console.Write("[");
            //        for (int i = 0; i < copiaArray.Length; i++)
            //        {
            //            Console.Write(copiaArray[i]);
            //            if (i < copiaArray.Length - 1)
            //            {
            //                Console.Write(", ");
            //            }
            //        }
            //        Console.WriteLine("]");

            //    return copiaArray;

            //}


           //Somma Elementi Array

            //int[] numeri = new int[] { 1, 2, 3 };

            //int sum = SumArrayElement(numeri);


            //Console.WriteLine(sum);


            //int SumArrayElement(int[] array)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        sum = sum + array[i];
            //    }
            //    return sum;
            //}




            //Parte 2

            int[] array = new int[] { 2, 6, 7, 5, 3, 9 };

            //Print Array
            PrintArray(array);

            //Print Cube Array
            int[] cubeArray = CubeArray(array);
            

            //Print Sum Number
            int sum = SumArrayElement(array);
            Console.WriteLine(sum);


            //Print Sum Cube Number
            int sumCube = SumArrayElement(cubeArray);
            Console.WriteLine(sumCube);









            //FUNCTIONS

            //Stampa array
            void PrintArray(int[] array)
            {
                Console.Write("[");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i]);
                        if (i < array.Length - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine("]");

            }



            //CubeNumber
            void CubeNumber(int n)
            {
                n *= n;
                Console.WriteLine(n);
            }



            //Eleva Array Quadrato
            int[] CubeArray(int[] array)
            {
                int[] copiaArray = (int[])array.Clone();
                for (int i = 0; i < copiaArray.Length; i++)
                {
                    copiaArray[i] *= copiaArray[i];
                }

                //Stampa l'array
                Console.Write("[");
                    for (int i = 0; i < copiaArray.Length; i++)
                    {
                        Console.Write(copiaArray[i]);
                        if (i < copiaArray.Length - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine("]");

                return copiaArray;

            }



            //Somma elementi array
            int SumArrayElement(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum = sum + array[i];
                }
                return sum;
            }





        }












    }

}