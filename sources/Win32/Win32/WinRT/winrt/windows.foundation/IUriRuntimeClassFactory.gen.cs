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

[Guid("44A9796F-723E-4FDF-A218-033E75B0C084")]
[NativeTypeName("struct IUriRuntimeClassFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUriRuntimeClassFactory
    : IUriRuntimeClassFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUriRuntimeClassFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUriRuntimeClassFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUriRuntimeClassFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUriRuntimeClassFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUriRuntimeClassFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUriRuntimeClassFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUriRuntimeClassFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateUri(
        HSTRING uri,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* instance
    )
    {
        return (
            (delegate* unmanaged<IUriRuntimeClassFactory, HSTRING, IUriRuntimeClass*, int>)(
                (*lpVtbl)[6]
            )
        )(this, uri, instance);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithRelativeUri(
        HSTRING baseUri,
        HSTRING relativeUri,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* instance
    )
    {
        return (
            (delegate* unmanaged<
                IUriRuntimeClassFactory,
                HSTRING,
                HSTRING,
                IUriRuntimeClass*,
                int>)((*lpVtbl)[7])
        )(this, baseUri, relativeUri, instance);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateUri(
            HSTRING uri,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* instance
        );

        [VtblIndex(7)]
        HRESULT CreateWithRelativeUri(
            HSTRING baseUri,
            HSTRING relativeUri,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* instance
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IUriRuntimeClass*, int> CreateUri;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IUriRuntimeClass*,
            int> CreateWithRelativeUri;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUriRuntimeClassFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUriRuntimeClassFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUriRuntimeClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUriRuntimeClassFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IUriRuntimeClassFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUriRuntimeClassFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUriRuntimeClassFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUriRuntimeClassFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUriRuntimeClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUriRuntimeClassFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IUriRuntimeClassFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUriRuntimeClassFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUriRuntimeClassFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUriRuntimeClassFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
