// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/securitybaseapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheck(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        HANDLE ClientToken,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* PrivilegeSet,
        [NativeTypeName("LPDWORD")] uint* PrivilegeSetLength,
        [NativeTypeName("LPDWORD")] uint* GrantedAccess,
        [NativeTypeName("LPBOOL")] BOOL* AccessStatus
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckAndAuditAlarmW(
        [NativeTypeName("LPCWSTR")] ushort* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        [NativeTypeName("LPWSTR")] ushort* ObjectTypeName,
        [NativeTypeName("LPWSTR")] ushort* ObjectName,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        BOOL ObjectCreation,
        [NativeTypeName("LPDWORD")] uint* GrantedAccess,
        [NativeTypeName("LPBOOL")] BOOL* AccessStatus,
        [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByType(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("PSID")] void* PrincipalSelfSid,
        HANDLE ClientToken,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList,
        [NativeTypeName("DWORD")] uint ObjectTypeListLength,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* PrivilegeSet,
        [NativeTypeName("LPDWORD")] uint* PrivilegeSetLength,
        [NativeTypeName("LPDWORD")] uint* GrantedAccess,
        [NativeTypeName("LPBOOL")] BOOL* AccessStatus
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeResultList(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("PSID")] void* PrincipalSelfSid,
        HANDLE ClientToken,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList,
        [NativeTypeName("DWORD")] uint ObjectTypeListLength,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* PrivilegeSet,
        [NativeTypeName("LPDWORD")] uint* PrivilegeSetLength,
        [NativeTypeName("LPDWORD")] uint* GrantedAccessList,
        [NativeTypeName("LPDWORD")] uint* AccessStatusList
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeAndAuditAlarmW(
        [NativeTypeName("LPCWSTR")] ushort* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        [NativeTypeName("LPCWSTR")] ushort* ObjectTypeName,
        [NativeTypeName("LPCWSTR")] ushort* ObjectName,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("PSID")] void* PrincipalSelfSid,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        AUDIT_EVENT_TYPE AuditType,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList,
        [NativeTypeName("DWORD")] uint ObjectTypeListLength,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        BOOL ObjectCreation,
        [NativeTypeName("LPDWORD")] uint* GrantedAccess,
        [NativeTypeName("LPBOOL")] BOOL* AccessStatus,
        [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeResultListAndAuditAlarmW(
        [NativeTypeName("LPCWSTR")] ushort* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        [NativeTypeName("LPCWSTR")] ushort* ObjectTypeName,
        [NativeTypeName("LPCWSTR")] ushort* ObjectName,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("PSID")] void* PrincipalSelfSid,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        AUDIT_EVENT_TYPE AuditType,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList,
        [NativeTypeName("DWORD")] uint ObjectTypeListLength,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        BOOL ObjectCreation,
        [NativeTypeName("LPDWORD")] uint* GrantedAccessList,
        [NativeTypeName("LPDWORD")] uint* AccessStatusList,
        [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeResultListAndAuditAlarmByHandleW(
        [NativeTypeName("LPCWSTR")] ushort* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        HANDLE ClientToken,
        [NativeTypeName("LPCWSTR")] ushort* ObjectTypeName,
        [NativeTypeName("LPCWSTR")] ushort* ObjectName,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("PSID")] void* PrincipalSelfSid,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        AUDIT_EVENT_TYPE AuditType,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList,
        [NativeTypeName("DWORD")] uint ObjectTypeListLength,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        BOOL ObjectCreation,
        [NativeTypeName("LPDWORD")] uint* GrantedAccessList,
        [NativeTypeName("LPDWORD")] uint* AccessStatusList,
        [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessAllowedAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AccessMask,
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessAllowedAceEx(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AceFlags,
        [NativeTypeName("DWORD")] uint AccessMask,
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessAllowedObjectAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AceFlags,
        [NativeTypeName("DWORD")] uint AccessMask,
        Guid* ObjectTypeGuid,
        Guid* InheritedObjectTypeGuid,
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessDeniedAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AccessMask,
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessDeniedAceEx(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AceFlags,
        [NativeTypeName("DWORD")] uint AccessMask,
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessDeniedObjectAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AceFlags,
        [NativeTypeName("DWORD")] uint AccessMask,
        Guid* ObjectTypeGuid,
        Guid* InheritedObjectTypeGuid,
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint dwStartingAceIndex,
        [NativeTypeName("LPVOID")] void* pAceList,
        [NativeTypeName("DWORD")] uint nAceListLength
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAuditAccessAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint dwAccessMask,
        [NativeTypeName("PSID")] void* pSid,
        BOOL bAuditSuccess,
        BOOL bAuditFailure
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAuditAccessAceEx(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AceFlags,
        [NativeTypeName("DWORD")] uint dwAccessMask,
        [NativeTypeName("PSID")] void* pSid,
        BOOL bAuditSuccess,
        BOOL bAuditFailure
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAuditAccessObjectAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AceFlags,
        [NativeTypeName("DWORD")] uint AccessMask,
        Guid* ObjectTypeGuid,
        Guid* InheritedObjectTypeGuid,
        [NativeTypeName("PSID")] void* pSid,
        BOOL bAuditSuccess,
        BOOL bAuditFailure
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddMandatoryAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AceFlags,
        [NativeTypeName("DWORD")] uint MandatoryPolicy,
        [NativeTypeName("PSID")] void* pLabelSid
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL AddResourceAttributeAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AceFlags,
        [NativeTypeName("DWORD")] uint AccessMask,
        [NativeTypeName("PSID")] void* pSid,
        [NativeTypeName("PCLAIM_SECURITY_ATTRIBUTES_INFORMATION")]
            CLAIM_SECURITY_ATTRIBUTES_INFORMATION* pAttributeInfo,
        [NativeTypeName("PDWORD")] uint* pReturnLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL AddScopedPolicyIDAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AceFlags,
        [NativeTypeName("DWORD")] uint AccessMask,
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AdjustTokenGroups(
        HANDLE TokenHandle,
        BOOL ResetToDefault,
        [NativeTypeName("PTOKEN_GROUPS")] TOKEN_GROUPS* NewState,
        [NativeTypeName("DWORD")] uint BufferLength,
        [NativeTypeName("PTOKEN_GROUPS")] TOKEN_GROUPS* PreviousState,
        [NativeTypeName("PDWORD")] uint* ReturnLength
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AdjustTokenPrivileges(
        HANDLE TokenHandle,
        BOOL DisableAllPrivileges,
        [NativeTypeName("PTOKEN_PRIVILEGES")] TOKEN_PRIVILEGES* NewState,
        [NativeTypeName("DWORD")] uint BufferLength,
        [NativeTypeName("PTOKEN_PRIVILEGES")] TOKEN_PRIVILEGES* PreviousState,
        [NativeTypeName("PDWORD")] uint* ReturnLength
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AllocateAndInitializeSid(
        [NativeTypeName("PSID_IDENTIFIER_AUTHORITY")]
            SID_IDENTIFIER_AUTHORITY* pIdentifierAuthority,
        byte nSubAuthorityCount,
        [NativeTypeName("DWORD")] uint nSubAuthority0,
        [NativeTypeName("DWORD")] uint nSubAuthority1,
        [NativeTypeName("DWORD")] uint nSubAuthority2,
        [NativeTypeName("DWORD")] uint nSubAuthority3,
        [NativeTypeName("DWORD")] uint nSubAuthority4,
        [NativeTypeName("DWORD")] uint nSubAuthority5,
        [NativeTypeName("DWORD")] uint nSubAuthority6,
        [NativeTypeName("DWORD")] uint nSubAuthority7,
        [NativeTypeName("PSID *")] void** pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AllocateLocallyUniqueId([NativeTypeName("PLUID")] LUID* Luid);

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL AreAllAccessesGranted(
        [NativeTypeName("DWORD")] uint GrantedAccess,
        [NativeTypeName("DWORD")] uint DesiredAccess
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL AreAnyAccessesGranted(
        [NativeTypeName("DWORD")] uint GrantedAccess,
        [NativeTypeName("DWORD")] uint DesiredAccess
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CheckTokenMembership(
        HANDLE TokenHandle,
        [NativeTypeName("PSID")] void* SidToCheck,
        [NativeTypeName("PBOOL")] BOOL* IsMember
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL CheckTokenCapability(
        HANDLE TokenHandle,
        [NativeTypeName("PSID")] void* CapabilitySidToCheck,
        [NativeTypeName("PBOOL")] BOOL* HasCapability
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetAppContainerAce(
        [NativeTypeName("PACL")] ACL* Acl,
        [NativeTypeName("DWORD")] uint StartingAceIndex,
        [NativeTypeName("PVOID *")] void** AppContainerAce,
        [NativeTypeName("DWORD *")] uint* AppContainerAceIndex
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL CheckTokenMembershipEx(
        HANDLE TokenHandle,
        [NativeTypeName("PSID")] void* SidToCheck,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("PBOOL")] BOOL* IsMember
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertToAutoInheritPrivateObjectSecurity(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CurrentSecurityDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewSecurityDescriptor,
        Guid* ObjectType,
        [NativeTypeName("BOOLEAN")] byte IsDirectoryObject,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopySid(
        [NativeTypeName("DWORD")] uint nDestinationSidLength,
        [NativeTypeName("PSID")] void* pDestinationSid,
        [NativeTypeName("PSID")] void* pSourceSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreatePrivateObjectSecurity(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CreatorDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewDescriptor,
        BOOL IsDirectoryObject,
        HANDLE Token,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreatePrivateObjectSecurityEx(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CreatorDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewDescriptor,
        Guid* ObjectType,
        BOOL IsContainerObject,
        [NativeTypeName("ULONG")] uint AutoInheritFlags,
        HANDLE Token,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreatePrivateObjectSecurityWithMultipleInheritance(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CreatorDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewDescriptor,
        Guid** ObjectTypes,
        [NativeTypeName("ULONG")] uint GuidCount,
        BOOL IsContainerObject,
        [NativeTypeName("ULONG")] uint AutoInheritFlags,
        HANDLE Token,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateRestrictedToken(
        HANDLE ExistingTokenHandle,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("DWORD")] uint DisableSidCount,
        [NativeTypeName("PSID_AND_ATTRIBUTES")] SID_AND_ATTRIBUTES* SidsToDisable,
        [NativeTypeName("DWORD")] uint DeletePrivilegeCount,
        [NativeTypeName("PLUID_AND_ATTRIBUTES")] LUID_AND_ATTRIBUTES* PrivilegesToDelete,
        [NativeTypeName("DWORD")] uint RestrictedSidCount,
        [NativeTypeName("PSID_AND_ATTRIBUTES")] SID_AND_ATTRIBUTES* SidsToRestrict,
        [NativeTypeName("PHANDLE")] HANDLE* NewTokenHandle
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateWellKnownSid(
        WELL_KNOWN_SID_TYPE WellKnownSidType,
        [NativeTypeName("PSID")] void* DomainSid,
        [NativeTypeName("PSID")] void* pSid,
        [NativeTypeName("DWORD *")] uint* cbSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EqualDomainSid(
        [NativeTypeName("PSID")] void* pSid1,
        [NativeTypeName("PSID")] void* pSid2,
        BOOL* pfEqual
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceIndex
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DestroyPrivateObjectSecurity(
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ObjectDescriptor
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DuplicateToken(
        HANDLE ExistingTokenHandle,
        SECURITY_IMPERSONATION_LEVEL ImpersonationLevel,
        [NativeTypeName("PHANDLE")] HANDLE* DuplicateTokenHandle
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DuplicateTokenEx(
        HANDLE hExistingToken,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTokenAttributes,
        SECURITY_IMPERSONATION_LEVEL ImpersonationLevel,
        TOKEN_TYPE TokenType,
        [NativeTypeName("PHANDLE")] HANDLE* phNewToken
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EqualPrefixSid(
        [NativeTypeName("PSID")] void* pSid1,
        [NativeTypeName("PSID")] void* pSid2
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EqualSid(
        [NativeTypeName("PSID")] void* pSid1,
        [NativeTypeName("PSID")] void* pSid2
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindFirstFreeAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("LPVOID *")] void** pAce
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("PVOID")]
    public static extern void* FreeSid([NativeTypeName("PSID")] void* pSid);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceIndex,
        [NativeTypeName("LPVOID *")] void** pAce
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetAclInformation(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("LPVOID")] void* pAclInformation,
        [NativeTypeName("DWORD")] uint nAclInformationLength,
        ACL_INFORMATION_CLASS dwAclInformationClass
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileSecurityW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("SECURITY_INFORMATION")] uint RequestedInformation,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("DWORD")] uint nLength,
        [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetKernelObjectSecurity(
        HANDLE Handle,
        [NativeTypeName("SECURITY_INFORMATION")] uint RequestedInformation,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("DWORD")] uint nLength,
        [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLengthSid([NativeTypeName("PSID")] void* pSid);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetPrivateObjectSecurity(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ObjectDescriptor,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ResultantDescriptor,
        [NativeTypeName("DWORD")] uint DescriptorLength,
        [NativeTypeName("PDWORD")] uint* ReturnLength
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSecurityDescriptorControl(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR_CONTROL")] ushort* pControl,
        [NativeTypeName("LPDWORD")] uint* lpdwRevision
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSecurityDescriptorDacl(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("LPBOOL")] BOOL* lpbDaclPresent,
        [NativeTypeName("PACL *")] ACL** pDacl,
        [NativeTypeName("LPBOOL")] BOOL* lpbDaclDefaulted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSecurityDescriptorGroup(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("PSID *")] void** pGroup,
        [NativeTypeName("LPBOOL")] BOOL* lpbGroupDefaulted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetSecurityDescriptorLength(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSecurityDescriptorOwner(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("PSID *")] void** pOwner,
        [NativeTypeName("LPBOOL")] BOOL* lpbOwnerDefaulted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetSecurityDescriptorRMControl(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("PUCHAR")] byte* RMControl
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSecurityDescriptorSacl(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("LPBOOL")] BOOL* lpbSaclPresent,
        [NativeTypeName("PACL *")] ACL** pSacl,
        [NativeTypeName("LPBOOL")] BOOL* lpbSaclDefaulted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PSID_IDENTIFIER_AUTHORITY")]
    public static extern SID_IDENTIFIER_AUTHORITY* GetSidIdentifierAuthority(
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetSidLengthRequired(
        [NativeTypeName("UCHAR")] byte nSubAuthorityCount
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PDWORD")]
    public static extern uint* GetSidSubAuthority(
        [NativeTypeName("PSID")] void* pSid,
        [NativeTypeName("DWORD")] uint nSubAuthority
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PUCHAR")]
    public static extern byte* GetSidSubAuthorityCount([NativeTypeName("PSID")] void* pSid);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetTokenInformation(
        HANDLE TokenHandle,
        TOKEN_INFORMATION_CLASS TokenInformationClass,
        [NativeTypeName("LPVOID")] void* TokenInformation,
        [NativeTypeName("DWORD")] uint TokenInformationLength,
        [NativeTypeName("PDWORD")] uint* ReturnLength
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetWindowsAccountDomainSid(
        [NativeTypeName("PSID")] void* pSid,
        [NativeTypeName("PSID")] void* pDomainSid,
        [NativeTypeName("DWORD *")] uint* cbDomainSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ImpersonateAnonymousToken(HANDLE ThreadHandle);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ImpersonateLoggedOnUser(HANDLE hToken);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ImpersonateSelf(SECURITY_IMPERSONATION_LEVEL ImpersonationLevel);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeAcl(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint nAclLength,
        [NativeTypeName("DWORD")] uint dwAclRevision
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeSecurityDescriptor(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("DWORD")] uint dwRevision
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeSid(
        [NativeTypeName("PSID")] void* Sid,
        [NativeTypeName("PSID_IDENTIFIER_AUTHORITY")]
            SID_IDENTIFIER_AUTHORITY* pIdentifierAuthority,
        byte nSubAuthorityCount
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsTokenRestricted(HANDLE TokenHandle);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsValidAcl([NativeTypeName("PACL")] ACL* pAcl);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsValidSecurityDescriptor(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsValidSid([NativeTypeName("PSID")] void* pSid);

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL IsWellKnownSid(
        [NativeTypeName("PSID")] void* pSid,
        WELL_KNOWN_SID_TYPE WellKnownSidType
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MakeAbsoluteSD(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSelfRelativeSecurityDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pAbsoluteSecurityDescriptor,
        [NativeTypeName("LPDWORD")] uint* lpdwAbsoluteSecurityDescriptorSize,
        [NativeTypeName("PACL")] ACL* pDacl,
        [NativeTypeName("LPDWORD")] uint* lpdwDaclSize,
        [NativeTypeName("PACL")] ACL* pSacl,
        [NativeTypeName("LPDWORD")] uint* lpdwSaclSize,
        [NativeTypeName("PSID")] void* pOwner,
        [NativeTypeName("LPDWORD")] uint* lpdwOwnerSize,
        [NativeTypeName("PSID")] void* pPrimaryGroup,
        [NativeTypeName("LPDWORD")] uint* lpdwPrimaryGroupSize
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MakeSelfRelativeSD(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pAbsoluteSecurityDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSelfRelativeSecurityDescriptor,
        [NativeTypeName("LPDWORD")] uint* lpdwBufferLength
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void MapGenericMask(
        [NativeTypeName("PDWORD")] uint* AccessMask,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectCloseAuditAlarmW(
        [NativeTypeName("LPCWSTR")] ushort* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        BOOL GenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectDeleteAuditAlarmW(
        [NativeTypeName("LPCWSTR")] ushort* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        BOOL GenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectOpenAuditAlarmW(
        [NativeTypeName("LPCWSTR")] ushort* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        [NativeTypeName("LPWSTR")] ushort* ObjectTypeName,
        [NativeTypeName("LPWSTR")] ushort* ObjectName,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        HANDLE ClientToken,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        [NativeTypeName("DWORD")] uint GrantedAccess,
        [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges,
        BOOL ObjectCreation,
        BOOL AccessGranted,
        [NativeTypeName("LPBOOL")] BOOL* GenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectPrivilegeAuditAlarmW(
        [NativeTypeName("LPCWSTR")] ushort* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        HANDLE ClientToken,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges,
        BOOL AccessGranted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PrivilegeCheck(
        HANDLE ClientToken,
        [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* RequiredPrivileges,
        [NativeTypeName("LPBOOL")] BOOL* pfResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PrivilegedServiceAuditAlarmW(
        [NativeTypeName("LPCWSTR")] ushort* SubsystemName,
        [NativeTypeName("LPCWSTR")] ushort* ServiceName,
        HANDLE ClientToken,
        [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges,
        BOOL AccessGranted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void QuerySecurityAccessMask(
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("LPDWORD")] uint* DesiredAccess
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RevertToSelf();

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetAclInformation(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("LPVOID")] void* pAclInformation,
        [NativeTypeName("DWORD")] uint nAclInformationLength,
        ACL_INFORMATION_CLASS dwAclInformationClass
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileSecurityW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetKernelObjectSecurity(
        HANDLE Handle,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetPrivateObjectSecurity(
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ModificationDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ObjectsSecurityDescriptor,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        HANDLE Token
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetPrivateObjectSecurityEx(
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ModificationDescriptor,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ObjectsSecurityDescriptor,
        [NativeTypeName("ULONG")] uint AutoInheritFlags,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        HANDLE Token
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void SetSecurityAccessMask(
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("LPDWORD")] uint* DesiredAccess
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSecurityDescriptorControl(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("SECURITY_DESCRIPTOR_CONTROL")] ushort ControlBitsOfInterest,
        [NativeTypeName("SECURITY_DESCRIPTOR_CONTROL")] ushort ControlBitsToSet
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSecurityDescriptorDacl(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        BOOL bDaclPresent,
        [NativeTypeName("PACL")] ACL* pDacl,
        BOOL bDaclDefaulted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSecurityDescriptorGroup(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("PSID")] void* pGroup,
        BOOL bGroupDefaulted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSecurityDescriptorOwner(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("PSID")] void* pOwner,
        BOOL bOwnerDefaulted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetSecurityDescriptorRMControl(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("PUCHAR")] byte* RMControl
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSecurityDescriptorSacl(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        BOOL bSaclPresent,
        [NativeTypeName("PACL")] ACL* pSacl,
        BOOL bSaclDefaulted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetTokenInformation(
        HANDLE TokenHandle,
        TOKEN_INFORMATION_CLASS TokenInformationClass,
        [NativeTypeName("LPVOID")] void* TokenInformation,
        [NativeTypeName("DWORD")] uint TokenInformationLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetCachedSigningLevel(
        [NativeTypeName("PHANDLE")] HANDLE* SourceFiles,
        [NativeTypeName("ULONG")] uint SourceFileCount,
        [NativeTypeName("ULONG")] uint Flags,
        HANDLE TargetFile
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetCachedSigningLevel(
        HANDLE File,
        [NativeTypeName("PULONG")] uint* Flags,
        [NativeTypeName("PULONG")] uint* SigningLevel,
        [NativeTypeName("PUCHAR")] byte* Thumbprint,
        [NativeTypeName("PULONG")] uint* ThumbprintSize,
        [NativeTypeName("PULONG")] uint* ThumbprintAlgorithm
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows10.0")]
    public static extern int CveEventWrite(
        [NativeTypeName("PCWSTR")] ushort* CveId,
        [NativeTypeName("PCWSTR")] ushort* AdditionalDetails
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeriveCapabilitySidsFromName(
        [NativeTypeName("LPCWSTR")] ushort* CapName,
        [NativeTypeName("PSID **")] void*** CapabilityGroupSids,
        [NativeTypeName("DWORD *")] uint* CapabilityGroupSidCount,
        [NativeTypeName("PSID **")] void*** CapabilitySids,
        [NativeTypeName("DWORD *")] uint* CapabilitySidCount
    );

    [NativeTypeName("#define AccessCheckAndAuditAlarm AccessCheckAndAuditAlarmW")]
    public static delegate* <
        ushort*,
        void*,
        ushort*,
        ushort*,
        void*,
        uint,
        GENERIC_MAPPING*,
        BOOL,
        uint*,
        BOOL*,
        BOOL*,
        BOOL> AccessCheckAndAuditAlarm => &AccessCheckAndAuditAlarmW;

    [NativeTypeName("#define AccessCheckByTypeAndAuditAlarm AccessCheckByTypeAndAuditAlarmW")]
    public static delegate* <
        ushort*,
        void*,
        ushort*,
        ushort*,
        void*,
        void*,
        uint,
        AUDIT_EVENT_TYPE,
        uint,
        OBJECT_TYPE_LIST*,
        uint,
        GENERIC_MAPPING*,
        BOOL,
        uint*,
        BOOL*,
        BOOL*,
        BOOL> AccessCheckByTypeAndAuditAlarm => &AccessCheckByTypeAndAuditAlarmW;

    [NativeTypeName(
        "#define AccessCheckByTypeResultListAndAuditAlarm AccessCheckByTypeResultListAndAuditAlarmW"
    )]
    public static delegate* <
        ushort*,
        void*,
        ushort*,
        ushort*,
        void*,
        void*,
        uint,
        AUDIT_EVENT_TYPE,
        uint,
        OBJECT_TYPE_LIST*,
        uint,
        GENERIC_MAPPING*,
        BOOL,
        uint*,
        uint*,
        BOOL*,
        BOOL> AccessCheckByTypeResultListAndAuditAlarm =>
        &AccessCheckByTypeResultListAndAuditAlarmW;

    [NativeTypeName(
        "#define AccessCheckByTypeResultListAndAuditAlarmByHandle AccessCheckByTypeResultListAndAuditAlarmByHandleW"
    )]
    public static delegate* <
        ushort*,
        void*,
        HANDLE,
        ushort*,
        ushort*,
        void*,
        void*,
        uint,
        AUDIT_EVENT_TYPE,
        uint,
        OBJECT_TYPE_LIST*,
        uint,
        GENERIC_MAPPING*,
        BOOL,
        uint*,
        uint*,
        BOOL*,
        BOOL> AccessCheckByTypeResultListAndAuditAlarmByHandle =>
        &AccessCheckByTypeResultListAndAuditAlarmByHandleW;

    [NativeTypeName("#define GetFileSecurity GetFileSecurityW")]
    public static delegate* <ushort*, uint, void*, uint, uint*, BOOL> GetFileSecurity =>
        &GetFileSecurityW;

    [NativeTypeName("#define ObjectCloseAuditAlarm ObjectCloseAuditAlarmW")]
    public static delegate* <ushort*, void*, BOOL, BOOL> ObjectCloseAuditAlarm =>
        &ObjectCloseAuditAlarmW;

    [NativeTypeName("#define ObjectDeleteAuditAlarm ObjectDeleteAuditAlarmW")]
    public static delegate* <ushort*, void*, BOOL, BOOL> ObjectDeleteAuditAlarm =>
        &ObjectDeleteAuditAlarmW;

    [NativeTypeName("#define ObjectOpenAuditAlarm ObjectOpenAuditAlarmW")]
    public static delegate* <
        ushort*,
        void*,
        ushort*,
        ushort*,
        void*,
        HANDLE,
        uint,
        uint,
        PRIVILEGE_SET*,
        BOOL,
        BOOL,
        BOOL*,
        BOOL> ObjectOpenAuditAlarm => &ObjectOpenAuditAlarmW;

    [NativeTypeName("#define ObjectPrivilegeAuditAlarm ObjectPrivilegeAuditAlarmW")]
    public static delegate* <
        ushort*,
        void*,
        HANDLE,
        uint,
        PRIVILEGE_SET*,
        BOOL,
        BOOL> ObjectPrivilegeAuditAlarm => &ObjectPrivilegeAuditAlarmW;

    [NativeTypeName("#define PrivilegedServiceAuditAlarm PrivilegedServiceAuditAlarmW")]
    public static delegate* <
        ushort*,
        ushort*,
        HANDLE,
        PRIVILEGE_SET*,
        BOOL,
        BOOL> PrivilegedServiceAuditAlarm => &PrivilegedServiceAuditAlarmW;

    [NativeTypeName("#define SetFileSecurity SetFileSecurityW")]
    public static delegate* <ushort*, uint, void*, BOOL> SetFileSecurity => &SetFileSecurityW;

    [NativeTypeName("#define SIGNING_LEVEL_FILE_CACHE_FLAG_NOT_VALIDATED 0x01")]
    public const int SIGNING_LEVEL_FILE_CACHE_FLAG_NOT_VALIDATED = 0x01;

    [NativeTypeName("#define SIGNING_LEVEL_FILE_CACHE_FLAG_VALIDATE_ONLY 0x04")]
    public const int SIGNING_LEVEL_FILE_CACHE_FLAG_VALIDATE_ONLY = 0x04;

    [NativeTypeName("#define SIGNING_LEVEL_MICROSOFT 8")]
    public const int SIGNING_LEVEL_MICROSOFT = 8;
}
