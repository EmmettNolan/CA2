using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    public class Activity : IComparable
    {
        public enum terrain { Land, Water, Air }

        // Properties
        public DateTime ActivityDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public terrain TypeOfActivity { get; set; }

        //Constructors
        public int CompareTo(object obj)
        {
            Activity that = obj as Activity;
            return this.ActivityDate.CompareTo(that.ActivityDate);
        }

        public Activity(string name, DateTime activityDate, decimal cost, string description,  terrain typeofActivity)
        {
            ActivityDate = activityDate;
            Name = name;
            Description = description;
            Cost = cost;
            TypeOfActivity = typeofActivity;
        }


        public Activity()
        {
        }


        //Methods
        public override string ToString()
        {
            return $"{Name} - {ActivityDate}";
        }
    }
}
