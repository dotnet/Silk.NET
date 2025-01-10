// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PANOSE
{
    public byte bFamilyType;
    public byte bSerifStyle;
    public byte bWeight;
    public byte bProportion;
    public byte bContrast;
    public byte bStrokeVariation;
    public byte bArmStyle;
    public byte bLetterform;
    public byte bMidline;
    public byte bXHeight;
}
