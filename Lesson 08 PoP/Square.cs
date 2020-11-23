using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_PoP
{
    public class Square
    {
        private int[,][] matrixX;
        private int[,][] matrixY;
        internal int sideLength;

        //Constructor
        public Square(int sideLength)
        {
            matrixX = new int[2, 2][];
            matrixY = new int[2, 2][];
            int counter = 0;
            for(int i = 0; i<matrixX.GetLength(0); i++)
            {
                for(int j = 0; j<matrixX.GetLength(1); j++)
                {
                    matrixX[i, j] = new int[2];
                    matrixX[i, j][0] = counter; // Corner Number
                    matrixX[i, j][1] = counter; // X coordinate
                    counter++;
                }
            }

            counter = 0;
            for (int i = 0; i < matrixY.GetLength(0); i++)
            {
                for (int j = 0; j < matrixY.GetLength(1); j++)
                {
                    matrixY[i, j] = new int[2];
                    matrixY[i, j][0] = counter;  // Corner Numer
                    matrixY[i, j][1] = counter; // Y coordinate
                    counter++;
                }
            }

            this.sideLength = sideLength;
        }

        //Priority
        public int SideLength
        {
            get { return this.sideLength; }
            set
            {
                sideLength = value;
            }
        }

        //Methods
        public void Move(int corner, int newX, int newY)
        {
            int a = -1;
            int b = -1;
            int counter = 0;
            for (int i = 0; i < matrixX.GetLength(0); i++)
            {
                for (int j = 0; j < matrixX.GetLength(1); j++)
                {
                    if(matrixX[i,j][0] == corner)
                    {
                        a = i;
                        b = j;
                        counter++;
                    }
                }
            }
            if(counter == 0)
            {
                Console.WriteLine("The corner written doesn't exist!");
            }
            else
            {
                matrixX[a, b][1] = newX;
                matrixY[a, b][1] = newY;
            }
        }

        public void Scale(int scaleFactor)
        {
            this.sideLength = sideLength * scaleFactor;
        }

        public string toString()
        {
            string data = "";
            for (int i = 0; i < matrixX.GetLength(0); i++)
            {
                for (int j = 0; j < matrixX.GetLength(1); j++)
                {
                    data = data + "Corner (" + matrixX[i,j][1] + ", " + matrixY[i, j][1] + "), side " + sideLength + "\n";                    
                }
            }
            return data;
        }
    }
}
