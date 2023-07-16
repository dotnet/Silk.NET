// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MANAGEMENT_REGISTRATION_INFO.xml' path='doc/member[@name="MANAGEMENT_REGISTRATION_INFO"]/*'/>
public unsafe partial struct MANAGEMENT_REGISTRATION_INFO
{
    /// <include file='MANAGEMENT_REGISTRATION_INFO.xml' path='doc/member[@name="MANAGEMENT_REGISTRATION_INFO.fDeviceRegisteredWithManagement"]/*'/>
    public BOOL fDeviceRegisteredWithManagement;
    /// <include file='MANAGEMENT_REGISTRATION_INFO.xml' path='doc/member[@name="MANAGEMENT_REGISTRATION_INFO.dwDeviceRegistionKind"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDeviceRegistionKind;
    /// <include file='MANAGEMENT_REGISTRATION_INFO.xml' path='doc/member[@name="MANAGEMENT_REGISTRATION_INFO.pszUPN"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszUPN;
    /// <include file='MANAGEMENT_REGISTRATION_INFO.xml' path='doc/member[@name="MANAGEMENT_REGISTRATION_INFO.pszMDMServiceUri"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszMDMServiceUri;
}