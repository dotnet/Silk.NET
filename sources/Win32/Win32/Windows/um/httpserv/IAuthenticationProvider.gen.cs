// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("304D51D0-0307-45ED-83FD-DD3FC032FDFC")]
[NativeTypeName("struct IAuthenticationProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IAuthenticationProvider
    : IAuthenticationProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAuthenticationProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged<IAuthenticationProvider*, HRESULT, void>)((*lpVtbl)[0]))(
            (IAuthenticationProvider*)Unsafe.AsPointer(ref this),
            hrError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void SetUser(IHttpUser* pUser)
    {
        ((delegate* unmanaged<IAuthenticationProvider*, IHttpUser*, void>)((*lpVtbl)[1]))(
            (IAuthenticationProvider*)Unsafe.AsPointer(ref this),
            pUser
        );
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        void SetUser(IHttpUser* pUser);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("void (IHttpUser *)")]
        public delegate* unmanaged<TSelf*, IHttpUser*, void> SetUser;
    }
}
