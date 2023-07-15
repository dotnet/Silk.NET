// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFTimedTextBouten.xml' path='doc/member[@name="IMFTimedTextBouten"]/*'/>
[Guid("3C5F3E8A-90C0-464E-8136-898D2975F847")]
[NativeTypeName("struct IMFTimedTextBouten : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTimedTextBouten : IMFTimedTextBouten.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextBouten));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextBouten*, Guid*, void**, int> )(lpVtbl[0]))((IMFTimedTextBouten*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTimedTextBouten*, uint> )(lpVtbl[1]))((IMFTimedTextBouten*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextBouten*, uint> )(lpVtbl[2]))((IMFTimedTextBouten*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextBouten.xml' path='doc/member[@name="IMFTimedTextBouten.GetBoutenType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBoutenType(MF_TIMED_TEXT_BOUTEN_TYPE* value)
    {
        return ((delegate* unmanaged<IMFTimedTextBouten*, MF_TIMED_TEXT_BOUTEN_TYPE*, int> )(lpVtbl[3]))((IMFTimedTextBouten*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMFTimedTextBouten.xml' path='doc/member[@name="IMFTimedTextBouten.GetBoutenColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBoutenColor(MFARGB* value)
    {
        return ((delegate* unmanaged<IMFTimedTextBouten*, MFARGB*, int> )(lpVtbl[4]))((IMFTimedTextBouten*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMFTimedTextBouten.xml' path='doc/member[@name="IMFTimedTextBouten.GetBoutenPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBoutenPosition(MF_TIMED_TEXT_BOUTEN_POSITION* value)
    {
        return ((delegate* unmanaged<IMFTimedTextBouten*, MF_TIMED_TEXT_BOUTEN_POSITION*, int> )(lpVtbl[5]))((IMFTimedTextBouten*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBoutenType(MF_TIMED_TEXT_BOUTEN_TYPE* value);
        [VtblIndex(4)]
        HRESULT GetBoutenColor(MFARGB* value);
        [VtblIndex(5)]
        HRESULT GetBoutenPosition(MF_TIMED_TEXT_BOUTEN_POSITION* value);
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
        [NativeTypeName("HRESULT (MF_TIMED_TEXT_BOUTEN_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_BOUTEN_TYPE*, int> GetBoutenType;
        [NativeTypeName("HRESULT (MFARGB *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFARGB*, int> GetBoutenColor;
        [NativeTypeName("HRESULT (MF_TIMED_TEXT_BOUTEN_POSITION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_BOUTEN_POSITION*, int> GetBoutenPosition;
    }
}