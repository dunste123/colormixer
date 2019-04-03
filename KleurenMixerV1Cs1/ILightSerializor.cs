using System;
using System.Collections.Generic;
using System.Text;

namespace KleurenMixerV1Cs1
{
    public interface ILightSerializer
    {
        int[] GetDMXRange();
        object[][] GetDMXValues();
    }
}
