//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace MyMLAppML.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("title"), LoadColumn(0)]
        public string Title { get; set; }


        [ColumnName("author"), LoadColumn(1)]
        public string Author { get; set; }


        [ColumnName("average_rating"), LoadColumn(2)]
        public float Average_rating { get; set; }


        [ColumnName("rating"), LoadColumn(3)]
        public float Rating { get; set; }


        [ColumnName("shelves"), LoadColumn(4)]
        public string Shelves { get; set; }


        [ColumnName("num_ratings"), LoadColumn(5)]
        public float Num_ratings { get; set; }


    }
}
