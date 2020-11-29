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
    [NativeName("Name", "D3D12_VIDEO_SIZE_RANGE")]
    public unsafe partial struct VideoSizeRange
    {
        public VideoSizeRange
        (
            uint? maxWidth = null,
            uint? maxHeight = null,
            uint? minWidth = null,
            uint? minHeight = null
        ) : this()
        {
            if (maxWidth is not null)
            {
                MaxWidth = maxWidth.Value;
            }

            if (maxHeight is not null)
            {
                MaxHeight = maxHeight.Value;
            }

            if (minWidth is not null)
            {
                MinWidth = minWidth.Value;
            }

            if (minHeight is not null)
            {
                MinHeight = minHeight.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxWidth")]
        public uint MaxWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxHeight")]
        public uint MaxHeight;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MinWidth")]
        public uint MinWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MinHeight")]
        public uint MinHeight;
    }
}
