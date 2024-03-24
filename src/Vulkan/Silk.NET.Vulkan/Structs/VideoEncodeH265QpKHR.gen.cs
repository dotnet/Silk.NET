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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoEncodeH265QpKHR")]
    public unsafe partial struct VideoEncodeH265QpKHR
    {
        public VideoEncodeH265QpKHR
        (
            int? qpI = null,
            int? qpP = null,
            int? qpB = null
        ) : this()
        {
            if (qpI is not null)
            {
                QpI = qpI.Value;
            }

            if (qpP is not null)
            {
                QpP = qpP.Value;
            }

            if (qpB is not null)
            {
                QpB = qpB.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "qpI")]
        public int QpI;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "qpP")]
        public int QpP;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "qpB")]
        public int QpB;
    }
}
