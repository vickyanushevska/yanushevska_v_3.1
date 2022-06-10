using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Shop
    {
        public void main()
        {
            List<Furniture> things = new List<Furniture>();

            // Add parts to the list.
            things.Add(new Furniture() { FurnitureName = "brown table", FurnitureId = 1234 });
            things.Add(new Furniture() { FurnitureName = "wooden chair", FurnitureId = 1334 });
            things.Add(new Furniture() { FurnitureName = "plastic window", FurnitureId = 1434 });
            things.Add(new Furniture() { FurnitureName = "double bed", FurnitureId = 1444 });
            things.Add(new Furniture() { FurnitureName = "glass doors", FurnitureId = 1534 });
            things.Add(new Furniture() { FurnitureName = "ceiling lamp", FurnitureId = 1634 });

            // Write out the parts in the list. This will call the overridden ToString method
            // in the Part class.
            Console.WriteLine();
            foreach (Furniture aFurniture in things)
            {
                Console.WriteLine(aFurniture);
            }

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Select search type: 1 - search by FurnitureId; 2 - search by FurnitureName");
            int number = 1;
            while (number != 0)
            {
                number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        // Check the list for part #1734. This calls the IEquatable.Equals method
                        // of the Part class, which checks the PartId for equality.
                        int idnumber;
                        Console.WriteLine("Input the Id number: ");
                        idnumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Contains: Furniture with this Id number : {0}",
                            things.Contains(new Furniture { FurnitureId = idnumber, FurnitureName = "" }));
                        Console.WriteLine("--------------------------------------------------------------------------");
                        continue;

                    case 2:
                        // Find items where name contains "seat".
                        string name;
                        Console.WriteLine("Input the Name:");
                        name = (Console.ReadLine());
                        Console.WriteLine("Find: Furniture with this word: {0}",
                            things.Find(x => x.FurnitureName.Contains($"{name}")));
                        Console.WriteLine("--------------------------------------------------------------------------");
                        continue;
                    case 0:
                        break;

                    default:
                        Console.WriteLine("Input the right number or word.");
                        continue;
                }
            }
        }
    }
 }

