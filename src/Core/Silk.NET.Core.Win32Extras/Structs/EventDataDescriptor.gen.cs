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
    [NativeName("Name", "_EVENT_DATA_DESCRIPTOR")]
    public unsafe partial struct EventDataDescriptor
    {
        public EventDataDescriptor
        (
            ulong? ptr = null,
            uint? size = null,
            EventDataDescriptorUnion? anonymous = null,
            uint? reserved = null,
            byte? type = null,
            byte? reserved1 = null,
            ushort? reserved2 = null
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

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
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

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntprov_L183_C5")]
        [NativeName("Name", "anonymous1")]
        public EventDataDescriptorUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Reserved
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Reserved;
        }
#else
        public uint Reserved
        {
            get => Anonymous.Reserved;
            set => Anonymous.Reserved = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte Type
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Type;
        }
#else
        public byte Type
        {
            get => Anonymous.Type;
            set => Anonymous.Type = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte Reserved1
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Reserved1;
        }
#else
        public byte Reserved1
        {
            get => Anonymous.Reserved1;
            set => Anonymous.Reserved1 = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ushort Reserved2
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Reserved2;
        }
#else
        public ushort Reserved2
        {
            get => Anonymous.Reserved2;
            set => Anonymous.Reserved2 = value;
        }
#endif

    }
}
