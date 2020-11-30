// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_COUNTER_INFO")]
    public unsafe partial struct CounterInfo
    {
        public CounterInfo
        (
            Counter? lastDeviceDependentCounter = null,
            uint? numSimultaneousCounters = null,
            byte? numDetectableParallelUnits = null
        ) : this()
        {
            if (lastDeviceDependentCounter is not null)
            {
                LastDeviceDependentCounter = lastDeviceDependentCounter.Value;
            }

            if (numSimultaneousCounters is not null)
            {
                NumSimultaneousCounters = numSimultaneousCounters.Value;
            }

            if (numDetectableParallelUnits is not null)
            {
                NumDetectableParallelUnits = numDetectableParallelUnits.Value;
            }
        }


        [NativeName("Type", "D3D11_COUNTER")]
        [NativeName("Type.Name", "D3D11_COUNTER")]
        [NativeName("Name", "LastDeviceDependentCounter")]
        public Counter LastDeviceDependentCounter;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumSimultaneousCounters")]
        public uint NumSimultaneousCounters;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "NumDetectableParallelUnits")]
        public byte NumDetectableParallelUnits;
    }
}
