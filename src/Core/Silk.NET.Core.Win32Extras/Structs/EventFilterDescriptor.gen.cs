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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_EVENT_FILTER_DESCRIPTOR")]
    public unsafe partial struct EventFilterDescriptor
    {
        public EventFilterDescriptor
        (
            ulong? ptr = null,
            uint? size = null,
            uint? type = null
        ) : this()
        {
            if (ptr is not null)
            {
                Ptr = ptr.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }
        }


        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "Ptr")]
        public ulong Ptr;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Type")]
        public uint Type;
    }
}
