using System.Reflection;

namespace AdventOfCode.Tests;

public class Day1Tests
{

    private static readonly string _executionDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
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

    [Fact]
    public void Should_ReturnTotal_From_InputFile()
    {
      // Arrange
      var filePath = Path.Combine(_executionDirectory, "data", "day1-input.txt");
      var input = File.ReadAllText(filePath);
      var output = 54597; // Generated from Day1.Calibrater(input), verified on website

      // Act
      var result = Day1.Calibrater(input);

      // Assert 
      result.Should().Be(output); 
    }
}
