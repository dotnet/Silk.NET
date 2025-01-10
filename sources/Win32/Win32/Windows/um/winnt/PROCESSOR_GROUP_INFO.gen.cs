// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROCESSOR_GROUP_INFO
{
    public byte MaximumProcessorCount;
    public byte ActiveProcessorCount;

    [NativeTypeName("BYTE[38]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("KAFFINITY")]
    public nuint ActiveProcessorMask;

    [InlineArray(38)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
