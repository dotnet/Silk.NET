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
    [NativeName("Name", "D3D12_VIDEO_PROCESS_REFERENCE_SET")]
    public unsafe partial struct VideoProcessReferenceSet
    {
        public VideoProcessReferenceSet
        (
            uint? numPastFrames = null,
            ID3D12Resource** ppPastFrames = null,
            uint* pPastSubresources = null,
            uint? numFutureFrames = null,
            ID3D12Resource** ppFutureFrames = null,
            uint* pFutureSubresources = null
        ) : this()
        {
            if (numPastFrames is not null)
            {
                NumPastFrames = numPastFrames.Value;
            }

            if (ppPastFrames is not null)
            {
                PpPastFrames = ppPastFrames;
            }

            if (pPastSubresources is not null)
            {
                PPastSubresources = pPastSubresources;
            }

            if (numFutureFrames is not null)
            {
                NumFutureFrames = numFutureFrames.Value;
            }

            if (ppFutureFrames is not null)
            {
                PpFutureFrames = ppFutureFrames;
            }

            if (pFutureSubresources is not null)
            {
                PFutureSubresources = pFutureSubresources;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumPastFrames")]
        public uint NumPastFrames;

        [NativeName("Type", "ID3D12Resource **")]
        [NativeName("Type.Name", "ID3D12Resource **")]
        [NativeName("Name", "ppPastFrames")]
        public ID3D12Resource** PpPastFrames;

        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "pPastSubresources")]
        public uint* PPastSubresources;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumFutureFrames")]
        public uint NumFutureFrames;

        [NativeName("Type", "ID3D12Resource **")]
        [NativeName("Type.Name", "ID3D12Resource **")]
        [NativeName("Name", "ppFutureFrames")]
        public ID3D12Resource** PpFutureFrames;

        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "pFutureSubresources")]
        public uint* PFutureSubresources;
    }
}
