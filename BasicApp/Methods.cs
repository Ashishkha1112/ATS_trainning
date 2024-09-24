using System.Data;
using System.Runtime.Intrinsics.X86;

class Methods{

   public void SayHello(){
    Console.WriteLine("Hey, There!!!");
    }

public void SayHello(String greetings){
       Console.WriteLine(greetings);
    }
public string SayHello(String greetings,string hello){
    return $"{greetings} \n{hello.ToUpper()}";
}
// get variable 
public float GetVariable(params int[] number){
    float av;
    
    return av
}


}