// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct POINTER_DEVICE_INFO
{
    [NativeTypeName("DWORD")]
    public uint displayOrientation;
    public HANDLE device;
    public POINTER_DEVICE_TYPE pointerDeviceType;
    public HMONITOR monitor;

    [NativeTypeName("ULONG")]
    public uint startingCursorId;
    public ushort maxActiveContacts;

    [NativeTypeName("WCHAR[520]")]
    public _productString_e__FixedBuffer productString;

    [InlineArray(520)]
    public partial struct _productString_e__FixedBuffer
    {
        public ushort e0;
    }
}
