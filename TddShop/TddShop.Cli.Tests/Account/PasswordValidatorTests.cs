using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddShop.Cli.Account;

namespace TddShop.Cli.Tests.Account
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        [Test]
        public void IsValid_Password_ShlouldIsTrue()
        {
            // Assert 
            var target = new PasswordValidator();

            // Act
            var password = "AAAss23@#r";
            var actual = target.IsValid(password);

            // Assert
            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsValid_Password_ShlouldIsFalse()
        {
            // Assert 
            var target = new PasswordValidator();

            // Act
            var password = "";
            var actual = target.IsValid(password);

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsValid_PasswordNotLength10_ShlouldIsFalse()
        {
            // Assert 
            var target = new PasswordValidator();

            // Act
            var password = "eqwe";
            var actual = target.IsValid(password);

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsValid_ContainUpperCase_ShlouldIsTrue()
        {
            // Assert 
            var target = new PasswordValidator();
            
            // Act
            var password = "AVD";
            var actual = target.IsValid(password);

            // Assert
            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsValid_ContainSpecialCharacters_ShlouldIsTrue()
        {
            // Assert 
            var target = new PasswordValidator();

            // Act
            var password = "!@#$";
            var actual = target.IsValid(password);

            // Assert
            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsValid_ContainLowerCase_ShlouldIsTrue()
        {
            // Assert 
            var target = new PasswordValidator();

            // Act
            var password = "er";
            var actual = target.IsValid(password);

            // Assert
            Assert.That(actual, Is.True);
        }
    }
}
