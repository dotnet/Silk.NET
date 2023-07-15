// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WTS_THUMBNAILID.xml' path='doc/member[@name="WTS_THUMBNAILID"]/*'/>
public unsafe partial struct WTS_THUMBNAILID
{
    /// <include file='WTS_THUMBNAILID.xml' path='doc/member[@name="WTS_THUMBNAILID.rgbKey"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte rgbKey[16];
}