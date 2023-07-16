// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CFG_CALL_TARGET_INFO.xml' path='doc/member[@name="CFG_CALL_TARGET_INFO"]/*'/>
public partial struct CFG_CALL_TARGET_INFO
{
    /// <include file='CFG_CALL_TARGET_INFO.xml' path='doc/member[@name="CFG_CALL_TARGET_INFO.Offset"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint Offset;
    /// <include file='CFG_CALL_TARGET_INFO.xml' path='doc/member[@name="CFG_CALL_TARGET_INFO.Flags"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint Flags;
}