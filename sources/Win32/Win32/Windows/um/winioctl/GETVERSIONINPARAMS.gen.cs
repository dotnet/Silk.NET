// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct GETVERSIONINPARAMS
{
    public byte bVersion;
    public byte bRevision;
    public byte bReserved;
    public byte bIDEDeviceMap;

    [NativeTypeName("DWORD")]
    public uint fCapabilities;

    [NativeTypeName("DWORD[4]")]
    public _dwReserved_e__FixedBuffer dwReserved;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(4)]
    public partial struct _dwReserved_e__FixedBuffer
    {
        public uint e0;
    }
}
