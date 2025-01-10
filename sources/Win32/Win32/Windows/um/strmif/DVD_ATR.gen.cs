// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DVD_ATR
{
    [NativeTypeName("ULONG")]
    public uint ulCAT;

    [NativeTypeName("BYTE[768]")]
    public _pbATRI_e__FixedBuffer pbATRI;

    [InlineArray(768)]
    public partial struct _pbATRI_e__FixedBuffer
    {
        public byte e0;
    }
}
