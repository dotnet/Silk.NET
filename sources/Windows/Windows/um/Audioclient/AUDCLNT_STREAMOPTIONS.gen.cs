// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='AUDCLNT_STREAMOPTIONS.xml' path='doc/member[@name="AUDCLNT_STREAMOPTIONS"]/*' />
[Flags]
[SupportedOSPlatform("windows6.3")]
public enum AUDCLNT_STREAMOPTIONS
{
    /// <include file='AUDCLNT_STREAMOPTIONS.xml' path='doc/member[@name="AUDCLNT_STREAMOPTIONS.AUDCLNT_STREAMOPTIONS_NONE"]/*' />
    AUDCLNT_STREAMOPTIONS_NONE = 0,

    /// <include file='AUDCLNT_STREAMOPTIONS.xml' path='doc/member[@name="AUDCLNT_STREAMOPTIONS.AUDCLNT_STREAMOPTIONS_RAW"]/*' />
    AUDCLNT_STREAMOPTIONS_RAW = 0x1,

    /// <include file='AUDCLNT_STREAMOPTIONS.xml' path='doc/member[@name="AUDCLNT_STREAMOPTIONS.AUDCLNT_STREAMOPTIONS_MATCH_FORMAT"]/*' />
    AUDCLNT_STREAMOPTIONS_MATCH_FORMAT = 0x2,

    /// <include file='AUDCLNT_STREAMOPTIONS.xml' path='doc/member[@name="AUDCLNT_STREAMOPTIONS.AUDCLNT_STREAMOPTIONS_AMBISONICS"]/*' />
    AUDCLNT_STREAMOPTIONS_AMBISONICS = 0x4,
}
