// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID2D1BlendTransform.xml' path='doc/member[@name="ID2D1BlendTransform"]/*'/>
[Guid("63AC0B32-BA44-450F-8806-7F4CA1FF2F1B")]
[NativeTypeName("struct ID2D1BlendTransform : ID2D1ConcreteTransform")]
[NativeInheritance("ID2D1ConcreteTransform")]
public unsafe partial struct ID2D1BlendTransform : ID2D1BlendTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BlendTransform));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1BlendTransform*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1BlendTransform*, uint> )(lpVtbl[1]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1BlendTransform*, uint> )(lpVtbl[2]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1TransformNode.GetInputCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<ID2D1BlendTransform*, uint> )(lpVtbl[3]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1ConcreteTransform.SetOutputBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
    {
        return ((delegate* unmanaged<ID2D1BlendTransform*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int> )(lpVtbl[4]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
    }

    /// <inheritdoc cref = "ID2D1ConcreteTransform.SetCached"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetCached(BOOL isCached)
    {
        ((delegate* unmanaged<ID2D1BlendTransform*, BOOL, void> )(lpVtbl[5]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), isCached);
    }

    /// <include file='ID2D1BlendTransform.xml' path='doc/member[@name="ID2D1BlendTransform.SetDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetDescription([NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* description)
    {
        ((delegate* unmanaged<ID2D1BlendTransform*, D2D1_BLEND_DESCRIPTION*, void> )(lpVtbl[6]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), description);
    }

    /// <include file='ID2D1BlendTransform.xml' path='doc/member[@name="ID2D1BlendTransform.GetDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetDescription(D2D1_BLEND_DESCRIPTION* description)
    {
        ((delegate* unmanaged<ID2D1BlendTransform*, D2D1_BLEND_DESCRIPTION*, void> )(lpVtbl[7]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), description);
    }

    public interface Interface : ID2D1ConcreteTransform.Interface
    {
        [VtblIndex(6)]
        void SetDescription([NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* description);
        [VtblIndex(7)]
        void GetDescription(D2D1_BLEND_DESCRIPTION* description);
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
        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetInputCount;
        [NativeTypeName("HRESULT (D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int> SetOutputBuffer;
        [NativeTypeName("void (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetCached;
        [NativeTypeName("void (const D2D1_BLEND_DESCRIPTION *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_BLEND_DESCRIPTION*, void> SetDescription;
        [NativeTypeName("void (D2D1_BLEND_DESCRIPTION *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_BLEND_DESCRIPTION*, void> GetDescription;
    }
}