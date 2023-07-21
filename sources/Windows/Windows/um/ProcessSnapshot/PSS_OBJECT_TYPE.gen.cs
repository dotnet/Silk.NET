// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PSS_OBJECT_TYPE.xml' path='doc/member[@name="PSS_OBJECT_TYPE"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum PSS_OBJECT_TYPE
{
    /// <include file='PSS_OBJECT_TYPE.xml' path='doc/member[@name="PSS_OBJECT_TYPE.PSS_OBJECT_TYPE_UNKNOWN"]/*' />
    PSS_OBJECT_TYPE_UNKNOWN = 0,

    /// <include file='PSS_OBJECT_TYPE.xml' path='doc/member[@name="PSS_OBJECT_TYPE.PSS_OBJECT_TYPE_PROCESS"]/*' />
    PSS_OBJECT_TYPE_PROCESS = 1,

    /// <include file='PSS_OBJECT_TYPE.xml' path='doc/member[@name="PSS_OBJECT_TYPE.PSS_OBJECT_TYPE_THREAD"]/*' />
    PSS_OBJECT_TYPE_THREAD = 2,

    /// <include file='PSS_OBJECT_TYPE.xml' path='doc/member[@name="PSS_OBJECT_TYPE.PSS_OBJECT_TYPE_MUTANT"]/*' />
    PSS_OBJECT_TYPE_MUTANT = 3,

    /// <include file='PSS_OBJECT_TYPE.xml' path='doc/member[@name="PSS_OBJECT_TYPE.PSS_OBJECT_TYPE_EVENT"]/*' />
    PSS_OBJECT_TYPE_EVENT = 4,

    /// <include file='PSS_OBJECT_TYPE.xml' path='doc/member[@name="PSS_OBJECT_TYPE.PSS_OBJECT_TYPE_SECTION"]/*' />
    PSS_OBJECT_TYPE_SECTION = 5,

    /// <include file='PSS_OBJECT_TYPE.xml' path='doc/member[@name="PSS_OBJECT_TYPE.PSS_OBJECT_TYPE_SEMAPHORE"]/*' />
    PSS_OBJECT_TYPE_SEMAPHORE = 6,
}
