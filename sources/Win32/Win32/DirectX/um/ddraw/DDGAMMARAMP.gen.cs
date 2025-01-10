// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DDGAMMARAMP
{
    [NativeTypeName("WORD[256]")]
    public _red_e__FixedBuffer red;

    [NativeTypeName("WORD[256]")]
    public _green_e__FixedBuffer green;

    [NativeTypeName("WORD[256]")]
    public _blue_e__FixedBuffer blue;

    [InlineArray(256)]
    public partial struct _red_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(256)]
    public partial struct _green_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(256)]
    public partial struct _blue_e__FixedBuffer
    {
        public ushort e0;
    }
}
