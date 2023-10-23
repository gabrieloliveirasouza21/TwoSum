internal class Program {
    private static void Main(string[] args) {
        int[] arr = {4,3,2,5,8};
        int[] retorno = TwoSum(arr, 6);

        foreach(int i in retorno) {
            Console.Write(i + " ");
        }


        
        

    }

    public static int[] TwoSum(int[] nums, int target) {

        //O código a seguir é de complexidade O(n^2)

        //for (int i = 0; i < nums.Length; i++) {
        //    int atual = nums[i];
        //    for (int j = 0; j<nums.Length; j++) {
        //        if (j.Equals(i)) {
        //            continue;
        //        }
        //        if (atual + nums[j] == target) {
        //            return new int[] { i, j };
        //        }
        //    }
        //}

        //return new int[0];

        //---------------------------------------------------------

        //O código a seguir é de complexidade O(n)

        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {

            int falta =  target - nums[i];

            if (dic.ContainsKey(falta)){
                return new int[] { dic[falta], i };
            }

            dic[nums[i]] = i; 

        }
        return new int[0];
        
        //Esse código cria um hash map, percorre o array
        // e guarda a diferença entre o numero alvo e cada item do array
        // se tem esse numero dessa diferença no hash map, significa que um dos numeros
        // do array é essa diferença
        // então ele retorna um novo array com a posição desses membros
    }
}