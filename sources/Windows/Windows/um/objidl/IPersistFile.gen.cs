// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IPersistFile.xml' path='doc/member[@name="IPersistFile"]/*'/>
[Guid("0000010B-0000-0000-C000-000000000046")]
[NativeTypeName("struct IPersistFile : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistFile : IPersistFile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistFile));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistFile*, Guid*, void**, int> )(lpVtbl[0]))((IPersistFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistFile*, uint> )(lpVtbl[1]))((IPersistFile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistFile*, uint> )(lpVtbl[2]))((IPersistFile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPersist.GetClassID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistFile*, Guid*, int> )(lpVtbl[3]))((IPersistFile*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <include file='IPersistFile.xml' path='doc/member[@name="IPersistFile.IsDirty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistFile*, int> )(lpVtbl[4]))((IPersistFile*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPersistFile.xml' path='doc/member[@name="IPersistFile.Load"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("DWORD")] uint dwMode)
    {
        return ((delegate* unmanaged<IPersistFile*, ushort*, uint, int> )(lpVtbl[5]))((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName, dwMode);
    }

    /// <include file='IPersistFile.xml' path='doc/member[@name="IPersistFile.Save"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save([NativeTypeName("LPCOLESTR")] ushort* pszFileName, BOOL fRemember)
    {
        return ((delegate* unmanaged<IPersistFile*, ushort*, BOOL, int> )(lpVtbl[6]))((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName, fRemember);
    }

    /// <include file='IPersistFile.xml' path='doc/member[@name="IPersistFile.SaveCompleted"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SaveCompleted([NativeTypeName("LPCOLESTR")] ushort* pszFileName)
    {
        return ((delegate* unmanaged<IPersistFile*, ushort*, int> )(lpVtbl[7]))((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName);
    }

    /// <include file='IPersistFile.xml' path='doc/member[@name="IPersistFile.GetCurFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName)
    {
        return ((delegate* unmanaged<IPersistFile*, ushort**, int> )(lpVtbl[8]))((IPersistFile*)Unsafe.AsPointer(ref this), ppszFileName);
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT IsDirty();
        [VtblIndex(5)]
        HRESULT Load([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("DWORD")] uint dwMode);
        [VtblIndex(6)]
        HRESULT Save([NativeTypeName("LPCOLESTR")] ushort* pszFileName, BOOL fRemember);
        [VtblIndex(7)]
        HRESULT SaveCompleted([NativeTypeName("LPCOLESTR")] ushort* pszFileName);
        [VtblIndex(8)]
        HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName);
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
        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClassID;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDirty;
        [NativeTypeName("HRESULT (LPCOLESTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> Load;
        [NativeTypeName("HRESULT (LPCOLESTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL, int> Save;
        [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SaveCompleted;
        [NativeTypeName("HRESULT (LPOLESTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetCurFile;
    }
}