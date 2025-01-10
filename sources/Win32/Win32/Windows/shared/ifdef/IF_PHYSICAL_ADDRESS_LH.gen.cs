// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IF_PHYSICAL_ADDRESS_LH
{
    public ushort Length;

    [NativeTypeName("UCHAR[32]")]
    public _Address_e__FixedBuffer Address;

    [InlineArray(32)]
    public partial struct _Address_e__FixedBuffer
    {
        public byte e0;
    }
}
