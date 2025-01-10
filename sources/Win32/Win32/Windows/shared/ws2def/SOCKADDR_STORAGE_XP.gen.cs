// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SOCKADDR_STORAGE_XP
{
    public short ss_family;

    [NativeTypeName("CHAR[6]")]
    public ___ss_pad1_e__FixedBuffer __ss_pad1;

    [NativeTypeName("long long")]
    public long __ss_align;

    [NativeTypeName("CHAR[112]")]
    public ___ss_pad2_e__FixedBuffer __ss_pad2;

    [InlineArray(6)]
    public partial struct ___ss_pad1_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(112)]
    public partial struct ___ss_pad2_e__FixedBuffer
    {
        public sbyte e0;
    }
}
