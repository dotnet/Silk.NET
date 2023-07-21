// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMoniker.xml' path='doc/member[@name="IMoniker"]/*' />
[Guid("0000000F-0000-0000-C000-000000000046")]
[NativeTypeName("struct IMoniker : IPersistStream")]
[NativeInheritance("IPersistStream")]
public unsafe partial struct IMoniker : IMoniker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMoniker));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMoniker*, Guid*, void**, int>)(lpVtbl[0]))((IMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMoniker*, uint>)(lpVtbl[1]))((IMoniker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMoniker*, uint>)(lpVtbl[2]))((IMoniker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersist.GetClassID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IMoniker*, Guid*, int>)(lpVtbl[3]))((IMoniker*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <inheritdoc cref="IPersistStream.IsDirty" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IMoniker*, int>)(lpVtbl[4]))((IMoniker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersistStream.Load" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IStream* pStm)
    {
        return ((delegate* unmanaged<IMoniker*, IStream*, int>)(lpVtbl[5]))((IMoniker*)Unsafe.AsPointer(ref this), pStm);
    }

    /// <inheritdoc cref="IPersistStream.Save" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IStream* pStm, BOOL fClearDirty)
    {
        return ((delegate* unmanaged<IMoniker*, IStream*, BOOL, int>)(lpVtbl[6]))((IMoniker*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
    }

    /// <inheritdoc cref="IPersistStream.GetSizeMax" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax(ULARGE_INTEGER* pcbSize)
    {
        return ((delegate* unmanaged<IMoniker*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IMoniker*)Unsafe.AsPointer(ref this), pcbSize);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.BindToObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BindToObject(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riidResult, void** ppvResult)
    {
        return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)(lpVtbl[8]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, riidResult, ppvResult);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.BindToStorage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT BindToStorage(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj)
    {
        return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)(lpVtbl[9]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, riid, ppvObj);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.Reduce"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Reduce(IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwReduceHowFar, IMoniker** ppmkToLeft, IMoniker** ppmkReduced)
    {
        return ((delegate* unmanaged<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)(lpVtbl[10]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, dwReduceHowFar, ppmkToLeft, ppmkReduced);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.ComposeWith"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ComposeWith(IMoniker* pmkRight, BOOL fOnlyIfNotGeneric, IMoniker** ppmkComposite)
    {
        return ((delegate* unmanaged<IMoniker*, IMoniker*, BOOL, IMoniker**, int>)(lpVtbl[11]))((IMoniker*)Unsafe.AsPointer(ref this), pmkRight, fOnlyIfNotGeneric, ppmkComposite);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.Enum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Enum(BOOL fForward, IEnumMoniker** ppenumMoniker)
    {
        return ((delegate* unmanaged<IMoniker*, BOOL, IEnumMoniker**, int>)(lpVtbl[12]))((IMoniker*)Unsafe.AsPointer(ref this), fForward, ppenumMoniker);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.IsEqual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsEqual(IMoniker* pmkOtherMoniker)
    {
        return ((delegate* unmanaged<IMoniker*, IMoniker*, int>)(lpVtbl[13]))((IMoniker*)Unsafe.AsPointer(ref this), pmkOtherMoniker);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.Hash"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Hash([NativeTypeName("DWORD *")] uint* pdwHash)
    {
        return ((delegate* unmanaged<IMoniker*, uint*, int>)(lpVtbl[14]))((IMoniker*)Unsafe.AsPointer(ref this), pdwHash);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.IsRunning"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsRunning(IBindCtx* pbc, IMoniker* pmkToLeft, IMoniker* pmkNewlyRunning)
    {
        return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)(lpVtbl[15]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pmkNewlyRunning);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.GetTimeOfLastChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetTimeOfLastChange(IBindCtx* pbc, IMoniker* pmkToLeft, FILETIME* pFileTime)
    {
        return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, FILETIME*, int>)(lpVtbl[16]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pFileTime);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.Inverse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Inverse(IMoniker** ppmk)
    {
        return ((delegate* unmanaged<IMoniker*, IMoniker**, int>)(lpVtbl[17]))((IMoniker*)Unsafe.AsPointer(ref this), ppmk);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.CommonPrefixWith"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CommonPrefixWith(IMoniker* pmkOther, IMoniker** ppmkPrefix)
    {
        return ((delegate* unmanaged<IMoniker*, IMoniker*, IMoniker**, int>)(lpVtbl[18]))((IMoniker*)Unsafe.AsPointer(ref this), pmkOther, ppmkPrefix);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.RelativePathTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RelativePathTo(IMoniker* pmkOther, IMoniker** ppmkRelPath)
    {
        return ((delegate* unmanaged<IMoniker*, IMoniker*, IMoniker**, int>)(lpVtbl[19]))((IMoniker*)Unsafe.AsPointer(ref this), pmkOther, ppmkRelPath);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.GetDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName)
    {
        return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, ushort**, int>)(lpVtbl[20]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, ppszDisplayName);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.ParseDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, IMoniker** ppmkOut)
    {
        return ((delegate* unmanaged<IMoniker*, IBindCtx*, IMoniker*, ushort*, uint*, IMoniker**, int>)(lpVtbl[21]))((IMoniker*)Unsafe.AsPointer(ref this), pbc, pmkToLeft, pszDisplayName, pchEaten, ppmkOut);
    }

    /// <include file='IMoniker.xml' path='doc/member[@name="IMoniker.IsSystemMoniker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT IsSystemMoniker([NativeTypeName("DWORD *")] uint* pdwMksys)
    {
        return ((delegate* unmanaged<IMoniker*, uint*, int>)(lpVtbl[22]))((IMoniker*)Unsafe.AsPointer(ref this), pdwMksys);
    }

    public interface Interface : IPersistStream.Interface
    {
        [VtblIndex(8)]
        HRESULT BindToObject(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riidResult, void** ppvResult);

        [VtblIndex(9)]
        HRESULT BindToStorage(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [VtblIndex(10)]
        HRESULT Reduce(IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwReduceHowFar, IMoniker** ppmkToLeft, IMoniker** ppmkReduced);

        [VtblIndex(11)]
        HRESULT ComposeWith(IMoniker* pmkRight, BOOL fOnlyIfNotGeneric, IMoniker** ppmkComposite);

        [VtblIndex(12)]
        HRESULT Enum(BOOL fForward, IEnumMoniker** ppenumMoniker);

        [VtblIndex(13)]
        HRESULT IsEqual(IMoniker* pmkOtherMoniker);

        [VtblIndex(14)]
        HRESULT Hash([NativeTypeName("DWORD *")] uint* pdwHash);

        [VtblIndex(15)]
        HRESULT IsRunning(IBindCtx* pbc, IMoniker* pmkToLeft, IMoniker* pmkNewlyRunning);

        [VtblIndex(16)]
        HRESULT GetTimeOfLastChange(IBindCtx* pbc, IMoniker* pmkToLeft, FILETIME* pFileTime);

        [VtblIndex(17)]
        HRESULT Inverse(IMoniker** ppmk);

        [VtblIndex(18)]
        HRESULT CommonPrefixWith(IMoniker* pmkOther, IMoniker** ppmkPrefix);

        [VtblIndex(19)]
        HRESULT RelativePathTo(IMoniker* pmkOther, IMoniker** ppmkRelPath);

        [VtblIndex(20)]
        HRESULT GetDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName);

        [VtblIndex(21)]
        HRESULT ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, IMoniker** ppmkOut);

        [VtblIndex(22)]
        HRESULT IsSystemMoniker([NativeTypeName("DWORD *")] uint* pdwMksys);
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

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> Load;

        [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, BOOL, int> Save;

        [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER*, int> GetSizeMax;

        [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx*, IMoniker*, Guid*, void**, int> BindToObject;

        [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx*, IMoniker*, Guid*, void**, int> BindToStorage;

        [NativeTypeName("HRESULT (IBindCtx *, DWORD, IMoniker **, IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx*, uint, IMoniker**, IMoniker**, int> Reduce;

        [NativeTypeName("HRESULT (IMoniker *, BOOL, IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, BOOL, IMoniker**, int> ComposeWith;

        [NativeTypeName("HRESULT (BOOL, IEnumMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, IEnumMoniker**, int> Enum;

        [NativeTypeName("HRESULT (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, int> IsEqual;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> Hash;

        [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx*, IMoniker*, IMoniker*, int> IsRunning;

        [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx*, IMoniker*, FILETIME*, int> GetTimeOfLastChange;

        [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker**, int> Inverse;

        [NativeTypeName("HRESULT (IMoniker *, IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, IMoniker**, int> CommonPrefixWith;

        [NativeTypeName("HRESULT (IMoniker *, IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, IMoniker**, int> RelativePathTo;

        [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, LPOLESTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx*, IMoniker*, ushort**, int> GetDisplayName;

        [NativeTypeName("HRESULT (IBindCtx *, IMoniker *, LPOLESTR, ULONG *, IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx*, IMoniker*, ushort*, uint*, IMoniker**, int> ParseDisplayName;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> IsSystemMoniker;
    }
}
