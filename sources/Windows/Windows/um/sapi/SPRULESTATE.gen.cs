// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPRULESTATE.xml' path='doc/member[@name="SPRULESTATE"]/*'/>
public enum SPRULESTATE
{
    /// <include file='SPRULESTATE.xml' path='doc/member[@name="SPRULESTATE.SPRS_INACTIVE"]/*'/>
    SPRS_INACTIVE = 0,
    /// <include file='SPRULESTATE.xml' path='doc/member[@name="SPRULESTATE.SPRS_ACTIVE"]/*'/>
    SPRS_ACTIVE = 1,
    /// <include file='SPRULESTATE.xml' path='doc/member[@name="SPRULESTATE.SPRS_ACTIVE_WITH_AUTO_PAUSE"]/*'/>
    SPRS_ACTIVE_WITH_AUTO_PAUSE = 3,
    /// <include file='SPRULESTATE.xml' path='doc/member[@name="SPRULESTATE.SPRS_ACTIVE_USER_DELIMITED"]/*'/>
    SPRS_ACTIVE_USER_DELIMITED = 4,
}