// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B15B8DC1-C7E1-11D0-8680-00AA00BDCB71")]
[NativeTypeName("struct ISoftDistExt : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISoftDistExt : ISoftDistExt.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISoftDistExt));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISoftDistExt, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISoftDistExt, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISoftDistExt, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ProcessSoftDist(
        [NativeTypeName("LPCWSTR")] ushort* szCDFURL,
        IXMLElement pSoftDistElement,
        [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* lpsdi
    )
    {
        return (
            (delegate* unmanaged<ISoftDistExt, ushort*, IXMLElement, SOFTDISTINFO*, int>)(
                (*lpVtbl)[3]
            )
        )(this, szCDFURL, pSoftDistElement, lpsdi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFirstCodeBase(
        [NativeTypeName("LPWSTR *")] ushort** szCodeBase,
        [NativeTypeName("LPDWORD")] uint* dwMaxSize
    )
    {
        return ((delegate* unmanaged<ISoftDistExt, ushort**, uint*, int>)((*lpVtbl)[4]))(
            this,
            szCodeBase,
            dwMaxSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetNextCodeBase(
        [NativeTypeName("LPWSTR *")] ushort** szCodeBase,
        [NativeTypeName("LPDWORD")] uint* dwMaxSize
    )
    {
        return ((delegate* unmanaged<ISoftDistExt, ushort**, uint*, int>)((*lpVtbl)[5]))(
            this,
            szCodeBase,
            dwMaxSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AsyncInstallDistributionUnit(
        IBindCtx pbc,
        [NativeTypeName("LPVOID")] void* pvReserved,
        [NativeTypeName("DWORD")] uint flags,
        [NativeTypeName("LPCODEBASEHOLD")] CODEBASEHOLD* lpcbh
    )
    {
        return (
            (delegate* unmanaged<ISoftDistExt, IBindCtx, void*, uint, CODEBASEHOLD*, int>)(
                (*lpVtbl)[6]
            )
        )(this, pbc, pvReserved, flags, lpcbh);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ProcessSoftDist(
            [NativeTypeName("LPCWSTR")] ushort* szCDFURL,
            IXMLElement pSoftDistElement,
            [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* lpsdi
        );

        [VtblIndex(4)]
        HRESULT GetFirstCodeBase(
            [NativeTypeName("LPWSTR *")] ushort** szCodeBase,
            [NativeTypeName("LPDWORD")] uint* dwMaxSize
        );

        [VtblIndex(5)]
        HRESULT GetNextCodeBase(
            [NativeTypeName("LPWSTR *")] ushort** szCodeBase,
            [NativeTypeName("LPDWORD")] uint* dwMaxSize
        );

        [VtblIndex(6)]
        HRESULT AsyncInstallDistributionUnit(
            IBindCtx pbc,
            [NativeTypeName("LPVOID")] void* pvReserved,
            [NativeTypeName("DWORD")] uint flags,
            [NativeTypeName("LPCODEBASEHOLD")] CODEBASEHOLD* lpcbh
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
            "HRESULT (LPCWSTR, IXMLElement *, LPSOFTDISTINFO) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IXMLElement,
            SOFTDISTINFO*,
            int> ProcessSoftDist;

        [NativeTypeName("HRESULT (LPWSTR *, LPDWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, int> GetFirstCodeBase;

        [NativeTypeName("HRESULT (LPWSTR *, LPDWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, int> GetNextCodeBase;

        [NativeTypeName(
            "HRESULT (IBindCtx *, LPVOID, DWORD, LPCODEBASEHOLD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBindCtx,
            void*,
            uint,
            CODEBASEHOLD*,
            int> AsyncInstallDistributionUnit;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISoftDistExt"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISoftDistExt(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISoftDistExt"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISoftDistExt(Silk.NET.Windows.IUnknown value)
    {
        return new ISoftDistExt(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISoftDistExt"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISoftDistExt"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISoftDistExt value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
