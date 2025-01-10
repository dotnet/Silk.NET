// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("83F58412-E56B-4C75-A66E-0F63D57758A6")]
[NativeTypeName("struct ICalendarFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICalendarFactory : ICalendarFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICalendarFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICalendarFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICalendarFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICalendarFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICalendarFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICalendarFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICalendarFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateCalendarDefaultCalendarAndClock(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* languages,
        [NativeTypeName("ABI::Windows::Globalization::ICalendar **")] ICalendar* result
    )
    {
        return (
            (delegate* unmanaged<ICalendarFactory, IIterable<HSTRING>*, ICalendar*, int>)(
                (*lpVtbl)[6]
            )
        )(this, languages, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateCalendar(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* languages,
        HSTRING calendar,
        HSTRING clock,
        [NativeTypeName("ABI::Windows::Globalization::ICalendar **")] ICalendar* result
    )
    {
        return (
            (delegate* unmanaged<
                ICalendarFactory,
                IIterable<HSTRING>*,
                HSTRING,
                HSTRING,
                ICalendar*,
                int>)((*lpVtbl)[7])
        )(this, languages, calendar, clock, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateCalendarDefaultCalendarAndClock(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* languages,
            [NativeTypeName("ABI::Windows::Globalization::ICalendar **")] ICalendar* result
        );

        [VtblIndex(7)]
        HRESULT CreateCalendar(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* languages,
            HSTRING calendar,
            HSTRING clock,
            [NativeTypeName("ABI::Windows::Globalization::ICalendar **")] ICalendar* result
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Globalization::ICalendar **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            ICalendar*,
            int> CreateCalendarDefaultCalendarAndClock;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, HSTRING, HSTRING, ABI::Windows::Globalization::ICalendar **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            HSTRING,
            HSTRING,
            ICalendar*,
            int> CreateCalendar;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICalendarFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICalendarFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICalendarFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICalendarFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new ICalendarFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICalendarFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICalendarFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICalendarFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICalendarFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICalendarFactory(Silk.NET.Windows.IUnknown value)
    {
        return new ICalendarFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICalendarFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICalendarFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICalendarFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
