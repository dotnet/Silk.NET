// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC"]/*'/>
public enum D3D12_COMPARISON_FUNC
{
    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_NONE"]/*'/>
    D3D12_COMPARISON_FUNC_NONE = 0,
    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_NEVER"]/*'/>
    D3D12_COMPARISON_FUNC_NEVER = 1,
    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_LESS"]/*'/>
    D3D12_COMPARISON_FUNC_LESS = 2,
    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_EQUAL"]/*'/>
    D3D12_COMPARISON_FUNC_EQUAL = 3,
    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_LESS_EQUAL"]/*'/>
    D3D12_COMPARISON_FUNC_LESS_EQUAL = 4,
    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_GREATER"]/*'/>
    D3D12_COMPARISON_FUNC_GREATER = 5,
    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_NOT_EQUAL"]/*'/>
    D3D12_COMPARISON_FUNC_NOT_EQUAL = 6,
    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_GREATER_EQUAL"]/*'/>
    D3D12_COMPARISON_FUNC_GREATER_EQUAL = 7,
    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_ALWAYS"]/*'/>
    D3D12_COMPARISON_FUNC_ALWAYS = 8,
}