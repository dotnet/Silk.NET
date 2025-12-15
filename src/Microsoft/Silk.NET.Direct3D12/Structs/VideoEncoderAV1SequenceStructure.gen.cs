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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEQUENCE_STRUCTURE")]
    public unsafe partial struct VideoEncoderAV1SequenceStructure
    {
        public VideoEncoderAV1SequenceStructure
        (
            uint? intraDistance = null,
            uint? interFramePeriod = null
        ) : this()
        {
            if (intraDistance is not null)
            {
                IntraDistance = intraDistance.Value;
            }

            if (interFramePeriod is not null)
            {
                InterFramePeriod = interFramePeriod.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IntraDistance")]
        public uint IntraDistance;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InterFramePeriod")]
        public uint InterFramePeriod;
    }
}
