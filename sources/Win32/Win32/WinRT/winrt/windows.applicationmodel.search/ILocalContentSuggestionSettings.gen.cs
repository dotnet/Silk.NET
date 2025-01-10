// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("EEAEB062-743D-456E-84A3-23F06F2D15D7")]
[NativeTypeName("struct ILocalContentSuggestionSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILocalContentSuggestionSettings
    : ILocalContentSuggestionSettings.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILocalContentSuggestionSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ILocalContentSuggestionSettings, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILocalContentSuggestionSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILocalContentSuggestionSettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ILocalContentSuggestionSettings, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ILocalContentSuggestionSettings, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ILocalContentSuggestionSettings, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Enabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ILocalContentSuggestionSettings, byte, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ILocalContentSuggestionSettings, byte*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Locations(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStorageFolder_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<ILocalContentSuggestionSettings, IVector<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AqsFilter(HSTRING value)
    {
        return ((delegate* unmanaged<ILocalContentSuggestionSettings, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AqsFilter(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ILocalContentSuggestionSettings, HSTRING*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PropertiesToMatch(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return (
            (delegate* unmanaged<ILocalContentSuggestionSettings, IVector<HSTRING>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Enabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_Locations(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStorageFolder_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(9)]
        HRESULT put_AqsFilter(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_AqsFilter(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_PropertiesToMatch(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_Enabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Enabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_Locations;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_AqsFilter;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AqsFilter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_PropertiesToMatch;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILocalContentSuggestionSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILocalContentSuggestionSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ILocalContentSuggestionSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ILocalContentSuggestionSettings(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ILocalContentSuggestionSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILocalContentSuggestionSettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ILocalContentSuggestionSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ILocalContentSuggestionSettings value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILocalContentSuggestionSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILocalContentSuggestionSettings(Silk.NET.Windows.IUnknown value)
    {
        return new ILocalContentSuggestionSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILocalContentSuggestionSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILocalContentSuggestionSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ILocalContentSuggestionSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
