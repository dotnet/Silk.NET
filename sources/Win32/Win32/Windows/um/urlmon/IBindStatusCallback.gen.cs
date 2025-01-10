// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9C1-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IBindStatusCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBindStatusCallback : IBindStatusCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindStatusCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBindStatusCallback, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBindStatusCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBindStatusCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, IBinding pib)
    {
        return ((delegate* unmanaged<IBindStatusCallback, uint, IBinding, int>)((*lpVtbl)[3]))(
            this,
            dwReserved,
            pib
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPriority([NativeTypeName("LONG *")] int* pnPriority)
    {
        return ((delegate* unmanaged<IBindStatusCallback, int*, int>)((*lpVtbl)[4]))(
            this,
            pnPriority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnLowResource([NativeTypeName("DWORD")] uint reserved)
    {
        return ((delegate* unmanaged<IBindStatusCallback, uint, int>)((*lpVtbl)[5]))(
            this,
            reserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnProgress(
        [NativeTypeName("ULONG")] uint ulProgress,
        [NativeTypeName("ULONG")] uint ulProgressMax,
        [NativeTypeName("ULONG")] uint ulStatusCode,
        [NativeTypeName("LPCWSTR")] ushort* szStatusText
    )
    {
        return (
            (delegate* unmanaged<IBindStatusCallback, uint, uint, uint, ushort*, int>)((*lpVtbl)[6])
        )(this, ulProgress, ulProgressMax, ulStatusCode, szStatusText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnStopBinding(HRESULT hresult, [NativeTypeName("LPCWSTR")] ushort* szError)
    {
        return ((delegate* unmanaged<IBindStatusCallback, HRESULT, ushort*, int>)((*lpVtbl)[7]))(
            this,
            hresult,
            szError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo)
    {
        return ((delegate* unmanaged<IBindStatusCallback, uint*, BINDINFO*, int>)((*lpVtbl)[8]))(
            this,
            grfBINDF,
            pbindinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnDataAvailable(
        [NativeTypeName("DWORD")] uint grfBSCF,
        [NativeTypeName("DWORD")] uint dwSize,
        FORMATETC* pformatetc,
        STGMEDIUM* pstgmed
    )
    {
        return (
            (delegate* unmanaged<IBindStatusCallback, uint, uint, FORMATETC*, STGMEDIUM*, int>)(
                (*lpVtbl)[9]
            )
        )(this, grfBSCF, dwSize, pformatetc, pstgmed);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, IUnknown punk)
    {
        return ((delegate* unmanaged<IBindStatusCallback, Guid*, IUnknown, int>)((*lpVtbl)[10]))(
            this,
            riid,
            punk
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, IBinding pib);

        [VtblIndex(4)]
        HRESULT GetPriority([NativeTypeName("LONG *")] int* pnPriority);

        [VtblIndex(5)]
        HRESULT OnLowResource([NativeTypeName("DWORD")] uint reserved);

        [VtblIndex(6)]
        HRESULT OnProgress(
            [NativeTypeName("ULONG")] uint ulProgress,
            [NativeTypeName("ULONG")] uint ulProgressMax,
            [NativeTypeName("ULONG")] uint ulStatusCode,
            [NativeTypeName("LPCWSTR")] ushort* szStatusText
        );

        [VtblIndex(7)]
        HRESULT OnStopBinding(HRESULT hresult, [NativeTypeName("LPCWSTR")] ushort* szError);

        [VtblIndex(8)]
        HRESULT GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo);

        [VtblIndex(9)]
        HRESULT OnDataAvailable(
            [NativeTypeName("DWORD")] uint grfBSCF,
            [NativeTypeName("DWORD")] uint dwSize,
            FORMATETC* pformatetc,
            STGMEDIUM* pstgmed
        );

        [VtblIndex(10)]
        HRESULT OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, IUnknown punk);
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

        [NativeTypeName("HRESULT (DWORD, IBinding *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IBinding, int> OnStartBinding;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetPriority;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnLowResource;

        [NativeTypeName("HRESULT (ULONG, ULONG, ULONG, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, ushort*, int> OnProgress;

        [NativeTypeName("HRESULT (HRESULT, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, ushort*, int> OnStopBinding;

        [NativeTypeName("HRESULT (DWORD *, BINDINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, BINDINFO*, int> GetBindInfo;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, FORMATETC *, STGMEDIUM *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, FORMATETC*, STGMEDIUM*, int> OnDataAvailable;

        [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> OnObjectAvailable;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBindStatusCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBindStatusCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBindStatusCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBindStatusCallback(Silk.NET.Windows.IUnknown value)
    {
        return new IBindStatusCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBindStatusCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBindStatusCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBindStatusCallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
