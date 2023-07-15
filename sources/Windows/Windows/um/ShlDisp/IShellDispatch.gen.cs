// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch"]/*'/>
[Guid("D8F015C0-C278-11CE-A49E-444553540000")]
[NativeTypeName("struct IShellDispatch : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IShellDispatch : IShellDispatch.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellDispatch));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellDispatch*, Guid*, void**, int> )(lpVtbl[0]))((IShellDispatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellDispatch*, uint> )(lpVtbl[1]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellDispatch*, uint> )(lpVtbl[2]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellDispatch*, uint*, int> )(lpVtbl[3]))((IShellDispatch*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IShellDispatch*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IShellDispatch*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IShellDispatch*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IShellDispatch*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IShellDispatch*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IShellDispatch*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.get_Application"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Application(IDispatch** ppid)
    {
        return ((delegate* unmanaged<IShellDispatch*, IDispatch**, int> )(lpVtbl[7]))((IShellDispatch*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.get_Parent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Parent(IDispatch** ppid)
    {
        return ((delegate* unmanaged<IShellDispatch*, IDispatch**, int> )(lpVtbl[8]))((IShellDispatch*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.NameSpace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT NameSpace(VARIANT vDir, Folder** ppsdf)
    {
        return ((delegate* unmanaged<IShellDispatch*, VARIANT, Folder**, int> )(lpVtbl[9]))((IShellDispatch*)Unsafe.AsPointer(ref this), vDir, ppsdf);
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.BrowseForFolder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT BrowseForFolder([NativeTypeName("long")] int Hwnd, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("long")] int Options, VARIANT RootFolder, Folder** ppsdf)
    {
        return ((delegate* unmanaged<IShellDispatch*, int, ushort*, int, VARIANT, Folder**, int> )(lpVtbl[10]))((IShellDispatch*)Unsafe.AsPointer(ref this), Hwnd, Title, Options, RootFolder, ppsdf);
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.Windows"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Windows(IDispatch** ppid)
    {
        return ((delegate* unmanaged<IShellDispatch*, IDispatch**, int> )(lpVtbl[11]))((IShellDispatch*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.Open"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Open(VARIANT vDir)
    {
        return ((delegate* unmanaged<IShellDispatch*, VARIANT, int> )(lpVtbl[12]))((IShellDispatch*)Unsafe.AsPointer(ref this), vDir);
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.Explore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Explore(VARIANT vDir)
    {
        return ((delegate* unmanaged<IShellDispatch*, VARIANT, int> )(lpVtbl[13]))((IShellDispatch*)Unsafe.AsPointer(ref this), vDir);
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.MinimizeAll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT MinimizeAll()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[14]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.UndoMinimizeALL"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT UndoMinimizeALL()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[15]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.FileRun"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT FileRun()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[16]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.CascadeWindows"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CascadeWindows()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[17]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.TileVertically"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT TileVertically()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[18]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.TileHorizontally"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT TileHorizontally()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[19]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.ShutdownWindows"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT ShutdownWindows()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[20]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.Suspend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT Suspend()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[21]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.EjectPC"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT EjectPC()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[22]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.SetTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetTime()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[23]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.TrayProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT TrayProperties()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[24]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.Help"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT Help()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[25]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.FindFiles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT FindFiles()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[26]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.FindComputer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT FindComputer()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[27]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.RefreshMenu"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT RefreshMenu()
    {
        return ((delegate* unmanaged<IShellDispatch*, int> )(lpVtbl[28]))((IShellDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDispatch.xml' path='doc/member[@name="IShellDispatch.ControlPanelItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT ControlPanelItem([NativeTypeName("BSTR")] ushort* bstrDir)
    {
        return ((delegate* unmanaged<IShellDispatch*, ushort*, int> )(lpVtbl[29]))((IShellDispatch*)Unsafe.AsPointer(ref this), bstrDir);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Application(IDispatch** ppid);
        [VtblIndex(8)]
        HRESULT get_Parent(IDispatch** ppid);
        [VtblIndex(9)]
        HRESULT NameSpace(VARIANT vDir, Folder** ppsdf);
        [VtblIndex(10)]
        HRESULT BrowseForFolder([NativeTypeName("long")] int Hwnd, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("long")] int Options, VARIANT RootFolder, Folder** ppsdf);
        [VtblIndex(11)]
        HRESULT Windows(IDispatch** ppid);
        [VtblIndex(12)]
        HRESULT Open(VARIANT vDir);
        [VtblIndex(13)]
        HRESULT Explore(VARIANT vDir);
        [VtblIndex(14)]
        HRESULT MinimizeAll();
        [VtblIndex(15)]
        HRESULT UndoMinimizeALL();
        [VtblIndex(16)]
        HRESULT FileRun();
        [VtblIndex(17)]
        HRESULT CascadeWindows();
        [VtblIndex(18)]
        HRESULT TileVertically();
        [VtblIndex(19)]
        HRESULT TileHorizontally();
        [VtblIndex(20)]
        HRESULT ShutdownWindows();
        [VtblIndex(21)]
        HRESULT Suspend();
        [VtblIndex(22)]
        HRESULT EjectPC();
        [VtblIndex(23)]
        HRESULT SetTime();
        [VtblIndex(24)]
        HRESULT TrayProperties();
        [VtblIndex(25)]
        HRESULT Help();
        [VtblIndex(26)]
        HRESULT FindFiles();
        [VtblIndex(27)]
        HRESULT FindComputer();
        [VtblIndex(28)]
        HRESULT RefreshMenu();
        [VtblIndex(29)]
        HRESULT ControlPanelItem([NativeTypeName("BSTR")] ushort* bstrDir);
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
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Application;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Parent;
        [NativeTypeName("HRESULT (VARIANT, Folder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, Folder**, int> NameSpace;
        [NativeTypeName("HRESULT (long, BSTR, long, VARIANT, Folder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort*, int, VARIANT, Folder**, int> BrowseForFolder;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> Windows;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> Open;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> Explore;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> MinimizeAll;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UndoMinimizeALL;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FileRun;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CascadeWindows;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> TileVertically;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> TileHorizontally;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ShutdownWindows;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Suspend;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EjectPC;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetTime;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> TrayProperties;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Help;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FindFiles;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FindComputer;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RefreshMenu;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> ControlPanelItem;
    }
}