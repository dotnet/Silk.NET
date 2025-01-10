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

[Guid("689F1F85-C72E-4E33-8F19-85754EFD5ACE")]
[NativeTypeName("struct ID2D1DrawingStateBlock1 : ID2D1DrawingStateBlock")]
[NativeInheritance("ID2D1DrawingStateBlock")]
public unsafe partial struct ID2D1DrawingStateBlock1
    : ID2D1DrawingStateBlock1.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1DrawingStateBlock1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1DrawingStateBlock1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1DrawingStateBlock1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1DrawingStateBlock1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1DrawingStateBlock1, ID2D1Factory*, void>)((*lpVtbl)[3]))(
            this,
            factory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
    {
        (
            (delegate* unmanaged<ID2D1DrawingStateBlock1, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(
                (*lpVtbl)[4]
            )
        )(this, stateDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetDescription(
        [NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")]
            D2D1_DRAWING_STATE_DESCRIPTION* stateDescription
    )
    {
        (
            (delegate* unmanaged<ID2D1DrawingStateBlock1, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(
                (*lpVtbl)[5]
            )
        )(this, stateDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetTextRenderingParams(IDWriteRenderingParams textRenderingParams = default)
    {
        (
            (delegate* unmanaged<ID2D1DrawingStateBlock1, IDWriteRenderingParams, void>)(
                (*lpVtbl)[6]
            )
        )(this, textRenderingParams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetTextRenderingParams(IDWriteRenderingParams* textRenderingParams)
    {
        (
            (delegate* unmanaged<ID2D1DrawingStateBlock1, IDWriteRenderingParams*, void>)(
                (*lpVtbl)[7]
            )
        )(this, textRenderingParams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)
    {
        (
            (delegate* unmanaged<ID2D1DrawingStateBlock1, D2D1_DRAWING_STATE_DESCRIPTION1*, void>)(
                (*lpVtbl)[8]
            )
        )(this, stateDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void SetDescription(
        [NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")]
            D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription
    )
    {
        (
            (delegate* unmanaged<ID2D1DrawingStateBlock1, D2D1_DRAWING_STATE_DESCRIPTION1*, void>)(
                (*lpVtbl)[9]
            )
        )(this, stateDescription);
    }

    public interface Interface : ID2D1DrawingStateBlock.Interface
    {
        [VtblIndex(8)]
        void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription);

        [VtblIndex(9)]
        void SetDescription(
            [NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")]
                D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription
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

        [NativeTypeName(
            "void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Factory*, void> GetFactory;

        [NativeTypeName(
            "void (D2D1_DRAWING_STATE_DESCRIPTION *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_DRAWING_STATE_DESCRIPTION*, void> GetDescription;

        [NativeTypeName(
            "void (const D2D1_DRAWING_STATE_DESCRIPTION *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_DRAWING_STATE_DESCRIPTION*, void> SetDescription;

        [NativeTypeName(
            "void (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteRenderingParams, void> SetTextRenderingParams;

        [NativeTypeName(
            "void (IDWriteRenderingParams **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteRenderingParams*, void> GetTextRenderingParams;

        [NativeTypeName(
            "void (D2D1_DRAWING_STATE_DESCRIPTION1 *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_DRAWING_STATE_DESCRIPTION1*, void> GetDescription1;

        [NativeTypeName(
            "void (const D2D1_DRAWING_STATE_DESCRIPTION1 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_DRAWING_STATE_DESCRIPTION1*, void> SetDescription1;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1DrawingStateBlock1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1DrawingStateBlock1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1DrawingStateBlock"/> to <see cref = "ID2D1DrawingStateBlock1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1DrawingStateBlock"/> instance to be converted </param>
    public static explicit operator ID2D1DrawingStateBlock1(
        Silk.NET.DirectX.ID2D1DrawingStateBlock value
    )
    {
        return new ID2D1DrawingStateBlock1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DrawingStateBlock1"/> to <see cref = "Silk.NET.DirectX.ID2D1DrawingStateBlock"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DrawingStateBlock1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1DrawingStateBlock(
        ID2D1DrawingStateBlock1 value
    )
    {
        return new Silk.NET.DirectX.ID2D1DrawingStateBlock(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1DrawingStateBlock1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1DrawingStateBlock1(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1DrawingStateBlock1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DrawingStateBlock1"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DrawingStateBlock1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1DrawingStateBlock1 value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1DrawingStateBlock1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1DrawingStateBlock1(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1DrawingStateBlock1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DrawingStateBlock1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DrawingStateBlock1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1DrawingStateBlock1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
