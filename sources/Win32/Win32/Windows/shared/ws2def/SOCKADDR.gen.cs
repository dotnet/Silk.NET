// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SOCKADDR
{
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort sa_family;

    [NativeTypeName("CHAR[14]")]
    public _sa_data_e__FixedBuffer sa_data;

    [InlineArray(14)]
    public partial struct _sa_data_e__FixedBuffer
    {
        public sbyte e0;
    }
}
