// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER"]/*'/>
[Flags]
public enum D3D10_FILTER
{
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_MAG_MIP_POINT"]/*'/>
    D3D10_FILTER_MIN_MAG_MIP_POINT = 0,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_MAG_POINT_MIP_LINEAR"]/*'/>
    D3D10_FILTER_MIN_MAG_POINT_MIP_LINEAR = 0x1,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*'/>
    D3D10_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x4,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_POINT_MAG_MIP_LINEAR"]/*'/>
    D3D10_FILTER_MIN_POINT_MAG_MIP_LINEAR = 0x5,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_LINEAR_MAG_MIP_POINT"]/*'/>
    D3D10_FILTER_MIN_LINEAR_MAG_MIP_POINT = 0x10,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*'/>
    D3D10_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x11,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_MAG_LINEAR_MIP_POINT"]/*'/>
    D3D10_FILTER_MIN_MAG_LINEAR_MIP_POINT = 0x14,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_MAG_MIP_LINEAR"]/*'/>
    D3D10_FILTER_MIN_MAG_MIP_LINEAR = 0x15,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_ANISOTROPIC"]/*'/>
    D3D10_FILTER_ANISOTROPIC = 0x55,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_MAG_MIP_POINT"]/*'/>
    D3D10_FILTER_COMPARISON_MIN_MAG_MIP_POINT = 0x80,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR"]/*'/>
    D3D10_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR = 0x81,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*'/>
    D3D10_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x84,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR"]/*'/>
    D3D10_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR = 0x85,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT"]/*'/>
    D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT = 0x90,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*'/>
    D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x91,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT"]/*'/>
    D3D10_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT = 0x94,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR"]/*'/>
    D3D10_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR = 0x95,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_ANISOTROPIC"]/*'/>
    D3D10_FILTER_COMPARISON_ANISOTROPIC = 0xd5,
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_TEXT_1BIT"]/*'/>
    D3D10_FILTER_TEXT_1BIT = unchecked((int)(0x80000000)),
}