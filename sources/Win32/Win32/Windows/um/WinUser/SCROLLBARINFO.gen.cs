// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCROLLBARINFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public RECT rcScrollBar;
    public int dxyLineButton;
    public int xyThumbTop;
    public int xyThumbBottom;
    public int reserved;

    [NativeTypeName("DWORD[6]")]
    public _rgstate_e__FixedBuffer rgstate;

    [InlineArray(6)]
    public partial struct _rgstate_e__FixedBuffer
    {
        public uint e0;
    }
}
