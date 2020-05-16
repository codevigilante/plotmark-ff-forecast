//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace plotmark.qb
{
        public class QBModelInput
        {
        [ColumnName("IsWeek17"), LoadColumn(0)]
        public bool IsWeek17 { get; set; }


        [ColumnName("AvgFP"), LoadColumn(1)]
        public float AvgFP { get; set; }


        [ColumnName("PassRatioOverAvg"), LoadColumn(2)]
        public float PassRatioOverAvg { get; set; }


        [ColumnName("TeamExpectedPoints"), LoadColumn(3)]
        public float TeamExpectedPoints { get; set; }


        [ColumnName("AvgRushAttempts"), LoadColumn(4)]
        public float AvgRushAttempts { get; set; }


        [ColumnName("AvgTeamPoints"), LoadColumn(5)]
        public float AvgTeamPoints { get; set; }


        [ColumnName("WindSpeed"), LoadColumn(6)]
        public float WindSpeed { get; set; }


        [ColumnName("PointsFavored"), LoadColumn(7)]
        public float PointsFavored { get; set; }


        [ColumnName("GamesPlayedPreviousSeason"), LoadColumn(8)]
        public float GamesPlayedPreviousSeason { get; set; }


        [ColumnName("FP"), LoadColumn(9)]
        public float FP { get; set; }
    }
}
