using System.ComponentModel.Design;

namespace ConditionalRefactoring
{
    public class ConditionalRefactoring
    {
        public static int Invert(int x)
        {
            if (x != 3)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        public static int RedundantElse(int x)
        {
            if (x < 3)
            {
                return 1;
            }
            else if (x < 10)
            {
                return 10;
            }
            if (x < 30)
            {
                return 30;
            }
            return 0;
        }

        public static bool DeMorgan(int x)
        {
            return !(x != 5 && x != 7);
        }

        public static int Join_AND(int x, int y)
        {
            if (x == 3)
            {
                if (y == 4)
                {
                    return x + y;
                }
            }
            return 0;
        }

        public static int Split_AND(int x, int y)
        {
            if (x == 3 && y == 4)
            {
                return x + y;
            }
            return 0;
        }

        public static bool Join_OR(int x, int y)
        {
            if (x >= 0)
            {
                return true;
            }

            if (y <= 3)
            {
                return true;
            }

            return y == 10;
        }

        public static bool Split_OR(int x, int y)
        {
            if (x >= 0 || y <= 3 || y == 10)
            {
                return true;
            }

            return false;
        }

        public static int Join_Statements(int x, int y)
        {
            var result = 0;
            var factor = 1;
            if (x > 3)
            {
                factor = x;
            }
            if (x > 3)
            {
                result += y * 3;
            }

            return result * factor;
        }

        public static int Split_Statements(int x, int y)
        {
            var result = 0;
            var factor = 1;
            if (x > 3)
            {
                result += y * 3;
                factor = x;
            }

            return result * factor;
        }

        public static int Normalize(string s1, string s2)
        {
            if (!s1.Equals("hello"))
            {
                if (!s2.Equals("world"))
                {
                    if (!s1.Equals("foo"))
                    {
                        return 6;
                    }

                    return 1;
                }
                else if (!s1.Equals("foo"))
                {
                    return 2;
                }
            }
            else
            {
                if (s2.Equals("bar"))
                {
                    return 3;
                } else if (!s2.Equals("world"))
                {
                    return 4;
                }
                return 5;
            }
            return 0;
        }
    }
}