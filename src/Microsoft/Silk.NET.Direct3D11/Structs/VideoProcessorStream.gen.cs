// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            int enable = default,
            uint outputIndex = default,
            uint inputFrameOrField = default,
            uint pastFrames = default,
            uint futureFrames = default,
            ID3D11VideoProcessorInputView** ppPastSurfaces = default,
            ID3D11VideoProcessorInputView* pInputSurface = default,
            ID3D11VideoProcessorInputView** ppFutureSurfaces = default,
            ID3D11VideoProcessorInputView** ppPastSurfacesRight = default,
            ID3D11VideoProcessorInputView* pInputSurfaceRight = default,
            ID3D11VideoProcessorInputView** ppFutureSurfacesRight = default
        )
        {
            Enable = enable;
            OutputIndex = outputIndex;
            InputFrameOrField = inputFrameOrField;
            PastFrames = pastFrames;
            FutureFrames = futureFrames;
            PpPastSurfaces = ppPastSurfaces;
            PInputSurface = pInputSurface;
            PpFutureSurfaces = ppFutureSurfaces;
            PpPastSurfacesRight = ppPastSurfacesRight;
            PInputSurfaceRight = pInputSurfaceRight;
            PpFutureSurfacesRight = ppFutureSurfacesRight;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enable")]
        public int Enable;

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
