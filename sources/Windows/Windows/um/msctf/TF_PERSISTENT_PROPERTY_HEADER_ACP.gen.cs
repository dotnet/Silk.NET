// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='TF_PERSISTENT_PROPERTY_HEADER_ACP.xml' path='doc/member[@name="TF_PERSISTENT_PROPERTY_HEADER_ACP"]/*'/>
public partial struct TF_PERSISTENT_PROPERTY_HEADER_ACP
{
    /// <include file='TF_PERSISTENT_PROPERTY_HEADER_ACP.xml' path='doc/member[@name="TF_PERSISTENT_PROPERTY_HEADER_ACP.guidType"]/*'/>
    public Guid guidType;
    /// <include file='TF_PERSISTENT_PROPERTY_HEADER_ACP.xml' path='doc/member[@name="TF_PERSISTENT_PROPERTY_HEADER_ACP.ichStart"]/*'/>
    [NativeTypeName("LONG")]
    public int ichStart;
    /// <include file='TF_PERSISTENT_PROPERTY_HEADER_ACP.xml' path='doc/member[@name="TF_PERSISTENT_PROPERTY_HEADER_ACP.cch"]/*'/>
    [NativeTypeName("LONG")]
    public int cch;
    /// <include file='TF_PERSISTENT_PROPERTY_HEADER_ACP.xml' path='doc/member[@name="TF_PERSISTENT_PROPERTY_HEADER_ACP.cb"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cb;
    /// <include file='TF_PERSISTENT_PROPERTY_HEADER_ACP.xml' path='doc/member[@name="TF_PERSISTENT_PROPERTY_HEADER_ACP.dwPrivate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPrivate;
    /// <include file='TF_PERSISTENT_PROPERTY_HEADER_ACP.xml' path='doc/member[@name="TF_PERSISTENT_PROPERTY_HEADER_ACP.clsidTIP"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid clsidTIP;
}