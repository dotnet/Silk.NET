// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='QualityMessageType.xml' path='doc/member[@name="QualityMessageType"]/*'/>
public enum QualityMessageType
{
    /// <include file='QualityMessageType.xml' path='doc/member[@name="QualityMessageType.Famine"]/*'/>
    Famine = 0,
    /// <include file='QualityMessageType.xml' path='doc/member[@name="QualityMessageType.Flood"]/*'/>
    Flood = (Famine + 1),
}