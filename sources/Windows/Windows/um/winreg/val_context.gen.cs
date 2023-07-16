// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='val_context.xml' path='doc/member[@name="val_context"]/*'/>
public unsafe partial struct val_context
{
    /// <include file='val_context.xml' path='doc/member[@name="val_context.valuelen"]/*'/>
    public int valuelen;
    /// <include file='val_context.xml' path='doc/member[@name="val_context.value_context"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* value_context;
    /// <include file='val_context.xml' path='doc/member[@name="val_context.val_buff_ptr"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* val_buff_ptr;
}