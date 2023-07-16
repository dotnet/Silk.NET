// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA"]/*'/>
[SupportedOSPlatform("windows10.0.17763.0")]
public unsafe partial struct PRJ_CALLBACK_DATA
{
    /// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA.Size"]/*'/>
    [NativeTypeName("UINT32")]
    public uint Size;
    /// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA.Flags"]/*'/>
    public PRJ_CALLBACK_DATA_FLAGS Flags;
    /// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA.NamespaceVirtualizationContext"]/*'/>
    public PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT NamespaceVirtualizationContext;
    /// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA.CommandId"]/*'/>
    [NativeTypeName("INT32")]
    public int CommandId;
    /// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA.FileId"]/*'/>
    public Guid FileId;
    /// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA.DataStreamId"]/*'/>
    public Guid DataStreamId;
    /// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA.FilePathName"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* FilePathName;
    /// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA.VersionInfo"]/*'/>
    public PRJ_PLACEHOLDER_VERSION_INFO* VersionInfo;
    /// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA.TriggeringProcessId"]/*'/>
    [NativeTypeName("UINT32")]
    public uint TriggeringProcessId;
    /// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA.TriggeringProcessImageFileName"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* TriggeringProcessImageFileName;
    /// <include file='PRJ_CALLBACK_DATA.xml' path='doc/member[@name="PRJ_CALLBACK_DATA.InstanceContext"]/*'/>
    public void* InstanceContext;
}