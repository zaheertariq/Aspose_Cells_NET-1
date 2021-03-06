//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Cells. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using Aspose.Cells;

namespace Aspose.Cells.Examples.Data.AddOn.NamedRanges
{
    public class IdentifyCellsinNamedRange
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Instantiate a new Workbook.
            Workbook workbook = new Workbook(dataDir + "book1.xls");

            //Getting the specified named range
            Range range = workbook.Worksheets.GetRangeByName("TestRange");

            //Identify range cells.
            Console.WriteLine( "First Row : " + range.FirstRow);
            Console.WriteLine( "First Column : " + range.FirstColumn);
            Console.WriteLine( "Row Count : " + range.RowCount);
            Console.WriteLine( "Column Count : " + range.ColumnCount);

        }
    }
}