// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("20168D64-5A8F-4A5A-B7BD-CFA29F4D0FD9")]
[NativeTypeName("struct ITfComposition : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfComposition : ITfComposition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfComposition));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfComposition, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfComposition, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfComposition, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRange(ITfRange* ppRange)
    {
        return ((delegate* unmanaged<ITfComposition, ITfRange*, int>)((*lpVtbl)[3]))(this, ppRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShiftStart([NativeTypeName("TfEditCookie")] uint ecWrite, ITfRange pNewStart)
    {
        return ((delegate* unmanaged<ITfComposition, uint, ITfRange, int>)((*lpVtbl)[4]))(
            this,
            ecWrite,
            pNewStart
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ShiftEnd([NativeTypeName("TfEditCookie")] uint ecWrite, ITfRange pNewEnd)
    {
        return ((delegate* unmanaged<ITfComposition, uint, ITfRange, int>)((*lpVtbl)[5]))(
            this,
            ecWrite,
            pNewEnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EndComposition([NativeTypeName("TfEditCookie")] uint ecWrite)
    {
        return ((delegate* unmanaged<ITfComposition, uint, int>)((*lpVtbl)[6]))(this, ecWrite);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRange(ITfRange* ppRange);

        [VtblIndex(4)]
        HRESULT ShiftStart([NativeTypeName("TfEditCookie")] uint ecWrite, ITfRange pNewStart);

        [VtblIndex(5)]
        HRESULT ShiftEnd([NativeTypeName("TfEditCookie")] uint ecWrite, ITfRange pNewEnd);

        [VtblIndex(6)]
        HRESULT EndComposition([NativeTypeName("TfEditCookie")] uint ecWrite);
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

        [NativeTypeName("HRESULT (ITfRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange*, int> GetRange;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange, int> ShiftStart;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange, int> ShiftEnd;

        [NativeTypeName("HRESULT (TfEditCookie) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> EndComposition;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfComposition"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfComposition(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfComposition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfComposition(Silk.NET.Windows.IUnknown value)
    {
        return new ITfComposition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfComposition"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfComposition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfComposition value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
