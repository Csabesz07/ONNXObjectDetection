using System.Drawing;

namespace ONNXObjectDetection.YoloParser;

public class YoloOutputParser
{
    class CellDimensions : DimensionsBase { }

    public const int ROW_COUNT = 13;
    public const int COL_COUNT = 13;
    public const int CHANNEL_COUNT = 125;
    public const int BOXES_PER_CELL = 5;
    public const int BOX_INFO_FEATURE_COUNT = 5;
    public const int CLASS_COUNT = 20;
    public const float CELL_WIDTH = 32;
    public const float CELL_HEIGHT = 32;

    private int channelStride = ROW_COUNT * COL_COUNT;
    private float[] anchors = new float[]
    {
        1.08F, 1.19F, 3.42F, 4.41F, 6.63F, 11.38F, 9.42F, 5.11F, 16.62F, 10.52F
    };

    private string[] labels = new string[]
    {
        "aeroplane", "bicycle", "bird", "boat", "bottle",
        "bus", "car", "cat", "chair", "cow",
        "diningtable", "dog", "horse", "motorbike", "person",
        "pottedplant", "sheep", "sofa", "train", "tvmonitor"
    };

    private static Color[] classColors = new Color[]
    {
        Color.Khaki,
        Color.Fuchsia,
        Color.Silver,
        Color.RoyalBlue,
        Color.Green,
        Color.DarkOrange,
        Color.Purple,
        Color.Gold,
        Color.Red,
        Color.Aquamarine,
        Color.Lime,
        Color.AliceBlue,
        Color.Sienna,
        Color.Orchid,
        Color.Tan,
        Color.LightPink,
        Color.Yellow,
        Color.HotPink,
        Color.OliveDrab,
        Color.SandyBrown,
        Color.DarkTurquoise
    };
}
