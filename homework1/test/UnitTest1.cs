namespace Store_Class;

public class UnitTest1
{
   Store store1 = new Store();
   //1.1
    [Fact]
     public void Test_String_Input(){
         store1.Name="Bam";
         Assert.IsType <string>(store1.Name);
     }
    [Fact]
     public void Test_Number(){
         store1.Number=435453453;
         Assert.IsType<double>(store1.Number);
     }
     [Fact]
     public void Test_exchange(){
         double testdata = 5120.25;
         int[] numtest = store1.exchange((float)testdata);
         int[] myNum = { 5, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1 };
         Assert.Equal(numtest,myNum);
     }
}
