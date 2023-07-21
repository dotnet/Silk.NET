// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='eAVScenarioInfo.xml' path='doc/member[@name="eAVScenarioInfo"]/*' />
public enum eAVScenarioInfo
{
    /// <include file='eAVScenarioInfo.xml' path='doc/member[@name="eAVScenarioInfo.eAVScenarioInfo_Unknown"]/*' />
    eAVScenarioInfo_Unknown = 0,

    /// <include file='eAVScenarioInfo.xml' path='doc/member[@name="eAVScenarioInfo.eAVScenarioInfo_DisplayRemoting"]/*' />
    eAVScenarioInfo_DisplayRemoting = 1,

    /// <include file='eAVScenarioInfo.xml' path='doc/member[@name="eAVScenarioInfo.eAVScenarioInfo_VideoConference"]/*' />
    eAVScenarioInfo_VideoConference = 2,

    /// <include file='eAVScenarioInfo.xml' path='doc/member[@name="eAVScenarioInfo.eAVScenarioInfo_Archive"]/*' />
    eAVScenarioInfo_Archive = 3,

    /// <include file='eAVScenarioInfo.xml' path='doc/member[@name="eAVScenarioInfo.eAVScenarioInfo_LiveStreaming"]/*' />
    eAVScenarioInfo_LiveStreaming = 4,

    /// <include file='eAVScenarioInfo.xml' path='doc/member[@name="eAVScenarioInfo.eAVScenarioInfo_CameraRecord"]/*' />
    eAVScenarioInfo_CameraRecord = 5,

    /// <include file='eAVScenarioInfo.xml' path='doc/member[@name="eAVScenarioInfo.eAVScenarioInfo_DisplayRemotingWithFeatureMap"]/*' />
    eAVScenarioInfo_DisplayRemotingWithFeatureMap = 6,
}
