internal class Program {
    private static void Main(string[] args) {
        int[] arr = {6,7,4,2};
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

        foreach (var s in sums) {
            Console.WriteLine(s);
        }

        
        int[] arrFinal = { 0, 0 };
        foreach (var s in sums) {
            if (s.Value.Equals(target)) {

                char[] chaves = s.Key.ToCharArray();
                //Console.WriteLine("chaves[0] " + chaves[0]);
                //Console.WriteLine("chaves[1] " + chaves[2]);
                arrFinal[0] = chaves[0] - 48;
                arrFinal[1] = chaves[2] - 48;
                break;
            }
        }

        foreach (var s in arrFinal) {
            Console.WriteLine(s);
        }

        //return arrFinal;
    }
}