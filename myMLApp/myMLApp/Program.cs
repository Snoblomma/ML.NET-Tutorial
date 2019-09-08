using System;
using MyMLAppML.Model.DataModels;
using Microsoft.ML;

namespace myMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumeTaxiFareModel();
        }

        public static void ConsumeTaxiFareModel()
        {
            // Load the model
            MLContext mlContext = new MLContext();

            ITransformer mlModel = mlContext.Model.Load("MLModel.zip", out var modelInputSchema);

            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            // Use the code below to add input data
            var input = new ModelInput();
            input.Passenger_count = 2;
            input.Trip_time_in_secs = 1200;
            input.Trip_distance = 2.2f;


            // Try model on sample data
            // True is toxic, false is non-toxic
            ModelOutput result = predEngine.Predict(input);

            Console.WriteLine($"Passenger count: {input.Passenger_count}, Trip time: {input.Trip_time_in_secs}, Trip distance: {input.Trip_distance} | Prediction: {result.Score}");
        }
    }
}
