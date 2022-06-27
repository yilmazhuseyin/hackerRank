using System;
using System.Collections.Generic;
using System.IO;
class Solution {

static void displayPathtoPrincess(int n, String [] grid){
  int k = 0;
        int mPosFirst = 0;
        int mPosSec = 0;
        int pPosFirst = 0;
        int pPosSec = 0;
        int firstPosDif = 0;
        int secondPosDif = 0;
        List<string> moves = new List<string>();

        while (k < n)
        {
            for (int i = 0; i < n; i++)
            {
                if (grid[k][i] == 'm')
                {
                    mPosFirst = k;
                    mPosSec = i;
                }else if(grid[k][i] == 'p')
                {
                    pPosFirst = k;
                    pPosSec = i;
                }
            }
            k++;
        }

        firstPosDif = mPosFirst - pPosFirst;

        if(firstPosDif < 0)
        {
            for (int i = 0; i < Math.Abs(firstPosDif); i++)
            {
                moves.Add("DOWN");
            }
        }else if(firstPosDif > 0)
        {
            for (int i = 0; i < firstPosDif; i++)
            {
                moves.Add("UP");
            }
        }

        secondPosDif = mPosSec - pPosSec;

        if (secondPosDif < 0)
        {
            for (int i = 0; i < Math.Abs(secondPosDif); i++)
            {
                moves.Add("RIGHT");
            }
        }
        else if (secondPosDif > 0)
        {
            for (int i = 0; i < secondPosDif; i++)
            {
                moves.Add("LEFT");
            }
        }

        foreach (var item in moves)
        {
            Console.WriteLine(item);
        }
  }

static void Main(String[] args) {
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid  = new String[m];
        for(int i=0; i < m; i++) {
            grid[i] = Console.ReadLine(); 
        }

        displayPathtoPrincess(m,grid);
     }
}
