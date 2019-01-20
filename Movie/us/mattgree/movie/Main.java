package us.mattgree.movie;

public class Main {

    public static void main(String[] args) {
        MovieDB movieDB = new MovieDB();
        ConsoleUI con = ConsoleUI.getUI();
        boolean moreTasks = true;
        do {
            Choices choice = con.getChoice();
            switch (choice) {
                case LIST: con.outputMovies(movieDB.getAllMovies());break;
                case BYRATING: con.outputMovies(movieDB.getAllMoviesByRating(con.getRating()));break;
                case BYGENRE: con.outputMovies(movieDB.getAllMoviesByGenre(con.getGenre()));break;
                case DELETE:
                    System.out.println(movieDB.deleteMovieByIndex(con.getMovieToDelete(movieDB.getAllMovies())));break;
                case EXIT: moreTasks=false;
            }
        } while(moreTasks);
    }
}
