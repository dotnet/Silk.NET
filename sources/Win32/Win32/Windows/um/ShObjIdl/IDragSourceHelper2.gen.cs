// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("83E07D0D-0C5F-4163-BF1A-60B274051E40")]
[NativeTypeName("struct IDragSourceHelper2 : IDragSourceHelper")]
[NativeInheritance("IDragSourceHelper")]
public unsafe partial struct IDragSourceHelper2 : IDragSourceHelper2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDragSourceHelper2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDragSourceHelper2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDragSourceHelper2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDragSourceHelper2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeFromBitmap(
        [NativeTypeName("LPSHDRAGIMAGE")] SHDRAGIMAGE* pshdi,
        IDataObject pDataObject
    )
    {
        return (
            (delegate* unmanaged<IDragSourceHelper2, SHDRAGIMAGE*, IDataObject, int>)((*lpVtbl)[3])
        )(this, pshdi, pDataObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitializeFromWindow(HWND hwnd, POINT* ppt, IDataObject pDataObject)
    {
        return (
            (delegate* unmanaged<IDragSourceHelper2, HWND, POINT*, IDataObject, int>)((*lpVtbl)[4])
        )(this, hwnd, ppt, pDataObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFlags([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IDragSourceHelper2, uint, int>)((*lpVtbl)[5]))(this, dwFlags);
    }

    public interface Interface : IDragSourceHelper.Interface
    {
        [VtblIndex(5)]
        HRESULT SetFlags([NativeTypeName("DWORD")] uint dwFlags);
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

        [NativeTypeName("HRESULT (LPSHDRAGIMAGE, IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SHDRAGIMAGE*, IDataObject, int> InitializeFromBitmap;

        [NativeTypeName("HRESULT (HWND, POINT *, IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, POINT*, IDataObject, int> InitializeFromWindow;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetFlags;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDragSourceHelper2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDragSourceHelper2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDragSourceHelper"/> to <see cref = "IDragSourceHelper2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDragSourceHelper"/> instance to be converted </param>
    public static explicit operator IDragSourceHelper2(Silk.NET.Windows.IDragSourceHelper value)
    {
        return new IDragSourceHelper2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDragSourceHelper2"/> to <see cref = "Silk.NET.Windows.IDragSourceHelper"/>.</summary>
    /// <param name = "value">The <see cref = "IDragSourceHelper2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDragSourceHelper(IDragSourceHelper2 value)
    {
        return new Silk.NET.Windows.IDragSourceHelper(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDragSourceHelper2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDragSourceHelper2(Silk.NET.Windows.IUnknown value)
    {
        return new IDragSourceHelper2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDragSourceHelper2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDragSourceHelper2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDragSourceHelper2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
