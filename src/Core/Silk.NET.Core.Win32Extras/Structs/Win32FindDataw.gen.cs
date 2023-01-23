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
    [NativeName("Name", "_WIN32_FIND_DATAW")]
    public unsafe partial struct Win32FindDataw
    {
        public Win32FindDataw
        (
            uint? dwFileAttributes = null,
            Silk.NET.Core.Win32Extras.Filetime? ftCreationTime = null,
            Silk.NET.Core.Win32Extras.Filetime? ftLastAccessTime = null,
            Silk.NET.Core.Win32Extras.Filetime? ftLastWriteTime = null,
            uint? nFileSizeHigh = null,
            uint? nFileSizeLow = null,
            uint? dwReserved0 = null,
            uint? dwReserved1 = null
        ) : this()
        {
            if (dwFileAttributes is not null)
            {
                DwFileAttributes = dwFileAttributes.Value;
            }

            if (ftCreationTime is not null)
            {
                FtCreationTime = ftCreationTime.Value;
            }

            if (ftLastAccessTime is not null)
            {
                FtLastAccessTime = ftLastAccessTime.Value;
            }

            if (ftLastWriteTime is not null)
            {
                FtLastWriteTime = ftLastWriteTime.Value;
            }

            if (nFileSizeHigh is not null)
            {
                NFileSizeHigh = nFileSizeHigh.Value;
            }

            if (nFileSizeLow is not null)
            {
                NFileSizeLow = nFileSizeLow.Value;
            }

            if (dwReserved0 is not null)
            {
                DwReserved0 = dwReserved0.Value;
            }

            if (dwReserved1 is not null)
            {
                DwReserved1 = dwReserved1.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwFileAttributes")]
        public uint DwFileAttributes;

        [NativeName("Type", "FILETIME")]
        [NativeName("Type.Name", "FILETIME")]
        [NativeName("Name", "ftCreationTime")]
        public Silk.NET.Core.Win32Extras.Filetime FtCreationTime;

        [NativeName("Type", "FILETIME")]
        [NativeName("Type.Name", "FILETIME")]
        [NativeName("Name", "ftLastAccessTime")]
        public Silk.NET.Core.Win32Extras.Filetime FtLastAccessTime;

        [NativeName("Type", "FILETIME")]
        [NativeName("Type.Name", "FILETIME")]
        [NativeName("Name", "ftLastWriteTime")]
        public Silk.NET.Core.Win32Extras.Filetime FtLastWriteTime;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "nFileSizeHigh")]
        public uint NFileSizeHigh;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "nFileSizeLow")]
        public uint NFileSizeLow;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwReserved0")]
        public uint DwReserved0;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwReserved1")]
        public uint DwReserved1;
        [NativeName("Type", "WCHAR[260]")]
        [NativeName("Type.Name", "WCHAR[260]")]
        [NativeName("Name", "cFileName")]
        public fixed char CFileName[260];
        [NativeName("Type", "WCHAR[14]")]
        [NativeName("Type.Name", "WCHAR[14]")]
        [NativeName("Name", "cAlternateFileName")]
        public fixed char CAlternateFileName[14];
    }
}
