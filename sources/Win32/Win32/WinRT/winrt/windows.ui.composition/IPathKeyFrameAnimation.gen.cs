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

[Guid("9D0D18C9-1576-4B3F-BE60-1D5031F5E71B")]
[NativeTypeName("struct IPathKeyFrameAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPathKeyFrameAnimation : IPathKeyFrameAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPathKeyFrameAnimation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPathKeyFrameAnimation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPathKeyFrameAnimation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPathKeyFrameAnimation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPathKeyFrameAnimation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPathKeyFrameAnimation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPathKeyFrameAnimation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InsertKeyFrame(
        float normalizedProgressKey,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPath *")] ICompositionPath path
    )
    {
        return (
            (delegate* unmanaged<IPathKeyFrameAnimation, float, ICompositionPath, int>)(
                (*lpVtbl)[6]
            )
        )(this, normalizedProgressKey, path);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertKeyFrameWithEasingFunction(
        float normalizedProgressKey,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPath *")] ICompositionPath path,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEasingFunction *")]
            ICompositionEasingFunction easingFunction
    )
    {
        return (
            (delegate* unmanaged<
                IPathKeyFrameAnimation,
                float,
                ICompositionPath,
                ICompositionEasingFunction,
                int>)((*lpVtbl)[7])
        )(this, normalizedProgressKey, path, easingFunction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT InsertKeyFrame(
            float normalizedProgressKey,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPath *")]
                ICompositionPath path
        );

        [VtblIndex(7)]
        HRESULT InsertKeyFrameWithEasingFunction(
            float normalizedProgressKey,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPath *")]
                ICompositionPath path,
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
            "HRESULT (FLOAT, ABI::Windows::UI::Composition::ICompositionPath *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float, ICompositionPath, int> InsertKeyFrame;

        [NativeTypeName(
            "HRESULT (FLOAT, ABI::Windows::UI::Composition::ICompositionPath *, ABI::Windows::UI::Composition::ICompositionEasingFunction *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            ICompositionPath,
            ICompositionEasingFunction,
            int> InsertKeyFrameWithEasingFunction;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPathKeyFrameAnimation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPathKeyFrameAnimation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPathKeyFrameAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPathKeyFrameAnimation(Silk.NET.WinRT.IInspectable value)
    {
        return new IPathKeyFrameAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPathKeyFrameAnimation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPathKeyFrameAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPathKeyFrameAnimation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPathKeyFrameAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPathKeyFrameAnimation(Silk.NET.Windows.IUnknown value)
    {
        return new IPathKeyFrameAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPathKeyFrameAnimation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPathKeyFrameAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPathKeyFrameAnimation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
