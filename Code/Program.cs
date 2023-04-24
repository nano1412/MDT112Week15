using System;

class Program{
  static void Main(string[] args){
  }


  static void Print(string[,] table, int x_Axis, int y_Axis){
    if(x_Axis < table.GetLength(0) && x_Axis >=0 && y_Axis < table.GetLength(1) && y_Axis >=0){
      Console.WriteLine(table[x_Axis,y_Axis]);
    } else {
      Console.WriteLine("No one is there");
    }
  }

  static void StudentScore(){
    float[,] Score = new float[5,5];
    for(int i = 0; i <5; i++){
      for(int j =0;j < 5; j++){
        Console.Write("student {0} score {1}:",i+1,j+1);
        Score[i,j] = float.Parse(Console.ReadLine());
      }
    }

    for(int i = 0; i <5; i++){
      float sum = 0;
      Console.Write("Student {0} Score is:", i+1);
      for(int j =0;j < 5; j++){
        sum += Score[i,j];
        Console.Write("{0} ",Score[i,j]);
      }
      Console.WriteLine(" Total Score: {0}", sum);
    }
  }

  static void StudentTable(){
    int n = int.Parse(Console.ReadLine());
    string[] table = new string[n];

    int frontLine = int.Parse(Console.ReadLine());

    for(int i = 0; i < table.Length;i++){
      table[i] = Console.ReadLine();
    }

    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());

    Console.WriteLine(table[(y*frontLine)+x]);
  }
  static void StudentScore2(){
    int n = int.Parse(Console.ReadLine());
    int column = int.Parse(Console.ReadLine());
    int row = (n/column) + 1;
    int counter = 0;

    string[,] table = new string[row,column];

    for(int i = 0; i < row; i++){
      for(int j = 0; j < column;j++){
        if(counter >= n){
          break;
        }
        counter++;
        table[i,j] = Console.ReadLine();
      }
    }

    Console.WriteLine("position");
    int y_Axis = int.Parse(Console.ReadLine());
    int x_Axis = int.Parse(Console.ReadLine());

    Print(table,x_Axis,y_Axis);
    Print(table,x_Axis,y_Axis-1);
    Print(table,x_Axis-1,y_Axis);
    Print(table,x_Axis,y_Axis+1);
    Print(table,x_Axis+1,y_Axis);

  }
}
