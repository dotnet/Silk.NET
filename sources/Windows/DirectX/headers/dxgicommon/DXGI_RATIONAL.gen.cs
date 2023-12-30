// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxgicommon.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='DXGI_RATIONAL.xml' path='doc/member[@name="DXGI_RATIONAL"]/*'/>
public partial struct DXGI_RATIONAL
{
    /// <include file='DXGI_RATIONAL.xml' path='doc/member[@name="DXGI_RATIONAL.Numerator"]/*'/>

    public uint Numerator;

    /// <include file='DXGI_RATIONAL.xml' path='doc/member[@name="DXGI_RATIONAL.Denominator"]/*'/>

    public uint Denominator;
}
