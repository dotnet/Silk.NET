// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct VMRMONITORINFO
{
    public VMRGUID guid;
    public RECT rcMonitor;
    public HMONITOR hMon;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("wchar_t[32]")]
    public _szDevice_e__FixedBuffer szDevice;

    [NativeTypeName("wchar_t[256]")]
    public _szDescription_e__FixedBuffer szDescription;
    public LARGE_INTEGER liDriverVersion;

    [NativeTypeName("DWORD")]
    public uint dwVendorId;

    [NativeTypeName("DWORD")]
    public uint dwDeviceId;

    [NativeTypeName("DWORD")]
    public uint dwSubSysId;

    [NativeTypeName("DWORD")]
    public uint dwRevision;

    [InlineArray(32)]
    public partial struct _szDevice_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(256)]
    public partial struct _szDescription_e__FixedBuffer
    {
        public ushort e0;
    }
}
