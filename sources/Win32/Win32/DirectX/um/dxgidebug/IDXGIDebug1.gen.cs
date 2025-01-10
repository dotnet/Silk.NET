// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("C5A05F0C-16F2-4ADF-9F4D-A8C4D58AC550")]
[NativeTypeName("struct IDXGIDebug1 : IDXGIDebug")]
[NativeInheritance("IDXGIDebug")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDXGIDebug1 : IDXGIDebug1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDebug1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIDebug1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGIDebug1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIDebug1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReportLiveObjects(Guid apiid, DXGI_DEBUG_RLO_FLAGS flags)
    {
        return ((delegate* unmanaged<IDXGIDebug1, Guid, DXGI_DEBUG_RLO_FLAGS, int>)((*lpVtbl)[3]))(
            this,
            apiid,
            flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void EnableLeakTrackingForThread()
    {
        ((delegate* unmanaged<IDXGIDebug1, void>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void DisableLeakTrackingForThread()
    {
        ((delegate* unmanaged<IDXGIDebug1, void>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL IsLeakTrackingEnabledForThread()
    {
        return ((delegate* unmanaged<IDXGIDebug1, int>)((*lpVtbl)[6]))(this);
    }

    public interface Interface : IDXGIDebug.Interface
    {
        [VtblIndex(4)]
        void EnableLeakTrackingForThread();

        [VtblIndex(5)]
        void DisableLeakTrackingForThread();

        [VtblIndex(6)]
        BOOL IsLeakTrackingEnabledForThread();
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

        [NativeTypeName("HRESULT (GUID, DXGI_DEBUG_RLO_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_DEBUG_RLO_FLAGS, int> ReportLiveObjects;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EnableLeakTrackingForThread;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> DisableLeakTrackingForThread;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsLeakTrackingEnabledForThread;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIDebug1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIDebug1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIDebug"/> to <see cref = "IDXGIDebug1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIDebug"/> instance to be converted </param>
    public static explicit operator IDXGIDebug1(Silk.NET.DirectX.IDXGIDebug value)
    {
        return new IDXGIDebug1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIDebug1"/> to <see cref = "Silk.NET.DirectX.IDXGIDebug"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIDebug1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIDebug(IDXGIDebug1 value)
    {
        return new Silk.NET.DirectX.IDXGIDebug(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGIDebug1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGIDebug1(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGIDebug1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIDebug1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIDebug1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGIDebug1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
