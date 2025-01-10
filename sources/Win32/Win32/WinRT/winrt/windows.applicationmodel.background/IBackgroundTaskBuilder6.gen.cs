// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("80B47B17-EC8B-5653-850B-7508A01F52E7")]
[NativeTypeName("struct IBackgroundTaskBuilder6 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTaskBuilder6
    : IBackgroundTaskBuilder6.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTaskBuilder6));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder6, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBackgroundTaskBuilder6, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder6, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder6, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder6, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder6, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllowRunningTaskInStandby([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder6, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AllowRunningTaskInStandby([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder6, byte, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Validate([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder6, byte*, int>)((*lpVtbl)[8]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Register(
        HSTRING taskName,
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **"
        )]
            IBackgroundTaskRegistration* result
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundTaskBuilder6,
                HSTRING,
                IBackgroundTaskRegistration*,
                int>)((*lpVtbl)[9])
        )(this, taskName, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllowRunningTaskInStandby([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_AllowRunningTaskInStandby([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT Validate([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(9)]
        HRESULT Register(
            HSTRING taskName,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **"
            )]
                IBackgroundTaskRegistration* result
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AllowRunningTaskInStandby;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AllowRunningTaskInStandby;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> Validate;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IBackgroundTaskRegistration*, int> Register;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundTaskBuilder6"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundTaskBuilder6(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundTaskBuilder6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundTaskBuilder6(Silk.NET.WinRT.IInspectable value)
    {
        return new IBackgroundTaskBuilder6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTaskBuilder6"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTaskBuilder6"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBackgroundTaskBuilder6 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundTaskBuilder6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundTaskBuilder6(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundTaskBuilder6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTaskBuilder6"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTaskBuilder6"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundTaskBuilder6 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
