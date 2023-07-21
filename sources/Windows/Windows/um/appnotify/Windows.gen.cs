// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appnotify.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterAppStateChangeNotification"]/*' />
    [DllImport("twinapi.appcore.dll", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint RegisterAppStateChangeNotification([NativeTypeName("PAPPSTATE_CHANGE_ROUTINE")] delegate* unmanaged<byte, void*, void> Routine, [NativeTypeName("PVOID")] void* Context, PAPPSTATE_REGISTRATION* Registration);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterAppStateChangeNotification"]/*' />
    [DllImport("twinapi.appcore.dll", ExactSpelling = true)]
    public static extern void UnregisterAppStateChangeNotification(PAPPSTATE_REGISTRATION Registration);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterAppConstrainedChangeNotification"]/*' />
    [DllImport("twinapi.appcore.dll", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint RegisterAppConstrainedChangeNotification([NativeTypeName("PAPPCONSTRAIN_CHANGE_ROUTINE")] delegate* unmanaged<byte, void*, void> Routine, [NativeTypeName("PVOID")] void* Context, PAPPCONSTRAIN_REGISTRATION* Registration);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterAppConstrainedChangeNotification"]/*' />
    [DllImport("twinapi.appcore.dll", ExactSpelling = true)]
    public static extern void UnregisterAppConstrainedChangeNotification(PAPPCONSTRAIN_REGISTRATION Registration);
}
