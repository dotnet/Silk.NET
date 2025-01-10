// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("CD068EE1-C3FC-4FAD-9DDC-593FAA4B7885")]
[NativeTypeName("struct IConnectionProfileFilter2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionProfileFilter2
    : IConnectionProfileFilter2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionProfileFilter2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IConnectionProfileFilter2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConnectionProfileFilter2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IConnectionProfileFilter2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_IsRoaming(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")]
            IReference<byte>* value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfileFilter2, IReference<byte>*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsRoaming(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")]
            IReference<byte>** value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfileFilter2, IReference<byte>**, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsOverDataLimit(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")]
            IReference<byte>* value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfileFilter2, IReference<byte>*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsOverDataLimit(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")]
            IReference<byte>** value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfileFilter2, IReference<byte>**, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_IsBackgroundDataUsageRestricted(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")]
            IReference<byte>* value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfileFilter2, IReference<byte>*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsBackgroundDataUsageRestricted(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")]
            IReference<byte>** value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfileFilter2, IReference<byte>**, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RawData(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return ((delegate* unmanaged<IConnectionProfileFilter2, IBuffer*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_IsRoaming(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")]
                IReference<byte>* value
        );

        [VtblIndex(7)]
        HRESULT get_IsRoaming(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")]
                IReference<byte>** value
        );

        [VtblIndex(8)]
        HRESULT put_IsOverDataLimit(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")]
                IReference<byte>* value
        );

        [VtblIndex(9)]
        HRESULT get_IsOverDataLimit(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")]
                IReference<byte>** value
        );

        [VtblIndex(10)]
        HRESULT put_IsBackgroundDataUsageRestricted(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")]
                IReference<byte>* value
        );

        [VtblIndex(11)]
        HRESULT get_IsBackgroundDataUsageRestricted(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")]
                IReference<byte>** value
        );

        [VtblIndex(12)]
        HRESULT get_RawData(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
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
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<byte>*, int> put_IsRoaming;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<byte>**, int> get_IsRoaming;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<byte>*, int> put_IsOverDataLimit;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<byte>**, int> get_IsOverDataLimit;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<byte>*,
            int> put_IsBackgroundDataUsageRestricted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<byte>**,
            int> get_IsBackgroundDataUsageRestricted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> get_RawData;
    }

    /// <summary>Initializes a new instance of the <see cref = "IConnectionProfileFilter2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IConnectionProfileFilter2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IConnectionProfileFilter2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IConnectionProfileFilter2(Silk.NET.WinRT.IInspectable value)
    {
        return new IConnectionProfileFilter2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionProfileFilter2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionProfileFilter2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IConnectionProfileFilter2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IConnectionProfileFilter2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IConnectionProfileFilter2(Silk.NET.Windows.IUnknown value)
    {
        return new IConnectionProfileFilter2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionProfileFilter2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionProfileFilter2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IConnectionProfileFilter2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
