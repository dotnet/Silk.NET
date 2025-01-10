// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("404E5835-ECF6-4240-8520-671279CF36BC")]
[NativeTypeName("struct IQuaternionKeyFrameAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IQuaternionKeyFrameAnimation
    : IQuaternionKeyFrameAnimation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQuaternionKeyFrameAnimation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IQuaternionKeyFrameAnimation, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IQuaternionKeyFrameAnimation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQuaternionKeyFrameAnimation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IQuaternionKeyFrameAnimation, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IQuaternionKeyFrameAnimation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IQuaternionKeyFrameAnimation, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InsertKeyFrame(
        float normalizedProgressKey,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value
    )
    {
        return (
            (delegate* unmanaged<IQuaternionKeyFrameAnimation, float, Quaternion, int>)(
                (*lpVtbl)[6]
            )
        )(this, normalizedProgressKey, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertKeyFrameWithEasingFunction(
        float normalizedProgressKey,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEasingFunction *")]
            ICompositionEasingFunction easingFunction
    )
    {
        return (
            (delegate* unmanaged<
                IQuaternionKeyFrameAnimation,
                float,
                Quaternion,
                ICompositionEasingFunction,
                int>)((*lpVtbl)[7])
        )(this, normalizedProgressKey, value, easingFunction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT InsertKeyFrame(
            float normalizedProgressKey,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value
        );

        [VtblIndex(7)]
        HRESULT InsertKeyFrameWithEasingFunction(
            float normalizedProgressKey,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEasingFunction *")]
                ICompositionEasingFunction easingFunction
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
            "HRESULT (FLOAT, ABI::Windows::Foundation::Numerics::Quaternion) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float, Quaternion, int> InsertKeyFrame;

        [NativeTypeName(
            "HRESULT (FLOAT, ABI::Windows::Foundation::Numerics::Quaternion, ABI::Windows::UI::Composition::ICompositionEasingFunction *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            Quaternion,
            ICompositionEasingFunction,
            int> InsertKeyFrameWithEasingFunction;
    }

    /// <summary>Initializes a new instance of the <see cref = "IQuaternionKeyFrameAnimation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IQuaternionKeyFrameAnimation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IQuaternionKeyFrameAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IQuaternionKeyFrameAnimation(Silk.NET.WinRT.IInspectable value)
    {
        return new IQuaternionKeyFrameAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQuaternionKeyFrameAnimation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IQuaternionKeyFrameAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IQuaternionKeyFrameAnimation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IQuaternionKeyFrameAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IQuaternionKeyFrameAnimation(Silk.NET.Windows.IUnknown value)
    {
        return new IQuaternionKeyFrameAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQuaternionKeyFrameAnimation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IQuaternionKeyFrameAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IQuaternionKeyFrameAnimation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
