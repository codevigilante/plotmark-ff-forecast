//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace plotmark.wr3
{
    public class WR3ModelInput
    {
        [ColumnName("ExpectedFPShare"), LoadColumn(0)]
        public float ExpectedFPShare { get; set; }


        [ColumnName("TargetPercentPerGame"), LoadColumn(1)]
        public float TargetPercentPerGame { get; set; }


        [ColumnName("ExpectedPlayerFP"), LoadColumn(2)]
        public float ExpectedPlayerFP { get; set; }


        [ColumnName("ReturningFP"), LoadColumn(3)]
        public float ReturningFP { get; set; }


        [ColumnName("FP"), LoadColumn(4)]
        public float FP { get; set; }
    }
}
