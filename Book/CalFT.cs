public class CalFT{
    public  static double FT_1(){
        double[] Value_1 = new double [12]
        {10.2,7.3,8.4,5.6,9.3,4.6,1.2,7.5,8.2,4.3,6.0,7.0};
        double sum =0;
        for (int i = 0;i < 12;i++){
            sum = sum+Value_1[i];
        }
        return sum;
    }

    public static double FT_2(){
        double[] Value_2 = new double [12]
        {9.2,5.2,8.9,7.1,9.3,2.2,1.7,5.2,9.1,8.4,2.1,2.3};
        double sum =0;
        for (int i = 0;i < 12;i++){
            sum = sum+Value_2[i];
        }
        return sum;
    }

    public static double FT_3(){
        double[] Value_3 = new double [12]
        {17.2,19,23,25.1,31,32.1,17.0,14,11.3,18.1,19.2,22};
        double sum =0;
        for (int i = 0;i < 12;i++){
            sum = sum+Value_3[i];
        }
        return sum;
}
    public static double FT_4(){
        double[] Value_4 = new double [12]
        {2.1,2.0,1.1,1.5,3.2,4.1,2.2,2.2,1.3,1.4,5.0,4.1};
        double sum =0;
        for (int i = 0;i < 12;i++){
            sum = sum+Value_4[i];
        }
        return sum;}

    public static double FT_5(){
        double[] Value_5 = new double [12]
        {17.2,20,23,25.1,31,4.1,17.0,14,11.3,5.0,19.2,22};
        double sum =0;
        for (int i = 0;i < 12;i++){
            sum = sum+Value_5[i];
        }
        return sum;}
    public  static double[] Sum_FT(){
        double[] Sum = {FT_1(),FT_2(),FT_3(),FT_4(),FT_5()};
        return Sum;
    }
    
}