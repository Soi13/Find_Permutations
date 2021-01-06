class Program
    {

        public static double factorial(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial(number - 1);
        }


        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> final_res = new List<IList<int>>();

            if (nums.Length == 1)
            {
                final_res.Add(nums.ToList());
                return (IList<IList<int>>)final_res;
            }

            double fact = factorial(nums.Length);
            int cnt_iter = (Convert.ToInt32(fact) / (nums.Length - 1)) - 1;

            for (int u = 0; u <= cnt_iter; u++)
            {
                for (int i = 0; i <= nums.Length - 2; i++)
                {                    
                    int tmp_num = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = tmp_num;

                    final_res.Add(nums.ToList());                    
                }
            }

            return (IList<IList<int>>)final_res;
           
        }


        static void Main(string[] args)
        {
            
            int[] nums = new int[] { 5,4,6,2 };

            IList<IList<int>> res = new List<IList<int>>();
            res = Permute(nums);

            
            for (int t = 0; t <= res.Count - 1; t++)
            {
                for (int y = 0; y <= res[t].Count - 1; y++)
                {
                    Console.Write(res[t][y]);
                }
                Console.Write("\n");
            }
            
            
        
            Console.ReadKey();
        }
    }
