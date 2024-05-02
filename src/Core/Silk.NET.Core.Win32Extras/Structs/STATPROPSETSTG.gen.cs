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
    [NativeName("Name", "tagSTATPROPSETSTG")]
    public unsafe partial struct STATPROPSETSTG
    {
        public STATPROPSETSTG
        (
            Guid? fmtid = null,
            Guid? clsid = null,
            uint? grfFlags = null,
            Silk.NET.Core.Win32Extras.Filetime? mtime = null,
            Silk.NET.Core.Win32Extras.Filetime? ctime = null,
            Silk.NET.Core.Win32Extras.Filetime? atime = null,
            uint? dwOSVersion = null
        ) : this()
        {
            if (fmtid is not null)
            {
                Fmtid = fmtid.Value;
            }

            if (clsid is not null)
            {
                Clsid = clsid.Value;
            }

            if (grfFlags is not null)
            {
                GrfFlags = grfFlags.Value;
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

            if (dwOSVersion is not null)
            {
                DwOSVersion = dwOSVersion.Value;
            }
        }


        [NativeName("Type", "FMTID")]
        [NativeName("Type.Name", "FMTID")]
        [NativeName("Name", "fmtid")]
        public Guid Fmtid;

        [NativeName("Type", "CLSID")]
        [NativeName("Type.Name", "CLSID")]
        [NativeName("Name", "clsid")]
        public Guid Clsid;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "grfFlags")]
        public uint GrfFlags;

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
        [NativeName("Name", "dwOSVersion")]
        public uint DwOSVersion;
    }
}
