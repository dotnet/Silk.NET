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
    [NativeName("Name", "__AnonymousRecord_evntrace_L1287_C9")]
    public unsafe partial struct EventTracePropertiesV2Union2Union
    {
        public EventTracePropertiesV2Union2Union
        (
            uint? versionNumber = null
        ) : this()
        {
            if (versionNumber is not null)
            {
                VersionNumber = versionNumber.Value;
            }
        }


        private uint _bitfield1;

        public uint VersionNumber
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0xFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0xFFu) | (uint)((uint)(value) & 0xFFu));
        }
    }
}
