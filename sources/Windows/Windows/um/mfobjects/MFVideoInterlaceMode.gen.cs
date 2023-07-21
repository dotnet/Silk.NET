// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFVideoInterlaceMode.xml' path='doc/member[@name="MFVideoInterlaceMode"]/*' />
public enum MFVideoInterlaceMode
{
    /// <include file='MFVideoInterlaceMode.xml' path='doc/member[@name="MFVideoInterlaceMode.MFVideoInterlace_Unknown"]/*' />
    MFVideoInterlace_Unknown = 0,

    /// <include file='MFVideoInterlaceMode.xml' path='doc/member[@name="MFVideoInterlaceMode.MFVideoInterlace_Progressive"]/*' />
    MFVideoInterlace_Progressive = 2,

    /// <include file='MFVideoInterlaceMode.xml' path='doc/member[@name="MFVideoInterlaceMode.MFVideoInterlace_FieldInterleavedUpperFirst"]/*' />
    MFVideoInterlace_FieldInterleavedUpperFirst = 3,

    /// <include file='MFVideoInterlaceMode.xml' path='doc/member[@name="MFVideoInterlaceMode.MFVideoInterlace_FieldInterleavedLowerFirst"]/*' />
    MFVideoInterlace_FieldInterleavedLowerFirst = 4,

    /// <include file='MFVideoInterlaceMode.xml' path='doc/member[@name="MFVideoInterlaceMode.MFVideoInterlace_FieldSingleUpper"]/*' />
    MFVideoInterlace_FieldSingleUpper = 5,

    /// <include file='MFVideoInterlaceMode.xml' path='doc/member[@name="MFVideoInterlaceMode.MFVideoInterlace_FieldSingleLower"]/*' />
    MFVideoInterlace_FieldSingleLower = 6,

    /// <include file='MFVideoInterlaceMode.xml' path='doc/member[@name="MFVideoInterlaceMode.MFVideoInterlace_MixedInterlaceOrProgressive"]/*' />
    MFVideoInterlace_MixedInterlaceOrProgressive = 7,

    /// <include file='MFVideoInterlaceMode.xml' path='doc/member[@name="MFVideoInterlaceMode.MFVideoInterlace_Last"]/*' />
    MFVideoInterlace_Last = (MFVideoInterlace_MixedInterlaceOrProgressive + 1),

    /// <include file='MFVideoInterlaceMode.xml' path='doc/member[@name="MFVideoInterlaceMode.MFVideoInterlace_ForceDWORD"]/*' />
    MFVideoInterlace_ForceDWORD = 0x7fffffff,
}
