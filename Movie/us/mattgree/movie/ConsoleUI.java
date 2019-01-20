package us.mattgree.movie;

import java.util.List;
import java.util.Scanner;

public class ConsoleUI {
    private static ConsoleUI UI = new ConsoleUI();
    private ConsoleUI() { }
    private static Scanner keyboard = new Scanner(System.in);
    public static ConsoleUI getUI() {
        return UI;
    }

    public void outputMovies(List<Movie> m) {
        for (int i=0;i<m.size();i++) {
            System.out.println(i + ":" + m.get(i));
        }
    }

    public Choices getChoice() {
        boolean moreChoices=true;
        String input=null;
        do {
            System.out.print("'1' List Movies\n'2' Select Rating\n'3' Select Genre\n'4' Delete\n'5' Exit\nPlease enter choice: ");
            input=keyboard.nextLine();
            switch (input.trim()) {
                case "1": return Choices.LIST;
                case "2": return Choices.BYRATING;
                case "3": return Choices.BYGENRE;
                case "4": return Choices.DELETE;
                case "5": moreChoices=false;return Choices.EXIT;
                default:
                    System.out.println("Please enter a number between 1 and 5.");
            }
        } while (moreChoices);
        return null;
    }

    public int getMovieToDelete(List<Movie> m) {
        boolean notANumber=true;
        String input=null;
        int currentNumber=0;
        outputMovies(m);
        do {
            System.out.println("Please enter number to Delete: ");
            input=keyboard.nextLine();
            try
            {
                if(input != null && input.trim().length() > 0)
                {
                    currentNumber = Integer.parseInt(input);
                    notANumber=false;
                }
            }
            catch (NumberFormatException ex )
            {
                System.out.println("Not a valid Number.");
            }
        } while (notANumber);
        return currentNumber;
    }

    public Rating getRating() {
        String input=null;
        do {
            System.out.print("'1' G\n'2' PG\n'3' PG-13\n'4' R\n'5' NR\nPlease enter rating: ");
            input=keyboard.nextLine();
            switch (input.trim()) {
                case "1": return Rating.G;
                case "2": return Rating.PG;
                case "3": return Rating.PG13;
                case "4": return Rating.R;
                case "5": return Rating.NR;
                default:
                    System.out.println("Please enter a number between 1 and 5.");
            }
        } while (true);
    }

    public Genre getGenre() {
        String input=null;
        do {
            System.out.print("'1' Action\n'2' Child's Cartoon\n'3' Comedy\n'4' Drama\n'5' Epics\n'6' Horror\n'7' Musicals\n'8' Romance\n'9' SciFi\n'10' War\nPlease enter Genre : ");
            input=keyboard.nextLine();
            switch (input.trim()) {
                case "1": return Genre.ACTION;
                case "2": return Genre.CHILDCARTOON;
                case "3": return Genre.COMEDY;
                case "4": return Genre.DRAMA;
                case "5": return Genre.EPICS;
                case "6": return Genre.HORROR;
                case "7": return Genre.MUSICALS;
                case "8": return Genre.ROMANCE;
                case "9": return Genre.SCIFI;
                case "10": return Genre.WAR;
                default:
                    System.out.println("Please enter a number between 1 and 10.");
            }
        } while (true);
    }
}
