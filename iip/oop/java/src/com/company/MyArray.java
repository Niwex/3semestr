package com.company;

import java.util.Scanner;
import java.lang.String;


public class MyArray {

    private int stringlengh = 8;
    private String string;

    public MyArray(int a1) {

        stringlengh = a1;

        boolean bool = true;
        while (bool) {
            Scanner scanner = new Scanner(System.in);
            string = scanner.nextLine();
            if (string.length() > stringlengh) {
                System.out.println("Введенная строка привышает лимит символов. Лимит символов: " + stringlengh);
            } else bool = false;
        }
    }

    public MyArray(String s1) {
        string = s1;
    }


    public int getStringlengh() {
        return stringlengh;
    }

    public void setStringlengh(int n) {
        stringlengh = n;
    }

    public String getsString() {
        return string;
    }

    public void setString(String newString) {
        string = newString;
    }
    // поэлементное сцепление 2 масивов в новый
    public static String poelemSceplenie(MyArray arr1, MyArray arr2) {
        String newString = "";
        String arr1String = arr1.getsString();
        String arr2String = arr2.getsString();
        System.out.println(arr1String);
        System.out.println(arr2String);
        int leng1 = arr1String.length() - 1;
        int leng2 = arr2String.length() - 1;
        System.out.println(leng1);
        System.out.println(leng2);
        for (int i = 0; i < (arr1.stringlengh); i++) {
            char a, b;
                if (i<= leng1){
                    a = arr1String.charAt(i);
                    newString+=a;
                }

                if (i<=leng2) {
                    b = arr2String.charAt(i);
                    newString+=b;
                }
            //newString=newString+arr1String.charAt(i)+arr2String.charAt(i+1);
        }
        return newString;
    }

}
