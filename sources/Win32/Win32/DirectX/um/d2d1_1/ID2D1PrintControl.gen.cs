// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("2C1D867D-C290-41C8-AE7E-34A98702E9A5")]
[NativeTypeName("struct ID2D1PrintControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1PrintControl : ID2D1PrintControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1PrintControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1PrintControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1PrintControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1PrintControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPage(
        ID2D1CommandList commandList,
        D2D_SIZE_F pageSize,
        IStream pagePrintTicketStream,
        [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null,
        [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1PrintControl,
                ID2D1CommandList,
                D2D_SIZE_F,
                IStream,
                ulong*,
                ulong*,
                int>)((*lpVtbl)[3])
        )(this, commandList, pageSize, pagePrintTicketStream, tag1, tag2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ID2D1PrintControl, int>)((*lpVtbl)[4]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddPage(
            ID2D1CommandList commandList,
            D2D_SIZE_F pageSize,
            IStream pagePrintTicketStream,
            [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null,
            [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null
        );

        [VtblIndex(4)]
        HRESULT Close();
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

        [NativeTypeName(
            "HRESULT (ID2D1CommandList *, D2D_SIZE_F, IStream *, D2D1_TAG *, D2D1_TAG *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1CommandList,
            D2D_SIZE_F,
            IStream,
            ulong*,
            ulong*,
            int> AddPage;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1PrintControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1PrintControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1PrintControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1PrintControl(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1PrintControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1PrintControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1PrintControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1PrintControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
