// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FDE_OVERWRITE_RESPONSE.xml' path='doc/member[@name="FDE_OVERWRITE_RESPONSE"]/*' />
public enum FDE_OVERWRITE_RESPONSE
{
    /// <include file='FDE_OVERWRITE_RESPONSE.xml' path='doc/member[@name="FDE_OVERWRITE_RESPONSE.FDEOR_DEFAULT"]/*' />
    FDEOR_DEFAULT = 0,

    /// <include file='FDE_OVERWRITE_RESPONSE.xml' path='doc/member[@name="FDE_OVERWRITE_RESPONSE.FDEOR_ACCEPT"]/*' />
    FDEOR_ACCEPT = 1,

    /// <include file='FDE_OVERWRITE_RESPONSE.xml' path='doc/member[@name="FDE_OVERWRITE_RESPONSE.FDEOR_REFUSE"]/*' />
    FDEOR_REFUSE = 2,
}
