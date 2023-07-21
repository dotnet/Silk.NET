// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IErrorInfo.xml' path='doc/member[@name="IErrorInfo"]/*' />
[Guid("1CF2B120-547D-101B-8E65-08002B2BD119")]
[NativeTypeName("struct IErrorInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IErrorInfo : IErrorInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IErrorInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IErrorInfo*, Guid*, void**, int>)(lpVtbl[0]))((IErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IErrorInfo*, uint>)(lpVtbl[1]))((IErrorInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IErrorInfo*, uint>)(lpVtbl[2]))((IErrorInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IErrorInfo.xml' path='doc/member[@name="IErrorInfo.GetGUID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetGUID(Guid* pGUID)
    {
        return ((delegate* unmanaged<IErrorInfo*, Guid*, int>)(lpVtbl[3]))((IErrorInfo*)Unsafe.AsPointer(ref this), pGUID);
    }

    /// <include file='IErrorInfo.xml' path='doc/member[@name="IErrorInfo.GetSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSource([NativeTypeName("BSTR *")] ushort** pBstrSource)
    {
        return ((delegate* unmanaged<IErrorInfo*, ushort**, int>)(lpVtbl[4]))((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrSource);
    }

    /// <include file='IErrorInfo.xml' path='doc/member[@name="IErrorInfo.GetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pBstrDescription)
    {
        return ((delegate* unmanaged<IErrorInfo*, ushort**, int>)(lpVtbl[5]))((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrDescription);
    }

    /// <include file='IErrorInfo.xml' path='doc/member[@name="IErrorInfo.GetHelpFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetHelpFile([NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
    {
        return ((delegate* unmanaged<IErrorInfo*, ushort**, int>)(lpVtbl[6]))((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrHelpFile);
    }

    /// <include file='IErrorInfo.xml' path='doc/member[@name="IErrorInfo.GetHelpContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetHelpContext([NativeTypeName("DWORD *")] uint* pdwHelpContext)
    {
        return ((delegate* unmanaged<IErrorInfo*, uint*, int>)(lpVtbl[7]))((IErrorInfo*)Unsafe.AsPointer(ref this), pdwHelpContext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetGUID(Guid* pGUID);

        [VtblIndex(4)]
        HRESULT GetSource([NativeTypeName("BSTR *")] ushort** pBstrSource);

        [VtblIndex(5)]
        HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pBstrDescription);

        [VtblIndex(6)]
        HRESULT GetHelpFile([NativeTypeName("BSTR *")] ushort** pBstrHelpFile);

        [VtblIndex(7)]
        HRESULT GetHelpContext([NativeTypeName("DWORD *")] uint* pdwHelpContext);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSource;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetHelpFile;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetHelpContext;
    }
}
