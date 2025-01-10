// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct SE_SID
{
    [FieldOffset(0)]
    public SID Sid;

    [FieldOffset(0)]
    [NativeTypeName("BYTE[68]")]
    public _Buffer_e__FixedBuffer Buffer;

    [InlineArray(68)]
    public partial struct _Buffer_e__FixedBuffer
    {
        public byte e0;
    }
}
