// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Windows.Devices.Display.Core.Interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;
public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.Int64FromLuid"]/*'/>
    [return: NativeTypeName("INT64")]
    public static long Int64FromLuid([NativeTypeName("const LUID &")] LUID* Luid)
    {
        LARGE_INTEGER val = new LARGE_INTEGER();
        val.Anonymous.LowPart = Luid->LowPart;
        val.Anonymous.HighPart = Luid->HighPart;
        return val.QuadPart;
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.LuidFromInt64"]/*'/>
    public static LUID LuidFromInt64([NativeTypeName("INT64")] long Int64)
    {
        LARGE_INTEGER val = new LARGE_INTEGER();
        val.QuadPart = Int64;
        LUID Luid = new LUID();
        Luid.LowPart = val.Anonymous.LowPart;
        Luid.HighPart = val.Anonymous.HighPart;
        return Luid;
    }
}