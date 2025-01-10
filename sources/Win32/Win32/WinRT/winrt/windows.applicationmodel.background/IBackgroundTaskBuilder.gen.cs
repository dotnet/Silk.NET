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

[Guid("0351550E-3E64-4572-A93A-84075A37C917")]
[NativeTypeName("struct IBackgroundTaskBuilder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTaskBuilder : IBackgroundTaskBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTaskBuilder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBackgroundTaskBuilder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_TaskEntryPoint(HSTRING value)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder, HSTRING, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TaskEntryPoint(HSTRING* value)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTrigger(
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger *")]
            IBackgroundTrigger trigger
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTaskBuilder, IBackgroundTrigger, int>)((*lpVtbl)[8])
        )(this, trigger);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddCondition(
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundCondition *")]
            IBackgroundCondition condition
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTaskBuilder, IBackgroundCondition, int>)((*lpVtbl)[9])
        )(this, condition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder, HSTRING, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IBackgroundTaskBuilder, HSTRING*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Register(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **"
        )]
            IBackgroundTaskRegistration* task
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTaskBuilder, IBackgroundTaskRegistration*, int>)(
                (*lpVtbl)[12]
            )
        )(this, task);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_TaskEntryPoint(HSTRING value);

        [VtblIndex(7)]
        HRESULT get_TaskEntryPoint(HSTRING* value);

        [VtblIndex(8)]
        HRESULT SetTrigger(
            [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger *")]
                IBackgroundTrigger trigger
        );

        [VtblIndex(9)]
        HRESULT AddCondition(
            [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundCondition *")]
                IBackgroundCondition condition
        );

        [VtblIndex(10)]
        HRESULT put_Name(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(12)]
        HRESULT Register(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **"
            )]
                IBackgroundTaskRegistration* task
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_TaskEntryPoint;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TaskEntryPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTrigger *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBackgroundTrigger, int> SetTrigger;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundCondition *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBackgroundCondition, int> AddCondition;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBackgroundTaskRegistration*, int> Register;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundTaskBuilder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundTaskBuilder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundTaskBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundTaskBuilder(Silk.NET.WinRT.IInspectable value)
    {
        return new IBackgroundTaskBuilder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTaskBuilder"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTaskBuilder"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBackgroundTaskBuilder value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundTaskBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundTaskBuilder(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundTaskBuilder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTaskBuilder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTaskBuilder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundTaskBuilder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
