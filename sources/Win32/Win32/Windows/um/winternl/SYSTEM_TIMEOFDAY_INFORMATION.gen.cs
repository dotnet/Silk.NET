// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYSTEM_TIMEOFDAY_INFORMATION
{
    [NativeTypeName("BYTE[48]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    [InlineArray(48)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }
}
