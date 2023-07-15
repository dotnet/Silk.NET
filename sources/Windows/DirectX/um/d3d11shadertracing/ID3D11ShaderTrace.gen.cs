// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D11ShaderTrace.xml' path='doc/member[@name="ID3D11ShaderTrace"]/*'/>
[Guid("36B013E6-2811-4845-BAA7-D623FE0DF104")]
[NativeTypeName("struct ID3D11ShaderTrace : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ID3D11ShaderTrace : ID3D11ShaderTrace.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderTrace));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11ShaderTrace*, Guid*, void**, int> )(lpVtbl[0]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11ShaderTrace*, uint> )(lpVtbl[1]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11ShaderTrace*, uint> )(lpVtbl[2]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderTrace.xml' path='doc/member[@name="ID3D11ShaderTrace.TraceReady"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT TraceReady([NativeTypeName("UINT64 *")] ulong* pTestCount)
    {
        return ((delegate* unmanaged<ID3D11ShaderTrace*, ulong*, int> )(lpVtbl[3]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pTestCount);
    }

    /// <include file='ID3D11ShaderTrace.xml' path='doc/member[@name="ID3D11ShaderTrace.ResetTrace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ResetTrace()
    {
        ((delegate* unmanaged<ID3D11ShaderTrace*, void> )(lpVtbl[4]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderTrace.xml' path='doc/member[@name="ID3D11ShaderTrace.GetTraceStats"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTraceStats(D3D11_TRACE_STATS* pTraceStats)
    {
        return ((delegate* unmanaged<ID3D11ShaderTrace*, D3D11_TRACE_STATS*, int> )(lpVtbl[5]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pTraceStats);
    }

    /// <include file='ID3D11ShaderTrace.xml' path='doc/member[@name="ID3D11ShaderTrace.PSSelectStamp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PSSelectStamp(uint stampIndex)
    {
        return ((delegate* unmanaged<ID3D11ShaderTrace*, uint, int> )(lpVtbl[6]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stampIndex);
    }

    /// <include file='ID3D11ShaderTrace.xml' path='doc/member[@name="ID3D11ShaderTrace.GetInitialRegisterContents"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetInitialRegisterContents(D3D11_TRACE_REGISTER* pRegister, D3D11_TRACE_VALUE* pValue)
    {
        return ((delegate* unmanaged<ID3D11ShaderTrace*, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int> )(lpVtbl[7]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pRegister, pValue);
    }

    /// <include file='ID3D11ShaderTrace.xml' path='doc/member[@name="ID3D11ShaderTrace.GetStep"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStep(uint stepIndex, D3D11_TRACE_STEP* pTraceStep)
    {
        return ((delegate* unmanaged<ID3D11ShaderTrace*, uint, D3D11_TRACE_STEP*, int> )(lpVtbl[8]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, pTraceStep);
    }

    /// <include file='ID3D11ShaderTrace.xml' path='doc/member[@name="ID3D11ShaderTrace.GetWrittenRegister"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, D3D11_TRACE_REGISTER* pRegister, D3D11_TRACE_VALUE* pValue)
    {
        return ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int> )(lpVtbl[9]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, writtenRegisterIndex, pRegister, pValue);
    }

    /// <include file='ID3D11ShaderTrace.xml' path='doc/member[@name="ID3D11ShaderTrace.GetReadRegister"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetReadRegister(uint stepIndex, uint readRegisterIndex, D3D11_TRACE_REGISTER* pRegister, D3D11_TRACE_VALUE* pValue)
    {
        return ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int> )(lpVtbl[10]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, readRegisterIndex, pRegister, pValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT TraceReady([NativeTypeName("UINT64 *")] ulong* pTestCount);
        [VtblIndex(4)]
        void ResetTrace();
        [VtblIndex(5)]
        HRESULT GetTraceStats(D3D11_TRACE_STATS* pTraceStats);
        [VtblIndex(6)]
        HRESULT PSSelectStamp(uint stampIndex);
        [VtblIndex(7)]
        HRESULT GetInitialRegisterContents(D3D11_TRACE_REGISTER* pRegister, D3D11_TRACE_VALUE* pValue);
        [VtblIndex(8)]
        HRESULT GetStep(uint stepIndex, D3D11_TRACE_STEP* pTraceStep);
        [VtblIndex(9)]
        HRESULT GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, D3D11_TRACE_REGISTER* pRegister, D3D11_TRACE_VALUE* pValue);
        [VtblIndex(10)]
        HRESULT GetReadRegister(uint stepIndex, uint readRegisterIndex, D3D11_TRACE_REGISTER* pRegister, D3D11_TRACE_VALUE* pValue);
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
        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> TraceReady;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ResetTrace;
        [NativeTypeName("HRESULT (D3D11_TRACE_STATS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_TRACE_STATS*, int> GetTraceStats;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> PSSelectStamp;
        [NativeTypeName("HRESULT (D3D11_TRACE_REGISTER *, D3D11_TRACE_VALUE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int> GetInitialRegisterContents;
        [NativeTypeName("HRESULT (UINT, D3D11_TRACE_STEP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D11_TRACE_STEP*, int> GetStep;
        [NativeTypeName("HRESULT (UINT, UINT, D3D11_TRACE_REGISTER *, D3D11_TRACE_VALUE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int> GetWrittenRegister;
        [NativeTypeName("HRESULT (UINT, UINT, D3D11_TRACE_REGISTER *, D3D11_TRACE_VALUE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int> GetReadRegister;
    }
}