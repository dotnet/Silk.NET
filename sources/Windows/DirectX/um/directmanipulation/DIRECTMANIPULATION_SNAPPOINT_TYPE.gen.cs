// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='DIRECTMANIPULATION_SNAPPOINT_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_SNAPPOINT_TYPE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_SNAPPOINT_TYPE
{
    /// <include file='DIRECTMANIPULATION_SNAPPOINT_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_SNAPPOINT_TYPE.DIRECTMANIPULATION_SNAPPOINT_MANDATORY"]/*'/>
    DIRECTMANIPULATION_SNAPPOINT_MANDATORY = 0,
    /// <include file='DIRECTMANIPULATION_SNAPPOINT_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_SNAPPOINT_TYPE.DIRECTMANIPULATION_SNAPPOINT_OPTIONAL"]/*'/>
    DIRECTMANIPULATION_SNAPPOINT_OPTIONAL = 1,
    /// <include file='DIRECTMANIPULATION_SNAPPOINT_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_SNAPPOINT_TYPE.DIRECTMANIPULATION_SNAPPOINT_MANDATORY_SINGLE"]/*'/>
    DIRECTMANIPULATION_SNAPPOINT_MANDATORY_SINGLE = 2,
    /// <include file='DIRECTMANIPULATION_SNAPPOINT_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_SNAPPOINT_TYPE.DIRECTMANIPULATION_SNAPPOINT_OPTIONAL_SINGLE"]/*'/>
    DIRECTMANIPULATION_SNAPPOINT_OPTIONAL_SINGLE = 3,
}