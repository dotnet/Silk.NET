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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEVINFO_D3D9PIPELINETIMINGS")]
    public unsafe partial struct DevinfoD3D9Pipelinetimings
    {
        public DevinfoD3D9Pipelinetimings
        (
            float vertexProcessingTimePercent = default,
            float pixelProcessingTimePercent = default,
            float otherGPUProcessingTimePercent = default,
            float gPUIdleTimePercent = default
        )
        {
            VertexProcessingTimePercent = vertexProcessingTimePercent;
            PixelProcessingTimePercent = pixelProcessingTimePercent;
            OtherGPUProcessingTimePercent = otherGPUProcessingTimePercent;
            GPUIdleTimePercent = gPUIdleTimePercent;
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "VertexProcessingTimePercent")]
        public float VertexProcessingTimePercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "PixelProcessingTimePercent")]
        public float PixelProcessingTimePercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "OtherGPUProcessingTimePercent")]
        public float OtherGPUProcessingTimePercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "GPUIdleTimePercent")]
        public float GPUIdleTimePercent;
    }
}
