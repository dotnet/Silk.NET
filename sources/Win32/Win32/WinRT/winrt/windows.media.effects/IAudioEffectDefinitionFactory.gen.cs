// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8E1DA646-E705-45ED-8A2B-FC4E4F405A97")]
[NativeTypeName("struct IAudioEffectDefinitionFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioEffectDefinitionFactory
    : IAudioEffectDefinitionFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEffectDefinitionFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAudioEffectDefinitionFactory, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioEffectDefinitionFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioEffectDefinitionFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAudioEffectDefinitionFactory, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioEffectDefinitionFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAudioEffectDefinitionFactory, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        HSTRING activatableClassId,
        [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition **")]
            IAudioEffectDefinition* value
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEffectDefinitionFactory,
                HSTRING,
                IAudioEffectDefinition*,
                int>)((*lpVtbl)[6])
        )(this, activatableClassId, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithProperties(
        HSTRING activatableClassId,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet props,
        [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition **")]
            IAudioEffectDefinition* value
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEffectDefinitionFactory,
                HSTRING,
                IPropertySet,
                IAudioEffectDefinition*,
                int>)((*lpVtbl)[7])
        )(this, activatableClassId, props, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            HSTRING activatableClassId,
            [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition **")]
                IAudioEffectDefinition* value
        );

        [VtblIndex(7)]
        HRESULT CreateWithProperties(
            HSTRING activatableClassId,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet props,
            [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition **")]
                IAudioEffectDefinition* value
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
            "HRESULT (HSTRING, ABI::Windows::Media::Effects::IAudioEffectDefinition **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAudioEffectDefinition*, int> Create;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Media::Effects::IAudioEffectDefinition **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IPropertySet,
            IAudioEffectDefinition*,
            int> CreateWithProperties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioEffectDefinitionFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioEffectDefinitionFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioEffectDefinitionFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioEffectDefinitionFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioEffectDefinitionFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEffectDefinitionFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEffectDefinitionFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioEffectDefinitionFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioEffectDefinitionFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioEffectDefinitionFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioEffectDefinitionFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEffectDefinitionFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEffectDefinitionFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioEffectDefinitionFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
