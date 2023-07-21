// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NL_BANDWIDTH_FLAG.xml' path='doc/member[@name="NL_BANDWIDTH_FLAG"]/*' />
public enum NL_BANDWIDTH_FLAG
{
    /// <include file='NL_BANDWIDTH_FLAG.xml' path='doc/member[@name="NL_BANDWIDTH_FLAG.NlbwDisabled"]/*' />
    NlbwDisabled = 0,

    /// <include file='NL_BANDWIDTH_FLAG.xml' path='doc/member[@name="NL_BANDWIDTH_FLAG.NlbwEnabled"]/*' />
    NlbwEnabled,

    /// <include file='NL_BANDWIDTH_FLAG.xml' path='doc/member[@name="NL_BANDWIDTH_FLAG.NlbwUnchanged"]/*' />
    NlbwUnchanged = -1,
}
