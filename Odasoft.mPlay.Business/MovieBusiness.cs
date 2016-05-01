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
            string[] title = new string[] { "Calle Cloverfield 10", "Mad Max", "Capitan America: Guerra Civil", "El Renacido", "Zootopia", "Deadpool", "Batman vs Superman", "Spotlight", "Misión Rescate", " Trumbo"};
            string[] genre = new string[] {"Ciencia ficción, Thriller psicológico", "Acción", "Acción, Aventura, Ciencia ficción", "Drama, Thriller", "Animación, Aventura", "Acción, Comedia", "Acción, Ciencia ficción", "Drama", "Drama", "Drama"};
            string[] description = new string[] {
                "Tras un accidente de tráfico, una joven despierta en un sótano, donde tiene lugar la mayor parte de la acción. Teme haber sido secuestrada por un supervivencialista, que le cuenta que le salvó la vida y que, en la superficie, el mundo es un lugar inhabitable debido a un ataque químico o nuclear. Sin saber muy bien qué creer, decide que debe escapar de ese lugar, sea cual sea el peligro al que deba enfrentarse en el exterior.",
                "La ley y la sociedad ya no existe en este mundo formado por una páramo desértico, pero sí que hay sangre, fuego y muerte. Sin embargo, hay dos rebeldes que son capaces de restaurar el orden perdido, por un lado está Max, que sigue buscando su propia paz tras la muerte de su mujer y su hijo; y por otro lado está Imperator Furiosa, una misteriosa mujer que trata de sobrevivir en este peligroso viaje hacia su hogar.",
                "'Capitán América: Civil War' sigue a Steve Rogers liderando al nuevo equipo de Vengadores en sus continúos esfuerzos para mantener a salvo a la humanidad. Pero después de los daños colaterales de otro incidente en el que el grupo de superhéroes está involucrado, la presión política instala un sistema de responsabilidad encabezado por el Gobierno para supervisar y dirigir al equipo. El nuevo ‘status quo’ provoca la ruptura de los Vengadores y da como resultado dos bandos -uno liderado por Steve Rogers y su deseo de que los superhéroes sigan siendo libres para defender a la humanidad sin la intromisión del Gobierno y otro liderado por Tony Stark que decide apoyar la decisión de la clase dirigente.",
                "Año 1823. En las profundidades de la América salvaje, el explorador Hugh Glass (Leonardo DiCaprio) participa junto a su hijo mestizo Hawk en una expedición de tramperos que recolecta pieles. Glass resulta gravemente herido por el ataque de un oso y es abandonado a su suerte por un traicionero miembro de su equipo, John Fitzgerald (Tom Hardy). Con la fuerza de voluntad como su única arma, Glass deberá enfrentarse a un territorio hostil, a un invierno brutal y a la guerra constante entre las tribus de nativos americanos, en una búsqueda implacable para conseguir vengarse.",
                "Se trata de un buddy movie («cine de acción de colegas») protagonizada por animales antropomórficos que viven en la ciudad de Zootopia. El zorro Nick Wilde ayudará a la primera coneja policía, Judy Hopps, para resolver un caso, por qué en una ciudad en la cual los herbívoros y los carnívoros siempre han convivido, estos últimos se han vuelto salvajes.",
                "Basado en el anti-héroe menos convencional de la Marvel, Deadpool narra el origen de un ex-operativo de la fuerzas especiales llamado Wade Wilson, reconvertido a mercenario, y que tras ser sometido a un cruel experimento adquiere poderes de curación rápida, adoptando Wade entonces el alter ego de Deadpool. Armado con sus nuevas habilidades y un oscuro y retorcido sentido del humor, Deadpool intentará dar caza al hombre que casi destruye su vida.",
                "Temiendo las consecuencias que las acciones de un superhéroe con poderes casi divinos podrían ocasionar si no están supervisadas, Batman, el formidable justiciero de Gotham, viaja a Metrópolis para confrontar a Superman, el salvador más reverenciado, mientras el mundo lucha con la interrogante de qué tipo de héroe realmente necesita. Con Batman y Superman enfrentados entre sí, una nueva amenaza pronto cobra fuerza, poniendo a toda la humanidad ante un peligro como nunca antes se conoció.",
                "En 2002, un equipo de reporteros de investigación del Boston Globe destapó los escándalos de pederastia cometidos durante décadas por curas de Massachussets. La publicación de estos hechos, que la archidiócesis de Boston intentó ocultar, sacudió a la Iglesia Católica como institución.",
                "Durante una misión tripulada a Marte, el astronauta Mark Watney es dado por muerto tras una feroz tormenta y es abandonado por su tripulación. Pero Watney ha sobrevivido y se encuentra atrapado y solo en el planeta hostil. Con suministros escasos, deberá recurrir a su ingenio y a su instinto de supervivencia para encontrar la manera de comunicar a la Tierra que él está vivo.",
                "En 1940, la exitosa carrera del guionista Dalton Trumbo (Bryan Cranston) llega a un abrupto final cuando él y otras figuras de Hollywood son incluidos en una lista negra por sus creencias políticas. Trumbo cuenta la historia de su lucha contra el gobierno y los jefes de estado de Estados Unidos en una guerra por la palabra y la libertad."
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
