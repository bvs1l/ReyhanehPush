package soujerire.a01;

import java.util.Scanner;

public class At01Ex05 {
public static void main(String[] args) {
    Scanner scanner= new Scanner(System.in);
    double dPrix= askPrice(scanner);
    scanner.close();
    prixFinale(dPrix);
   

}


public static double askPrice(Scanner scanner) 
{
    System.out.print("Entrer un montant d'argent: ");
    double dPrix=scanner.nextInt();
        return dPrix;
}

public static void prixFinale(double dPrix ) {
    double dPrixFinal =dPrix-(dPrix*0.25);
   System.out.printf("Votre montant total est de %.2f avec un rabais de 25%%\n", dPrixFinal); 
}
}
