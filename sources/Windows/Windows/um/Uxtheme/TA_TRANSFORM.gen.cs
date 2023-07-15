// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TA_TRANSFORM.xml' path='doc/member[@name="TA_TRANSFORM"]/*'/>
public partial struct TA_TRANSFORM
{
    /// <include file='TA_TRANSFORM.xml' path='doc/member[@name="TA_TRANSFORM.eTransformType"]/*'/>
    public TA_TRANSFORM_TYPE eTransformType;
    /// <include file='TA_TRANSFORM.xml' path='doc/member[@name="TA_TRANSFORM.dwTimingFunctionId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTimingFunctionId;
    /// <include file='TA_TRANSFORM.xml' path='doc/member[@name="TA_TRANSFORM.dwStartTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStartTime;
    /// <include file='TA_TRANSFORM.xml' path='doc/member[@name="TA_TRANSFORM.dwDurationTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDurationTime;
    /// <include file='TA_TRANSFORM.xml' path='doc/member[@name="TA_TRANSFORM.eFlags"]/*'/>
    public TA_TRANSFORM_FLAG eFlags;
}