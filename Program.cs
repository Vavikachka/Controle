int count=3;
string[] Array1= {"3","Vika","))","90","File","78","City"};
string [] Array2= new string [count];
Console.Write("{");
ChangesArray(Array2,Array1);
Console.Write("}");

void ChangesArray(string [] arr2,string  [] arr1){
    for(int i=0; i<arr2.Length;i++){
        arr2[i]=arr1[i];
        Console.Write($"{arr2[i]} ");
    }
}