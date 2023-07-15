// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation"]/*'/>
[Guid("947AAB5F-0A5C-4C13-B4D6-4BF7836FC9F8")]
[NativeTypeName("struct IFileOperation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileOperation : IFileOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileOperation));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileOperation*, Guid*, void**, int> )(lpVtbl[0]))((IFileOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileOperation*, uint> )(lpVtbl[1]))((IFileOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileOperation*, uint> )(lpVtbl[2]))((IFileOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.Advise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(IFileOperationProgressSink* pfops, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IFileOperation*, IFileOperationProgressSink*, uint*, int> )(lpVtbl[3]))((IFileOperation*)Unsafe.AsPointer(ref this), pfops, pdwCookie);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.Unadvise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IFileOperation*, uint, int> )(lpVtbl[4]))((IFileOperation*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.SetOperationFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOperationFlags([NativeTypeName("DWORD")] uint dwOperationFlags)
    {
        return ((delegate* unmanaged<IFileOperation*, uint, int> )(lpVtbl[5]))((IFileOperation*)Unsafe.AsPointer(ref this), dwOperationFlags);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.SetProgressMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetProgressMessage([NativeTypeName("LPCWSTR")] ushort* pszMessage)
    {
        return ((delegate* unmanaged<IFileOperation*, ushort*, int> )(lpVtbl[6]))((IFileOperation*)Unsafe.AsPointer(ref this), pszMessage);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.SetProgressDialog"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetProgressDialog(IOperationsProgressDialog* popd)
    {
        return ((delegate* unmanaged<IFileOperation*, IOperationsProgressDialog*, int> )(lpVtbl[7]))((IFileOperation*)Unsafe.AsPointer(ref this), popd);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.SetProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetProperties(IPropertyChangeArray* pproparray)
    {
        return ((delegate* unmanaged<IFileOperation*, IPropertyChangeArray*, int> )(lpVtbl[8]))((IFileOperation*)Unsafe.AsPointer(ref this), pproparray);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.SetOwnerWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetOwnerWindow(HWND hwndOwner)
    {
        return ((delegate* unmanaged<IFileOperation*, HWND, int> )(lpVtbl[9]))((IFileOperation*)Unsafe.AsPointer(ref this), hwndOwner);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.ApplyPropertiesToItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ApplyPropertiesToItem(IShellItem* psiItem)
    {
        return ((delegate* unmanaged<IFileOperation*, IShellItem*, int> )(lpVtbl[10]))((IFileOperation*)Unsafe.AsPointer(ref this), psiItem);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.ApplyPropertiesToItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ApplyPropertiesToItems(IUnknown* punkItems)
    {
        return ((delegate* unmanaged<IFileOperation*, IUnknown*, int> )(lpVtbl[11]))((IFileOperation*)Unsafe.AsPointer(ref this), punkItems);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.RenameItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RenameItem(IShellItem* psiItem, [NativeTypeName("LPCWSTR")] ushort* pszNewName, IFileOperationProgressSink* pfopsItem)
    {
        return ((delegate* unmanaged<IFileOperation*, IShellItem*, ushort*, IFileOperationProgressSink*, int> )(lpVtbl[12]))((IFileOperation*)Unsafe.AsPointer(ref this), psiItem, pszNewName, pfopsItem);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.RenameItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RenameItems(IUnknown* pUnkItems, [NativeTypeName("LPCWSTR")] ushort* pszNewName)
    {
        return ((delegate* unmanaged<IFileOperation*, IUnknown*, ushort*, int> )(lpVtbl[13]))((IFileOperation*)Unsafe.AsPointer(ref this), pUnkItems, pszNewName);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.MoveItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT MoveItem(IShellItem* psiItem, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszNewName, IFileOperationProgressSink* pfopsItem)
    {
        return ((delegate* unmanaged<IFileOperation*, IShellItem*, IShellItem*, ushort*, IFileOperationProgressSink*, int> )(lpVtbl[14]))((IFileOperation*)Unsafe.AsPointer(ref this), psiItem, psiDestinationFolder, pszNewName, pfopsItem);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.MoveItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT MoveItems(IUnknown* punkItems, IShellItem* psiDestinationFolder)
    {
        return ((delegate* unmanaged<IFileOperation*, IUnknown*, IShellItem*, int> )(lpVtbl[15]))((IFileOperation*)Unsafe.AsPointer(ref this), punkItems, psiDestinationFolder);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.CopyItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CopyItem(IShellItem* psiItem, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszCopyName, IFileOperationProgressSink* pfopsItem)
    {
        return ((delegate* unmanaged<IFileOperation*, IShellItem*, IShellItem*, ushort*, IFileOperationProgressSink*, int> )(lpVtbl[16]))((IFileOperation*)Unsafe.AsPointer(ref this), psiItem, psiDestinationFolder, pszCopyName, pfopsItem);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.CopyItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CopyItems(IUnknown* punkItems, IShellItem* psiDestinationFolder)
    {
        return ((delegate* unmanaged<IFileOperation*, IUnknown*, IShellItem*, int> )(lpVtbl[17]))((IFileOperation*)Unsafe.AsPointer(ref this), punkItems, psiDestinationFolder);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.DeleteItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DeleteItem(IShellItem* psiItem, IFileOperationProgressSink* pfopsItem)
    {
        return ((delegate* unmanaged<IFileOperation*, IShellItem*, IFileOperationProgressSink*, int> )(lpVtbl[18]))((IFileOperation*)Unsafe.AsPointer(ref this), psiItem, pfopsItem);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.DeleteItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DeleteItems(IUnknown* punkItems)
    {
        return ((delegate* unmanaged<IFileOperation*, IUnknown*, int> )(lpVtbl[19]))((IFileOperation*)Unsafe.AsPointer(ref this), punkItems);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.NewItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT NewItem(IShellItem* psiDestinationFolder, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPCWSTR")] ushort* pszTemplateName, IFileOperationProgressSink* pfopsItem)
    {
        return ((delegate* unmanaged<IFileOperation*, IShellItem*, uint, ushort*, ushort*, IFileOperationProgressSink*, int> )(lpVtbl[20]))((IFileOperation*)Unsafe.AsPointer(ref this), psiDestinationFolder, dwFileAttributes, pszName, pszTemplateName, pfopsItem);
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.PerformOperations"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT PerformOperations()
    {
        return ((delegate* unmanaged<IFileOperation*, int> )(lpVtbl[21]))((IFileOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileOperation.xml' path='doc/member[@name="IFileOperation.GetAnyOperationsAborted"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetAnyOperationsAborted(BOOL* pfAnyOperationsAborted)
    {
        return ((delegate* unmanaged<IFileOperation*, BOOL*, int> )(lpVtbl[22]))((IFileOperation*)Unsafe.AsPointer(ref this), pfAnyOperationsAborted);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Advise(IFileOperationProgressSink* pfops, [NativeTypeName("DWORD *")] uint* pdwCookie);
        [VtblIndex(4)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie);
        [VtblIndex(5)]
        HRESULT SetOperationFlags([NativeTypeName("DWORD")] uint dwOperationFlags);
        [VtblIndex(6)]
        HRESULT SetProgressMessage([NativeTypeName("LPCWSTR")] ushort* pszMessage);
        [VtblIndex(7)]
        HRESULT SetProgressDialog(IOperationsProgressDialog* popd);
        [VtblIndex(8)]
        HRESULT SetProperties(IPropertyChangeArray* pproparray);
        [VtblIndex(9)]
        HRESULT SetOwnerWindow(HWND hwndOwner);
        [VtblIndex(10)]
        HRESULT ApplyPropertiesToItem(IShellItem* psiItem);
        [VtblIndex(11)]
        HRESULT ApplyPropertiesToItems(IUnknown* punkItems);
        [VtblIndex(12)]
        HRESULT RenameItem(IShellItem* psiItem, [NativeTypeName("LPCWSTR")] ushort* pszNewName, IFileOperationProgressSink* pfopsItem);
        [VtblIndex(13)]
        HRESULT RenameItems(IUnknown* pUnkItems, [NativeTypeName("LPCWSTR")] ushort* pszNewName);
        [VtblIndex(14)]
        HRESULT MoveItem(IShellItem* psiItem, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszNewName, IFileOperationProgressSink* pfopsItem);
        [VtblIndex(15)]
        HRESULT MoveItems(IUnknown* punkItems, IShellItem* psiDestinationFolder);
        [VtblIndex(16)]
        HRESULT CopyItem(IShellItem* psiItem, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszCopyName, IFileOperationProgressSink* pfopsItem);
        [VtblIndex(17)]
        HRESULT CopyItems(IUnknown* punkItems, IShellItem* psiDestinationFolder);
        [VtblIndex(18)]
        HRESULT DeleteItem(IShellItem* psiItem, IFileOperationProgressSink* pfopsItem);
        [VtblIndex(19)]
        HRESULT DeleteItems(IUnknown* punkItems);
        [VtblIndex(20)]
        HRESULT NewItem(IShellItem* psiDestinationFolder, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPCWSTR")] ushort* pszTemplateName, IFileOperationProgressSink* pfopsItem);
        [VtblIndex(21)]
        HRESULT PerformOperations();
        [VtblIndex(22)]
        HRESULT GetAnyOperationsAborted(BOOL* pfAnyOperationsAborted);
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
        [NativeTypeName("HRESULT (IFileOperationProgressSink *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileOperationProgressSink*, uint*, int> Advise;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetOperationFlags;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetProgressMessage;
        [NativeTypeName("HRESULT (IOperationsProgressDialog *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOperationsProgressDialog*, int> SetProgressDialog;
        [NativeTypeName("HRESULT (IPropertyChangeArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyChangeArray*, int> SetProperties;
        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> SetOwnerWindow;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> ApplyPropertiesToItem;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> ApplyPropertiesToItems;
        [NativeTypeName("HRESULT (IShellItem *, LPCWSTR, IFileOperationProgressSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, ushort*, IFileOperationProgressSink*, int> RenameItem;
        [NativeTypeName("HRESULT (IUnknown *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, ushort*, int> RenameItems;
        [NativeTypeName("HRESULT (IShellItem *, IShellItem *, LPCWSTR, IFileOperationProgressSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, IShellItem*, ushort*, IFileOperationProgressSink*, int> MoveItem;
        [NativeTypeName("HRESULT (IUnknown *, IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IShellItem*, int> MoveItems;
        [NativeTypeName("HRESULT (IShellItem *, IShellItem *, LPCWSTR, IFileOperationProgressSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, IShellItem*, ushort*, IFileOperationProgressSink*, int> CopyItem;
        [NativeTypeName("HRESULT (IUnknown *, IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IShellItem*, int> CopyItems;
        [NativeTypeName("HRESULT (IShellItem *, IFileOperationProgressSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, IFileOperationProgressSink*, int> DeleteItem;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> DeleteItems;
        [NativeTypeName("HRESULT (IShellItem *, DWORD, LPCWSTR, LPCWSTR, IFileOperationProgressSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, uint, ushort*, ushort*, IFileOperationProgressSink*, int> NewItem;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PerformOperations;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetAnyOperationsAborted;
    }
}