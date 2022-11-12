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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA_DeinterlaceQueryModeCaps")]
    public unsafe partial struct DeinterlaceQueryModeCaps
    {
        public DeinterlaceQueryModeCaps
        (
            int? size = null,
            Guid? guid = null,
            VideoDesc? videoDesc = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (guid is not null)
            {
                Guid = guid.Value;
            }

            if (videoDesc is not null)
            {
                VideoDesc = videoDesc.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Size")]
        public int Size;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "Guid")]
        public Guid Guid;

        [NativeName("Type", "DXVA_VideoDesc")]
        [NativeName("Type.Name", "DXVA_VideoDesc")]
        [NativeName("Name", "VideoDesc")]
        public VideoDesc VideoDesc;
    }
}
