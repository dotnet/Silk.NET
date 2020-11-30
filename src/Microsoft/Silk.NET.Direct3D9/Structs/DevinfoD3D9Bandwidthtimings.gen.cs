// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "_D3DDEVINFO_D3D9BANDWIDTHTIMINGS")]
    public unsafe partial struct DevinfoD3D9Bandwidthtimings
    {
        public DevinfoD3D9Bandwidthtimings
        (
            float? maxBandwidthUtilized = null,
            float? frontEndUploadMemoryUtilizedPercent = null,
            float? vertexRateUtilizedPercent = null,
            float? triangleSetupRateUtilizedPercent = null,
            float? fillRateUtilizedPercent = null
        ) : this()
        {
            if (maxBandwidthUtilized is not null)
            {
                MaxBandwidthUtilized = maxBandwidthUtilized.Value;
            }

            if (frontEndUploadMemoryUtilizedPercent is not null)
            {
                FrontEndUploadMemoryUtilizedPercent = frontEndUploadMemoryUtilizedPercent.Value;
            }

            if (vertexRateUtilizedPercent is not null)
            {
                VertexRateUtilizedPercent = vertexRateUtilizedPercent.Value;
            }

            if (triangleSetupRateUtilizedPercent is not null)
            {
                TriangleSetupRateUtilizedPercent = triangleSetupRateUtilizedPercent.Value;
            }

            if (fillRateUtilizedPercent is not null)
            {
                FillRateUtilizedPercent = fillRateUtilizedPercent.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MaxBandwidthUtilized")]
        public float MaxBandwidthUtilized;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "FrontEndUploadMemoryUtilizedPercent")]
        public float FrontEndUploadMemoryUtilizedPercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "VertexRateUtilizedPercent")]
        public float VertexRateUtilizedPercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "TriangleSetupRateUtilizedPercent")]
        public float TriangleSetupRateUtilizedPercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "FillRateUtilizedPercent")]
        public float FillRateUtilizedPercent;
    }
}
