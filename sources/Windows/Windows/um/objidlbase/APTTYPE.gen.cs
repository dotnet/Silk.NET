// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='APTTYPE.xml' path='doc/member[@name="APTTYPE"]/*'/>
public enum APTTYPE
{
    /// <include file='APTTYPE.xml' path='doc/member[@name="APTTYPE.APTTYPE_CURRENT"]/*'/>
    APTTYPE_CURRENT = -1,
    /// <include file='APTTYPE.xml' path='doc/member[@name="APTTYPE.APTTYPE_STA"]/*'/>
    APTTYPE_STA = 0,
    /// <include file='APTTYPE.xml' path='doc/member[@name="APTTYPE.APTTYPE_MTA"]/*'/>
    APTTYPE_MTA = 1,
    /// <include file='APTTYPE.xml' path='doc/member[@name="APTTYPE.APTTYPE_NA"]/*'/>
    APTTYPE_NA = 2,
    /// <include file='APTTYPE.xml' path='doc/member[@name="APTTYPE.APTTYPE_MAINSTA"]/*'/>
    APTTYPE_MAINSTA = 3,
}