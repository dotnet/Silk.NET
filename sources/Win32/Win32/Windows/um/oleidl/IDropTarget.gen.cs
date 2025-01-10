// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000122-0000-0000-C000-000000000046")]
[NativeTypeName("struct IDropTarget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDropTarget : IDropTarget.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDropTarget));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDropTarget, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDropTarget, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDropTarget, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DragEnter(
        IDataObject pDataObj,
        [NativeTypeName("DWORD")] uint grfKeyState,
        POINTL pt,
        [NativeTypeName("DWORD *")] uint* pdwEffect
    )
    {
        return (
            (delegate* unmanaged<IDropTarget, IDataObject, uint, POINTL, uint*, int>)((*lpVtbl)[3])
        )(this, pDataObj, grfKeyState, pt, pdwEffect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DragOver(
        [NativeTypeName("DWORD")] uint grfKeyState,
        POINTL pt,
        [NativeTypeName("DWORD *")] uint* pdwEffect
    )
    {
        return ((delegate* unmanaged<IDropTarget, uint, POINTL, uint*, int>)((*lpVtbl)[4]))(
            this,
            grfKeyState,
            pt,
            pdwEffect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DragLeave()
    {
        return ((delegate* unmanaged<IDropTarget, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Drop(
        IDataObject pDataObj,
        [NativeTypeName("DWORD")] uint grfKeyState,
        POINTL pt,
        [NativeTypeName("DWORD *")] uint* pdwEffect
    )
    {
        return (
            (delegate* unmanaged<IDropTarget, IDataObject, uint, POINTL, uint*, int>)((*lpVtbl)[6])
        )(this, pDataObj, grfKeyState, pt, pdwEffect);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DragEnter(
            IDataObject pDataObj,
            [NativeTypeName("DWORD")] uint grfKeyState,
            POINTL pt,
            [NativeTypeName("DWORD *")] uint* pdwEffect
        );

        [VtblIndex(4)]
        HRESULT DragOver(
            [NativeTypeName("DWORD")] uint grfKeyState,
            POINTL pt,
            [NativeTypeName("DWORD *")] uint* pdwEffect
        );

        [VtblIndex(5)]
        HRESULT DragLeave();

        [VtblIndex(6)]
        HRESULT Drop(
            IDataObject pDataObj,
            [NativeTypeName("DWORD")] uint grfKeyState,
            POINTL pt,
            [NativeTypeName("DWORD *")] uint* pdwEffect
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

        [NativeTypeName("HRESULT (IDataObject *, DWORD, POINTL, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject, uint, POINTL, uint*, int> DragEnter;

        [NativeTypeName("HRESULT (DWORD, POINTL, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, POINTL, uint*, int> DragOver;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DragLeave;

        [NativeTypeName("HRESULT (IDataObject *, DWORD, POINTL, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject, uint, POINTL, uint*, int> Drop;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDropTarget"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDropTarget(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDropTarget"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDropTarget(Silk.NET.Windows.IUnknown value)
    {
        return new IDropTarget(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDropTarget"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDropTarget"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDropTarget value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
