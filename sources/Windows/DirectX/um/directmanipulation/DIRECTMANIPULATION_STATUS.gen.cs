// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='DIRECTMANIPULATION_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_STATUS"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_STATUS
{
    /// <include file='DIRECTMANIPULATION_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_STATUS.DIRECTMANIPULATION_BUILDING"]/*' />
    DIRECTMANIPULATION_BUILDING = 0,

    /// <include file='DIRECTMANIPULATION_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_STATUS.DIRECTMANIPULATION_ENABLED"]/*' />
    DIRECTMANIPULATION_ENABLED = 1,

    /// <include file='DIRECTMANIPULATION_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_STATUS.DIRECTMANIPULATION_DISABLED"]/*' />
    DIRECTMANIPULATION_DISABLED = 2,

    /// <include file='DIRECTMANIPULATION_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_STATUS.DIRECTMANIPULATION_RUNNING"]/*' />
    DIRECTMANIPULATION_RUNNING = 3,

    /// <include file='DIRECTMANIPULATION_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_STATUS.DIRECTMANIPULATION_INERTIA"]/*' />
    DIRECTMANIPULATION_INERTIA = 4,

    /// <include file='DIRECTMANIPULATION_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_STATUS.DIRECTMANIPULATION_READY"]/*' />
    DIRECTMANIPULATION_READY = 5,

    /// <include file='DIRECTMANIPULATION_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_STATUS.DIRECTMANIPULATION_SUSPENDED"]/*' />
    DIRECTMANIPULATION_SUSPENDED = 6,
}
