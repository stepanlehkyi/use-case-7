using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase7TestProject {
  using UseCase7;
  using Xunit;

  public class PlayerAnalyzerTests {
    [Fact]
    public void CalculateScore_ReturnsCorrectScore_ForNormalPlayer() {
      var players = new List<Player> {
            new Player { Age = 25, Experience = 5, Skills = new List<int> {2, 2, 2} }
        };

      double result = PlayerAnalyzer.CalculateScore(players);

      Assert.Equal(250, result);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScore_ForJuniorPlayer() {
      var players = new List<Player> {
            new Player { Age = 15, Experience = 3, Skills = new List<int> {3, 3, 3} }
        };

      double result = PlayerAnalyzer.CalculateScore(players);

      Assert.Equal(67.5, result);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScore_ForSeniorPlayer() {
      var players = new List<Player> {
            new Player { Age = 35, Experience = 15, Skills = new List<int> {4, 4, 4} }
        };

      double result = PlayerAnalyzer.CalculateScore(players);

      Assert.Equal(2520, result);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScore_ForMultiplePlayers() {
      var players = new List<Player> {
        new Player { Age = 25, Experience = 5, Skills = new List<int> {2, 2, 2} },
        new Player { Age = 15, Experience = 3, Skills = new List<int> {3, 3, 3} }
    };

      double result = PlayerAnalyzer.CalculateScore(players);

      // Update the expected value to the sum of the scores of the two players
      Assert.Equal(317.5, result);
    }

    [Fact]
    public void CalculateScore_ThrowsException_WhenSkillsIsNull() {
      var players = new List<Player> {
            new Player { Age = 25, Experience = 5, Skills = null }
        };

      Assert.Throws<ArgumentNullException>(() => PlayerAnalyzer.CalculateScore(players));
    }

    [Fact]
    public void CalculateScore_ReturnsZero_WhenPlayersListIsEmpty() {
      var players = new List<Player> { };

      double result = PlayerAnalyzer.CalculateScore(players);

      Assert.Equal(0, result);
    }
  }
}
