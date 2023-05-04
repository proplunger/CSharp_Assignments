namespace Assignmentdll
{
    public   class NumericFunctions
    {
        public   int Add(params int[] ar) {
            int sum = 0;
            for (int i=0;i<ar.Length;i++) {
                sum += ar[i];
            } 
            return sum; 
        }

        public   int Subtract(int num1, int num2) {
            return num1 - num2;
        }

        public   int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public  int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public  int FindMAX(params int[] ar) {
            return ar.Max();
        }

        public  int FindMin(params int[] ar) {
        return ar.Min();
        }

        public  bool CheckOdd(int num) {
            if (num % 2 != 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public  bool CheckEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  bool CheckPrime(int num)
        {
            if (num==0||num==1) { return false; }
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }       
            }
            return true;
        }

    }
}