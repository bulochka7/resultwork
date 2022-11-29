string[] Array()
{
    string[] array=new string[5];
    for(int i=0;i<array.Length;i++)
        {
           array[i]=Convert.ToString(Console.ReadLine());
        }
    return array;
}

void FindArray(string[] array)
{
    for(int i=0;i<array.Length;i++)
        if(array[i].Length<=3)
        {
            Console.Write(array[i]+" ");
        } 
    else
    Console.WriteLine("0");
}
Console.WriteLine("Введите 5 значений через enter ");
string[] array=Array();
FindArray(array);
