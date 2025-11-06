package soujerire.a02;

import java.util.Scanner;

public class At02Ex02 {
public static void main(String[] args) {
    Scanner scanner= new Scanner(System.in);
    String SPhrase= askWords(scanner);
    scanner.close();
    showNb(SPhrase);

}

public static String askWords(Scanner scanner){
    System.out.print("Bonjour, veuillez entrer une chaine de carctère:");
    String SPhrase=scanner.nextLine();
    return SPhrase;
    
}
public static void showNb(String SPhrase){
    int iNb=SPhrase.length();
    System.out.println(iNb);
}
}
