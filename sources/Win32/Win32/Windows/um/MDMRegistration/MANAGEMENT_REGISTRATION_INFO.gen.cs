// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct MANAGEMENT_REGISTRATION_INFO
{
    public BOOL fDeviceRegisteredWithManagement;

    [NativeTypeName("DWORD")]
    public uint dwDeviceRegistionKind;

    [NativeTypeName("LPWSTR")]
    public ushort* pszUPN;

    [NativeTypeName("LPWSTR")]
    public ushort* pszMDMServiceUri;
}
