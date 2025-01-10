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

[Guid("10335C29-5B3C-5693-9959-D05A0BD24628")]
[NativeTypeName("struct ITimedTextRuby : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextRuby : ITimedTextRuby.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextRuby));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITimedTextRuby, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITimedTextRuby, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITimedTextRuby, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITimedTextRuby, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITimedTextRuby, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITimedTextRuby, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged<ITimedTextRuby, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Text(HSTRING value)
    {
        return ((delegate* unmanaged<ITimedTextRuby, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Position(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyPosition *")]
            TimedTextRubyPosition* value
    )
    {
        return ((delegate* unmanaged<ITimedTextRuby, TimedTextRubyPosition*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Position(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyPosition")]
            TimedTextRubyPosition value
    )
    {
        return ((delegate* unmanaged<ITimedTextRuby, TimedTextRubyPosition, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Align(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyAlign *")]
            TimedTextRubyAlign* value
    )
    {
        return ((delegate* unmanaged<ITimedTextRuby, TimedTextRubyAlign*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Align(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyAlign")] TimedTextRubyAlign value
    )
    {
        return ((delegate* unmanaged<ITimedTextRuby, TimedTextRubyAlign, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Reserve(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyReserve *")]
            TimedTextRubyReserve* value
    )
    {
        return ((delegate* unmanaged<ITimedTextRuby, TimedTextRubyReserve*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Reserve(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyReserve")]
            TimedTextRubyReserve value
    )
    {
        return ((delegate* unmanaged<ITimedTextRuby, TimedTextRubyReserve, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Text(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Position(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyPosition *")]
                TimedTextRubyPosition* value
        );

        [VtblIndex(9)]
        HRESULT put_Position(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyPosition")]
                TimedTextRubyPosition value
        );

        [VtblIndex(10)]
        HRESULT get_Align(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyAlign *")]
                TimedTextRubyAlign* value
        );

        [VtblIndex(11)]
        HRESULT put_Align(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyAlign")]
                TimedTextRubyAlign value
        );

        [VtblIndex(12)]
        HRESULT get_Reserve(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyReserve *")]
                TimedTextRubyReserve* value
        );

        [VtblIndex(13)]
        HRESULT put_Reserve(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyReserve")]
                TimedTextRubyReserve value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Text;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextRubyPosition *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextRubyPosition*, int> get_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextRubyPosition) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextRubyPosition, int> put_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextRubyAlign *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextRubyAlign*, int> get_Align;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextRubyAlign) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextRubyAlign, int> put_Align;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextRubyReserve *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextRubyReserve*, int> get_Reserve;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextRubyReserve) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextRubyReserve, int> put_Reserve;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITimedTextRuby"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITimedTextRuby(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITimedTextRuby"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITimedTextRuby(Silk.NET.WinRT.IInspectable value)
    {
        return new ITimedTextRuby(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextRuby"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextRuby"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITimedTextRuby value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITimedTextRuby"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITimedTextRuby(Silk.NET.Windows.IUnknown value)
    {
        return new ITimedTextRuby(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextRuby"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextRuby"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITimedTextRuby value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
