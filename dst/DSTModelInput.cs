//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace plotmark.dst
{
    public class DSTModelInput
    {
        [ColumnName("AvgFP"), LoadColumn(0)]
        public float AvgFP { get; set; }


        [ColumnName("AvgFPAllowed"), LoadColumn(1)]
        public float AvgFPAllowed { get; set; }


        [ColumnName("OpposingTeamPoints"), LoadColumn(2)]
        public float OpposingTeamPoints { get; set; }


        [ColumnName("PointsFavored"), LoadColumn(3)]
        public float PointsFavored { get; set; }


        [ColumnName("WindSpeed"), LoadColumn(4)]
        public float WindSpeed { get; set; }


        [ColumnName("DomeGame"), LoadColumn(5)]
        public float DomeGame { get; set; }


        [ColumnName("FP"), LoadColumn(6)]
        public float FP { get; set; }
    }
}
