// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_RT_FORMAT_ARRAY.xml' path='doc/member[@name="D3D12_RT_FORMAT_ARRAY"]/*'/>
public partial struct D3D12_RT_FORMAT_ARRAY
{
    /// <include file='D3D12_RT_FORMAT_ARRAY.xml' path='doc/member[@name="D3D12_RT_FORMAT_ARRAY.RTFormats"]/*'/>

    [NativeTypeName("DXGI_FORMAT[8]")]
    public _RTFormats_e__FixedBuffer RTFormats;

    /// <include file='D3D12_RT_FORMAT_ARRAY.xml' path='doc/member[@name="D3D12_RT_FORMAT_ARRAY.NumRenderTargets"]/*'/>

    public uint NumRenderTargets;

    /// <include file='_RTFormats_e__FixedBuffer.xml' path='doc/member[@name="_RTFormats_e__FixedBuffer"]/*'/>

    [InlineArray(8)]
    public partial struct _RTFormats_e__FixedBuffer
    {
        public DXGI_FORMAT e0;
    }
}
