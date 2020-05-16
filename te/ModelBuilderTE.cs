namespace plotmark.te
{
    public class ModelBuilderTE : Forecaster<TEModelInput, TEModelOutput>
    {
        private const string ModelPath = "plotmark.forecast.te.MLModel.zip";

        public ModelBuilderTE()
            : base(ModelPath)
        {
        }
    }
}