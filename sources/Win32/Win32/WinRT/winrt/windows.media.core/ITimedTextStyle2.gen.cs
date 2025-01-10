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

[Guid("655F492D-6111-4787-89CC-686FECE57E14")]
[NativeTypeName("struct ITimedTextStyle2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextStyle2 : ITimedTextStyle2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextStyle2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITimedTextStyle2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITimedTextStyle2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITimedTextStyle2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITimedTextStyle2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITimedTextStyle2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FontStyle(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextFontStyle *")]
            TimedTextFontStyle* value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle2, TimedTextFontStyle*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_FontStyle(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextFontStyle")] TimedTextFontStyle value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle2, TimedTextFontStyle, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsUnderlineEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ITimedTextStyle2, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IsUnderlineEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ITimedTextStyle2, byte, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsLineThroughEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ITimedTextStyle2, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsLineThroughEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ITimedTextStyle2, byte, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsOverlineEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ITimedTextStyle2, byte*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IsOverlineEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ITimedTextStyle2, byte, int>)((*lpVtbl)[13]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FontStyle(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextFontStyle *")]
                TimedTextFontStyle* value
        );

        [VtblIndex(7)]
        HRESULT put_FontStyle(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextFontStyle")]
                TimedTextFontStyle value
        );

        [VtblIndex(8)]
        HRESULT get_IsUnderlineEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IsUnderlineEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_IsLineThroughEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsLineThroughEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_IsOverlineEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_IsOverlineEnabled([NativeTypeName("boolean")] byte value);
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
            "HRESULT (ABI::Windows::Media::Core::TimedTextFontStyle *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextFontStyle*, int> get_FontStyle;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextFontStyle) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextFontStyle, int> put_FontStyle;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsUnderlineEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsUnderlineEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsLineThroughEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsLineThroughEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsOverlineEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsOverlineEnabled;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITimedTextStyle2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITimedTextStyle2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITimedTextStyle2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITimedTextStyle2(Silk.NET.WinRT.IInspectable value)
    {
        return new ITimedTextStyle2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextStyle2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextStyle2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITimedTextStyle2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITimedTextStyle2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITimedTextStyle2(Silk.NET.Windows.IUnknown value)
    {
        return new ITimedTextStyle2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextStyle2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextStyle2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITimedTextStyle2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
