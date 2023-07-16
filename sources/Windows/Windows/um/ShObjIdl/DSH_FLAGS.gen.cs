// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='DSH_FLAGS.xml' path='doc/member[@name="DSH_FLAGS"]/*'/>
[Flags]
public enum DSH_FLAGS
{
    /// <include file='DSH_FLAGS.xml' path='doc/member[@name="DSH_FLAGS.DSH_ALLOWDROPDESCRIPTIONTEXT"]/*'/>
    DSH_ALLOWDROPDESCRIPTIONTEXT = 0x1,
}