// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DE5BF786-477A-11D2-839D-00C04FD918D0")]
[NativeTypeName("struct IDragSourceHelper : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDragSourceHelper : IDragSourceHelper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDragSourceHelper));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDragSourceHelper, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDragSourceHelper, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDragSourceHelper, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeFromBitmap(
        [NativeTypeName("LPSHDRAGIMAGE")] SHDRAGIMAGE* pshdi,
        IDataObject pDataObject
    )
    {
        return (
            (delegate* unmanaged<IDragSourceHelper, SHDRAGIMAGE*, IDataObject, int>)((*lpVtbl)[3])
        )(this, pshdi, pDataObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitializeFromWindow(HWND hwnd, POINT* ppt, IDataObject pDataObject)
    {
        return (
            (delegate* unmanaged<IDragSourceHelper, HWND, POINT*, IDataObject, int>)((*lpVtbl)[4])
        )(this, hwnd, ppt, pDataObject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeFromBitmap(
            [NativeTypeName("LPSHDRAGIMAGE")] SHDRAGIMAGE* pshdi,
            IDataObject pDataObject
        );

        [VtblIndex(4)]
        HRESULT InitializeFromWindow(HWND hwnd, POINT* ppt, IDataObject pDataObject);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IDragSourceHelper"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDragSourceHelper(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDragSourceHelper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDragSourceHelper(Silk.NET.Windows.IUnknown value)
    {
        return new IDragSourceHelper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDragSourceHelper"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDragSourceHelper"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDragSourceHelper value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
