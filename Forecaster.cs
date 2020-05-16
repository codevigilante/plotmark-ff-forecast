using System;
using System.IO;
using System.Reflection;
using Microsoft.ML;

namespace plotmark
{
    internal class Thing
    {

    };

    public abstract class Forecaster<In, Out> where In : class where Out : class, new()
    {
        private PredictionEngine<In, Out> Engine = null;
        private string ModelPath = string.Empty;

        public Forecaster(string modelPath)
        {
            ModelPath = modelPath;
        }

        public void LoadModel()
        {
            MLContext mlContext = new MLContext();
            var assembly = Assembly.GetAssembly(typeof(plotmark.Thing));   

            using(var reader = assembly.GetManifestResourceStream(ModelPath))
            {
                ITransformer mlModel = mlContext.Model.Load(reader, out DataViewSchema inputSchema);

                Engine = mlContext.Model.CreatePredictionEngine<In, Out>(mlModel);
            }            
        }

        public Out Forecast(In input)
        {
            if (Engine == null)
            {
                throw new Exception("Model has not been loaded. Please do that.");
            }         

            // Try a single prediction
            Out predictionResult = Engine.Predict(input);

            return(predictionResult);
        }

        public static string GetAbsolutePath(string relativePath)
        {
            FileInfo _dataRoot = new FileInfo(typeof(plotmark.Thing).Assembly.Location);
            string assemblyFolderPath = _dataRoot.Directory.FullName;

            string fullPath = Path.Combine(assemblyFolderPath, relativePath);

            return fullPath;
        }
    }
}
