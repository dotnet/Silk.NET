// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS"]/*'/>
public enum ASSOCCLASS
{
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_SHELL_KEY"]/*'/>
    ASSOCCLASS_SHELL_KEY = 0,
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_PROGID_KEY"]/*'/>
    ASSOCCLASS_PROGID_KEY,
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_PROGID_STR"]/*'/>
    ASSOCCLASS_PROGID_STR,
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_CLSID_KEY"]/*'/>
    ASSOCCLASS_CLSID_KEY,
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_CLSID_STR"]/*'/>
    ASSOCCLASS_CLSID_STR,
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_APP_KEY"]/*'/>
    ASSOCCLASS_APP_KEY,
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_APP_STR"]/*'/>
    ASSOCCLASS_APP_STR,
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_SYSTEM_STR"]/*'/>
    ASSOCCLASS_SYSTEM_STR,
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_FOLDER"]/*'/>
    ASSOCCLASS_FOLDER,
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_STAR"]/*'/>
    ASSOCCLASS_STAR,
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_FIXED_PROGID_STR"]/*'/>
    ASSOCCLASS_FIXED_PROGID_STR,
    /// <include file='ASSOCCLASS.xml' path='doc/member[@name="ASSOCCLASS.ASSOCCLASS_PROTOCOL_STR"]/*'/>
    ASSOCCLASS_PROTOCOL_STR,
}