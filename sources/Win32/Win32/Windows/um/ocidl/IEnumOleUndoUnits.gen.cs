// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B3E7C340-EF97-11CE-9BC9-00AA00608E01")]
[NativeTypeName("struct IEnumOleUndoUnits : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumOleUndoUnits : IEnumOleUndoUnits.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumOleUndoUnits));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEnumOleUndoUnits, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next(
        [NativeTypeName("ULONG")] uint cElt,
        IOleUndoUnit* rgElt,
        [NativeTypeName("ULONG *")] uint* pcEltFetched
    )
    {
        return (
            (delegate* unmanaged<IEnumOleUndoUnits, uint, IOleUndoUnit*, uint*, int>)((*lpVtbl)[3])
        )(this, cElt, rgElt, pcEltFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cElt)
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits, uint, int>)((*lpVtbl)[4]))(this, cElt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumOleUndoUnits* ppEnum)
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits, IEnumOleUndoUnits*, int>)((*lpVtbl)[6]))(
            this,
            ppEnum
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next(
            [NativeTypeName("ULONG")] uint cElt,
            IOleUndoUnit* rgElt,
            [NativeTypeName("ULONG *")] uint* pcEltFetched
        );

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cElt);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumOleUndoUnits* ppEnum);
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

        [NativeTypeName("HRESULT (ULONG, IOleUndoUnit **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IOleUndoUnit*, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumOleUndoUnits **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumOleUndoUnits*, int> Clone;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEnumOleUndoUnits"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEnumOleUndoUnits(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEnumOleUndoUnits"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEnumOleUndoUnits(Silk.NET.Windows.IUnknown value)
    {
        return new IEnumOleUndoUnits(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEnumOleUndoUnits"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEnumOleUndoUnits"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEnumOleUndoUnits value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
