namespace plotmark.dst
{
    public class ModelBuilderDST : Forecaster<DSTModelInput, DSTModelOutput>
    {
        private const string ModelPath = "plotmark.forecast.dst.MLModel.zip";

        public ModelBuilderDST()
            : base(ModelPath)
        {
        }
    }
}