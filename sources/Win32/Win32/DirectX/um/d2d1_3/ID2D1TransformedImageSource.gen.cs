// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("7F1F79E5-2796-416C-8F55-700F911445E5")]
[NativeTypeName("struct ID2D1TransformedImageSource : ID2D1Image")]
[NativeInheritance("ID2D1Image")]
public unsafe partial struct ID2D1TransformedImageSource
    : ID2D1TransformedImageSource.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1TransformedImageSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID2D1TransformedImageSource, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1TransformedImageSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1TransformedImageSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1TransformedImageSource, ID2D1Factory*, void>)((*lpVtbl)[3]))(
            this,
            factory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetSource(ID2D1ImageSource* imageSource)
    {
        ((delegate* unmanaged<ID2D1TransformedImageSource, ID2D1ImageSource*, void>)((*lpVtbl)[4]))(
            this,
            imageSource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void GetProperties(D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties)
    {
        (
            (delegate* unmanaged<
                ID2D1TransformedImageSource,
                D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*,
                void>)((*lpVtbl)[5])
        )(this, properties);
    }

    public interface Interface : ID2D1Image.Interface
    {
        [VtblIndex(4)]
        void GetSource(ID2D1ImageSource* imageSource);

        [VtblIndex(5)]
        void GetProperties(D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties);
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
            "void (ID2D1ImageSource **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1ImageSource*, void> GetSource;

        [NativeTypeName(
            "void (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*,
            void> GetProperties;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1TransformedImageSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1TransformedImageSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Image"/> to <see cref = "ID2D1TransformedImageSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Image"/> instance to be converted </param>
    public static explicit operator ID2D1TransformedImageSource(Silk.NET.DirectX.ID2D1Image value)
    {
        return new ID2D1TransformedImageSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1TransformedImageSource"/> to <see cref = "Silk.NET.DirectX.ID2D1Image"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1TransformedImageSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Image(ID2D1TransformedImageSource value)
    {
        return new Silk.NET.DirectX.ID2D1Image(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1TransformedImageSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1TransformedImageSource(
        Silk.NET.DirectX.ID2D1Resource value
    )
    {
        return new ID2D1TransformedImageSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1TransformedImageSource"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1TransformedImageSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(
        ID2D1TransformedImageSource value
    )
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1TransformedImageSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1TransformedImageSource(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1TransformedImageSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1TransformedImageSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1TransformedImageSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1TransformedImageSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
