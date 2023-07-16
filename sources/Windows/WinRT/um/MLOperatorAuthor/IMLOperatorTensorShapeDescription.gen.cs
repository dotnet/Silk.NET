// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IMLOperatorTensorShapeDescription.xml' path='doc/member[@name="IMLOperatorTensorShapeDescription"]/*'/>
[Guid("F20E8CBE-3B28-4248-BE95-F96FBC6E4643")]
[NativeTypeName("struct IMLOperatorTensorShapeDescription : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMLOperatorTensorShapeDescription : IMLOperatorTensorShapeDescription.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMLOperatorTensorShapeDescription));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, Guid*, void**, int> )(lpVtbl[0]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint> )(lpVtbl[1]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint> )(lpVtbl[2]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMLOperatorTensorShapeDescription.xml' path='doc/member[@name="IMLOperatorTensorShapeDescription.GetInputTensorDimensionCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInputTensorDimensionCount([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t *")] uint* dimensionCount)
    {
        return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint*, int> )(lpVtbl[3]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this), inputIndex, dimensionCount);
    }

    /// <include file='IMLOperatorTensorShapeDescription.xml' path='doc/member[@name="IMLOperatorTensorShapeDescription.GetInputTensorShape"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetInputTensorShape([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions)
    {
        return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint, uint*, int> )(lpVtbl[4]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this), inputIndex, dimensionCount, dimensions);
    }

    /// <include file='IMLOperatorTensorShapeDescription.xml' path='doc/member[@name="IMLOperatorTensorShapeDescription.HasOutputShapeDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool HasOutputShapeDescription()
    {
        return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, byte> )(lpVtbl[5]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this)) != 0;
    }

    /// <include file='IMLOperatorTensorShapeDescription.xml' path='doc/member[@name="IMLOperatorTensorShapeDescription.GetOutputTensorDimensionCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOutputTensorDimensionCount([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t *")] uint* dimensionCount)
    {
        return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint*, int> )(lpVtbl[6]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this), outputIndex, dimensionCount);
    }

    /// <include file='IMLOperatorTensorShapeDescription.xml' path='doc/member[@name="IMLOperatorTensorShapeDescription.GetOutputTensorShape"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOutputTensorShape([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions)
    {
        return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint, uint*, int> )(lpVtbl[7]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this), outputIndex, dimensionCount, dimensions);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetInputTensorDimensionCount([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t *")] uint* dimensionCount);
        [VtblIndex(4)]
        HRESULT GetInputTensorShape([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions);
        [VtblIndex(5)]
        bool HasOutputShapeDescription();
        [VtblIndex(6)]
        HRESULT GetOutputTensorDimensionCount([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t *")] uint* dimensionCount);
        [VtblIndex(7)]
        HRESULT GetOutputTensorShape([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions);
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
        [NativeTypeName("HRESULT (uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetInputTensorDimensionCount;
        [NativeTypeName("HRESULT (uint32_t, uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint*, int> GetInputTensorShape;
        [NativeTypeName("bool () const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte> HasOutputShapeDescription;
        [NativeTypeName("HRESULT (uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetOutputTensorDimensionCount;
        [NativeTypeName("HRESULT (uint32_t, uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint*, int> GetOutputTensorShape;
    }
}