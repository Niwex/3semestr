package com.company;

import java.util.Scanner;

class Matric {
    public Matric(double x, double y){
        this.x = x;
        this.y = y;
    }
     public double x;
     public double y;
}

public class Main {

    public static void main(String[] args) {
	// write your code here
        int n = 2;
        Scanner scanner =new Scanner(System.in);
        System.out.print("Введите x и y : ");
        Matric xy = new Matric(scanner.nextDouble(),scanner.nextDouble());
        System.out.print("Введите Epselon : ");
        double eps = scanner.nextDouble();
        xy = method_Nutona(xy,eps,n);
        System.out.println("Xmin ("+xy.x +", "+xy.y+")");
    }


    //функция f(x y)
    static double f (double x , double y){
        double z;
        return   z =  Math.pow(x,2)-12*x+Math.pow(y,2)+6*y+45;
    }
    //первая производная
    static double f1 (double x,double y){
        double z = (12-2*x)/(2*y+6);
        return z;
    }

    static double f1x (double x){
        double z = (-12+2*x);
        return z;
    }
    static double f1y (double y){
        double z = (2*y+6);

        return z;
    }


    //вторая производная
    static double f2 (double x,double y){
        double z = -(2*(12-2*x)* f1(x,y)) / Math.pow((2*f(x, y)+6), 2) - 2/(2*f(x, y)+6);
        return z;
    }

    static double f2x (double x){
        double z = (2);
        return z;
    }
    static double f2y (double y){
        double z = (2);
        return z;
    }
    static double f2xy(double x, double y){
        double z = 0;
        return z;
    }



    public static Matric method_Nutona(Matric xy, double eps, int n) {
        double[][] gesse = new double[n][n];
        int  k = 0;
       while(true) {
           Matric gradient = new Matric(f1x(xy.x), f1y(xy.y));
           if (Math.sqrt(Math.pow(gradient.x, 2) + Math.pow(gradient.y, 2)) < eps) break;
            for (int i = 0 ; i< n; i++){
                for (int j = 0;j<n; j ++){
                    if (i == j && i<1)
                        gesse[i][j] = f2x(xy.x);
                    else if (i == j)
                        gesse[i][j] = f2y(xy.y);
                    else
                        gesse[i][j] = f2xy(xy.x,xy.y);
                }
            }
            double detG = gesse[0][0]*gesse[1][1] - gesse[1][0]*gesse[0][1];
            xy.x = xy.x - (1/4.)*(gesse[0][0]*gradient.x+ gesse[0][1]*gradient.y);
            xy.y = xy.y - (1/4.)*(gesse[1][0]*gradient.x+ gesse[1][1]*gradient.y);
            k++;
       }
       System.out.println("Кол-во итерацций - "+k);
        return xy ;
    }
}
