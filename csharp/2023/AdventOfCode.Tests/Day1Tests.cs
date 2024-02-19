namespace AdventOfCode.Tests;

public class Day1Tests
{
    [Fact]
    public void Task1_Test_From_Example()
    {
      // Arrange
      var exampleInput = """
        1abc2
        pqr3stu8vwx
        a1b2c3d4e5f
        treb7uchet
        """;
      var exampleOutput = 142;

      // Act
      var result = Day1.Calibrater(exampleInput);

      // Assert 
      result.Should().Be(exampleOutput);

    }
}
