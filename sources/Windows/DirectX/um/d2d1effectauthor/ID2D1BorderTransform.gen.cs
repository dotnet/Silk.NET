// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1BorderTransform.xml' path='doc/member[@name="ID2D1BorderTransform"]/*'/>
[Guid("4998735C-3A19-473C-9781-656847E3A347")]
[NativeTypeName("struct ID2D1BorderTransform : ID2D1ConcreteTransform")]
[NativeInheritance("ID2D1ConcreteTransform")]
public unsafe partial struct ID2D1BorderTransform : ID2D1BorderTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BorderTransform));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1BorderTransform*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1BorderTransform*, uint> )(lpVtbl[1]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1BorderTransform*, uint> )(lpVtbl[2]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1TransformNode.GetInputCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<ID2D1BorderTransform*, uint> )(lpVtbl[3]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1ConcreteTransform.SetOutputBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
    {
        return ((delegate* unmanaged<ID2D1BorderTransform*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int> )(lpVtbl[4]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
    }

    /// <inheritdoc cref = "ID2D1ConcreteTransform.SetCached"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetCached(BOOL isCached)
    {
        ((delegate* unmanaged<ID2D1BorderTransform*, BOOL, void> )(lpVtbl[5]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), isCached);
    }

    /// <include file='ID2D1BorderTransform.xml' path='doc/member[@name="ID2D1BorderTransform.SetExtendModeX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetExtendModeX(D2D1_EXTEND_MODE extendMode)
    {
        ((delegate* unmanaged<ID2D1BorderTransform*, D2D1_EXTEND_MODE, void> )(lpVtbl[6]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), extendMode);
    }

    /// <include file='ID2D1BorderTransform.xml' path='doc/member[@name="ID2D1BorderTransform.SetExtendModeY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void SetExtendModeY(D2D1_EXTEND_MODE extendMode)
    {
        ((delegate* unmanaged<ID2D1BorderTransform*, D2D1_EXTEND_MODE, void> )(lpVtbl[7]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), extendMode);
    }

    /// <include file='ID2D1BorderTransform.xml' path='doc/member[@name="ID2D1BorderTransform.GetExtendModeX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public D2D1_EXTEND_MODE GetExtendModeX()
    {
        return ((delegate* unmanaged<ID2D1BorderTransform*, D2D1_EXTEND_MODE> )(lpVtbl[8]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1BorderTransform.xml' path='doc/member[@name="ID2D1BorderTransform.GetExtendModeY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public D2D1_EXTEND_MODE GetExtendModeY()
    {
        return ((delegate* unmanaged<ID2D1BorderTransform*, D2D1_EXTEND_MODE> )(lpVtbl[9]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID2D1ConcreteTransform.Interface
    {
        [VtblIndex(6)]
        void SetExtendModeX(D2D1_EXTEND_MODE extendMode);
        [VtblIndex(7)]
        void SetExtendModeY(D2D1_EXTEND_MODE extendMode);
        [VtblIndex(8)]
        D2D1_EXTEND_MODE GetExtendModeX();
        [VtblIndex(9)]
        D2D1_EXTEND_MODE GetExtendModeY();
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
        [NativeTypeName("void (D2D1_EXTEND_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE, void> SetExtendModeX;
        [NativeTypeName("void (D2D1_EXTEND_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE, void> SetExtendModeY;
        [NativeTypeName("D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE> GetExtendModeX;
        [NativeTypeName("D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE> GetExtendModeY;
    }
}