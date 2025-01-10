// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("sechost", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaLookupOpenLocalPolicy(
        [NativeTypeName("PLSA_OBJECT_ATTRIBUTES")] LSA_OBJECT_ATTRIBUTES* ObjectAttributes,
        [NativeTypeName("ACCESS_MASK")] uint AccessMask,
        [NativeTypeName("PLSA_LOOKUP_HANDLE")] void** PolicyHandle
    );

    [DllImport("sechost", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaLookupClose(
        [NativeTypeName("LSA_LOOKUP_HANDLE")] void* ObjectHandle
    );

    [DllImport("sechost", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaLookupTranslateSids(
        [NativeTypeName("LSA_LOOKUP_HANDLE")] void* PolicyHandle,
        [NativeTypeName("ULONG")] uint Count,
        [NativeTypeName("PSID *")] void** Sids,
        [NativeTypeName("PLSA_REFERENCED_DOMAIN_LIST *")]
            LSA_REFERENCED_DOMAIN_LIST** ReferencedDomains,
        [NativeTypeName("PLSA_TRANSLATED_NAME *")] LSA_TRANSLATED_NAME** Names
    );

    [DllImport("sechost", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaLookupTranslateNames(
        [NativeTypeName("LSA_LOOKUP_HANDLE")] void* PolicyHandle,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("ULONG")] uint Count,
        [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* Names,
        [NativeTypeName("PLSA_REFERENCED_DOMAIN_LIST *")]
            LSA_REFERENCED_DOMAIN_LIST** ReferencedDomains,
        [NativeTypeName("PLSA_TRANSLATED_SID2 *")] LSA_TRANSLATED_SID2** Sids
    );

    [DllImport("sechost", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaLookupGetDomainInfo(
        [NativeTypeName("LSA_LOOKUP_HANDLE")] void* PolicyHandle,
        LSA_LOOKUP_DOMAIN_INFO_CLASS DomainInfoClass,
        [NativeTypeName("PVOID *")] void** DomainInfo
    );

    [DllImport("sechost", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaLookupFreeMemory([NativeTypeName("PVOID")] void* Buffer);

    [NativeTypeName("#define LOOKUP_VIEW_LOCAL_INFORMATION 0x00000001")]
    public const int LOOKUP_VIEW_LOCAL_INFORMATION = 0x00000001;

    [NativeTypeName("#define LOOKUP_TRANSLATE_NAMES 0x00000800")]
    public const int LOOKUP_TRANSLATE_NAMES = 0x00000800;
}
