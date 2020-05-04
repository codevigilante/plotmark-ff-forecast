//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace plotmark.teamrush
{
    public class TeamRushModelInput
    {
        [ColumnName("PointsFavored"), LoadColumn(0)]
        public float PointsFavored { get; set; }


        [ColumnName("AvgRushFP"), LoadColumn(1)]
        public float AvgRushFP { get; set; }


        [ColumnName("AvgOppFPAllowed"), LoadColumn(2)]
        public float AvgOppFPAllowed { get; set; }


        [ColumnName("RainSnow"), LoadColumn(3)]
        public float RainSnow { get; set; }


        [ColumnName("TotalRushingFP"), LoadColumn(4)]
        public float TotalRushingFP { get; set; }
    }
}
