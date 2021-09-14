using System;


namespace PE8_5
{
    class Program
    {
        // Author :- RAJ BAROT
        // Purpose :- 
             /* Given the formula z = 3y2 + 2x - 1 write a console application to calculate z for the following ranges of x and y:
            -1 <= x <= 1 in 0.1 increments
            1 <= y <= 4 in 0.1 increments

            Use a 3-dimensional array double[,,] to store the values of x, y and z for each computation.  */

        static void Main(string[] args)
{
    {
        double xvalue, yvalue, zvalue;    // variables for x y z cordinates
        int nX = 0;
        int nY = 0;

        double[,,] zFun = new double[30, 40, 3];  

        // Traversing xvalue
        for (xvalue = -1; xvalue <= 1; xvalue += 0.1, ++nX)
        {
            xvalue = Math.Round(xvalue, 1);

            nY = 0;

                    //  Traversing yvalue

        for (yvalue = 1; yvalue <= 4; yvalue += 0.1, ++nY)
            {
                yvalue = Math.Round(yvalue, 1);
                zvalue = 3 * Math.Pow(yvalue, 2) + 2 * xvalue + 1;
                zvalue = Math.Round(zvalue, 3);

                // Store xvalue, yvalue and z 

                zFun[nX, nY, 0] = xvalue;
                zFun[nX, nY, 1] = yvalue;
                zFun[nX, nY, 2] = zvalue;
            }

        }
    }
}
}
}




