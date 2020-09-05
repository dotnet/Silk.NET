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
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_RANGE")]
    public unsafe partial struct VideoProcessorFilterRange
    {
        public VideoProcessorFilterRange
        (
            int minimum = default,
            int maximum = default,
            int @default = default,
            float multiplier = default
        )
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            Multiplier = multiplier;
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "Minimum")]
        public int Minimum;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "Maximum")]
        public int Maximum;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "Default")]
        public int Default;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Multiplier")]
        public float Multiplier;
    }
}
