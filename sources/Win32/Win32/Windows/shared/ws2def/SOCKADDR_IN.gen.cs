// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SOCKADDR_IN
{
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort sin_family;
    public ushort sin_port;
    public IN_ADDR sin_addr;

    [NativeTypeName("CHAR[8]")]
    public _sin_zero_e__FixedBuffer sin_zero;

    [InlineArray(8)]
    public partial struct _sin_zero_e__FixedBuffer
    {
        public sbyte e0;
    }
}
