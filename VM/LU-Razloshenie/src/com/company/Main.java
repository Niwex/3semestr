package com.company;

public class Main {

    public static void main(String[] args) {
	// Задаем матрицы необходиммой размерности;
        float [][] matrixA ={
                {2,1,4},
                {3,2,1},
                {1,3,3}
        };
        float [] matrixB ={16,10,16};
        int n = 3;
        LU_razloshenie razlosh = new LU_razloshenie(matrixA,matrixB,n);
        razlosh.show("A", n);
       // razlosh.doLUmatrixes(3);
        razlosh.show("U",n);
        razlosh.show("L", n);
        System.out.println();
        razlosh.myp(n);
        System.out.println();
        razlosh.reshenie_SLAU();
    }
}
