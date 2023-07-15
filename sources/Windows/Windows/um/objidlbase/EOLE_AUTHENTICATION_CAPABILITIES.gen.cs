// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES"]/*'/>
[Flags]
public enum EOLE_AUTHENTICATION_CAPABILITIES
{
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_NONE"]/*'/>
    EOAC_NONE = 0,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_MUTUAL_AUTH"]/*'/>
    EOAC_MUTUAL_AUTH = 0x1,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_STATIC_CLOAKING"]/*'/>
    EOAC_STATIC_CLOAKING = 0x20,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_DYNAMIC_CLOAKING"]/*'/>
    EOAC_DYNAMIC_CLOAKING = 0x40,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_ANY_AUTHORITY"]/*'/>
    EOAC_ANY_AUTHORITY = 0x80,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_MAKE_FULLSIC"]/*'/>
    EOAC_MAKE_FULLSIC = 0x100,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_DEFAULT"]/*'/>
    EOAC_DEFAULT = 0x800,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_SECURE_REFS"]/*'/>
    EOAC_SECURE_REFS = 0x2,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_ACCESS_CONTROL"]/*'/>
    EOAC_ACCESS_CONTROL = 0x4,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_APPID"]/*'/>
    EOAC_APPID = 0x8,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_DYNAMIC"]/*'/>
    EOAC_DYNAMIC = 0x10,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_REQUIRE_FULLSIC"]/*'/>
    EOAC_REQUIRE_FULLSIC = 0x200,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_AUTO_IMPERSONATE"]/*'/>
    EOAC_AUTO_IMPERSONATE = 0x400,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_DISABLE_AAA"]/*'/>
    EOAC_DISABLE_AAA = 0x1000,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_NO_CUSTOM_MARSHAL"]/*'/>
    EOAC_NO_CUSTOM_MARSHAL = 0x2000,
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_RESERVED1"]/*'/>
    EOAC_RESERVED1 = 0x4000,
}