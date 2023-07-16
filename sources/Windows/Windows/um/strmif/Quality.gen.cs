// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='Quality.xml' path='doc/member[@name="Quality"]/*'/>
public partial struct Quality
{
    /// <include file='Quality.xml' path='doc/member[@name="Quality.Type"]/*'/>
    public QualityMessageType Type;
    /// <include file='Quality.xml' path='doc/member[@name="Quality.Proportion"]/*'/>
    [NativeTypeName("long")]
    public int Proportion;
    /// <include file='Quality.xml' path='doc/member[@name="Quality.Late"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long Late;
    /// <include file='Quality.xml' path='doc/member[@name="Quality.TimeStamp"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long TimeStamp;
}