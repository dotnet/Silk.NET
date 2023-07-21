// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='_MFP_CREATION_OPTIONS.xml' path='doc/member[@name="_MFP_CREATION_OPTIONS"]/*' />
public enum _MFP_CREATION_OPTIONS
{
    /// <include file='_MFP_CREATION_OPTIONS.xml' path='doc/member[@name="_MFP_CREATION_OPTIONS.MFP_OPTION_NONE"]/*' />
    MFP_OPTION_NONE = 0,

    /// <include file='_MFP_CREATION_OPTIONS.xml' path='doc/member[@name="_MFP_CREATION_OPTIONS.MFP_OPTION_FREE_THREADED_CALLBACK"]/*' />
    MFP_OPTION_FREE_THREADED_CALLBACK = 0x1,

    /// <include file='_MFP_CREATION_OPTIONS.xml' path='doc/member[@name="_MFP_CREATION_OPTIONS.MFP_OPTION_NO_MMCSS"]/*' />
    MFP_OPTION_NO_MMCSS = 0x2,

    /// <include file='_MFP_CREATION_OPTIONS.xml' path='doc/member[@name="_MFP_CREATION_OPTIONS.MFP_OPTION_NO_REMOTE_DESKTOP_OPTIMIZATION"]/*' />
    MFP_OPTION_NO_REMOTE_DESKTOP_OPTIMIZATION = 0x4,
}
