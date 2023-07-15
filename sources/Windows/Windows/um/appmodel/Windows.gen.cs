// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentPackageId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetCurrentPackageId([NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentPackageFullName"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetCurrentPackageFullName([NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentPackageFamilyName"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetCurrentPackageFamilyName([NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentPackagePath"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetCurrentPackagePath([NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPackageId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageId(HANDLE hProcess, [NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPackageFullName"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageFullName(HANDLE hProcess, [NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPackageFullNameFromToken"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageFullNameFromToken(HANDLE token, [NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPackageFamilyName"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageFamilyName(HANDLE hProcess, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPackageFamilyNameFromToken"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageFamilyNameFromToken(HANDLE token, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPackagePath"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackagePath([NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId, [NativeTypeName("const UINT32")] uint reserved, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPackagePathByFullName"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int GetPackagePathByFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetStagedPackagePathByFullName"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int GetStagedPackagePathByFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentApplicationUserModelId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int GetCurrentApplicationUserModelId([NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetApplicationUserModelId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int GetApplicationUserModelId(HANDLE hProcess, [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetApplicationUserModelIdFromToken"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int GetApplicationUserModelIdFromToken(HANDLE token, [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PackageIdFromFullName"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int PackageIdFromFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("const UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PackageFullNameFromId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int PackageFullNameFromId([NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId, [NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PackageFamilyNameFromId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int PackageFamilyNameFromId([NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PackageFamilyNameFromFullName"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int PackageFamilyNameFromFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PackageNameAndPublisherIdFromFamilyName"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int PackageNameAndPublisherIdFromFamilyName([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32 *")] uint* packageNameLength, [NativeTypeName("PWSTR")] ushort* packageName, [NativeTypeName("UINT32 *")] uint* packagePublisherIdLength, [NativeTypeName("PWSTR")] ushort* packagePublisherId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FormatApplicationUserModelId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int FormatApplicationUserModelId([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("PCWSTR")] ushort* packageRelativeApplicationId, [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ParseApplicationUserModelId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int ParseApplicationUserModelId([NativeTypeName("PCWSTR")] ushort* applicationUserModelId, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32 *")] uint* packageRelativeApplicationIdLength, [NativeTypeName("PWSTR")] ushort* packageRelativeApplicationId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPackagesByPackageFamily"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackagesByPackageFamily([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32 *")] uint* count, [NativeTypeName("PWSTR *")] ushort** packageFullNames, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("WCHAR *")] ushort* buffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindPackagesByPackageFamily"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int FindPackagesByPackageFamily([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32")] uint packageFilters, [NativeTypeName("UINT32 *")] uint* count, [NativeTypeName("PWSTR *")] ushort** packageFullNames, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("WCHAR *")] ushort* buffer, [NativeTypeName("UINT32 *")] uint* packageProperties);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetStagedPackageOrigin"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int GetStagedPackageOrigin([NativeTypeName("PCWSTR")] ushort* packageFullName, PackageOrigin* origin);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentPackageInfo"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetCurrentPackageInfo([NativeTypeName("const UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer, [NativeTypeName("UINT32 *")] uint* count);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenPackageInfoByFullName"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int OpenPackageInfoByFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("const UINT32")] uint reserved, PACKAGE_INFO_REFERENCE* packageInfoReference);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ClosePackageInfo"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int ClosePackageInfo(PACKAGE_INFO_REFERENCE packageInfoReference);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPackageInfo"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int GetPackageInfo(PACKAGE_INFO_REFERENCE packageInfoReference, [NativeTypeName("const UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer, [NativeTypeName("UINT32 *")] uint* count);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPackageApplicationIds"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows6.3")]
    public static extern int GetPackageApplicationIds(PACKAGE_INFO_REFERENCE packageInfoReference, [NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer, [NativeTypeName("UINT32 *")] uint* count);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TryCreatePackageDependency"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern HRESULT TryCreatePackageDependency([NativeTypeName("PSID")] void* user, [NativeTypeName("PCWSTR")] ushort* packageFamilyName, PACKAGE_VERSION minVersion, PackageDependencyProcessorArchitectures packageDependencyProcessorArchitectures, PackageDependencyLifetimeKind lifetimeKind, [NativeTypeName("PCWSTR")] ushort* lifetimeArtifact, CreatePackageDependencyOptions options, [NativeTypeName("PWSTR *")] ushort** packageDependencyId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeletePackageDependency"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern HRESULT DeletePackageDependency([NativeTypeName("PCWSTR")] ushort* packageDependencyId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddPackageDependency"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern HRESULT AddPackageDependency([NativeTypeName("PCWSTR")] ushort* packageDependencyId, [NativeTypeName("INT32")] int rank, AddPackageDependencyOptions options, PACKAGEDEPENDENCY_CONTEXT* packageDependencyContext, [NativeTypeName("PWSTR *")] ushort** packageFullName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemovePackageDependency"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern HRESULT RemovePackageDependency(PACKAGEDEPENDENCY_CONTEXT packageDependencyContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetResolvedPackageFullNameForPackageDependency"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern HRESULT GetResolvedPackageFullNameForPackageDependency([NativeTypeName("PCWSTR")] ushort* packageDependencyId, [NativeTypeName("PWSTR *")] ushort** packageFullName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetIdForPackageDependencyContext"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern HRESULT GetIdForPackageDependencyContext(PACKAGEDEPENDENCY_CONTEXT packageDependencyContext, [NativeTypeName("PWSTR *")] ushort** packageDependencyId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPackageGraphRevisionId"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("UINT32")]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern uint GetPackageGraphRevisionId();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AppPolicyGetLifecycleManagement"]/*'/>
    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetLifecycleManagement(HANDLE processToken, AppPolicyLifecycleManagement* policy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AppPolicyGetWindowingModel"]/*'/>
    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetWindowingModel(HANDLE processToken, AppPolicyWindowingModel* policy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AppPolicyGetMediaFoundationCodecLoading"]/*'/>
    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetMediaFoundationCodecLoading(HANDLE processToken, AppPolicyMediaFoundationCodecLoading* policy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AppPolicyGetClrCompat"]/*'/>
    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetClrCompat(HANDLE processToken, AppPolicyClrCompat* policy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AppPolicyGetThreadInitializationType"]/*'/>
    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetThreadInitializationType(HANDLE processToken, AppPolicyThreadInitializationType* policy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AppPolicyGetShowDeveloperDiagnostic"]/*'/>
    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetShowDeveloperDiagnostic(HANDLE processToken, AppPolicyShowDeveloperDiagnostic* policy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AppPolicyGetProcessTerminationMethod"]/*'/>
    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetProcessTerminationMethod(HANDLE processToken, AppPolicyProcessTerminationMethod* policy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AppPolicyGetCreateFileAccess"]/*'/>
    [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int AppPolicyGetCreateFileAccess(HANDLE processToken, AppPolicyCreateFileAccess* policy);
}