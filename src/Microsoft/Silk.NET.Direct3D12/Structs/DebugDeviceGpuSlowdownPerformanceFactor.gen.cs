// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
