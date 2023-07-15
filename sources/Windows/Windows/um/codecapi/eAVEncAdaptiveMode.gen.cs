// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='eAVEncAdaptiveMode.xml' path='doc/member[@name="eAVEncAdaptiveMode"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum eAVEncAdaptiveMode
{
    /// <include file='eAVEncAdaptiveMode.xml' path='doc/member[@name="eAVEncAdaptiveMode.eAVEncAdaptiveMode_None"]/*'/>
    eAVEncAdaptiveMode_None = 0,
    /// <include file='eAVEncAdaptiveMode.xml' path='doc/member[@name="eAVEncAdaptiveMode.eAVEncAdaptiveMode_Resolution"]/*'/>
    eAVEncAdaptiveMode_Resolution = 1,
    /// <include file='eAVEncAdaptiveMode.xml' path='doc/member[@name="eAVEncAdaptiveMode.eAVEncAdaptiveMode_FrameRate"]/*'/>
    eAVEncAdaptiveMode_FrameRate = 2,
}