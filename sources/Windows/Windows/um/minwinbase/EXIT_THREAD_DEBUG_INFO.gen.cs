// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EXIT_THREAD_DEBUG_INFO.xml' path='doc/member[@name="EXIT_THREAD_DEBUG_INFO"]/*'/>
public partial struct EXIT_THREAD_DEBUG_INFO
{
    /// <include file='EXIT_THREAD_DEBUG_INFO.xml' path='doc/member[@name="EXIT_THREAD_DEBUG_INFO.dwExitCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwExitCode;
}