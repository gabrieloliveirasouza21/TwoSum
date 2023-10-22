internal class Program {
    private static void Main(string[] args) {
        int[] arr = {4,3,2,5,8};
        int[] retorno = TwoSum(arr, 6);

        foreach(int i in retorno) {
            Console.Write(i + " ");
        }


        
        

    }

    public static int[] TwoSum(int[] nums, int target) {

        for (int i = 0; i < nums.Length; i++) {
            int atual = nums[i];
            for (int j = 0; j<nums.Length; j++) {
                if (j.Equals(i)) {
                    continue;
                }
                if (atual + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }

        return new int[0];


    }
}