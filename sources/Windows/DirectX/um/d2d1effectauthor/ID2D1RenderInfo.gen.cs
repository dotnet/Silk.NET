// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID2D1RenderInfo.xml' path='doc/member[@name="ID2D1RenderInfo"]/*'/>
[Guid("519AE1BD-D19A-420D-B849-364F594776B7")]
[NativeTypeName("struct ID2D1RenderInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1RenderInfo : ID2D1RenderInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1RenderInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1RenderInfo*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1RenderInfo*, uint> )(lpVtbl[1]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1RenderInfo*, uint> )(lpVtbl[2]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1RenderInfo.xml' path='doc/member[@name="ID2D1RenderInfo.SetInputDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInputDescription([NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription)
    {
        return ((delegate* unmanaged<ID2D1RenderInfo*, uint, D2D1_INPUT_DESCRIPTION, int> )(lpVtbl[3]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this), inputIndex, inputDescription);
    }

    /// <include file='ID2D1RenderInfo.xml' path='doc/member[@name="ID2D1RenderInfo.SetOutputBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
    {
        return ((delegate* unmanaged<ID2D1RenderInfo*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int> )(lpVtbl[4]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
    }

    /// <include file='ID2D1RenderInfo.xml' path='doc/member[@name="ID2D1RenderInfo.SetCached"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetCached(BOOL isCached)
    {
        ((delegate* unmanaged<ID2D1RenderInfo*, BOOL, void> )(lpVtbl[5]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this), isCached);
    }

    /// <include file='ID2D1RenderInfo.xml' path='doc/member[@name="ID2D1RenderInfo.SetInstructionCountHint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetInstructionCountHint([NativeTypeName("UINT32")] uint instructionCount)
    {
        ((delegate* unmanaged<ID2D1RenderInfo*, uint, void> )(lpVtbl[6]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this), instructionCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetInputDescription([NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription);
        [VtblIndex(4)]
        HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);
        [VtblIndex(5)]
        void SetCached(BOOL isCached);
        [VtblIndex(6)]
        void SetInstructionCountHint([NativeTypeName("UINT32")] uint instructionCount);
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
    }
}