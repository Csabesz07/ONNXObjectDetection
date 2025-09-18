using Microsoft.ML.Data;

namespace ONNXObjectDetection.DataStructures;

public class ImageNetPrediction
{
    [ColumnName("grid")]
    public float[] PredictedLabels;
}
