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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L15521_C5")]
    public unsafe partial struct SerializedRaytracingAccelerationStructureHeader1Union
    {
        public SerializedRaytracingAccelerationStructureHeader1Union
        (
            uint? numBottomLevelAccelerationStructurePointersAfterHeader = null,
            uint? numBlocks = null
        ) : this()
        {
            if (numBottomLevelAccelerationStructurePointersAfterHeader is not null)
            {
                NumBottomLevelAccelerationStructurePointersAfterHeader = numBottomLevelAccelerationStructurePointersAfterHeader.Value;
            }

            if (numBlocks is not null)
            {
                NumBlocks = numBlocks.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumBottomLevelAccelerationStructurePointersAfterHeader")]
        public uint NumBottomLevelAccelerationStructurePointersAfterHeader;

        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumBlocks")]
        public uint NumBlocks;
    }
}
