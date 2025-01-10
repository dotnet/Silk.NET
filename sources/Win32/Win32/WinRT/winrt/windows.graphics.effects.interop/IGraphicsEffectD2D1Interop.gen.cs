// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.effects.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2FC57384-A068-44D7-A331-30982FCF7177")]
[NativeTypeName("struct IGraphicsEffectD2D1Interop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGraphicsEffectD2D1Interop
    : IGraphicsEffectD2D1Interop.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGraphicsEffectD2D1Interop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IGraphicsEffectD2D1Interop, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGraphicsEffectD2D1Interop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGraphicsEffectD2D1Interop, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEffectId(Guid* id)
    {
        return ((delegate* unmanaged<IGraphicsEffectD2D1Interop, Guid*, int>)((*lpVtbl)[3]))(
            this,
            id
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetNamedPropertyMapping(
        [NativeTypeName("LPCWSTR")] ushort* name,
        uint* index,
        [NativeTypeName("ABI::Windows::Graphics::Effects::GRAPHICS_EFFECT_PROPERTY_MAPPING *")]
            GRAPHICS_EFFECT_PROPERTY_MAPPING* mapping
    )
    {
        return (
            (delegate* unmanaged<
                IGraphicsEffectD2D1Interop,
                ushort*,
                uint*,
                GRAPHICS_EFFECT_PROPERTY_MAPPING*,
                int>)((*lpVtbl)[4])
        )(this, name, index, mapping);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPropertyCount(uint* count)
    {
        return ((delegate* unmanaged<IGraphicsEffectD2D1Interop, uint*, int>)((*lpVtbl)[5]))(
            this,
            count
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetProperty(
        uint index,
        [NativeTypeName("Windows::Foundation::IPropertyValue **")] IPropertyValue* value
    )
    {
        return (
            (delegate* unmanaged<IGraphicsEffectD2D1Interop, uint, IPropertyValue*, int>)(
                (*lpVtbl)[6]
            )
        )(this, index, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSource(uint index, IGraphicsEffectSource* source)
    {
        return (
            (delegate* unmanaged<IGraphicsEffectD2D1Interop, uint, IGraphicsEffectSource*, int>)(
                (*lpVtbl)[7]
            )
        )(this, index, source);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSourceCount(uint* count)
    {
        return ((delegate* unmanaged<IGraphicsEffectD2D1Interop, uint*, int>)((*lpVtbl)[8]))(
            this,
            count
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEffectId(Guid* id);

        [VtblIndex(4)]
        HRESULT GetNamedPropertyMapping(
            [NativeTypeName("LPCWSTR")] ushort* name,
            uint* index,
            [NativeTypeName("ABI::Windows::Graphics::Effects::GRAPHICS_EFFECT_PROPERTY_MAPPING *")]
                GRAPHICS_EFFECT_PROPERTY_MAPPING* mapping
        );

        [VtblIndex(5)]
        HRESULT GetPropertyCount(uint* count);

        [VtblIndex(6)]
        HRESULT GetProperty(
            uint index,
            [NativeTypeName("Windows::Foundation::IPropertyValue **")] IPropertyValue* value
        );

        [VtblIndex(7)]
        HRESULT GetSource(uint index, IGraphicsEffectSource* source);

        [VtblIndex(8)]
        HRESULT GetSourceCount(uint* count);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetEffectId;

        [NativeTypeName(
            "HRESULT (LPCWSTR, UINT *, GRAPHICS_EFFECT_PROPERTY_MAPPING *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint*,
            GRAPHICS_EFFECT_PROPERTY_MAPPING*,
            int> GetNamedPropertyMapping;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetPropertyCount;

        [NativeTypeName(
            "HRESULT (UINT, Windows::Foundation::IPropertyValue **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IPropertyValue*, int> GetProperty;

        [NativeTypeName(
            "HRESULT (UINT, IGraphicsEffectSource **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IGraphicsEffectSource*, int> GetSource;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSourceCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGraphicsEffectD2D1Interop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGraphicsEffectD2D1Interop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGraphicsEffectD2D1Interop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGraphicsEffectD2D1Interop(Silk.NET.Windows.IUnknown value)
    {
        return new IGraphicsEffectD2D1Interop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGraphicsEffectD2D1Interop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGraphicsEffectD2D1Interop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGraphicsEffectD2D1Interop value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
