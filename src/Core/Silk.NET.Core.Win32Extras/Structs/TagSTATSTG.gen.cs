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
    [NativeName("Name", "tagSTATSTG")]
    public unsafe partial struct TagSTATSTG
    {
        public TagSTATSTG
        (
            char* pwcsName = null,
            int? type = null,
            ulong? cbSize = null,
            Silk.NET.Core.Win32Extras.Filetime? mtime = null,
            Silk.NET.Core.Win32Extras.Filetime? ctime = null,
            Silk.NET.Core.Win32Extras.Filetime? atime = null,
            int? grfMode = null,
            int? grfLocksSupported = null,
            Guid? clsid = null,
            int? grfStateBits = null,
            int? reserved = null
        ) : this()
        {
            if (pwcsName is not null)
            {
                PwcsName = pwcsName;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (cbSize is not null)
            {
                CbSize = cbSize.Value;
            }

            if (mtime is not null)
            {
                Mtime = mtime.Value;
            }

            if (ctime is not null)
            {
                Ctime = ctime.Value;
            }

            if (atime is not null)
            {
                Atime = atime.Value;
            }

            if (grfMode is not null)
            {
                GrfMode = grfMode.Value;
            }

            if (grfLocksSupported is not null)
            {
                GrfLocksSupported = grfLocksSupported.Value;
            }

            if (clsid is not null)
            {
                Clsid = clsid.Value;
            }

            if (grfStateBits is not null)
            {
                GrfStateBits = grfStateBits.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [NativeName("Type", "LPOLESTR")]
        [NativeName("Type.Name", "LPOLESTR")]
        [NativeName("Name", "pwcsName")]
        public char* PwcsName;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "type")]
        public int Type;

        [NativeName("Type", "ULARGE_INTEGER")]
        [NativeName("Type.Name", "ULARGE_INTEGER")]
        [NativeName("Name", "cbSize")]
        public ulong CbSize;

        [NativeName("Type", "FILETIME")]
        [NativeName("Type.Name", "FILETIME")]
        [NativeName("Name", "mtime")]
        public Silk.NET.Core.Win32Extras.Filetime Mtime;

        [NativeName("Type", "FILETIME")]
        [NativeName("Type.Name", "FILETIME")]
        [NativeName("Name", "ctime")]
        public Silk.NET.Core.Win32Extras.Filetime Ctime;

        [NativeName("Type", "FILETIME")]
        [NativeName("Type.Name", "FILETIME")]
        [NativeName("Name", "atime")]
        public Silk.NET.Core.Win32Extras.Filetime Atime;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "grfMode")]
        public int GrfMode;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "grfLocksSupported")]
        public int GrfLocksSupported;

        [NativeName("Type", "CLSID")]
        [NativeName("Type.Name", "CLSID")]
        [NativeName("Name", "clsid")]
        public Guid Clsid;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "grfStateBits")]
        public int GrfStateBits;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "reserved")]
        public int Reserved;
    }
}
