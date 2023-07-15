// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_GEOMETRY_RELATION.xml' path='doc/member[@name="D2D1_GEOMETRY_RELATION"]/*'/>
public enum D2D1_GEOMETRY_RELATION
{
    /// <include file='D2D1_GEOMETRY_RELATION.xml' path='doc/member[@name="D2D1_GEOMETRY_RELATION.D2D1_GEOMETRY_RELATION_UNKNOWN"]/*'/>
    D2D1_GEOMETRY_RELATION_UNKNOWN = 0,
    /// <include file='D2D1_GEOMETRY_RELATION.xml' path='doc/member[@name="D2D1_GEOMETRY_RELATION.D2D1_GEOMETRY_RELATION_DISJOINT"]/*'/>
    D2D1_GEOMETRY_RELATION_DISJOINT = 1,
    /// <include file='D2D1_GEOMETRY_RELATION.xml' path='doc/member[@name="D2D1_GEOMETRY_RELATION.D2D1_GEOMETRY_RELATION_IS_CONTAINED"]/*'/>
    D2D1_GEOMETRY_RELATION_IS_CONTAINED = 2,
    /// <include file='D2D1_GEOMETRY_RELATION.xml' path='doc/member[@name="D2D1_GEOMETRY_RELATION.D2D1_GEOMETRY_RELATION_CONTAINS"]/*'/>
    D2D1_GEOMETRY_RELATION_CONTAINS = 3,
    /// <include file='D2D1_GEOMETRY_RELATION.xml' path='doc/member[@name="D2D1_GEOMETRY_RELATION.D2D1_GEOMETRY_RELATION_OVERLAP"]/*'/>
    D2D1_GEOMETRY_RELATION_OVERLAP = 4,
    /// <include file='D2D1_GEOMETRY_RELATION.xml' path='doc/member[@name="D2D1_GEOMETRY_RELATION.D2D1_GEOMETRY_RELATION_FORCE_DWORD"]/*'/>
    D2D1_GEOMETRY_RELATION_FORCE_DWORD = unchecked((int)(0xffffffff)),
}