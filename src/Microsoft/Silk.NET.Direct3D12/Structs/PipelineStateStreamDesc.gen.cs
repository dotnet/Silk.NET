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
    [NativeName("Name", "D3D12_PIPELINE_STATE_STREAM_DESC")]
    public unsafe partial struct PipelineStateStreamDesc
    {
        public PipelineStateStreamDesc
        (
            nuint? sizeInBytes = null,
            void* pPipelineStateSubobjectStream = null
        ) : this()
        {
            if (sizeInBytes is not null)
            {
                SizeInBytes = sizeInBytes.Value;
            }

            if (pPipelineStateSubobjectStream is not null)
            {
                PPipelineStateSubobjectStream = pPipelineStateSubobjectStream;
            }
        }


        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "SizeInBytes")]
        public nuint SizeInBytes;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pPipelineStateSubobjectStream")]
        public void* PPipelineStateSubobjectStream;
    }
}
