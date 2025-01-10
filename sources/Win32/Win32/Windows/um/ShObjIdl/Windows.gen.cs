// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using static Silk.NET.Windows.NSTCSTYLE2;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHAddDefaultPropertiesByExt(
        [NativeTypeName("PCWSTR")] ushort* pszExt,
        IPropertyStore pPropStore
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateDefaultPropertiesOp(
        IShellItem psi,
        IFileOperation* ppFileOp
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetDefaultProperties(
        HWND hwnd,
        IShellItem psi,
        [NativeTypeName("DWORD")] uint dwFileOpFlags,
        IFileOperationProgressSink pfops
    );

    [NativeTypeName("#define SHPWHF_NORECOMPRESS 0x00000001")]
    public const int SHPWHF_NORECOMPRESS = 0x00000001;

    [NativeTypeName("#define SHPWHF_NONETPLACECREATE 0x00000002")]
    public const int SHPWHF_NONETPLACECREATE = 0x00000002;

    [NativeTypeName("#define SHPWHF_NOFILESELECTOR 0x00000004")]
    public const int SHPWHF_NOFILESELECTOR = 0x00000004;

    [NativeTypeName("#define SHPWHF_USEMRU 0x00000008")]
    public const int SHPWHF_USEMRU = 0x00000008;

    [NativeTypeName("#define SHPWHF_ANYLOCATION 0x00000100")]
    public const int SHPWHF_ANYLOCATION = 0x00000100;

    [NativeTypeName("#define SHPWHF_VALIDATEVIAWEBFOLDERS 0x00010000")]
    public const int SHPWHF_VALIDATEVIAWEBFOLDERS = 0x00010000;

    [NativeTypeName("#define ACDD_VISIBLE 0x0001")]
    public const int ACDD_VISIBLE = 0x0001;

    [NativeTypeName("#define PROPSTR_EXTENSIONCOMPLETIONSTATE L\"ExtensionCompletionState\"")]
    public const string PROPSTR_EXTENSIONCOMPLETIONSTATE = "ExtensionCompletionState";

    [NativeTypeName(
        "#define NSTCS2_ALLMASK (NSTCS2_INTERRUPTNOTIFICATIONS | NSTCS2_SHOWNULLSPACEMENU | NSTCS2_DISPLAYPADDING)"
    )]
    public const NSTCSTYLE2 NSTCS2_ALLMASK = (
        NSTCS2_INTERRUPTNOTIFICATIONS | NSTCS2_SHOWNULLSPACEMENU | NSTCS2_DISPLAYPADDING
    );

    [NativeTypeName("#define NSTCDHPOS_ONTOP -1")]
    public const int NSTCDHPOS_ONTOP = -1;
}
