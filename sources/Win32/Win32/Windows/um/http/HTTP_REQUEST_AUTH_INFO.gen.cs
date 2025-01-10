// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct HTTP_REQUEST_AUTH_INFO
{
    public HTTP_AUTH_STATUS AuthStatus;

    [NativeTypeName("SECURITY_STATUS")]
    public int SecStatus;

    [NativeTypeName("ULONG")]
    public uint Flags;
    public HTTP_REQUEST_AUTH_TYPE AuthType;
    public HANDLE AccessToken;

    [NativeTypeName("ULONG")]
    public uint ContextAttributes;

    [NativeTypeName("ULONG")]
    public uint PackedContextLength;

    [NativeTypeName("ULONG")]
    public uint PackedContextType;

    [NativeTypeName("PVOID")]
    public void* PackedContext;

    [NativeTypeName("ULONG")]
    public uint MutualAuthDataLength;

    [NativeTypeName("PCHAR")]
    public sbyte* pMutualAuthData;
    public ushort PackageNameLength;

    [NativeTypeName("PWSTR")]
    public ushort* pPackageName;
}
