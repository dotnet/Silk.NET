// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='APC_CALLBACK_DATA.xml' path='doc/member[@name="APC_CALLBACK_DATA"]/*'/>
public unsafe partial struct APC_CALLBACK_DATA
{
    /// <include file='APC_CALLBACK_DATA.xml' path='doc/member[@name="APC_CALLBACK_DATA.Parameter"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint Parameter;
    /// <include file='APC_CALLBACK_DATA.xml' path='doc/member[@name="APC_CALLBACK_DATA.ContextRecord"]/*'/>
    [NativeTypeName("PCONTEXT")]
    public void* ContextRecord;
    /// <include file='APC_CALLBACK_DATA.xml' path='doc/member[@name="APC_CALLBACK_DATA.Reserved0"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved0;
    /// <include file='APC_CALLBACK_DATA.xml' path='doc/member[@name="APC_CALLBACK_DATA.Reserved1"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved1;
}