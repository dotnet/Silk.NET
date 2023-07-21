// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NL_NEIGHBOR_STATE.xml' path='doc/member[@name="NL_NEIGHBOR_STATE"]/*' />
public enum NL_NEIGHBOR_STATE
{
    /// <include file='NL_NEIGHBOR_STATE.xml' path='doc/member[@name="NL_NEIGHBOR_STATE.NlnsUnreachable"]/*' />
    NlnsUnreachable,

    /// <include file='NL_NEIGHBOR_STATE.xml' path='doc/member[@name="NL_NEIGHBOR_STATE.NlnsIncomplete"]/*' />
    NlnsIncomplete,

    /// <include file='NL_NEIGHBOR_STATE.xml' path='doc/member[@name="NL_NEIGHBOR_STATE.NlnsProbe"]/*' />
    NlnsProbe,

    /// <include file='NL_NEIGHBOR_STATE.xml' path='doc/member[@name="NL_NEIGHBOR_STATE.NlnsDelay"]/*' />
    NlnsDelay,

    /// <include file='NL_NEIGHBOR_STATE.xml' path='doc/member[@name="NL_NEIGHBOR_STATE.NlnsStale"]/*' />
    NlnsStale,

    /// <include file='NL_NEIGHBOR_STATE.xml' path='doc/member[@name="NL_NEIGHBOR_STATE.NlnsReachable"]/*' />
    NlnsReachable,

    /// <include file='NL_NEIGHBOR_STATE.xml' path='doc/member[@name="NL_NEIGHBOR_STATE.NlnsPermanent"]/*' />
    NlnsPermanent,

    /// <include file='NL_NEIGHBOR_STATE.xml' path='doc/member[@name="NL_NEIGHBOR_STATE.NlnsMaximum"]/*' />
    NlnsMaximum,
}
