namespace plotmark.k
{
    public class ModelBuilderK : Forecaster<KModelInput, KModelOutput>
    {
        private const string ModelPath = "plotmark.forecast.k.MLModel.zip";

        public ModelBuilderK()
            : base(ModelPath)
        {
        }
    }
}