// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT GetDeviceRegistrationInfo(
        REGISTRATION_INFORMATION_CLASS DeviceInformationClass,
        [NativeTypeName("PVOID *")] void** ppDeviceRegistrationInfo
    );

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT IsDeviceRegisteredWithManagement(
        BOOL* pfIsDeviceRegisteredWithManagement,
        [NativeTypeName("DWORD")] uint cchUPN,
        [NativeTypeName("LPWSTR")] ushort* pszUPN
    );

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT IsManagementRegistrationAllowed(
        BOOL* pfIsManagementRegistrationAllowed
    );

    [DllImport("mdmregistration", ExactSpelling = true)]
    public static extern HRESULT IsMdmUxWithoutAadAllowed(BOOL* isEnrollmentAllowed);

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT SetManagedExternally(BOOL IsManagedExternally);

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT DiscoverManagementService(
        [NativeTypeName("LPCWSTR")] ushort* pszUPN,
        [NativeTypeName("PMANAGEMENT_SERVICE_INFO *")] MANAGEMENT_SERVICE_INFO** ppMgmtInfo
    );

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RegisterDeviceWithManagementUsingAADCredentials(HANDLE UserToken);

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RegisterDeviceWithManagementUsingAADDeviceCredentials();

    [DllImport("mdmregistration", ExactSpelling = true)]
    public static extern HRESULT RegisterDeviceWithManagementUsingAADDeviceCredentials2(
        [NativeTypeName("PCWSTR")] ushort* MDMApplicationID
    );

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RegisterDeviceWithManagement(
        [NativeTypeName("LPCWSTR")] ushort* pszUPN,
        [NativeTypeName("LPCWSTR")] ushort* ppszMDMServiceUri,
        [NativeTypeName("LPCWSTR")] ushort* ppzsAccessToken
    );

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT UnregisterDeviceWithManagement(
        [NativeTypeName("LPCWSTR")] ushort* enrollmentID
    );

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HRESULT GetDeviceManagementConfigInfo(
        [NativeTypeName("PCWSTR")] ushort* providerID,
        [NativeTypeName("DWORD *")] uint* configStringBufferLength,
        [NativeTypeName("PWSTR")] ushort* configString
    );

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HRESULT SetDeviceManagementConfigInfo(
        [NativeTypeName("PCWSTR")] ushort* providerID,
        [NativeTypeName("PCWSTR")] ushort* configString
    );

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT GetManagementAppHyperlink(
        [NativeTypeName("DWORD")] uint cchHyperlink,
        [NativeTypeName("LPWSTR")] ushort* pszHyperlink
    );

    [DllImport("mdmregistration", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT DiscoverManagementServiceEx(
        [NativeTypeName("LPCWSTR")] ushort* pszUPN,
        [NativeTypeName("LPCWSTR")] ushort* pszDiscoveryServiceCandidate,
        [NativeTypeName("PMANAGEMENT_SERVICE_INFO *")] MANAGEMENT_SERVICE_INFO** ppMgmtInfo
    );

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
