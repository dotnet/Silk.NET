// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("71FA9A2C-53CE-4662-A132-1A7E8CBF62DB")]
[NativeTypeName("struct IMFHttpDownloadSession : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFHttpDownloadSession : IMFHttpDownloadSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFHttpDownloadSession));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFHttpDownloadSession, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFHttpDownloadSession, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFHttpDownloadSession, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetServer(
        [NativeTypeName("LPCWSTR")] ushort* szServerName,
        [NativeTypeName("DWORD")] uint nPort
    )
    {
        return ((delegate* unmanaged<IMFHttpDownloadSession, ushort*, uint, int>)((*lpVtbl)[3]))(
            this,
            szServerName,
            nPort
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateRequest(
        [NativeTypeName("LPCWSTR")] ushort* szObjectName,
        BOOL fBypassProxyCache,
        BOOL fSecure,
        [NativeTypeName("LPCWSTR")] ushort* szVerb,
        [NativeTypeName("LPCWSTR")] ushort* szReferrer,
        IMFHttpDownloadRequest* ppRequest
    )
    {
        return (
            (delegate* unmanaged<
                IMFHttpDownloadSession,
                ushort*,
                BOOL,
                BOOL,
                ushort*,
                ushort*,
                IMFHttpDownloadRequest*,
                int>)((*lpVtbl)[4])
        )(this, szObjectName, fBypassProxyCache, fSecure, szVerb, szReferrer, ppRequest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IMFHttpDownloadSession, int>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetServer(
            [NativeTypeName("LPCWSTR")] ushort* szServerName,
            [NativeTypeName("DWORD")] uint nPort
        );

        [VtblIndex(4)]
        HRESULT CreateRequest(
            [NativeTypeName("LPCWSTR")] ushort* szObjectName,
            BOOL fBypassProxyCache,
            BOOL fSecure,
            [NativeTypeName("LPCWSTR")] ushort* szVerb,
            [NativeTypeName("LPCWSTR")] ushort* szReferrer,
            IMFHttpDownloadRequest* ppRequest
        );

        [VtblIndex(5)]
        HRESULT Close();
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

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetServer;

        [NativeTypeName(
            "HRESULT (LPCWSTR, BOOL, BOOL, LPCWSTR, LPCWSTR, IMFHttpDownloadRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            BOOL,
            BOOL,
            ushort*,
            ushort*,
            IMFHttpDownloadRequest*,
            int> CreateRequest;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFHttpDownloadSession"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFHttpDownloadSession(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFHttpDownloadSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFHttpDownloadSession(Silk.NET.Windows.IUnknown value)
    {
        return new IMFHttpDownloadSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFHttpDownloadSession"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFHttpDownloadSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFHttpDownloadSession value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
