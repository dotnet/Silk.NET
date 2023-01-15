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
    [NativeName("Name", "_PROFILE_SOURCE_INFO")]
    public unsafe partial struct ProfileSourceInfo
    {
        public ProfileSourceInfo
        (
            uint? nextEntryOffset = null,
            uint? source = null,
            uint? minInterval = null,
            uint? maxInterval = null,
            ulong? reserved = null
        ) : this()
        {
            if (nextEntryOffset is not null)
            {
                NextEntryOffset = nextEntryOffset.Value;
            }

            if (source is not null)
            {
                Source = source.Value;
            }

            if (minInterval is not null)
            {
                MinInterval = minInterval.Value;
            }

            if (maxInterval is not null)
            {
                MaxInterval = maxInterval.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "NextEntryOffset")]
        public uint NextEntryOffset;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Source")]
        public uint Source;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "MinInterval")]
        public uint MinInterval;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "MaxInterval")]
        public uint MaxInterval;

        [NativeName("Type", "ULONG64")]
        [NativeName("Type.Name", "ULONG64")]
        [NativeName("Name", "Reserved")]
        public ulong Reserved;
        [NativeName("Type", "WCHAR[1]")]
        [NativeName("Type.Name", "WCHAR[1]")]
        [NativeName("Name", "Description")]
        public fixed char Description[1];
    }
}
