// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='SENSORPROFILEID.xml' path='doc/member[@name="SENSORPROFILEID"]/*' />
[SupportedOSPlatform("windows10.0.16299.0")]
public partial struct SENSORPROFILEID
{
    /// <include file='SENSORPROFILEID.xml' path='doc/member[@name="SENSORPROFILEID.Type"]/*' />
    public Guid Type;

    /// <include file='SENSORPROFILEID.xml' path='doc/member[@name="SENSORPROFILEID.Index"]/*' />
    [NativeTypeName("UINT32")]
    public uint Index;

    /// <include file='SENSORPROFILEID.xml' path='doc/member[@name="SENSORPROFILEID.Unused"]/*' />
    [NativeTypeName("UINT32")]
    public uint Unused;
}
