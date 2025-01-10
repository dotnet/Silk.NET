// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.DirectX.D2D1_PIXEL_OPTIONS;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("693CE632-7F2F-45DE-93FE-18D88B37AA21")]
[NativeTypeName("struct ID2D1DrawInfo : ID2D1RenderInfo")]
[NativeInheritance("ID2D1RenderInfo")]
public unsafe partial struct ID2D1DrawInfo : ID2D1DrawInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1DrawInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1DrawInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1DrawInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1DrawInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInputDescription(
        [NativeTypeName("UINT32")] uint inputIndex,
        D2D1_INPUT_DESCRIPTION inputDescription
    )
    {
        return (
            (delegate* unmanaged<ID2D1DrawInfo, uint, D2D1_INPUT_DESCRIPTION, int>)((*lpVtbl)[3])
        )(this, inputIndex, inputDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOutputBuffer(
        D2D1_BUFFER_PRECISION bufferPrecision,
        D2D1_CHANNEL_DEPTH channelDepth
    )
    {
        return (
            (delegate* unmanaged<ID2D1DrawInfo, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int>)(
                (*lpVtbl)[4]
            )
        )(this, bufferPrecision, channelDepth);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetCached(BOOL isCached)
    {
        ((delegate* unmanaged<ID2D1DrawInfo, BOOL, void>)((*lpVtbl)[5]))(this, isCached);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetInstructionCountHint([NativeTypeName("UINT32")] uint instructionCount)
    {
        ((delegate* unmanaged<ID2D1DrawInfo, uint, void>)((*lpVtbl)[6]))(this, instructionCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPixelShaderConstantBuffer(
        [NativeTypeName("const BYTE *")] byte* buffer,
        [NativeTypeName("UINT32")] uint bufferCount
    )
    {
        return ((delegate* unmanaged<ID2D1DrawInfo, byte*, uint, int>)((*lpVtbl)[7]))(
            this,
            buffer,
            bufferCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetResourceTexture(
        [NativeTypeName("UINT32")] uint textureIndex,
        ID2D1ResourceTexture resourceTexture
    )
    {
        return (
            (delegate* unmanaged<ID2D1DrawInfo, uint, ID2D1ResourceTexture, int>)((*lpVtbl)[8])
        )(this, textureIndex, resourceTexture);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetVertexShaderConstantBuffer(
        [NativeTypeName("const BYTE *")] byte* buffer,
        [NativeTypeName("UINT32")] uint bufferCount
    )
    {
        return ((delegate* unmanaged<ID2D1DrawInfo, byte*, uint, int>)((*lpVtbl)[9]))(
            this,
            buffer,
            bufferCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPixelShader(
        [NativeTypeName("const GUID &")] Guid* shaderId,
        D2D1_PIXEL_OPTIONS pixelOptions = D2D1_PIXEL_OPTIONS_NONE
    )
    {
        return (
            (delegate* unmanaged<ID2D1DrawInfo, Guid*, D2D1_PIXEL_OPTIONS, int>)((*lpVtbl)[10])
        )(this, shaderId, pixelOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetVertexProcessing(
        ID2D1VertexBuffer vertexBuffer,
        D2D1_VERTEX_OPTIONS vertexOptions,
        [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")]
            D2D1_BLEND_DESCRIPTION* blendDescription = null,
        [NativeTypeName("const D2D1_VERTEX_RANGE *")] D2D1_VERTEX_RANGE* vertexRange = null,
        [NativeTypeName("const GUID *")] Guid* vertexShader = null
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DrawInfo,
                ID2D1VertexBuffer,
                D2D1_VERTEX_OPTIONS,
                D2D1_BLEND_DESCRIPTION*,
                D2D1_VERTEX_RANGE*,
                Guid*,
                int>)((*lpVtbl)[11])
        )(this, vertexBuffer, vertexOptions, blendDescription, vertexRange, vertexShader);
    }

    public interface Interface : ID2D1RenderInfo.Interface
    {
        [VtblIndex(7)]
        HRESULT SetPixelShaderConstantBuffer(
            [NativeTypeName("const BYTE *")] byte* buffer,
            [NativeTypeName("UINT32")] uint bufferCount
        );

        [VtblIndex(8)]
        HRESULT SetResourceTexture(
            [NativeTypeName("UINT32")] uint textureIndex,
            ID2D1ResourceTexture resourceTexture
        );

        [VtblIndex(9)]
        HRESULT SetVertexShaderConstantBuffer(
            [NativeTypeName("const BYTE *")] byte* buffer,
            [NativeTypeName("UINT32")] uint bufferCount
        );

        [VtblIndex(10)]
        HRESULT SetPixelShader(
            [NativeTypeName("const GUID &")] Guid* shaderId,
            D2D1_PIXEL_OPTIONS pixelOptions = D2D1_PIXEL_OPTIONS_NONE
        );

        [VtblIndex(11)]
        HRESULT SetVertexProcessing(
            ID2D1VertexBuffer vertexBuffer,
            D2D1_VERTEX_OPTIONS vertexOptions,
            [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")]
                D2D1_BLEND_DESCRIPTION* blendDescription = null,
            [NativeTypeName("const D2D1_VERTEX_RANGE *")] D2D1_VERTEX_RANGE* vertexRange = null,
            [NativeTypeName("const GUID *")] Guid* vertexShader = null
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
            "HRESULT (UINT32, D2D1_INPUT_DESCRIPTION) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D2D1_INPUT_DESCRIPTION, int> SetInputDescription;

        [NativeTypeName(
            "HRESULT (D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_BUFFER_PRECISION,
            D2D1_CHANNEL_DEPTH,
            int> SetOutputBuffer;

        [NativeTypeName("void (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetCached;

        [NativeTypeName("void (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> SetInstructionCountHint;

        [NativeTypeName(
            "HRESULT (const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte*, uint, int> SetPixelShaderConstantBuffer;

        [NativeTypeName(
            "HRESULT (UINT32, ID2D1ResourceTexture *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ID2D1ResourceTexture, int> SetResourceTexture;

        [NativeTypeName(
            "HRESULT (const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte*, uint, int> SetVertexShaderConstantBuffer;

        [NativeTypeName(
            "HRESULT (const GUID &, D2D1_PIXEL_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, D2D1_PIXEL_OPTIONS, int> SetPixelShader;

        [NativeTypeName(
            "HRESULT (ID2D1VertexBuffer *, D2D1_VERTEX_OPTIONS, const D2D1_BLEND_DESCRIPTION *, const D2D1_VERTEX_RANGE *, const GUID *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1VertexBuffer,
            D2D1_VERTEX_OPTIONS,
            D2D1_BLEND_DESCRIPTION*,
            D2D1_VERTEX_RANGE*,
            Guid*,
            int> SetVertexProcessing;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1DrawInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1DrawInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1RenderInfo"/> to <see cref = "ID2D1DrawInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1RenderInfo"/> instance to be converted </param>
    public static explicit operator ID2D1DrawInfo(Silk.NET.DirectX.ID2D1RenderInfo value)
    {
        return new ID2D1DrawInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DrawInfo"/> to <see cref = "Silk.NET.DirectX.ID2D1RenderInfo"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DrawInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1RenderInfo(ID2D1DrawInfo value)
    {
        return new Silk.NET.DirectX.ID2D1RenderInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1DrawInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1DrawInfo(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1DrawInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DrawInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DrawInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1DrawInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
