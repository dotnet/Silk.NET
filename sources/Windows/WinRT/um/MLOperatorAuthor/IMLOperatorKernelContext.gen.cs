// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IMLOperatorKernelContext.xml' path='doc/member[@name="IMLOperatorKernelContext"]/*'/>
[Guid("82536A28-F022-4769-9D3F-8B278F84C0C3")]
[NativeTypeName("struct IMLOperatorKernelContext : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMLOperatorKernelContext : IMLOperatorKernelContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMLOperatorKernelContext));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMLOperatorKernelContext*, Guid*, void**, int> )(lpVtbl[0]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMLOperatorKernelContext*, uint> )(lpVtbl[1]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMLOperatorKernelContext*, uint> )(lpVtbl[2]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMLOperatorKernelContext.xml' path='doc/member[@name="IMLOperatorKernelContext.GetInputTensor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInputTensor([NativeTypeName("uint32_t")] uint inputIndex, IMLOperatorTensor** tensor)
    {
        return ((delegate* unmanaged<IMLOperatorKernelContext*, uint, IMLOperatorTensor**, int> )(lpVtbl[3]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), inputIndex, tensor);
    }

    /// <include file='IMLOperatorKernelContext.xml' path='doc/member[@name="IMLOperatorKernelContext.GetOutputTensor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetOutputTensor([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("const uint32_t *")] uint* dimensionSizes, IMLOperatorTensor** tensor)
    {
        return ((delegate* unmanaged<IMLOperatorKernelContext*, uint, uint, uint*, IMLOperatorTensor**, int> )(lpVtbl[4]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), outputIndex, dimensionCount, dimensionSizes, tensor);
    }

    /// <include file='IMLOperatorKernelContext.xml' path='doc/member[@name="IMLOperatorKernelContext.GetOutputTensor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOutputTensor([NativeTypeName("uint32_t")] uint outputIndex, IMLOperatorTensor** tensor)
    {
        return ((delegate* unmanaged<IMLOperatorKernelContext*, uint, IMLOperatorTensor**, int> )(lpVtbl[5]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), outputIndex, tensor);
    }

    /// <include file='IMLOperatorKernelContext.xml' path='doc/member[@name="IMLOperatorKernelContext.AllocateTemporaryData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AllocateTemporaryData([NativeTypeName("size_t")] nuint size, IUnknown** data)
    {
        return ((delegate* unmanaged<IMLOperatorKernelContext*, nuint, IUnknown**, int> )(lpVtbl[6]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), size, data);
    }

    /// <include file='IMLOperatorKernelContext.xml' path='doc/member[@name="IMLOperatorKernelContext.GetExecutionInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetExecutionInterface(IUnknown** executionObject)
    {
        ((delegate* unmanaged<IMLOperatorKernelContext*, IUnknown**, void> )(lpVtbl[7]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), executionObject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetInputTensor([NativeTypeName("uint32_t")] uint inputIndex, IMLOperatorTensor** tensor);
        [VtblIndex(4)]
        HRESULT GetOutputTensor([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("const uint32_t *")] uint* dimensionSizes, IMLOperatorTensor** tensor);
        [VtblIndex(5)]
        HRESULT GetOutputTensor([NativeTypeName("uint32_t")] uint outputIndex, IMLOperatorTensor** tensor);
        [VtblIndex(6)]
        HRESULT AllocateTemporaryData([NativeTypeName("size_t")] nuint size, IUnknown** data);
        [VtblIndex(7)]
        void GetExecutionInterface(IUnknown** executionObject);
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
        [NativeTypeName("HRESULT (uint32_t, IMLOperatorTensor **) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMLOperatorTensor**, int> GetInputTensor;
        [NativeTypeName("HRESULT (uint32_t, uint32_t, const uint32_t *, IMLOperatorTensor **) noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint*, IMLOperatorTensor**, int> GetOutputTensor;
        [NativeTypeName("HRESULT (uint32_t, IMLOperatorTensor **) noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMLOperatorTensor**, int> GetOutputTensor1;
        [NativeTypeName("HRESULT (size_t, IUnknown **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, IUnknown**, int> AllocateTemporaryData;
        [NativeTypeName("void (IUnknown **) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, void> GetExecutionInterface;
    }
}