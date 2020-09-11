// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEVINFO_D3D9INTERFACETIMINGS")]
    public unsafe partial struct DevinfoD3D9interfacetimings
    {
        public DevinfoD3D9interfacetimings
        (
            float waitingForGPUToUseApplicationResourceTimePercent = default,
            float waitingForGPUToAcceptMoreCommandsTimePercent = default,
            float waitingForGPUToStayWithinLatencyTimePercent = default,
            float waitingForGPUExclusiveResourceTimePercent = default,
            float waitingForGPUOtherTimePercent = default
        )
        {
            WaitingForGPUToUseApplicationResourceTimePercent = waitingForGPUToUseApplicationResourceTimePercent;
            WaitingForGPUToAcceptMoreCommandsTimePercent = waitingForGPUToAcceptMoreCommandsTimePercent;
            WaitingForGPUToStayWithinLatencyTimePercent = waitingForGPUToStayWithinLatencyTimePercent;
            WaitingForGPUExclusiveResourceTimePercent = waitingForGPUExclusiveResourceTimePercent;
            WaitingForGPUOtherTimePercent = waitingForGPUOtherTimePercent;
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "WaitingForGPUToUseApplicationResourceTimePercent")]
        public float WaitingForGPUToUseApplicationResourceTimePercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "WaitingForGPUToAcceptMoreCommandsTimePercent")]
        public float WaitingForGPUToAcceptMoreCommandsTimePercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "WaitingForGPUToStayWithinLatencyTimePercent")]
        public float WaitingForGPUToStayWithinLatencyTimePercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "WaitingForGPUExclusiveResourceTimePercent")]
        public float WaitingForGPUExclusiveResourceTimePercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "WaitingForGPUOtherTimePercent")]
        public float WaitingForGPUOtherTimePercent;
    }
}
