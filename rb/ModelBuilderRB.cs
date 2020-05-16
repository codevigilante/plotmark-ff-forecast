namespace plotmark.rb
{
    public class ModelBuilderRB : Forecaster<RBModelInput, RBModelOutput>
    {
        private const string ModelPath = "plotmark.forecast.rb.MLModel.zip";

        public ModelBuilderRB()
            : base(ModelPath)
        {
        }
    }
}