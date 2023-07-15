// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_VERTEX_USAGE.xml' path='doc/member[@name="D2D1_VERTEX_USAGE"]/*'/>
public enum D2D1_VERTEX_USAGE
{
    /// <include file='D2D1_VERTEX_USAGE.xml' path='doc/member[@name="D2D1_VERTEX_USAGE.D2D1_VERTEX_USAGE_STATIC"]/*'/>
    D2D1_VERTEX_USAGE_STATIC = 0,
    /// <include file='D2D1_VERTEX_USAGE.xml' path='doc/member[@name="D2D1_VERTEX_USAGE.D2D1_VERTEX_USAGE_DYNAMIC"]/*'/>
    D2D1_VERTEX_USAGE_DYNAMIC = 1,
    /// <include file='D2D1_VERTEX_USAGE.xml' path='doc/member[@name="D2D1_VERTEX_USAGE.D2D1_VERTEX_USAGE_FORCE_DWORD"]/*'/>
    D2D1_VERTEX_USAGE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}