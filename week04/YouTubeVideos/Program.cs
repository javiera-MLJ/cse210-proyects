using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Dua Lipa - Future Nostalgia (Official Lyrics Video)", "Dua Lipa", "3:07");
        video1.AddComment(new Comment("Giuliana_Abade", "This song is literally an introduction to the rest of the songs. It says EXACTLY what we should expect from the whole album. So iconic."));
        video1.AddComment(new Comment("wilcisco1159", "I love how retro sounding her songs are. She saves the 2019 music"));
        video1.AddComment(new Comment("sakuraisan6400", "FUTURE NOSTALGIA WON THE FREAKING GRAMMYs BEST POP VOCAL ALBUM"));
        video1.AddComment(new Comment("nickatnick4424", "Best Pop Album since 1989"));

        Console.WriteLine(video1.GetDisplayVideoInformation());

        Video video2 = new Video("Sing About Me, I'm Dying Of Thirst", "Kendrick Lamar", "12:03");
        video2.AddComment(new Comment("mufasa6272", "I was too young to appreciate how good this album was back in 2012, it actually sounds much better now that I'm older"));
        video2.AddComment(new Comment("Fazzarelli", "12 minutes of pure genius. Can't stop listening. So glad I stumbled on this. Kendrick Lamar has saved hip-hop."));
        video2.AddComment(new Comment("eskereit", "Soo good there's no need to have a music video. Kendrick is arguably the GOAT, unarguably the most complete and conscious rapper ever."));
        video2.AddComment(new Comment("candig879", "This is still a vibe"));

        Console.WriteLine(video2.GetDisplayVideoInformation());

        Video video3 = new Video("Slipknot - Duality [OFFICIAL VIDEO] [HD]", "Slipknot", "3:37");
        video3.AddComment(new Comment("mammontustado9680", "This is the greatest fan-appreciation music video ever made, even Slayer never made anything close to this."));
        video3.AddComment(new Comment("jonfisher9214", "This is so wholesome when you consider how closely they interact with their fans."));
        video3.AddComment(new Comment("marcnixon3007", "It's ironic that people who listen to this are actually the nicest people you'll ever meet."));
        video3.AddComment(new Comment("rabisidan0517", "you know you goin crazy when you feel like this type of music is relaxing"));

        Console.WriteLine(video3.GetDisplayVideoInformation());
    }
}