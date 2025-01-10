// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MFFOLDDOWN_MATRIX
{
    [NativeTypeName("UINT32")]
    public uint cbSize;

    [NativeTypeName("UINT32")]
    public uint cSrcChannels;

    [NativeTypeName("UINT32")]
    public uint cDstChannels;

    [NativeTypeName("UINT32")]
    public uint dwChannelMask;

    [NativeTypeName("LONG[64]")]
    public _Coeff_e__FixedBuffer Coeff;

    [InlineArray(64)]
    public partial struct _Coeff_e__FixedBuffer
    {
        public int e0;
    }
}
