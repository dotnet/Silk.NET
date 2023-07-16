// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='INERTIA_PARAMETER.xml' path='doc/member[@name="INERTIA_PARAMETER"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum INERTIA_PARAMETER
{
    /// <include file='INERTIA_PARAMETER.xml' path='doc/member[@name="INERTIA_PARAMETER.INERTIA_PARAMETER_TRANSLATION_DECELERATION"]/*'/>
    INERTIA_PARAMETER_TRANSLATION_DECELERATION = 0x00000001,
    /// <include file='INERTIA_PARAMETER.xml' path='doc/member[@name="INERTIA_PARAMETER.INERTIA_PARAMETER_TRANSLATION_DISPLACEMENT"]/*'/>
    INERTIA_PARAMETER_TRANSLATION_DISPLACEMENT = 0x00000002,
    /// <include file='INERTIA_PARAMETER.xml' path='doc/member[@name="INERTIA_PARAMETER.INERTIA_PARAMETER_ROTATION_DECELERATION"]/*'/>
    INERTIA_PARAMETER_ROTATION_DECELERATION = 0x00000003,
    /// <include file='INERTIA_PARAMETER.xml' path='doc/member[@name="INERTIA_PARAMETER.INERTIA_PARAMETER_ROTATION_ANGLE"]/*'/>
    INERTIA_PARAMETER_ROTATION_ANGLE = 0x00000004,
    /// <include file='INERTIA_PARAMETER.xml' path='doc/member[@name="INERTIA_PARAMETER.INERTIA_PARAMETER_EXPANSION_DECELERATION"]/*'/>
    INERTIA_PARAMETER_EXPANSION_DECELERATION = 0x00000005,
    /// <include file='INERTIA_PARAMETER.xml' path='doc/member[@name="INERTIA_PARAMETER.INERTIA_PARAMETER_EXPANSION_EXPANSION"]/*'/>
    INERTIA_PARAMETER_EXPANSION_EXPANSION = 0x00000006,
    /// <include file='INERTIA_PARAMETER.xml' path='doc/member[@name="INERTIA_PARAMETER.INERTIA_PARAMETER_MAX"]/*'/>
    INERTIA_PARAMETER_MAX = unchecked((int)(0xffffffff)),
}