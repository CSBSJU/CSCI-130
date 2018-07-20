* Based on Lab09 from CSCI 140.
  * The problem will be the following:
    * You are given a file with a user ratings for X number of movies, no
      missing entires.
    * Your job is, given the ratings for X-1 movies for a user, what do you
      predict that they will rate the movie with no ratingl
    * To do this, you will find the user who is most similar to the user for the
      movies that do have ratings, then use their rating for the missing movie
      as the rating for the query user.
    * https://grouplens.org/datasets/movielens/
      * Use one of these datasets, choose columns and users to create a matrix
        with no empty entries.
    * https://www.kaggle.com/c/predict-movie-ratings
