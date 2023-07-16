// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CHANGER_MOVE_MEDIUM.xml' path='doc/member[@name="CHANGER_MOVE_MEDIUM"]/*'/>
public partial struct CHANGER_MOVE_MEDIUM
{
    /// <include file='CHANGER_MOVE_MEDIUM.xml' path='doc/member[@name="CHANGER_MOVE_MEDIUM.Transport"]/*'/>
    public CHANGER_ELEMENT Transport;
    /// <include file='CHANGER_MOVE_MEDIUM.xml' path='doc/member[@name="CHANGER_MOVE_MEDIUM.Source"]/*'/>
    public CHANGER_ELEMENT Source;
    /// <include file='CHANGER_MOVE_MEDIUM.xml' path='doc/member[@name="CHANGER_MOVE_MEDIUM.Destination"]/*'/>
    public CHANGER_ELEMENT Destination;
    /// <include file='CHANGER_MOVE_MEDIUM.xml' path='doc/member[@name="CHANGER_MOVE_MEDIUM.Flip"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Flip;
}