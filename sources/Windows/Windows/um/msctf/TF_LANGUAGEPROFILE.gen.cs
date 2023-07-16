// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='TF_LANGUAGEPROFILE.xml' path='doc/member[@name="TF_LANGUAGEPROFILE"]/*'/>
public partial struct TF_LANGUAGEPROFILE
{
    /// <include file='TF_LANGUAGEPROFILE.xml' path='doc/member[@name="TF_LANGUAGEPROFILE.clsid"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid clsid;
    /// <include file='TF_LANGUAGEPROFILE.xml' path='doc/member[@name="TF_LANGUAGEPROFILE.langid"]/*'/>
    [NativeTypeName("LANGID")]
    public ushort langid;
    /// <include file='TF_LANGUAGEPROFILE.xml' path='doc/member[@name="TF_LANGUAGEPROFILE.catid"]/*'/>
    public Guid catid;
    /// <include file='TF_LANGUAGEPROFILE.xml' path='doc/member[@name="TF_LANGUAGEPROFILE.fActive"]/*'/>
    public BOOL fActive;
    /// <include file='TF_LANGUAGEPROFILE.xml' path='doc/member[@name="TF_LANGUAGEPROFILE.guidProfile"]/*'/>
    public Guid guidProfile;
}