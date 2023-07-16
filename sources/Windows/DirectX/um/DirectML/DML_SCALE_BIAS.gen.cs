// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DML_SCALE_BIAS.xml' path='doc/member[@name="DML_SCALE_BIAS"]/*'/>
public partial struct DML_SCALE_BIAS
{
    /// <include file='DML_SCALE_BIAS.xml' path='doc/member[@name="DML_SCALE_BIAS.Scale"]/*'/>
    public float Scale;
    /// <include file='DML_SCALE_BIAS.xml' path='doc/member[@name="DML_SCALE_BIAS.Bias"]/*'/>
    public float Bias;
}