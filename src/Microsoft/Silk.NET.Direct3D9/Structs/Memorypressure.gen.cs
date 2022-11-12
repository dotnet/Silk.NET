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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DMEMORYPRESSURE")]
    public unsafe partial struct Memorypressure
    {
        public Memorypressure
        (
            ulong? bytesEvictedFromProcess = null,
            ulong? sizeOfInefficientAllocation = null,
            int? levelOfEfficiency = null
        ) : this()
        {
            if (bytesEvictedFromProcess is not null)
            {
                BytesEvictedFromProcess = bytesEvictedFromProcess.Value;
            }

            if (sizeOfInefficientAllocation is not null)
            {
                SizeOfInefficientAllocation = sizeOfInefficientAllocation.Value;
            }

            if (levelOfEfficiency is not null)
            {
                LevelOfEfficiency = levelOfEfficiency.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "BytesEvictedFromProcess")]
        public ulong BytesEvictedFromProcess;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SizeOfInefficientAllocation")]
        public ulong SizeOfInefficientAllocation;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "LevelOfEfficiency")]
        public int LevelOfEfficiency;
    }
}
