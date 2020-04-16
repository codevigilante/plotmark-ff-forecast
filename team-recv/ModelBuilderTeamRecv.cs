using System;
using System.IO;
using Microsoft.ML;

namespace plotmark.teamrecv
{
    public class ModelBuilderTeamRecv
    {
        private const string MODEL_FILEPATH = @"./team-recv/MLModel.zip";
        private PredictionEngine<TeamRecvModelInput, TeamRecvModelOutput> Engine = null;

        public ModelBuilderTeamRecv()
        {
        }

        public void LoadModel()
        {
            MLContext mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MODEL_FILEPATH, out DataViewSchema inputSchema);

            Engine = mlContext.Model.CreatePredictionEngine<TeamRecvModelInput, TeamRecvModelOutput>(mlModel);
        }

        public TeamRecvModelOutput Forecast(TeamRecvModelInput input)
        {
            if (Engine == null)
            {
                throw new Exception("Model has not been loaded. Please do that.");
            }         

            // Try a single prediction
            TeamRecvModelOutput predictionResult = Engine.Predict(input);

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