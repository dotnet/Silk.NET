// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE"]/*'/>
public enum D3D12_COLOR_WRITE_ENABLE
{
    /// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE.D3D12_COLOR_WRITE_ENABLE_RED"]/*'/>
    D3D12_COLOR_WRITE_ENABLE_RED = 1,
    /// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE.D3D12_COLOR_WRITE_ENABLE_GREEN"]/*'/>
    D3D12_COLOR_WRITE_ENABLE_GREEN = 2,
    /// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE.D3D12_COLOR_WRITE_ENABLE_BLUE"]/*'/>
    D3D12_COLOR_WRITE_ENABLE_BLUE = 4,
    /// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE.D3D12_COLOR_WRITE_ENABLE_ALPHA"]/*'/>
    D3D12_COLOR_WRITE_ENABLE_ALPHA = 8,
    /// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE.D3D12_COLOR_WRITE_ENABLE_ALL"]/*'/>
    D3D12_COLOR_WRITE_ENABLE_ALL = (((D3D12_COLOR_WRITE_ENABLE_RED | D3D12_COLOR_WRITE_ENABLE_GREEN) | D3D12_COLOR_WRITE_ENABLE_BLUE) | D3D12_COLOR_WRITE_ENABLE_ALPHA),
}