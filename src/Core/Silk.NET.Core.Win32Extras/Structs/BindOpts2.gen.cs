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
    [NativeName("Name", "tagBIND_OPTS2")]
    public unsafe partial struct BindOpts2
    {
        public BindOpts2
        (
            uint? cbStruct = null,
            uint? grfFlags = null,
            uint? grfMode = null,
            uint? dwTickCountDeadline = null,
            uint? dwTrackFlags = null,
            uint? dwClassContext = null,
            uint? locale = null,
            Coserverinfo* pServerInfo = null
        ) : this()
        {
            if (cbStruct is not null)
            {
                CbStruct = cbStruct.Value;
            }

            if (grfFlags is not null)
            {
                GrfFlags = grfFlags.Value;
            }

            if (grfMode is not null)
            {
                GrfMode = grfMode.Value;
            }

            if (dwTickCountDeadline is not null)
            {
                DwTickCountDeadline = dwTickCountDeadline.Value;
            }

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
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "cbStruct")]
        public uint CbStruct;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "grfFlags")]
        public uint GrfFlags;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "grfMode")]
        public uint GrfMode;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwTickCountDeadline")]
        public uint DwTickCountDeadline;

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
    }
}
