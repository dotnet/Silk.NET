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

[Guid("15389D7F-DBD8-4819-BF03-668E9357CD6D")]
[NativeTypeName("struct IAudioNode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNode : IAudioNode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNode));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioNode, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioNode, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioNode, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioNode, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioNode, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioNode, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EffectDefinitions(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IAudioNode, IVector<IntPtr>**, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_OutgoingGain(double value)
    {
        return ((delegate* unmanaged<IAudioNode, double, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutgoingGain(double* value)
    {
        return ((delegate* unmanaged<IAudioNode, double*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_EncodingProperties(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
            IAudioEncodingProperties* value
    )
    {
        return ((delegate* unmanaged<IAudioNode, IAudioEncodingProperties*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ConsumeInput([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAudioNode, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ConsumeInput([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAudioNode, byte, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IAudioNode, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IAudioNode, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IAudioNode, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DisableEffectsByDefinition(
        [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition *")]
            IAudioEffectDefinition definition
    )
    {
        return ((delegate* unmanaged<IAudioNode, IAudioEffectDefinition, int>)((*lpVtbl)[15]))(
            this,
            definition
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnableEffectsByDefinition(
        [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition *")]
            IAudioEffectDefinition definition
    )
    {
        return ((delegate* unmanaged<IAudioNode, IAudioEffectDefinition, int>)((*lpVtbl)[16]))(
            this,
            definition
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EffectDefinitions(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT put_OutgoingGain(double value);

        [VtblIndex(8)]
        HRESULT get_OutgoingGain(double* value);

        [VtblIndex(9)]
        HRESULT get_EncodingProperties(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
                IAudioEncodingProperties* value
        );

        [VtblIndex(10)]
        HRESULT get_ConsumeInput([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_ConsumeInput([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT Start();

        [VtblIndex(13)]
        HRESULT Stop();

        [VtblIndex(14)]
        HRESULT Reset();

        [VtblIndex(15)]
        HRESULT DisableEffectsByDefinition(
            [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition *")]
                IAudioEffectDefinition definition
        );

        [VtblIndex(16)]
        HRESULT EnableEffectsByDefinition(
            [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition *")]
                IAudioEffectDefinition definition
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_EffectDefinitions;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_OutgoingGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_OutgoingGain;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioEncodingProperties*, int> get_EncodingProperties;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ConsumeInput;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_ConsumeInput;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Effects::IAudioEffectDefinition *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioEffectDefinition, int> DisableEffectsByDefinition;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Effects::IAudioEffectDefinition *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioEffectDefinition, int> EnableEffectsByDefinition;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioNode"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioNode(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioNode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioNode(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioNode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioNode"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioNode"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioNode value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioNode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioNode(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioNode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioNode"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioNode"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioNode value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
