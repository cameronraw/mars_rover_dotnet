namespace UnitTests;
using NUnit.Framework;
using MarsRover;

[TestFixture]
public class MarsRoverShould
{
    [Test]
    public void Constructor_InitializesDefaultValues()
    {
        var rover = new MarsRover();

        Assert.That(rover.Execute(""), Is.EqualTo("0:0:N"));
    }

    [TestCase("L", "0:0:W")]
    [TestCase("LL", "0:0:S")]
    [TestCase("LLL", "0:0:E")]
    [TestCase("LLLL", "0:0:N")]
    public void Execute_TurnLeft_ChangesOrientation(string command, string expected)
    {
        var rover = new MarsRover();

        Assert.That(rover.Execute(command), Is.EqualTo(expected));
    }
    
    [TestCase("R", "0:0:E")]
    [TestCase("RR", "0:0:S")]
    [TestCase("RRR", "0:0:W")]
    [TestCase("RRRR", "0:0:N")]
    public void Execute_TurnRight_ChangesOrientation(string command, string expected)
    {
        var rover = new MarsRover();

        Assert.That(rover.Execute(command), Is.EqualTo(expected));
    }
    
    [Test]
    public void Execute_MoveNorth_IncrementsY()
    {
        var rover = new MarsRover();

        Assert.That(rover.Execute("M"), Is.EqualTo("0:1:N"));
    }

    [Test]
    public void Execute_MoveEast_IncrementsX()
    {
        var rover = new MarsRover();

        Assert.That(rover.Execute("RM"), Is.EqualTo("1:0:E"));
    }

    [Test]
    public void Execute_MoveSouth_DecrementsY()
    {
        var rover = new MarsRover();

        Assert.That(rover.Execute("RRM"), Is.EqualTo("0:-1:S"));
    }

    [Test]
    public void Execute_MoveWest_DecrementsX()
    {
        var rover = new MarsRover();

        Assert.That(rover.Execute("LM"), Is.EqualTo("-1:0:W"));
    }

    [Test]
    public void Execute_InvalidCommand_ThrowsInvalidCommandException()
    {
        var rover = new MarsRover();

        Assert.Throws<InvalidCommandException>(() => rover.Execute("X"));
    }

    [Test]
    public void Execute_MultipleCommands_CorrectFinalPositionAndOrientation()
    {
        var rover = new MarsRover();

        Assert.That(rover.Execute("MMRMMRMRRM"), Is.EqualTo("2:2:N"));
    }
}

