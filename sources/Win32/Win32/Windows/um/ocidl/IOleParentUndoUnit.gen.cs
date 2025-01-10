// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A1FAF330-EF97-11CE-9BC9-00AA00608E01")]
[NativeTypeName("struct IOleParentUndoUnit : IOleUndoUnit")]
[NativeInheritance("IOleUndoUnit")]
public unsafe partial struct IOleParentUndoUnit : IOleParentUndoUnit.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleParentUndoUnit));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleParentUndoUnit, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleParentUndoUnit, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Do(IOleUndoManager pUndoManager)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit, IOleUndoManager, int>)((*lpVtbl)[3]))(
            this,
            pUndoManager
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pBstr)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit, ushort**, int>)((*lpVtbl)[4]))(
            this,
            pBstr
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetUnitType(
        [NativeTypeName("CLSID *")] Guid* pClsid,
        [NativeTypeName("LONG *")] int* plID
    )
    {
        return ((delegate* unmanaged<IOleParentUndoUnit, Guid*, int*, int>)((*lpVtbl)[5]))(
            this,
            pClsid,
            plID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnNextAdd()
    {
        return ((delegate* unmanaged<IOleParentUndoUnit, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Open(IOleParentUndoUnit pPUU)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit, IOleParentUndoUnit, int>)((*lpVtbl)[7]))(
            this,
            pPUU
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Close(IOleParentUndoUnit pPUU, BOOL fCommit)
    {
        return (
            (delegate* unmanaged<IOleParentUndoUnit, IOleParentUndoUnit, BOOL, int>)((*lpVtbl)[8])
        )(this, pPUU, fCommit);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Add(IOleUndoUnit pUU)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit, IOleUndoUnit, int>)((*lpVtbl)[9]))(
            this,
            pUU
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindUnit(IOleUndoUnit pUU)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit, IOleUndoUnit, int>)((*lpVtbl)[10]))(
            this,
            pUU
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetParentState([NativeTypeName("DWORD *")] uint* pdwState)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit, uint*, int>)((*lpVtbl)[11]))(
            this,
            pdwState
        );
    }

    public interface Interface : IOleUndoUnit.Interface
    {
        [VtblIndex(7)]
        HRESULT Open(IOleParentUndoUnit pPUU);

        [VtblIndex(8)]
        HRESULT Close(IOleParentUndoUnit pPUU, BOOL fCommit);

        [VtblIndex(9)]
        HRESULT Add(IOleUndoUnit pUU);

        [VtblIndex(10)]
        HRESULT FindUnit(IOleUndoUnit pUU);

        [VtblIndex(11)]
        HRESULT GetParentState([NativeTypeName("DWORD *")] uint* pdwState);
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

        [NativeTypeName("HRESULT (IOleParentUndoUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleParentUndoUnit, int> Open;

        [NativeTypeName("HRESULT (IOleParentUndoUnit *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleParentUndoUnit, BOOL, int> Close;

        [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleUndoUnit, int> Add;

        [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleUndoUnit, int> FindUnit;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetParentState;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleParentUndoUnit"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleParentUndoUnit(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleUndoUnit"/> to <see cref = "IOleParentUndoUnit"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleUndoUnit"/> instance to be converted </param>
    public static explicit operator IOleParentUndoUnit(Silk.NET.Windows.IOleUndoUnit value)
    {
        return new IOleParentUndoUnit(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleParentUndoUnit"/> to <see cref = "Silk.NET.Windows.IOleUndoUnit"/>.</summary>
    /// <param name = "value">The <see cref = "IOleParentUndoUnit"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleUndoUnit(IOleParentUndoUnit value)
    {
        return new Silk.NET.Windows.IOleUndoUnit(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleParentUndoUnit"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleParentUndoUnit(Silk.NET.Windows.IUnknown value)
    {
        return new IOleParentUndoUnit(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleParentUndoUnit"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleParentUndoUnit"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleParentUndoUnit value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
