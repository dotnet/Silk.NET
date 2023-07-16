// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KERB_PROFILE_BUFFER_TYPE.xml' path='doc/member[@name="KERB_PROFILE_BUFFER_TYPE"]/*'/>
public enum KERB_PROFILE_BUFFER_TYPE
{
    /// <include file='KERB_PROFILE_BUFFER_TYPE.xml' path='doc/member[@name="KERB_PROFILE_BUFFER_TYPE.KerbInteractiveProfile"]/*'/>
    KerbInteractiveProfile = 2,
    /// <include file='KERB_PROFILE_BUFFER_TYPE.xml' path='doc/member[@name="KERB_PROFILE_BUFFER_TYPE.KerbSmartCardProfile"]/*'/>
    KerbSmartCardProfile = 4,
    /// <include file='KERB_PROFILE_BUFFER_TYPE.xml' path='doc/member[@name="KERB_PROFILE_BUFFER_TYPE.KerbTicketProfile"]/*'/>
    KerbTicketProfile = 6,
}