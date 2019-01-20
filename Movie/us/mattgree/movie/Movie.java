package us.mattgree.movie;

import java.util.Objects;

public class Movie {
    private String name;
    private Rating rating;
    private Genre genre;

    public Movie(String name, Rating rating, Genre genre) {
        this.name = name;
        this.rating = rating;
        this.genre = genre;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Rating getRating() {
        return rating;
    }

    public void setRating(Rating rating) {
        this.rating = rating;
    }

    public Genre getGenre() {
        return genre;
    }

    public void setGenre(Genre genre) {
        this.genre = genre;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof Movie)) return false;
        Movie movie = (Movie) o;
        return Objects.equals(getName(), movie.getName()) &&
                getRating() == movie.getRating() &&
                getGenre() == movie.getGenre();
    }

    @Override
    public int hashCode() {
        return Objects.hash(getName(), getRating(), getGenre());
    }

    @Override
    public String toString() {
        return "Movie{" +
                "name='" + name + '\'' +
                ", rating=" + rating +
                ", genre=" + genre +
                '}';
    }
}
