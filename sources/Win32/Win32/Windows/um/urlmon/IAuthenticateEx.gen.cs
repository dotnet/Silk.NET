// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2AD1EDAF-D83D-48B5-9ADF-03DBE19F53BD")]
[NativeTypeName("struct IAuthenticateEx : IAuthenticate")]
[NativeInheritance("IAuthenticate")]
public unsafe partial struct IAuthenticateEx : IAuthenticateEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAuthenticateEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAuthenticateEx, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAuthenticateEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAuthenticateEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Authenticate(
        HWND* phwnd,
        [NativeTypeName("LPWSTR *")] ushort** pszUsername,
        [NativeTypeName("LPWSTR *")] ushort** pszPassword
    )
    {
        return (
            (delegate* unmanaged<IAuthenticateEx, HWND*, ushort**, ushort**, int>)((*lpVtbl)[3])
        )(this, phwnd, pszUsername, pszPassword);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AuthenticateEx(
        HWND* phwnd,
        [NativeTypeName("LPWSTR *")] ushort** pszUsername,
        [NativeTypeName("LPWSTR *")] ushort** pszPassword,
        AUTHENTICATEINFO* pauthinfo
    )
    {
        return (
            (delegate* unmanaged<
                IAuthenticateEx,
                HWND*,
                ushort**,
                ushort**,
                AUTHENTICATEINFO*,
                int>)((*lpVtbl)[4])
        )(this, phwnd, pszUsername, pszPassword, pauthinfo);
    }

    public interface Interface : IAuthenticate.Interface
    {
        [VtblIndex(4)]
        HRESULT AuthenticateEx(
            HWND* phwnd,
            [NativeTypeName("LPWSTR *")] ushort** pszUsername,
            [NativeTypeName("LPWSTR *")] ushort** pszPassword,
            AUTHENTICATEINFO* pauthinfo
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (HWND *, LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, ushort**, ushort**, int> Authenticate;

        [NativeTypeName(
            "HRESULT (HWND *, LPWSTR *, LPWSTR *, AUTHENTICATEINFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND*,
            ushort**,
            ushort**,
            AUTHENTICATEINFO*,
            int> AuthenticateEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAuthenticateEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAuthenticateEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAuthenticate"/> to <see cref = "IAuthenticateEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAuthenticate"/> instance to be converted </param>
    public static explicit operator IAuthenticateEx(Silk.NET.Windows.IAuthenticate value)
    {
        return new IAuthenticateEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAuthenticateEx"/> to <see cref = "Silk.NET.Windows.IAuthenticate"/>.</summary>
    /// <param name = "value">The <see cref = "IAuthenticateEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAuthenticate(IAuthenticateEx value)
    {
        return new Silk.NET.Windows.IAuthenticate(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAuthenticateEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAuthenticateEx(Silk.NET.Windows.IUnknown value)
    {
        return new IAuthenticateEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAuthenticateEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAuthenticateEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAuthenticateEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
