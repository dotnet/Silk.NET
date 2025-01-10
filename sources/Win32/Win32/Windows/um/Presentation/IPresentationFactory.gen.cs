// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8FB37B58-1D74-4F64-A49C-1F97A80A2EC0")]
[NativeTypeName("struct IPresentationFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPresentationFactory : IPresentationFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentationFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPresentationFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPresentationFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPresentationFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("boolean")]
    public byte IsPresentationSupported()
    {
        return ((delegate* unmanaged<IPresentationFactory, byte>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("boolean")]
    public byte IsPresentationSupportedWithIndependentFlip()
    {
        return ((delegate* unmanaged<IPresentationFactory, byte>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreatePresentationManager(IPresentationManager* ppPresentationManager)
    {
        return (
            (delegate* unmanaged<IPresentationFactory, IPresentationManager*, int>)((*lpVtbl)[5])
        )(this, ppPresentationManager);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("boolean")]
        byte IsPresentationSupported();

        [VtblIndex(4)]
        [return: NativeTypeName("boolean")]
        byte IsPresentationSupportedWithIndependentFlip();

        [VtblIndex(5)]
        HRESULT CreatePresentationManager(IPresentationManager* ppPresentationManager);
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

        [NativeTypeName("boolean () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte> IsPresentationSupported;

        [NativeTypeName("boolean () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte> IsPresentationSupportedWithIndependentFlip;

        [NativeTypeName("HRESULT (IPresentationManager **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPresentationManager*, int> CreatePresentationManager;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPresentationFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPresentationFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPresentationFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPresentationFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IPresentationFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPresentationFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPresentationFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPresentationFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
