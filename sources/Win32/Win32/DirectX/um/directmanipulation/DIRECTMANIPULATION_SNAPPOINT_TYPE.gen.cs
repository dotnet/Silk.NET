// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_SNAPPOINT_TYPE
{
    DIRECTMANIPULATION_SNAPPOINT_MANDATORY = 0,
    DIRECTMANIPULATION_SNAPPOINT_OPTIONAL = 1,
    DIRECTMANIPULATION_SNAPPOINT_MANDATORY_SINGLE = 2,
    DIRECTMANIPULATION_SNAPPOINT_OPTIONAL_SINGLE = 3,
}
