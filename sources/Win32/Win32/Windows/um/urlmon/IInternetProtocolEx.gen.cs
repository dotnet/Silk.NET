// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C7A98E66-1010-492C-A1C8-C809E1F75905")]
[NativeTypeName("struct IInternetProtocolEx : IInternetProtocol")]
[NativeInheritance("IInternetProtocol")]
public unsafe partial struct IInternetProtocolEx : IInternetProtocolEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetProtocolEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInternetProtocolEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetProtocolEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Start(
        [NativeTypeName("LPCWSTR")] ushort* szUrl,
        IInternetProtocolSink pOIProtSink,
        IInternetBindInfo pOIBindInfo,
        [NativeTypeName("DWORD")] uint grfPI,
        HANDLE_PTR dwReserved
    )
    {
        return (
            (delegate* unmanaged<
                IInternetProtocolEx,
                ushort*,
                IInternetProtocolSink,
                IInternetBindInfo,
                uint,
                HANDLE_PTR,
                int>)((*lpVtbl)[3])
        )(this, szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Continue(PROTOCOLDATA* pProtocolData)
    {
        return ((delegate* unmanaged<IInternetProtocolEx, PROTOCOLDATA*, int>)((*lpVtbl)[4]))(
            this,
            pProtocolData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Abort(HRESULT hrReason, [NativeTypeName("DWORD")] uint dwOptions)
    {
        return ((delegate* unmanaged<IInternetProtocolEx, HRESULT, uint, int>)((*lpVtbl)[5]))(
            this,
            hrReason,
            dwOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Terminate([NativeTypeName("DWORD")] uint dwOptions)
    {
        return ((delegate* unmanaged<IInternetProtocolEx, uint, int>)((*lpVtbl)[6]))(
            this,
            dwOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Suspend()
    {
        return ((delegate* unmanaged<IInternetProtocolEx, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IInternetProtocolEx, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Read(
        void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbRead
    )
    {
        return ((delegate* unmanaged<IInternetProtocolEx, void*, uint, uint*, int>)((*lpVtbl)[9]))(
            this,
            pv,
            cb,
            pcbRead
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Seek(
        LARGE_INTEGER dlibMove,
        [NativeTypeName("DWORD")] uint dwOrigin,
        ULARGE_INTEGER* plibNewPosition
    )
    {
        return (
            (delegate* unmanaged<IInternetProtocolEx, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(
                (*lpVtbl)[10]
            )
        )(this, dlibMove, dwOrigin, plibNewPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT LockRequest([NativeTypeName("DWORD")] uint dwOptions)
    {
        return ((delegate* unmanaged<IInternetProtocolEx, uint, int>)((*lpVtbl)[11]))(
            this,
            dwOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT UnlockRequest()
    {
        return ((delegate* unmanaged<IInternetProtocolEx, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT StartEx(
        IUri pUri,
        IInternetProtocolSink pOIProtSink,
        IInternetBindInfo pOIBindInfo,
        [NativeTypeName("DWORD")] uint grfPI,
        HANDLE_PTR dwReserved
    )
    {
        return (
            (delegate* unmanaged<
                IInternetProtocolEx,
                IUri,
                IInternetProtocolSink,
                IInternetBindInfo,
                uint,
                HANDLE_PTR,
                int>)((*lpVtbl)[13])
        )(this, pUri, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
    }

    public interface Interface : IInternetProtocol.Interface
    {
        [VtblIndex(13)]
        HRESULT StartEx(
            IUri pUri,
            IInternetProtocolSink pOIProtSink,
            IInternetBindInfo pOIBindInfo,
            [NativeTypeName("DWORD")] uint grfPI,
            HANDLE_PTR dwReserved
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
            "HRESULT (LPCWSTR, IInternetProtocolSink *, IInternetBindInfo *, DWORD, HANDLE_PTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IInternetProtocolSink,
            IInternetBindInfo,
            uint,
            HANDLE_PTR,
            int> Start;

        [NativeTypeName("HRESULT (PROTOCOLDATA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROTOCOLDATA*, int> Continue;

        [NativeTypeName("HRESULT (HRESULT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, uint, int> Abort;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Terminate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Suspend;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Resume;

        [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint*, int> Read;

        [NativeTypeName(
            "HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> Seek;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> LockRequest;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockRequest;

        [NativeTypeName(
            "HRESULT (IUri *, IInternetProtocolSink *, IInternetBindInfo *, DWORD, HANDLE_PTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUri,
            IInternetProtocolSink,
            IInternetBindInfo,
            uint,
            HANDLE_PTR,
            int> StartEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInternetProtocolEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInternetProtocolEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IInternetProtocol"/> to <see cref = "IInternetProtocolEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IInternetProtocol"/> instance to be converted </param>
    public static explicit operator IInternetProtocolEx(Silk.NET.Windows.IInternetProtocol value)
    {
        return new IInternetProtocolEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetProtocolEx"/> to <see cref = "Silk.NET.Windows.IInternetProtocol"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetProtocolEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IInternetProtocol(IInternetProtocolEx value)
    {
        return new Silk.NET.Windows.IInternetProtocol(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IInternetProtocolRoot"/> to <see cref = "IInternetProtocolEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IInternetProtocolRoot"/> instance to be converted </param>
    public static explicit operator IInternetProtocolEx(
        Silk.NET.Windows.IInternetProtocolRoot value
    )
    {
        return new IInternetProtocolEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetProtocolEx"/> to <see cref = "Silk.NET.Windows.IInternetProtocolRoot"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetProtocolEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IInternetProtocolRoot(
        IInternetProtocolEx value
    )
    {
        return new Silk.NET.Windows.IInternetProtocolRoot(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInternetProtocolEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInternetProtocolEx(Silk.NET.Windows.IUnknown value)
    {
        return new IInternetProtocolEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetProtocolEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetProtocolEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInternetProtocolEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
