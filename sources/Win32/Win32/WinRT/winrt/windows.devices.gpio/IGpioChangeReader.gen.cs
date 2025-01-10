// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("0ABC885F-E031-48E8-8590-70DE78363C6D")]
[NativeTypeName("struct IGpioChangeReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioChangeReader : IGpioChangeReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioChangeReader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGpioChangeReader, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGpioChangeReader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGpioChangeReader, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGpioChangeReader, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGpioChangeReader, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGpioChangeReader, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Capacity([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IGpioChangeReader, int*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Length([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IGpioChangeReader, int*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsEmpty([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IGpioChangeReader, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsOverflowed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IGpioChangeReader, byte*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Polarity(
        [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity")] GpioChangePolarity value
    )
    {
        return ((delegate* unmanaged<IGpioChangeReader, GpioChangePolarity, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Polarity(
        [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity *")]
            GpioChangePolarity* value
    )
    {
        return ((delegate* unmanaged<IGpioChangeReader, GpioChangePolarity*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IGpioChangeReader, byte*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IGpioChangeReader, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IGpioChangeReader, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<IGpioChangeReader, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetNextItem(
        [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeRecord *")] GpioChangeRecord* value
    )
    {
        return ((delegate* unmanaged<IGpioChangeReader, GpioChangeRecord*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PeekNextItem(
        [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeRecord *")] GpioChangeRecord* value
    )
    {
        return ((delegate* unmanaged<IGpioChangeReader, GpioChangeRecord*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetAllItems(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CGpio__CGpioChangeRecord_t **"
        )]
            IVector<GpioChangeRecord>** value
    )
    {
        return (
            (delegate* unmanaged<IGpioChangeReader, IVector<GpioChangeRecord>**, int>)(
                (*lpVtbl)[18]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WaitForItemsAsync(
        [NativeTypeName("INT32")] int count,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IGpioChangeReader, int, IAsyncAction*, int>)((*lpVtbl)[19]))(
            this,
            count,
            operation
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Capacity([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_Length([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_IsEmpty([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsOverflowed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_Polarity(
            [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity")]
                GpioChangePolarity value
        );

        [VtblIndex(11)]
        HRESULT get_Polarity(
            [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity *")]
                GpioChangePolarity* value
        );

        [VtblIndex(12)]
        HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT Start();

        [VtblIndex(14)]
        HRESULT Stop();

        [VtblIndex(15)]
        HRESULT Clear();

        [VtblIndex(16)]
        HRESULT GetNextItem(
            [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeRecord *")]
                GpioChangeRecord* value
        );

        [VtblIndex(17)]
        HRESULT PeekNextItem(
            [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeRecord *")]
                GpioChangeRecord* value
        );

        [VtblIndex(18)]
        HRESULT GetAllItems(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CGpio__CGpioChangeRecord_t **"
            )]
                IVector<GpioChangeRecord>** value
        );

        [VtblIndex(19)]
        HRESULT WaitForItemsAsync(
            [NativeTypeName("INT32")] int count,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Capacity;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Length;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsEmpty;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsOverflowed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::GpioChangePolarity) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GpioChangePolarity, int> put_Polarity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::GpioChangePolarity *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GpioChangePolarity*, int> get_Polarity;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsStarted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::GpioChangeRecord *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GpioChangeRecord*, int> GetNextItem;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::GpioChangeRecord *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GpioChangeRecord*, int> PeekNextItem;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CGpio__CGpioChangeRecord_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<GpioChangeRecord>**, int> GetAllItems;

        [NativeTypeName(
            "HRESULT (INT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, IAsyncAction*, int> WaitForItemsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGpioChangeReader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGpioChangeReader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGpioChangeReader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGpioChangeReader(Silk.NET.WinRT.IInspectable value)
    {
        return new IGpioChangeReader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGpioChangeReader"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGpioChangeReader"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGpioChangeReader value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGpioChangeReader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGpioChangeReader(Silk.NET.Windows.IUnknown value)
    {
        return new IGpioChangeReader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGpioChangeReader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGpioChangeReader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGpioChangeReader value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
