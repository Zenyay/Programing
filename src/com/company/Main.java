package com.company;

import java.util.ArrayList;
import java.util.Date;
import java.util.Random;

public class Main {

    public static void main(String[] args) {
	// write your code here
        Random myRandom = new Random();
        int num = myRandom.nextInt();
        System.out.println(num);
        Random anotherRandomGenerator = new Random();
        double number = anotherRandomGenerator.nextDouble();
        System.out.println(number);

        ArrayList<Integer> myList = new ArrayList<>();
        myList.add(12);
        myList.add(14);
        int Num = myList.size();
        int Number = myList.get(0);
        int nmbr = myList.get(1);
        int NMBR = myList.set(0,5);
        NMBR = myList.get(0);
        int Nmbr = myList.get(1);
        myList.clear();
        int n = myList.size();
        System.out.println(Num);
        System.out.println(Number);
        System.out.println(nmbr);
        System.out.println(NMBR);
        System.out.println(Nmbr);
        System.out.println(n);

        Date currentDate = new Date();
        Date anotherDate = new Date();
        String curDateString = currentDate.toString();
        anotherDate.setTime(123478);
        boolean TF = currentDate.before(anotherDate);
        System.out.println(curDateString);
        if(TF == true)
        {
            System.out.println("current date is before another date");
        }
        else if(TF == false)
        {
           System.out.println("current date is after another date");
        }
    }
}
