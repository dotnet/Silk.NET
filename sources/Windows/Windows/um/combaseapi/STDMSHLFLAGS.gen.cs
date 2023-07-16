// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='STDMSHLFLAGS.xml' path='doc/member[@name="STDMSHLFLAGS"]/*'/>
[Flags]
public enum STDMSHLFLAGS
{
    /// <include file='STDMSHLFLAGS.xml' path='doc/member[@name="STDMSHLFLAGS.SMEXF_SERVER"]/*'/>
    SMEXF_SERVER = 0x01,
    /// <include file='STDMSHLFLAGS.xml' path='doc/member[@name="STDMSHLFLAGS.SMEXF_HANDLER"]/*'/>
    SMEXF_HANDLER = 0x02,
}