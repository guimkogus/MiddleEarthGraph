public class MiddleEarth
{
    private static MiddleEarth instance = new MiddleEarth();
    public Graph map;

    private MiddleEarth()
    {
        this.map = new Graph(getAllLocations());
        setEdges(this.map);
    }

    private static string[] getAllLocations()
    {
        return new string[] {
                "Hobbiton", // 0
                "Sarn Ford", // 1
                "Far Downs", // 2
                "White Downs",  // 3
                "Old Forest", // 4
                "Barrow Downs", // 5
                "Bree", // 6
                "Greenway", // 7
                "Chetwood", // 8
                "East-West Road", // 9
                "Last Bridge", // 10
                "Trollshaws", // 11
                "Rivendell's Ford", // 12
                "Rivendell", // 13
                "Rivendell's Old Ford", // 14
                "Eregion", // 15
                "Moria Gate", // 16
                "Glanduin", // 17
                "Lórien", // 18
                "The Great River", // 19
                "Gladden Fields", // 20
                "North Undeep", // 21
                "The Wold", // 22
                "South Undeep", // 23
                "Sarn Gebir", // 24
                "Mering Stream", // 25
                "Dead Marshes", // 26
                "Morannon", // 27
                "Minas Morgul", // 28
                "Minas Tirith", // 29
                "Morgai", // 30
                "Isenmouthe", // 31
                "Barad Dur", // 32
                "Orodruin" // 33
            };
    }

    private static string[] getRoadToOrodruin()
    {
        return new string[] {
                "Hobbiton",
                "Old Forest",
                "Bree",
                "East-West Road",
                "Last Bridge",
                "Trollshaws",
                "Rivendell's Ford",
                "Rivendell",
                "Eregion",
                "Moria Gate",
                "Lórien",
                "The Great River",
                "North Undeep",
                "South Undeep",
                "Sarn Gebir",
                "Dead Marshes",
                "Morannon",
                "Minas Morgul",
                "Morgai",
                "Isenmouthe",
                "Orodruin"
            };
    }

    private static void setEdges(Graph map)
    {
        // add edges between the locations that Froddo has passed thru
        string[] roadToOrodruinLocations = getRoadToOrodruin();
        for (int i = 0; i < roadToOrodruinLocations.Length - 1; i++)
        {
            map.addEdge(roadToOrodruinLocations[i], roadToOrodruinLocations[i + 1]);
        }

        // add secondary edges between all locations
        string[] allLocations = getAllLocations();
        // Hobbiton neighbors
        map.addEdge(allLocations[0], allLocations[1]);
        map.addEdge(allLocations[0], allLocations[2]);
        map.addEdge(allLocations[0], allLocations[3]);
        // Old Forest neighbors
        map.addEdge(allLocations[4], allLocations[5]);
        // Bree neighbors
        map.addEdge(allLocations[6], allLocations[7]);
        map.addEdge(allLocations[6], allLocations[8]);
        // Rivendell neighbors
        map.addEdge(allLocations[13], allLocations[14]);
        // Moria Gate neighbors        
        map.addEdge(allLocations[16], allLocations[17]);
        // Great River neighbors
        map.addEdge(allLocations[19], allLocations[20]);
        // North Undeep neighbors
        map.addEdge(allLocations[21], allLocations[22]);
        // Sarn Gebir neighbors        
        map.addEdge(allLocations[24], allLocations[25]);
        // Minas Morgul neighbors        
        map.addEdge(allLocations[28], allLocations[29]);
        // Isenmouthe neighbors        
        map.addEdge(allLocations[31], allLocations[32]);
    }

    public static MiddleEarth getInstance()
    {
        return instance;
    }
}