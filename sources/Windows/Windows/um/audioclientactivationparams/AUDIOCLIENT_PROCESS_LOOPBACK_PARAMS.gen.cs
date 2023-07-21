// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audioclientactivationparams.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS.xml' path='doc/member[@name="AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS"]/*' />
[SupportedOSPlatform("windows10.0.19043.0")]
public partial struct AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS
{
    /// <include file='AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS.xml' path='doc/member[@name="AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS.TargetProcessId"]/*' />
    [NativeTypeName("DWORD")]
    public uint TargetProcessId;

    /// <include file='AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS.xml' path='doc/member[@name="AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS.ProcessLoopbackMode"]/*' />
    public PROCESS_LOOPBACK_MODE ProcessLoopbackMode;
}
