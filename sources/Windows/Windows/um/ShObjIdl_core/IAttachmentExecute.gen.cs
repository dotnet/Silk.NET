// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute"]/*' />
[Guid("73DB1241-1E85-4581-8E4F-A81E1D0F8C57")]
[NativeTypeName("struct IAttachmentExecute : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAttachmentExecute : IAttachmentExecute.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAttachmentExecute));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAttachmentExecute*, Guid*, void**, int>)(lpVtbl[0]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAttachmentExecute*, uint>)(lpVtbl[1]))((IAttachmentExecute*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAttachmentExecute*, uint>)(lpVtbl[2]))((IAttachmentExecute*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.SetClientTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetClientTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle)
    {
        return ((delegate* unmanaged<IAttachmentExecute*, ushort*, int>)(lpVtbl[3]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), pszTitle);
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.SetClientGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetClientGuid([NativeTypeName("const GUID &")] Guid* guid)
    {
        return ((delegate* unmanaged<IAttachmentExecute*, Guid*, int>)(lpVtbl[4]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), guid);
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.SetLocalPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetLocalPath([NativeTypeName("LPCWSTR")] ushort* pszLocalPath)
    {
        return ((delegate* unmanaged<IAttachmentExecute*, ushort*, int>)(lpVtbl[5]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), pszLocalPath);
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.SetFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetFileName([NativeTypeName("LPCWSTR")] ushort* pszFileName)
    {
        return ((delegate* unmanaged<IAttachmentExecute*, ushort*, int>)(lpVtbl[6]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), pszFileName);
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.SetSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetSource([NativeTypeName("LPCWSTR")] ushort* pszSource)
    {
        return ((delegate* unmanaged<IAttachmentExecute*, ushort*, int>)(lpVtbl[7]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), pszSource);
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.SetReferrer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetReferrer([NativeTypeName("LPCWSTR")] ushort* pszReferrer)
    {
        return ((delegate* unmanaged<IAttachmentExecute*, ushort*, int>)(lpVtbl[8]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), pszReferrer);
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.CheckPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CheckPolicy()
    {
        return ((delegate* unmanaged<IAttachmentExecute*, int>)(lpVtbl[9]))((IAttachmentExecute*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.Prompt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Prompt(HWND hwnd, ATTACHMENT_PROMPT prompt, ATTACHMENT_ACTION* paction)
    {
        return ((delegate* unmanaged<IAttachmentExecute*, HWND, ATTACHMENT_PROMPT, ATTACHMENT_ACTION*, int>)(lpVtbl[10]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), hwnd, prompt, paction);
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.Save"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Save()
    {
        return ((delegate* unmanaged<IAttachmentExecute*, int>)(lpVtbl[11]))((IAttachmentExecute*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.Execute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Execute(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszVerb, HANDLE* phProcess)
    {
        return ((delegate* unmanaged<IAttachmentExecute*, HWND, ushort*, HANDLE*, int>)(lpVtbl[12]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), hwnd, pszVerb, phProcess);
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.SaveWithUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SaveWithUI(HWND hwnd)
    {
        return ((delegate* unmanaged<IAttachmentExecute*, HWND, int>)(lpVtbl[13]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <include file='IAttachmentExecute.xml' path='doc/member[@name="IAttachmentExecute.ClearClientState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ClearClientState()
    {
        return ((delegate* unmanaged<IAttachmentExecute*, int>)(lpVtbl[14]))((IAttachmentExecute*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetClientTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle);

        [VtblIndex(4)]
        HRESULT SetClientGuid([NativeTypeName("const GUID &")] Guid* guid);

        [VtblIndex(5)]
        HRESULT SetLocalPath([NativeTypeName("LPCWSTR")] ushort* pszLocalPath);

        [VtblIndex(6)]
        HRESULT SetFileName([NativeTypeName("LPCWSTR")] ushort* pszFileName);

        [VtblIndex(7)]
        HRESULT SetSource([NativeTypeName("LPCWSTR")] ushort* pszSource);

        [VtblIndex(8)]
        HRESULT SetReferrer([NativeTypeName("LPCWSTR")] ushort* pszReferrer);

        [VtblIndex(9)]
        HRESULT CheckPolicy();

        [VtblIndex(10)]
        HRESULT Prompt(HWND hwnd, ATTACHMENT_PROMPT prompt, ATTACHMENT_ACTION* paction);

        [VtblIndex(11)]
        HRESULT Save();

        [VtblIndex(12)]
        HRESULT Execute(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszVerb, HANDLE* phProcess);

        [VtblIndex(13)]
        HRESULT SaveWithUI(HWND hwnd);

        [VtblIndex(14)]
        HRESULT ClearClientState();
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetClientTitle;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetClientGuid;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetLocalPath;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetFileName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetSource;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetReferrer;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CheckPolicy;

        [NativeTypeName("HRESULT (HWND, ATTACHMENT_PROMPT, ATTACHMENT_ACTION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ATTACHMENT_PROMPT, ATTACHMENT_ACTION*, int> Prompt;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Save;

        [NativeTypeName("HRESULT (HWND, LPCWSTR, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ushort*, HANDLE*, int> Execute;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> SaveWithUI;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearClientState;
    }
}
