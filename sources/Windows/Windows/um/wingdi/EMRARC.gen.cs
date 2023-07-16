// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRARC.xml' path='doc/member[@name="EMRARC"]/*'/>
public partial struct EMRARC
{
    /// <include file='EMRARC.xml' path='doc/member[@name="EMRARC.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRARC.xml' path='doc/member[@name="EMRARC.rclBox"]/*'/>
    public RECTL rclBox;
    /// <include file='EMRARC.xml' path='doc/member[@name="EMRARC.ptlStart"]/*'/>
    public POINTL ptlStart;
    /// <include file='EMRARC.xml' path='doc/member[@name="EMRARC.ptlEnd"]/*'/>
    public POINTL ptlEnd;
}