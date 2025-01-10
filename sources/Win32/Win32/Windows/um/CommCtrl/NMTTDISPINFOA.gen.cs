// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct NMTTDISPINFOA
{
    public NMHDR hdr;

    [NativeTypeName("LPSTR")]
    public sbyte* lpszText;

    [NativeTypeName("char[80]")]
    public _szText_e__FixedBuffer szText;
    public HINSTANCE hinst;
    public uint uFlags;
    public LPARAM lParam;

    [InlineArray(80)]
    public partial struct _szText_e__FixedBuffer
    {
        public sbyte e0;
    }
}
