// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("1FBAD429-66AB-41CC-9617-667AC10E4459")]
[NativeTypeName("struct ID3D11ShaderTraceFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ID3D11ShaderTraceFactory
    : ID3D11ShaderTraceFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderTraceFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11ShaderTraceFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D11ShaderTraceFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11ShaderTraceFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateShaderTrace(
        IUnknown pShader,
        D3D11_SHADER_TRACE_DESC* pTraceDesc,
        ID3D11ShaderTrace* ppShaderTrace
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11ShaderTraceFactory,
                IUnknown,
                D3D11_SHADER_TRACE_DESC*,
                ID3D11ShaderTrace*,
                int>)((*lpVtbl)[3])
        )(this, pShader, pTraceDesc, ppShaderTrace);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateShaderTrace(
            IUnknown pShader,
            D3D11_SHADER_TRACE_DESC* pTraceDesc,
            ID3D11ShaderTrace* ppShaderTrace
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

        [NativeTypeName(
            "HRESULT (IUnknown *, D3D11_SHADER_TRACE_DESC *, ID3D11ShaderTrace **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            D3D11_SHADER_TRACE_DESC*,
            ID3D11ShaderTrace*,
            int> CreateShaderTrace;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11ShaderTraceFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11ShaderTraceFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11ShaderTraceFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11ShaderTraceFactory(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11ShaderTraceFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11ShaderTraceFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11ShaderTraceFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11ShaderTraceFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
