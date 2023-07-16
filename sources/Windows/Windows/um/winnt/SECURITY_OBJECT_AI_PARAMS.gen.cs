// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SECURITY_OBJECT_AI_PARAMS.xml' path='doc/member[@name="SECURITY_OBJECT_AI_PARAMS"]/*'/>
public partial struct SECURITY_OBJECT_AI_PARAMS
{
    /// <include file='SECURITY_OBJECT_AI_PARAMS.xml' path='doc/member[@name="SECURITY_OBJECT_AI_PARAMS.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SECURITY_OBJECT_AI_PARAMS.xml' path='doc/member[@name="SECURITY_OBJECT_AI_PARAMS.ConstraintMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ConstraintMask;
}