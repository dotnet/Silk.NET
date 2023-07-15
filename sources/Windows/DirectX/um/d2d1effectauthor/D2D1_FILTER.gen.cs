// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_FILTER.xml' path='doc/member[@name="D2D1_FILTER"]/*'/>
public enum D2D1_FILTER
{
    /// <include file='D2D1_FILTER.xml' path='doc/member[@name="D2D1_FILTER.D2D1_FILTER_MIN_MAG_MIP_POINT"]/*'/>
    D2D1_FILTER_MIN_MAG_MIP_POINT = 0x00,
    /// <include file='D2D1_FILTER.xml' path='doc/member[@name="D2D1_FILTER.D2D1_FILTER_MIN_MAG_POINT_MIP_LINEAR"]/*'/>
    D2D1_FILTER_MIN_MAG_POINT_MIP_LINEAR = 0x01,
    /// <include file='D2D1_FILTER.xml' path='doc/member[@name="D2D1_FILTER.D2D1_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*'/>
    D2D1_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x04,
    /// <include file='D2D1_FILTER.xml' path='doc/member[@name="D2D1_FILTER.D2D1_FILTER_MIN_POINT_MAG_MIP_LINEAR"]/*'/>
    D2D1_FILTER_MIN_POINT_MAG_MIP_LINEAR = 0x05,
    /// <include file='D2D1_FILTER.xml' path='doc/member[@name="D2D1_FILTER.D2D1_FILTER_MIN_LINEAR_MAG_MIP_POINT"]/*'/>
    D2D1_FILTER_MIN_LINEAR_MAG_MIP_POINT = 0x10,
    /// <include file='D2D1_FILTER.xml' path='doc/member[@name="D2D1_FILTER.D2D1_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*'/>
    D2D1_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x11,
    /// <include file='D2D1_FILTER.xml' path='doc/member[@name="D2D1_FILTER.D2D1_FILTER_MIN_MAG_LINEAR_MIP_POINT"]/*'/>
    D2D1_FILTER_MIN_MAG_LINEAR_MIP_POINT = 0x14,
    /// <include file='D2D1_FILTER.xml' path='doc/member[@name="D2D1_FILTER.D2D1_FILTER_MIN_MAG_MIP_LINEAR"]/*'/>
    D2D1_FILTER_MIN_MAG_MIP_LINEAR = 0x15,
    /// <include file='D2D1_FILTER.xml' path='doc/member[@name="D2D1_FILTER.D2D1_FILTER_ANISOTROPIC"]/*'/>
    D2D1_FILTER_ANISOTROPIC = 0x55,
    /// <include file='D2D1_FILTER.xml' path='doc/member[@name="D2D1_FILTER.D2D1_FILTER_FORCE_DWORD"]/*'/>
    D2D1_FILTER_FORCE_DWORD = unchecked((int)(0xffffffff)),
}