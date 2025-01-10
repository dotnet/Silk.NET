// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROCESSOR_IDLESTATE_INFO
{
    [NativeTypeName("DWORD")]
    public uint TimeCheck;
    public byte DemotePercent;
    public byte PromotePercent;

    [NativeTypeName("BYTE[2]")]
    public _Spare_e__FixedBuffer Spare;

    [InlineArray(2)]
    public partial struct _Spare_e__FixedBuffer
    {
        public byte e0;
    }
}
