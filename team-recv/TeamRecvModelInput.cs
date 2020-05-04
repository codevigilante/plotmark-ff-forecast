//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace plotmark.teamrecv
{
    public class TeamRecvModelInput
    {
        [ColumnName("AvgPassYards"), LoadColumn(0)]
        public float AvgPassYards { get; set; }


        [ColumnName("PassRatioOverAvg"), LoadColumn(1)]
        public float PassRatioOverAvg { get; set; }


        [ColumnName("TeamExpectedPoints"), LoadColumn(2)]
        public float TeamExpectedPoints { get; set; }


        [ColumnName("AvgRushAttempts"), LoadColumn(3)]
        public float AvgRushAttempts { get; set; }


        [ColumnName("AvgTeamPoints"), LoadColumn(4)]
        public float AvgTeamPoints { get; set; }


        [ColumnName("WindSpeed"), LoadColumn(5)]
        public float WindSpeed { get; set; }


        [ColumnName("PointsFavored"), LoadColumn(6)]
        public float PointsFavored { get; set; }


        [ColumnName("GamesPlayedPreviousSeason"), LoadColumn(7)]
        public float GamesPlayedPreviousSeason { get; set; }


        [ColumnName("IsWeek17"), LoadColumn(8)]
        public float IsWeek17 { get; set; }


        [ColumnName("TotalReceivingFP"), LoadColumn(9)]
        public float TotalReceivingFP { get; set; }
    }
}
