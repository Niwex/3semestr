package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        // ввод начальных данных
        int n = 10;
        float h, e, l = 3;
        float[] y, x, dy;
        x = new float[n];
        y = new float[n];
        dy= new float[n];
        x[0] = 0;

        Scanner scaner;
        scaner = new Scanner(System.in);
        System.out.print("введите значение вц y(0) :  ");
        y[0] = scaner.nextFloat();
        System.out.print("введите epselon : ");
        e = scaner.nextFloat();

        h = (l - x[0]) / n;

        method_Milna(x, y,dy, l, n, h, e);

    }
// y'=y y(0) = 1 , x E [0, 3]

    private static float f(float x, float y) {
        return y;
    }

    public static float Runge_Kutt(float[] yn, float[] xn, float h, int n) {
        float k1 = f(xn[n], yn[n]);
        float k2 = f(xn[n] + h / 2, yn[n] + h / 2 * k1);
        float k3 = f(xn[n] + h / 2, yn[n] + h / 2 * k2);
        float k4 = f(xn[n] + h, yn[n] + h * k3);
        float y = yn[n] + h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
        xn[n + 1] = xn[n] + h;
        return y;
    }

    public static void method_Milna(float[] x, float[] y, float[] dy, float l, int n, float h , float e) {
        // первые 4 y;
        for (int i = 0; i < 3; i++) {
            y[i + 1] = Runge_Kutt(y, x, h, i);
        }
        //заполняем первые 4 производных
        for (int i = 0;i<4;i++){
            dy[i]= f(x[i],y[i]);
        }


        for (int p =4;p<n;p++) {
            // первая формули Миллна
            y[p] = (float) (y[p - 4] + 4. / 3 * h * (2 * f(x[p - 3], y[p - 3]) - f(x[p - 2], y[p - 2]) + 2 * f(x[p - 1], y[p - 1])));
            x[p] = x[p-1]+h;
            dy[p] = f(x[p],y[p]);
            float temp = f(x[p],y[p]), temp2 =0;

            while(true) {
                // вторая формула милна (уточняющая)
                y[p] = y[p-2]+h/3*(temp +4*dy[p-1]+dy[p-2]);
                temp2 = f(x[p], y[p]);
                float eps =  Math.abs(temp - temp2);
                if (eps < e) break;
                temp = temp2 ;
            }
            dy[p] = temp2;
            y[p] = y[p-2]+h/3*(dy[p]+4*dy[p-1]+dy[p-2]);

        }
        System.out.println("№ \t x \t\t\t y \t\t\t dy");
        for (int i = 0; i< n; i++){
            System.out.format("%d \t %.1f \t %.4f \t %.4f%n",i, x[i],y[i],dy[i]);
        }

    }
}
