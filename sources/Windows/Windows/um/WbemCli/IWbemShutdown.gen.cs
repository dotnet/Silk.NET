// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWbemShutdown.xml' path='doc/member[@name="IWbemShutdown"]/*'/>
[Guid("B7B31DF9-D515-11D3-A11C-00105A1F515A")]
[NativeTypeName("struct IWbemShutdown : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemShutdown : IWbemShutdown.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemShutdown));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemShutdown*, Guid*, void**, int> )(lpVtbl[0]))((IWbemShutdown*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWbemShutdown*, uint> )(lpVtbl[1]))((IWbemShutdown*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemShutdown*, uint> )(lpVtbl[2]))((IWbemShutdown*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWbemShutdown.xml' path='doc/member[@name="IWbemShutdown.Shutdown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Shutdown([NativeTypeName("LONG")] int uReason, [NativeTypeName("ULONG")] uint uMaxMilliseconds, IWbemContext* pCtx)
    {
        return ((delegate* unmanaged<IWbemShutdown*, int, uint, IWbemContext*, int> )(lpVtbl[3]))((IWbemShutdown*)Unsafe.AsPointer(ref this), uReason, uMaxMilliseconds, pCtx);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Shutdown([NativeTypeName("LONG")] int uReason, [NativeTypeName("ULONG")] uint uMaxMilliseconds, IWbemContext* pCtx);
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
        [NativeTypeName("HRESULT (LONG, ULONG, IWbemContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, IWbemContext*, int> Shutdown;
    }
}