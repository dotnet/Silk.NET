// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfReverseConversionMgr.xml' path='doc/member[@name="ITfReverseConversionMgr"]/*'/>
[Guid("B643C236-C493-41B6-ABB3-692412775CC4")]
[NativeTypeName("struct ITfReverseConversionMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfReverseConversionMgr : ITfReverseConversionMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfReverseConversionMgr));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfReverseConversionMgr*, Guid*, void**, int> )(lpVtbl[0]))((ITfReverseConversionMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfReverseConversionMgr*, uint> )(lpVtbl[1]))((ITfReverseConversionMgr*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfReverseConversionMgr*, uint> )(lpVtbl[2]))((ITfReverseConversionMgr*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfReverseConversionMgr.xml' path='doc/member[@name="ITfReverseConversionMgr.GetReverseConversion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetReverseConversion([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("DWORD")] uint dwflag, ITfReverseConversion** ppReverseConversion)
    {
        return ((delegate* unmanaged<ITfReverseConversionMgr*, ushort, Guid*, uint, ITfReverseConversion**, int> )(lpVtbl[3]))((ITfReverseConversionMgr*)Unsafe.AsPointer(ref this), langid, guidProfile, dwflag, ppReverseConversion);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetReverseConversion([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("DWORD")] uint dwflag, ITfReverseConversion** ppReverseConversion);
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
        [NativeTypeName("HRESULT (LANGID, const GUID &, DWORD, ITfReverseConversion **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, Guid*, uint, ITfReverseConversion**, int> GetReverseConversion;
    }
}