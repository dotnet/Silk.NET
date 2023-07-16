// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FaceCharacterization.xml' path='doc/member[@name="FaceCharacterization"]/*'/>
public partial struct FaceCharacterization
{
    /// <include file='FaceCharacterization.xml' path='doc/member[@name="FaceCharacterization.BlinkScoreLeft"]/*'/>
    [NativeTypeName("ULONG")]
    public uint BlinkScoreLeft;
    /// <include file='FaceCharacterization.xml' path='doc/member[@name="FaceCharacterization.BlinkScoreRight"]/*'/>
    [NativeTypeName("ULONG")]
    public uint BlinkScoreRight;
    /// <include file='FaceCharacterization.xml' path='doc/member[@name="FaceCharacterization.FacialExpression"]/*'/>
    [NativeTypeName("ULONG")]
    public uint FacialExpression;
    /// <include file='FaceCharacterization.xml' path='doc/member[@name="FaceCharacterization.FacialExpressionScore"]/*'/>
    [NativeTypeName("ULONG")]
    public uint FacialExpressionScore;
}