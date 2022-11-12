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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA_DeinterlaceCaps")]
    public unsafe partial struct DeinterlaceCaps
    {
        public DeinterlaceCaps
        (
            int? size = null,
            int? numPreviousOutputFrames = null,
            int? inputPool = null,
            int? numForwardRefSamples = null,
            int? numBackwardRefSamples = null,
            Silk.NET.Direct3D9.Format? d3dOutputFormat = null,
            VideoProcessCaps? videoProcessingCaps = null,
            DeinterlaceTech? deinterlaceTechnology = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (numPreviousOutputFrames is not null)
            {
                NumPreviousOutputFrames = numPreviousOutputFrames.Value;
            }

            if (inputPool is not null)
            {
                InputPool = inputPool.Value;
            }

            if (numForwardRefSamples is not null)
            {
                NumForwardRefSamples = numForwardRefSamples.Value;
            }

            if (numBackwardRefSamples is not null)
            {
                NumBackwardRefSamples = numBackwardRefSamples.Value;
            }

            if (d3dOutputFormat is not null)
            {
                D3dOutputFormat = d3dOutputFormat.Value;
            }

            if (videoProcessingCaps is not null)
            {
                VideoProcessingCaps = videoProcessingCaps.Value;
            }

            if (deinterlaceTechnology is not null)
            {
                DeinterlaceTechnology = deinterlaceTechnology.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Size")]
        public int Size;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumPreviousOutputFrames")]
        public int NumPreviousOutputFrames;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "InputPool")]
        public int InputPool;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumForwardRefSamples")]
        public int NumForwardRefSamples;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumBackwardRefSamples")]
        public int NumBackwardRefSamples;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "d3dOutputFormat")]
        public Silk.NET.Direct3D9.Format D3dOutputFormat;

        [NativeName("Type", "DXVA_VideoProcessCaps")]
        [NativeName("Type.Name", "DXVA_VideoProcessCaps")]
        [NativeName("Name", "VideoProcessingCaps")]
        public VideoProcessCaps VideoProcessingCaps;

        [NativeName("Type", "DXVA_DeinterlaceTech")]
        [NativeName("Type.Name", "DXVA_DeinterlaceTech")]
        [NativeName("Name", "DeinterlaceTechnology")]
        public DeinterlaceTech DeinterlaceTechnology;
    }
}
