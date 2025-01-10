// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("334B1F50-2292-4B35-99A1-25588D8C17FE")]
[NativeTypeName("struct IDxcContainerBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcContainerBuilder : IDxcContainerBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcContainerBuilder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcContainerBuilder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcContainerBuilder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcContainerBuilder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IDxcBlob pDxilContainerHeader)
    {
        return ((delegate* unmanaged<IDxcContainerBuilder, IDxcBlob, int>)((*lpVtbl)[3]))(
            this,
            pDxilContainerHeader
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddPart([NativeTypeName("UINT32")] uint fourCC, IDxcBlob pSource)
    {
        return ((delegate* unmanaged<IDxcContainerBuilder, uint, IDxcBlob, int>)((*lpVtbl)[4]))(
            this,
            fourCC,
            pSource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemovePart([NativeTypeName("UINT32")] uint fourCC)
    {
        return ((delegate* unmanaged<IDxcContainerBuilder, uint, int>)((*lpVtbl)[5]))(this, fourCC);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SerializeContainer(IDxcOperationResult* ppResult)
    {
        return (
            (delegate* unmanaged<IDxcContainerBuilder, IDxcOperationResult*, int>)((*lpVtbl)[6])
        )(this, ppResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Load(IDxcBlob pDxilContainerHeader);

        [VtblIndex(4)]
        HRESULT AddPart([NativeTypeName("UINT32")] uint fourCC, IDxcBlob pSource);

        [VtblIndex(5)]
        HRESULT RemovePart([NativeTypeName("UINT32")] uint fourCC);

        [VtblIndex(6)]
        HRESULT SerializeContainer(IDxcOperationResult* ppResult);
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

        [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob, int> Load;

        [NativeTypeName("HRESULT (UINT32, IDxcBlob *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDxcBlob, int> AddPart;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemovePart;

        [NativeTypeName("HRESULT (IDxcOperationResult **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcOperationResult*, int> SerializeContainer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcContainerBuilder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcContainerBuilder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcContainerBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcContainerBuilder(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcContainerBuilder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcContainerBuilder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcContainerBuilder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcContainerBuilder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
