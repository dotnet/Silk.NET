// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CLASS_MEDIA_CHANGE_CONTEXT.xml' path='doc/member[@name="CLASS_MEDIA_CHANGE_CONTEXT"]/*'/>
public partial struct CLASS_MEDIA_CHANGE_CONTEXT
{
    /// <include file='CLASS_MEDIA_CHANGE_CONTEXT.xml' path='doc/member[@name="CLASS_MEDIA_CHANGE_CONTEXT.MediaChangeCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MediaChangeCount;
    /// <include file='CLASS_MEDIA_CHANGE_CONTEXT.xml' path='doc/member[@name="CLASS_MEDIA_CHANGE_CONTEXT.NewState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NewState;
}