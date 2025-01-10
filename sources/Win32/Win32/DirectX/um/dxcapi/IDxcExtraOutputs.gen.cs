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

[Guid("319B37A2-A5C2-494A-A5DE-4801B2FAF989")]
[NativeTypeName("struct IDxcExtraOutputs : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcExtraOutputs : IDxcExtraOutputs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcExtraOutputs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcExtraOutputs, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcExtraOutputs, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcExtraOutputs, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetOutputCount()
    {
        return ((delegate* unmanaged<IDxcExtraOutputs, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetOutput(
        [NativeTypeName("UINT32")] uint uIndex,
        [NativeTypeName("const IID &")] Guid* iid,
        void** ppvObject,
        [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppOutputType,
        [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppOutputName
    )
    {
        return (
            (delegate* unmanaged<
                IDxcExtraOutputs,
                uint,
                Guid*,
                void**,
                IDxcBlobUtf16*,
                IDxcBlobUtf16*,
                int>)((*lpVtbl)[4])
        )(this, uIndex, iid, ppvObject, ppOutputType, ppOutputName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        uint GetOutputCount();

        [VtblIndex(4)]
        HRESULT GetOutput(
            [NativeTypeName("UINT32")] uint uIndex,
            [NativeTypeName("const IID &")] Guid* iid,
            void** ppvObject,
            [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppOutputType,
            [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppOutputName
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

        [NativeTypeName("UINT32 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetOutputCount;

        [NativeTypeName(
            "HRESULT (UINT32, const IID &, void **, IDxcBlobWide **, IDxcBlobWide **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            Guid*,
            void**,
            IDxcBlobUtf16*,
            IDxcBlobUtf16*,
            int> GetOutput;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcExtraOutputs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcExtraOutputs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcExtraOutputs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcExtraOutputs(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcExtraOutputs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcExtraOutputs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcExtraOutputs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcExtraOutputs value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
