// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8059E6F8-10CE-4D61-B47E-5A1D8D9A8B67")]
public unsafe partial struct IHttpUser : IHttpUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpUser));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetRemoteUserName()
    {
        return ((delegate* unmanaged<IHttpUser*, ushort*>)((*lpVtbl)[0]))(
            (IHttpUser*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetUserNameW()
    {
        return ((delegate* unmanaged<IHttpUser*, ushort*>)((*lpVtbl)[1]))(
            (IHttpUser*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetAuthenticationType()
    {
        return ((delegate* unmanaged<IHttpUser*, ushort*>)((*lpVtbl)[2]))(
            (IHttpUser*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetPassword()
    {
        return ((delegate* unmanaged<IHttpUser*, ushort*>)((*lpVtbl)[3]))(
            (IHttpUser*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HANDLE GetImpersonationToken()
    {
        return (
            (HANDLE)(
                ((delegate* unmanaged<IHttpUser*, void*>)((*lpVtbl)[4]))(
                    (IHttpUser*)Unsafe.AsPointer(ref this)
                )
            )
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HANDLE GetPrimaryToken()
    {
        return (
            (HANDLE)(
                ((delegate* unmanaged<IHttpUser*, void*>)((*lpVtbl)[5]))(
                    (IHttpUser*)Unsafe.AsPointer(ref this)
                )
            )
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void ReferenceUser()
    {
        ((delegate* unmanaged<IHttpUser*, void>)((*lpVtbl)[6]))(
            (IHttpUser*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void DereferenceUser()
    {
        ((delegate* unmanaged<IHttpUser*, void>)((*lpVtbl)[7]))(
            (IHttpUser*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public BOOL SupportsIsInRole()
    {
        return ((delegate* unmanaged<IHttpUser*, int>)((*lpVtbl)[8]))(
            (IHttpUser*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsInRole([NativeTypeName("PCWSTR")] ushort* pszRoleName, BOOL* pfInRole)
    {
        return ((delegate* unmanaged<IHttpUser*, ushort*, BOOL*, int>)((*lpVtbl)[9]))(
            (IHttpUser*)Unsafe.AsPointer(ref this),
            pszRoleName,
            pfInRole
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("PVOID")]
    public void* GetUserVariable([NativeTypeName("PCSTR")] sbyte* pszVariableName)
    {
        return ((delegate* unmanaged<IHttpUser*, sbyte*, void*>)((*lpVtbl)[10]))(
            (IHttpUser*)Unsafe.AsPointer(ref this),
            pszVariableName
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetRemoteUserName();

        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetUserNameW();

        [VtblIndex(2)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetAuthenticationType();

        [VtblIndex(3)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetPassword();

        [VtblIndex(4)]
        HANDLE GetImpersonationToken();

        [VtblIndex(5)]
        HANDLE GetPrimaryToken();

        [VtblIndex(6)]
        void ReferenceUser();

        [VtblIndex(7)]
        void DereferenceUser();

        [VtblIndex(8)]
        BOOL SupportsIsInRole();

        [VtblIndex(9)]
        HRESULT IsInRole([NativeTypeName("PCWSTR")] ushort* pszRoleName, BOOL* pfInRole);

        [VtblIndex(10)]
        [return: NativeTypeName("PVOID")]
        void* GetUserVariable([NativeTypeName("PCSTR")] sbyte* pszVariableName);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("PCWSTR ()")]
        public delegate* unmanaged<TSelf*, ushort*> GetRemoteUserName;

        [NativeTypeName("PCWSTR ()")]
        public delegate* unmanaged<TSelf*, ushort*> GetUserNameW;

        [NativeTypeName("PCWSTR ()")]
        public delegate* unmanaged<TSelf*, ushort*> GetAuthenticationType;

        [NativeTypeName("PCWSTR ()")]
        public delegate* unmanaged<TSelf*, ushort*> GetPassword;

        [NativeTypeName("HANDLE ()")]
        public delegate* unmanaged<TSelf*, void*> GetImpersonationToken;

        [NativeTypeName("HANDLE ()")]
        public delegate* unmanaged<TSelf*, void*> GetPrimaryToken;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> ReferenceUser;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> DereferenceUser;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged<TSelf*, int> SupportsIsInRole;

        [NativeTypeName("HRESULT (PCWSTR, BOOL *)")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, int> IsInRole;

        [NativeTypeName("PVOID (PCSTR)")]
        public delegate* unmanaged<TSelf*, sbyte*, void*> GetUserVariable;
    }
}
