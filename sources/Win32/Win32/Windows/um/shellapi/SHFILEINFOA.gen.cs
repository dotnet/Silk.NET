// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SHFILEINFOA
{
    public HICON hIcon;
    public int iIcon;

    [NativeTypeName("DWORD")]
    public uint dwAttributes;

    [NativeTypeName("CHAR[260]")]
    public _szDisplayName_e__FixedBuffer szDisplayName;

    [NativeTypeName("CHAR[80]")]
    public _szTypeName_e__FixedBuffer szTypeName;

    [InlineArray(260)]
    public partial struct _szDisplayName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(80)]
    public partial struct _szTypeName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
