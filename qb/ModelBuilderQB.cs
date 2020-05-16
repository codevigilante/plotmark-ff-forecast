namespace plotmark.qb
{
    public class ModelBuilderQB : Forecaster<QBModelInput, QBModelOutput>
    {
        private const string ModelPath = "plotmark.forecast.qb.MLModel.zip";

        public ModelBuilderQB()
            : base(ModelPath)
        {
        }
    }
}