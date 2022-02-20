string[] stringArray = { "hello", "world", "2", ":-)", "red",
"prog", "55", "to", "miners", "are", "for", "the",
 "then", "of", "last", "two", "video" };

void PrintStringArray(string[] stringArray)
{
  Console.Write("[");
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.Write($"\"{stringArray[i]}\"");
    if (i != stringArray.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
}

int SearchStringWithSizeLessOrEqual3(string[] stringArray)
{
  int numberOfString = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length < 4)
    {
      numberOfString++;
    }
  }
  return numberOfString;
}

string[] CreatArrayWithSizeLessOrEqual3(string[] stringArray, int sizeNewArray)
{
  string[] newStringArray = new string[sizeNewArray];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length < 4)
    {
      newStringArray[j] = stringArray[i];
      j++; 
    }
  }
  return newStringArray;
}

PrintStringArray(stringArray);
int sizeNewArray = SearchStringWithSizeLessOrEqual3(stringArray); 
string[] newStringArray = CreatArrayWithSizeLessOrEqual3(stringArray, sizeNewArray); 
Console.Write(" --> ");
PrintStringArray(newStringArray);