// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct AUXCAPS2A
{
    [NativeTypeName("WORD")]
    public ushort wMid;

    [NativeTypeName("WORD")]
    public ushort wPid;

    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    [NativeTypeName("CHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    [NativeTypeName("WORD")]
    public ushort wTechnology;

    [NativeTypeName("WORD")]
    public ushort wReserved1;

    [NativeTypeName("DWORD")]
    public uint dwSupport;
    public Guid ManufacturerGuid;
    public Guid ProductGuid;
    public Guid NameGuid;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szPname_e__FixedBuffer
    {
        public sbyte e0;
    }
}
