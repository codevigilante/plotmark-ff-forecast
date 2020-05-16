//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace plotmark.rb
{
    public class RBModelInput
    {
        [ColumnName("GamesPlayedLastSeason"), LoadColumn(0)]
        public float GamesPlayedLastSeason { get; set; }


        [ColumnName("YardsPerCarry"), LoadColumn(1)]
        public float YardsPerCarry { get; set; }


        [ColumnName("PredictedReceivingProduction"), LoadColumn(2)]
        public float PredictedReceivingProduction { get; set; }


        [ColumnName("PredictedRushingProduction"), LoadColumn(3)]
        public float PredictedRushingProduction { get; set; }


        [ColumnName("FP"), LoadColumn(4)]
        public float FP { get; set; }
    }
}
