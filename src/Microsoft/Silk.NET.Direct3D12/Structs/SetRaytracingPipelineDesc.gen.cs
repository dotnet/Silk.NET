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
    [NativeName("Name", "D3D12_SET_RAYTRACING_PIPELINE_DESC")]
    public unsafe partial struct SetRaytracingPipelineDesc
    {
        public SetRaytracingPipelineDesc
        (
            ProgramIdentifier? programIdentifier = null
        ) : this()
        {
            if (programIdentifier is not null)
            {
                ProgramIdentifier = programIdentifier.Value;
            }
        }


        [NativeName("Type", "D3D12_PROGRAM_IDENTIFIER")]
        [NativeName("Type.Name", "D3D12_PROGRAM_IDENTIFIER")]
        [NativeName("Name", "ProgramIdentifier")]
        public ProgramIdentifier ProgramIdentifier;
    }
}
