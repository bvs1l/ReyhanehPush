package soujerire.a01;

import java.util.Scanner;

public class At01Ex03 {
public static void main(String[] args) {
    Scanner scanner= new Scanner(System.in);
int iAge1= askAge (scanner);
int iAge2= askAge(scanner);
    scanner.close();
    averageAge(iAge1, iAge2);
}
public static int askAge (Scanner scanner){
System.out.println("Veuillez entrer l' age svp:");
int iAge=scanner.nextInt();
return iAge;
}

public static void averageAge(int iAge1, int iAge2) {
   System.out.println("La moyenne de vos 2 ages est "+ (iAge2*iAge1)/2); 
}
}


