// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            uint adapterOrdinal = default,
            Devtype deviceType = default,
            IntPtr hFocusWindow = default,
            uint behaviorFlags = default
        )
        {
            AdapterOrdinal = adapterOrdinal;
            DeviceType = deviceType;
            HFocusWindow = hFocusWindow;
            BehaviorFlags = behaviorFlags;
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
        public IntPtr HFocusWindow;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "BehaviorFlags")]
        public uint BehaviorFlags;
    }
}
