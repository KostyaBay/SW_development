using design_pattern_composite;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestForCommand_easy()
        {
            var warlord = new Warlord();
            var actual = warlord.Warlord_easy();
            var expected = "RESULT: Soldier: I obey, sir!";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForCommand_medium()
        {
            var warlord = new Warlord();
            var actual = warlord.Warlord_medium();
            var expected = "RESULT: Transfer(Transfer(Soldier: I obey, sir! + Soldier: I obey, sir!)";    //Warlord: Now I've give a medium command: \n RESULT: Transfer(Transfer(Soldier: I obey, sir! + Soldier: I obey, sir!))     
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForCommand_hard()
        {
            var warlord = new Warlord();
            var actual = warlord.Warlord_hard();
            var expected = "RESULT: Transfer(Transfer(Soldier: I obey, sir! + Soldier: I obey, sir!) + Transfer(Soldier: I obey, sir!))";    //Warlord: I don't need to check the my subordinates even when giving the hard command: \n RESULT: Transfer(Transfer(Soldier: I obey, sir! + Soldier: I obey, sir!) + Transfer(Soldier: I obey, sir!) + Soldier: I obey, sir!)";     
            Assert.Equal(expected, actual);
        }

    }
}
