// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("894AD3B0-EF97-11CE-9BC9-00AA00608E01")]
[NativeTypeName("struct IOleUndoUnit : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleUndoUnit : IOleUndoUnit.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleUndoUnit));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleUndoUnit, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleUndoUnit, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleUndoUnit, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Do(IOleUndoManager pUndoManager)
    {
        return ((delegate* unmanaged<IOleUndoUnit, IOleUndoManager, int>)((*lpVtbl)[3]))(
            this,
            pUndoManager
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pBstr)
    {
        return ((delegate* unmanaged<IOleUndoUnit, ushort**, int>)((*lpVtbl)[4]))(this, pBstr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetUnitType(
        [NativeTypeName("CLSID *")] Guid* pClsid,
        [NativeTypeName("LONG *")] int* plID
    )
    {
        return ((delegate* unmanaged<IOleUndoUnit, Guid*, int*, int>)((*lpVtbl)[5]))(
            this,
            pClsid,
            plID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnNextAdd()
    {
        return ((delegate* unmanaged<IOleUndoUnit, int>)((*lpVtbl)[6]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Do(IOleUndoManager pUndoManager);

        [VtblIndex(4)]
        HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pBstr);

        [VtblIndex(5)]
        HRESULT GetUnitType(
            [NativeTypeName("CLSID *")] Guid* pClsid,
            [NativeTypeName("LONG *")] int* plID
        );

        [VtblIndex(6)]
        HRESULT OnNextAdd();
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

        [NativeTypeName("HRESULT (IOleUndoManager *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleUndoManager, int> Do;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (CLSID *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int*, int> GetUnitType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnNextAdd;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleUndoUnit"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleUndoUnit(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleUndoUnit"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleUndoUnit(Silk.NET.Windows.IUnknown value)
    {
        return new IOleUndoUnit(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleUndoUnit"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleUndoUnit"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleUndoUnit value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
