using System;
namespace Algorithms.Immutable
{
    public  sealed  class Age
    {
        private readonly int age;

        private Age(){}
        private Age(int age)
        {
            age = age;
        }

        private static Age of(int age) {
            return new Age(age);
        }

        public Age grow_up() {
            return new Age(age + 1);
        }

        public int getAge() {
            return age;
        }
    }
}
