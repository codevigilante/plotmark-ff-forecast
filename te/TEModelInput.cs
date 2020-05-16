//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace plotmark.te
{
    public class TEModelInput
    {
        [ColumnName("ExpectedFPShare"), LoadColumn(0)]
        public float ExpectedFPShare { get; set; }


        [ColumnName("TargetPercentPerGame"), LoadColumn(1)]
        public float TargetPercentPerGame { get; set; }


        [ColumnName("ExpectedPlayerFP"), LoadColumn(2)]
        public float ExpectedPlayerFP { get; set; }


        [ColumnName("FP"), LoadColumn(3)]
        public float FP { get; set; }
    }
}
