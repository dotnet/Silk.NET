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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEVINFO_D3D9INTERFACETIMINGS")]
    public unsafe partial struct DevinfoD3D9interfacetimings
    {
        public DevinfoD3D9interfacetimings
        (
            float? waitingForGPUToUseApplicationResourceTimePercent = null,
            float? waitingForGPUToAcceptMoreCommandsTimePercent = null,
            float? waitingForGPUToStayWithinLatencyTimePercent = null,
            float? waitingForGPUExclusiveResourceTimePercent = null,
            float? waitingForGPUOtherTimePercent = null
        ) : this()
        {
            if (waitingForGPUToUseApplicationResourceTimePercent is not null)
            {
                WaitingForGPUToUseApplicationResourceTimePercent = waitingForGPUToUseApplicationResourceTimePercent.Value;
            }

            if (waitingForGPUToAcceptMoreCommandsTimePercent is not null)
            {
                WaitingForGPUToAcceptMoreCommandsTimePercent = waitingForGPUToAcceptMoreCommandsTimePercent.Value;
            }

            if (waitingForGPUToStayWithinLatencyTimePercent is not null)
            {
                WaitingForGPUToStayWithinLatencyTimePercent = waitingForGPUToStayWithinLatencyTimePercent.Value;
            }

            if (waitingForGPUExclusiveResourceTimePercent is not null)
            {
                WaitingForGPUExclusiveResourceTimePercent = waitingForGPUExclusiveResourceTimePercent.Value;
            }

            if (waitingForGPUOtherTimePercent is not null)
            {
                WaitingForGPUOtherTimePercent = waitingForGPUOtherTimePercent.Value;
            }
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
