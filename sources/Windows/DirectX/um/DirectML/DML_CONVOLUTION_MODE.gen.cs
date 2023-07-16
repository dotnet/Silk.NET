// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DML_CONVOLUTION_MODE.xml' path='doc/member[@name="DML_CONVOLUTION_MODE"]/*'/>
public enum DML_CONVOLUTION_MODE
{
    /// <include file='DML_CONVOLUTION_MODE.xml' path='doc/member[@name="DML_CONVOLUTION_MODE.DML_CONVOLUTION_MODE_CONVOLUTION"]/*'/>
    DML_CONVOLUTION_MODE_CONVOLUTION,
    /// <include file='DML_CONVOLUTION_MODE.xml' path='doc/member[@name="DML_CONVOLUTION_MODE.DML_CONVOLUTION_MODE_CROSS_CORRELATION"]/*'/>
    DML_CONVOLUTION_MODE_CROSS_CORRELATION,
}