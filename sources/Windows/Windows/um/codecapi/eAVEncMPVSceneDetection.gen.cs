// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='eAVEncMPVSceneDetection.xml' path='doc/member[@name="eAVEncMPVSceneDetection"]/*' />
public enum eAVEncMPVSceneDetection
{
    /// <include file='eAVEncMPVSceneDetection.xml' path='doc/member[@name="eAVEncMPVSceneDetection.eAVEncMPVSceneDetection_None"]/*' />
    eAVEncMPVSceneDetection_None = 0,

    /// <include file='eAVEncMPVSceneDetection.xml' path='doc/member[@name="eAVEncMPVSceneDetection.eAVEncMPVSceneDetection_InsertIPicture"]/*' />
    eAVEncMPVSceneDetection_InsertIPicture = 1,

    /// <include file='eAVEncMPVSceneDetection.xml' path='doc/member[@name="eAVEncMPVSceneDetection.eAVEncMPVSceneDetection_StartNewGOP"]/*' />
    eAVEncMPVSceneDetection_StartNewGOP = 2,

    /// <include file='eAVEncMPVSceneDetection.xml' path='doc/member[@name="eAVEncMPVSceneDetection.eAVEncMPVSceneDetection_StartNewLocatableGOP"]/*' />
    eAVEncMPVSceneDetection_StartNewLocatableGOP = 3,
}
