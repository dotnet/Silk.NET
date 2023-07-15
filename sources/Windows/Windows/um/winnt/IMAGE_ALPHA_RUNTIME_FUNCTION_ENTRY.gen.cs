// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY"]/*'/>
public partial struct IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY
{
    /// <include file='IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY.BeginAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BeginAddress;
    /// <include file='IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY.EndAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EndAddress;
    /// <include file='IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY.ExceptionHandler"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExceptionHandler;
    /// <include file='IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY.HandlerData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HandlerData;
    /// <include file='IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY.PrologEndAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PrologEndAddress;
}