// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msiltcfg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShutdownMsi"]/*' />
    [DllImport("msiltcfg", ExactSpelling = true)]
    public static extern uint ShutdownMsi([NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RestartMsi"]/*' />
    [DllImport("msiltcfg", ExactSpelling = true)]
    public static extern uint RestartMsi([NativeTypeName("DWORD")] uint dwReserved);
}
