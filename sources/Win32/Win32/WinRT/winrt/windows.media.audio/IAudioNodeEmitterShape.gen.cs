// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("EA0311C5-E73D-44BC-859C-45553BBC4828")]
[NativeTypeName("struct IAudioNodeEmitterShape : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeEmitterShape : IAudioNodeEmitterShape.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNodeEmitterShape));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioNodeEmitterShape, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioNodeEmitterShape, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioNodeEmitterShape, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioNodeEmitterShape, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioNodeEmitterShape, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioNodeEmitterShape, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Kind(
        [NativeTypeName("ABI::Windows::Media::Audio::AudioNodeEmitterShapeKind *")]
            AudioNodeEmitterShapeKind* value
    )
    {
        return (
            (delegate* unmanaged<IAudioNodeEmitterShape, AudioNodeEmitterShapeKind*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConeProperties(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterConeProperties **")]
            IAudioNodeEmitterConeProperties* value
    )
    {
        return (
            (delegate* unmanaged<IAudioNodeEmitterShape, IAudioNodeEmitterConeProperties*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Kind(
            [NativeTypeName("ABI::Windows::Media::Audio::AudioNodeEmitterShapeKind *")]
                AudioNodeEmitterShapeKind* value
        );

        [VtblIndex(7)]
        HRESULT get_ConeProperties(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterConeProperties **")]
                IAudioNodeEmitterConeProperties* value
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
            "HRESULT (ABI::Windows::Media::Audio::AudioNodeEmitterShapeKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AudioNodeEmitterShapeKind*, int> get_Kind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::IAudioNodeEmitterConeProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioNodeEmitterConeProperties*,
            int> get_ConeProperties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioNodeEmitterShape"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioNodeEmitterShape(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioNodeEmitterShape"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioNodeEmitterShape(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioNodeEmitterShape(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioNodeEmitterShape"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioNodeEmitterShape"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioNodeEmitterShape value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioNodeEmitterShape"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioNodeEmitterShape(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioNodeEmitterShape(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioNodeEmitterShape"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioNodeEmitterShape"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioNodeEmitterShape value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
