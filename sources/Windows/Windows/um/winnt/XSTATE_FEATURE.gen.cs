// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='XSTATE_FEATURE.xml' path='doc/member[@name="XSTATE_FEATURE"]/*'/>
public partial struct XSTATE_FEATURE
{
    /// <include file='XSTATE_FEATURE.xml' path='doc/member[@name="XSTATE_FEATURE.Offset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Offset;
    /// <include file='XSTATE_FEATURE.xml' path='doc/member[@name="XSTATE_FEATURE.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
}