using System;
namespace PortalsRPG.Models
{
    public class Location : ILocation
    {
        //properties
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }

        //what class type-data will need to extend to a location? are these best served as properties?
        public Quest QuestAvailable { get; set; }
        public Artifact ArtifactRequired { get; set; }
        public Npc NpcInteraction { get; set; }

        //object type properties for player moves:
        public Location MoveNorth { get; set; }
        public Location MoveEast { get; set; }
        public Location MoveWest { get; set; }
        public Location MoveSouth { get; set; }

        //create an instance of where the player is at as they move
        //public string UpdateLocation { get; set; }

        //struct
        public Location(int locID, string locName, string locDescript)
        {
            LocationID = locID;
            LocationName = locName;
            LocationDescription = locDescript;
        }

        public string DisplayLocation()
        {

            return "Current location: " + LocationName + " " + LocationDescription + " \n";
        }

        public void MovePlayer()
        {
            throw new NotImplementedException();
        }
    }
}
