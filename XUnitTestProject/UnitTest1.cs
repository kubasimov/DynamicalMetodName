using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void WhenCarStart_ThenPower_100()
        {
            // arrange
            var car = new Car();

            // act
            car.Start();

            // assert
            Assert.Equal(100, car.Power);
        }

        [Fact]
        public void WhenCarStop_ThenPower_0()
        {
            // arrange
            var car = new Car();

            // act
            car.Stop();

            // assert
            Assert.Equal(0, car.Power);
        }

        [Fact]
        public void WhenCarBack_ThenPower_Minus100()
        {
            // arrange
            var car = new Car();

            // act
            car.Back();

            // assert
            Assert.Equal(-100, car.Power);
        }

        [Theory]
        [InlineData("Start",100)]
        [InlineData("Stop",0)]
        [InlineData("Back",-100)]
        public void StartCarMethodByStringSwitch(string s,int i)
        {
            // arrange
            var car = new Car();

            // act
            switch (s)
            {
                case "Start":
                    car.Start();
                    break;
                case "Stop":
                    car.Stop();
                    break;
                case "Back":
                    car.Back();
                    break;
                default:
                    break;
            }

            // assert
            Assert.Equal(i, car.Power);
        }

        [Theory]
        [InlineData("Start", 100)]
        [InlineData("Stop", 0)]
        [InlineData("Back", -100)]
        public void StartCarMethodByStringIf(string s, int i)
        {
            // arrange
            var car = new Car();

            // act
            if (s== "Start")car.Start();
            if(s=="Stop")car.Stop();
            if(s=="Back")car.Back();

            // assert
            Assert.Equal(i, car.Power);
        }

        [Theory]
        [InlineData("Start", 100)]
        [InlineData("Stop", 0)]
        [InlineData("Back", -100)]
        public void StartCarMethodByStringDynamical(string s, int i)
        {
            // arrange
            var car = new Car();

            var type = typeof(Car);
            var method = type.GetMethod(s);

            // act
            method.Invoke(car,null );

            // assert
            Assert.Equal(i, car.Power);
        }
    }
}
