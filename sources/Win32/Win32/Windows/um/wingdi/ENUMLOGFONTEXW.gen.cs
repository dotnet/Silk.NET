// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct ENUMLOGFONTEXW
{
    public LOGFONTW elfLogFont;

    [NativeTypeName("WCHAR[64]")]
    public _elfFullName_e__FixedBuffer elfFullName;

    [NativeTypeName("WCHAR[32]")]
    public _elfStyle_e__FixedBuffer elfStyle;

    [NativeTypeName("WCHAR[32]")]
    public _elfScript_e__FixedBuffer elfScript;

    [InlineArray(64)]
    public partial struct _elfFullName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(32)]
    public partial struct _elfStyle_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(32)]
    public partial struct _elfScript_e__FixedBuffer
    {
        public ushort e0;
    }
}
