using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetInfo : MonoBehaviour {
    public Text PlanetInfoText;
    int rand;
    float counter;
    string[] planetInfo = {
        "Venus was named after the Goddess of love and beauty and is after the sun the brightest planet in our solarsystem."
            , "Mars is named after the Roman God of war because of it's red appearance. The red color is caused by the oxidated iron on the surface."
            , "Mercury is our fastest planet. It is named after the messenger of the Roman Gods, because it goes arround the sun in 88 days."
            , "Jupiter is the biggest planet in our solarsystem, and is therefore named after the Roman king."
            , "Saturn's rings consists of rocks, ice and dust."
            , "Uranus is rotated in a weird way, caused by a collision not long after its birth."
            , "Neptune is named after the Roman God of sea cause of its blue color. Neptune has 8 to 10 moons."
            , "Mars' moon Phobos gets about 2 meters closer to its parent planet every 100 years. And it's predicted that in 30 to 50 million years it will either collide, or break into planetary rings."
            , "Alpha Centauri is the closest solar system to our own."
            , "A planet that has a lot of similar aspects as the Earth is called a Superearth. An example of this is Kepler-22b."
            , "Mars used to have a similar climate to Earth. There are signs of erosion from flowing water and wind."
            , "Jupiter has a moon called Europe. It's covered in ice with beautiful patterns. There could be organisms under the ice."
            , "COROT-7b is a planet where rocks melt and rise up on the hot side, and fall back as rocks on the cold side. It rains rocks."
            , "On HD189733-b it rains molten shards of glass at windspeeds of up to 2 km per second."
            , "The earth has been proven to be spherical, not flat."
            , "Jupiter's mass is so great, it's gravitational force is 2.5 times as strong as on earth."
            , "The Mars Rovers called Spirit and Opportunity exceeded their 90-day mission lifetime by years. Opportunity is still operating to this day."
            , "Mars has the biggest volcano of our solarsystem. Called Olympus Mons, it stretches out 25 km in height and more than 600 km in width."
            , "It is predicted that the Andromeda Galaxy and the Milky Way will collide in 4 billion years. It is however improbable for solar systems to collide."
            , "The observable universe is about 8,800,000,000,000,000,000,000,000,000 kilometers in diameter, holding at least 2 trillion galaxies."
            , "The Boomerang Nebula, located 5000 lightyears from Earth, reaches a temperature of -272 Degrees Celcius. That is 1 Degree above Absolute Zero."
   };
    // Use this for initialization
    void Start () {
        rand = Random.Range(0, 21);
        PlanetInfoText.text = "Fact: \n" + planetInfo[rand];
	}

    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 15)
        {
            rand = Random.Range(0, 21);
            PlanetInfoText.text = "Fact: \n" + planetInfo[rand];
            counter = 0;
        }
    }
}
