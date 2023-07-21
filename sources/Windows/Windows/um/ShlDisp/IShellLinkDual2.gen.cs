// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IShellLinkDual2.xml' path='doc/member[@name="IShellLinkDual2"]/*' />
[Guid("317EE249-F12E-11D2-B1E4-00C04F8EEB3E")]
[NativeTypeName("struct IShellLinkDual2 : IShellLinkDual")]
[NativeInheritance("IShellLinkDual")]
public unsafe partial struct IShellLinkDual2 : IShellLinkDual2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellLinkDual2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, Guid*, void**, int>)(lpVtbl[0]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellLinkDual2*, uint>)(lpVtbl[1]))((IShellLinkDual2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellLinkDual2*, uint>)(lpVtbl[2]))((IShellLinkDual2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, uint*, int>)(lpVtbl[3]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref="IShellLinkDual.get_Path" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Path([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, ushort**, int>)(lpVtbl[7]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <inheritdoc cref="IShellLinkDual.put_Path" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Path([NativeTypeName("BSTR")] ushort* bs)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, ushort*, int>)(lpVtbl[8]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), bs);
    }

    /// <inheritdoc cref="IShellLinkDual.get_Description" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Description([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, ushort**, int>)(lpVtbl[9]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <inheritdoc cref="IShellLinkDual.put_Description" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Description([NativeTypeName("BSTR")] ushort* bs)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, ushort*, int>)(lpVtbl[10]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), bs);
    }

    /// <inheritdoc cref="IShellLinkDual.get_WorkingDirectory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_WorkingDirectory([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, ushort**, int>)(lpVtbl[11]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <inheritdoc cref="IShellLinkDual.put_WorkingDirectory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_WorkingDirectory([NativeTypeName("BSTR")] ushort* bs)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, ushort*, int>)(lpVtbl[12]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), bs);
    }

    /// <inheritdoc cref="IShellLinkDual.get_Arguments" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Arguments([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, ushort**, int>)(lpVtbl[13]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <inheritdoc cref="IShellLinkDual.put_Arguments" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Arguments([NativeTypeName("BSTR")] ushort* bs)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, ushort*, int>)(lpVtbl[14]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), bs);
    }

    /// <inheritdoc cref="IShellLinkDual.get_Hotkey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Hotkey(int* piHK)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, int*, int>)(lpVtbl[15]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), piHK);
    }

    /// <inheritdoc cref="IShellLinkDual.put_Hotkey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_Hotkey(int iHK)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, int, int>)(lpVtbl[16]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), iHK);
    }

    /// <inheritdoc cref="IShellLinkDual.get_ShowCommand" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ShowCommand(int* piShowCommand)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, int*, int>)(lpVtbl[17]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), piShowCommand);
    }

    /// <inheritdoc cref="IShellLinkDual.put_ShowCommand" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_ShowCommand(int iShowCommand)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, int, int>)(lpVtbl[18]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), iShowCommand);
    }

    /// <inheritdoc cref="IShellLinkDual.Resolve" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Resolve(int fFlags)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, int, int>)(lpVtbl[19]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), fFlags);
    }

    /// <inheritdoc cref="IShellLinkDual.GetIconLocation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetIconLocation([NativeTypeName("BSTR *")] ushort** pbs, int* piIcon)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, ushort**, int*, int>)(lpVtbl[20]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), pbs, piIcon);
    }

    /// <inheritdoc cref="IShellLinkDual.SetIconLocation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetIconLocation([NativeTypeName("BSTR")] ushort* bs, int iIcon)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, ushort*, int, int>)(lpVtbl[21]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), bs, iIcon);
    }

    /// <inheritdoc cref="IShellLinkDual.Save" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT Save(VARIANT vWhere)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, VARIANT, int>)(lpVtbl[22]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), vWhere);
    }

    /// <include file='IShellLinkDual2.xml' path='doc/member[@name="IShellLinkDual2.get_Target"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Target(FolderItem** ppfi)
    {
        return ((delegate* unmanaged<IShellLinkDual2*, FolderItem**, int>)(lpVtbl[23]))((IShellLinkDual2*)Unsafe.AsPointer(ref this), ppfi);
    }

    public interface Interface : IShellLinkDual.Interface
    {
        [VtblIndex(23)]
        HRESULT get_Target(FolderItem** ppfi);
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
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Path;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Path;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Description;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Description;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_WorkingDirectory;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_WorkingDirectory;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Arguments;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Arguments;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Hotkey;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Hotkey;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ShowCommand;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ShowCommand;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> Resolve;

        [NativeTypeName("HRESULT (BSTR *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int*, int> GetIconLocation;

        [NativeTypeName("HRESULT (BSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> SetIconLocation;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> Save;

        [NativeTypeName("HRESULT (FolderItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItem**, int> get_Target;
    }
}
