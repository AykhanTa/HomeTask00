int[] arr = {100,1111,33333,123456,101,1200,66666};
int sum3 = 0;
int mult3 = 1;
int sum4=0;
int mult4 = 1;
int sum5= 0;
int result = 0;

for (int i = 0; i < arr.Length; i++)
{
    int count = 0;
    int a = arr[i];
    while (arr[i]>0)
	{
		arr[i]/=10;
		count++;
    }
    if(count == 3)
    {
        sum3 += a;
        mult3*= a;
    }
    else if(count == 4)
    {
        sum4 += a;
        mult4 *= a;
    }
    else if (count == 5)
    {
        sum5 += a;
    }
    
}

result = sum3 + mult4;

result = (result * 10) + 7;

result += sum5;
Console.WriteLine(result);



//Console.WriteLine(sum3);
//Console.WriteLine(mult3);
//Console.WriteLine(sum4);
//Console.WriteLine(mult4);
Console.WriteLine(sum5);

