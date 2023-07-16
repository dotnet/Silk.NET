// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='RENDEZVOUS_SESSION_FLAGS.xml' path='doc/member[@name="RENDEZVOUS_SESSION_FLAGS"]/*'/>
[Flags]
public enum RENDEZVOUS_SESSION_FLAGS
{
    /// <include file='RENDEZVOUS_SESSION_FLAGS.xml' path='doc/member[@name="RENDEZVOUS_SESSION_FLAGS.RSF_NONE"]/*'/>
    RSF_NONE = 0,
    /// <include file='RENDEZVOUS_SESSION_FLAGS.xml' path='doc/member[@name="RENDEZVOUS_SESSION_FLAGS.RSF_INVITER"]/*'/>
    RSF_INVITER = 0x1,
    /// <include file='RENDEZVOUS_SESSION_FLAGS.xml' path='doc/member[@name="RENDEZVOUS_SESSION_FLAGS.RSF_INVITEE"]/*'/>
    RSF_INVITEE = 0x2,
    /// <include file='RENDEZVOUS_SESSION_FLAGS.xml' path='doc/member[@name="RENDEZVOUS_SESSION_FLAGS.RSF_ORIGINAL_INVITER"]/*'/>
    RSF_ORIGINAL_INVITER = 0x4,
    /// <include file='RENDEZVOUS_SESSION_FLAGS.xml' path='doc/member[@name="RENDEZVOUS_SESSION_FLAGS.RSF_REMOTE_LEGACYSESSION"]/*'/>
    RSF_REMOTE_LEGACYSESSION = 0x8,
    /// <include file='RENDEZVOUS_SESSION_FLAGS.xml' path='doc/member[@name="RENDEZVOUS_SESSION_FLAGS.RSF_REMOTE_WIN7SESSION"]/*'/>
    RSF_REMOTE_WIN7SESSION = 0x10,
}