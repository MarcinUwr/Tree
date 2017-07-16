using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using FamilySearch.Api.Util;
using Gedcomx.File;
using Gedcomx = Gx.Gedcomx;

namespace Tree.Models
{
    public class Gedcom
    {
        public void Read()
        {
            var file = new FileInfo("C:\\Users\\Bongo\\Desktop\\gedcom.ged");
            GedcomxFile f = new GedcomxFile(file);
        }
    }
}