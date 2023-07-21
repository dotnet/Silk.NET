// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='DIRECTMANIPULATION_HITTEST_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_HITTEST_TYPE"]/*' />
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_HITTEST_TYPE
{
    /// <include file='DIRECTMANIPULATION_HITTEST_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_HITTEST_TYPE.DIRECTMANIPULATION_HITTEST_TYPE_ASYNCHRONOUS"]/*' />
    DIRECTMANIPULATION_HITTEST_TYPE_ASYNCHRONOUS = 0,

    /// <include file='DIRECTMANIPULATION_HITTEST_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_HITTEST_TYPE.DIRECTMANIPULATION_HITTEST_TYPE_SYNCHRONOUS"]/*' />
    DIRECTMANIPULATION_HITTEST_TYPE_SYNCHRONOUS = 0x1,

    /// <include file='DIRECTMANIPULATION_HITTEST_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_HITTEST_TYPE.DIRECTMANIPULATION_HITTEST_TYPE_AUTO_SYNCHRONOUS"]/*' />
    DIRECTMANIPULATION_HITTEST_TYPE_AUTO_SYNCHRONOUS = 0x2,
}
