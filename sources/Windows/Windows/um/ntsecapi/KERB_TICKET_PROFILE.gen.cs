// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KERB_TICKET_PROFILE.xml' path='doc/member[@name="KERB_TICKET_PROFILE"]/*'/>
public partial struct KERB_TICKET_PROFILE
{
    /// <include file='KERB_TICKET_PROFILE.xml' path='doc/member[@name="KERB_TICKET_PROFILE.Profile"]/*'/>
    public KERB_INTERACTIVE_PROFILE Profile;
    /// <include file='KERB_TICKET_PROFILE.xml' path='doc/member[@name="KERB_TICKET_PROFILE.SessionKey"]/*'/>
    public KERB_CRYPTO_KEY SessionKey;
}