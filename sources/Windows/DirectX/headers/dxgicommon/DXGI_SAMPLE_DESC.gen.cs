// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxgicommon.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='DXGI_SAMPLE_DESC.xml' path='doc/member[@name="DXGI_SAMPLE_DESC"]/*'/>
public partial struct DXGI_SAMPLE_DESC
{
    /// <include file='DXGI_SAMPLE_DESC.xml' path='doc/member[@name="DXGI_SAMPLE_DESC.Count"]/*'/>
    public uint Count;
    /// <include file='DXGI_SAMPLE_DESC.xml' path='doc/member[@name="DXGI_SAMPLE_DESC.Quality"]/*'/>
    public uint Quality;
}