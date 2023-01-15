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
    [NativeName("Name", "_BY_HANDLE_FILE_INFORMATION")]
    public unsafe partial struct ByHandleFileInformation
    {
        public ByHandleFileInformation
        (
            uint? dwFileAttributes = null,
            Silk.NET.Core.Win32Extras.Filetime? ftCreationTime = null,
            Silk.NET.Core.Win32Extras.Filetime? ftLastAccessTime = null,
            Silk.NET.Core.Win32Extras.Filetime? ftLastWriteTime = null,
            uint? dwVolumeSerialNumber = null,
            uint? nFileSizeHigh = null,
            uint? nFileSizeLow = null,
            uint? nNumberOfLinks = null,
            uint? nFileIndexHigh = null,
            uint? nFileIndexLow = null
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

            if (dwVolumeSerialNumber is not null)
            {
                DwVolumeSerialNumber = dwVolumeSerialNumber.Value;
            }

            if (nFileSizeHigh is not null)
            {
                NFileSizeHigh = nFileSizeHigh.Value;
            }

            if (nFileSizeLow is not null)
            {
                NFileSizeLow = nFileSizeLow.Value;
            }

            if (nNumberOfLinks is not null)
            {
                NNumberOfLinks = nNumberOfLinks.Value;
            }

            if (nFileIndexHigh is not null)
            {
                NFileIndexHigh = nFileIndexHigh.Value;
            }

            if (nFileIndexLow is not null)
            {
                NFileIndexLow = nFileIndexLow.Value;
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
        [NativeName("Name", "dwVolumeSerialNumber")]
        public uint DwVolumeSerialNumber;

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
        [NativeName("Name", "nNumberOfLinks")]
        public uint NNumberOfLinks;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "nFileIndexHigh")]
        public uint NFileIndexHigh;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "nFileIndexLow")]
        public uint NFileIndexLow;
    }
}
