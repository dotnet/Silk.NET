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

[Guid("C1ED052F-1BA2-44BA-A904-6A882A0A5ADB")]
[NativeTypeName("struct ICompositionObjectStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionObjectStatics
    : ICompositionObjectStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionObjectStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionObjectStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionObjectStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionObjectStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionObjectStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionObjectStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionObjectStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StartAnimationWithIAnimationObject(
        [NativeTypeName("ABI::Windows::UI::Composition::IAnimationObject *")]
            IAnimationObject target,
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")]
            ICompositionAnimation animation
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionObjectStatics,
                IAnimationObject,
                HSTRING,
                ICompositionAnimation,
                int>)((*lpVtbl)[6])
        )(this, target, propertyName, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StartAnimationGroupWithIAnimationObject(
        [NativeTypeName("ABI::Windows::UI::Composition::IAnimationObject *")]
            IAnimationObject target,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")]
            ICompositionAnimationBase animation
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionObjectStatics,
                IAnimationObject,
                ICompositionAnimationBase,
                int>)((*lpVtbl)[7])
        )(this, target, animation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT StartAnimationWithIAnimationObject(
            [NativeTypeName("ABI::Windows::UI::Composition::IAnimationObject *")]
                IAnimationObject target,
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")]
                ICompositionAnimation animation
        );

        [VtblIndex(7)]
        HRESULT StartAnimationGroupWithIAnimationObject(
            [NativeTypeName("ABI::Windows::UI::Composition::IAnimationObject *")]
                IAnimationObject target,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")]
                ICompositionAnimationBase animation
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
            "HRESULT (ABI::Windows::UI::Composition::IAnimationObject *, HSTRING, ABI::Windows::UI::Composition::ICompositionAnimation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAnimationObject,
            HSTRING,
            ICompositionAnimation,
            int> StartAnimationWithIAnimationObject;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IAnimationObject *, ABI::Windows::UI::Composition::ICompositionAnimationBase *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAnimationObject,
            ICompositionAnimationBase,
            int> StartAnimationGroupWithIAnimationObject;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionObjectStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionObjectStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionObjectStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionObjectStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionObjectStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionObjectStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionObjectStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionObjectStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionObjectStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionObjectStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionObjectStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionObjectStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionObjectStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionObjectStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
