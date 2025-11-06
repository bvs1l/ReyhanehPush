package soujerire.a02;

import java.util.Scanner;

public class At02Ex01 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String SReponse=askPass(scanner);
        scanner.close();
        showcasePass(SReponse);

     }

    public static String askPass(Scanner scanner){
        
 
        //Lecture d'un mot de passe ou d'une phrase
        System.out.print("entrer le mot de passe ou le mot que vous désirez : ");
        String SReponse = scanner.nextLine();
        return SReponse;
        
    }

     public static void showcasePass(String SReponse){

        //Réponse en majuscule
        System.out.println(SReponse.toUpperCase());
 
     }
 
    
}

