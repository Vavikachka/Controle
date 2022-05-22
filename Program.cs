string[] Array1= {"35","Vika","))","97","File","7","City"};
int count=Array1.Length;
string [] Array2=new string [count];
ChangesArray(Array1,Array2);

void ChangesArray(string  [] arr1,string [] arr2){
    for(int i=0; i<arr1.Length;i++){
        int len=arr1[i].Length;
        if(len<=3){ 
         int i1=0;
         arr2[i1]=arr1[i];
         Console.Write($"{arr2[i1]} ");
         i1++;
        }
    }
}


