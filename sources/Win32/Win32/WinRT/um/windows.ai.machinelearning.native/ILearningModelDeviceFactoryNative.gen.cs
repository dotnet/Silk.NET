// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1E9B31A1-662E-4AE0-AF67-F63BB337E634")]
[NativeTypeName("struct ILearningModelDeviceFactoryNative : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILearningModelDeviceFactoryNative
    : ILearningModelDeviceFactoryNative.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILearningModelDeviceFactoryNative));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ILearningModelDeviceFactoryNative, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILearningModelDeviceFactoryNative, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILearningModelDeviceFactoryNative, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateFromD3D12CommandQueue(ID3D12CommandQueue value, IUnknown* result)
    {
        return (
            (delegate* unmanaged<
                ILearningModelDeviceFactoryNative,
                ID3D12CommandQueue,
                IUnknown*,
                int>)((*lpVtbl)[3])
        )(this, value, result);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateFromD3D12CommandQueue(ID3D12CommandQueue value, IUnknown* result);
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

        [NativeTypeName("HRESULT (ID3D12CommandQueue *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D12CommandQueue,
            IUnknown*,
            int> CreateFromD3D12CommandQueue;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILearningModelDeviceFactoryNative"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILearningModelDeviceFactoryNative(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILearningModelDeviceFactoryNative"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILearningModelDeviceFactoryNative(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ILearningModelDeviceFactoryNative(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILearningModelDeviceFactoryNative"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILearningModelDeviceFactoryNative"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ILearningModelDeviceFactoryNative value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
