// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRROUNDRECT.xml' path='doc/member[@name="EMRROUNDRECT"]/*'/>
public partial struct EMRROUNDRECT
{
    /// <include file='EMRROUNDRECT.xml' path='doc/member[@name="EMRROUNDRECT.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRROUNDRECT.xml' path='doc/member[@name="EMRROUNDRECT.rclBox"]/*'/>
    public RECTL rclBox;
    /// <include file='EMRROUNDRECT.xml' path='doc/member[@name="EMRROUNDRECT.szlCorner"]/*'/>
    [NativeTypeName("SIZEL")]
    public SIZE szlCorner;
}