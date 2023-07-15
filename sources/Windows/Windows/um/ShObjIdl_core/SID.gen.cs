// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
public partial struct SID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_URLExecutionContext
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0x8E,
                0x5F,
                0xFB,
                0xB6,
                0xBB,
                0x10,
                0x4D,
                0xA4,
                0x61,
                0x77,
                0x72,
                0x91,
                0xA0,
                0x90,
                0x30
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_LaunchSourceViewSizePreference
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0x54,
                0x60,
                0x80,
                0xD9,
                0x67,
                0x4F,
                0x41,
                0xAF,
                0x89,
                0xA1,
                0xCD,
                0xF1,
                0x24,
                0x2B,
                0xC1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_LaunchTargetViewSizePreference
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0x24,
                0xDB,
                0x26,
                0xB7,
                0xB7,
                0x6B,
                0x40,
                0x97,
                0x02,
                0x73,
                0x0A,
                0x4E,
                0x20,
                0xD3,
                0xBF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_LaunchSourceAppUserModelId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x80,
                0xE7,
                0x2C,
                0xDB,
                0x74,
                0xBC,
                0x48,
                0x9C,
                0x6A,
                0x10,
                0xF3,
                0x72,
                0x49,
                0x57,
                0x23
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_ShellExecuteNamedPropertyStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0xAD,
                0x84,
                0xEB,
                0xFF,
                0x00,
                0x92,
                0x49,
                0x83,
                0x24,
                0xED,
                0x5C,
                0xE0,
                0x61,
                0xCB,
                0x29
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define SID_ShellTaskScheduler IID_IShellTaskScheduler")]
    public static ref readonly Guid SID_ShellTaskScheduler => ref IID_IShellTaskScheduler;

    [NativeTypeName("#define SID_SFolderView IID_IFolderView")]
    public static ref readonly Guid SID_SFolderView => ref IID_IFolderView;

    [NativeTypeName("#define SID_SExplorerBrowserFrame IID_ICommDlgBrowser")]
    public static ref readonly Guid SID_SExplorerBrowserFrame => ref IID_ICommDlgBrowser;

    [NativeTypeName("#define SID_SProfferService IID_IProfferService")]
    public static ref readonly Guid SID_SProfferService => ref IID_IProfferService;

    [NativeTypeName("#define SID_SBandSite IID_IBandSite")]
    public static ref readonly Guid SID_SBandSite => ref IID_IBandSite;

    [NativeTypeName("#define SID_SNewWindowManager IID_INewWindowManager")]
    public static ref readonly Guid SID_SNewWindowManager => ref IID_INewWindowManager;

    [NativeTypeName("#define SID_SNewMenuClient IID_INewMenuClient")]
    public static ref readonly Guid SID_SNewMenuClient => ref IID_INewMenuClient;

    [NativeTypeName("#define SID_SNavigationPane IID_INameSpaceTreeControl")]
    public static ref readonly Guid SID_SNavigationPane => ref IID_INameSpaceTreeControl;

    [NativeTypeName("#define SID_ExplorerPaneVisibility IID_IExplorerPaneVisibility")]
    public static ref readonly Guid SID_ExplorerPaneVisibility => ref IID_IExplorerPaneVisibility;

    [NativeTypeName("#define SID_ExecuteCommandHost IID_IExecuteCommandHost")]
    public static ref readonly Guid SID_ExecuteCommandHost => ref IID_IExecuteCommandHost;

    [NativeTypeName("#define SID_HandlerInfo IID_IHandlerInfo")]
    public static ref readonly Guid SID_HandlerInfo => ref IID_IHandlerInfo;

    [NativeTypeName("#define SID_SHandlerActivationHost IID_IHandlerActivationHost")]
    public static ref readonly Guid SID_SHandlerActivationHost => ref IID_IHandlerActivationHost;

    [NativeTypeName("#define SID_AppActivationUIInfo IID_IAppActivationUIInfo")]
    public static ref readonly Guid SID_AppActivationUIInfo => ref IID_IAppActivationUIInfo;
}