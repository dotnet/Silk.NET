// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHCOLUMNINFO
{
    [NativeTypeName("SHCOLUMNID")]
    public PROPERTYKEY scid;

    [NativeTypeName("VARTYPE")]
    public ushort vt;

    [NativeTypeName("DWORD")]
    public uint fmt;
    public uint cChars;

    [NativeTypeName("DWORD")]
    public uint csFlags;

    [NativeTypeName("WCHAR[80]")]
    public _wszTitle_e__FixedBuffer wszTitle;

    [NativeTypeName("WCHAR[128]")]
    public _wszDescription_e__FixedBuffer wszDescription;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(80)]
    public partial struct _wszTitle_e__FixedBuffer
    {
        public ushort e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(128)]
    public partial struct _wszDescription_e__FixedBuffer
    {
        public ushort e0;
    }
}
