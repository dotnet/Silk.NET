// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D_RECT_U.xml' path='doc/member[@name="D2D_RECT_U"]/*'/>
public partial struct D2D_RECT_U
{
    /// <include file='D2D_RECT_U.xml' path='doc/member[@name="D2D_RECT_U.left"]/*'/>
    [NativeTypeName("UINT32")]
    public uint left;
    /// <include file='D2D_RECT_U.xml' path='doc/member[@name="D2D_RECT_U.top"]/*'/>
    [NativeTypeName("UINT32")]
    public uint top;
    /// <include file='D2D_RECT_U.xml' path='doc/member[@name="D2D_RECT_U.right"]/*'/>
    [NativeTypeName("UINT32")]
    public uint right;
    /// <include file='D2D_RECT_U.xml' path='doc/member[@name="D2D_RECT_U.bottom"]/*'/>
    [NativeTypeName("UINT32")]
    public uint bottom;
}