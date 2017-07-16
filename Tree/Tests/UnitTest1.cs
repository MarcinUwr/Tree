using System;
using System.Globalization;
using System.IO;
using System.Threading;
using FamilyTreeProject.GEDCOM;
using FamilyTreeProject.GEDCOM.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            var doc = new GEDCOMDocument();
            var text = File.ReadAllText(@"‪..\..\..\..\gedcom.ged");
            doc.LoadGEDCOM(text);

            var ind1 = doc.IndividualRecords[0];
            var ind2 = ind1.ChildRecords[0];
            GEDCOMUtil.ParseGEDCOM(text, ind1);


            //GEDCOMReader reader = GEDCOMReader.Create(text);
            //var contents = reader.Read();
            //var family = reader.ReadFamily();
            //var families = reader.ReadFamilies();
        }
    }
}