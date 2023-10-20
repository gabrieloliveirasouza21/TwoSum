internal class Program {
    private static void Main(string[] args) {
        int[] arr = {2,4,6,7};
        TwoSum(arr, 6);
        

    }

    public static void TwoSum(int[] nums, int target) {

        if (nums.Length < 2) {
            Console.WriteLine("menor que 2 elementos");
        }

        Dictionary<string,int> sums = new Dictionary<string,int>();

        for (int i = 0; i < nums.Length - 1; i++) {
            int contador = i + 1;
            sums.Add(i.ToString() + " "+ contador.ToString(), nums[i] + nums[i+1]);
        }

        
        int[] arrFinal = new int[2];
        foreach (var s in sums) {
            if (s.Value.Equals(target)) {

                char[] chaves = s.Key.ToCharArray();

                arrFinal[0] = chaves[0];
                arrFinal[1] = chaves[1];
                //return arrFinal;
            }
        }

        foreach (var s in arrFinal) {
            Console.WriteLine(s);
        }

        //return arrFinal;
    }
}