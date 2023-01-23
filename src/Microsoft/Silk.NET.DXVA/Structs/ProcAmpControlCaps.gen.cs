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
    [NativeName("Name", "_DXVA_ProcAmpControlCaps")]
    public unsafe partial struct ProcAmpControlCaps
    {
        public ProcAmpControlCaps
        (
            uint? size = null,
            uint? inputPool = null,
            Silk.NET.Direct3D9.Format? d3dOutputFormat = null,
            uint? procAmpControlProps = null,
            uint? videoProcessingCaps = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (inputPool is not null)
            {
                InputPool = inputPool.Value;
            }

            if (d3dOutputFormat is not null)
            {
                D3dOutputFormat = d3dOutputFormat.Value;
            }

            if (procAmpControlProps is not null)
            {
                ProcAmpControlProps = procAmpControlProps.Value;
            }

            if (videoProcessingCaps is not null)
            {
                VideoProcessingCaps = videoProcessingCaps.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "InputPool")]
        public uint InputPool;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "d3dOutputFormat")]
        public Silk.NET.Direct3D9.Format D3dOutputFormat;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ProcAmpControlProps")]
        public uint ProcAmpControlProps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VideoProcessingCaps")]
        public uint VideoProcessingCaps;
    }
}
