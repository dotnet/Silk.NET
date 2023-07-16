// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MF_TIMED_TEXT_UNIT_TYPE.xml' path='doc/member[@name="MF_TIMED_TEXT_UNIT_TYPE"]/*'/>
[SupportedOSPlatform("windows10.0")]
public enum MF_TIMED_TEXT_UNIT_TYPE
{
    /// <include file='MF_TIMED_TEXT_UNIT_TYPE.xml' path='doc/member[@name="MF_TIMED_TEXT_UNIT_TYPE.MF_TIMED_TEXT_UNIT_TYPE_PIXELS"]/*'/>
    MF_TIMED_TEXT_UNIT_TYPE_PIXELS = 0,
    /// <include file='MF_TIMED_TEXT_UNIT_TYPE.xml' path='doc/member[@name="MF_TIMED_TEXT_UNIT_TYPE.MF_TIMED_TEXT_UNIT_TYPE_PERCENTAGE"]/*'/>
    MF_TIMED_TEXT_UNIT_TYPE_PERCENTAGE = 1,
}