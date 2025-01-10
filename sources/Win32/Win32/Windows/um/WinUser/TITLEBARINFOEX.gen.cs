// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TITLEBARINFOEX
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public RECT rcTitleBar;

    [NativeTypeName("DWORD[6]")]
    public _rgstate_e__FixedBuffer rgstate;

    [NativeTypeName("RECT[6]")]
    public _rgrect_e__FixedBuffer rgrect;

    [InlineArray(6)]
    public partial struct _rgstate_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(6)]
    public partial struct _rgrect_e__FixedBuffer
    {
        public RECT e0;
    }
}
