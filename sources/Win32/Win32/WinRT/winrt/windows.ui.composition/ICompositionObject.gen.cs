// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("BCB4AD45-7609-4550-934F-16002A68FDED")]
[NativeTypeName("struct ICompositionObject : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionObject : ICompositionObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionObject));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionObject, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionObject, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionObject, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionObject, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionObject, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionObject, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Compositor(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositor **")] ICompositor* value
    )
    {
        return ((delegate* unmanaged<ICompositionObject, ICompositor*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Dispatcher(
        [NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher* value
    )
    {
        return ((delegate* unmanaged<ICompositionObject, ICoreDispatcher*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Properties(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPropertySet **")]
            ICompositionPropertySet* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionObject, ICompositionPropertySet*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartAnimation(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")]
            ICompositionAnimation animation
    )
    {
        return (
            (delegate* unmanaged<ICompositionObject, HSTRING, ICompositionAnimation, int>)(
                (*lpVtbl)[9]
            )
        )(this, propertyName, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StopAnimation(HSTRING propertyName)
    {
        return ((delegate* unmanaged<ICompositionObject, HSTRING, int>)((*lpVtbl)[10]))(
            this,
            propertyName
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Compositor(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositor **")] ICompositor* value
        );

        [VtblIndex(7)]
        HRESULT get_Dispatcher(
            [NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher* value
        );

        [VtblIndex(8)]
        HRESULT get_Properties(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPropertySet **")]
                ICompositionPropertySet* value
        );

        [VtblIndex(9)]
        HRESULT StartAnimation(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")]
                ICompositionAnimation animation
        );

        [VtblIndex(10)]
        HRESULT StopAnimation(HSTRING propertyName);
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
            "HRESULT (ABI::Windows::UI::Composition::ICompositor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositor*, int> get_Compositor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::ICoreDispatcher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICoreDispatcher*, int> get_Dispatcher;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionPropertySet **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionPropertySet*, int> get_Properties;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Composition::ICompositionAnimation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, ICompositionAnimation, int> StartAnimation;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> StopAnimation;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionObject(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionObject(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionObject"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionObject value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionObject(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionObject"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionObject value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
