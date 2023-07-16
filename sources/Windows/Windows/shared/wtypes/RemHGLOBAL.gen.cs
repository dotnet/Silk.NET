// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='RemHGLOBAL.xml' path='doc/member[@name="RemHGLOBAL"]/*'/>
public unsafe partial struct RemHGLOBAL
{
    /// <include file='RemHGLOBAL.xml' path='doc/member[@name="RemHGLOBAL.fNullHGlobal"]/*'/>
    [NativeTypeName("LONG")]
    public int fNullHGlobal;
    /// <include file='RemHGLOBAL.xml' path='doc/member[@name="RemHGLOBAL.cbData"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbData;
    /// <include file='RemHGLOBAL.xml' path='doc/member[@name="RemHGLOBAL.data"]/*'/>
    [NativeTypeName("byte[1]")]
    public fixed byte data[1];
}