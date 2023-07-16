// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadUserProfileA"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LoadUserProfileA(HANDLE hToken, [NativeTypeName("LPPROFILEINFOA")] PROFILEINFOA* lpProfileInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadUserProfileW"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LoadUserProfileW(HANDLE hToken, [NativeTypeName("LPPROFILEINFOW")] PROFILEINFOW* lpProfileInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnloadUserProfile"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnloadUserProfile(HANDLE hToken, HANDLE hProfile);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProfilesDirectoryA"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProfilesDirectoryA([NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProfilesDirectoryW"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProfilesDirectoryW([NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProfileType"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProfileType([NativeTypeName("DWORD *")] uint* dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteProfileA"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteProfileA([NativeTypeName("LPCSTR")] sbyte* lpSidString, [NativeTypeName("LPCSTR")] sbyte* lpProfilePath, [NativeTypeName("LPCSTR")] sbyte* lpComputerName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteProfileW"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteProfileW([NativeTypeName("LPCWSTR")] ushort* lpSidString, [NativeTypeName("LPCWSTR")] ushort* lpProfilePath, [NativeTypeName("LPCWSTR")] ushort* lpComputerName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateProfile"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    public static extern HRESULT CreateProfile([NativeTypeName("LPCWSTR")] ushort* pszUserSid, [NativeTypeName("LPCWSTR")] ushort* pszUserName, [NativeTypeName("LPWSTR")] ushort* pszProfilePath, [NativeTypeName("DWORD")] uint cchProfilePath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDefaultUserProfileDirectoryA"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDefaultUserProfileDirectoryA([NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDefaultUserProfileDirectoryW"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDefaultUserProfileDirectoryW([NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAllUsersProfileDirectoryA"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetAllUsersProfileDirectoryA([NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAllUsersProfileDirectoryW"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetAllUsersProfileDirectoryW([NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUserProfileDirectoryA"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUserProfileDirectoryA(HANDLE hToken, [NativeTypeName("LPSTR")] sbyte* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUserProfileDirectoryW"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUserProfileDirectoryW(HANDLE hToken, [NativeTypeName("LPWSTR")] ushort* lpProfileDir, [NativeTypeName("LPDWORD")] uint* lpcchSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateEnvironmentBlock"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateEnvironmentBlock([NativeTypeName("LPVOID *")] void** lpEnvironment, HANDLE hToken, BOOL bInherit);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DestroyEnvironmentBlock"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DestroyEnvironmentBlock([NativeTypeName("LPVOID")] void* lpEnvironment);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExpandEnvironmentStringsForUserA"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ExpandEnvironmentStringsForUserA(HANDLE hToken, [NativeTypeName("LPCSTR")] sbyte* lpSrc, [NativeTypeName("LPSTR")] sbyte* lpDest, [NativeTypeName("DWORD")] uint dwSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExpandEnvironmentStringsForUserW"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ExpandEnvironmentStringsForUserW(HANDLE hToken, [NativeTypeName("LPCWSTR")] ushort* lpSrc, [NativeTypeName("LPWSTR")] ushort* lpDest, [NativeTypeName("DWORD")] uint dwSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RefreshPolicy"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RefreshPolicy(BOOL bMachine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RefreshPolicyEx"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RefreshPolicyEx(BOOL bMachine, [NativeTypeName("DWORD")] uint dwOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnterCriticalPolicySection"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE EnterCriticalPolicySection(BOOL bMachine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LeaveCriticalPolicySection"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LeaveCriticalPolicySection(HANDLE hSection);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterGPNotification"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RegisterGPNotification(HANDLE hEvent, BOOL bMachine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterGPNotification"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterGPNotification(HANDLE hEvent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGPOListA"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetGPOListA(HANDLE hToken, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpHostName, [NativeTypeName("LPCSTR")] sbyte* lpComputerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PGROUP_POLICY_OBJECTA *")] GROUP_POLICY_OBJECTA** pGPOList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGPOListW"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetGPOListW(HANDLE hToken, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpHostName, [NativeTypeName("LPCWSTR")] ushort* lpComputerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PGROUP_POLICY_OBJECTW *")] GROUP_POLICY_OBJECTW** pGPOList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeGPOListA"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FreeGPOListA([NativeTypeName("PGROUP_POLICY_OBJECTA")] GROUP_POLICY_OBJECTA* pGPOList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeGPOListW"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FreeGPOListW([NativeTypeName("PGROUP_POLICY_OBJECTW")] GROUP_POLICY_OBJECTW* pGPOList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAppliedGPOListA"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetAppliedGPOListA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* pMachineName, [NativeTypeName("PSID")] void* pSidUser, Guid* pGuidExtension, [NativeTypeName("PGROUP_POLICY_OBJECTA *")] GROUP_POLICY_OBJECTA** ppGPOList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAppliedGPOListW"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetAppliedGPOListW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pMachineName, [NativeTypeName("PSID")] void* pSidUser, Guid* pGuidExtension, [NativeTypeName("PGROUP_POLICY_OBJECTW *")] GROUP_POLICY_OBJECTW** ppGPOList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ProcessGroupPolicyCompleted"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ProcessGroupPolicyCompleted([NativeTypeName("REFGPEXTENSIONID")] Guid* extensionId, ASYNCCOMPLETIONHANDLE pAsyncHandle, [NativeTypeName("DWORD")] uint dwStatus);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ProcessGroupPolicyCompletedEx"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ProcessGroupPolicyCompletedEx([NativeTypeName("REFGPEXTENSIONID")] Guid* extensionId, ASYNCCOMPLETIONHANDLE pAsyncHandle, [NativeTypeName("DWORD")] uint dwStatus, HRESULT RsopStatus);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RsopAccessCheckByType"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    public static extern HRESULT RsopAccessCheckByType([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID")] void* pPrincipalSelfSid, [NativeTypeName("PRSOPTOKEN")] void* pRsopToken, [NativeTypeName("DWORD")] uint dwDesiredAccessMask, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* pObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* pGenericMapping, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* pPrivilegeSet, [NativeTypeName("LPDWORD")] uint* pdwPrivilegeSetLength, [NativeTypeName("LPDWORD")] uint* pdwGrantedAccessMask, [NativeTypeName("LPBOOL")] BOOL* pbAccessStatus);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RsopFileAccessCheck"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    public static extern HRESULT RsopFileAccessCheck([NativeTypeName("LPWSTR")] ushort* pszFileName, [NativeTypeName("PRSOPTOKEN")] void* pRsopToken, [NativeTypeName("DWORD")] uint dwDesiredAccessMask, [NativeTypeName("LPDWORD")] uint* pdwGrantedAccessMask, [NativeTypeName("LPBOOL")] BOOL* pbAccessStatus);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RsopSetPolicySettingStatus"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    public static extern HRESULT RsopSetPolicySettingStatus([NativeTypeName("DWORD")] uint dwFlags, IWbemServices* pServices, IWbemClassObject* pSettingInstance, [NativeTypeName("DWORD")] uint nInfo, POLICYSETTINGSTATUSINFO* pStatus);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RsopResetPolicySettingStatus"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    public static extern HRESULT RsopResetPolicySettingStatus([NativeTypeName("DWORD")] uint dwFlags, IWbemServices* pServices, IWbemClassObject* pSettingInstance);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GenerateGPNotification"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GenerateGPNotification(BOOL bMachine, [NativeTypeName("LPCWSTR")] ushort* lpwszMgmtProduct, [NativeTypeName("DWORD")] uint dwMgmtProductOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateAppContainerProfile"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CreateAppContainerProfile([NativeTypeName("PCWSTR")] ushort* pszAppContainerName, [NativeTypeName("PCWSTR")] ushort* pszDisplayName, [NativeTypeName("PCWSTR")] ushort* pszDescription, [NativeTypeName("PSID_AND_ATTRIBUTES")] SID_AND_ATTRIBUTES* pCapabilities, [NativeTypeName("DWORD")] uint dwCapabilityCount, [NativeTypeName("PSID *")] void** ppSidAppContainerSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteAppContainerProfile"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DeleteAppContainerProfile([NativeTypeName("PCWSTR")] ushort* pszAppContainerName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAppContainerRegistryLocation"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetAppContainerRegistryLocation([NativeTypeName("REGSAM")] uint desiredAccess, [NativeTypeName("PHKEY")] HKEY* phAppContainerKey);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAppContainerFolderPath"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetAppContainerFolderPath([NativeTypeName("PCWSTR")] ushort* pszAppContainerSid, [NativeTypeName("PWSTR *")] ushort** ppszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeriveRestrictedAppContainerSidFromAppContainerSidAndRestrictedName"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern HRESULT DeriveRestrictedAppContainerSidFromAppContainerSidAndRestrictedName([NativeTypeName("PSID")] void* psidAppContainerSid, [NativeTypeName("PCWSTR")] ushort* pszRestrictedAppContainerName, [NativeTypeName("PSID *")] void** ppsidRestrictedAppContainerSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeriveAppContainerSidFromAppContainerName"]/*'/>
    [DllImport("userenv", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DeriveAppContainerSidFromAppContainerName([NativeTypeName("PCWSTR")] ushort* pszAppContainerName, [NativeTypeName("PSID *")] void** ppsidAppContainerSid);
    [NativeTypeName("#define PI_NOUI 0x00000001")]
    public const int PI_NOUI = 0x00000001;
    [NativeTypeName("#define PI_APPLYPOLICY 0x00000002")]
    public const int PI_APPLYPOLICY = 0x00000002;
    [NativeTypeName("#define LoadUserProfile LoadUserProfileW")]
    public static delegate*<HANDLE, PROFILEINFOW*, BOOL> LoadUserProfile => &LoadUserProfileW;

    [NativeTypeName("#define GetProfilesDirectory GetProfilesDirectoryW")]
    public static delegate*<ushort*, uint*, BOOL> GetProfilesDirectory => &GetProfilesDirectoryW;

    [NativeTypeName("#define PT_TEMPORARY 0x00000001")]
    public const int PT_TEMPORARY = 0x00000001;
    [NativeTypeName("#define PT_ROAMING 0x00000002")]
    public const int PT_ROAMING = 0x00000002;
    [NativeTypeName("#define PT_MANDATORY 0x00000004")]
    public const int PT_MANDATORY = 0x00000004;
    [NativeTypeName("#define PT_ROAMING_PREEXISTING 0x00000008")]
    public const int PT_ROAMING_PREEXISTING = 0x00000008;
    [NativeTypeName("#define DeleteProfile DeleteProfileW")]
    public static delegate*<ushort*, ushort*, ushort*, BOOL> DeleteProfile => &DeleteProfileW;

    [NativeTypeName("#define GetDefaultUserProfileDirectory GetDefaultUserProfileDirectoryW")]
    public static delegate*<ushort*, uint*, BOOL> GetDefaultUserProfileDirectory => &GetDefaultUserProfileDirectoryW;

    [NativeTypeName("#define GetAllUsersProfileDirectory GetAllUsersProfileDirectoryW")]
    public static delegate*<ushort*, uint*, BOOL> GetAllUsersProfileDirectory => &GetAllUsersProfileDirectoryW;

    [NativeTypeName("#define GetUserProfileDirectory GetUserProfileDirectoryW")]
    public static delegate*<HANDLE, ushort*, uint*, BOOL> GetUserProfileDirectory => &GetUserProfileDirectoryW;

    [NativeTypeName("#define ExpandEnvironmentStringsForUser ExpandEnvironmentStringsForUserW")]
    public static delegate*<HANDLE, ushort*, ushort*, uint, BOOL> ExpandEnvironmentStringsForUser => &ExpandEnvironmentStringsForUserW;

    [NativeTypeName("#define RP_FORCE 1")]
    public const int RP_FORCE = 1;
    [NativeTypeName("#define RP_SYNC 2")]
    public const int RP_SYNC = 2;
    [NativeTypeName("#define GPC_BLOCK_POLICY 0x00000001")]
    public const int GPC_BLOCK_POLICY = 0x00000001;
    [NativeTypeName("#define GetGPOList GetGPOListW")]
    public static delegate*<HANDLE, ushort*, ushort*, ushort*, uint, GROUP_POLICY_OBJECTW**, BOOL> GetGPOList => &GetGPOListW;

    [NativeTypeName("#define FreeGPOList FreeGPOListW")]
    public static delegate*<GROUP_POLICY_OBJECTW*, BOOL> FreeGPOList => &FreeGPOListW;

    [NativeTypeName("#define GetAppliedGPOList GetAppliedGPOListW")]
    public static delegate*<uint, ushort*, void*, Guid*, GROUP_POLICY_OBJECTW**, uint> GetAppliedGPOList => &GetAppliedGPOListW;

    [NativeTypeName("#define RSOP_USER_ACCESS_DENIED 0x00000001")]
    public const int RSOP_USER_ACCESS_DENIED = 0x00000001;
    [NativeTypeName("#define RSOP_COMPUTER_ACCESS_DENIED 0x00000002")]
    public const int RSOP_COMPUTER_ACCESS_DENIED = 0x00000002;
    [NativeTypeName("#define RSOP_TEMPNAMESPACE_EXISTS 0x00000004")]
    public const int RSOP_TEMPNAMESPACE_EXISTS = 0x00000004;
}