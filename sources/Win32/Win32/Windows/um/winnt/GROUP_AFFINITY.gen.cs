// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct GROUP_AFFINITY
{
    [NativeTypeName("KAFFINITY")]
    public nuint Mask;

    [NativeTypeName("WORD")]
    public ushort Group;

    [NativeTypeName("WORD[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public ushort e0;
    }
}
