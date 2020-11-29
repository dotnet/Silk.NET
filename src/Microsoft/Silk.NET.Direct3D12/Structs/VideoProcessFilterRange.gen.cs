// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE")]
    public unsafe partial struct VideoProcessFilterRange
    {
        public VideoProcessFilterRange
        (
            int? minimum = null,
            int? maximum = null,
            int? @default = null,
            float? multiplier = null
        ) : this()
        {
            if (minimum is not null)
            {
                Minimum = minimum.Value;
            }

            if (maximum is not null)
            {
                Maximum = maximum.Value;
            }

            if (@default is not null)
            {
                Default = @default.Value;
            }

            if (multiplier is not null)
            {
                Multiplier = multiplier.Value;
            }
        }


        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "Minimum")]
        public int Minimum;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "Maximum")]
        public int Maximum;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "Default")]
        public int Default;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Multiplier")]
        public float Multiplier;
    }
}
