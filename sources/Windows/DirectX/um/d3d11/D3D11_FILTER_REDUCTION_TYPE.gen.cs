// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D11_FILTER_REDUCTION_TYPE"]/*'/>
public enum D3D11_FILTER_REDUCTION_TYPE
{
    /// <include file='D3D11_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D11_FILTER_REDUCTION_TYPE.D3D11_FILTER_REDUCTION_TYPE_STANDARD"]/*'/>
    D3D11_FILTER_REDUCTION_TYPE_STANDARD = 0,
    /// <include file='D3D11_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D11_FILTER_REDUCTION_TYPE.D3D11_FILTER_REDUCTION_TYPE_COMPARISON"]/*'/>
    D3D11_FILTER_REDUCTION_TYPE_COMPARISON = 1,
    /// <include file='D3D11_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D11_FILTER_REDUCTION_TYPE.D3D11_FILTER_REDUCTION_TYPE_MINIMUM"]/*'/>
    D3D11_FILTER_REDUCTION_TYPE_MINIMUM = 2,
    /// <include file='D3D11_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D11_FILTER_REDUCTION_TYPE.D3D11_FILTER_REDUCTION_TYPE_MAXIMUM"]/*'/>
    D3D11_FILTER_REDUCTION_TYPE_MAXIMUM = 3,
}