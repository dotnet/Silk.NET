// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCM_LOGICAL_DEVICE_INSTANCE
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;
    public Guid DeviceGuid;

    [NativeTypeName("WCHAR[256]")]
    public _SymbolicLink_e__FixedBuffer SymbolicLink;

    [InlineArray(256)]
    public partial struct _SymbolicLink_e__FixedBuffer
    {
        public ushort e0;
    }
}
