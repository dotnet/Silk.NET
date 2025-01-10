// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct AM_DVDCOPY_CHLGKEY
{
    [NativeTypeName("BYTE[10]")]
    public _ChlgKey_e__FixedBuffer ChlgKey;

    [NativeTypeName("BYTE[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    [InlineArray(10)]
    public partial struct _ChlgKey_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
