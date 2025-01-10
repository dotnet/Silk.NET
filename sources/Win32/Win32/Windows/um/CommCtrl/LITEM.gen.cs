// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct LITEM
{
    public uint mask;
    public int iLink;
    public uint state;
    public uint stateMask;

    [NativeTypeName("WCHAR[48]")]
    public _szID_e__FixedBuffer szID;

    [NativeTypeName("WCHAR[2084]")]
    public _szUrl_e__FixedBuffer szUrl;

    [InlineArray(48)]
    public partial struct _szID_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(2084)]
    public partial struct _szUrl_e__FixedBuffer
    {
        public ushort e0;
    }
}
