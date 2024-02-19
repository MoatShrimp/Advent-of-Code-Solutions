
namespace AdventOfCode;

public class Day1
{
  private static int GetFirstAndLastNumericInString(string str)
  {
    var num1 = str.FirstOrDefault(c => c is >= '0' and <= '9');
    if (num1 == 0) 
    {
      return 0;
    }
    var num2 = str.Reverse().FirstOrDefault(c => c is >= '0' and <= '9');

    return int.Parse(new string([num1, num2]));
  }
  
  public static int Calibrater(string exampleInput)
  {
    return exampleInput.Split('\n')
      .Aggregate(
        0,
        (curr, next) => curr + GetFirstAndLastNumericInString(next));
  }
}
