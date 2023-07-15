// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class CTF
{
    public const int CTF_INSIST = 0x00000001;
    public const int CTF_THREAD_REF = 0x00000002;
    public const int CTF_PROCESS_REF = 0x00000004;
    public const int CTF_COINIT_STA = 0x00000008;
    public const int CTF_COINIT = 0x00000008;
    public const int CTF_FREELIBANDEXIT = 0x00000010;
    public const int CTF_REF_COUNTED = 0x00000020;
    public const int CTF_WAIT_ALLOWCOM = 0x00000040;
    public const int CTF_UNUSED = 0x00000080;
    public const int CTF_INHERITWOW64 = 0x00000100;
    public const int CTF_WAIT_NO_REENTRANCY = 0x00000200;
    public const int CTF_KEYBOARD_LOCALE = 0x00000400;
    public const int CTF_OLEINITIALIZE = 0x00000800;
    public const int CTF_COINIT_MTA = 0x00001000;
    public const int CTF_NOADDREFLIB = 0x00002000;
}