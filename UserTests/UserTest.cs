using System.ComponentModel;

namespace LaunchMod1Week5Assessment
{
    public class UserTest
    {
        [Fact]
        public void UserIsCreatedWithName_Email_AndNotLoggedIn()
        {
            var user1 = new User("Sam", "Samkriser@gmail.com", "1234");
            Assert.Equal("Sam", user1.Name);
            Assert.Equal("Samkriser@gmail.com", user1.Email);
            Assert.False(user1.IsLoggedIn);

        }

        [Fact]

        public void IsSetupCompleteReturnsTrueWithPassword()
        {
            var user1 = new User("Sam", "Samkriser@gmail.com", "1234");
            var test = user1.IsSetupComplete();
            Assert.True(test);
        }


        [Fact]
        public void CreatePasswordCreatesPasswordWhenEmailsMatch()
        {
            var user1 = new User("Sam", "Samkriser@gmail.com", "1234");
            user1.CreatePassword("Samkriser@gmail.com", "12345");
            Assert.Equal("12345", user1.Password);
        }

        [Fact]
        public void PasswordConfirmationConfirmsPresenceOfPasswrd()
        {
            var user1 = new User("Sam", "Samkriser@gmail.com", "1234");
            user1.CreatePassword("Samkriser@gmail.com", "12345");
            string test = user1.PasswordConfirmation();
            Assert.Equal("Password Created", test);
        }

        [Fact]
        public void LogInLogsInWhenPasswordMatches()
        {
            var user1 = new User("Sam", "Samkriser@gmail.com", "1234");
            string test = user1.LogIn("1234");
            Assert.Equal("Logged In", test);
        }

        [Fact]
        public void LogInFailsWhenPasswordsDontMatch()
        {
            var user1 = new User("Sam", "Samkriser@gmail.com", "1234");
            string test = user1.LogIn("12345");
            Assert.Equal("Not Logged In", test);
        }

        [Fact]
        public void LogOutLogsUserOut()
        {
            var user1 = new User("Sam", "Samkriser@gmail.com", "1234");
            user1.LogOut();
            Assert.False(user1.IsLoggedIn);
        }

    }
}