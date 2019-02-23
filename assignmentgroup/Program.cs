using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentgroup
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
class JournalEntry
{
    public JournalEntry(string note, int dist)
    {
        villageName = note; distanceTraveled = dist;
        HowFarToGetBack = distanceTraveled;
    }
    public int HowFarToGetBack = 0;
    private string villageName;
    private int distanceTraveled;
    public int getDistanceWalked() { return distanceTraveled; }
    public string getVillageName() { return villageName; }
}
class Hugi
{
    private static JournalEntry je;
    public static bool FoundAstrilde = false;

    public static List<JournalEntry> HugiJournal = new List<JournalEntry>();

    public static int CalculateDistanceWalked()
    {
        int DistanceWalked = 0;
        // go down the list and add the distances
        foreach (var je in HugiJournal)
        {
            Console.WriteLine(" {0}  --   {1} *** --- {2} ", je.getDistanceWalked(), je.getVillageName(), je.HowFarToGetBack);
            DistanceWalked += je.getDistanceWalked() + je.HowFarToGetBack;
        }
        return DistanceWalked;
    }
}
class Village
{
    // http://www.vikinganswerlady.com/measurement.shtml

    public Village(string _villageName, bool _isAHere)
    {
        isAstrildgeHere = _isAHere;
        VillageName = _villageName;
    }
    public void VillageSetup(int _prevVillageDist, Village _westVillage, Village _eastVillage)
    {
        east = _eastVillage;
        west = _westVillage;
        distanceFromPreviousVillage = _prevVillageDist;
    }

    public Village west;
    public Village east;
    public string VillageName;
    public int distanceFromPreviousVillage;
    public bool isAstrildgeHere;
}
