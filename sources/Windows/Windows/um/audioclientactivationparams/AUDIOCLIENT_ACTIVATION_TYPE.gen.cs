// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audioclientactivationparams.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='AUDIOCLIENT_ACTIVATION_TYPE.xml' path='doc/member[@name="AUDIOCLIENT_ACTIVATION_TYPE"]/*' />
[SupportedOSPlatform("windows10.0.19043.0")]
public enum AUDIOCLIENT_ACTIVATION_TYPE
{
    /// <include file='AUDIOCLIENT_ACTIVATION_TYPE.xml' path='doc/member[@name="AUDIOCLIENT_ACTIVATION_TYPE.AUDIOCLIENT_ACTIVATION_TYPE_DEFAULT"]/*' />
    AUDIOCLIENT_ACTIVATION_TYPE_DEFAULT = 0,

    /// <include file='AUDIOCLIENT_ACTIVATION_TYPE.xml' path='doc/member[@name="AUDIOCLIENT_ACTIVATION_TYPE.AUDIOCLIENT_ACTIVATION_TYPE_PROCESS_LOOPBACK"]/*' />
    AUDIOCLIENT_ACTIVATION_TYPE_PROCESS_LOOPBACK = 1,
}
