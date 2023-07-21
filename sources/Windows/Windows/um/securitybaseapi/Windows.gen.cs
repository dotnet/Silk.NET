// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/securitybaseapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AccessCheck"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheck([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, HANDLE ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* PrivilegeSet, [NativeTypeName("LPDWORD")] uint* PrivilegeSetLength, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] BOOL* AccessStatus);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AccessCheckAndAuditAlarmW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckAndAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPWSTR")] ushort* ObjectTypeName, [NativeTypeName("LPWSTR")] ushort* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, BOOL ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] BOOL* AccessStatus, [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AccessCheckByType"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByType([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, HANDLE ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* PrivilegeSet, [NativeTypeName("LPDWORD")] uint* PrivilegeSetLength, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] BOOL* AccessStatus);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AccessCheckByTypeResultList"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeResultList([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, HANDLE ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* PrivilegeSet, [NativeTypeName("LPDWORD")] uint* PrivilegeSetLength, [NativeTypeName("LPDWORD")] uint* GrantedAccessList, [NativeTypeName("LPDWORD")] uint* AccessStatusList);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AccessCheckByTypeAndAuditAlarmW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeAndAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCWSTR")] ushort* ObjectTypeName, [NativeTypeName("LPCWSTR")] ushort* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, BOOL ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] BOOL* AccessStatus, [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AccessCheckByTypeResultListAndAuditAlarmW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeResultListAndAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCWSTR")] ushort* ObjectTypeName, [NativeTypeName("LPCWSTR")] ushort* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, BOOL ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccessList, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AccessCheckByTypeResultListAndAuditAlarmByHandleW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeResultListAndAuditAlarmByHandleW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, HANDLE ClientToken, [NativeTypeName("LPCWSTR")] ushort* ObjectTypeName, [NativeTypeName("LPCWSTR")] ushort* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, BOOL ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccessList, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAccessAllowedAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessAllowedAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAccessAllowedAceEx"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessAllowedAceEx([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAccessAllowedObjectAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessAllowedObjectAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, Guid* ObjectTypeGuid, Guid* InheritedObjectTypeGuid, [NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAccessDeniedAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessDeniedAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAccessDeniedAceEx"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessDeniedAceEx([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAccessDeniedObjectAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAccessDeniedObjectAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, Guid* ObjectTypeGuid, Guid* InheritedObjectTypeGuid, [NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint dwStartingAceIndex, [NativeTypeName("LPVOID")] void* pAceList, [NativeTypeName("DWORD")] uint nAceListLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAuditAccessAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAuditAccessAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint dwAccessMask, [NativeTypeName("PSID")] void* pSid, BOOL bAuditSuccess, BOOL bAuditFailure);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAuditAccessAceEx"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAuditAccessAceEx([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint dwAccessMask, [NativeTypeName("PSID")] void* pSid, BOOL bAuditSuccess, BOOL bAuditFailure);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAuditAccessObjectAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddAuditAccessObjectAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, Guid* ObjectTypeGuid, Guid* InheritedObjectTypeGuid, [NativeTypeName("PSID")] void* pSid, BOOL bAuditSuccess, BOOL bAuditFailure);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddMandatoryAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddMandatoryAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint MandatoryPolicy, [NativeTypeName("PSID")] void* pLabelSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddResourceAttributeAce"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL AddResourceAttributeAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("PCLAIM_SECURITY_ATTRIBUTES_INFORMATION")] CLAIM_SECURITY_ATTRIBUTES_INFORMATION* pAttributeInfo, [NativeTypeName("PDWORD")] uint* pReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddScopedPolicyIDAce"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL AddScopedPolicyIDAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AdjustTokenGroups"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AdjustTokenGroups(HANDLE TokenHandle, BOOL ResetToDefault, [NativeTypeName("PTOKEN_GROUPS")] TOKEN_GROUPS* NewState, [NativeTypeName("DWORD")] uint BufferLength, [NativeTypeName("PTOKEN_GROUPS")] TOKEN_GROUPS* PreviousState, [NativeTypeName("PDWORD")] uint* ReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AdjustTokenPrivileges"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AdjustTokenPrivileges(HANDLE TokenHandle, BOOL DisableAllPrivileges, [NativeTypeName("PTOKEN_PRIVILEGES")] TOKEN_PRIVILEGES* NewState, [NativeTypeName("DWORD")] uint BufferLength, [NativeTypeName("PTOKEN_PRIVILEGES")] TOKEN_PRIVILEGES* PreviousState, [NativeTypeName("PDWORD")] uint* ReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AllocateAndInitializeSid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AllocateAndInitializeSid([NativeTypeName("PSID_IDENTIFIER_AUTHORITY")] SID_IDENTIFIER_AUTHORITY* pIdentifierAuthority, byte nSubAuthorityCount, [NativeTypeName("DWORD")] uint nSubAuthority0, [NativeTypeName("DWORD")] uint nSubAuthority1, [NativeTypeName("DWORD")] uint nSubAuthority2, [NativeTypeName("DWORD")] uint nSubAuthority3, [NativeTypeName("DWORD")] uint nSubAuthority4, [NativeTypeName("DWORD")] uint nSubAuthority5, [NativeTypeName("DWORD")] uint nSubAuthority6, [NativeTypeName("DWORD")] uint nSubAuthority7, [NativeTypeName("PSID *")] void** pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AllocateLocallyUniqueId"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AllocateLocallyUniqueId([NativeTypeName("PLUID")] LUID* Luid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AreAllAccessesGranted"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL AreAllAccessesGranted([NativeTypeName("DWORD")] uint GrantedAccess, [NativeTypeName("DWORD")] uint DesiredAccess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AreAnyAccessesGranted"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL AreAnyAccessesGranted([NativeTypeName("DWORD")] uint GrantedAccess, [NativeTypeName("DWORD")] uint DesiredAccess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckTokenMembership"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CheckTokenMembership(HANDLE TokenHandle, [NativeTypeName("PSID")] void* SidToCheck, [NativeTypeName("PBOOL")] BOOL* IsMember);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckTokenCapability"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL CheckTokenCapability(HANDLE TokenHandle, [NativeTypeName("PSID")] void* CapabilitySidToCheck, [NativeTypeName("PBOOL")] BOOL* HasCapability);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckTokenMembershipEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL CheckTokenMembershipEx(HANDLE TokenHandle, [NativeTypeName("PSID")] void* SidToCheck, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PBOOL")] BOOL* IsMember);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertToAutoInheritPrivateObjectSecurity"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertToAutoInheritPrivateObjectSecurity([NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CurrentSecurityDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewSecurityDescriptor, Guid* ObjectType, [NativeTypeName("BOOLEAN")] byte IsDirectoryObject, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopySid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopySid([NativeTypeName("DWORD")] uint nDestinationSidLength, [NativeTypeName("PSID")] void* pDestinationSid, [NativeTypeName("PSID")] void* pSourceSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePrivateObjectSecurity"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreatePrivateObjectSecurity([NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CreatorDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewDescriptor, BOOL IsDirectoryObject, HANDLE Token, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePrivateObjectSecurityEx"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreatePrivateObjectSecurityEx([NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CreatorDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewDescriptor, Guid* ObjectType, BOOL IsContainerObject, [NativeTypeName("ULONG")] uint AutoInheritFlags, HANDLE Token, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePrivateObjectSecurityWithMultipleInheritance"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreatePrivateObjectSecurityWithMultipleInheritance([NativeTypeName("PSECURITY_DESCRIPTOR")] void* ParentDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* CreatorDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** NewDescriptor, Guid** ObjectTypes, [NativeTypeName("ULONG")] uint GuidCount, BOOL IsContainerObject, [NativeTypeName("ULONG")] uint AutoInheritFlags, HANDLE Token, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateRestrictedToken"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateRestrictedToken(HANDLE ExistingTokenHandle, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint DisableSidCount, [NativeTypeName("PSID_AND_ATTRIBUTES")] SID_AND_ATTRIBUTES* SidsToDisable, [NativeTypeName("DWORD")] uint DeletePrivilegeCount, [NativeTypeName("PLUID_AND_ATTRIBUTES")] LUID_AND_ATTRIBUTES* PrivilegesToDelete, [NativeTypeName("DWORD")] uint RestrictedSidCount, [NativeTypeName("PSID_AND_ATTRIBUTES")] SID_AND_ATTRIBUTES* SidsToRestrict, [NativeTypeName("PHANDLE")] HANDLE* NewTokenHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateWellKnownSid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateWellKnownSid(WELL_KNOWN_SID_TYPE WellKnownSidType, [NativeTypeName("PSID")] void* DomainSid, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("DWORD *")] uint* cbSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EqualDomainSid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EqualDomainSid([NativeTypeName("PSID")] void* pSid1, [NativeTypeName("PSID")] void* pSid2, BOOL* pfEqual);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceIndex);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DestroyPrivateObjectSecurity"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DestroyPrivateObjectSecurity([NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ObjectDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DuplicateToken"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DuplicateToken(HANDLE ExistingTokenHandle, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, [NativeTypeName("PHANDLE")] HANDLE* DuplicateTokenHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DuplicateTokenEx"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DuplicateTokenEx(HANDLE hExistingToken, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTokenAttributes, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, TOKEN_TYPE TokenType, [NativeTypeName("PHANDLE")] HANDLE* phNewToken);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EqualPrefixSid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EqualPrefixSid([NativeTypeName("PSID")] void* pSid1, [NativeTypeName("PSID")] void* pSid2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EqualSid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EqualSid([NativeTypeName("PSID")] void* pSid1, [NativeTypeName("PSID")] void* pSid2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstFreeAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindFirstFreeAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("LPVOID *")] void** pAce);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeSid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("PVOID")]
    public static extern void* FreeSid([NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceIndex, [NativeTypeName("LPVOID *")] void** pAce);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAclInformation"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetAclInformation([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("LPVOID")] void* pAclInformation, [NativeTypeName("DWORD")] uint nAclInformationLength, ACL_INFORMATION_CLASS dwAclInformationClass);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileSecurityW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileSecurityW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint RequestedInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKernelObjectSecurity"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetKernelObjectSecurity(HANDLE Handle, [NativeTypeName("SECURITY_INFORMATION")] uint RequestedInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLengthSid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLengthSid([NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPrivateObjectSecurity"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetPrivateObjectSecurity([NativeTypeName("PSECURITY_DESCRIPTOR")] void* ObjectDescriptor, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ResultantDescriptor, [NativeTypeName("DWORD")] uint DescriptorLength, [NativeTypeName("PDWORD")] uint* ReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSecurityDescriptorControl"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSecurityDescriptorControl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR_CONTROL")] ushort* pControl, [NativeTypeName("LPDWORD")] uint* lpdwRevision);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSecurityDescriptorDacl"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSecurityDescriptorDacl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("LPBOOL")] BOOL* lpbDaclPresent, [NativeTypeName("PACL *")] ACL** pDacl, [NativeTypeName("LPBOOL")] BOOL* lpbDaclDefaulted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSecurityDescriptorGroup"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSecurityDescriptorGroup([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID *")] void** pGroup, [NativeTypeName("LPBOOL")] BOOL* lpbGroupDefaulted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSecurityDescriptorLength"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetSecurityDescriptorLength([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSecurityDescriptorOwner"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSecurityDescriptorOwner([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID *")] void** pOwner, [NativeTypeName("LPBOOL")] BOOL* lpbOwnerDefaulted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSecurityDescriptorRMControl"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetSecurityDescriptorRMControl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PUCHAR")] byte* RMControl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSecurityDescriptorSacl"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSecurityDescriptorSacl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("LPBOOL")] BOOL* lpbSaclPresent, [NativeTypeName("PACL *")] ACL** pSacl, [NativeTypeName("LPBOOL")] BOOL* lpbSaclDefaulted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSidIdentifierAuthority"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PSID_IDENTIFIER_AUTHORITY")]
    public static extern SID_IDENTIFIER_AUTHORITY* GetSidIdentifierAuthority([NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSidLengthRequired"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetSidLengthRequired([NativeTypeName("UCHAR")] byte nSubAuthorityCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSidSubAuthority"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PDWORD")]
    public static extern uint* GetSidSubAuthority([NativeTypeName("PSID")] void* pSid, [NativeTypeName("DWORD")] uint nSubAuthority);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSidSubAuthorityCount"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PUCHAR")]
    public static extern byte* GetSidSubAuthorityCount([NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTokenInformation"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetTokenInformation(HANDLE TokenHandle, TOKEN_INFORMATION_CLASS TokenInformationClass, [NativeTypeName("LPVOID")] void* TokenInformation, [NativeTypeName("DWORD")] uint TokenInformationLength, [NativeTypeName("PDWORD")] uint* ReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowsAccountDomainSid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetWindowsAccountDomainSid([NativeTypeName("PSID")] void* pSid, [NativeTypeName("PSID")] void* pDomainSid, [NativeTypeName("DWORD *")] uint* cbDomainSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImpersonateAnonymousToken"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ImpersonateAnonymousToken(HANDLE ThreadHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImpersonateLoggedOnUser"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ImpersonateLoggedOnUser(HANDLE hToken);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImpersonateSelf"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ImpersonateSelf(SECURITY_IMPERSONATION_LEVEL ImpersonationLevel);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeAcl"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeAcl([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint nAclLength, [NativeTypeName("DWORD")] uint dwAclRevision);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeSecurityDescriptor"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeSecurityDescriptor([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("DWORD")] uint dwRevision);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeSid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeSid([NativeTypeName("PSID")] void* Sid, [NativeTypeName("PSID_IDENTIFIER_AUTHORITY")] SID_IDENTIFIER_AUTHORITY* pIdentifierAuthority, byte nSubAuthorityCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsTokenRestricted"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsTokenRestricted(HANDLE TokenHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsValidAcl"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsValidAcl([NativeTypeName("PACL")] ACL* pAcl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsValidSecurityDescriptor"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsValidSecurityDescriptor([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsValidSid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsValidSid([NativeTypeName("PSID")] void* pSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsWellKnownSid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL IsWellKnownSid([NativeTypeName("PSID")] void* pSid, WELL_KNOWN_SID_TYPE WellKnownSidType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MakeAbsoluteSD"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MakeAbsoluteSD([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSelfRelativeSecurityDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pAbsoluteSecurityDescriptor, [NativeTypeName("LPDWORD")] uint* lpdwAbsoluteSecurityDescriptorSize, [NativeTypeName("PACL")] ACL* pDacl, [NativeTypeName("LPDWORD")] uint* lpdwDaclSize, [NativeTypeName("PACL")] ACL* pSacl, [NativeTypeName("LPDWORD")] uint* lpdwSaclSize, [NativeTypeName("PSID")] void* pOwner, [NativeTypeName("LPDWORD")] uint* lpdwOwnerSize, [NativeTypeName("PSID")] void* pPrimaryGroup, [NativeTypeName("LPDWORD")] uint* lpdwPrimaryGroupSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MakeSelfRelativeSD"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MakeSelfRelativeSD([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pAbsoluteSecurityDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSelfRelativeSecurityDescriptor, [NativeTypeName("LPDWORD")] uint* lpdwBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapGenericMask"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void MapGenericMask([NativeTypeName("PDWORD")] uint* AccessMask, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ObjectCloseAuditAlarmW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectCloseAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, BOOL GenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ObjectDeleteAuditAlarmW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectDeleteAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, BOOL GenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ObjectOpenAuditAlarmW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectOpenAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPWSTR")] ushort* ObjectTypeName, [NativeTypeName("LPWSTR")] ushort* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, HANDLE ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("DWORD")] uint GrantedAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, BOOL ObjectCreation, BOOL AccessGranted, [NativeTypeName("LPBOOL")] BOOL* GenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ObjectPrivilegeAuditAlarmW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectPrivilegeAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, HANDLE ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, BOOL AccessGranted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrivilegeCheck"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PrivilegeCheck(HANDLE ClientToken, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* RequiredPrivileges, [NativeTypeName("LPBOOL")] BOOL* pfResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrivilegedServiceAuditAlarmW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PrivilegedServiceAuditAlarmW([NativeTypeName("LPCWSTR")] ushort* SubsystemName, [NativeTypeName("LPCWSTR")] ushort* ServiceName, HANDLE ClientToken, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, BOOL AccessGranted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QuerySecurityAccessMask"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void QuerySecurityAccessMask([NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("LPDWORD")] uint* DesiredAccess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RevertToSelf"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RevertToSelf();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetAclInformation"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetAclInformation([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("LPVOID")] void* pAclInformation, [NativeTypeName("DWORD")] uint nAclInformationLength, ACL_INFORMATION_CLASS dwAclInformationClass);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileSecurityW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileSecurityW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetKernelObjectSecurity"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetKernelObjectSecurity(HANDLE Handle, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPrivateObjectSecurity"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetPrivateObjectSecurity([NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ModificationDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ObjectsSecurityDescriptor, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, HANDLE Token);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPrivateObjectSecurityEx"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetPrivateObjectSecurityEx([NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* ModificationDescriptor, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ObjectsSecurityDescriptor, [NativeTypeName("ULONG")] uint AutoInheritFlags, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, HANDLE Token);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSecurityAccessMask"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void SetSecurityAccessMask([NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("LPDWORD")] uint* DesiredAccess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSecurityDescriptorControl"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSecurityDescriptorControl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("SECURITY_DESCRIPTOR_CONTROL")] ushort ControlBitsOfInterest, [NativeTypeName("SECURITY_DESCRIPTOR_CONTROL")] ushort ControlBitsToSet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSecurityDescriptorDacl"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSecurityDescriptorDacl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, BOOL bDaclPresent, [NativeTypeName("PACL")] ACL* pDacl, BOOL bDaclDefaulted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSecurityDescriptorGroup"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSecurityDescriptorGroup([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID")] void* pGroup, BOOL bGroupDefaulted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSecurityDescriptorOwner"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSecurityDescriptorOwner([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("PSID")] void* pOwner, BOOL bOwnerDefaulted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSecurityDescriptorRMControl"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetSecurityDescriptorRMControl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PUCHAR")] byte* RMControl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSecurityDescriptorSacl"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSecurityDescriptorSacl([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, BOOL bSaclPresent, [NativeTypeName("PACL")] ACL* pSacl, BOOL bSaclDefaulted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetTokenInformation"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetTokenInformation(HANDLE TokenHandle, TOKEN_INFORMATION_CLASS TokenInformationClass, [NativeTypeName("LPVOID")] void* TokenInformation, [NativeTypeName("DWORD")] uint TokenInformationLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CveEventWrite"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    [SupportedOSPlatform("windows10.0")]
    public static extern int CveEventWrite([NativeTypeName("PCWSTR")] ushort* CveId, [NativeTypeName("PCWSTR")] ushort* AdditionalDetails);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeriveCapabilitySidsFromName"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeriveCapabilitySidsFromName([NativeTypeName("LPCWSTR")] ushort* CapName, [NativeTypeName("PSID **")] void*** CapabilityGroupSids, [NativeTypeName("DWORD *")] uint* CapabilityGroupSidCount, [NativeTypeName("PSID **")] void*** CapabilitySids, [NativeTypeName("DWORD *")] uint* CapabilitySidCount);

    [NativeTypeName("#define AccessCheckAndAuditAlarm AccessCheckAndAuditAlarmW")]
    public static delegate*<ushort*, void*, ushort*, ushort*, void*, uint, GENERIC_MAPPING*, BOOL, uint*, BOOL*, BOOL*, BOOL> AccessCheckAndAuditAlarm => &AccessCheckAndAuditAlarmW;

    [NativeTypeName("#define AccessCheckByTypeAndAuditAlarm AccessCheckByTypeAndAuditAlarmW")]
    public static delegate*<ushort*, void*, ushort*, ushort*, void*, void*, uint, AUDIT_EVENT_TYPE, uint, OBJECT_TYPE_LIST*, uint, GENERIC_MAPPING*, BOOL, uint*, BOOL*, BOOL*, BOOL> AccessCheckByTypeAndAuditAlarm => &AccessCheckByTypeAndAuditAlarmW;

    [NativeTypeName("#define AccessCheckByTypeResultListAndAuditAlarm AccessCheckByTypeResultListAndAuditAlarmW")]
    public static delegate*<ushort*, void*, ushort*, ushort*, void*, void*, uint, AUDIT_EVENT_TYPE, uint, OBJECT_TYPE_LIST*, uint, GENERIC_MAPPING*, BOOL, uint*, uint*, BOOL*, BOOL> AccessCheckByTypeResultListAndAuditAlarm => &AccessCheckByTypeResultListAndAuditAlarmW;

    [NativeTypeName("#define AccessCheckByTypeResultListAndAuditAlarmByHandle AccessCheckByTypeResultListAndAuditAlarmByHandleW")]
    public static delegate*<ushort*, void*, HANDLE, ushort*, ushort*, void*, void*, uint, AUDIT_EVENT_TYPE, uint, OBJECT_TYPE_LIST*, uint, GENERIC_MAPPING*, BOOL, uint*, uint*, BOOL*, BOOL> AccessCheckByTypeResultListAndAuditAlarmByHandle => &AccessCheckByTypeResultListAndAuditAlarmByHandleW;

    [NativeTypeName("#define GetFileSecurity GetFileSecurityW")]
    public static delegate*<ushort*, uint, void*, uint, uint*, BOOL> GetFileSecurity => &GetFileSecurityW;

    [NativeTypeName("#define ObjectCloseAuditAlarm ObjectCloseAuditAlarmW")]
    public static delegate*<ushort*, void*, BOOL, BOOL> ObjectCloseAuditAlarm => &ObjectCloseAuditAlarmW;

    [NativeTypeName("#define ObjectDeleteAuditAlarm ObjectDeleteAuditAlarmW")]
    public static delegate*<ushort*, void*, BOOL, BOOL> ObjectDeleteAuditAlarm => &ObjectDeleteAuditAlarmW;

    [NativeTypeName("#define ObjectOpenAuditAlarm ObjectOpenAuditAlarmW")]
    public static delegate*<ushort*, void*, ushort*, ushort*, void*, HANDLE, uint, uint, PRIVILEGE_SET*, BOOL, BOOL, BOOL*, BOOL> ObjectOpenAuditAlarm => &ObjectOpenAuditAlarmW;

    [NativeTypeName("#define ObjectPrivilegeAuditAlarm ObjectPrivilegeAuditAlarmW")]
    public static delegate*<ushort*, void*, HANDLE, uint, PRIVILEGE_SET*, BOOL, BOOL> ObjectPrivilegeAuditAlarm => &ObjectPrivilegeAuditAlarmW;

    [NativeTypeName("#define PrivilegedServiceAuditAlarm PrivilegedServiceAuditAlarmW")]
    public static delegate*<ushort*, ushort*, HANDLE, PRIVILEGE_SET*, BOOL, BOOL> PrivilegedServiceAuditAlarm => &PrivilegedServiceAuditAlarmW;

    [NativeTypeName("#define SetFileSecurity SetFileSecurityW")]
    public static delegate*<ushort*, uint, void*, BOOL> SetFileSecurity => &SetFileSecurityW;
}
