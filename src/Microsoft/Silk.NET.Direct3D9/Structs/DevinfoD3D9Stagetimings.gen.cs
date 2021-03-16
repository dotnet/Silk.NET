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
    [NativeName("Name", "_D3DDEVINFO_D3D9STAGETIMINGS")]
    public unsafe partial struct DevinfoD3D9Stagetimings
    {
        public DevinfoD3D9Stagetimings
        (
            float? memoryProcessingPercent = null,
            float? computationProcessingPercent = null
        ) : this()
        {
            if (memoryProcessingPercent is not null)
            {
                MemoryProcessingPercent = memoryProcessingPercent.Value;
            }

            if (computationProcessingPercent is not null)
            {
                ComputationProcessingPercent = computationProcessingPercent.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MemoryProcessingPercent")]
        public float MemoryProcessingPercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "ComputationProcessingPercent")]
        public float ComputationProcessingPercent;
    }
}
