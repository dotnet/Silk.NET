// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPAUDIOOPTIONS.xml' path='doc/member[@name="SPAUDIOOPTIONS"]/*'/>
public enum SPAUDIOOPTIONS
{
    /// <include file='SPAUDIOOPTIONS.xml' path='doc/member[@name="SPAUDIOOPTIONS.SPAO_NONE"]/*'/>
    SPAO_NONE = 0,
    /// <include file='SPAUDIOOPTIONS.xml' path='doc/member[@name="SPAUDIOOPTIONS.SPAO_RETAIN_AUDIO"]/*'/>
    SPAO_RETAIN_AUDIO = (1 << 0),
}