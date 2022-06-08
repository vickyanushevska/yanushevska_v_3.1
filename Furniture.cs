using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    public class Furniture : IEquatable<Furniture>
    {

        public string FurnitureName { get; set; }
        public int FurnitureId { get; set; }


        public override string ToString()
        {
            return "ID: " + FurnitureId + "   Name: " + FurnitureName;
        }


        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Furniture objAsFurniture = obj as Furniture;
            if (objAsFurniture == null) return false;
            else return Equals(objAsFurniture);
        }


        public override int GetHashCode()
        {
            return FurnitureId;
        }


        public bool Equals(Furniture other)
        {
            if (other == null) return false;
            return (this.FurnitureId.Equals(other.FurnitureId));
        }
    }
}
