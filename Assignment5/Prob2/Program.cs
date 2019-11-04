/*
Author: Torin Tashima
Date:   November 2, 2019
CTEC 135: Microsoft Software Development with C#

Module 6, Programming Assignment 5, Problem 2

    XML Using LINQ

    The Main() method should call the methods described below.

    1. Create a static method that creates an XML document and saves it.
        See pages 3 and 10 in Appendix B
    2. Create a static method that creates an XML document from an array and
        saves it. See page 12 in Appendix B
    3. Create a static method that loads an XML document and prints it to the
        screen. You can load the doc created in 2 above. See page  13 in
        Appendix B. Note that all I am asking for is for you to load the
        document and print. You can ignore the parsing part of the book's
        example code.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace for LINQ to XML
using System.Xml.Linq;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call method for step 1
            CreateXmlDoc();

            // Call method for step 2
            CreateXmlDocFromArray();

            // Call method for step 3
            LoadXmlDoc();
        }

        // Input: N/A
        // Process: Create XML document using LINQ to XML and save it
        // Output: N/A
        static void CreateXmlDoc()
        {
            // XML document initialization
            XElement doc =
                new XElement("NinetiesPlaylist",
                    new XElement("Song00", new XAttribute("ID", "1"),
                        new XElement("Title", "Creep"),
                        new XElement("Year", "1992"),
                        new XElement("Band", "Radiohead"),
                        new XElement("Key", "GMajor")
                    ),
                    new XElement("Song01", new XAttribute("ID", "2"),
                        new XElement("Title", "SmellsLikeTeenSpirit"),
                        new XElement("Year", "1991"),
                        new XElement("Band", "Nirvana"),
                        new XElement("Key", "Fminor")
                    ),
                    new XElement("Song02", new XAttribute("ID", "3"),
                        new XElement("Title", "Today"),
                        new XElement("Year", "1993"),
                        new XElement("Band", "SmashingPumpkins"),
                        new XElement("Key", "EbMajor")
                    )
                );

            // Save XML document
            doc.Save("LinqPlaylist.xml");
        }

        // Input: Use array to fill in attributes and elements of XML document
        // Process: Create XML document using LINQ to XML from array and save it
        // Output: N/A
        static void CreateXmlDocFromArray()
        {
            // Create array of anonymous types
            var students = new[]
            {
                new {FirstName = "Blaze", Age = 16},
                new {FirstName = "Damian", Age = 17},
                new {FirstName = "Ken", Age = 17}
            };

            // XML document initialization
            XElement studentDoc =
                new XElement("Students",
                from s in students
                select new XElement("Student", new XAttribute("Age", s.Age),
                    new XElement("FirstName", s.FirstName))
                );

            // Save XML document
            studentDoc.Save("LinqRollCall.xml");
        }

        // Input: N/A
        // Process: Load XML document and print it to the console
        // Output: XML document contents on console
        static void LoadXmlDoc()
        {
            // Load the LinqRollCall.xml file
            XDocument myDoc = XDocument.Load("LinqRollCall.xml");
            Console.WriteLine(myDoc);
        }
    }
}
