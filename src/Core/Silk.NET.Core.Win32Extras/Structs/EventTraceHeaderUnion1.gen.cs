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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_evntrace_L914_C5")]
    public unsafe partial struct EventTraceHeaderUnion1
    {
        public EventTraceHeaderUnion1
        (
            ushort? fieldTypeFlags = null,
            EventTraceHeaderUnion1Union? anonymous = null,
            byte? headerType = null,
            byte? markerFlags = null
        ) : this()
        {
            if (fieldTypeFlags is not null)
            {
                FieldTypeFlags = fieldTypeFlags.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (headerType is not null)
            {
                HeaderType = headerType.Value;
            }

            if (markerFlags is not null)
            {
                MarkerFlags = markerFlags.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "FieldTypeFlags")]
        public ushort FieldTypeFlags;

        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L916_C9")]
        [NativeName("Name", "anonymous1")]
        public EventTraceHeaderUnion1Union Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte HeaderType
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].HeaderType;
        }
#else
        public byte HeaderType
        {
            get => Anonymous.HeaderType;
            set => Anonymous.HeaderType = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte MarkerFlags
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].MarkerFlags;
        }
#else
        public byte MarkerFlags
        {
            get => Anonymous.MarkerFlags;
            set => Anonymous.MarkerFlags = value;
        }
#endif

    }
}
