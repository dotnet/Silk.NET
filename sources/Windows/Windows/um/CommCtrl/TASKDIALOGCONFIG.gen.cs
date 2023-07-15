// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct TASKDIALOGCONFIG
{
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.hwndParent"]/*'/>
    public HWND hwndParent;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.dwFlags"]/*'/>
    [NativeTypeName("TASKDIALOG_FLAGS")]
    public int dwFlags;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.dwCommonButtons"]/*'/>
    [NativeTypeName("TASKDIALOG_COMMON_BUTTON_FLAGS")]
    public int dwCommonButtons;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.pszWindowTitle"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pszWindowTitle;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_CommCtrl_L7735_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.pszMainInstruction"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pszMainInstruction;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.pszContent"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pszContent;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.cButtons"]/*'/>
    public uint cButtons;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.pButtons"]/*'/>
    [NativeTypeName("const TASKDIALOG_BUTTON *")]
    public TASKDIALOG_BUTTON* pButtons;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.nDefaultButton"]/*'/>
    public int nDefaultButton;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.cRadioButtons"]/*'/>
    public uint cRadioButtons;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.pRadioButtons"]/*'/>
    [NativeTypeName("const TASKDIALOG_BUTTON *")]
    public TASKDIALOG_BUTTON* pRadioButtons;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.nDefaultRadioButton"]/*'/>
    public int nDefaultRadioButton;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.pszVerificationText"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pszVerificationText;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.pszExpandedInformation"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pszExpandedInformation;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.pszExpandedControlText"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pszExpandedControlText;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.pszCollapsedControlText"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pszCollapsedControlText;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_CommCtrl_L7752_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.pszFooter"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pszFooter;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.pfCallback"]/*'/>
    [NativeTypeName("PFTASKDIALOGCALLBACK")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint, HRESULT> pfCallback;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.lpCallbackData"]/*'/>
    [NativeTypeName("LONG_PTR")]
    public nint lpCallbackData;
    /// <include file='TASKDIALOGCONFIG.xml' path='doc/member[@name="TASKDIALOGCONFIG.cxWidth"]/*'/>
    public uint cxWidth;
    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.hMainIcon"]/*'/>
    [UnscopedRef]
    public ref HICON hMainIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.hMainIcon;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszMainIcon"]/*'/>
    [UnscopedRef]
    public ref ushort* pszMainIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.pszMainIcon;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.hFooterIcon"]/*'/>
    [UnscopedRef]
    public ref HICON hFooterIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.hFooterIcon;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszFooterIcon"]/*'/>
    [UnscopedRef]
    public ref ushort* pszFooterIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pszFooterIcon;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.hMainIcon"]/*'/>
        [FieldOffset(0)]
        public HICON hMainIcon;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszMainIcon"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pszMainIcon;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.hFooterIcon"]/*'/>
        [FieldOffset(0)]
        public HICON hFooterIcon;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszFooterIcon"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pszFooterIcon;
    }
}