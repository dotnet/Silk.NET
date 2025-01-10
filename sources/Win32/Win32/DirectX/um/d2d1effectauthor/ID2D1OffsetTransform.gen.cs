// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("3FE6ADEA-7643-4F53-BD14-A0CE63F24042")]
[NativeTypeName("struct ID2D1OffsetTransform : ID2D1TransformNode")]
[NativeInheritance("ID2D1TransformNode")]
public unsafe partial struct ID2D1OffsetTransform : ID2D1OffsetTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1OffsetTransform));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1OffsetTransform, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1OffsetTransform, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1OffsetTransform, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<ID2D1OffsetTransform, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetOffset([NativeTypeName("D2D1_POINT_2L")] POINT offset)
    {
        ((delegate* unmanaged<ID2D1OffsetTransform, POINT, void>)((*lpVtbl)[4]))(this, offset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("D2D1_POINT_2L")]
    public POINT GetOffset()
    {
        POINT result;
        return *((delegate* unmanaged<ID2D1OffsetTransform, POINT*, POINT*>)((*lpVtbl)[5]))(
            this,
            &result
        );
    }

    public interface Interface : ID2D1TransformNode.Interface
    {
        [VtblIndex(4)]
        void SetOffset([NativeTypeName("D2D1_POINT_2L")] POINT offset);

        [VtblIndex(5)]
        [return: NativeTypeName("D2D1_POINT_2L")]
        POINT GetOffset();
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

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetInputCount;

        [NativeTypeName("void (D2D1_POINT_2L) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, void> SetOffset;

        [NativeTypeName("D2D1_POINT_2L () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, POINT*> GetOffset;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1OffsetTransform"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1OffsetTransform(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1TransformNode"/> to <see cref = "ID2D1OffsetTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1TransformNode"/> instance to be converted </param>
    public static explicit operator ID2D1OffsetTransform(Silk.NET.DirectX.ID2D1TransformNode value)
    {
        return new ID2D1OffsetTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1OffsetTransform"/> to <see cref = "Silk.NET.DirectX.ID2D1TransformNode"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1OffsetTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1TransformNode(ID2D1OffsetTransform value)
    {
        return new Silk.NET.DirectX.ID2D1TransformNode(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1OffsetTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1OffsetTransform(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1OffsetTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1OffsetTransform"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1OffsetTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1OffsetTransform value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
