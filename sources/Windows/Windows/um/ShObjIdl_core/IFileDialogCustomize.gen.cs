// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize"]/*'/>
[Guid("E6FDD21A-163F-4975-9C8C-A69F1BA37034")]
[NativeTypeName("struct IFileDialogCustomize : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileDialogCustomize : IFileDialogCustomize.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileDialogCustomize));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, Guid*, void**, int> )(lpVtbl[0]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint> )(lpVtbl[1]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint> )(lpVtbl[2]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.EnableOpenDropDown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnableOpenDropDown([NativeTypeName("DWORD")] uint dwIDCtl)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, int> )(lpVtbl[3]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.AddMenu"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddMenu([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int> )(lpVtbl[4]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszLabel);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.AddPushButton"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddPushButton([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int> )(lpVtbl[5]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszLabel);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.AddComboBox"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddComboBox([NativeTypeName("DWORD")] uint dwIDCtl)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, int> )(lpVtbl[6]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.AddRadioButtonList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddRadioButtonList([NativeTypeName("DWORD")] uint dwIDCtl)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, int> )(lpVtbl[7]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.AddCheckButton"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddCheckButton([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel, BOOL bChecked)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, BOOL, int> )(lpVtbl[8]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszLabel, bChecked);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.AddEditBox"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddEditBox([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszText)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int> )(lpVtbl[9]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszText);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.AddSeparator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddSeparator([NativeTypeName("DWORD")] uint dwIDCtl)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, int> )(lpVtbl[10]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.AddText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AddText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszText)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int> )(lpVtbl[11]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszText);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.SetControlLabel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetControlLabel([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int> )(lpVtbl[12]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszLabel);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.GetControlState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetControlState([NativeTypeName("DWORD")] uint dwIDCtl, CDCONTROLSTATEF* pdwState)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, CDCONTROLSTATEF*, int> )(lpVtbl[13]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pdwState);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.SetControlState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetControlState([NativeTypeName("DWORD")] uint dwIDCtl, CDCONTROLSTATEF dwState)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, CDCONTROLSTATEF, int> )(lpVtbl[14]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwState);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.GetEditBoxText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetEditBoxText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("WCHAR **")] ushort** ppszText)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort**, int> )(lpVtbl[15]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, ppszText);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.SetEditBoxText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetEditBoxText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszText)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int> )(lpVtbl[16]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszText);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.GetCheckButtonState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetCheckButtonState([NativeTypeName("DWORD")] uint dwIDCtl, BOOL* pbChecked)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, BOOL*, int> )(lpVtbl[17]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pbChecked);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.SetCheckButtonState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetCheckButtonState([NativeTypeName("DWORD")] uint dwIDCtl, BOOL bChecked)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, BOOL, int> )(lpVtbl[18]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, bChecked);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.AddControlItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT AddControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, ushort*, int> )(lpVtbl[19]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem, pszLabel);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.RemoveControlItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT RemoveControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, int> )(lpVtbl[20]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.RemoveAllControlItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RemoveAllControlItems([NativeTypeName("DWORD")] uint dwIDCtl)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, int> )(lpVtbl[21]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.GetControlItemState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetControlItemState([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, CDCONTROLSTATEF* pdwState)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, CDCONTROLSTATEF*, int> )(lpVtbl[22]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem, pdwState);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.SetControlItemState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetControlItemState([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, CDCONTROLSTATEF dwState)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, CDCONTROLSTATEF, int> )(lpVtbl[23]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem, dwState);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.GetSelectedControlItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetSelectedControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD *")] uint* pdwIDItem)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint*, int> )(lpVtbl[24]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pdwIDItem);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.SetSelectedControlItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetSelectedControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, int> )(lpVtbl[25]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.StartVisualGroup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT StartVisualGroup([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int> )(lpVtbl[26]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszLabel);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.EndVisualGroup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT EndVisualGroup()
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, int> )(lpVtbl[27]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.MakeProminent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT MakeProminent([NativeTypeName("DWORD")] uint dwIDCtl)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, int> )(lpVtbl[28]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
    }

    /// <include file='IFileDialogCustomize.xml' path='doc/member[@name="IFileDialogCustomize.SetControlItemText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetControlItemText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
    {
        return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, ushort*, int> )(lpVtbl[29]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem, pszLabel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnableOpenDropDown([NativeTypeName("DWORD")] uint dwIDCtl);
        [VtblIndex(4)]
        HRESULT AddMenu([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel);
        [VtblIndex(5)]
        HRESULT AddPushButton([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel);
        [VtblIndex(6)]
        HRESULT AddComboBox([NativeTypeName("DWORD")] uint dwIDCtl);
        [VtblIndex(7)]
        HRESULT AddRadioButtonList([NativeTypeName("DWORD")] uint dwIDCtl);
        [VtblIndex(8)]
        HRESULT AddCheckButton([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel, BOOL bChecked);
        [VtblIndex(9)]
        HRESULT AddEditBox([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszText);
        [VtblIndex(10)]
        HRESULT AddSeparator([NativeTypeName("DWORD")] uint dwIDCtl);
        [VtblIndex(11)]
        HRESULT AddText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszText);
        [VtblIndex(12)]
        HRESULT SetControlLabel([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel);
        [VtblIndex(13)]
        HRESULT GetControlState([NativeTypeName("DWORD")] uint dwIDCtl, CDCONTROLSTATEF* pdwState);
        [VtblIndex(14)]
        HRESULT SetControlState([NativeTypeName("DWORD")] uint dwIDCtl, CDCONTROLSTATEF dwState);
        [VtblIndex(15)]
        HRESULT GetEditBoxText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("WCHAR **")] ushort** ppszText);
        [VtblIndex(16)]
        HRESULT SetEditBoxText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszText);
        [VtblIndex(17)]
        HRESULT GetCheckButtonState([NativeTypeName("DWORD")] uint dwIDCtl, BOOL* pbChecked);
        [VtblIndex(18)]
        HRESULT SetCheckButtonState([NativeTypeName("DWORD")] uint dwIDCtl, BOOL bChecked);
        [VtblIndex(19)]
        HRESULT AddControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, [NativeTypeName("LPCWSTR")] ushort* pszLabel);
        [VtblIndex(20)]
        HRESULT RemoveControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem);
        [VtblIndex(21)]
        HRESULT RemoveAllControlItems([NativeTypeName("DWORD")] uint dwIDCtl);
        [VtblIndex(22)]
        HRESULT GetControlItemState([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, CDCONTROLSTATEF* pdwState);
        [VtblIndex(23)]
        HRESULT SetControlItemState([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, CDCONTROLSTATEF dwState);
        [VtblIndex(24)]
        HRESULT GetSelectedControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD *")] uint* pdwIDItem);
        [VtblIndex(25)]
        HRESULT SetSelectedControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem);
        [VtblIndex(26)]
        HRESULT StartVisualGroup([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel);
        [VtblIndex(27)]
        HRESULT EndVisualGroup();
        [VtblIndex(28)]
        HRESULT MakeProminent([NativeTypeName("DWORD")] uint dwIDCtl);
        [VtblIndex(29)]
        HRESULT SetControlItemText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, [NativeTypeName("LPCWSTR")] ushort* pszLabel);
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
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> EnableOpenDropDown;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> AddMenu;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> AddPushButton;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> AddComboBox;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> AddRadioButtonList;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, BOOL, int> AddCheckButton;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> AddEditBox;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> AddSeparator;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> AddText;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> SetControlLabel;
        [NativeTypeName("HRESULT (DWORD, CDCONTROLSTATEF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, CDCONTROLSTATEF*, int> GetControlState;
        [NativeTypeName("HRESULT (DWORD, CDCONTROLSTATEF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, CDCONTROLSTATEF, int> SetControlState;
        [NativeTypeName("HRESULT (DWORD, WCHAR **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetEditBoxText;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> SetEditBoxText;
        [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> GetCheckButtonState;
        [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, int> SetCheckButtonState;
        [NativeTypeName("HRESULT (DWORD, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ushort*, int> AddControlItem;
        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> RemoveControlItem;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveAllControlItems;
        [NativeTypeName("HRESULT (DWORD, DWORD, CDCONTROLSTATEF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, CDCONTROLSTATEF*, int> GetControlItemState;
        [NativeTypeName("HRESULT (DWORD, DWORD, CDCONTROLSTATEF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, CDCONTROLSTATEF, int> SetControlItemState;
        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetSelectedControlItem;
        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetSelectedControlItem;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> StartVisualGroup;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndVisualGroup;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> MakeProminent;
        [NativeTypeName("HRESULT (DWORD, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ushort*, int> SetControlItemText;
    }
}