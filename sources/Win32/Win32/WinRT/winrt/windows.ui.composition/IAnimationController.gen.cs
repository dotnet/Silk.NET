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

[Guid("C934EFD2-0722-4F5F-A4E2-9510F3D43BF7")]
[NativeTypeName("struct IAnimationController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAnimationController : IAnimationController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAnimationController));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAnimationController, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAnimationController, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAnimationController, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAnimationController, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAnimationController, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAnimationController, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PlaybackRate(float* value)
    {
        return ((delegate* unmanaged<IAnimationController, float*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PlaybackRate(float value)
    {
        return ((delegate* unmanaged<IAnimationController, float, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Progress(float* value)
    {
        return ((delegate* unmanaged<IAnimationController, float*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Progress(float value)
    {
        return ((delegate* unmanaged<IAnimationController, float, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ProgressBehavior(
        [NativeTypeName("ABI::Windows::UI::Composition::AnimationControllerProgressBehavior *")]
            AnimationControllerProgressBehavior* value
    )
    {
        return (
            (delegate* unmanaged<IAnimationController, AnimationControllerProgressBehavior*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ProgressBehavior(
        [NativeTypeName("ABI::Windows::UI::Composition::AnimationControllerProgressBehavior")]
            AnimationControllerProgressBehavior value
    )
    {
        return (
            (delegate* unmanaged<IAnimationController, AnimationControllerProgressBehavior, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IAnimationController, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IAnimationController, int>)((*lpVtbl)[13]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PlaybackRate(float* value);

        [VtblIndex(7)]
        HRESULT put_PlaybackRate(float value);

        [VtblIndex(8)]
        HRESULT get_Progress(float* value);

        [VtblIndex(9)]
        HRESULT put_Progress(float value);

        [VtblIndex(10)]
        HRESULT get_ProgressBehavior(
            [NativeTypeName("ABI::Windows::UI::Composition::AnimationControllerProgressBehavior *")]
                AnimationControllerProgressBehavior* value
        );

        [VtblIndex(11)]
        HRESULT put_ProgressBehavior(
            [NativeTypeName("ABI::Windows::UI::Composition::AnimationControllerProgressBehavior")]
                AnimationControllerProgressBehavior value
        );

        [VtblIndex(12)]
        HRESULT Pause();

        [VtblIndex(13)]
        HRESULT Resume();
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_PlaybackRate;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_PlaybackRate;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Progress;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_Progress;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::AnimationControllerProgressBehavior *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AnimationControllerProgressBehavior*,
            int> get_ProgressBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::AnimationControllerProgressBehavior) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AnimationControllerProgressBehavior,
            int> put_ProgressBehavior;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Resume;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAnimationController"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAnimationController(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAnimationController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAnimationController(Silk.NET.WinRT.IInspectable value)
    {
        return new IAnimationController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAnimationController"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAnimationController"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAnimationController value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAnimationController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAnimationController(Silk.NET.Windows.IUnknown value)
    {
        return new IAnimationController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAnimationController"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAnimationController"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAnimationController value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
