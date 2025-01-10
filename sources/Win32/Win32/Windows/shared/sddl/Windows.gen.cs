// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/sddl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertSidToStringSidA(
        [NativeTypeName("PSID")] void* Sid,
        [NativeTypeName("LPSTR *")] sbyte** StringSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertSidToStringSidW(
        [NativeTypeName("PSID")] void* Sid,
        [NativeTypeName("LPWSTR *")] ushort** StringSid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertStringSidToSidA(
        [NativeTypeName("LPCSTR")] sbyte* StringSid,
        [NativeTypeName("PSID *")] void** Sid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertStringSidToSidW(
        [NativeTypeName("LPCWSTR")] ushort* StringSid,
        [NativeTypeName("PSID *")] void** Sid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertStringSecurityDescriptorToSecurityDescriptorA(
        [NativeTypeName("LPCSTR")] sbyte* StringSecurityDescriptor,
        [NativeTypeName("DWORD")] uint StringSDRevision,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** SecurityDescriptor,
        [NativeTypeName("PULONG")] uint* SecurityDescriptorSize
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertStringSecurityDescriptorToSecurityDescriptorW(
        [NativeTypeName("LPCWSTR")] ushort* StringSecurityDescriptor,
        [NativeTypeName("DWORD")] uint StringSDRevision,
        [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** SecurityDescriptor,
        [NativeTypeName("PULONG")] uint* SecurityDescriptorSize
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertSecurityDescriptorToStringSecurityDescriptorA(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("DWORD")] uint RequestedStringSDRevision,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("LPSTR *")] sbyte** StringSecurityDescriptor,
        [NativeTypeName("PULONG")] uint* StringSecurityDescriptorLen
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertSecurityDescriptorToStringSecurityDescriptorW(
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("DWORD")] uint RequestedStringSDRevision,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("LPWSTR *")] ushort** StringSecurityDescriptor,
        [NativeTypeName("PULONG")] uint* StringSecurityDescriptorLen
    );

    [NativeTypeName("#define ConvertSidToStringSid ConvertSidToStringSidW")]
    public static delegate* <void*, ushort**, BOOL> ConvertSidToStringSid =>
        &ConvertSidToStringSidW;

    [NativeTypeName("#define ConvertStringSidToSid ConvertStringSidToSidW")]
    public static delegate* <ushort*, void**, BOOL> ConvertStringSidToSid =>
        &ConvertStringSidToSidW;

    [NativeTypeName(
        "#define ConvertStringSecurityDescriptorToSecurityDescriptor ConvertStringSecurityDescriptorToSecurityDescriptorW"
    )]
    public static delegate* <
        ushort*,
        uint,
        void**,
        uint*,
        BOOL> ConvertStringSecurityDescriptorToSecurityDescriptor =>
        &ConvertStringSecurityDescriptorToSecurityDescriptorW;

    [NativeTypeName(
        "#define ConvertSecurityDescriptorToStringSecurityDescriptor ConvertSecurityDescriptorToStringSecurityDescriptorW"
    )]
    public static delegate* <
        void*,
        uint,
        uint,
        ushort**,
        uint*,
        BOOL> ConvertSecurityDescriptorToStringSecurityDescriptor =>
        &ConvertSecurityDescriptorToStringSecurityDescriptorW;
}
