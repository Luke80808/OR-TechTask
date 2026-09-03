namespace OR_TechTask.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReverseString_NullOrEmpty_ThrowsArgumentException()
        {
            //Arrange
            string input = null!;

            //Act and Assert
            var ex = Assert.Throws<ArgumentException>(() => StringManipulator.ReverseString(input));
            Assert.That(ex.Message, Is.EqualTo("Input string cannot be null or empty."));
        }

        [TestCase("hello", ExpectedResult = "olleh")]
        [TestCase("abc", ExpectedResult = "cba")]
        [TestCase("Abc", ExpectedResult = "cbA")]
        [TestCase("ABc", ExpectedResult = "cBA")]
        [TestCase("ABC", ExpectedResult = "CBA")]
        [TestCase("ab12", ExpectedResult = "21ba")]
        [TestCase("a12b", ExpectedResult = "b21a")]
        [TestCase("ab cd", ExpectedResult = "dc ba")]
        public string ReverseString_ReturnsReversedString(string input)
        {
            //Arrange
            //Act
            var result = StringManipulator.ReverseString(input);

            //Assert
            return result;
        }

        [Test]
        public void FindEarliestCharacter_NullOrEmpty_ThrowsArgumentException()
        {
            //Arrange
            string input = null!;

            //Act and Assert
            var ex = Assert.Throws<ArgumentException>(() => StringManipulator.FindEarliestCharacter(input));
            Assert.That(ex.Message, Is.EqualTo("Input string cannot be null or empty."));
        }

        [Test]
        public void FindEarliestCharacter_NoLetters_ThrowsArgumentException()
        {
            //Arrange
            string input = "1234!@#$";

            //Act and Assert
            var ex = Assert.Throws<ArgumentException>(() => StringManipulator.FindEarliestCharacter(input));
            Assert.That(ex.Message, Is.EqualTo("Input string must contain at least one letter."));
        }

        [TestCase("abcd", ExpectedResult = "a")]
        [TestCase("aBcd", ExpectedResult = "a")]
        [TestCase("ABCD", ExpectedResult = "A")]
        [TestCase("Abcd", ExpectedResult = "A")]
        [TestCase("bc1", ExpectedResult = "b")]
        [TestCase("ab ab", ExpectedResult = "a")]
        [TestCase("aB aB", ExpectedResult = "a")]
        public char FindEarliestCharacter_ReturnsEarliestCharacter(string input)
        {
            //Arrange
            //Act
            var result = StringManipulator.FindEarliestCharacter(input);

            //Assert
            return result;
        }

        [Test]
        public void ReturnRentOrOpenFromVowelTotal_NullOrEmpty_ThrowsArgumentException()
        {
            //Arrange
            string input = null!;

            //Act and Assert
            var ex = Assert.Throws<ArgumentException>(() => StringManipulator.ReturnRentOrOpenFromVowelTotal(input));
            Assert.That(ex.Message, Is.EqualTo("Input string cannot be null or empty."));
        }

        [TestCase("aeiou", ExpectedResult = "open")]
        [TestCase("AEIOU", ExpectedResult = "open")]
        [TestCase("ab", ExpectedResult = "open")]
        [TestCase("abcde", ExpectedResult = "rent")]
        [TestCase("ABCDE", ExpectedResult = "rent")]
        [TestCase("bc", ExpectedResult = "rent")]
        [TestCase("AbC", ExpectedResult = "open")]
        [TestCase("AbCdE", ExpectedResult = "rent")]
        [TestCase("AbCde", ExpectedResult = "rent")]
        [TestCase("1234", ExpectedResult = "rent")]
        public string ReturnRentOrOpenFromVowelTotal_ReturnsRentOrOpen(string input)
        {
            //Arrange
            //Act
            var result = StringManipulator.ReturnRentOrOpenFromVowelTotal(input);

            //Assert
            return result;
        }

        [Test]
        public void Manipulator_NullOrEmpty_ThrowsArgumentException()
        {
            //Arrange
            string input = null!;

            //Act and Assert
            var ex = Assert.Throws<ArgumentException>(() => StringManipulator.Manipulator(input));
            Assert.That(ex.Message, Is.EqualTo("Input string cannot be null or empty."));
        }

        [TestCase("nepo", ExpectedResult = "openerent")]
        [TestCase("test", ExpectedResult = "tseteopen")]
        [TestCase("TEST", ExpectedResult = "TSETEopen")]
        [TestCase("test123", ExpectedResult = "321tseteopen")]
        [TestCase("tEsT", ExpectedResult = "TsEtEopen")]
        [TestCase("test 123", ExpectedResult = "321 tseteopen")]
        [TestCase("nEPo", ExpectedResult = "oPEnErent")]
        [TestCase("NePo", ExpectedResult = "oPeNerent")]
        public string Manipulator_ReturnsManipulatedString(string input)
        {
            //Arrange
            //Act
            var result = StringManipulator.Manipulator(input);

            //Assert
            return result;
        }
    }
}