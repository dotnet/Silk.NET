// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PREVENT_MEDIA_REMOVAL.xml' path='doc/member[@name="PREVENT_MEDIA_REMOVAL"]/*'/>
public partial struct PREVENT_MEDIA_REMOVAL
{
    /// <include file='PREVENT_MEDIA_REMOVAL.xml' path='doc/member[@name="PREVENT_MEDIA_REMOVAL.PreventMediaRemoval"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte PreventMediaRemoval;
}