// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX
{
    public byte EnableIntegrity;
    public byte KeepIntegrityStateUnchanged;

    [NativeTypeName("WORD")]
    public ushort Reserved;

    [NativeTypeName("DWORD")]
    public uint Flags;
    public byte Version;

    [NativeTypeName("BYTE[7]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    [InlineArray(7)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public byte e0;
    }
}
