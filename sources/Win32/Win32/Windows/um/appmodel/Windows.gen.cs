// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetCurrentPackageId(
        [NativeTypeName("UINT32 *")] uint* bufferLength,
        byte* buffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetCurrentPackageFullName(
        [NativeTypeName("UINT32 *")] uint* packageFullNameLength,
        [NativeTypeName("PWSTR")] ushort* packageFullName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetCurrentPackageFamilyName(
        [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength,
        [NativeTypeName("PWSTR")] ushort* packageFamilyName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetCurrentPackagePath(
        [NativeTypeName("UINT32 *")] uint* pathLength,
        [NativeTypeName("PWSTR")] ushort* path
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageId(
        HANDLE hProcess,
        [NativeTypeName("UINT32 *")] uint* bufferLength,
        byte* buffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageFullName(
        HANDLE hProcess,
        [NativeTypeName("UINT32 *")] uint* packageFullNameLength,
        [NativeTypeName("PWSTR")] ushort* packageFullName
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageFullNameFromToken(
        HANDLE token,
        [NativeTypeName("UINT32 *")] uint* packageFullNameLength,
        [NativeTypeName("PWSTR")] ushort* packageFullName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageFamilyName(
        HANDLE hProcess,
        [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength,
        [NativeTypeName("PWSTR")] ushort* packageFamilyName
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageFamilyNameFromToken(
        HANDLE token,
        [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength,
        [NativeTypeName("PWSTR")] ushort* packageFamilyName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackagePath(
        [NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId,
        [NativeTypeName("const UINT32")] uint reserved,
        [NativeTypeName("UINT32 *")] uint* pathLength,
        [NativeTypeName("PWSTR")] ushort* path
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int GetPackagePathByFullName(
        [NativeTypeName("PCWSTR")] ushort* packageFullName,
        [NativeTypeName("UINT32 *")] uint* pathLength,
        [NativeTypeName("PWSTR")] ushort* path
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int GetStagedPackagePathByFullName(
        [NativeTypeName("PCWSTR")] ushort* packageFullName,
        [NativeTypeName("UINT32 *")] uint* pathLength,
        [NativeTypeName("PWSTR")] ushort* path
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows10.0")]
    public static extern int GetPackagePathByFullName2(
        [NativeTypeName("PCWSTR")] ushort* packageFullName,
        PackagePathType packagePathType,
        [NativeTypeName("UINT32 *")] uint* pathLength,
        [NativeTypeName("PWSTR")] ushort* path
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows10.0")]
    public static extern int GetStagedPackagePathByFullName2(
        [NativeTypeName("PCWSTR")] ushort* packageFullName,
        PackagePathType packagePathType,
        [NativeTypeName("UINT32 *")] uint* pathLength,
        [NativeTypeName("PWSTR")] ushort* path
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows10.0")]
    public static extern int GetCurrentPackageInfo2(
        [NativeTypeName("const UINT32")] uint flags,
        PackagePathType packagePathType,
        [NativeTypeName("UINT32 *")] uint* bufferLength,
        byte* buffer,
        [NativeTypeName("UINT32 *")] uint* count
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows10.0")]
    public static extern int GetCurrentPackagePath2(
        PackagePathType packagePathType,
        [NativeTypeName("UINT32 *")] uint* pathLength,
        [NativeTypeName("PWSTR")] ushort* path
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int GetCurrentApplicationUserModelId(
        [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength,
        [NativeTypeName("PWSTR")] ushort* applicationUserModelId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int GetApplicationUserModelId(
        HANDLE hProcess,
        [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength,
        [NativeTypeName("PWSTR")] ushort* applicationUserModelId
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int GetApplicationUserModelIdFromToken(
        HANDLE token,
        [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength,
        [NativeTypeName("PWSTR")] ushort* applicationUserModelId
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int VerifyPackageFullName(
        [NativeTypeName("PCWSTR")] ushort* packageFullName
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int VerifyPackageFamilyName(
        [NativeTypeName("PCWSTR")] ushort* packageFamilyName
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int VerifyPackageId(
        [NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int VerifyApplicationUserModelId(
        [NativeTypeName("PCWSTR")] ushort* applicationUserModelId
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int VerifyPackageRelativeApplicationId(
        [NativeTypeName("PCWSTR")] ushort* packageRelativeApplicationId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int PackageIdFromFullName(
        [NativeTypeName("PCWSTR")] ushort* packageFullName,
        [NativeTypeName("const UINT32")] uint flags,
        [NativeTypeName("UINT32 *")] uint* bufferLength,
        byte* buffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int PackageFullNameFromId(
        [NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId,
        [NativeTypeName("UINT32 *")] uint* packageFullNameLength,
        [NativeTypeName("PWSTR")] ushort* packageFullName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int PackageFamilyNameFromId(
        [NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId,
        [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength,
        [NativeTypeName("PWSTR")] ushort* packageFamilyName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int PackageFamilyNameFromFullName(
        [NativeTypeName("PCWSTR")] ushort* packageFullName,
        [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength,
        [NativeTypeName("PWSTR")] ushort* packageFamilyName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int PackageNameAndPublisherIdFromFamilyName(
        [NativeTypeName("PCWSTR")] ushort* packageFamilyName,
        [NativeTypeName("UINT32 *")] uint* packageNameLength,
        [NativeTypeName("PWSTR")] ushort* packageName,
        [NativeTypeName("UINT32 *")] uint* packagePublisherIdLength,
        [NativeTypeName("PWSTR")] ushort* packagePublisherId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int FormatApplicationUserModelId(
        [NativeTypeName("PCWSTR")] ushort* packageFamilyName,
        [NativeTypeName("PCWSTR")] ushort* packageRelativeApplicationId,
        [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength,
        [NativeTypeName("PWSTR")] ushort* applicationUserModelId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int ParseApplicationUserModelId(
        [NativeTypeName("PCWSTR")] ushort* applicationUserModelId,
        [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength,
        [NativeTypeName("PWSTR")] ushort* packageFamilyName,
        [NativeTypeName("UINT32 *")] uint* packageRelativeApplicationIdLength,
        [NativeTypeName("PWSTR")] ushort* packageRelativeApplicationId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackagesByPackageFamily(
        [NativeTypeName("PCWSTR")] ushort* packageFamilyName,
        [NativeTypeName("UINT32 *")] uint* count,
        [NativeTypeName("PWSTR *")] ushort** packageFullNames,
        [NativeTypeName("UINT32 *")] uint* bufferLength,
        [NativeTypeName("WCHAR *")] ushort* buffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int FindPackagesByPackageFamily(
        [NativeTypeName("PCWSTR")] ushort* packageFamilyName,
        [NativeTypeName("UINT32")] uint packageFilters,
        [NativeTypeName("UINT32 *")] uint* count,
        [NativeTypeName("PWSTR *")] ushort** packageFullNames,
        [NativeTypeName("UINT32 *")] uint* bufferLength,
        [NativeTypeName("WCHAR *")] ushort* buffer,
        [NativeTypeName("UINT32 *")] uint* packageProperties
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int GetStagedPackageOrigin(
        [NativeTypeName("PCWSTR")] ushort* packageFullName,
        PackageOrigin* origin
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetCurrentPackageInfo(
        [NativeTypeName("const UINT32")] uint flags,
        [NativeTypeName("UINT32 *")] uint* bufferLength,
        byte* buffer,
        [NativeTypeName("UINT32 *")] uint* count
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int OpenPackageInfoByFullName(
        [NativeTypeName("PCWSTR")] ushort* packageFullName,
        [NativeTypeName("const UINT32")] uint reserved,
        PACKAGE_INFO_REFERENCE* packageInfoReference
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int OpenPackageInfoByFullNameForUser(
        [NativeTypeName("PSID")] void* userSid,
        [NativeTypeName("PCWSTR")] ushort* packageFullName,
        [NativeTypeName("const UINT32")] uint reserved,
        PACKAGE_INFO_REFERENCE* packageInfoReference
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int ClosePackageInfo(PACKAGE_INFO_REFERENCE packageInfoReference);

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageInfo(
        PACKAGE_INFO_REFERENCE packageInfoReference,
        [NativeTypeName("const UINT32")] uint flags,
        [NativeTypeName("UINT32 *")] uint* bufferLength,
        byte* buffer,
        [NativeTypeName("UINT32 *")] uint* count
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int GetPackageApplicationIds(
        PACKAGE_INFO_REFERENCE packageInfoReference,
        [NativeTypeName("UINT32 *")] uint* bufferLength,
        byte* buffer,
        [NativeTypeName("UINT32 *")] uint* count
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows10.0")]
    public static extern int GetPackageInfo2(
        PACKAGE_INFO_REFERENCE packageInfoReference,
        [NativeTypeName("const UINT32")] uint flags,
        PackagePathType packagePathType,
        [NativeTypeName("UINT32 *")] uint* bufferLength,
        byte* buffer,
        [NativeTypeName("UINT32 *")] uint* count
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern HRESULT CheckIsMSIXPackage(
        [NativeTypeName("PCWSTR")] ushort* packageFullName,
        BOOL* isMSIXPackage
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern HRESULT TryCreatePackageDependency(
        [NativeTypeName("PSID")] void* user,
        [NativeTypeName("PCWSTR")] ushort* packageFamilyName,
        PACKAGE_VERSION minVersion,
        PackageDependencyProcessorArchitectures packageDependencyProcessorArchitectures,
        PackageDependencyLifetimeKind lifetimeKind,
        [NativeTypeName("PCWSTR")] ushort* lifetimeArtifact,
        CreatePackageDependencyOptions options,
        [NativeTypeName("PWSTR *")] ushort** packageDependencyId
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern HRESULT TryCreatePackageDependency2(
        [NativeTypeName("PSID")] void* user,
        [NativeTypeName("PCWSTR")] ushort* packageFamilyName,
        PACKAGE_VERSION minVersion,
        PackageDependencyProcessorArchitectures packageDependencyProcessorArchitectures,
        PackageDependencyLifetimeKind lifetimeKind,
        [NativeTypeName("PCWSTR")] ushort* lifetimeArtifact,
        CreatePackageDependencyOptions options,
        [NativeTypeName("const FILETIME *")] FILETIME* lifetimeExpiration,
        [NativeTypeName("PWSTR *")] ushort** packageDependencyId
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern HRESULT DeletePackageDependency(
        [NativeTypeName("PCWSTR")] ushort* packageDependencyId
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern HRESULT AddPackageDependency(
        [NativeTypeName("PCWSTR")] ushort* packageDependencyId,
        [NativeTypeName("INT32")] int rank,
        AddPackageDependencyOptions options,
        PACKAGEDEPENDENCY_CONTEXT* packageDependencyContext,
        [NativeTypeName("PWSTR *")] ushort** packageFullName
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern HRESULT AddPackageDependency2(
        [NativeTypeName("PCWSTR")] ushort* packageDependencyId,
        [NativeTypeName("INT32")] int rank,
        AddPackageDependencyOptions2 options,
        PACKAGEDEPENDENCY_CONTEXT* packageDependencyContext,
        [NativeTypeName("PWSTR *")] ushort** packageFullName
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern HRESULT RemovePackageDependency(
        PACKAGEDEPENDENCY_CONTEXT packageDependencyContext
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern HRESULT GetResolvedPackageFullNameForPackageDependency(
        [NativeTypeName("PCWSTR")] ushort* packageDependencyId,
        [NativeTypeName("PWSTR *")] ushort** packageFullName
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern HRESULT GetResolvedPackageFullNameForPackageDependency2(
        [NativeTypeName("PCWSTR")] ushort* packageDependencyId,
        [NativeTypeName("PWSTR *")] ushort** packageFullName
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern HRESULT GetIdForPackageDependencyContext(
        PACKAGEDEPENDENCY_CONTEXT packageDependencyContext,
        [NativeTypeName("PWSTR *")] ushort** packageDependencyId
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("UINT32")]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern uint GetPackageGraphRevisionId();

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern HRESULT FindPackageDependency(
        [NativeTypeName("const FindPackageDependencyCriteria *")]
            FindPackageDependencyCriteria* findPackageDependencyCriteria,
        [NativeTypeName("UINT32 *")] uint* packageDependencyIdsCount,
        [NativeTypeName("PWSTR **")] ushort*** packageDependencyIds
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern HRESULT GetPackageDependencyInformation(
        [NativeTypeName("PCWSTR")] ushort* packageDependencyId,
        [NativeTypeName("PSID *")] void** user,
        [NativeTypeName("PWSTR *")] ushort** packageFamilyName,
        PACKAGE_VERSION* minVersion,
        PackageDependencyProcessorArchitectures* packageDependencyProcessorArchitectures,
        PackageDependencyLifetimeKind* lifetimeKind,
        [NativeTypeName("PWSTR *")] ushort** lifetimeArtifact,
        CreatePackageDependencyOptions* options,
        FILETIME* lifetimeExpiration
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern HRESULT GetProcessesUsingPackageDependency(
        [NativeTypeName("PCWSTR")] ushort* packageDependencyId,
        [NativeTypeName("PSID")] void* user,
        BOOL scopeIsSystem,
        [NativeTypeName("UINT32 *")] uint* processIdsCount,
        [NativeTypeName("DWORD **")] uint** processIds
    );

    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetLifecycleManagement(
        HANDLE processToken,
        AppPolicyLifecycleManagement* policy
    );

    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetWindowingModel(
        HANDLE processToken,
        AppPolicyWindowingModel* policy
    );

    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetMediaFoundationCodecLoading(
        HANDLE processToken,
        AppPolicyMediaFoundationCodecLoading* policy
    );

    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetClrCompat(HANDLE processToken, AppPolicyClrCompat* policy);

    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetThreadInitializationType(
        HANDLE processToken,
        AppPolicyThreadInitializationType* policy
    );

    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetShowDeveloperDiagnostic(
        HANDLE processToken,
        AppPolicyShowDeveloperDiagnostic* policy
    );

    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetProcessTerminationMethod(
        HANDLE processToken,
        AppPolicyProcessTerminationMethod* policy
    );

    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetCreateFileAccess(
        HANDLE processToken,
        AppPolicyCreateFileAccess* policy
    );
}
