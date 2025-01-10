// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5B8C6B3D-24AE-41B5-A1BF-F0C3D544845B")]
[NativeTypeName("struct IWwwFormUrlDecoderRuntimeClassFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWwwFormUrlDecoderRuntimeClassFactory
    : IWwwFormUrlDecoderRuntimeClassFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWwwFormUrlDecoderRuntimeClassFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWwwFormUrlDecoder(
        HSTRING query,
        [NativeTypeName("ABI::Windows::Foundation::IWwwFormUrlDecoderRuntimeClass **")]
            IWwwFormUrlDecoderRuntimeClass* instance
    )
    {
        return (
            (delegate* unmanaged<
                IWwwFormUrlDecoderRuntimeClassFactory,
                HSTRING,
                IWwwFormUrlDecoderRuntimeClass*,
                int>)((*lpVtbl)[6])
        )(this, query, instance);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWwwFormUrlDecoder(
            HSTRING query,
            [NativeTypeName("ABI::Windows::Foundation::IWwwFormUrlDecoderRuntimeClass **")]
                IWwwFormUrlDecoderRuntimeClass* instance
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::IWwwFormUrlDecoderRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IWwwFormUrlDecoderRuntimeClass*,
            int> CreateWwwFormUrlDecoder;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWwwFormUrlDecoderRuntimeClassFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWwwFormUrlDecoderRuntimeClassFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWwwFormUrlDecoderRuntimeClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWwwFormUrlDecoderRuntimeClassFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IWwwFormUrlDecoderRuntimeClassFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWwwFormUrlDecoderRuntimeClassFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWwwFormUrlDecoderRuntimeClassFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IWwwFormUrlDecoderRuntimeClassFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWwwFormUrlDecoderRuntimeClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWwwFormUrlDecoderRuntimeClassFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IWwwFormUrlDecoderRuntimeClassFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWwwFormUrlDecoderRuntimeClassFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWwwFormUrlDecoderRuntimeClassFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IWwwFormUrlDecoderRuntimeClassFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
