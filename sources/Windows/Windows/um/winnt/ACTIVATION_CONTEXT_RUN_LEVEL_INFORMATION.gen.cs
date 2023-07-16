// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ACTIVATION_CONTEXT_RUN_LEVEL_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_RUN_LEVEL_INFORMATION"]/*'/>
public partial struct ACTIVATION_CONTEXT_RUN_LEVEL_INFORMATION
{
    /// <include file='ACTIVATION_CONTEXT_RUN_LEVEL_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_RUN_LEVEL_INFORMATION.ulFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ulFlags;
    /// <include file='ACTIVATION_CONTEXT_RUN_LEVEL_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_RUN_LEVEL_INFORMATION.RunLevel"]/*'/>
    public ACTCTX_REQUESTED_RUN_LEVEL RunLevel;
    /// <include file='ACTIVATION_CONTEXT_RUN_LEVEL_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_RUN_LEVEL_INFORMATION.UiAccess"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UiAccess;
}