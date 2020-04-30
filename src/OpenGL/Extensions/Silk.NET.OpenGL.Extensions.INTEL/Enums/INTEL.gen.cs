// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL.Extensions.INTEL
{
    public enum INTEL
    {
        BlackholeRenderIntel = 0x83FC,
        ConservativeRasterizationIntel = 0x83FE,
        PerfquerySingleContextIntel = 0x0,
        PerfqueryGlobalContextIntel = 0x1,
        PerfqueryWaitIntel = 0x83FB,
        PerfqueryFlushIntel = 0x83FA,
        PerfqueryDonotFlushIntel = 0x83F9,
        PerfqueryCounterEventIntel = 0x94F0,
        PerfqueryCounterDurationNormIntel = 0x94F1,
        PerfqueryCounterDurationRawIntel = 0x94F2,
        PerfqueryCounterThroughputIntel = 0x94F3,
        PerfqueryCounterRawIntel = 0x94F4,
        PerfqueryCounterTimestampIntel = 0x94F5,
        PerfqueryCounterDataUint32Intel = 0x94F8,
        PerfqueryCounterDataUint64Intel = 0x94F9,
        PerfqueryCounterDataFloatIntel = 0x94FA,
        PerfqueryCounterDataDoubleIntel = 0x94FB,
        PerfqueryCounterDataBool32Intel = 0x94FC,
        PerfqueryQueryNameLengthMaxIntel = 0x94FD,
        PerfqueryCounterNameLengthMaxIntel = 0x94FE,
        PerfqueryCounterDescLengthMaxIntel = 0x94FF,
        PerfqueryGpaExtendedCountersIntel = 0x9500,
    }
}
