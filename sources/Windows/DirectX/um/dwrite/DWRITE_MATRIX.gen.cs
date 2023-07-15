// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_MATRIX.xml' path='doc/member[@name="DWRITE_MATRIX"]/*'/>
public partial struct DWRITE_MATRIX
{
    /// <include file='DWRITE_MATRIX.xml' path='doc/member[@name="DWRITE_MATRIX.m11"]/*'/>
    public float m11;
    /// <include file='DWRITE_MATRIX.xml' path='doc/member[@name="DWRITE_MATRIX.m12"]/*'/>
    public float m12;
    /// <include file='DWRITE_MATRIX.xml' path='doc/member[@name="DWRITE_MATRIX.m21"]/*'/>
    public float m21;
    /// <include file='DWRITE_MATRIX.xml' path='doc/member[@name="DWRITE_MATRIX.m22"]/*'/>
    public float m22;
    /// <include file='DWRITE_MATRIX.xml' path='doc/member[@name="DWRITE_MATRIX.dx"]/*'/>
    public float dx;
    /// <include file='DWRITE_MATRIX.xml' path='doc/member[@name="DWRITE_MATRIX.dy"]/*'/>
    public float dy;
}