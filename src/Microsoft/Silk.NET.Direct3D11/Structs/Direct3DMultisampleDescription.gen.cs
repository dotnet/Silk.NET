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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "Direct3DMultisampleDescription")]
    public unsafe partial struct Direct3DMultisampleDescription
    {
        public Direct3DMultisampleDescription
        (
            int? count = null,
            int? quality = null
        ) : this()
        {
            if (count is not null)
            {
                Count = count.Value;
            }

            if (quality is not null)
            {
                Quality = quality.Value;
            }
        }


        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "Count")]
        public int Count;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "Quality")]
        public int Quality;
    }
}
