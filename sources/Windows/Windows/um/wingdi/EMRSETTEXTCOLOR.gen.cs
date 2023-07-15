// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRSETTEXTCOLOR.xml' path='doc/member[@name="EMRSETTEXTCOLOR"]/*'/>
public partial struct EMRSETTEXTCOLOR
{
    /// <include file='EMRSETTEXTCOLOR.xml' path='doc/member[@name="EMRSETTEXTCOLOR.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRSETTEXTCOLOR.xml' path='doc/member[@name="EMRSETTEXTCOLOR.crColor"]/*'/>
    public COLORREF crColor;
}