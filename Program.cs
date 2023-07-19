// See https://aka.ms/new-console-template for more information

int[][] groupArrays(int[] arrToBeGrouped, int numArrToBeReturned)
{ 
    //Get exact amount of times N goes into Array Size
    double getEqualPortionAmount = (double)arrToBeGrouped.Length / (double)numArrToBeReturned;
    //Round portion amount since it's integer based, cannot have < or > than whole number in array
    getEqualPortionAmount = Math.Round(getEqualPortionAmount,MidpointRounding.AwayFromZero);

    int[][] arrayGroupsToBeReturned = new int[numArrToBeReturned][];

    for(int x = 0; x < numArrToBeReturned; x++)
    {
        List<int> listTempItems = new List<int>(); //using list to prevent array initalisation from adding extra elements
        for(int i = ( x * (int)getEqualPortionAmount); i < (x + 1 == numArrToBeReturned ? arrToBeGrouped.Length : (x * (int)getEqualPortionAmount) + getEqualPortionAmount); i++) //On Last iteration gather remaining elements
        {
            Console.WriteLine(x);
            listTempItems.Add(arrToBeGrouped[i]); // Gets next set of equally distributable elements
        }
        arrayGroupsToBeReturned[x] = listTempItems.ToArray();
    }
    return arrayGroupsToBeReturned;
} 

int[][] jaggedArray = groupArrays(new int[]{1, 2, 3, 4, 5, 6, 7, 8}, 7);
string output =  string.Empty;

for (int i = 0; i < jaggedArray.Length; i++)
{
    output += "[";
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        output += jaggedArray[i][j].ToString();
        if (j < jaggedArray[i].Length - 1)
        {
            output += ", ";
        }
    }
    output += "]";
}

Console.WriteLine(output);