// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IBindCtx.xml' path='doc/member[@name="IBindCtx"]/*'/>
[Guid("0000000E-0000-0000-C000-000000000046")]
[NativeTypeName("struct IBindCtx : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBindCtx : IBindCtx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindCtx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBindCtx*, Guid*, void**, int> )(lpVtbl[0]))((IBindCtx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBindCtx*, uint> )(lpVtbl[1]))((IBindCtx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBindCtx*, uint> )(lpVtbl[2]))((IBindCtx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBindCtx.xml' path='doc/member[@name="IBindCtx.RegisterObjectBound"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterObjectBound(IUnknown* punk)
    {
        return ((delegate* unmanaged<IBindCtx*, IUnknown*, int> )(lpVtbl[3]))((IBindCtx*)Unsafe.AsPointer(ref this), punk);
    }

    /// <include file='IBindCtx.xml' path='doc/member[@name="IBindCtx.RevokeObjectBound"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RevokeObjectBound(IUnknown* punk)
    {
        return ((delegate* unmanaged<IBindCtx*, IUnknown*, int> )(lpVtbl[4]))((IBindCtx*)Unsafe.AsPointer(ref this), punk);
    }

    /// <include file='IBindCtx.xml' path='doc/member[@name="IBindCtx.ReleaseBoundObjects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReleaseBoundObjects()
    {
        return ((delegate* unmanaged<IBindCtx*, int> )(lpVtbl[5]))((IBindCtx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBindCtx.xml' path='doc/member[@name="IBindCtx.SetBindOptions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetBindOptions(BIND_OPTS* pbindopts)
    {
        return ((delegate* unmanaged<IBindCtx*, BIND_OPTS*, int> )(lpVtbl[6]))((IBindCtx*)Unsafe.AsPointer(ref this), pbindopts);
    }

    /// <include file='IBindCtx.xml' path='doc/member[@name="IBindCtx.GetBindOptions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetBindOptions(BIND_OPTS* pbindopts)
    {
        return ((delegate* unmanaged<IBindCtx*, BIND_OPTS*, int> )(lpVtbl[7]))((IBindCtx*)Unsafe.AsPointer(ref this), pbindopts);
    }

    /// <include file='IBindCtx.xml' path='doc/member[@name="IBindCtx.GetRunningObjectTable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetRunningObjectTable(IRunningObjectTable** pprot)
    {
        return ((delegate* unmanaged<IBindCtx*, IRunningObjectTable**, int> )(lpVtbl[8]))((IBindCtx*)Unsafe.AsPointer(ref this), pprot);
    }

    /// <include file='IBindCtx.xml' path='doc/member[@name="IBindCtx.RegisterObjectParam"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RegisterObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, IUnknown* punk)
    {
        return ((delegate* unmanaged<IBindCtx*, ushort*, IUnknown*, int> )(lpVtbl[9]))((IBindCtx*)Unsafe.AsPointer(ref this), pszKey, punk);
    }

    /// <include file='IBindCtx.xml' path='doc/member[@name="IBindCtx.GetObjectParam"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<IBindCtx*, ushort*, IUnknown**, int> )(lpVtbl[10]))((IBindCtx*)Unsafe.AsPointer(ref this), pszKey, ppunk);
    }

    /// <include file='IBindCtx.xml' path='doc/member[@name="IBindCtx.EnumObjectParam"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EnumObjectParam(IEnumString** ppenum)
    {
        return ((delegate* unmanaged<IBindCtx*, IEnumString**, int> )(lpVtbl[11]))((IBindCtx*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='IBindCtx.xml' path='doc/member[@name="IBindCtx.RevokeObjectParam"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RevokeObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey)
    {
        return ((delegate* unmanaged<IBindCtx*, ushort*, int> )(lpVtbl[12]))((IBindCtx*)Unsafe.AsPointer(ref this), pszKey);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterObjectBound(IUnknown* punk);
        [VtblIndex(4)]
        HRESULT RevokeObjectBound(IUnknown* punk);
        [VtblIndex(5)]
        HRESULT ReleaseBoundObjects();
        [VtblIndex(6)]
        HRESULT SetBindOptions(BIND_OPTS* pbindopts);
        [VtblIndex(7)]
        HRESULT GetBindOptions(BIND_OPTS* pbindopts);
        [VtblIndex(8)]
        HRESULT GetRunningObjectTable(IRunningObjectTable** pprot);
        [VtblIndex(9)]
        HRESULT RegisterObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, IUnknown* punk);
        [VtblIndex(10)]
        HRESULT GetObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, IUnknown** ppunk);
        [VtblIndex(11)]
        HRESULT EnumObjectParam(IEnumString** ppenum);
        [VtblIndex(12)]
        HRESULT RevokeObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey);
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
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> RegisterObjectBound;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> RevokeObjectBound;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReleaseBoundObjects;
        [NativeTypeName("HRESULT (BIND_OPTS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BIND_OPTS*, int> SetBindOptions;
        [NativeTypeName("HRESULT (BIND_OPTS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BIND_OPTS*, int> GetBindOptions;
        [NativeTypeName("HRESULT (IRunningObjectTable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IRunningObjectTable**, int> GetRunningObjectTable;
        [NativeTypeName("HRESULT (LPOLESTR, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IUnknown*, int> RegisterObjectParam;
        [NativeTypeName("HRESULT (LPOLESTR, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IUnknown**, int> GetObjectParam;
        [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumString**, int> EnumObjectParam;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RevokeObjectParam;
    }
}