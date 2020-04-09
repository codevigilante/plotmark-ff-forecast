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

        [ColumnName("PassProclivity"), LoadColumn(1)]
        public float PassProclivity { get; set; }

        [ColumnName("TeamExpectedPoints"), LoadColumn(2)]
        public float TeamExpectedPoints { get; set; }

        [ColumnName("AverageRushAttempts"), LoadColumn(3)]
        public float AverageRushAttempts { get; set; }

        [ColumnName("AverageTeamTotals"), LoadColumn(4)]
        public float AverageTeamTotals { get; set; }

        [ColumnName("WindSpeed"), LoadColumn(5)]
        public float WindSpeed { get; set; }

        [ColumnName("PointsFavored"), LoadColumn(6)]
        public float PointsFavored { get; set; }

        [ColumnName("GamesPlayedPreviousSeason"), LoadColumn(7)]
        public float GamesPlayedPreviousSeason { get; set; }

        [ColumnName("Week"), LoadColumn(8)]
        public bool Week { get; set; }

        [ColumnName("TotalReceivingFP"), LoadColumn(9)]
        public float TotalReceivingFP { get; set; }
    }
}
