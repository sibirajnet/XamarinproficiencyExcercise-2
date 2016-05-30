using System;
using Xunit;
using PCLMock;
using PasswordKata.Tests.Mocks;
using FluentAssertions;
namespace PasswordKata.Tests
{
	public class PasswordVerifierFixtures
	{
        [Theory]
        [InlineData(null, false)]
        [InlineData("xyz", true)]
        public void Password_Should_Not_Be_Null(string password, bool expected)
        {
            PasswordVerifier_Argument_Null_Mock password_verifier = new PasswordVerifier_Argument_Null_Mock(password);
            bool actual = password_verifier.Verify();
            Assert.Equal(expected, actual);
        }
        public void Password_Should_Be_Larger_Than_8_Chars(string password, bool expected)
        {
            PasswordVerifier_8_Chars_Mock password_verifier = new PasswordVerifier_8_Chars_Mock(password);
            bool actual = password_verifier.Verify();
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("abcdef", false)]
        [InlineData("abcDef", true)]
        public void Password_Check_Uppercase_Letter(string password, bool expected)
        {
            PasswordVerifier_Uppercase_Mock password_verifier = new PasswordVerifier_Uppercase_Mock(password);
            bool actual = password_verifier.Verify();
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("ABCD", false)]
        [InlineData("ABCd", true)]
        public void Password_Check_Lowercase_Letter(string password, bool expected)
        {
            PasswordVerifier_lowercase_Mock password_verifier = new PasswordVerifier_lowercase_Mock(password);
            bool actual = password_verifier.Verify();
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("xyz", false)]
        [InlineData("zxy2", true)]
        public void Password_Check_Numebr(string password, bool expected)
        {
            PasswordVerifier_Number_Mock password_verifier = new PasswordVerifier_Number_Mock(password);
            bool actual = password_verifier.Verify();
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(null, false)]
        public void Password_check_Feature_2(string password, bool expected)
        {

            var sut = new PasswordVerifierBuilder_Feature_2().WithPassword("PASSWORDTEST");
            sut.Build().Verify().Should().Be(true);

        }
	}
   
}
