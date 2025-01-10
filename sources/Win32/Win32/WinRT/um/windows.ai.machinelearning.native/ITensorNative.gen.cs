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

[Guid("52F547EF-5B03-49B5-82D6-565F1EE0DD49")]
[NativeTypeName("struct ITensorNative : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITensorNative : ITensorNative.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITensorNative));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITensorNative, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITensorNative, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITensorNative, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(byte** value, [NativeTypeName("UINT32 *")] uint* capacity)
    {
        return ((delegate* unmanaged<ITensorNative, byte**, uint*, int>)((*lpVtbl)[3]))(
            this,
            value,
            capacity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetD3D12Resource(ID3D12Resource* result)
    {
        return ((delegate* unmanaged<ITensorNative, ID3D12Resource*, int>)((*lpVtbl)[4]))(
            this,
            result
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBuffer(byte** value, [NativeTypeName("UINT32 *")] uint* capacity);

        [VtblIndex(4)]
        HRESULT GetD3D12Resource(ID3D12Resource* result);
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

        [NativeTypeName("HRESULT (BYTE **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetBuffer;

        [NativeTypeName("HRESULT (ID3D12Resource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, int> GetD3D12Resource;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITensorNative"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITensorNative(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITensorNative"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITensorNative(Silk.NET.Windows.IUnknown value)
    {
        return new ITensorNative(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITensorNative"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITensorNative"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITensorNative value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
