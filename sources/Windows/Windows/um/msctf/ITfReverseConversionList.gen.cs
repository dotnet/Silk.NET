// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfReverseConversionList.xml' path='doc/member[@name="ITfReverseConversionList"]/*'/>
[Guid("151D69F0-86F4-4674-B721-56911E797F47")]
[NativeTypeName("struct ITfReverseConversionList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfReverseConversionList : ITfReverseConversionList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfReverseConversionList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfReverseConversionList*, Guid*, void**, int> )(lpVtbl[0]))((ITfReverseConversionList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfReverseConversionList*, uint> )(lpVtbl[1]))((ITfReverseConversionList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfReverseConversionList*, uint> )(lpVtbl[2]))((ITfReverseConversionList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfReverseConversionList.xml' path='doc/member[@name="ITfReverseConversionList.GetLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetLength(uint* puIndex)
    {
        return ((delegate* unmanaged<ITfReverseConversionList*, uint*, int> )(lpVtbl[3]))((ITfReverseConversionList*)Unsafe.AsPointer(ref this), puIndex);
    }

    /// <include file='ITfReverseConversionList.xml' path='doc/member[@name="ITfReverseConversionList.GetString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetString(uint uIndex, [NativeTypeName("BSTR *")] ushort** pbstr)
    {
        return ((delegate* unmanaged<ITfReverseConversionList*, uint, ushort**, int> )(lpVtbl[4]))((ITfReverseConversionList*)Unsafe.AsPointer(ref this), uIndex, pbstr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetLength(uint* puIndex);
        [VtblIndex(4)]
        HRESULT GetString(uint uIndex, [NativeTypeName("BSTR *")] ushort** pbstr);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLength;
        [NativeTypeName("HRESULT (UINT, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetString;
    }
}