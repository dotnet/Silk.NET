// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1OffsetTransform.xml' path='doc/member[@name="ID2D1OffsetTransform"]/*'/>
[Guid("3FE6ADEA-7643-4F53-BD14-A0CE63F24042")]
[NativeTypeName("struct ID2D1OffsetTransform : ID2D1TransformNode")]
[NativeInheritance("ID2D1TransformNode")]
public unsafe partial struct ID2D1OffsetTransform : ID2D1OffsetTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1OffsetTransform));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1OffsetTransform*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1OffsetTransform*, uint> )(lpVtbl[1]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1OffsetTransform*, uint> )(lpVtbl[2]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1TransformNode.GetInputCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<ID2D1OffsetTransform*, uint> )(lpVtbl[3]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1OffsetTransform.xml' path='doc/member[@name="ID2D1OffsetTransform.SetOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetOffset([NativeTypeName("D2D1_POINT_2L")] POINT offset)
    {
        ((delegate* unmanaged<ID2D1OffsetTransform*, POINT, void> )(lpVtbl[4]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this), offset);
    }

    /// <include file='ID2D1OffsetTransform.xml' path='doc/member[@name="ID2D1OffsetTransform.GetOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("D2D1_POINT_2L")]
    public POINT GetOffset()
    {
        POINT result;
        return *((delegate* unmanaged<ID2D1OffsetTransform*, POINT*, POINT*> )(lpVtbl[5]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this), &result);
    }

    public interface Interface : ID2D1TransformNode.Interface
    {
        [VtblIndex(4)]
        void SetOffset([NativeTypeName("D2D1_POINT_2L")] POINT offset);
        [VtblIndex(5)]
        [return: NativeTypeName("D2D1_POINT_2L")]
        POINT GetOffset();
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
        [NativeTypeName("void (D2D1_POINT_2L) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, void> SetOffset;
        [NativeTypeName("D2D1_POINT_2L () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, POINT*> GetOffset;
    }
}