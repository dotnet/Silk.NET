// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPSTREAMFORMATTYPE.xml' path='doc/member[@name="SPSTREAMFORMATTYPE"]/*' />
public enum SPSTREAMFORMATTYPE
{
    /// <include file='SPSTREAMFORMATTYPE.xml' path='doc/member[@name="SPSTREAMFORMATTYPE.SPWF_INPUT"]/*' />
    SPWF_INPUT = 0,

    /// <include file='SPSTREAMFORMATTYPE.xml' path='doc/member[@name="SPSTREAMFORMATTYPE.SPWF_SRENGINE"]/*' />
    SPWF_SRENGINE = (SPWF_INPUT + 1),
}
