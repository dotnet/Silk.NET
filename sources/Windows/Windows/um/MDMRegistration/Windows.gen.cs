// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDeviceRegistrationInfo"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT GetDeviceRegistrationInfo(REGISTRATION_INFORMATION_CLASS DeviceInformationClass, [NativeTypeName("PVOID *")] void** ppDeviceRegistrationInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsDeviceRegisteredWithManagement"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT IsDeviceRegisteredWithManagement(BOOL* pfIsDeviceRegisteredWithManagement, [NativeTypeName("DWORD")] uint cchUPN, [NativeTypeName("LPWSTR")] ushort* pszUPN);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsManagementRegistrationAllowed"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT IsManagementRegistrationAllowed(BOOL* pfIsManagementRegistrationAllowed);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsMdmUxWithoutAadAllowed"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    public static extern HRESULT IsMdmUxWithoutAadAllowed(BOOL* isEnrollmentAllowed);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetManagedExternally"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT SetManagedExternally(BOOL IsManagedExternally);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DiscoverManagementService"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT DiscoverManagementService([NativeTypeName("LPCWSTR")] ushort* pszUPN, [NativeTypeName("PMANAGEMENT_SERVICE_INFO *")] MANAGEMENT_SERVICE_INFO** ppMgmtInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterDeviceWithManagementUsingAADCredentials"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RegisterDeviceWithManagementUsingAADCredentials(HANDLE UserToken);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterDeviceWithManagementUsingAADDeviceCredentials"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RegisterDeviceWithManagementUsingAADDeviceCredentials();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterDeviceWithManagementUsingAADDeviceCredentials2"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    public static extern HRESULT RegisterDeviceWithManagementUsingAADDeviceCredentials2([NativeTypeName("PCWSTR")] ushort* MDMApplicationID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterDeviceDualEnrollMmpcUsingAADDeviceCredentials"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern HRESULT RegisterDeviceDualEnrollMmpcUsingAADDeviceCredentials([NativeTypeName("DWORD")] uint cchEnrollmentId, [NativeTypeName("LPWSTR")] ushort* pszEnrollmentId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterDeviceWithManagement"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RegisterDeviceWithManagement([NativeTypeName("LPCWSTR")] ushort* pszUPN, [NativeTypeName("LPCWSTR")] ushort* ppszMDMServiceUri, [NativeTypeName("LPCWSTR")] ushort* ppzsAccessToken);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterDeviceWithManagement"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT UnregisterDeviceWithManagement([NativeTypeName("LPCWSTR")] ushort* enrollmentID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDeviceManagementConfigInfo"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    public static extern HRESULT GetDeviceManagementConfigInfo([NativeTypeName("PCWSTR")] ushort* providerID, [NativeTypeName("DWORD *")] uint* configStringBufferLength, [NativeTypeName("PWSTR")] ushort* configString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDeviceManagementConfigInfo"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    public static extern HRESULT SetDeviceManagementConfigInfo([NativeTypeName("PCWSTR")] ushort* providerID, [NativeTypeName("PCWSTR")] ushort* configString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetManagementAppHyperlink"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT GetManagementAppHyperlink([NativeTypeName("DWORD")] uint cchHyperlink, [NativeTypeName("LPWSTR")] ushort* pszHyperlink);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DiscoverManagementServiceEx"]/*' />
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT DiscoverManagementServiceEx([NativeTypeName("LPCWSTR")] ushort* pszUPN, [NativeTypeName("LPCWSTR")] ushort* pszDiscoveryServiceCandidate, [NativeTypeName("PMANAGEMENT_SERVICE_INFO *")] MANAGEMENT_SERVICE_INFO** ppMgmtInfo);

    [NativeTypeName("#define MDM_REGISTRATION_FACILITY_CODE 25")]
    public const int MDM_REGISTRATION_FACILITY_CODE = 25;

    [NativeTypeName("#define DEVICEREGISTRATIONTYPE_MDM_ONLY 0")]
    public const int DEVICEREGISTRATIONTYPE_MDM_ONLY = 0;

    [NativeTypeName("#define DEVICEREGISTRATIONTYPE_MAM 5")]
    public const int DEVICEREGISTRATIONTYPE_MAM = 5;

    [NativeTypeName("#define DEVICEREGISTRATIONTYPE_MDM_DEVICEWIDE_WITH_AAD 6")]
    public const int DEVICEREGISTRATIONTYPE_MDM_DEVICEWIDE_WITH_AAD = 6;

    [NativeTypeName("#define DEVICEREGISTRATIONTYPE_MDM_USERSPECIFIC_WITH_AAD 13")]
    public const int DEVICEREGISTRATIONTYPE_MDM_USERSPECIFIC_WITH_AAD = 13;
}
