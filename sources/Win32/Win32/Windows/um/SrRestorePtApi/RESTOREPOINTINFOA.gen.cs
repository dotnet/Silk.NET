// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SrRestorePtApi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct RESTOREPOINTINFOA
{
    [NativeTypeName("DWORD")]
    public uint dwEventType;

    [NativeTypeName("DWORD")]
    public uint dwRestorePtType;

    [NativeTypeName("INT64")]
    public long llSequenceNumber;

    [NativeTypeName("CHAR[64]")]
    public _szDescription_e__FixedBuffer szDescription;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    public partial struct _szDescription_e__FixedBuffer
    {
        public sbyte e0;
    }
}
