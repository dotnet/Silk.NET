// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_FORMAT_SUPPORT2")]
    public enum FormatSupport2 : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"UavAtomicAdd\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_ADD")]
        FormatSupport2UavAtomicAdd = 0x1,
        [Obsolete("Deprecated in favour of \"UavAtomicBitwiseOps\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS")]
        FormatSupport2UavAtomicBitwiseOps = 0x2,
        [Obsolete("Deprecated in favour of \"UavAtomicCompareStoreOrCompareExchange\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE")]
        FormatSupport2UavAtomicCompareStoreOrCompareExchange = 0x4,
        [Obsolete("Deprecated in favour of \"UavAtomicExchange\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE")]
        FormatSupport2UavAtomicExchange = 0x8,
        [Obsolete("Deprecated in favour of \"UavAtomicSignedMinOrMax\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX")]
        FormatSupport2UavAtomicSignedMinOrMax = 0x10,
        [Obsolete("Deprecated in favour of \"UavAtomicUnsignedMinOrMax\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX")]
        FormatSupport2UavAtomicUnsignedMinOrMax = 0x20,
        [Obsolete("Deprecated in favour of \"UavTypedLoad\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_TYPED_LOAD")]
        FormatSupport2UavTypedLoad = 0x40,
        [Obsolete("Deprecated in favour of \"UavTypedStore\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_TYPED_STORE")]
        FormatSupport2UavTypedStore = 0x80,
        [Obsolete("Deprecated in favour of \"OutputMergerLogicOp\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP")]
        FormatSupport2OutputMergerLogicOp = 0x100,
        [Obsolete("Deprecated in favour of \"Tiled\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_TILED")]
        FormatSupport2Tiled = 0x200,
        [Obsolete("Deprecated in favour of \"Shareable\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_SHAREABLE")]
        FormatSupport2Shareable = 0x400,
        [Obsolete("Deprecated in favour of \"MultiplaneOverlay\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY")]
        FormatSupport2MultiplaneOverlay = 0x4000,
        [Obsolete("Deprecated in favour of \"Displayable\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_DISPLAYABLE")]
        FormatSupport2Displayable = 0x10000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_ADD")]
        UavAtomicAdd = 0x1,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS")]
        UavAtomicBitwiseOps = 0x2,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE")]
        UavAtomicCompareStoreOrCompareExchange = 0x4,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE")]
        UavAtomicExchange = 0x8,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX")]
        UavAtomicSignedMinOrMax = 0x10,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX")]
        UavAtomicUnsignedMinOrMax = 0x20,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_TYPED_LOAD")]
        UavTypedLoad = 0x40,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_UAV_TYPED_STORE")]
        UavTypedStore = 0x80,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP")]
        OutputMergerLogicOp = 0x100,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_TILED")]
        Tiled = 0x200,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_SHAREABLE")]
        Shareable = 0x400,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY")]
        MultiplaneOverlay = 0x4000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT2_DISPLAYABLE")]
        Displayable = 0x10000,
    }
}
