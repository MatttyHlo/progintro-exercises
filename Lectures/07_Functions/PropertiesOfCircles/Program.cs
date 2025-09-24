void Properties(int r){
    Console.WriteLine($"for radius {r} Area fo cirecle is: {Math.PI*r*r}, Circumference of circle is {2*Math.PI*r}");
}

int[] radiuses = {1,3,5};
foreach(int i in radiuses) Properties(i);

