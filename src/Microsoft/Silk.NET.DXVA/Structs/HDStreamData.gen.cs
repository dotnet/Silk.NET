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
    [NativeName("Name", "_DXVAHD_STREAM_DATA")]
    public unsafe partial struct HDStreamData
    {
        public HDStreamData
        (
            Silk.NET.Core.Bool32? enable = null,
            uint? outputIndex = null,
            uint? inputFrameOrField = null,
            uint? pastFrames = null,
            uint? futureFrames = null,
            Silk.NET.Direct3D9.IDirect3DSurface9** ppPastSurfaces = null,
            Silk.NET.Direct3D9.IDirect3DSurface9* pInputSurface = null,
            Silk.NET.Direct3D9.IDirect3DSurface9** ppFutureSurfaces = null
        ) : this()
        {
            if (enable is not null)
            {
                Enable = enable.Value;
            }

            if (outputIndex is not null)
            {
                OutputIndex = outputIndex.Value;
            }

            if (inputFrameOrField is not null)
            {
                InputFrameOrField = inputFrameOrField.Value;
            }

            if (pastFrames is not null)
            {
                PastFrames = pastFrames.Value;
            }

            if (futureFrames is not null)
            {
                FutureFrames = futureFrames.Value;
            }

            if (ppPastSurfaces is not null)
            {
                PpPastSurfaces = ppPastSurfaces;
            }

            if (pInputSurface is not null)
            {
                PInputSurface = pInputSurface;
            }

            if (ppFutureSurfaces is not null)
            {
                PpFutureSurfaces = ppFutureSurfaces;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enable")]
        public Silk.NET.Core.Bool32 Enable;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputIndex")]
        public uint OutputIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputFrameOrField")]
        public uint InputFrameOrField;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PastFrames")]
        public uint PastFrames;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FutureFrames")]
        public uint FutureFrames;

        [NativeName("Type", "IDirect3DSurface9 **")]
        [NativeName("Type.Name", "IDirect3DSurface9 **")]
        [NativeName("Name", "ppPastSurfaces")]
        public Silk.NET.Direct3D9.IDirect3DSurface9** PpPastSurfaces;

        [NativeName("Type", "IDirect3DSurface9 *")]
        [NativeName("Type.Name", "IDirect3DSurface9 *")]
        [NativeName("Name", "pInputSurface")]
        public Silk.NET.Direct3D9.IDirect3DSurface9* PInputSurface;

        [NativeName("Type", "IDirect3DSurface9 **")]
        [NativeName("Type.Name", "IDirect3DSurface9 **")]
        [NativeName("Name", "ppFutureSurfaces")]
        public Silk.NET.Direct3D9.IDirect3DSurface9** PpFutureSurfaces;
    }
}
