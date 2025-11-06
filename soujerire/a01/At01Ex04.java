package soujerire.a01;

import java.util.Scanner;

public class At01Ex04 {

    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);
        int iNote= askGrade(scanner);
        scanner.close();
        receiveResults(iNote);
    }
    public static int askGrade(Scanner scanner){
        System.out.println("Entrer votre note de math sur 100:");
        int iNote=scanner.nextInt();
        return iNote;
    }

    public static void receiveResults(int iNote){
        if (iNote>59) {
            System.out.println("Félicitations, vous avez passé!");
        }
        else   {
            System.out.println("Malheureusement, vous n'avez pas passé!");
        }
    }
}
