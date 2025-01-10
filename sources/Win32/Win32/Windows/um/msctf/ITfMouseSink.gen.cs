// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A1ADAAA2-3A24-449D-AC96-5183E7F5C217")]
[NativeTypeName("struct ITfMouseSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfMouseSink : ITfMouseSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfMouseSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfMouseSink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfMouseSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfMouseSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnMouseEvent(
        [NativeTypeName("ULONG")] uint uEdge,
        [NativeTypeName("ULONG")] uint uQuadrant,
        [NativeTypeName("DWORD")] uint dwBtnStatus,
        BOOL* pfEaten
    )
    {
        return ((delegate* unmanaged<ITfMouseSink, uint, uint, uint, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            uEdge,
            uQuadrant,
            dwBtnStatus,
            pfEaten
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnMouseEvent(
            [NativeTypeName("ULONG")] uint uEdge,
            [NativeTypeName("ULONG")] uint uQuadrant,
            [NativeTypeName("DWORD")] uint dwBtnStatus,
            BOOL* pfEaten
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

        [NativeTypeName("HRESULT (ULONG, ULONG, DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, BOOL*, int> OnMouseEvent;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfMouseSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfMouseSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfMouseSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfMouseSink(Silk.NET.Windows.IUnknown value)
    {
        return new ITfMouseSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfMouseSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfMouseSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfMouseSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
