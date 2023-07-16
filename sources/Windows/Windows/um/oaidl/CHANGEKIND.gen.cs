// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CHANGEKIND.xml' path='doc/member[@name="CHANGEKIND"]/*'/>
public enum CHANGEKIND
{
    /// <include file='CHANGEKIND.xml' path='doc/member[@name="CHANGEKIND.CHANGEKIND_ADDMEMBER"]/*'/>
    CHANGEKIND_ADDMEMBER = 0,
    /// <include file='CHANGEKIND.xml' path='doc/member[@name="CHANGEKIND.CHANGEKIND_DELETEMEMBER"]/*'/>
    CHANGEKIND_DELETEMEMBER = (CHANGEKIND_ADDMEMBER + 1),
    /// <include file='CHANGEKIND.xml' path='doc/member[@name="CHANGEKIND.CHANGEKIND_SETNAMES"]/*'/>
    CHANGEKIND_SETNAMES = (CHANGEKIND_DELETEMEMBER + 1),
    /// <include file='CHANGEKIND.xml' path='doc/member[@name="CHANGEKIND.CHANGEKIND_SETDOCUMENTATION"]/*'/>
    CHANGEKIND_SETDOCUMENTATION = (CHANGEKIND_SETNAMES + 1),
    /// <include file='CHANGEKIND.xml' path='doc/member[@name="CHANGEKIND.CHANGEKIND_GENERAL"]/*'/>
    CHANGEKIND_GENERAL = (CHANGEKIND_SETDOCUMENTATION + 1),
    /// <include file='CHANGEKIND.xml' path='doc/member[@name="CHANGEKIND.CHANGEKIND_INVALIDATE"]/*'/>
    CHANGEKIND_INVALIDATE = (CHANGEKIND_GENERAL + 1),
    /// <include file='CHANGEKIND.xml' path='doc/member[@name="CHANGEKIND.CHANGEKIND_CHANGEFAILED"]/*'/>
    CHANGEKIND_CHANGEFAILED = (CHANGEKIND_INVALIDATE + 1),
    /// <include file='CHANGEKIND.xml' path='doc/member[@name="CHANGEKIND.CHANGEKIND_MAX"]/*'/>
    CHANGEKIND_MAX = (CHANGEKIND_CHANGEFAILED + 1),
}