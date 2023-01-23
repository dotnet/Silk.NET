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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STREAM")]
    public unsafe partial struct VideoProcessorStream
    {
        public VideoProcessorStream
        (
            Silk.NET.Core.Bool32? enable = null,
            uint? outputIndex = null,
            uint? inputFrameOrField = null,
            uint? pastFrames = null,
            uint? futureFrames = null,
            ID3D11VideoProcessorInputView** ppPastSurfaces = null,
            ID3D11VideoProcessorInputView* pInputSurface = null,
            ID3D11VideoProcessorInputView** ppFutureSurfaces = null,
            ID3D11VideoProcessorInputView** ppPastSurfacesRight = null,
            ID3D11VideoProcessorInputView* pInputSurfaceRight = null,
            ID3D11VideoProcessorInputView** ppFutureSurfacesRight = null
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

            if (ppPastSurfacesRight is not null)
            {
                PpPastSurfacesRight = ppPastSurfacesRight;
            }

            if (pInputSurfaceRight is not null)
            {
                PInputSurfaceRight = pInputSurfaceRight;
            }

            if (ppFutureSurfacesRight is not null)
            {
                PpFutureSurfacesRight = ppFutureSurfacesRight;
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

        [NativeName("Type", "ID3D11VideoProcessorInputView **")]
        [NativeName("Type.Name", "ID3D11VideoProcessorInputView **")]
        [NativeName("Name", "ppPastSurfaces")]
        public ID3D11VideoProcessorInputView** PpPastSurfaces;

        [NativeName("Type", "ID3D11VideoProcessorInputView *")]
        [NativeName("Type.Name", "ID3D11VideoProcessorInputView *")]
        [NativeName("Name", "pInputSurface")]
        public ID3D11VideoProcessorInputView* PInputSurface;

        [NativeName("Type", "ID3D11VideoProcessorInputView **")]
        [NativeName("Type.Name", "ID3D11VideoProcessorInputView **")]
        [NativeName("Name", "ppFutureSurfaces")]
        public ID3D11VideoProcessorInputView** PpFutureSurfaces;

        [NativeName("Type", "ID3D11VideoProcessorInputView **")]
        [NativeName("Type.Name", "ID3D11VideoProcessorInputView **")]
        [NativeName("Name", "ppPastSurfacesRight")]
        public ID3D11VideoProcessorInputView** PpPastSurfacesRight;

        [NativeName("Type", "ID3D11VideoProcessorInputView *")]
        [NativeName("Type.Name", "ID3D11VideoProcessorInputView *")]
        [NativeName("Name", "pInputSurfaceRight")]
        public ID3D11VideoProcessorInputView* PInputSurfaceRight;

        [NativeName("Type", "ID3D11VideoProcessorInputView **")]
        [NativeName("Type.Name", "ID3D11VideoProcessorInputView **")]
        [NativeName("Name", "ppFutureSurfacesRight")]
        public ID3D11VideoProcessorInputView** PpFutureSurfacesRight;
    }
}
