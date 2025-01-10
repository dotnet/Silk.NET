// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SHFILEINFOW
{
    public HICON hIcon;
    public int iIcon;

    [NativeTypeName("DWORD")]
    public uint dwAttributes;

    [NativeTypeName("WCHAR[260]")]
    public _szDisplayName_e__FixedBuffer szDisplayName;

    [NativeTypeName("WCHAR[80]")]
    public _szTypeName_e__FixedBuffer szTypeName;

    [InlineArray(260)]
    public partial struct _szDisplayName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(80)]
    public partial struct _szTypeName_e__FixedBuffer
    {
        public ushort e0;
    }
}
