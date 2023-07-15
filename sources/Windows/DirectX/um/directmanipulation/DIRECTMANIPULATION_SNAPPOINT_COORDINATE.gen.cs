// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='DIRECTMANIPULATION_SNAPPOINT_COORDINATE.xml' path='doc/member[@name="DIRECTMANIPULATION_SNAPPOINT_COORDINATE"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_SNAPPOINT_COORDINATE
{
    /// <include file='DIRECTMANIPULATION_SNAPPOINT_COORDINATE.xml' path='doc/member[@name="DIRECTMANIPULATION_SNAPPOINT_COORDINATE.DIRECTMANIPULATION_COORDINATE_BOUNDARY"]/*'/>
    DIRECTMANIPULATION_COORDINATE_BOUNDARY = 0,
    /// <include file='DIRECTMANIPULATION_SNAPPOINT_COORDINATE.xml' path='doc/member[@name="DIRECTMANIPULATION_SNAPPOINT_COORDINATE.DIRECTMANIPULATION_COORDINATE_ORIGIN"]/*'/>
    DIRECTMANIPULATION_COORDINATE_ORIGIN = 0x1,
    /// <include file='DIRECTMANIPULATION_SNAPPOINT_COORDINATE.xml' path='doc/member[@name="DIRECTMANIPULATION_SNAPPOINT_COORDINATE.DIRECTMANIPULATION_COORDINATE_MIRRORED"]/*'/>
    DIRECTMANIPULATION_COORDINATE_MIRRORED = 0x10,
}