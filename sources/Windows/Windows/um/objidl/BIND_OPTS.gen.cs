// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BIND_OPTS.xml' path='doc/member[@name="BIND_OPTS"]/*'/>
public partial struct BIND_OPTS
{
    /// <include file='BIND_OPTS.xml' path='doc/member[@name="BIND_OPTS.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='BIND_OPTS.xml' path='doc/member[@name="BIND_OPTS.grfFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfFlags;
    /// <include file='BIND_OPTS.xml' path='doc/member[@name="BIND_OPTS.grfMode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfMode;
    /// <include file='BIND_OPTS.xml' path='doc/member[@name="BIND_OPTS.dwTickCountDeadline"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTickCountDeadline;
}