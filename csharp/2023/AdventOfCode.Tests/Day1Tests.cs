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

    [Fact]
    public void Should_ReturnZero_When_InputIsZero()
    {
      // Arrange
      var input = "";
      var output = 0;

      // Act
      var result = Day1.Calibrater(input);

      // Assert 
      result.Should().Be(output);
    }

}
