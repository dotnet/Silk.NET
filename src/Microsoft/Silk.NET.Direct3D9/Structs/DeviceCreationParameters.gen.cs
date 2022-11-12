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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEVICE_CREATION_PARAMETERS")]
    public unsafe partial struct DeviceCreationParameters
    {
        public DeviceCreationParameters
        (
            uint? adapterOrdinal = null,
            Devtype? deviceType = null,
            nint? hFocusWindow = null,
            int? behaviorFlags = null
        ) : this()
        {
            if (adapterOrdinal is not null)
            {
                AdapterOrdinal = adapterOrdinal.Value;
            }

            if (deviceType is not null)
            {
                DeviceType = deviceType.Value;
            }

            if (hFocusWindow is not null)
            {
                HFocusWindow = hFocusWindow.Value;
            }

            if (behaviorFlags is not null)
            {
                BehaviorFlags = behaviorFlags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AdapterOrdinal")]
        public uint AdapterOrdinal;

        [NativeName("Type", "D3DDEVTYPE")]
        [NativeName("Type.Name", "D3DDEVTYPE")]
        [NativeName("Name", "DeviceType")]
        public Devtype DeviceType;

        [NativeName("Type", "HWND")]
        [NativeName("Type.Name", "HWND")]
        [NativeName("Name", "hFocusWindow")]
        public nint HFocusWindow;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "BehaviorFlags")]
        public int BehaviorFlags;
    }
}
