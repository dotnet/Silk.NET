// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D_POINT_2U.xml' path='doc/member[@name="D2D_POINT_2U"]/*'/>
public partial struct D2D_POINT_2U
{
    /// <include file='D2D_POINT_2U.xml' path='doc/member[@name="D2D_POINT_2U.x"]/*'/>
    [NativeTypeName("UINT32")]
    public uint x;
    /// <include file='D2D_POINT_2U.xml' path='doc/member[@name="D2D_POINT_2U.y"]/*'/>
    [NativeTypeName("UINT32")]
    public uint y;
}