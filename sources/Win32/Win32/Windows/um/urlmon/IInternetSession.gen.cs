// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9E7-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetSession : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetSession : IInternetSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetSession));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetSession, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInternetSession, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetSession, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterNameSpace(
        IClassFactory pCF,
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LPCWSTR")] ushort* pwzProtocol,
        [NativeTypeName("ULONG")] uint cPatterns,
        [NativeTypeName("const LPCWSTR *")] ushort** ppwzPatterns,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<
                IInternetSession,
                IClassFactory,
                Guid*,
                ushort*,
                uint,
                ushort**,
                uint,
                int>)((*lpVtbl)[3])
        )(this, pCF, rclsid, pwzProtocol, cPatterns, ppwzPatterns, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterNameSpace(
        IClassFactory pCF,
        [NativeTypeName("LPCWSTR")] ushort* pszProtocol
    )
    {
        return ((delegate* unmanaged<IInternetSession, IClassFactory, ushort*, int>)((*lpVtbl)[4]))(
            this,
            pCF,
            pszProtocol
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterMimeFilter(
        IClassFactory pCF,
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LPCWSTR")] ushort* pwzType
    )
    {
        return (
            (delegate* unmanaged<IInternetSession, IClassFactory, Guid*, ushort*, int>)(
                (*lpVtbl)[5]
            )
        )(this, pCF, rclsid, pwzType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnregisterMimeFilter(
        IClassFactory pCF,
        [NativeTypeName("LPCWSTR")] ushort* pwzType
    )
    {
        return ((delegate* unmanaged<IInternetSession, IClassFactory, ushort*, int>)((*lpVtbl)[6]))(
            this,
            pCF,
            pwzType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateBinding(
        [NativeTypeName("LPBC")] IBindCtx pBC,
        [NativeTypeName("LPCWSTR")] ushort* szUrl,
        IUnknown pUnkOuter,
        IUnknown* ppUnk,
        IInternetProtocol* ppOInetProt,
        [NativeTypeName("DWORD")] uint dwOption
    )
    {
        return (
            (delegate* unmanaged<
                IInternetSession,
                IBindCtx,
                ushort*,
                IUnknown,
                IUnknown*,
                IInternetProtocol*,
                uint,
                int>)((*lpVtbl)[7])
        )(this, pBC, szUrl, pUnkOuter, ppUnk, ppOInetProt, dwOption);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSessionOption(
        [NativeTypeName("DWORD")] uint dwOption,
        [NativeTypeName("LPVOID")] void* pBuffer,
        [NativeTypeName("DWORD")] uint dwBufferLength,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<IInternetSession, uint, void*, uint, uint, int>)((*lpVtbl)[8])
        )(this, dwOption, pBuffer, dwBufferLength, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSessionOption(
        [NativeTypeName("DWORD")] uint dwOption,
        [NativeTypeName("LPVOID")] void* pBuffer,
        [NativeTypeName("DWORD *")] uint* pdwBufferLength,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<IInternetSession, uint, void*, uint*, uint, int>)((*lpVtbl)[9])
        )(this, dwOption, pBuffer, pdwBufferLength, dwReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterNameSpace(
            IClassFactory pCF,
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LPCWSTR")] ushort* pwzProtocol,
            [NativeTypeName("ULONG")] uint cPatterns,
            [NativeTypeName("const LPCWSTR *")] ushort** ppwzPatterns,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(4)]
        HRESULT UnregisterNameSpace(
            IClassFactory pCF,
            [NativeTypeName("LPCWSTR")] ushort* pszProtocol
        );

        [VtblIndex(5)]
        HRESULT RegisterMimeFilter(
            IClassFactory pCF,
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LPCWSTR")] ushort* pwzType
        );

        [VtblIndex(6)]
        HRESULT UnregisterMimeFilter(
            IClassFactory pCF,
            [NativeTypeName("LPCWSTR")] ushort* pwzType
        );

        [VtblIndex(7)]
        HRESULT CreateBinding(
            [NativeTypeName("LPBC")] IBindCtx pBC,
            [NativeTypeName("LPCWSTR")] ushort* szUrl,
            IUnknown pUnkOuter,
            IUnknown* ppUnk,
            IInternetProtocol* ppOInetProt,
            [NativeTypeName("DWORD")] uint dwOption
        );

        [VtblIndex(8)]
        HRESULT SetSessionOption(
            [NativeTypeName("DWORD")] uint dwOption,
            [NativeTypeName("LPVOID")] void* pBuffer,
            [NativeTypeName("DWORD")] uint dwBufferLength,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(9)]
        HRESULT GetSessionOption(
            [NativeTypeName("DWORD")] uint dwOption,
            [NativeTypeName("LPVOID")] void* pBuffer,
            [NativeTypeName("DWORD *")] uint* pdwBufferLength,
            [NativeTypeName("DWORD")] uint dwReserved
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

        [NativeTypeName(
            "HRESULT (IClassFactory *, const IID &, LPCWSTR, ULONG, const LPCWSTR *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IClassFactory,
            Guid*,
            ushort*,
            uint,
            ushort**,
            uint,
            int> RegisterNameSpace;

        [NativeTypeName("HRESULT (IClassFactory *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IClassFactory, ushort*, int> UnregisterNameSpace;

        [NativeTypeName("HRESULT (IClassFactory *, const IID &, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IClassFactory, Guid*, ushort*, int> RegisterMimeFilter;

        [NativeTypeName("HRESULT (IClassFactory *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IClassFactory, ushort*, int> UnregisterMimeFilter;

        [NativeTypeName(
            "HRESULT (LPBC, LPCWSTR, IUnknown *, IUnknown **, IInternetProtocol **, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBindCtx,
            ushort*,
            IUnknown,
            IUnknown*,
            IInternetProtocol*,
            uint,
            int> CreateBinding;

        [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, uint, int> SetSessionOption;

        [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint*, uint, int> GetSessionOption;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInternetSession"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInternetSession(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInternetSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInternetSession(Silk.NET.Windows.IUnknown value)
    {
        return new IInternetSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetSession"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInternetSession value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
