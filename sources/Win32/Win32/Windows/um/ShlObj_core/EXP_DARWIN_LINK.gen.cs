// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct EXP_DARWIN_LINK
{
    public DATABLOCK_HEADER dbh;

    [NativeTypeName("CHAR[260]")]
    public _szDarwinID_e__FixedBuffer szDarwinID;

    [NativeTypeName("WCHAR[260]")]
    public _szwDarwinID_e__FixedBuffer szwDarwinID;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    public partial struct _szDarwinID_e__FixedBuffer
    {
        public sbyte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    public partial struct _szwDarwinID_e__FixedBuffer
    {
        public ushort e0;
    }
}
