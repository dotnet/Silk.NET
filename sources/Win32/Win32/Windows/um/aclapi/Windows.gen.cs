// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AclAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetEntriesInAclA(
        [NativeTypeName("ULONG")] uint cCountOfExplicitEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_A")] EXPLICIT_ACCESS_A* pListOfExplicitEntries,
        [NativeTypeName("PACL")] ACL* OldAcl,
        [NativeTypeName("PACL *")] ACL** NewAcl
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetEntriesInAclW(
        [NativeTypeName("ULONG")] uint cCountOfExplicitEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_W")] EXPLICIT_ACCESS_W* pListOfExplicitEntries,
        [NativeTypeName("PACL")] ACL* OldAcl,
        [NativeTypeName("PACL *")] ACL** NewAcl
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetExplicitEntriesFromAclA(
        [NativeTypeName("PACL")] ACL* pacl,
        [NativeTypeName("PULONG")] uint* pcCountOfExplicitEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_A *")] EXPLICIT_ACCESS_A** pListOfExplicitEntries
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetExplicitEntriesFromAclW(
        [NativeTypeName("PACL")] ACL* pacl,
        [NativeTypeName("PULONG")] uint* pcCountOfExplicitEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_W *")] EXPLICIT_ACCESS_W** pListOfExplicitEntries
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetEffectiveRightsFromAclA(
        [NativeTypeName("PACL")] ACL* pacl,
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee,
        [NativeTypeName("PACCESS_MASK")] uint* pAccessRights
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetEffectiveRightsFromAclW(
        [NativeTypeName("PACL")] ACL* pacl,
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee,
        [NativeTypeName("PACCESS_MASK")] uint* pAccessRights
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetAuditedPermissionsFromAclA(
        [NativeTypeName("PACL")] ACL* pacl,
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee,
        [NativeTypeName("PACCESS_MASK")] uint* pSuccessfulAuditedRights,
        [NativeTypeName("PACCESS_MASK")] uint* pFailedAuditRights
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetAuditedPermissionsFromAclW(
        [NativeTypeName("PACL")] ACL* pacl,
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee,
        [NativeTypeName("PACCESS_MASK")] uint* pSuccessfulAuditedRights,
        [NativeTypeName("PACCESS_MASK")] uint* pFailedAuditRights
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetNamedSecurityInfoA(
        [NativeTypeName("LPCSTR")] sbyte* pObjectName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        [NativeTypeName("PSID *")] void** ppsidOwner,
        [NativeTypeName("PSID *")] void** ppsidGroup,
        [NativeTypeName("PACL *")] ACL** ppDacl,
        [NativeTypeName("PACL *")] ACL** ppSacl,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ppSecurityDescriptor
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetNamedSecurityInfoW(
        [NativeTypeName("LPCWSTR")] ushort* pObjectName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        [NativeTypeName("PSID *")] void** ppsidOwner,
        [NativeTypeName("PSID *")] void** ppsidGroup,
        [NativeTypeName("PACL *")] ACL** ppDacl,
        [NativeTypeName("PACL *")] ACL** ppSacl,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ppSecurityDescriptor
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetSecurityInfo(
        HANDLE handle,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        [NativeTypeName("PSID *")] void** ppsidOwner,
        [NativeTypeName("PSID *")] void** ppsidGroup,
        [NativeTypeName("PACL *")] ACL** ppDacl,
        [NativeTypeName("PACL *")] ACL** ppSacl,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ppSecurityDescriptor
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetNamedSecurityInfoA(
        [NativeTypeName("LPSTR")] sbyte* pObjectName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        [NativeTypeName("PSID")] void* psidOwner,
        [NativeTypeName("PSID")] void* psidGroup,
        [NativeTypeName("PACL")] ACL* pDacl,
        [NativeTypeName("PACL")] ACL* pSacl
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetNamedSecurityInfoW(
        [NativeTypeName("LPWSTR")] ushort* pObjectName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        [NativeTypeName("PSID")] void* psidOwner,
        [NativeTypeName("PSID")] void* psidGroup,
        [NativeTypeName("PACL")] ACL* pDacl,
        [NativeTypeName("PACL")] ACL* pSacl
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetSecurityInfo(
        HANDLE handle,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        [NativeTypeName("PSID")] void* psidOwner,
        [NativeTypeName("PSID")] void* psidGroup,
        [NativeTypeName("PACL")] ACL* pDacl,
        [NativeTypeName("PACL")] ACL* pSacl
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetInheritanceSourceA(
        [NativeTypeName("LPSTR")] sbyte* pObjectName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        BOOL Container,
        Guid** pObjectClassGuids,
        [NativeTypeName("DWORD")] uint GuidCount,
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("PFN_OBJECT_MGR_FUNCTS")] FN_OBJECT_MGR_FUNCTS* pfnArray,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* pGenericMapping,
        [NativeTypeName("PINHERITED_FROMA")] INHERITED_FROMA* pInheritArray
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetInheritanceSourceW(
        [NativeTypeName("LPWSTR")] ushort* pObjectName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        BOOL Container,
        Guid** pObjectClassGuids,
        [NativeTypeName("DWORD")] uint GuidCount,
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("PFN_OBJECT_MGR_FUNCTS")] FN_OBJECT_MGR_FUNCTS* pfnArray,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* pGenericMapping,
        [NativeTypeName("PINHERITED_FROMW")] INHERITED_FROMW* pInheritArray
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint FreeInheritedFromArray(
        [NativeTypeName("PINHERITED_FROMW")] INHERITED_FROMW* pInheritArray,
        ushort AceCnt,
        [NativeTypeName("PFN_OBJECT_MGR_FUNCTS")] FN_OBJECT_MGR_FUNCTS* pfnArray
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint TreeResetNamedSecurityInfoA(
        [NativeTypeName("LPSTR")] sbyte* pObjectName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        [NativeTypeName("PSID")] void* pOwner,
        [NativeTypeName("PSID")] void* pGroup,
        [NativeTypeName("PACL")] ACL* pDacl,
        [NativeTypeName("PACL")] ACL* pSacl,
        BOOL KeepExplicit,
        [NativeTypeName("FN_PROGRESS")]
            delegate* unmanaged<ushort*, uint, PROG_INVOKE_SETTING*, void*, BOOL, void> fnProgress,
        PROG_INVOKE_SETTING ProgressInvokeSetting,
        [NativeTypeName("PVOID")] void* Args
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint TreeResetNamedSecurityInfoW(
        [NativeTypeName("LPWSTR")] ushort* pObjectName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        [NativeTypeName("PSID")] void* pOwner,
        [NativeTypeName("PSID")] void* pGroup,
        [NativeTypeName("PACL")] ACL* pDacl,
        [NativeTypeName("PACL")] ACL* pSacl,
        BOOL KeepExplicit,
        [NativeTypeName("FN_PROGRESS")]
            delegate* unmanaged<ushort*, uint, PROG_INVOKE_SETTING*, void*, BOOL, void> fnProgress,
        PROG_INVOKE_SETTING ProgressInvokeSetting,
        [NativeTypeName("PVOID")] void* Args
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint TreeSetNamedSecurityInfoA(
        [NativeTypeName("LPSTR")] sbyte* pObjectName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        [NativeTypeName("PSID")] void* pOwner,
        [NativeTypeName("PSID")] void* pGroup,
        [NativeTypeName("PACL")] ACL* pDacl,
        [NativeTypeName("PACL")] ACL* pSacl,
        [NativeTypeName("DWORD")] uint dwAction,
        [NativeTypeName("FN_PROGRESS")]
            delegate* unmanaged<ushort*, uint, PROG_INVOKE_SETTING*, void*, BOOL, void> fnProgress,
        PROG_INVOKE_SETTING ProgressInvokeSetting,
        [NativeTypeName("PVOID")] void* Args
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint TreeSetNamedSecurityInfoW(
        [NativeTypeName("LPWSTR")] ushort* pObjectName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInfo,
        [NativeTypeName("PSID")] void* pOwner,
        [NativeTypeName("PSID")] void* pGroup,
        [NativeTypeName("PACL")] ACL* pDacl,
        [NativeTypeName("PACL")] ACL* pSacl,
        [NativeTypeName("DWORD")] uint dwAction,
        [NativeTypeName("FN_PROGRESS")]
            delegate* unmanaged<ushort*, uint, PROG_INVOKE_SETTING*, void*, BOOL, void> fnProgress,
        PROG_INVOKE_SETTING ProgressInvokeSetting,
        [NativeTypeName("PVOID")] void* Args
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint BuildSecurityDescriptorA(
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pOwner,
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pGroup,
        [NativeTypeName("ULONG")] uint cCountOfAccessEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_A")] EXPLICIT_ACCESS_A* pListOfAccessEntries,
        [NativeTypeName("ULONG")] uint cCountOfAuditEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_A")] EXPLICIT_ACCESS_A* pListOfAuditEntries,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pOldSD,
        [NativeTypeName("PULONG")] uint* pSizeNewSD,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** pNewSD
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint BuildSecurityDescriptorW(
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pOwner,
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pGroup,
        [NativeTypeName("ULONG")] uint cCountOfAccessEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_W")] EXPLICIT_ACCESS_W* pListOfAccessEntries,
        [NativeTypeName("ULONG")] uint cCountOfAuditEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_W")] EXPLICIT_ACCESS_W* pListOfAuditEntries,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pOldSD,
        [NativeTypeName("PULONG")] uint* pSizeNewSD,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** pNewSD
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint LookupSecurityDescriptorPartsA(
        [NativeTypeName("PTRUSTEE_A *")] TRUSTEE_A** ppOwner,
        [NativeTypeName("PTRUSTEE_A *")] TRUSTEE_A** ppGroup,
        [NativeTypeName("PULONG")] uint* pcCountOfAccessEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_A *")] EXPLICIT_ACCESS_A** ppListOfAccessEntries,
        [NativeTypeName("PULONG")] uint* pcCountOfAuditEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_A *")] EXPLICIT_ACCESS_A** ppListOfAuditEntries,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSD
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint LookupSecurityDescriptorPartsW(
        [NativeTypeName("PTRUSTEE_W *")] TRUSTEE_W** ppOwner,
        [NativeTypeName("PTRUSTEE_W *")] TRUSTEE_W** ppGroup,
        [NativeTypeName("PULONG")] uint* pcCountOfAccessEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_W *")] EXPLICIT_ACCESS_W** ppListOfAccessEntries,
        [NativeTypeName("PULONG")] uint* pcCountOfAuditEntries,
        [NativeTypeName("PEXPLICIT_ACCESS_W *")] EXPLICIT_ACCESS_W** ppListOfAuditEntries,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSD
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildExplicitAccessWithNameA(
        [NativeTypeName("PEXPLICIT_ACCESS_A")] EXPLICIT_ACCESS_A* pExplicitAccess,
        [NativeTypeName("LPSTR")] sbyte* pTrusteeName,
        [NativeTypeName("DWORD")] uint AccessPermissions,
        ACCESS_MODE AccessMode,
        [NativeTypeName("DWORD")] uint Inheritance
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildExplicitAccessWithNameW(
        [NativeTypeName("PEXPLICIT_ACCESS_W")] EXPLICIT_ACCESS_W* pExplicitAccess,
        [NativeTypeName("LPWSTR")] ushort* pTrusteeName,
        [NativeTypeName("DWORD")] uint AccessPermissions,
        ACCESS_MODE AccessMode,
        [NativeTypeName("DWORD")] uint Inheritance
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildImpersonateExplicitAccessWithNameA(
        [NativeTypeName("PEXPLICIT_ACCESS_A")] EXPLICIT_ACCESS_A* pExplicitAccess,
        [NativeTypeName("LPSTR")] sbyte* pTrusteeName,
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee,
        [NativeTypeName("DWORD")] uint AccessPermissions,
        ACCESS_MODE AccessMode,
        [NativeTypeName("DWORD")] uint Inheritance
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildImpersonateExplicitAccessWithNameW(
        [NativeTypeName("PEXPLICIT_ACCESS_W")] EXPLICIT_ACCESS_W* pExplicitAccess,
        [NativeTypeName("LPWSTR")] ushort* pTrusteeName,
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee,
        [NativeTypeName("DWORD")] uint AccessPermissions,
        ACCESS_MODE AccessMode,
        [NativeTypeName("DWORD")] uint Inheritance
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildTrusteeWithNameA(
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee,
        [NativeTypeName("LPSTR")] sbyte* pName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildTrusteeWithNameW(
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee,
        [NativeTypeName("LPWSTR")] ushort* pName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildImpersonateTrusteeA(
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee,
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pImpersonateTrustee
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildImpersonateTrusteeW(
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee,
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pImpersonateTrustee
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildTrusteeWithSidA(
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee,
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildTrusteeWithSidW(
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee,
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildTrusteeWithObjectsAndSidA(
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee,
        [NativeTypeName("POBJECTS_AND_SID")] OBJECTS_AND_SID* pObjSid,
        Guid* pObjectGuid,
        Guid* pInheritedObjectGuid,
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildTrusteeWithObjectsAndSidW(
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee,
        [NativeTypeName("POBJECTS_AND_SID")] OBJECTS_AND_SID* pObjSid,
        Guid* pObjectGuid,
        Guid* pInheritedObjectGuid,
        [NativeTypeName("PSID")] void* pSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildTrusteeWithObjectsAndNameA(
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee,
        [NativeTypeName("POBJECTS_AND_NAME_A")] OBJECTS_AND_NAME_A* pObjName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("LPSTR")] sbyte* ObjectTypeName,
        [NativeTypeName("LPSTR")] sbyte* InheritedObjectTypeName,
        [NativeTypeName("LPSTR")] sbyte* Name
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void BuildTrusteeWithObjectsAndNameW(
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee,
        [NativeTypeName("POBJECTS_AND_NAME_W")] OBJECTS_AND_NAME_W* pObjName,
        SE_OBJECT_TYPE ObjectType,
        [NativeTypeName("LPWSTR")] ushort* ObjectTypeName,
        [NativeTypeName("LPWSTR")] ushort* InheritedObjectTypeName,
        [NativeTypeName("LPWSTR")] ushort* Name
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* GetTrusteeNameA([NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* GetTrusteeNameW(
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern TRUSTEE_TYPE GetTrusteeTypeA(
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern TRUSTEE_TYPE GetTrusteeTypeW(
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern TRUSTEE_FORM GetTrusteeFormA(
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern TRUSTEE_FORM GetTrusteeFormW(
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern MULTIPLE_TRUSTEE_OPERATION GetMultipleTrusteeOperationA(
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern MULTIPLE_TRUSTEE_OPERATION GetMultipleTrusteeOperationW(
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("PTRUSTEE_A")]
    public static extern TRUSTEE_A* GetMultipleTrusteeA(
        [NativeTypeName("PTRUSTEE_A")] TRUSTEE_A* pTrustee
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("PTRUSTEE_W")]
    public static extern TRUSTEE_W* GetMultipleTrusteeW(
        [NativeTypeName("PTRUSTEE_W")] TRUSTEE_W* pTrustee
    );

    [NativeTypeName("#define SetEntriesInAcl SetEntriesInAclW")]
    public static delegate* <uint, EXPLICIT_ACCESS_W*, ACL*, ACL**, uint> SetEntriesInAcl =>
        &SetEntriesInAclW;

    [NativeTypeName("#define GetExplicitEntriesFromAcl GetExplicitEntriesFromAclW")]
    public static delegate* <ACL*, uint*, EXPLICIT_ACCESS_W**, uint> GetExplicitEntriesFromAcl =>
        &GetExplicitEntriesFromAclW;

    [NativeTypeName("#define GetEffectiveRightsFromAcl GetEffectiveRightsFromAclW")]
    public static delegate* <ACL*, TRUSTEE_W*, uint*, uint> GetEffectiveRightsFromAcl =>
        &GetEffectiveRightsFromAclW;

    [NativeTypeName("#define GetAuditedPermissionsFromAcl GetAuditedPermissionsFromAclW")]
    public static delegate* <ACL*, TRUSTEE_W*, uint*, uint*, uint> GetAuditedPermissionsFromAcl =>
        &GetAuditedPermissionsFromAclW;

    [NativeTypeName("#define GetNamedSecurityInfo GetNamedSecurityInfoW")]
    public static delegate* <
        ushort*,
        SE_OBJECT_TYPE,
        uint,
        void**,
        void**,
        ACL**,
        ACL**,
        void**,
        uint> GetNamedSecurityInfo => &GetNamedSecurityInfoW;

    [NativeTypeName("#define SetNamedSecurityInfo SetNamedSecurityInfoW")]
    public static delegate* <
        ushort*,
        SE_OBJECT_TYPE,
        uint,
        void*,
        void*,
        ACL*,
        ACL*,
        uint> SetNamedSecurityInfo => &SetNamedSecurityInfoW;

    [NativeTypeName("#define GetInheritanceSource GetInheritanceSourceW")]
    public static delegate* <
        ushort*,
        SE_OBJECT_TYPE,
        uint,
        BOOL,
        Guid**,
        uint,
        ACL*,
        FN_OBJECT_MGR_FUNCTS*,
        GENERIC_MAPPING*,
        INHERITED_FROMW*,
        uint> GetInheritanceSource => &GetInheritanceSourceW;

    [NativeTypeName("#define TreeResetNamedSecurityInfo TreeResetNamedSecurityInfoW")]
    public static delegate* <
        ushort*,
        SE_OBJECT_TYPE,
        uint,
        void*,
        void*,
        ACL*,
        ACL*,
        BOOL,
        delegate* unmanaged<ushort*, uint, PROG_INVOKE_SETTING*, void*, BOOL, void>,
        PROG_INVOKE_SETTING,
        void*,
        uint> TreeResetNamedSecurityInfo => &TreeResetNamedSecurityInfoW;

    [NativeTypeName("#define TreeSetNamedSecurityInfo TreeSetNamedSecurityInfoW")]
    public static delegate* <
        ushort*,
        SE_OBJECT_TYPE,
        uint,
        void*,
        void*,
        ACL*,
        ACL*,
        uint,
        delegate* unmanaged<ushort*, uint, PROG_INVOKE_SETTING*, void*, BOOL, void>,
        PROG_INVOKE_SETTING,
        void*,
        uint> TreeSetNamedSecurityInfo => &TreeSetNamedSecurityInfoW;

    [NativeTypeName("#define BuildSecurityDescriptor BuildSecurityDescriptorW")]
    public static delegate* <
        TRUSTEE_W*,
        TRUSTEE_W*,
        uint,
        EXPLICIT_ACCESS_W*,
        uint,
        EXPLICIT_ACCESS_W*,
        void*,
        uint*,
        void**,
        uint> BuildSecurityDescriptor => &BuildSecurityDescriptorW;

    [NativeTypeName("#define LookupSecurityDescriptorParts LookupSecurityDescriptorPartsW")]
    public static delegate* <
        TRUSTEE_W**,
        TRUSTEE_W**,
        uint*,
        EXPLICIT_ACCESS_W**,
        uint*,
        EXPLICIT_ACCESS_W**,
        void*,
        uint> LookupSecurityDescriptorParts => &LookupSecurityDescriptorPartsW;

    [NativeTypeName("#define BuildExplicitAccessWithName BuildExplicitAccessWithNameW")]
    public static delegate* <
        EXPLICIT_ACCESS_W*,
        ushort*,
        uint,
        ACCESS_MODE,
        uint,
        void> BuildExplicitAccessWithName => &BuildExplicitAccessWithNameW;

    [NativeTypeName(
        "#define BuildImpersonateExplicitAccessWithName BuildImpersonateExplicitAccessWithNameW"
    )]
    public static delegate* <
        EXPLICIT_ACCESS_W*,
        ushort*,
        TRUSTEE_W*,
        uint,
        ACCESS_MODE,
        uint,
        void> BuildImpersonateExplicitAccessWithName => &BuildImpersonateExplicitAccessWithNameW;

    [NativeTypeName("#define BuildTrusteeWithName BuildTrusteeWithNameW")]
    public static delegate* <TRUSTEE_W*, ushort*, void> BuildTrusteeWithName =>
        &BuildTrusteeWithNameW;

    [NativeTypeName("#define BuildImpersonateTrustee BuildImpersonateTrusteeW")]
    public static delegate* <TRUSTEE_W*, TRUSTEE_W*, void> BuildImpersonateTrustee =>
        &BuildImpersonateTrusteeW;

    [NativeTypeName("#define BuildTrusteeWithSid BuildTrusteeWithSidW")]
    public static delegate* <TRUSTEE_W*, void*, void> BuildTrusteeWithSid => &BuildTrusteeWithSidW;

    [NativeTypeName("#define BuildTrusteeWithObjectsAndSid BuildTrusteeWithObjectsAndSidW")]
    public static delegate* <
        TRUSTEE_W*,
        OBJECTS_AND_SID*,
        Guid*,
        Guid*,
        void*,
        void> BuildTrusteeWithObjectsAndSid => &BuildTrusteeWithObjectsAndSidW;

    [NativeTypeName("#define BuildTrusteeWithObjectsAndName BuildTrusteeWithObjectsAndNameW")]
    public static delegate* <
        TRUSTEE_W*,
        OBJECTS_AND_NAME_W*,
        SE_OBJECT_TYPE,
        ushort*,
        ushort*,
        ushort*,
        void> BuildTrusteeWithObjectsAndName => &BuildTrusteeWithObjectsAndNameW;

    [NativeTypeName("#define GetTrusteeName GetTrusteeNameW")]
    public static delegate* <TRUSTEE_W*, ushort*> GetTrusteeName => &GetTrusteeNameW;

    [NativeTypeName("#define GetTrusteeType GetTrusteeTypeW")]
    public static delegate* <TRUSTEE_W*, TRUSTEE_TYPE> GetTrusteeType => &GetTrusteeTypeW;

    [NativeTypeName("#define GetTrusteeForm GetTrusteeFormW")]
    public static delegate* <TRUSTEE_W*, TRUSTEE_FORM> GetTrusteeForm => &GetTrusteeFormW;

    [NativeTypeName("#define GetMultipleTrusteeOperation GetMultipleTrusteeOperationW")]
    public static delegate* <TRUSTEE_W*, MULTIPLE_TRUSTEE_OPERATION> GetMultipleTrusteeOperation =>
        &GetMultipleTrusteeOperationW;

    [NativeTypeName("#define GetMultipleTrustee GetMultipleTrusteeW")]
    public static delegate* <TRUSTEE_W*, TRUSTEE_W*> GetMultipleTrustee => &GetMultipleTrusteeW;
}
