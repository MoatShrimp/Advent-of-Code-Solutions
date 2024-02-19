
namespace AdventOfCode;

public class Day1
{
  private static int GetFirstAndLastNumericInString(string str)
  {
    throw new NotImplementedException();
  }
  
  public static int Calibrater(string exampleInput)
  {
    return exampleInput.Split('\n')
      .Aggregate(
        0,
        (curr, next) => curr + GetFirstAndLastNumericInString(next));
  }
}
