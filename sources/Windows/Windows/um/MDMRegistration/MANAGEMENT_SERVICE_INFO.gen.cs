// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MANAGEMENT_SERVICE_INFO.xml' path='doc/member[@name="MANAGEMENT_SERVICE_INFO"]/*'/>
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct MANAGEMENT_SERVICE_INFO
{
    /// <include file='MANAGEMENT_SERVICE_INFO.xml' path='doc/member[@name="MANAGEMENT_SERVICE_INFO.pszMDMServiceUri"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszMDMServiceUri;
    /// <include file='MANAGEMENT_SERVICE_INFO.xml' path='doc/member[@name="MANAGEMENT_SERVICE_INFO.pszAuthenticationUri"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszAuthenticationUri;
}