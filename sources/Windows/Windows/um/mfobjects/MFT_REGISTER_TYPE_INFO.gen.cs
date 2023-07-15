// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='MFT_REGISTER_TYPE_INFO.xml' path='doc/member[@name="MFT_REGISTER_TYPE_INFO"]/*'/>
public partial struct MFT_REGISTER_TYPE_INFO
{
    /// <include file='MFT_REGISTER_TYPE_INFO.xml' path='doc/member[@name="MFT_REGISTER_TYPE_INFO.guidMajorType"]/*'/>
    public Guid guidMajorType;
    /// <include file='MFT_REGISTER_TYPE_INFO.xml' path='doc/member[@name="MFT_REGISTER_TYPE_INFO.guidSubtype"]/*'/>
    public Guid guidSubtype;
}