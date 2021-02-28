package com.company;

public class LU_razloshenie {
    //
    public LU_razloshenie(float[][] matrixA, float[] matrixB, int n) {
        this.matrixA = new float[n][n];
        this.matrixA = matrixA;
        this.matrixB = new float[n];
        this.matrixB = matrixB;
        this.matrixU = new float[n][n];
        this.matrixL = new float[n][n];
        this.n = n;
        // Элементы матрицы A переносим в матрицу U а матрицу L обнуляем;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                this.matrixU[i][j] = this.matrixA[i][j];
            }
        }
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                this.matrixL[i][j] = 0;
            }
        }
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                this.matrixL[i][j] = 0;
            }
        }
        // из матрицы А создем две треуголные матрицы L и U;
        //формируем первый столбец матрицы L
        for (int i = 0; i < n; i++) {
            for (int j = i; j < n; j++)
                matrixL[j][i] = matrixU[j][i] / matrixU[i][i];
        }
        // формируем матрицы L и U до конца;
        for (int k = 1; k < n; k++) {
            for (int i = k - 1; i < n; i++)
                for (int j = i; j < n; j++)
                    matrixL[j][i] = matrixU[j][i] / matrixU[i][i];

            for (int i = k; i < n; i++)
                for (int j = k - 1; j < n; j++)
                    matrixU[i][j] = matrixU[i][j] - matrixL[i][k - 1] * matrixU[k - 1][j];
        }
    }

    public void show(String a, int n) {
        if (a == "U") {
            System.out.println("Матрицу U :");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    System.out.print(matrixU[i][j] + "\t");
                }
                System.out.println();
            }
        }
        if (a == "L") {
            System.out.println("Матрицу L :");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    System.out.print(matrixL[i][j] + "\t");
                }
                System.out.println();
            }
        }
        if (a == "A") {
            System.out.println("Изначальная матрица A: ");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    System.out.print(matrixA[i][j] + "\t");
                }
                System.out.println();
            }
        }
        if (a == "R") {
            System.out.println("Результат перемножения матриц L и U: ");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    System.out.print(R[i][j] + "\t");
                }
                System.out.println();
            }
        }
    }

    void myp(int n) {
        float[][] R = new float[n][n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                for (int k = 0; k < n; k++)
                    R[i][j] += matrixL[i][k] * matrixU[k][j];
        this.R = R;
        show("R", n);
    }
    // метод решения слау
    void reshenie_SLAU() {
        float[] y = new float[n];
        // сначала находим матрицу y
        y[0] = matrixB[0] / matrixL[0][0];
        System.out.println("Матрица y(U*x):");
        System.out.println(y[0]);
        for (int k = 2; k < n; k++) {

            for (int i = 1; i <=k; i++) {
                float sum = matrixB[i];
                int temp=0;
                for (int j = 0; j < i; j++) {
                    sum -= matrixL[i][j] * y[j];
                    temp = j;
                }
                y[i] = sum/matrixL[i][temp+1];
                System.out.println(y[i]);
            }
        }
        //затем матрицу решений
        float[] x = new float [n];
        x[n-1]= y[n-1]/matrixU[n-1][n-1];
        System.out.println("");
        System.out.println(x[n-1]);
        for (int k = n-3; k >=0; k--) {

            for (int i = n-2; i >=k; i--) {
                float sum = y[i];
                int temp=i;
                for (int j = n-1; j > i; j--) {
                    sum -= matrixU[i][j] * x[j];
                    temp = j;
                }
                x[i] = sum/matrixU[i][temp-1];
                System.out.println(x[i]);
            }
        }
        System.out.print("Найденные x : ");
        for (int i = 0; i < n; i++)
            System.out.print( "x"+i+" = "+x[i] + "\t");
        System.out.println(")");
    }

    int n = 4;
    float[][] matrixA;
    float[] matrixB;
    float[][] matrixL;
    float[][] matrixU;
    float[][] R;
}
