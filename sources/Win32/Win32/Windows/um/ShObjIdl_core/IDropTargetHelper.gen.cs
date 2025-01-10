// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4657278B-411B-11D2-839A-00C04FD918D0")]
[NativeTypeName("struct IDropTargetHelper : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDropTargetHelper : IDropTargetHelper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDropTargetHelper));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDropTargetHelper, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDropTargetHelper, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDropTargetHelper, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DragEnter(
        HWND hwndTarget,
        IDataObject pDataObject,
        POINT* ppt,
        [NativeTypeName("DWORD")] uint dwEffect
    )
    {
        return (
            (delegate* unmanaged<IDropTargetHelper, HWND, IDataObject, POINT*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, hwndTarget, pDataObject, ppt, dwEffect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DragLeave()
    {
        return ((delegate* unmanaged<IDropTargetHelper, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DragOver(POINT* ppt, [NativeTypeName("DWORD")] uint dwEffect)
    {
        return ((delegate* unmanaged<IDropTargetHelper, POINT*, uint, int>)((*lpVtbl)[5]))(
            this,
            ppt,
            dwEffect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Drop(
        IDataObject pDataObject,
        POINT* ppt,
        [NativeTypeName("DWORD")] uint dwEffect
    )
    {
        return (
            (delegate* unmanaged<IDropTargetHelper, IDataObject, POINT*, uint, int>)((*lpVtbl)[6])
        )(this, pDataObject, ppt, dwEffect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Show(BOOL fShow)
    {
        return ((delegate* unmanaged<IDropTargetHelper, BOOL, int>)((*lpVtbl)[7]))(this, fShow);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DragEnter(
            HWND hwndTarget,
            IDataObject pDataObject,
            POINT* ppt,
            [NativeTypeName("DWORD")] uint dwEffect
        );

        [VtblIndex(4)]
        HRESULT DragLeave();

        [VtblIndex(5)]
        HRESULT DragOver(POINT* ppt, [NativeTypeName("DWORD")] uint dwEffect);

        [VtblIndex(6)]
        HRESULT Drop(IDataObject pDataObject, POINT* ppt, [NativeTypeName("DWORD")] uint dwEffect);

        [VtblIndex(7)]
        HRESULT Show(BOOL fShow);
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

        [NativeTypeName("HRESULT (HWND, IDataObject *, POINT *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IDataObject, POINT*, uint, int> DragEnter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DragLeave;

        [NativeTypeName("HRESULT (POINT *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, uint, int> DragOver;

        [NativeTypeName("HRESULT (IDataObject *, POINT *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject, POINT*, uint, int> Drop;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Show;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDropTargetHelper"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDropTargetHelper(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDropTargetHelper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDropTargetHelper(Silk.NET.Windows.IUnknown value)
    {
        return new IDropTargetHelper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDropTargetHelper"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDropTargetHelper"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDropTargetHelper value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
