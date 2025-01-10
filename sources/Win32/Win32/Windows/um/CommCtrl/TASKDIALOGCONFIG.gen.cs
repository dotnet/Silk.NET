// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct TASKDIALOGCONFIG
{
    public uint cbSize;
    public HWND hwndParent;
    public HINSTANCE hInstance;

    [NativeTypeName("TASKDIALOG_FLAGS")]
    public int dwFlags;

    [NativeTypeName("TASKDIALOG_COMMON_BUTTON_FLAGS")]
    public int dwCommonButtons;

    [NativeTypeName("PCWSTR")]
    public ushort* pszWindowTitle;

    [NativeTypeName("__AnonymousRecord_CommCtrl_L7735_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("PCWSTR")]
    public ushort* pszMainInstruction;

    [NativeTypeName("PCWSTR")]
    public ushort* pszContent;
    public uint cButtons;

    [NativeTypeName("const TASKDIALOG_BUTTON *")]
    public TASKDIALOG_BUTTON* pButtons;
    public int nDefaultButton;
    public uint cRadioButtons;

    [NativeTypeName("const TASKDIALOG_BUTTON *")]
    public TASKDIALOG_BUTTON* pRadioButtons;
    public int nDefaultRadioButton;

    [NativeTypeName("PCWSTR")]
    public ushort* pszVerificationText;

    [NativeTypeName("PCWSTR")]
    public ushort* pszExpandedInformation;

    [NativeTypeName("PCWSTR")]
    public ushort* pszExpandedControlText;

    [NativeTypeName("PCWSTR")]
    public ushort* pszCollapsedControlText;

    [NativeTypeName("__AnonymousRecord_CommCtrl_L7752_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("PCWSTR")]
    public ushort* pszFooter;

    [NativeTypeName("PFTASKDIALOGCALLBACK")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint, HRESULT> pfCallback;

    [NativeTypeName("LONG_PTR")]
    public nint lpCallbackData;
    public uint cxWidth;

    [UnscopedRef]
    public ref HICON hMainIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.hMainIcon; }
    }

    [UnscopedRef]
    public ref ushort* pszMainIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.pszMainIcon; }
    }

    [UnscopedRef]
    public ref HICON hFooterIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.hFooterIcon; }
    }

    [UnscopedRef]
    public ref ushort* pszFooterIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.pszFooterIcon; }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public HICON hMainIcon;

        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pszMainIcon;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public HICON hFooterIcon;

        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pszFooterIcon;
    }
}
