using design_pattern_composite;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestForCommand()
        {
            var soldier = new Soldier();
            var actual = soldier.Command();
            var expected = "Soldier: I obey, sir!";
            Assert.Equal(expected, actual);
        }
    }
}
