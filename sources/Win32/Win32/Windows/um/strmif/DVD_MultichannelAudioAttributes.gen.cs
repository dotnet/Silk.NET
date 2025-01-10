// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DVD_MultichannelAudioAttributes
{
    [NativeTypeName("DVD_MUA_MixingInfo[8]")]
    public _Info_e__FixedBuffer Info;

    [NativeTypeName("DVD_MUA_Coeff[8]")]
    public _Coeff_e__FixedBuffer Coeff;

    [InlineArray(8)]
    public partial struct _Info_e__FixedBuffer
    {
        public DVD_MUA_MixingInfo e0;
    }

    [InlineArray(8)]
    public partial struct _Coeff_e__FixedBuffer
    {
        public DVD_MUA_Coeff e0;
    }
}
