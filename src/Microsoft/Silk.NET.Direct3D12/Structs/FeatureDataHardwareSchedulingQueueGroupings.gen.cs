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
    [NativeName("Name", "D3D12_FEATURE_DATA_HARDWARE_SCHEDULING_QUEUE_GROUPINGS")]
    public unsafe partial struct FeatureDataHardwareSchedulingQueueGroupings
    {
        public FeatureDataHardwareSchedulingQueueGroupings
        (
            uint? computeQueuesPer3DQueue = null
        ) : this()
        {
            if (computeQueuesPer3DQueue is not null)
            {
                ComputeQueuesPer3DQueue = computeQueuesPer3DQueue.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ComputeQueuesPer3DQueue")]
        public uint ComputeQueuesPer3DQueue;
    }
}
