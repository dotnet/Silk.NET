// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMarkupContainer2.xml' path='doc/member[@name="IMarkupContainer2"]/*'/>
[Guid("3050F648-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IMarkupContainer2 : IMarkupContainer")]
[NativeInheritance("IMarkupContainer")]
public unsafe partial struct IMarkupContainer2 : IMarkupContainer2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMarkupContainer2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMarkupContainer2*, Guid*, void**, int> )(lpVtbl[0]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMarkupContainer2*, uint> )(lpVtbl[1]))((IMarkupContainer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMarkupContainer2*, uint> )(lpVtbl[2]))((IMarkupContainer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMarkupContainer.OwningDoc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OwningDoc(IHTMLDocument2** ppDoc)
    {
        return ((delegate* unmanaged<IMarkupContainer2*, IHTMLDocument2**, int> )(lpVtbl[3]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), ppDoc);
    }

    /// <include file='IMarkupContainer2.xml' path='doc/member[@name="IMarkupContainer2.CreateChangeLog"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateChangeLog(IHTMLChangeSink* pChangeSink, IHTMLChangeLog** ppChangeLog, BOOL fForward, BOOL fBackward)
    {
        return ((delegate* unmanaged<IMarkupContainer2*, IHTMLChangeSink*, IHTMLChangeLog**, BOOL, BOOL, int> )(lpVtbl[4]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), pChangeSink, ppChangeLog, fForward, fBackward);
    }

    /// <include file='IMarkupContainer2.xml' path='doc/member[@name="IMarkupContainer2.RegisterForDirtyRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterForDirtyRange(IHTMLChangeSink* pChangeSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IMarkupContainer2*, IHTMLChangeSink*, uint*, int> )(lpVtbl[5]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), pChangeSink, pdwCookie);
    }

    /// <include file='IMarkupContainer2.xml' path='doc/member[@name="IMarkupContainer2.UnRegisterForDirtyRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnRegisterForDirtyRange([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IMarkupContainer2*, uint, int> )(lpVtbl[6]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <include file='IMarkupContainer2.xml' path='doc/member[@name="IMarkupContainer2.GetAndClearDirtyRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAndClearDirtyRange([NativeTypeName("DWORD")] uint dwCookie, IMarkupPointer* pIPointerBegin, IMarkupPointer* pIPointerEnd)
    {
        return ((delegate* unmanaged<IMarkupContainer2*, uint, IMarkupPointer*, IMarkupPointer*, int> )(lpVtbl[7]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), dwCookie, pIPointerBegin, pIPointerEnd);
    }

    /// <include file='IMarkupContainer2.xml' path='doc/member[@name="IMarkupContainer2.GetVersionNumber"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("long")]
    public int GetVersionNumber()
    {
        return ((delegate* unmanaged<IMarkupContainer2*, int> )(lpVtbl[8]))((IMarkupContainer2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMarkupContainer2.xml' path='doc/member[@name="IMarkupContainer2.GetMasterElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMasterElement(IHTMLElement** ppElementMaster)
    {
        return ((delegate* unmanaged<IMarkupContainer2*, IHTMLElement**, int> )(lpVtbl[9]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), ppElementMaster);
    }

    public interface Interface : IMarkupContainer.Interface
    {
        [VtblIndex(4)]
        HRESULT CreateChangeLog(IHTMLChangeSink* pChangeSink, IHTMLChangeLog** ppChangeLog, BOOL fForward, BOOL fBackward);
        [VtblIndex(5)]
        HRESULT RegisterForDirtyRange(IHTMLChangeSink* pChangeSink, [NativeTypeName("DWORD *")] uint* pdwCookie);
        [VtblIndex(6)]
        HRESULT UnRegisterForDirtyRange([NativeTypeName("DWORD")] uint dwCookie);
        [VtblIndex(7)]
        HRESULT GetAndClearDirtyRange([NativeTypeName("DWORD")] uint dwCookie, IMarkupPointer* pIPointerBegin, IMarkupPointer* pIPointerEnd);
        [VtblIndex(8)]
        [return: NativeTypeName("long")]
        int GetVersionNumber();
        [VtblIndex(9)]
        HRESULT GetMasterElement(IHTMLElement** ppElementMaster);
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
        [NativeTypeName("HRESULT (IHTMLDocument2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDocument2**, int> OwningDoc;
        [NativeTypeName("HRESULT (IHTMLChangeSink *, IHTMLChangeLog **, BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLChangeSink*, IHTMLChangeLog**, BOOL, BOOL, int> CreateChangeLog;
        [NativeTypeName("HRESULT (IHTMLChangeSink *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLChangeSink*, uint*, int> RegisterForDirtyRange;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnRegisterForDirtyRange;
        [NativeTypeName("HRESULT (DWORD, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMarkupPointer*, IMarkupPointer*, int> GetAndClearDirtyRange;
        [NativeTypeName("long () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetVersionNumber;
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> GetMasterElement;
    }
}