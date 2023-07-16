// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_FUNCTION_OVERRIDE_HEADER.xml' path='doc/member[@name="IMAGE_FUNCTION_OVERRIDE_HEADER"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_FUNCTION_OVERRIDE_HEADER
{
    /// <include file='IMAGE_FUNCTION_OVERRIDE_HEADER.xml' path='doc/member[@name="IMAGE_FUNCTION_OVERRIDE_HEADER.FuncOverrideSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FuncOverrideSize;
}