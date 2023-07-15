// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_CHANNEL_DEPTH.xml' path='doc/member[@name="D2D1_CHANNEL_DEPTH"]/*'/>
public enum D2D1_CHANNEL_DEPTH
{
    /// <include file='D2D1_CHANNEL_DEPTH.xml' path='doc/member[@name="D2D1_CHANNEL_DEPTH.D2D1_CHANNEL_DEPTH_DEFAULT"]/*'/>
    D2D1_CHANNEL_DEPTH_DEFAULT = 0,
    /// <include file='D2D1_CHANNEL_DEPTH.xml' path='doc/member[@name="D2D1_CHANNEL_DEPTH.D2D1_CHANNEL_DEPTH_1"]/*'/>
    D2D1_CHANNEL_DEPTH_1 = 1,
    /// <include file='D2D1_CHANNEL_DEPTH.xml' path='doc/member[@name="D2D1_CHANNEL_DEPTH.D2D1_CHANNEL_DEPTH_4"]/*'/>
    D2D1_CHANNEL_DEPTH_4 = 4,
    /// <include file='D2D1_CHANNEL_DEPTH.xml' path='doc/member[@name="D2D1_CHANNEL_DEPTH.D2D1_CHANNEL_DEPTH_FORCE_DWORD"]/*'/>
    D2D1_CHANNEL_DEPTH_FORCE_DWORD = unchecked((int)(0xffffffff)),
}