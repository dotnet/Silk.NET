// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='DIRECTMANIPULATION_INPUT_MODE.xml' path='doc/member[@name="DIRECTMANIPULATION_INPUT_MODE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_INPUT_MODE
{
    /// <include file='DIRECTMANIPULATION_INPUT_MODE.xml' path='doc/member[@name="DIRECTMANIPULATION_INPUT_MODE.DIRECTMANIPULATION_INPUT_MODE_AUTOMATIC"]/*' />
    DIRECTMANIPULATION_INPUT_MODE_AUTOMATIC = 0,

    /// <include file='DIRECTMANIPULATION_INPUT_MODE.xml' path='doc/member[@name="DIRECTMANIPULATION_INPUT_MODE.DIRECTMANIPULATION_INPUT_MODE_MANUAL"]/*' />
    DIRECTMANIPULATION_INPUT_MODE_MANUAL = 1,
}
