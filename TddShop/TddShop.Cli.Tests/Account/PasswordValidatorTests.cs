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
        public void IsValid_ContainUpperCase_ShlouldIsTrue()
        {
            // Assert 
            var valid = new PasswordValidator();
            var password = "AVD";

            // Act
            var actual = valid.IsValid(password);

            // Assert
            Assert.That(actual, Is.True);
        }
    }
}
