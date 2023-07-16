// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.3")]
public enum SYNC_ENGINE_STATE_FLAGS
{
    /// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS.SESF_NONE"]/*'/>
    SESF_NONE = 0,
    /// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS.SESF_SERVICE_QUOTA_NEARING_LIMIT"]/*'/>
    SESF_SERVICE_QUOTA_NEARING_LIMIT = 0x1,
    /// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS.SESF_SERVICE_QUOTA_EXCEEDED_LIMIT"]/*'/>
    SESF_SERVICE_QUOTA_EXCEEDED_LIMIT = 0x2,
    /// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS.SESF_AUTHENTICATION_ERROR"]/*'/>
    SESF_AUTHENTICATION_ERROR = 0x4,
    /// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS.SESF_PAUSED_DUE_TO_METERED_NETWORK"]/*'/>
    SESF_PAUSED_DUE_TO_METERED_NETWORK = 0x8,
    /// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS.SESF_PAUSED_DUE_TO_DISK_SPACE_FULL"]/*'/>
    SESF_PAUSED_DUE_TO_DISK_SPACE_FULL = 0x10,
    /// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS.SESF_PAUSED_DUE_TO_CLIENT_POLICY"]/*'/>
    SESF_PAUSED_DUE_TO_CLIENT_POLICY = 0x20,
    /// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS.SESF_PAUSED_DUE_TO_SERVICE_POLICY"]/*'/>
    SESF_PAUSED_DUE_TO_SERVICE_POLICY = 0x40,
    /// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS.SESF_SERVICE_UNAVAILABLE"]/*'/>
    SESF_SERVICE_UNAVAILABLE = 0x80,
    /// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS.SESF_PAUSED_DUE_TO_USER_REQUEST"]/*'/>
    SESF_PAUSED_DUE_TO_USER_REQUEST = 0x100,
    /// <include file='SYNC_ENGINE_STATE_FLAGS.xml' path='doc/member[@name="SYNC_ENGINE_STATE_FLAGS.SESF_ALL_FLAGS"]/*'/>
    SESF_ALL_FLAGS = (((((((((SESF_NONE | SESF_SERVICE_QUOTA_NEARING_LIMIT) | SESF_SERVICE_QUOTA_EXCEEDED_LIMIT) | SESF_AUTHENTICATION_ERROR) | SESF_PAUSED_DUE_TO_METERED_NETWORK) | SESF_PAUSED_DUE_TO_DISK_SPACE_FULL) | SESF_PAUSED_DUE_TO_CLIENT_POLICY) | SESF_PAUSED_DUE_TO_SERVICE_POLICY) | SESF_SERVICE_UNAVAILABLE) | SESF_PAUSED_DUE_TO_USER_REQUEST),
}