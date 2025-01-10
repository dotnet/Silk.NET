// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SecPkgContext_EapKeyBlock
{
    [NativeTypeName("BYTE[128]")]
    public _rgbKeys_e__FixedBuffer rgbKeys;

    [NativeTypeName("BYTE[64]")]
    public _rgbIVs_e__FixedBuffer rgbIVs;

    [InlineArray(128)]
    public partial struct _rgbKeys_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(64)]
    public partial struct _rgbIVs_e__FixedBuffer
    {
        public byte e0;
    }
}
