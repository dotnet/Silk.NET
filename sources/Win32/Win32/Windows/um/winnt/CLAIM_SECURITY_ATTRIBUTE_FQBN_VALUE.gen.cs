// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public unsafe partial struct CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE
{
    [NativeTypeName("DWORD64")]
    public ulong Version;

    [NativeTypeName("PWSTR")]
    public ushort* Name;
}
