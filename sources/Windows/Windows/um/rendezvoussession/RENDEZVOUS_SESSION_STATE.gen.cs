// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RENDEZVOUS_SESSION_STATE.xml' path='doc/member[@name="RENDEZVOUS_SESSION_STATE"]/*'/>
public enum RENDEZVOUS_SESSION_STATE
{
    /// <include file='RENDEZVOUS_SESSION_STATE.xml' path='doc/member[@name="RENDEZVOUS_SESSION_STATE.RSS_UNKNOWN"]/*'/>
    RSS_UNKNOWN = 0,
    /// <include file='RENDEZVOUS_SESSION_STATE.xml' path='doc/member[@name="RENDEZVOUS_SESSION_STATE.RSS_READY"]/*'/>
    RSS_READY = (RSS_UNKNOWN + 1),
    /// <include file='RENDEZVOUS_SESSION_STATE.xml' path='doc/member[@name="RENDEZVOUS_SESSION_STATE.RSS_INVITATION"]/*'/>
    RSS_INVITATION = (RSS_READY + 1),
    /// <include file='RENDEZVOUS_SESSION_STATE.xml' path='doc/member[@name="RENDEZVOUS_SESSION_STATE.RSS_ACCEPTED"]/*'/>
    RSS_ACCEPTED = (RSS_INVITATION + 1),
    /// <include file='RENDEZVOUS_SESSION_STATE.xml' path='doc/member[@name="RENDEZVOUS_SESSION_STATE.RSS_CONNECTED"]/*'/>
    RSS_CONNECTED = (RSS_ACCEPTED + 1),
    /// <include file='RENDEZVOUS_SESSION_STATE.xml' path='doc/member[@name="RENDEZVOUS_SESSION_STATE.RSS_CANCELLED"]/*'/>
    RSS_CANCELLED = (RSS_CONNECTED + 1),
    /// <include file='RENDEZVOUS_SESSION_STATE.xml' path='doc/member[@name="RENDEZVOUS_SESSION_STATE.RSS_DECLINED"]/*'/>
    RSS_DECLINED = (RSS_CANCELLED + 1),
    /// <include file='RENDEZVOUS_SESSION_STATE.xml' path='doc/member[@name="RENDEZVOUS_SESSION_STATE.RSS_TERMINATED"]/*'/>
    RSS_TERMINATED = (RSS_DECLINED + 1),
}