// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("9D11E77F-9EA6-47AF-A6EC-46784C5BA254")]
[NativeTypeName("struct IAppInstanceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppInstanceStatics : IAppInstanceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppInstanceStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppInstanceStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppInstanceStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppInstanceStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppInstanceStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppInstanceStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppInstanceStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RecommendedInstance(
        [NativeTypeName("ABI::Windows::ApplicationModel::IAppInstance **")] IAppInstance* value
    )
    {
        return ((delegate* unmanaged<IAppInstanceStatics, IAppInstance*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetActivatedEventArgs(
        [NativeTypeName("ABI::Windows::ApplicationModel::Activation::IActivatedEventArgs **")]
            IActivatedEventArgs* result
    )
    {
        return (
            (delegate* unmanaged<IAppInstanceStatics, IActivatedEventArgs*, int>)((*lpVtbl)[7])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindOrRegisterInstanceForKey(
        HSTRING key,
        [NativeTypeName("ABI::Windows::ApplicationModel::IAppInstance **")] IAppInstance* result
    )
    {
        return (
            (delegate* unmanaged<IAppInstanceStatics, HSTRING, IAppInstance*, int>)((*lpVtbl)[8])
        )(this, key, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Unregister()
    {
        return ((delegate* unmanaged<IAppInstanceStatics, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetInstances(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CAppInstance_t **"
        )]
            IVector<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IAppInstanceStatics, IVector<IntPtr>**, int>)((*lpVtbl)[10]))(
            this,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RecommendedInstance(
            [NativeTypeName("ABI::Windows::ApplicationModel::IAppInstance **")] IAppInstance* value
        );

        [VtblIndex(7)]
        HRESULT GetActivatedEventArgs(
            [NativeTypeName("ABI::Windows::ApplicationModel::Activation::IActivatedEventArgs **")]
                IActivatedEventArgs* result
        );

        [VtblIndex(8)]
        HRESULT FindOrRegisterInstanceForKey(
            HSTRING key,
            [NativeTypeName("ABI::Windows::ApplicationModel::IAppInstance **")] IAppInstance* result
        );

        [VtblIndex(9)]
        HRESULT Unregister();

        [VtblIndex(10)]
        HRESULT GetInstances(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CAppInstance_t **"
            )]
                IVector<IntPtr>** result
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
            "HRESULT (ABI::Windows::ApplicationModel::IAppInstance **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppInstance*, int> get_RecommendedInstance;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Activation::IActivatedEventArgs **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IActivatedEventArgs*, int> GetActivatedEventArgs;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::IAppInstance **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAppInstance*,
            int> FindOrRegisterInstanceForKey;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unregister;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CAppInstance_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> GetInstances;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppInstanceStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppInstanceStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppInstanceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppInstanceStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppInstanceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppInstanceStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppInstanceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppInstanceStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppInstanceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppInstanceStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IAppInstanceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppInstanceStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppInstanceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppInstanceStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
