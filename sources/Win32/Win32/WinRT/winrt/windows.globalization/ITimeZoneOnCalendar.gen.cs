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

[Guid("BB3C25E5-46CF-4317-A3F5-02621AD54478")]
[NativeTypeName("struct ITimeZoneOnCalendar : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimeZoneOnCalendar : ITimeZoneOnCalendar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimeZoneOnCalendar));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITimeZoneOnCalendar, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITimeZoneOnCalendar, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITimeZoneOnCalendar, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITimeZoneOnCalendar, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITimeZoneOnCalendar, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITimeZoneOnCalendar, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTimeZone(HSTRING* value)
    {
        return ((delegate* unmanaged<ITimeZoneOnCalendar, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ChangeTimeZone(HSTRING timeZoneId)
    {
        return ((delegate* unmanaged<ITimeZoneOnCalendar, HSTRING, int>)((*lpVtbl)[7]))(
            this,
            timeZoneId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TimeZoneAsFullString(HSTRING* result)
    {
        return ((delegate* unmanaged<ITimeZoneOnCalendar, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TimeZoneAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result)
    {
        return ((delegate* unmanaged<ITimeZoneOnCalendar, int, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            idealLength,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetTimeZone(HSTRING* value);

        [VtblIndex(7)]
        HRESULT ChangeTimeZone(HSTRING timeZoneId);

        [VtblIndex(8)]
        HRESULT TimeZoneAsFullString(HSTRING* result);

        [VtblIndex(9)]
        HRESULT TimeZoneAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetTimeZone;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> ChangeTimeZone;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> TimeZoneAsFullString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> TimeZoneAsString;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITimeZoneOnCalendar"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITimeZoneOnCalendar(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITimeZoneOnCalendar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITimeZoneOnCalendar(Silk.NET.WinRT.IInspectable value)
    {
        return new ITimeZoneOnCalendar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimeZoneOnCalendar"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITimeZoneOnCalendar"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITimeZoneOnCalendar value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITimeZoneOnCalendar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITimeZoneOnCalendar(Silk.NET.Windows.IUnknown value)
    {
        return new ITimeZoneOnCalendar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimeZoneOnCalendar"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITimeZoneOnCalendar"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITimeZoneOnCalendar value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
