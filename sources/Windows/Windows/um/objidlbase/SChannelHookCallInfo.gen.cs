// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SChannelHookCallInfo.xml' path='doc/member[@name="SChannelHookCallInfo"]/*'/>
public unsafe partial struct SChannelHookCallInfo
{
    /// <include file='SChannelHookCallInfo.xml' path='doc/member[@name="SChannelHookCallInfo.iid"]/*'/>
    [NativeTypeName("IID")]
    public Guid iid;
    /// <include file='SChannelHookCallInfo.xml' path='doc/member[@name="SChannelHookCallInfo.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='SChannelHookCallInfo.xml' path='doc/member[@name="SChannelHookCallInfo.uCausality"]/*'/>
    public Guid uCausality;
    /// <include file='SChannelHookCallInfo.xml' path='doc/member[@name="SChannelHookCallInfo.dwServerPid"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwServerPid;
    /// <include file='SChannelHookCallInfo.xml' path='doc/member[@name="SChannelHookCallInfo.iMethod"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iMethod;
    /// <include file='SChannelHookCallInfo.xml' path='doc/member[@name="SChannelHookCallInfo.pObject"]/*'/>
    public void* pObject;
}