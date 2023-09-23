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
    [NativeName("Name", "tagBIND_OPTS3")]
    public unsafe partial struct BindOpts3
    {
        public BindOpts3
        (
            uint? dwTrackFlags = null,
            uint? dwClassContext = null,
            uint? locale = null,
            Coserverinfo* pServerInfo = null,
            nint? hwnd = null
        ) : this()
        {
            if (dwTrackFlags is not null)
            {
                DwTrackFlags = dwTrackFlags.Value;
            }

            if (dwClassContext is not null)
            {
                DwClassContext = dwClassContext.Value;
            }

            if (locale is not null)
            {
                Locale = locale.Value;
            }

            if (pServerInfo is not null)
            {
                PServerInfo = pServerInfo;
            }

            if (hwnd is not null)
            {
                Hwnd = hwnd.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwTrackFlags")]
        public uint DwTrackFlags;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwClassContext")]
        public uint DwClassContext;

        [NativeName("Type", "LCID")]
        [NativeName("Type.Name", "LCID")]
        [NativeName("Name", "locale")]
        public uint Locale;

        [NativeName("Type", "COSERVERINFO *")]
        [NativeName("Type.Name", "COSERVERINFO *")]
        [NativeName("Name", "pServerInfo")]
        public Coserverinfo* PServerInfo;

        [NativeName("Type", "HWND")]
        [NativeName("Type.Name", "HWND")]
        [NativeName("Name", "hwnd")]
        public nint Hwnd;
    }
}
