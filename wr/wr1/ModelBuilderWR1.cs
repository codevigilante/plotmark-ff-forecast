namespace plotmark.wr1
{
    public class ModelBuilderWR1 : Forecaster<WR1ModelInput, WR1ModelOutput>
    {
        private const string ModelPath = "plotmark.forecast.wr.wr1.MLModel.zip";

        public ModelBuilderWR1()
            : base(ModelPath)
        {
        }
    }
}