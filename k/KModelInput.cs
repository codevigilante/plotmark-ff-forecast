//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace plotmark.k
{
    public class KModelInput
    {
        [ColumnName("TeamPoints"), LoadColumn(0)]
        public float TeamPoints { get; set; }


        [ColumnName("PointsFavored"), LoadColumn(1)]
        public float PointsFavored { get; set; }


        [ColumnName("WindSpeed"), LoadColumn(2)]
        public float WindSpeed { get; set; }


        [ColumnName("RainSnow"), LoadColumn(3)]
        public float RainSnow { get; set; }


        [ColumnName("FP"), LoadColumn(4)]
        public float FP { get; set; }
    }
}
