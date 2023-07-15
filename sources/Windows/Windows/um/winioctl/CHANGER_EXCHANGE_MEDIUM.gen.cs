// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CHANGER_EXCHANGE_MEDIUM.xml' path='doc/member[@name="CHANGER_EXCHANGE_MEDIUM"]/*'/>
public partial struct CHANGER_EXCHANGE_MEDIUM
{
    /// <include file='CHANGER_EXCHANGE_MEDIUM.xml' path='doc/member[@name="CHANGER_EXCHANGE_MEDIUM.Transport"]/*'/>
    public CHANGER_ELEMENT Transport;
    /// <include file='CHANGER_EXCHANGE_MEDIUM.xml' path='doc/member[@name="CHANGER_EXCHANGE_MEDIUM.Source"]/*'/>
    public CHANGER_ELEMENT Source;
    /// <include file='CHANGER_EXCHANGE_MEDIUM.xml' path='doc/member[@name="CHANGER_EXCHANGE_MEDIUM.Destination1"]/*'/>
    public CHANGER_ELEMENT Destination1;
    /// <include file='CHANGER_EXCHANGE_MEDIUM.xml' path='doc/member[@name="CHANGER_EXCHANGE_MEDIUM.Destination2"]/*'/>
    public CHANGER_ELEMENT Destination2;
    /// <include file='CHANGER_EXCHANGE_MEDIUM.xml' path='doc/member[@name="CHANGER_EXCHANGE_MEDIUM.Flip1"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Flip1;
    /// <include file='CHANGER_EXCHANGE_MEDIUM.xml' path='doc/member[@name="CHANGER_EXCHANGE_MEDIUM.Flip2"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Flip2;
}