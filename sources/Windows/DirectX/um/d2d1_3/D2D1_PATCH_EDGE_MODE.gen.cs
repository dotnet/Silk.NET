// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_PATCH_EDGE_MODE.xml' path='doc/member[@name="D2D1_PATCH_EDGE_MODE"]/*'/>
public enum D2D1_PATCH_EDGE_MODE
{
    /// <include file='D2D1_PATCH_EDGE_MODE.xml' path='doc/member[@name="D2D1_PATCH_EDGE_MODE.D2D1_PATCH_EDGE_MODE_ALIASED"]/*'/>
    D2D1_PATCH_EDGE_MODE_ALIASED = 0,
    /// <include file='D2D1_PATCH_EDGE_MODE.xml' path='doc/member[@name="D2D1_PATCH_EDGE_MODE.D2D1_PATCH_EDGE_MODE_ANTIALIASED"]/*'/>
    D2D1_PATCH_EDGE_MODE_ANTIALIASED = 1,
    /// <include file='D2D1_PATCH_EDGE_MODE.xml' path='doc/member[@name="D2D1_PATCH_EDGE_MODE.D2D1_PATCH_EDGE_MODE_ALIASED_INFLATED"]/*'/>
    D2D1_PATCH_EDGE_MODE_ALIASED_INFLATED = 2,
    /// <include file='D2D1_PATCH_EDGE_MODE.xml' path='doc/member[@name="D2D1_PATCH_EDGE_MODE.D2D1_PATCH_EDGE_MODE_FORCE_DWORD"]/*'/>
    D2D1_PATCH_EDGE_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}