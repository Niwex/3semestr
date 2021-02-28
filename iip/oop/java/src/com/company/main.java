package com.company;

import java.util.Scanner;

public class main {

    public static void main(String[] args) {
        // write your code here
        String a = "fasffa";
        MyArray arr1  = new MyArray(8);
        MyArray arr2 = new MyArray(8);

        String newArray = MyArray.poelemSceplenie(arr1,arr2);
        System.out.println(newArray);
    }
}
