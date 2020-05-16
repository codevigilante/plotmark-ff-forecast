namespace plotmark.wr2
{
    public class ModelBuilderWR2 : Forecaster<WR2ModelInput, WR2ModelOutput>
    {
        private const string ModelPath = "plotmark.forecast.wr.wr2.MLModel.zip";

        public ModelBuilderWR2()
            : base(ModelPath)
        {
        }
    }
}