package soujerire.a01;

import java.util.Scanner;

public class At01Ex06 {
    public static void main(String[] args) {
        Scanner scanner=new Scanner(System.in);
        int iChoix=askWood(scanner);
        String SNom=askName(scanner);
        double dLargeur=askMesurements(scanner);
        double dLongeur=askMesurements(scanner);
        scanner.close();
        double dPrixFinale

    }

    public static int askWood(Scanner scanner){
       int iChoix;
        
        do {

            System.out.println("Bonjour, veuillez choisir votre type de bois:");
            System.out.println("1 - Chêne 5$/m²");
            System.out.println("2 - Érable 12$/m²");
            System.out.println("3 - Pin 10$/m²");
            System.out.print("Votre choix: ");
            iChoix= scanner.nextInt();

                switch (iChoix) {
                    case 1:
                        iChoix=5;
                        return iChoix; 

                    case 2:
                        iChoix=10;
                        return iChoix;

                    case 3:
                        iChoix=15;
                        return iChoix;
        
                    default:
                        System.out.println("Vous devez choisir entre 1 et 3 svp");
                        break;
            
                } 
            
        
        } while ( iChoix < 1|| iChoix >3 );
        return 0; 
    }
}
