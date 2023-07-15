// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='UNLOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="UNLOAD_DLL_DEBUG_INFO"]/*'/>
public unsafe partial struct UNLOAD_DLL_DEBUG_INFO
{
    /// <include file='UNLOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="UNLOAD_DLL_DEBUG_INFO.lpBaseOfDll"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* lpBaseOfDll;
}