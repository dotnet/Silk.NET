// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("CB7490AC-8A0F-44EC-9B7B-6F4CAFE8E9AB")]
[NativeTypeName("struct DirectMLTensorFlowCreatorID : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct DirectMLTensorFlowCreatorID
    : DirectMLTensorFlowCreatorID.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_DirectMLTensorFlowCreatorID));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<DirectMLTensorFlowCreatorID, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<DirectMLTensorFlowCreatorID, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<DirectMLTensorFlowCreatorID, uint>)((*lpVtbl)[2]))(this);
    }

    public interface Interface : IUnknown.Interface { }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
    }

    /// <summary>Initializes a new instance of the <see cref = "DirectMLTensorFlowCreatorID"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public DirectMLTensorFlowCreatorID(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "DirectMLTensorFlowCreatorID"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator DirectMLTensorFlowCreatorID(Silk.NET.Windows.IUnknown value)
    {
        return new DirectMLTensorFlowCreatorID(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "DirectMLTensorFlowCreatorID"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "DirectMLTensorFlowCreatorID"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(DirectMLTensorFlowCreatorID value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
