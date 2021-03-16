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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEVINFO_D3D9PIPELINETIMINGS")]
    public unsafe partial struct DevinfoD3D9Pipelinetimings
    {
        public DevinfoD3D9Pipelinetimings
        (
            float? vertexProcessingTimePercent = null,
            float? pixelProcessingTimePercent = null,
            float? otherGPUProcessingTimePercent = null,
            float? gPUIdleTimePercent = null
        ) : this()
        {
            if (vertexProcessingTimePercent is not null)
            {
                VertexProcessingTimePercent = vertexProcessingTimePercent.Value;
            }

            if (pixelProcessingTimePercent is not null)
            {
                PixelProcessingTimePercent = pixelProcessingTimePercent.Value;
            }

            if (otherGPUProcessingTimePercent is not null)
            {
                OtherGPUProcessingTimePercent = otherGPUProcessingTimePercent.Value;
            }

            if (gPUIdleTimePercent is not null)
            {
                GPUIdleTimePercent = gPUIdleTimePercent.Value;
            }
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
