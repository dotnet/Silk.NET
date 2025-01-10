// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class ASSOCF
{
    public const int ASSOCF_NONE = 0x00000000;
    public const int ASSOCF_INIT_NOREMAPCLSID = 0x00000001;
    public const int ASSOCF_INIT_BYEXENAME = 0x00000002;
    public const int ASSOCF_OPEN_BYEXENAME = 0x00000002;
    public const int ASSOCF_INIT_DEFAULTTOSTAR = 0x00000004;
    public const int ASSOCF_INIT_DEFAULTTOFOLDER = 0x00000008;
    public const int ASSOCF_NOUSERSETTINGS = 0x00000010;
    public const int ASSOCF_NOTRUNCATE = 0x00000020;
    public const int ASSOCF_VERIFY = 0x00000040;
    public const int ASSOCF_REMAPRUNDLL = 0x00000080;
    public const int ASSOCF_NOFIXUPS = 0x00000100;
    public const int ASSOCF_IGNOREBASECLASS = 0x00000200;
    public const int ASSOCF_INIT_IGNOREUNKNOWN = 0x00000400;
    public const int ASSOCF_INIT_FIXED_PROGID = 0x00000800;
    public const int ASSOCF_IS_PROTOCOL = 0x00001000;
    public const int ASSOCF_INIT_FOR_FILE = 0x00002000;
    public const int ASSOCF_IS_FULL_URI = 0x00004000;
    public const int ASSOCF_PER_MACHINE_ONLY = 0x00008000;
    public const int ASSOCF_APP_TO_APP = 0x00010000;
}
