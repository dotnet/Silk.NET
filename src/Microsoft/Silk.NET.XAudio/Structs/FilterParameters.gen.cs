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

namespace Silk.NET.XAudio
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeName("Name", "XAUDIO2_FILTER_PARAMETERS")]
    public unsafe partial struct FilterParameters
    {
        public FilterParameters
        (
            FilterType? type = null,
            float? frequency = null,
            float? oneOverQ = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (frequency is not null)
            {
                Frequency = frequency.Value;
            }

            if (oneOverQ is not null)
            {
                OneOverQ = oneOverQ.Value;
            }
        }


        [NativeName("Type", "XAUDIO2_FILTER_TYPE")]
        [NativeName("Type.Name", "XAUDIO2_FILTER_TYPE")]
        [NativeName("Name", "Type")]
        public FilterType Type;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Frequency")]
        public float Frequency;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "OneOverQ")]
        public float OneOverQ;
    }
}
