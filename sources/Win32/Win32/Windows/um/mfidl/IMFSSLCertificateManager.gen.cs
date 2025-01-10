// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("61F7D887-1230-4A8B-AEBA-8AD434D1A64D")]
[NativeTypeName("struct IMFSSLCertificateManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSSLCertificateManager
    : IMFSSLCertificateManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSSLCertificateManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSSLCertificateManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSSLCertificateManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSSLCertificateManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClientCertificate(
        [NativeTypeName("LPCWSTR")] ushort* pszURL,
        byte** ppbData,
        [NativeTypeName("DWORD *")] uint* pcbData
    )
    {
        return (
            (delegate* unmanaged<IMFSSLCertificateManager, ushort*, byte**, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pszURL, ppbData, pcbData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginGetClientCertificate(
        [NativeTypeName("LPCWSTR")] ushort* pszURL,
        IMFAsyncCallback pCallback,
        IUnknown pState
    )
    {
        return (
            (delegate* unmanaged<
                IMFSSLCertificateManager,
                ushort*,
                IMFAsyncCallback,
                IUnknown,
                int>)((*lpVtbl)[4])
        )(this, pszURL, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetClientCertificate(
        IMFAsyncResult pResult,
        byte** ppbData,
        [NativeTypeName("DWORD *")] uint* pcbData
    )
    {
        return (
            (delegate* unmanaged<IMFSSLCertificateManager, IMFAsyncResult, byte**, uint*, int>)(
                (*lpVtbl)[5]
            )
        )(this, pResult, ppbData, pcbData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCertificatePolicy(
        [NativeTypeName("LPCWSTR")] ushort* pszURL,
        BOOL* pfOverrideAutomaticCheck,
        BOOL* pfClientCertificateAvailable
    )
    {
        return (
            (delegate* unmanaged<IMFSSLCertificateManager, ushort*, BOOL*, BOOL*, int>)(
                (*lpVtbl)[6]
            )
        )(this, pszURL, pfOverrideAutomaticCheck, pfClientCertificateAvailable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnServerCertificate(
        [NativeTypeName("LPCWSTR")] ushort* pszURL,
        byte* pbData,
        [NativeTypeName("DWORD")] uint cbData,
        BOOL* pfIsGood
    )
    {
        return (
            (delegate* unmanaged<IMFSSLCertificateManager, ushort*, byte*, uint, BOOL*, int>)(
                (*lpVtbl)[7]
            )
        )(this, pszURL, pbData, cbData, pfIsGood);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetClientCertificate(
            [NativeTypeName("LPCWSTR")] ushort* pszURL,
            byte** ppbData,
            [NativeTypeName("DWORD *")] uint* pcbData
        );

        [VtblIndex(4)]
        HRESULT BeginGetClientCertificate(
            [NativeTypeName("LPCWSTR")] ushort* pszURL,
            IMFAsyncCallback pCallback,
            IUnknown pState
        );

        [VtblIndex(5)]
        HRESULT EndGetClientCertificate(
            IMFAsyncResult pResult,
            byte** ppbData,
            [NativeTypeName("DWORD *")] uint* pcbData
        );

        [VtblIndex(6)]
        HRESULT GetCertificatePolicy(
            [NativeTypeName("LPCWSTR")] ushort* pszURL,
            BOOL* pfOverrideAutomaticCheck,
            BOOL* pfClientCertificateAvailable
        );

        [VtblIndex(7)]
        HRESULT OnServerCertificate(
            [NativeTypeName("LPCWSTR")] ushort* pszURL,
            byte* pbData,
            [NativeTypeName("DWORD")] uint cbData,
            BOOL* pfIsGood
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

        [NativeTypeName("HRESULT (LPCWSTR, BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, byte**, uint*, int> GetClientCertificate;

        [NativeTypeName(
            "HRESULT (LPCWSTR, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IMFAsyncCallback,
            IUnknown,
            int> BeginGetClientCertificate;

        [NativeTypeName("HRESULT (IMFAsyncResult *, BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncResult,
            byte**,
            uint*,
            int> EndGetClientCertificate;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, BOOL*, int> GetCertificatePolicy;

        [NativeTypeName("HRESULT (LPCWSTR, BYTE *, DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, byte*, uint, BOOL*, int> OnServerCertificate;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSSLCertificateManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSSLCertificateManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSSLCertificateManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSSLCertificateManager(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSSLCertificateManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSSLCertificateManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSSLCertificateManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSSLCertificateManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
