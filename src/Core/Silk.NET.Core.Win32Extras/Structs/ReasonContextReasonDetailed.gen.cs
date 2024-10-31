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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "__AnonymousRecord_minwinbase_L277_C9")]
    public unsafe partial struct ReasonContextReasonDetailed
    {
        public ReasonContextReasonDetailed
        (
            nint? localizedReasonModule = null,
            uint? localizedReasonId = null,
            uint? reasonStringCount = null,
            char** reasonStrings = null
        ) : this()
        {
            if (localizedReasonModule is not null)
            {
                LocalizedReasonModule = localizedReasonModule.Value;
            }

            if (localizedReasonId is not null)
            {
                LocalizedReasonId = localizedReasonId.Value;
            }

            if (reasonStringCount is not null)
            {
                ReasonStringCount = reasonStringCount.Value;
            }

            if (reasonStrings is not null)
            {
                ReasonStrings = reasonStrings;
            }
        }


        [NativeName("Type", "HMODULE")]
        [NativeName("Type.Name", "HMODULE")]
        [NativeName("Name", "LocalizedReasonModule")]
        public nint LocalizedReasonModule;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "LocalizedReasonId")]
        public uint LocalizedReasonId;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ReasonStringCount")]
        public uint ReasonStringCount;

        [NativeName("Type", "LPWSTR *")]
        [NativeName("Type.Name", "LPWSTR *")]
        [NativeName("Name", "ReasonStrings")]
        public char** ReasonStrings;
    }
}
