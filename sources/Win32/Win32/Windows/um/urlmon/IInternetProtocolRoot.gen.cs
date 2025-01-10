// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9E3-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetProtocolRoot : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetProtocolRoot : IInternetProtocolRoot.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolRoot));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetProtocolRoot, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInternetProtocolRoot, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetProtocolRoot, uint>)((*lpVtbl)[2]))(this);
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
                IInternetProtocolRoot,
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
        return ((delegate* unmanaged<IInternetProtocolRoot, PROTOCOLDATA*, int>)((*lpVtbl)[4]))(
            this,
            pProtocolData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Abort(HRESULT hrReason, [NativeTypeName("DWORD")] uint dwOptions)
    {
        return ((delegate* unmanaged<IInternetProtocolRoot, HRESULT, uint, int>)((*lpVtbl)[5]))(
            this,
            hrReason,
            dwOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Terminate([NativeTypeName("DWORD")] uint dwOptions)
    {
        return ((delegate* unmanaged<IInternetProtocolRoot, uint, int>)((*lpVtbl)[6]))(
            this,
            dwOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Suspend()
    {
        return ((delegate* unmanaged<IInternetProtocolRoot, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IInternetProtocolRoot, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Start(
            [NativeTypeName("LPCWSTR")] ushort* szUrl,
            IInternetProtocolSink pOIProtSink,
            IInternetBindInfo pOIBindInfo,
            [NativeTypeName("DWORD")] uint grfPI,
            HANDLE_PTR dwReserved
        );

        [VtblIndex(4)]
        HRESULT Continue(PROTOCOLDATA* pProtocolData);

        [VtblIndex(5)]
        HRESULT Abort(HRESULT hrReason, [NativeTypeName("DWORD")] uint dwOptions);

        [VtblIndex(6)]
        HRESULT Terminate([NativeTypeName("DWORD")] uint dwOptions);

        [VtblIndex(7)]
        HRESULT Suspend();

        [VtblIndex(8)]
        HRESULT Resume();
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IInternetProtocolRoot"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInternetProtocolRoot(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInternetProtocolRoot"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInternetProtocolRoot(Silk.NET.Windows.IUnknown value)
    {
        return new IInternetProtocolRoot(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetProtocolRoot"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetProtocolRoot"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInternetProtocolRoot value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
