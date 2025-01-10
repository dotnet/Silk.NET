// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("EA9DBF1A-C88E-4486-854A-98AA0138F30C")]
[NativeTypeName("struct IDXGIDisplayControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDXGIDisplayControl : IDXGIDisplayControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDisplayControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIDisplayControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGIDisplayControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIDisplayControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL IsStereoEnabled()
    {
        return ((delegate* unmanaged<IDXGIDisplayControl, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetStereoEnabled(BOOL enabled)
    {
        ((delegate* unmanaged<IDXGIDisplayControl, BOOL, void>)((*lpVtbl)[4]))(this, enabled);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        BOOL IsStereoEnabled();

        [VtblIndex(4)]
        void SetStereoEnabled(BOOL enabled);
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

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsStereoEnabled;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetStereoEnabled;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIDisplayControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIDisplayControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGIDisplayControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGIDisplayControl(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGIDisplayControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIDisplayControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIDisplayControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGIDisplayControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
