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

[Guid("F803F93B-3E99-595E-BBB7-78A2FA13C270")]
[NativeTypeName("struct ITimedTextStyle3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextStyle3 : ITimedTextStyle3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextStyle3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITimedTextStyle3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITimedTextStyle3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITimedTextStyle3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITimedTextStyle3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITimedTextStyle3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Ruby(
        [NativeTypeName("ABI::Windows::Media::Core::ITimedTextRuby **")] ITimedTextRuby* value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle3, ITimedTextRuby*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Bouten(
        [NativeTypeName("ABI::Windows::Media::Core::ITimedTextBouten **")] ITimedTextBouten* value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle3, ITimedTextBouten*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsTextCombined([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ITimedTextStyle3, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IsTextCombined([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ITimedTextStyle3, byte, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FontAngleInDegrees(double* value)
    {
        return ((delegate* unmanaged<ITimedTextStyle3, double*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_FontAngleInDegrees(double value)
    {
        return ((delegate* unmanaged<ITimedTextStyle3, double, int>)((*lpVtbl)[11]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Ruby(
            [NativeTypeName("ABI::Windows::Media::Core::ITimedTextRuby **")] ITimedTextRuby* value
        );

        [VtblIndex(7)]
        HRESULT get_Bouten(
            [NativeTypeName("ABI::Windows::Media::Core::ITimedTextBouten **")]
                ITimedTextBouten* value
        );

        [VtblIndex(8)]
        HRESULT get_IsTextCombined([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IsTextCombined([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_FontAngleInDegrees(double* value);

        [VtblIndex(11)]
        HRESULT put_FontAngleInDegrees(double value);
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
            "HRESULT (ABI::Windows::Media::Core::ITimedTextRuby **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITimedTextRuby*, int> get_Ruby;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::ITimedTextBouten **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITimedTextBouten*, int> get_Bouten;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsTextCombined;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsTextCombined;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_FontAngleInDegrees;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_FontAngleInDegrees;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITimedTextStyle3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITimedTextStyle3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITimedTextStyle3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITimedTextStyle3(Silk.NET.WinRT.IInspectable value)
    {
        return new ITimedTextStyle3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextStyle3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextStyle3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITimedTextStyle3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITimedTextStyle3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITimedTextStyle3(Silk.NET.Windows.IUnknown value)
    {
        return new ITimedTextStyle3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextStyle3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextStyle3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITimedTextStyle3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
