// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BORDERTYPE.xml' path='doc/member[@name="BORDERTYPE"]/*'/>
public enum BORDERTYPE
{
    /// <include file='BORDERTYPE.xml' path='doc/member[@name="BORDERTYPE.BT_RECT"]/*'/>
    BT_RECT = 0,
    /// <include file='BORDERTYPE.xml' path='doc/member[@name="BORDERTYPE.BT_ROUNDRECT"]/*'/>
    BT_ROUNDRECT = 1,
    /// <include file='BORDERTYPE.xml' path='doc/member[@name="BORDERTYPE.BT_ELLIPSE"]/*'/>
    BT_ELLIPSE = 2,
}