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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_PIPELINE_STATE_STREAM_DESC")]
    public unsafe partial struct PipelineStateStreamDesc
    {
        public PipelineStateStreamDesc
        (
            uint? sizeInBytes = null,
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
        public uint SizeInBytes;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pPipelineStateSubobjectStream")]
        public void* PPipelineStateSubobjectStream;
    }
}
