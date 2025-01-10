// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D9062783-5597-5092-820C-8F738E0F774A")]
[NativeTypeName("struct ITimedTextBouten : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextBouten : ITimedTextBouten.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextBouten));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITimedTextBouten, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITimedTextBouten, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITimedTextBouten, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITimedTextBouten, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITimedTextBouten, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITimedTextBouten, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Type(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenType *")]
            TimedTextBoutenType* value
    )
    {
        return ((delegate* unmanaged<ITimedTextBouten, TimedTextBoutenType*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Type(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenType")] TimedTextBoutenType value
    )
    {
        return ((delegate* unmanaged<ITimedTextBouten, TimedTextBoutenType, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<ITimedTextBouten, Color*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<ITimedTextBouten, Color, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Position(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenPosition *")]
            TimedTextBoutenPosition* value
    )
    {
        return (
            (delegate* unmanaged<ITimedTextBouten, TimedTextBoutenPosition*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Position(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenPosition")]
            TimedTextBoutenPosition value
    )
    {
        return (
            (delegate* unmanaged<ITimedTextBouten, TimedTextBoutenPosition, int>)((*lpVtbl)[11])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Type(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenType *")]
                TimedTextBoutenType* value
        );

        [VtblIndex(7)]
        HRESULT put_Type(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenType")]
                TimedTextBoutenType value
        );

        [VtblIndex(8)]
        HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(9)]
        HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(10)]
        HRESULT get_Position(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenPosition *")]
                TimedTextBoutenPosition* value
        );

        [VtblIndex(11)]
        HRESULT put_Position(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenPosition")]
                TimedTextBoutenPosition value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextBoutenType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextBoutenType*, int> get_Type;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextBoutenType) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextBoutenType, int> put_Type;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Color;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color, int> put_Color;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextBoutenPosition *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextBoutenPosition*, int> get_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextBoutenPosition) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextBoutenPosition, int> put_Position;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITimedTextBouten"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITimedTextBouten(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITimedTextBouten"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITimedTextBouten(Silk.NET.WinRT.IInspectable value)
    {
        return new ITimedTextBouten(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextBouten"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextBouten"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITimedTextBouten value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITimedTextBouten"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITimedTextBouten(Silk.NET.Windows.IUnknown value)
    {
        return new ITimedTextBouten(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextBouten"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextBouten"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITimedTextBouten value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
