// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='_AUDCLNT_BUFFERFLAGS.xml' path='doc/member[@name="_AUDCLNT_BUFFERFLAGS"]/*' />
[Flags]
public enum _AUDCLNT_BUFFERFLAGS
{
    /// <include file='_AUDCLNT_BUFFERFLAGS.xml' path='doc/member[@name="_AUDCLNT_BUFFERFLAGS.AUDCLNT_BUFFERFLAGS_DATA_DISCONTINUITY"]/*' />
    AUDCLNT_BUFFERFLAGS_DATA_DISCONTINUITY = 0x1,

    /// <include file='_AUDCLNT_BUFFERFLAGS.xml' path='doc/member[@name="_AUDCLNT_BUFFERFLAGS.AUDCLNT_BUFFERFLAGS_SILENT"]/*' />
    AUDCLNT_BUFFERFLAGS_SILENT = 0x2,

    /// <include file='_AUDCLNT_BUFFERFLAGS.xml' path='doc/member[@name="_AUDCLNT_BUFFERFLAGS.AUDCLNT_BUFFERFLAGS_TIMESTAMP_ERROR"]/*' />
    AUDCLNT_BUFFERFLAGS_TIMESTAMP_ERROR = 0x4,
}
