using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace Pic2Vector
{
    public static class Processing
    {
        public static void Process(string filePath)
        {
            double lowThreshold = 40;
            // Should be between 2 and 3 times larger
            double highThreshold = 3 * lowThreshold;

            var img = CvInvoke.Imread(filePath, ImreadModes.Grayscale);
            var imgAfterEdgeDetection = new Mat(img.Rows, img.Cols, DepthType.Cv8U, 1);
            CvInvoke.Canny(img, imgAfterEdgeDetection, lowThreshold, highThreshold);
            var imgAfterInvert = new Mat(img.Rows, img.Cols, DepthType.Cv8U, 1);
            CvInvoke.BitwiseNot(imgAfterEdgeDetection, imgAfterInvert);
            CvInvoke.Imwrite("output.png", imgAfterInvert);
        }
    }
}
