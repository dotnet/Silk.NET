// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DiaTagValue
{
    [NativeTypeName("BYTE[16]")]
    public _value_e__FixedBuffer value;
    public byte valueSizeBytes;

    [InlineArray(16)]
    public partial struct _value_e__FixedBuffer
    {
        public byte e0;
    }
}
