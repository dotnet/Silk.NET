// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CONFIG_CI_PROV_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwPolicies;
    public CRYPT_DATA_BLOB* pPolicies;
    public CONFIG_CI_PROV_INFO_RESULT result;

    [NativeTypeName("DWORD")]
    public uint dwScenario;
    public CONFIG_CI_PROV_INFO_RESULT2* result2;
}
