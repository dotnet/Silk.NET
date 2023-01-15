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

namespace Silk.NET.DXVA
{
    [NativeName("AnonymousName", "__AnonymousRecord_dxva2trace_L112_C9")]
    [NativeName("Name", "DXVA2Trace_VideoProcessDevCreatedData")]
    public unsafe partial struct DXVA2TraceVideoProcessDevCreatedData
    {
        public DXVA2TraceVideoProcessDevCreatedData
        (
            Silk.NET.Core.Win32Extras.EventTraceHeader? wmiHeader = null,
            ulong? pObject = null,
            ulong? pD3DDevice = null,
            Guid? deviceGuid = null,
            uint? rTFourCC = null,
            uint? width = null,
            uint? height = null,
            Silk.NET.Core.Bool32? enter = null
        ) : this()
        {
            if (wmiHeader is not null)
            {
                WmiHeader = wmiHeader.Value;
            }

            if (pObject is not null)
            {
                PObject = pObject.Value;
            }

            if (pD3DDevice is not null)
            {
                PD3DDevice = pD3DDevice.Value;
            }

            if (deviceGuid is not null)
            {
                DeviceGuid = deviceGuid.Value;
            }

            if (rTFourCC is not null)
            {
                RTFourCC = rTFourCC.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (enter is not null)
            {
                Enter = enter.Value;
            }
        }


        [NativeName("Type", "EVENT_TRACE_HEADER")]
        [NativeName("Type.Name", "EVENT_TRACE_HEADER")]
        [NativeName("Name", "wmiHeader")]
        public Silk.NET.Core.Win32Extras.EventTraceHeader WmiHeader;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pObject")]
        public ulong PObject;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pD3DDevice")]
        public ulong PD3DDevice;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "DeviceGuid")]
        public Guid DeviceGuid;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "RTFourCC")]
        public uint RTFourCC;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enter")]
        public Silk.NET.Core.Bool32 Enter;
    }
}
