using System;
using System.IO;
using System.Reflection;
using Microsoft.ML;
using Microsoft.Extensions.FileProviders;

namespace plotmark.teamrecv
{
    public class ModelBuilderTeamRecv
    {
        private PredictionEngine<TeamRecvModelInput, TeamRecvModelOutput> Engine = null;
        private const string ModelPath = "plotmark.forecast.team_recv.MLModel.zip";

        public ModelBuilderTeamRecv()
        {
        }

        public void LoadModel()
        {
            MLContext mlContext = new MLContext();
            var assembly = Assembly.GetAssembly(typeof(plotmark.Forecaster));   

            using(var reader = assembly.GetManifestResourceStream(ModelPath))
            {
                ITransformer mlModel = mlContext.Model.Load(reader, out DataViewSchema inputSchema);

                Engine = mlContext.Model.CreatePredictionEngine<TeamRecvModelInput, TeamRecvModelOutput>(mlModel);
            }            
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