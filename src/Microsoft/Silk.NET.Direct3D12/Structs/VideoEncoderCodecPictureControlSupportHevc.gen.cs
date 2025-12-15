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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC")]
    public unsafe partial struct VideoEncoderCodecPictureControlSupportHevc
    {
        public VideoEncoderCodecPictureControlSupportHevc
        (
            uint? maxL0ReferencesForP = null,
            uint? maxL0ReferencesForB = null,
            uint? maxL1ReferencesForB = null,
            uint? maxLongTermReferences = null,
            uint? maxDPBCapacity = null
        ) : this()
        {
            if (maxL0ReferencesForP is not null)
            {
                MaxL0ReferencesForP = maxL0ReferencesForP.Value;
            }

            if (maxL0ReferencesForB is not null)
            {
                MaxL0ReferencesForB = maxL0ReferencesForB.Value;
            }

            if (maxL1ReferencesForB is not null)
            {
                MaxL1ReferencesForB = maxL1ReferencesForB.Value;
            }

            if (maxLongTermReferences is not null)
            {
                MaxLongTermReferences = maxLongTermReferences.Value;
            }

            if (maxDPBCapacity is not null)
            {
                MaxDPBCapacity = maxDPBCapacity.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxL0ReferencesForP")]
        public uint MaxL0ReferencesForP;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxL0ReferencesForB")]
        public uint MaxL0ReferencesForB;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxL1ReferencesForB")]
        public uint MaxL1ReferencesForB;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxLongTermReferences")]
        public uint MaxLongTermReferences;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxDPBCapacity")]
        public uint MaxDPBCapacity;
    }
}
