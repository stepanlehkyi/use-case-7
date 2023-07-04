using UseCase7;

namespace UseCase7TestProject {
  public class Test {

    [Fact]
    public void ConvertStudents_ShouldSetHonorRoll_WhenHighAchieverAbove21() {
      // Arrange
      var students = new List<Student>
      {
            new Student { Name = "John", Age = 22, Grade = 95 }
        };

      // Act
      var result = StudentConverter.ConvertStudents(students);

      // Assert
      Assert.Single(result);
      Assert.True(result[0].HonorRoll);
    }

    [Fact]
    public void ConvertStudents_ShouldSetExceptional_WhenYoungHighAchiever() {
      // Arrange
      var students = new List<Student>
      {
            new Student { Name = "Jane", Age = 20, Grade = 95 }
        };

      // Act
      var result = StudentConverter.ConvertStudents(students);

      // Assert
      Assert.Single(result);
      Assert.True(result[0].Exceptional);
    }

    [Fact]
    public void ConvertStudents_ShouldSetPassed_WhenStudentInGradeRange() {
      // Arrange
      var students = new List<Student>
      {
            new Student { Name = "Alice", Age = 25, Grade = 85 }
        };

      // Act
      var result = StudentConverter.ConvertStudents(students);

      // Assert
      Assert.Single(result);
      Assert.True(result[0].Passed);
    }

    [Fact]
    public void ConvertStudents_ShouldSetPassedFalse_WhenFailedStudent() {
      // Arrange
      var students = new List<Student>
      {
            new Student { Name = "Bob", Age = 23, Grade = 60 }
        };

      // Act
      var result = StudentConverter.ConvertStudents(students);

      // Assert
      Assert.Single(result);
      Assert.False(result[0].Passed);
    }

    [Fact]
    public void ConvertStudents_ShouldReturnEmpty_WhenInputIsEmpty() {
      // Arrange
      var students = new List<Student>();

      // Act
      var result = StudentConverter.ConvertStudents(students);

      // Assert
      Assert.Empty(result);
    }

    [Fact]
    public void ConvertStudents_ShouldThrowException_WhenInputIsNotArray() {
      // Arrange
      List<Student>? students = null; // Or any non-array value

      // Assert
      Assert.Throws<ArgumentNullException>(() => StudentConverter.ConvertStudents(students));
    }

  }
}