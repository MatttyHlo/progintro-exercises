double[] temperatures = {21.5, 23.7, 19.6, 22.5, 25.3, 21.7, 18.9};

for(int i =0; i <= 6; i++){
    Console.WriteLine(Math.Round((temperatures[i+1] - temperatures[i])*10)/10);
}
