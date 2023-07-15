// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TF_DA_ATTR_INFO.xml' path='doc/member[@name="TF_DA_ATTR_INFO"]/*'/>
public enum TF_DA_ATTR_INFO
{
    /// <include file='TF_DA_ATTR_INFO.xml' path='doc/member[@name="TF_DA_ATTR_INFO.TF_ATTR_INPUT"]/*'/>
    TF_ATTR_INPUT = 0,
    /// <include file='TF_DA_ATTR_INFO.xml' path='doc/member[@name="TF_DA_ATTR_INFO.TF_ATTR_TARGET_CONVERTED"]/*'/>
    TF_ATTR_TARGET_CONVERTED = 1,
    /// <include file='TF_DA_ATTR_INFO.xml' path='doc/member[@name="TF_DA_ATTR_INFO.TF_ATTR_CONVERTED"]/*'/>
    TF_ATTR_CONVERTED = 2,
    /// <include file='TF_DA_ATTR_INFO.xml' path='doc/member[@name="TF_DA_ATTR_INFO.TF_ATTR_TARGET_NOTCONVERTED"]/*'/>
    TF_ATTR_TARGET_NOTCONVERTED = 3,
    /// <include file='TF_DA_ATTR_INFO.xml' path='doc/member[@name="TF_DA_ATTR_INFO.TF_ATTR_INPUT_ERROR"]/*'/>
    TF_ATTR_INPUT_ERROR = 4,
    /// <include file='TF_DA_ATTR_INFO.xml' path='doc/member[@name="TF_DA_ATTR_INFO.TF_ATTR_FIXEDCONVERTED"]/*'/>
    TF_ATTR_FIXEDCONVERTED = 5,
    /// <include file='TF_DA_ATTR_INFO.xml' path='doc/member[@name="TF_DA_ATTR_INFO.TF_ATTR_OTHER"]/*'/>
    TF_ATTR_OTHER = -1,
}