// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TYPEKIND.xml' path='doc/member[@name="TYPEKIND"]/*'/>
public enum TYPEKIND
{
    /// <include file='TYPEKIND.xml' path='doc/member[@name="TYPEKIND.TKIND_ENUM"]/*'/>
    TKIND_ENUM = 0,
    /// <include file='TYPEKIND.xml' path='doc/member[@name="TYPEKIND.TKIND_RECORD"]/*'/>
    TKIND_RECORD = (TKIND_ENUM + 1),
    /// <include file='TYPEKIND.xml' path='doc/member[@name="TYPEKIND.TKIND_MODULE"]/*'/>
    TKIND_MODULE = (TKIND_RECORD + 1),
    /// <include file='TYPEKIND.xml' path='doc/member[@name="TYPEKIND.TKIND_INTERFACE"]/*'/>
    TKIND_INTERFACE = (TKIND_MODULE + 1),
    /// <include file='TYPEKIND.xml' path='doc/member[@name="TYPEKIND.TKIND_DISPATCH"]/*'/>
    TKIND_DISPATCH = (TKIND_INTERFACE + 1),
    /// <include file='TYPEKIND.xml' path='doc/member[@name="TYPEKIND.TKIND_COCLASS"]/*'/>
    TKIND_COCLASS = (TKIND_DISPATCH + 1),
    /// <include file='TYPEKIND.xml' path='doc/member[@name="TYPEKIND.TKIND_ALIAS"]/*'/>
    TKIND_ALIAS = (TKIND_COCLASS + 1),
    /// <include file='TYPEKIND.xml' path='doc/member[@name="TYPEKIND.TKIND_UNION"]/*'/>
    TKIND_UNION = (TKIND_ALIAS + 1),
    /// <include file='TYPEKIND.xml' path='doc/member[@name="TYPEKIND.TKIND_MAX"]/*'/>
    TKIND_MAX = (TKIND_UNION + 1),
}