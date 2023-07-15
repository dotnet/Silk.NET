// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.D2D1_PIXEL_OPTIONS;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1DrawInfo.xml' path='doc/member[@name="ID2D1DrawInfo"]/*'/>
[Guid("693CE632-7F2F-45DE-93FE-18D88B37AA21")]
[NativeTypeName("struct ID2D1DrawInfo : ID2D1RenderInfo")]
[NativeInheritance("ID2D1RenderInfo")]
public unsafe partial struct ID2D1DrawInfo : ID2D1DrawInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1DrawInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1DrawInfo*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1DrawInfo*, uint> )(lpVtbl[1]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1DrawInfo*, uint> )(lpVtbl[2]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1RenderInfo.SetInputDescription"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInputDescription([NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription)
    {
        return ((delegate* unmanaged<ID2D1DrawInfo*, uint, D2D1_INPUT_DESCRIPTION, int> )(lpVtbl[3]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), inputIndex, inputDescription);
    }

    /// <inheritdoc cref = "ID2D1RenderInfo.SetOutputBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
    {
        return ((delegate* unmanaged<ID2D1DrawInfo*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int> )(lpVtbl[4]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
    }

    /// <inheritdoc cref = "ID2D1RenderInfo.SetCached"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetCached(BOOL isCached)
    {
        ((delegate* unmanaged<ID2D1DrawInfo*, BOOL, void> )(lpVtbl[5]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), isCached);
    }

    /// <inheritdoc cref = "ID2D1RenderInfo.SetInstructionCountHint"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetInstructionCountHint([NativeTypeName("UINT32")] uint instructionCount)
    {
        ((delegate* unmanaged<ID2D1DrawInfo*, uint, void> )(lpVtbl[6]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), instructionCount);
    }

    /// <include file='ID2D1DrawInfo.xml' path='doc/member[@name="ID2D1DrawInfo.SetPixelShaderConstantBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPixelShaderConstantBuffer([NativeTypeName("const BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount)
    {
        return ((delegate* unmanaged<ID2D1DrawInfo*, byte*, uint, int> )(lpVtbl[7]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), buffer, bufferCount);
    }

    /// <include file='ID2D1DrawInfo.xml' path='doc/member[@name="ID2D1DrawInfo.SetResourceTexture"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetResourceTexture([NativeTypeName("UINT32")] uint textureIndex, ID2D1ResourceTexture* resourceTexture)
    {
        return ((delegate* unmanaged<ID2D1DrawInfo*, uint, ID2D1ResourceTexture*, int> )(lpVtbl[8]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), textureIndex, resourceTexture);
    }

    /// <include file='ID2D1DrawInfo.xml' path='doc/member[@name="ID2D1DrawInfo.SetVertexShaderConstantBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetVertexShaderConstantBuffer([NativeTypeName("const BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount)
    {
        return ((delegate* unmanaged<ID2D1DrawInfo*, byte*, uint, int> )(lpVtbl[9]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), buffer, bufferCount);
    }

    /// <include file='ID2D1DrawInfo.xml' path='doc/member[@name="ID2D1DrawInfo.SetPixelShader"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPixelShader([NativeTypeName("const GUID &")] Guid* shaderId, D2D1_PIXEL_OPTIONS pixelOptions = D2D1_PIXEL_OPTIONS_NONE)
    {
        return ((delegate* unmanaged<ID2D1DrawInfo*, Guid*, D2D1_PIXEL_OPTIONS, int> )(lpVtbl[10]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), shaderId, pixelOptions);
    }

    /// <include file='ID2D1DrawInfo.xml' path='doc/member[@name="ID2D1DrawInfo.SetVertexProcessing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetVertexProcessing(ID2D1VertexBuffer* vertexBuffer, D2D1_VERTEX_OPTIONS vertexOptions, [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* blendDescription = null, [NativeTypeName("const D2D1_VERTEX_RANGE *")] D2D1_VERTEX_RANGE* vertexRange = null, [NativeTypeName("const GUID *")] Guid* vertexShader = null)
    {
        return ((delegate* unmanaged<ID2D1DrawInfo*, ID2D1VertexBuffer*, D2D1_VERTEX_OPTIONS, D2D1_BLEND_DESCRIPTION*, D2D1_VERTEX_RANGE*, Guid*, int> )(lpVtbl[11]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), vertexBuffer, vertexOptions, blendDescription, vertexRange, vertexShader);
    }

    public interface Interface : ID2D1RenderInfo.Interface
    {
        [VtblIndex(7)]
        HRESULT SetPixelShaderConstantBuffer([NativeTypeName("const BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount);
        [VtblIndex(8)]
        HRESULT SetResourceTexture([NativeTypeName("UINT32")] uint textureIndex, ID2D1ResourceTexture* resourceTexture);
        [VtblIndex(9)]
        HRESULT SetVertexShaderConstantBuffer([NativeTypeName("const BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount);
        [VtblIndex(10)]
        HRESULT SetPixelShader([NativeTypeName("const GUID &")] Guid* shaderId, D2D1_PIXEL_OPTIONS pixelOptions = D2D1_PIXEL_OPTIONS_NONE);
        [VtblIndex(11)]
        HRESULT SetVertexProcessing(ID2D1VertexBuffer* vertexBuffer, D2D1_VERTEX_OPTIONS vertexOptions, [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* blendDescription = null, [NativeTypeName("const D2D1_VERTEX_RANGE *")] D2D1_VERTEX_RANGE* vertexRange = null, [NativeTypeName("const GUID *")] Guid* vertexShader = null);
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
        [NativeTypeName("HRESULT (UINT32, D2D1_INPUT_DESCRIPTION) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D2D1_INPUT_DESCRIPTION, int> SetInputDescription;
        [NativeTypeName("HRESULT (D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int> SetOutputBuffer;
        [NativeTypeName("void (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetCached;
        [NativeTypeName("void (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> SetInstructionCountHint;
        [NativeTypeName("HRESULT (const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> SetPixelShaderConstantBuffer;
        [NativeTypeName("HRESULT (UINT32, ID2D1ResourceTexture *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID2D1ResourceTexture*, int> SetResourceTexture;
        [NativeTypeName("HRESULT (const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> SetVertexShaderConstantBuffer;
        [NativeTypeName("HRESULT (const GUID &, D2D1_PIXEL_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, D2D1_PIXEL_OPTIONS, int> SetPixelShader;
        [NativeTypeName("HRESULT (ID2D1VertexBuffer *, D2D1_VERTEX_OPTIONS, const D2D1_BLEND_DESCRIPTION *, const D2D1_VERTEX_RANGE *, const GUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1VertexBuffer*, D2D1_VERTEX_OPTIONS, D2D1_BLEND_DESCRIPTION*, D2D1_VERTEX_RANGE*, Guid*, int> SetVertexProcessing;
    }
}