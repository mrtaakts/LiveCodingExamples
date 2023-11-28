
#region Palindrome

//Palindrome 

using LiveCodingExamples.Models;
using System.Linq;
using System.Numerics;

bool IsPalindrome(string input)
{
    string cleanedInput = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();

    int left =0, right = input.Length-1;

    while(left < right)
    {
        if (cleanedInput[left] != cleanedInput[right])
        {
            return false;
        }
        left++;
        right--;
    }
    return true;

}



//Console.WriteLine(IsPalindrome("kabb1ak"));
#endregion

#region Stack 
/*

LiveCodingExamples.Models.Stack<int> stack = new LiveCodingExamples.Models.Stack<int>();

stack.Push(1);
stack.Push(2);

Console.WriteLine($"IsEmpty : {stack.IsEmpty()}" );

Console.WriteLine("Peek:" + stack.Peek());

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

*/
#endregion

#region FirstNonRepeatedChar 
/*
char FindFirstNonRepeatedChar(string input)
{
    if(string.IsNullOrEmpty(input))
        throw new ArgumentNullException("Input string was empty");


    Dictionary<char,int> dictionary = new Dictionary<char,int>();
    foreach(char c in input)
    {
        if(!dictionary.ContainsKey(c))
            dictionary[c] = 1;
        else dictionary[c]++;

    }
    foreach(char c in input)
    {
        if (dictionary[c] == 1) return c;
    }

    throw new ArgumentOutOfRangeException("No non repeated char found");
}

Console.WriteLine(FindFirstNonRepeatedChar("aabbccddeeffgghh"));
*/

#endregion

#region MajorityNumber
/*
int findMajorityNum(int[] input)
{
    Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();

    foreach(var item in input)
    {
        if(!keyValuePairs.ContainsKey(item))
            keyValuePairs.Add(item,1);
        else keyValuePairs[item]++;
    }

    var MaxKeyValue =keyValuePairs.MaxBy(x=>x.Value);

    if (MaxKeyValue.Value >= input.Length/2)
        return MaxKeyValue.Key;
    return -1;
}

int[] nums1 = { 3, 2, 3 };
int[] nums2 = { 2, 2, 1, 1, 1, 2, 2 };

int majority1 = findMajorityNum(nums1);
int majority2 = findMajorityNum(nums2);

Console.WriteLine("Majority Element 1: " + majority1); // Output: 3
Console.WriteLine("Majority Element 2: " + majority2); // Output: 2
*/

#endregion

#region TwoSumFinder



#endregion

#region TheMostRepeatedChar
/*
char TheMostRepeatedCharacter(string input)
{
    Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();

    foreach(char c in input)
    {
        if (keyValuePairs.ContainsKey(c))
            keyValuePairs[c]++;
        else
        keyValuePairs.Add(c, 1);
    }
    
    // eğer tüm karakterler eşit sayıda varsa
    bool allValuesSame= keyValuePairs.Values.All(v=>v== keyValuePairs.Values.First());
    if(allValuesSame)
    throw new ArgumentException("Tüm karakterler eşit sayıda olduğundan en çok tekrar eden karakter olamaz");

    var MaximumRepeatedCharacter = keyValuePairs.MaxBy(x => x.Value).Key;
    
    return MaximumRepeatedCharacter;
}

Console.WriteLine(TheMostRepeatedCharacter("mertmert"));
*/
#endregion

#region EnBuyukFark
//Bir dizi içinde birbirini takip eden iki elemanın arasındaki en büyük farkı bulan bir C# fonksiyonu yazın. Örneğin, verilen dizi [7, 1, 5, 3, 6, 4] için, fonksiyon 5 döndürmelidir (6-1).
/*
int EnBuyukFark(int[] input)
{

    if(input.Length<2) return 0;

    Array.Sort(input);
   
    return input[input.Length - 1] - input[0];
}

int[] fakeData = { 7, 1, 5, 3, 6, 4 };
Console.WriteLine(EnBuyukFark(fakeData));
*/
#endregion

#region HedefIkiElemanToplamı

//Bir dizideki herhangi iki elemanın (farklı indisli) toplamı, belirli bir hedef değere eşitse, bu iki elemanı bulan bir C# fonksiyonu yazın.

//Fonksiyon, bulduğu iki elemanı içeren bir liste döndürmelidir. Örneğin, verilen dizi [2, 7, 11, 15] ve hedef değer 9 için, fonksiyon [2, 7] listesini döndürmelidir.
/*
List<int> IkıElemanToplamı(List<int> input, int hedef)
{
    Dictionary<List<int>,int> dictionary = new Dictionary<List<int>, int>();

    for(int i = 0; i < input.Count; i++)
    {
        for(int j = i+1; j < input.Count; j++)
        {
            dictionary.Add(new List<int>() { input[i], input[j] }, input[i] + input[j] );
        }
    }

    if (!dictionary.ContainsValue(hedef))
        throw new Exception($"Hedeflenen {hedef} sayısı için eşlenen iki eleman toplamı bulunamadı");
    return dictionary.FirstOrDefault(x=>x.Value==hedef).Key;
}

List<int> fakeData = new List<int> { 2, 11,7, 15 };
List<int> sonuc = IkıElemanToplamı(fakeData, 9);

foreach(var item in sonuc)
{
    Console.WriteLine(item);
}
*/
#endregion


#region Palindrome
/*
bool IsPalindrome2(string input)
{
    bool status = true;
    for(int i=0; i<input.Length; i++)
    {
        if (input[i] != input[(input.Length -1) - i])
           status = false;
    }
    return status;
}

Console.WriteLine(IsPalindrome2("kabbbak"));
*/
#endregion

#region IsAnagram 
/*
bool IsAnagram(string input, string input2)
{
    char[] inputArray = input.Trim().ToCharArray();
    char[] inputArray2 = input2.Trim().ToCharArray();

    Array.Sort(inputArray);
    Array.Sort(inputArray2);

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] != inputArray2[i])
            return false;
    }
        return true;
   

}

Console.WriteLine(IsAnagram("asya", "yasa"));
*/
#endregion

#region MatchCharacter
/*
List<char> GetMatchCharacters(string input,string input2)
{
    HashSet<char> characters = new HashSet<char>(input);
    HashSet<char> matchingCharacters = new HashSet<char>();
    foreach(char c in input2)
    {
        if (characters.Contains(c))
        {
            matchingCharacters.Add(c);
        }
    }
    return matchingCharacters.ToList();
}

var res = GetMatchCharacters("aktaşa", "aydına");
foreach(char c in res)
    Console.WriteLine(c);
*/
#endregion

#region Factorial
/*
long FindFactorial(int number)
{
   
    if(number ==1)
    return 1;
    else
    return number * FindFactorial(number-1);
}

Console.WriteLine(FindFactorial(8));
*/
#endregion

#region 

string LongestWord(string sen)
{
    string ignoredSen = new string(sen.Where(x => !char.IsPunctuation(x)).ToArray());

    string longestWord = string.Empty;

    string[] list = ignoredSen.Split(" ").ToArray();

    foreach (var item in list)
    {
        if(item.Length > longestWord.Length)
        {
            longestWord = item;
        }
    }
    return longestWord;

}

Console.WriteLine(LongestWord("fun&!! time"));

#endregion