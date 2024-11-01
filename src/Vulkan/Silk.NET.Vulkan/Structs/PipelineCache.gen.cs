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
    [NativeName("Name", "VkPipelineCache")]
    public unsafe partial struct PipelineCache
    {
        public PipelineCache
        (
            ulong? handle = null
        ) : this()
        {
            if (handle is not null)
            {
                Handle = handle.Value;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "")]
        public ulong Handle;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return sizeof(nint) == 8 ? $"0x{Handle:x16}" : $"0x{Handle:x8}";
        }

    }
}
