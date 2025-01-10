// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("994E23AF-1CC2-493C-B9FA-46F1CB040FA4")]
[NativeTypeName("struct IMFPMPServer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFPMPServer : IMFPMPServer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPMPServer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPMPServer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFPMPServer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPMPServer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LockProcess()
    {
        return ((delegate* unmanaged<IMFPMPServer, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnlockProcess()
    {
        return ((delegate* unmanaged<IMFPMPServer, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateObjectByCLSID(
        [NativeTypeName("const IID &")] Guid* clsid,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppObject
    )
    {
        return ((delegate* unmanaged<IMFPMPServer, Guid*, Guid*, void**, int>)((*lpVtbl)[5]))(
            this,
            clsid,
            riid,
            ppObject
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LockProcess();

        [VtblIndex(4)]
        HRESULT UnlockProcess();

        [VtblIndex(5)]
        HRESULT CreateObjectByCLSID(
            [NativeTypeName("const IID &")] Guid* clsid,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppObject
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LockProcess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockProcess;

        [NativeTypeName("HRESULT (const IID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> CreateObjectByCLSID;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFPMPServer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFPMPServer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFPMPServer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFPMPServer(Silk.NET.Windows.IUnknown value)
    {
        return new IMFPMPServer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFPMPServer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFPMPServer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFPMPServer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
