// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CHANGER_SET_POSITION.xml' path='doc/member[@name="CHANGER_SET_POSITION"]/*'/>
public partial struct CHANGER_SET_POSITION
{
    /// <include file='CHANGER_SET_POSITION.xml' path='doc/member[@name="CHANGER_SET_POSITION.Transport"]/*'/>
    public CHANGER_ELEMENT Transport;
    /// <include file='CHANGER_SET_POSITION.xml' path='doc/member[@name="CHANGER_SET_POSITION.Destination"]/*'/>
    public CHANGER_ELEMENT Destination;
    /// <include file='CHANGER_SET_POSITION.xml' path='doc/member[@name="CHANGER_SET_POSITION.Flip"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Flip;
}