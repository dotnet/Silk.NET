// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfFnBalloon.xml' path='doc/member[@name="ITfFnBalloon"]/*'/>
[Guid("3BAB89E4-5FBE-45F4-A5BC-DCA36AD225A8")]
[NativeTypeName("struct ITfFnBalloon : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfFnBalloon : ITfFnBalloon.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnBalloon));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnBalloon*, Guid*, void**, int> )(lpVtbl[0]))((ITfFnBalloon*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnBalloon*, uint> )(lpVtbl[1]))((ITfFnBalloon*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnBalloon*, uint> )(lpVtbl[2]))((ITfFnBalloon*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfFnBalloon.xml' path='doc/member[@name="ITfFnBalloon.UpdateBalloon"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UpdateBalloon(TfLBBalloonStyle style, [NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch)
    {
        return ((delegate* unmanaged<ITfFnBalloon*, TfLBBalloonStyle, ushort*, uint, int> )(lpVtbl[3]))((ITfFnBalloon*)Unsafe.AsPointer(ref this), style, pch, cch);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT UpdateBalloon(TfLBBalloonStyle style, [NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch);
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
        [NativeTypeName("HRESULT (TfLBBalloonStyle, const WCHAR *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TfLBBalloonStyle, ushort*, uint, int> UpdateBalloon;
    }
}