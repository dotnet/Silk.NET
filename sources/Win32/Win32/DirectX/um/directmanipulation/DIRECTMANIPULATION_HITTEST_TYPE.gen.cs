// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_HITTEST_TYPE
{
    DIRECTMANIPULATION_HITTEST_TYPE_ASYNCHRONOUS = 0,
    DIRECTMANIPULATION_HITTEST_TYPE_SYNCHRONOUS = 0x1,
    DIRECTMANIPULATION_HITTEST_TYPE_AUTO_SYNCHRONOUS = 0x2,
}
