// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9EC-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetProtocolInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetProtocolInfo : IInternetProtocolInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetProtocolInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInternetProtocolInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetProtocolInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ParseUrl(
        [NativeTypeName("LPCWSTR")] ushort* pwzUrl,
        PARSEACTION ParseAction,
        [NativeTypeName("DWORD")] uint dwParseFlags,
        [NativeTypeName("LPWSTR")] ushort* pwzResult,
        [NativeTypeName("DWORD")] uint cchResult,
        [NativeTypeName("DWORD *")] uint* pcchResult,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<
                IInternetProtocolInfo,
                ushort*,
                PARSEACTION,
                uint,
                ushort*,
                uint,
                uint*,
                uint,
                int>)((*lpVtbl)[3])
        )(this, pwzUrl, ParseAction, dwParseFlags, pwzResult, cchResult, pcchResult, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CombineUrl(
        [NativeTypeName("LPCWSTR")] ushort* pwzBaseUrl,
        [NativeTypeName("LPCWSTR")] ushort* pwzRelativeUrl,
        [NativeTypeName("DWORD")] uint dwCombineFlags,
        [NativeTypeName("LPWSTR")] ushort* pwzResult,
        [NativeTypeName("DWORD")] uint cchResult,
        [NativeTypeName("DWORD *")] uint* pcchResult,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<
                IInternetProtocolInfo,
                ushort*,
                ushort*,
                uint,
                ushort*,
                uint,
                uint*,
                uint,
                int>)((*lpVtbl)[4])
        )(
            this,
            pwzBaseUrl,
            pwzRelativeUrl,
            dwCombineFlags,
            pwzResult,
            cchResult,
            pcchResult,
            dwReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CompareUrl(
        [NativeTypeName("LPCWSTR")] ushort* pwzUrl1,
        [NativeTypeName("LPCWSTR")] ushort* pwzUrl2,
        [NativeTypeName("DWORD")] uint dwCompareFlags
    )
    {
        return (
            (delegate* unmanaged<IInternetProtocolInfo, ushort*, ushort*, uint, int>)((*lpVtbl)[5])
        )(this, pwzUrl1, pwzUrl2, dwCompareFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueryInfo(
        [NativeTypeName("LPCWSTR")] ushort* pwzUrl,
        QUERYOPTION OueryOption,
        [NativeTypeName("DWORD")] uint dwQueryFlags,
        [NativeTypeName("LPVOID")] void* pBuffer,
        [NativeTypeName("DWORD")] uint cbBuffer,
        [NativeTypeName("DWORD *")] uint* pcbBuf,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<
                IInternetProtocolInfo,
                ushort*,
                QUERYOPTION,
                uint,
                void*,
                uint,
                uint*,
                uint,
                int>)((*lpVtbl)[6])
        )(this, pwzUrl, OueryOption, dwQueryFlags, pBuffer, cbBuffer, pcbBuf, dwReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ParseUrl(
            [NativeTypeName("LPCWSTR")] ushort* pwzUrl,
            PARSEACTION ParseAction,
            [NativeTypeName("DWORD")] uint dwParseFlags,
            [NativeTypeName("LPWSTR")] ushort* pwzResult,
            [NativeTypeName("DWORD")] uint cchResult,
            [NativeTypeName("DWORD *")] uint* pcchResult,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(4)]
        HRESULT CombineUrl(
            [NativeTypeName("LPCWSTR")] ushort* pwzBaseUrl,
            [NativeTypeName("LPCWSTR")] ushort* pwzRelativeUrl,
            [NativeTypeName("DWORD")] uint dwCombineFlags,
            [NativeTypeName("LPWSTR")] ushort* pwzResult,
            [NativeTypeName("DWORD")] uint cchResult,
            [NativeTypeName("DWORD *")] uint* pcchResult,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(5)]
        HRESULT CompareUrl(
            [NativeTypeName("LPCWSTR")] ushort* pwzUrl1,
            [NativeTypeName("LPCWSTR")] ushort* pwzUrl2,
            [NativeTypeName("DWORD")] uint dwCompareFlags
        );

        [VtblIndex(6)]
        HRESULT QueryInfo(
            [NativeTypeName("LPCWSTR")] ushort* pwzUrl,
            QUERYOPTION OueryOption,
            [NativeTypeName("DWORD")] uint dwQueryFlags,
            [NativeTypeName("LPVOID")] void* pBuffer,
            [NativeTypeName("DWORD")] uint cbBuffer,
            [NativeTypeName("DWORD *")] uint* pcbBuf,
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
            "HRESULT (LPCWSTR, PARSEACTION, DWORD, LPWSTR, DWORD, DWORD *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            PARSEACTION,
            uint,
            ushort*,
            uint,
            uint*,
            uint,
            int> ParseUrl;

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, DWORD, LPWSTR, DWORD, DWORD *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            uint,
            ushort*,
            uint,
            uint*,
            uint,
            int> CombineUrl;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, uint, int> CompareUrl;

        [NativeTypeName(
            "HRESULT (LPCWSTR, QUERYOPTION, DWORD, LPVOID, DWORD, DWORD *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            QUERYOPTION,
            uint,
            void*,
            uint,
            uint*,
            uint,
            int> QueryInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInternetProtocolInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInternetProtocolInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInternetProtocolInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInternetProtocolInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IInternetProtocolInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetProtocolInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetProtocolInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInternetProtocolInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
