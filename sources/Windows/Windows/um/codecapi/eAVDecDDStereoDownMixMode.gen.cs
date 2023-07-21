// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='eAVDecDDStereoDownMixMode.xml' path='doc/member[@name="eAVDecDDStereoDownMixMode"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum eAVDecDDStereoDownMixMode
{
    /// <include file='eAVDecDDStereoDownMixMode.xml' path='doc/member[@name="eAVDecDDStereoDownMixMode.eAVDecDDStereoDownMixMode_Auto"]/*' />
    eAVDecDDStereoDownMixMode_Auto = 0,

    /// <include file='eAVDecDDStereoDownMixMode.xml' path='doc/member[@name="eAVDecDDStereoDownMixMode.eAVDecDDStereoDownMixMode_LtRt"]/*' />
    eAVDecDDStereoDownMixMode_LtRt = 1,

    /// <include file='eAVDecDDStereoDownMixMode.xml' path='doc/member[@name="eAVDecDDStereoDownMixMode.eAVDecDDStereoDownMixMode_LoRo"]/*' />
    eAVDecDDStereoDownMixMode_LoRo = 2,
}
