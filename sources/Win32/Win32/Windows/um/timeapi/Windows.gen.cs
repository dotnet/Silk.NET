// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/timeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint timeGetSystemTime(
        [NativeTypeName("LPMMTIME")] MMTIME* pmmt,
        uint cbmmt
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint timeGetTime();

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint timeGetDevCaps(
        [NativeTypeName("LPTIMECAPS")] TIMECAPS* ptc,
        uint cbtc
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint timeBeginPeriod(uint uPeriod);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint timeEndPeriod(uint uPeriod);

    [NativeTypeName("#define TIMERR_NOERROR (0)")]
    public const int TIMERR_NOERROR = (0);

    [NativeTypeName("#define TIMERR_NOCANDO (TIMERR_BASE+1)")]
    public const int TIMERR_NOCANDO = (96 + 1);

    [NativeTypeName("#define TIMERR_STRUCT (TIMERR_BASE+33)")]
    public const int TIMERR_STRUCT = (96 + 33);
}
