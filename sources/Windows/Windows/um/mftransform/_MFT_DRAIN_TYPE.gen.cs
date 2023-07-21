// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='_MFT_DRAIN_TYPE.xml' path='doc/member[@name="_MFT_DRAIN_TYPE"]/*' />
public enum _MFT_DRAIN_TYPE
{
    /// <include file='_MFT_DRAIN_TYPE.xml' path='doc/member[@name="_MFT_DRAIN_TYPE.MFT_DRAIN_PRODUCE_TAILS"]/*' />
    MFT_DRAIN_PRODUCE_TAILS = 0,

    /// <include file='_MFT_DRAIN_TYPE.xml' path='doc/member[@name="_MFT_DRAIN_TYPE.MFT_DRAIN_NO_TAILS"]/*' />
    MFT_DRAIN_NO_TAILS = 0x1,
}
