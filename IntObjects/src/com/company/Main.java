package com.company;

import org.omg.PortableInterceptor.SYSTEM_EXCEPTION;

import java.util.ArrayList;
import java.util.Date;
import java.util.Random;

public class Main {

    public static void main(String[] args) {
	// write your code here
        Random myRandom = new Random();
        Random anotherRandomGenerator = new Random();
        System.out.println(myRandom.nextInt());
        System.out.println(anotherRandomGenerator.nextDouble());
        System.out.println(myRandom.nextInt());
        System.out.println(anotherRandomGenerator.nextDouble());

        ArrayList<Integer>  myList = new ArrayList<>();
        myList.add(12);
        System.out.println(myList.size());
        myList.add(14);
        System.out.println(myList.size());
        System.out.println(myList.get(0));
        System.out.println(myList.get(1));
        myList.set(0,5);
        System.out.println(myList.get(0));
        System.out.println(myList.get(1));
        myList.clear();
        System.out.println(myList.size());

        Date currentDate = new Date();
        Date anotherDate = new Date();

        String curDateString = currentDate.toString();
        System.out.println(curDateString);
        anotherDate.setTime(123478);
        boolean isBefore = currentDate.before(anotherDate);
        if (isBefore = true){
            System.out.println("current date is before another date");
        }
        else if (isBefore = false){
            System.out.println("current date is after another date");
        }

    }
}
