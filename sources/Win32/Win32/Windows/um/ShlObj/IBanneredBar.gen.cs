// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("596A9A94-013E-11D1-8D34-00A0C90F2719")]
[NativeTypeName("struct IBanneredBar : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBanneredBar : IBanneredBar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBanneredBar));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBanneredBar, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBanneredBar, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBanneredBar, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetIconSize([NativeTypeName("DWORD")] uint iIcon)
    {
        return ((delegate* unmanaged<IBanneredBar, uint, int>)((*lpVtbl)[3]))(this, iIcon);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIconSize([NativeTypeName("DWORD *")] uint* piIcon)
    {
        return ((delegate* unmanaged<IBanneredBar, uint*, int>)((*lpVtbl)[4]))(this, piIcon);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetBitmap(HBITMAP hBitmap)
    {
        return ((delegate* unmanaged<IBanneredBar, HBITMAP, int>)((*lpVtbl)[5]))(this, hBitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetBitmap(HBITMAP* phBitmap)
    {
        return ((delegate* unmanaged<IBanneredBar, HBITMAP*, int>)((*lpVtbl)[6]))(this, phBitmap);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetIconSize([NativeTypeName("DWORD")] uint iIcon);

        [VtblIndex(4)]
        HRESULT GetIconSize([NativeTypeName("DWORD *")] uint* piIcon);

        [VtblIndex(5)]
        HRESULT SetBitmap(HBITMAP hBitmap);

        [VtblIndex(6)]
        HRESULT GetBitmap(HBITMAP* phBitmap);
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

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetIconSize;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetIconSize;

        [NativeTypeName("HRESULT (HBITMAP) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HBITMAP, int> SetBitmap;

        [NativeTypeName("HRESULT (HBITMAP *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HBITMAP*, int> GetBitmap;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBanneredBar"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBanneredBar(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBanneredBar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBanneredBar(Silk.NET.Windows.IUnknown value)
    {
        return new IBanneredBar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBanneredBar"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBanneredBar"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBanneredBar value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
