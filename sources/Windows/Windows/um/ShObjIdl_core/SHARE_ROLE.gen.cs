// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SHARE_ROLE.xml' path='doc/member[@name="SHARE_ROLE"]/*'/>
public enum SHARE_ROLE
{
    /// <include file='SHARE_ROLE.xml' path='doc/member[@name="SHARE_ROLE.SHARE_ROLE_INVALID"]/*'/>
    SHARE_ROLE_INVALID = -1,
    /// <include file='SHARE_ROLE.xml' path='doc/member[@name="SHARE_ROLE.SHARE_ROLE_READER"]/*'/>
    SHARE_ROLE_READER = 0,
    /// <include file='SHARE_ROLE.xml' path='doc/member[@name="SHARE_ROLE.SHARE_ROLE_CONTRIBUTOR"]/*'/>
    SHARE_ROLE_CONTRIBUTOR = 1,
    /// <include file='SHARE_ROLE.xml' path='doc/member[@name="SHARE_ROLE.SHARE_ROLE_CO_OWNER"]/*'/>
    SHARE_ROLE_CO_OWNER = 2,
    /// <include file='SHARE_ROLE.xml' path='doc/member[@name="SHARE_ROLE.SHARE_ROLE_OWNER"]/*'/>
    SHARE_ROLE_OWNER = 3,
    /// <include file='SHARE_ROLE.xml' path='doc/member[@name="SHARE_ROLE.SHARE_ROLE_CUSTOM"]/*'/>
    SHARE_ROLE_CUSTOM = 4,
    /// <include file='SHARE_ROLE.xml' path='doc/member[@name="SHARE_ROLE.SHARE_ROLE_MIXED"]/*'/>
    SHARE_ROLE_MIXED = 5,
}