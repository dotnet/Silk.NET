// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TsRunType.xml' path='doc/member[@name="TsRunType"]/*'/>
public enum TsRunType
{
    /// <include file='TsRunType.xml' path='doc/member[@name="TsRunType.TS_RT_PLAIN"]/*'/>
    TS_RT_PLAIN = 0,
    /// <include file='TsRunType.xml' path='doc/member[@name="TsRunType.TS_RT_HIDDEN"]/*'/>
    TS_RT_HIDDEN = (TS_RT_PLAIN + 1),
    /// <include file='TsRunType.xml' path='doc/member[@name="TsRunType.TS_RT_OPAQUE"]/*'/>
    TS_RT_OPAQUE = (TS_RT_HIDDEN + 1),
}