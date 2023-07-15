// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsProcessInWDAGContainer"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    public static extern HRESULT IsProcessInWDAGContainer([NativeTypeName("PVOID")] void* Reserved, BOOL* isProcessInWDAGContainer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsProcessInIsolatedContainer"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    public static extern HRESULT IsProcessInIsolatedContainer(BOOL* isProcessInIsolatedContainer);
}