package soujerire.a01;

import java.util.Scanner;

public class At01Ex02 {

    public static void main(String[] args) {
    Scanner scanner= new Scanner(System.in);
    int iSalaire= askSalary(scanner);
    int iNbHeures= askHours(scanner);
        scanner.close();
        weeklySalary(iNbHeures, iSalaire);
 }

 public static int askSalary(Scanner scanner) {
    System.out.println("Entrer votre salaire /heure: ");
    int iSalaire=scanner.nextInt();
    return iSalaire;
    
 }

 public static int askHours(Scanner scanner) {
    System.out.println("Entrer votre nombre d'heures travaillés par semaine: ");
    int iNbHeures=scanner.nextInt();
    return iNbHeures;
 }
   
 public static void weeklySalary(int iNbHeures, int iSalaire) {
    System.out.println("Votre salaire par semaine est de " + (iNbHeures*iSalaire)*2+" .");

    
 }
}
