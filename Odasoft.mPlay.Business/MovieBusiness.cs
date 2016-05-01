using Odasoft.mPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Business
{
    public class MovieBusiness
    {
        public MovieBusiness()
        {

        }

        public int NumberOfMovies()
        {
            return this.GetMovies().Count;
        }

        public ICollection<Movie> GetMovies()
        {
            var movies = new List<Movie>();
            int[] id = new int[] {0,1,2,3,4,5,6,7,8,9};
            string[] title = new string[] { "10 Cloverfield Lane", "Mad Max", "Capitan America: Civil War", "The Revenant", "Zootopia", "Deadpool", "Batman vs Superman", "Spotlight", "The Martian", " Trumbo"};
            string[] genre = new string[] {"Sci-fi, Psychological Thriller", "Action", "Action, Adventure, Sci-fi", "Drama, Thriller", "Animation, Adventure", "Action, Comedy", "Action, Sci-fi", "Drama", "Drama", "Drama"};
            string[] description = new string[] {
                "After surviving a car accident, Michelle (Mary Elizabeth Winstead) wakes up to find herself in an underground bunker with two men. Howard (John Goodman) tells her that a massive chemical attack has rendered the air unbreathable, and their only hope of survival is to remain inside. Despite the comforts of home, Howard's controlling and menacing nature makes Michelle want to escape. After taking matters into her own hands, the young woman finally discovers the truth about the outside world.",
                "Years after the collapse of civilization, the tyrannical Immortan Joe enslaves apocalypse survivors inside the desert fortress the Citadel. When the warrior Imperator Furiosa (Charlize Theron) leads the despot's five wives in a daring escape, she forges an alliance with Max Rockatansky (Tom Hardy), a loner and former captive. Fortified in the massive, armored truck the War Rig, they try to outrun the ruthless warlord and his henchmen in a deadly high-speed chase through the Wasteland.",
                "Political pressure mounts to install a system of accountability when the actions of the Avengers lead to collateral damage. The new status quo deeply divides members of the team. Captain America (Chris Evans) believes superheroes should remain free to defend humanity without government interference. Iron Man (Robert Downey Jr.) sharply disagrees and supports oversight. As the debate escalates into an all-out feud, Black Widow (Scarlett Johansson) and Hawkeye (Jeremy Renner) must pick a side.",
                "While exploring the uncharted wilderness in 1823, frontiersman Hugh Glass (Leonardo DiCaprio) sustains life-threatening injuries from a brutal bear attack. When a member (Tom Hardy) of his hunting team kills his young son (Forrest Goodluck) and leaves him for dead, Glass must utilize his survival skills to find a way back to civilization. Grief-stricken and fueled by vengeance, the legendary fur trapper treks through the snowy terrain to track down the man who betrayed him.",
                "From the largest elephant to the smallest shrew, the city of Zootopia is a mammal metropolis where various animals live and thrive. When Judy Hopps (Ginnifer Goodwin) becomes the first rabbit to join the police force, she quickly learns how tough it is to enforce the law. Determined to prove herself, Judy jumps at the opportunity to solve a mysterious case. Unfortunately, that means working with Nick Wilde (Jason Bateman), a wily fox who makes her job even harder.",
                "Wade Wilson (Ryan Reynolds) is a former Special Forces operative who now works as a mercenary. His world comes crashing down when evil scientist Ajax (Ed Skrein) tortures, disfigures and transforms him into Deadpool. The rogue experiment leaves Deadpool with accelerated healing powers and a twisted sense of humor. With help from mutant allies Colossus and Negasonic Teenage Warhead (Brianna Hildebrand), Deadpool uses his new skills to hunt down the man who nearly destroyed his life.",
                "It's been nearly two years since Superman's (Henry Cavill) colossal battle with Zod (Michael Shannon) devastated the city of Metropolis. The loss of life and collateral damage left many feeling angry and helpless, including crime-fighting billionaire Bruce Wayne (Ben Affleck). Convinced that Superman is now a threat to humanity, Batman embarks on a personal vendetta to end his reign on Earth, while the conniving Lex Luthor (Jesse Eisenberg) launches his own crusade against the Man of Steel.",
                "In 2001, editor Marty Baron of The Boston Globe assigns a team of journalists to investigate allegations against John Geoghan, an unfrocked priest accused of molesting more than 80 boys. Led by editor Walter Robinson (Michael Keaton), reporters Michael Rezendes (Mark Ruffalo), Matt Carroll and Sacha Pfeiffer interview victims and try to unseal sensitive documents. The reporters make it their mission to provide proof of a cover-up of sexual abuse within the Roman Catholic Church.",
                "When astronauts blast off from the planet Mars, they leave behind Mark Watney (Matt Damon), presumed dead after a fierce storm. With only a meager amount of supplies, the stranded visitor must utilize his wits and spirit to find a way to survive on the hostile planet. Meanwhile, back on Earth, members of NASA and a team of international scientists work tirelessly to bring him home, while his crew mates hatch their own plan for a daring rescue mission.",
                "In 1947, successful screenwriter Dalton Trumbo (Bryan Cranston) and other Hollywood figures get blacklisted for their political beliefs."
            };
            string[] image = new string[] {
                "http://www.10cloverfieldlane.com/images/10cl_poster.jpg",
                "http://img09.deviantart.net/4cda/i/2015/118/e/d/poster_3_fury_road_mad_max_by_cesaria_yohann-d8rd450.jpg",
                "http://www.eonline.com/eol_images/Entire_Site/201627/rs_634x940-160307074539-634.captain-america-civil-war-poster-chris-evans-robert-downey-jr.3716.jpg",
                "http://i.imgur.com/l6SozVJ.jpg",
                "http://cdn3-www.comingsoon.net/assets/uploads/gallery/zootopia/c55463169023e916571b0361c592cd6c0f630904.jpg",
                "http://cdn.traileraddict.com/content/20th-century-fox/deadpool-poster-10.jpg",
                "http://media.comicbook.com/2016/01/batmanvsupermanwhowillwinposter-167083.jpg",
                "http://i.dailymail.co.uk/i/pix/2015/08/21/01/2B89064B00000578-0-image-a-25_1440115471750.jpg",
                "http://www.joblo.com/posters/images/full/the-martian-poster.jpg",
                "http://cdn.traileraddict.com/content/universal-pictures/trumbo2015-2.jpg"
            };

            //Movies generated locally
            for (int i = 0; i < 10; i++)
            {
                movies.Add(new Movie
                {
                    Id = id[i],
                    Title = title[i],
                    ReleaseDate = DateTime.Today.Date,
                    Genre = genre[i],
                    Price = 180,
                    Description = description[i],
                    Length = "1:50:20",
                    Image = image[i]
                });
            }
            return movies;
        }

        public Movie GetMovieById(int MovieId)
        {
            var MovieById = this.GetMovies().ToList()
                .FindAll(x => x.Id == MovieId).FirstOrDefault();

            return MovieById;
        }

        public Movie CreateMovie(Movie model)
        {
            //this function will edit a movie in the db
            return model;
        }

        public Movie EditMovie(Movie model)
        {
            //this function will edit a movie in the db
            return model;
        }

        public void DeleteMovie(int AlbumId)
        {
            //this function will delete a movie in the db
        }
    }
}
