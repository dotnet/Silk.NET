// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='SpatialAudioClientActivationParams.xml' path='doc/member[@name="SpatialAudioClientActivationParams"]/*' />
public partial struct SpatialAudioClientActivationParams
{
    /// <include file='SpatialAudioClientActivationParams.xml' path='doc/member[@name="SpatialAudioClientActivationParams.tracingContextId"]/*' />
    public Guid tracingContextId;

    /// <include file='SpatialAudioClientActivationParams.xml' path='doc/member[@name="SpatialAudioClientActivationParams.appId"]/*' />
    public Guid appId;

    /// <include file='SpatialAudioClientActivationParams.xml' path='doc/member[@name="SpatialAudioClientActivationParams.majorVersion"]/*' />
    public int majorVersion;

    /// <include file='SpatialAudioClientActivationParams.xml' path='doc/member[@name="SpatialAudioClientActivationParams.minorVersion1"]/*' />
    public int minorVersion1;

    /// <include file='SpatialAudioClientActivationParams.xml' path='doc/member[@name="SpatialAudioClientActivationParams.minorVersion2"]/*' />
    public int minorVersion2;

    /// <include file='SpatialAudioClientActivationParams.xml' path='doc/member[@name="SpatialAudioClientActivationParams.minorVersion3"]/*' />
    public int minorVersion3;
}
