// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISyncMgrHandlerCollection.xml' path='doc/member[@name="ISyncMgrHandlerCollection"]/*'/>
[Guid("A7F337A3-D20B-45CB-9ED7-87D094CA5045")]
[NativeTypeName("struct ISyncMgrHandlerCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrHandlerCollection : ISyncMgrHandlerCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrHandlerCollection));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrHandlerCollection*, Guid*, void**, int> )(lpVtbl[0]))((ISyncMgrHandlerCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrHandlerCollection*, uint> )(lpVtbl[1]))((ISyncMgrHandlerCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrHandlerCollection*, uint> )(lpVtbl[2]))((ISyncMgrHandlerCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrHandlerCollection.xml' path='doc/member[@name="ISyncMgrHandlerCollection.GetHandlerEnumerator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetHandlerEnumerator(IEnumString** ppenum)
    {
        return ((delegate* unmanaged<ISyncMgrHandlerCollection*, IEnumString**, int> )(lpVtbl[3]))((ISyncMgrHandlerCollection*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='ISyncMgrHandlerCollection.xml' path='doc/member[@name="ISyncMgrHandlerCollection.BindToHandler"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BindToHandler([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ISyncMgrHandlerCollection*, ushort*, Guid*, void**, int> )(lpVtbl[4]))((ISyncMgrHandlerCollection*)Unsafe.AsPointer(ref this), pszHandlerID, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetHandlerEnumerator(IEnumString** ppenum);
        [VtblIndex(4)]
        HRESULT BindToHandler([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumString**, int> GetHandlerEnumerator;
        [NativeTypeName("HRESULT (LPCWSTR, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, void**, int> BindToHandler;
    }
}