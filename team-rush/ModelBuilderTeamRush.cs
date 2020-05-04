using System;
using System.IO;
using System.Reflection;
using Microsoft.ML;
using Microsoft.Extensions.FileProviders;

namespace plotmark.teamrush
{
    public class ModelBuilderTeamRush
    {
        private PredictionEngine<TeamRushModelInput, TeamRushModelOutput> Engine = null;
        private const string ModelPath = "plotmark.forecast.team_rush.MLModel.zip";

        public ModelBuilderTeamRush()
        {
        }

        public void LoadModel()
        {
            MLContext mlContext = new MLContext();
            var assembly = Assembly.GetAssembly(typeof(plotmark.Forecaster));   

            using(var reader = assembly.GetManifestResourceStream(ModelPath))
            {
                ITransformer mlModel = mlContext.Model.Load(reader, out DataViewSchema inputSchema);

                Engine = mlContext.Model.CreatePredictionEngine<TeamRushModelInput, TeamRushModelOutput>(mlModel);
            }            
        }

        public TeamRushModelOutput Forecast(TeamRushModelInput input)
        {
            if (Engine == null)
            {
                throw new Exception("Model has not been loaded. Please do that.");
            }         

            // Try a single prediction
            TeamRushModelOutput predictionResult = Engine.Predict(input);

            return(predictionResult);
        }

        public static string GetAbsolutePath(string relativePath)
        {
            FileInfo _dataRoot = new FileInfo(typeof(Forecaster).Assembly.Location);
            string assemblyFolderPath = _dataRoot.Directory.FullName;

            string fullPath = Path.Combine(assemblyFolderPath, relativePath);

            return fullPath;
        }
    }
}