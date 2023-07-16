// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRSETMITERLIMIT.xml' path='doc/member[@name="EMRSETMITERLIMIT"]/*'/>
public partial struct EMRSETMITERLIMIT
{
    /// <include file='EMRSETMITERLIMIT.xml' path='doc/member[@name="EMRSETMITERLIMIT.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRSETMITERLIMIT.xml' path='doc/member[@name="EMRSETMITERLIMIT.eMiterLimit"]/*'/>
    public float eMiterLimit;
}