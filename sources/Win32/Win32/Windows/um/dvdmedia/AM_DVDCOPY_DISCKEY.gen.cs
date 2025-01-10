// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct AM_DVDCOPY_DISCKEY
{
    [NativeTypeName("BYTE[2048]")]
    public _DiscKey_e__FixedBuffer DiscKey;

    [InlineArray(2048)]
    public partial struct _DiscKey_e__FixedBuffer
    {
        public byte e0;
    }
}
