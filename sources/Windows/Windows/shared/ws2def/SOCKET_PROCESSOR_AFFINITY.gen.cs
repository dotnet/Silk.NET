// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='SOCKET_PROCESSOR_AFFINITY.xml' path='doc/member[@name="SOCKET_PROCESSOR_AFFINITY"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct SOCKET_PROCESSOR_AFFINITY
{
    /// <include file='SOCKET_PROCESSOR_AFFINITY.xml' path='doc/member[@name="SOCKET_PROCESSOR_AFFINITY.Processor"]/*' />
    public PROCESSOR_NUMBER Processor;

    /// <include file='SOCKET_PROCESSOR_AFFINITY.xml' path='doc/member[@name="SOCKET_PROCESSOR_AFFINITY.NumaNodeId"]/*' />
    public ushort NumaNodeId;

    /// <include file='SOCKET_PROCESSOR_AFFINITY.xml' path='doc/member[@name="SOCKET_PROCESSOR_AFFINITY.Reserved"]/*' />
    public ushort Reserved;
}
