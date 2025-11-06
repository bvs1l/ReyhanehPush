package soujerire.a01;

import java.util.Scanner;

public class At01Ex01 {

public static void main(String[] args) {
    Scanner scanner= new Scanner(System.in);

    int iNb1 =askNumber(scanner);
    int iNb2 =askNumber(scanner);
        scanner.close();
        compareNumber(iNb1, iNb2);
}
public static int askNumber(Scanner scanner){
 System.out.print("Entrer un nombre svp: ");
 int iNb=scanner.nextInt();

    return  iNb;
}
  
public static void compareNumber(int iNb1, int iNb2) {
    if (iNb1>iNb2) {
        System.out.println("Votre premier nombre " + iNb1 +", est plus élévé que votre deuxième nombre "+ iNb2  + "." ) ;
    }
    else if (iNb1<iNb2) {
            System.out.println("Votre deuxième nombre " + iNb2 + ", est plus élévé que votre premier nombre " + iNb1+".");
    }
    else {
        System.out.println("Vos deux nombres "+iNb1+" et "+iNb2+" sont équivalents.");
    }
    
}
}


