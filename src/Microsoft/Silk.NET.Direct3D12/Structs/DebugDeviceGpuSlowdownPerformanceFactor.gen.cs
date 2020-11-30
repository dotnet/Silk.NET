// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DEBUG_DEVICE_GPU_SLOWDOWN_PERFORMANCE_FACTOR")]
    public unsafe partial struct DebugDeviceGpuSlowdownPerformanceFactor
    {
        public DebugDeviceGpuSlowdownPerformanceFactor
        (
            float? slowdownFactor = null
        ) : this()
        {
            if (slowdownFactor is not null)
            {
                SlowdownFactor = slowdownFactor.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "SlowdownFactor")]
        public float SlowdownFactor;
    }
}
