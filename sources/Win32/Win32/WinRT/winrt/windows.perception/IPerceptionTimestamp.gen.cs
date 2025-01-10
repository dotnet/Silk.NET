// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("87C24804-A22E-4ADB-BA26-D78EF639BCF4")]
[NativeTypeName("struct IPerceptionTimestamp : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPerceptionTimestamp : IPerceptionTimestamp.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPerceptionTimestamp));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPerceptionTimestamp, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPerceptionTimestamp, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPerceptionTimestamp, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPerceptionTimestamp, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPerceptionTimestamp, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPerceptionTimestamp, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TargetTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IPerceptionTimestamp, WinRTDateTime*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PredictionAmount(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IPerceptionTimestamp, TimeSpan*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TargetTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(7)]
        HRESULT get_PredictionAmount(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_TargetTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_PredictionAmount;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPerceptionTimestamp"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPerceptionTimestamp(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPerceptionTimestamp"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPerceptionTimestamp(Silk.NET.WinRT.IInspectable value)
    {
        return new IPerceptionTimestamp(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPerceptionTimestamp"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPerceptionTimestamp"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPerceptionTimestamp value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPerceptionTimestamp"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPerceptionTimestamp(Silk.NET.Windows.IUnknown value)
    {
        return new IPerceptionTimestamp(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPerceptionTimestamp"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPerceptionTimestamp"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPerceptionTimestamp value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
