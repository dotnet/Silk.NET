// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IMLOperatorTensor.xml' path='doc/member[@name="IMLOperatorTensor"]/*'/>
[Guid("7FE41F41-F430-440E-AECE-54416DC8B9DB")]
[NativeTypeName("struct IMLOperatorTensor : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMLOperatorTensor : IMLOperatorTensor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMLOperatorTensor));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMLOperatorTensor*, Guid*, void**, int> )(lpVtbl[0]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMLOperatorTensor*, uint> )(lpVtbl[1]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMLOperatorTensor*, uint> )(lpVtbl[2]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMLOperatorTensor.xml' path='doc/member[@name="IMLOperatorTensor.GetDimensionCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("uint32_t")]
    public uint GetDimensionCount()
    {
        return ((delegate* unmanaged<IMLOperatorTensor*, uint> )(lpVtbl[3]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMLOperatorTensor.xml' path='doc/member[@name="IMLOperatorTensor.GetShape"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetShape([NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions)
    {
        return ((delegate* unmanaged<IMLOperatorTensor*, uint, uint*, int> )(lpVtbl[4]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this), dimensionCount, dimensions);
    }

    /// <include file='IMLOperatorTensor.xml' path='doc/member[@name="IMLOperatorTensor.GetTensorDataType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public MLOperatorTensorDataType GetTensorDataType()
    {
        return ((delegate* unmanaged<IMLOperatorTensor*, MLOperatorTensorDataType> )(lpVtbl[5]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMLOperatorTensor.xml' path='doc/member[@name="IMLOperatorTensor.IsCpuData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public bool IsCpuData()
    {
        return ((delegate* unmanaged<IMLOperatorTensor*, byte> )(lpVtbl[6]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this)) != 0;
    }

    /// <include file='IMLOperatorTensor.xml' path='doc/member[@name="IMLOperatorTensor.IsDataInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public bool IsDataInterface()
    {
        return ((delegate* unmanaged<IMLOperatorTensor*, byte> )(lpVtbl[7]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this)) != 0;
    }

    /// <include file='IMLOperatorTensor.xml' path='doc/member[@name="IMLOperatorTensor.GetData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void* GetData()
    {
        return ((delegate* unmanaged<IMLOperatorTensor*, void*> )(lpVtbl[8]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMLOperatorTensor.xml' path='doc/member[@name="IMLOperatorTensor.GetDataInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void GetDataInterface(IUnknown** dataInterface)
    {
        ((delegate* unmanaged<IMLOperatorTensor*, IUnknown**, void> )(lpVtbl[9]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this), dataInterface);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("uint32_t")]
        uint GetDimensionCount();
        [VtblIndex(4)]
        HRESULT GetShape([NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions);
        [VtblIndex(5)]
        MLOperatorTensorDataType GetTensorDataType();
        [VtblIndex(6)]
        bool IsCpuData();
        [VtblIndex(7)]
        bool IsDataInterface();
        [VtblIndex(8)]
        void* GetData();
        [VtblIndex(9)]
        void GetDataInterface(IUnknown** dataInterface);
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
        [NativeTypeName("uint32_t () const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetDimensionCount;
        [NativeTypeName("HRESULT (uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetShape;
        [NativeTypeName("MLOperatorTensorDataType () const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MLOperatorTensorDataType> GetTensorDataType;
        [NativeTypeName("bool () const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte> IsCpuData;
        [NativeTypeName("bool () const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte> IsDataInterface;
        [NativeTypeName("void *() noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetData;
        [NativeTypeName("void (IUnknown **) noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, void> GetDataInterface;
    }
}