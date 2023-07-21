// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1DrawingStateBlock.xml' path='doc/member[@name="ID2D1DrawingStateBlock"]/*' />
[Guid("28506E39-EBF6-46A1-BB47-FD85565AB957")]
[NativeTypeName("struct ID2D1DrawingStateBlock : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1DrawingStateBlock : ID2D1DrawingStateBlock.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1DrawingStateBlock));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1DrawingStateBlock*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1DrawingStateBlock*, uint>)(lpVtbl[1]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1DrawingStateBlock*, uint>)(lpVtbl[2]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Resource.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1DrawingStateBlock*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), factory);
    }

    /// <include file='ID2D1DrawingStateBlock.xml' path='doc/member[@name="ID2D1DrawingStateBlock.GetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
    {
        ((delegate* unmanaged<ID2D1DrawingStateBlock*, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(lpVtbl[4]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), stateDescription);
    }

    /// <include file='ID2D1DrawingStateBlock.xml' path='doc/member[@name="ID2D1DrawingStateBlock.SetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
    {
        ((delegate* unmanaged<ID2D1DrawingStateBlock*, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(lpVtbl[5]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), stateDescription);
    }

    /// <include file='ID2D1DrawingStateBlock.xml' path='doc/member[@name="ID2D1DrawingStateBlock.SetTextRenderingParams"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null)
    {
        ((delegate* unmanaged<ID2D1DrawingStateBlock*, IDWriteRenderingParams*, void>)(lpVtbl[6]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), textRenderingParams);
    }

    /// <include file='ID2D1DrawingStateBlock.xml' path='doc/member[@name="ID2D1DrawingStateBlock.GetTextRenderingParams"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
    {
        ((delegate* unmanaged<ID2D1DrawingStateBlock*, IDWriteRenderingParams**, void>)(lpVtbl[7]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), textRenderingParams);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

        [VtblIndex(5)]
        void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

        [VtblIndex(6)]
        void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null);

        [VtblIndex(7)]
        void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams);
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

        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Factory**, void> GetFactory;

        [NativeTypeName("void (D2D1_DRAWING_STATE_DESCRIPTION *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_DRAWING_STATE_DESCRIPTION*, void> GetDescription;

        [NativeTypeName("void (const D2D1_DRAWING_STATE_DESCRIPTION *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_DRAWING_STATE_DESCRIPTION*, void> SetDescription;

        [NativeTypeName("void (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteRenderingParams*, void> SetTextRenderingParams;

        [NativeTypeName("void (IDWriteRenderingParams **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteRenderingParams**, void> GetTextRenderingParams;
    }
}
