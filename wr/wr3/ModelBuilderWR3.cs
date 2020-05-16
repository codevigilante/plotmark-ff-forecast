namespace plotmark.wr3
{
    public class ModelBuilderWR3 : Forecaster<WR3ModelInput, WR3ModelOutput>
    {
        private const string ModelPath = "plotmark.forecast.wr.wr3.MLModel.zip";

        public ModelBuilderWR3()
            : base(ModelPath)
        {
        }
    }
}