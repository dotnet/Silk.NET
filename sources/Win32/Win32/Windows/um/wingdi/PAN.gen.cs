// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class PAN
{
    [NativeTypeName("#define PAN_FAMILYTYPE_INDEX 0")]
    public const int PAN_FAMILYTYPE_INDEX = 0;

    [NativeTypeName("#define PAN_SERIFSTYLE_INDEX 1")]
    public const int PAN_SERIFSTYLE_INDEX = 1;

    [NativeTypeName("#define PAN_WEIGHT_INDEX 2")]
    public const int PAN_WEIGHT_INDEX = 2;

    [NativeTypeName("#define PAN_PROPORTION_INDEX 3")]
    public const int PAN_PROPORTION_INDEX = 3;

    [NativeTypeName("#define PAN_CONTRAST_INDEX 4")]
    public const int PAN_CONTRAST_INDEX = 4;

    [NativeTypeName("#define PAN_STROKEVARIATION_INDEX 5")]
    public const int PAN_STROKEVARIATION_INDEX = 5;

    [NativeTypeName("#define PAN_ARMSTYLE_INDEX 6")]
    public const int PAN_ARMSTYLE_INDEX = 6;

    [NativeTypeName("#define PAN_LETTERFORM_INDEX 7")]
    public const int PAN_LETTERFORM_INDEX = 7;

    [NativeTypeName("#define PAN_MIDLINE_INDEX 8")]
    public const int PAN_MIDLINE_INDEX = 8;

    [NativeTypeName("#define PAN_XHEIGHT_INDEX 9")]
    public const int PAN_XHEIGHT_INDEX = 9;

    [NativeTypeName("#define PAN_CULTURE_LATIN 0")]
    public const int PAN_CULTURE_LATIN = 0;

    [NativeTypeName("#define PAN_ANY 0")]
    public const int PAN_ANY = 0;

    [NativeTypeName("#define PAN_NO_FIT 1")]
    public const int PAN_NO_FIT = 1;

    [NativeTypeName("#define PAN_FAMILY_TEXT_DISPLAY 2")]
    public const int PAN_FAMILY_TEXT_DISPLAY = 2;

    [NativeTypeName("#define PAN_FAMILY_SCRIPT 3")]
    public const int PAN_FAMILY_SCRIPT = 3;

    [NativeTypeName("#define PAN_FAMILY_DECORATIVE 4")]
    public const int PAN_FAMILY_DECORATIVE = 4;

    [NativeTypeName("#define PAN_FAMILY_PICTORIAL 5")]
    public const int PAN_FAMILY_PICTORIAL = 5;

    [NativeTypeName("#define PAN_SERIF_COVE 2")]
    public const int PAN_SERIF_COVE = 2;

    [NativeTypeName("#define PAN_SERIF_OBTUSE_COVE 3")]
    public const int PAN_SERIF_OBTUSE_COVE = 3;

    [NativeTypeName("#define PAN_SERIF_SQUARE_COVE 4")]
    public const int PAN_SERIF_SQUARE_COVE = 4;

    [NativeTypeName("#define PAN_SERIF_OBTUSE_SQUARE_COVE 5")]
    public const int PAN_SERIF_OBTUSE_SQUARE_COVE = 5;

    [NativeTypeName("#define PAN_SERIF_SQUARE 6")]
    public const int PAN_SERIF_SQUARE = 6;

    [NativeTypeName("#define PAN_SERIF_THIN 7")]
    public const int PAN_SERIF_THIN = 7;

    [NativeTypeName("#define PAN_SERIF_BONE 8")]
    public const int PAN_SERIF_BONE = 8;

    [NativeTypeName("#define PAN_SERIF_EXAGGERATED 9")]
    public const int PAN_SERIF_EXAGGERATED = 9;

    [NativeTypeName("#define PAN_SERIF_TRIANGLE 10")]
    public const int PAN_SERIF_TRIANGLE = 10;

    [NativeTypeName("#define PAN_SERIF_NORMAL_SANS 11")]
    public const int PAN_SERIF_NORMAL_SANS = 11;

    [NativeTypeName("#define PAN_SERIF_OBTUSE_SANS 12")]
    public const int PAN_SERIF_OBTUSE_SANS = 12;

    [NativeTypeName("#define PAN_SERIF_PERP_SANS 13")]
    public const int PAN_SERIF_PERP_SANS = 13;

    [NativeTypeName("#define PAN_SERIF_FLARED 14")]
    public const int PAN_SERIF_FLARED = 14;

    [NativeTypeName("#define PAN_SERIF_ROUNDED 15")]
    public const int PAN_SERIF_ROUNDED = 15;

    [NativeTypeName("#define PAN_WEIGHT_VERY_LIGHT 2")]
    public const int PAN_WEIGHT_VERY_LIGHT = 2;

    [NativeTypeName("#define PAN_WEIGHT_LIGHT 3")]
    public const int PAN_WEIGHT_LIGHT = 3;

    [NativeTypeName("#define PAN_WEIGHT_THIN 4")]
    public const int PAN_WEIGHT_THIN = 4;

    [NativeTypeName("#define PAN_WEIGHT_BOOK 5")]
    public const int PAN_WEIGHT_BOOK = 5;

    [NativeTypeName("#define PAN_WEIGHT_MEDIUM 6")]
    public const int PAN_WEIGHT_MEDIUM = 6;

    [NativeTypeName("#define PAN_WEIGHT_DEMI 7")]
    public const int PAN_WEIGHT_DEMI = 7;

    [NativeTypeName("#define PAN_WEIGHT_BOLD 8")]
    public const int PAN_WEIGHT_BOLD = 8;

    [NativeTypeName("#define PAN_WEIGHT_HEAVY 9")]
    public const int PAN_WEIGHT_HEAVY = 9;

    [NativeTypeName("#define PAN_WEIGHT_BLACK 10")]
    public const int PAN_WEIGHT_BLACK = 10;

    [NativeTypeName("#define PAN_WEIGHT_NORD 11")]
    public const int PAN_WEIGHT_NORD = 11;

    [NativeTypeName("#define PAN_PROP_OLD_STYLE 2")]
    public const int PAN_PROP_OLD_STYLE = 2;

    [NativeTypeName("#define PAN_PROP_MODERN 3")]
    public const int PAN_PROP_MODERN = 3;

    [NativeTypeName("#define PAN_PROP_EVEN_WIDTH 4")]
    public const int PAN_PROP_EVEN_WIDTH = 4;

    [NativeTypeName("#define PAN_PROP_EXPANDED 5")]
    public const int PAN_PROP_EXPANDED = 5;

    [NativeTypeName("#define PAN_PROP_CONDENSED 6")]
    public const int PAN_PROP_CONDENSED = 6;

    [NativeTypeName("#define PAN_PROP_VERY_EXPANDED 7")]
    public const int PAN_PROP_VERY_EXPANDED = 7;

    [NativeTypeName("#define PAN_PROP_VERY_CONDENSED 8")]
    public const int PAN_PROP_VERY_CONDENSED = 8;

    [NativeTypeName("#define PAN_PROP_MONOSPACED 9")]
    public const int PAN_PROP_MONOSPACED = 9;

    [NativeTypeName("#define PAN_CONTRAST_NONE 2")]
    public const int PAN_CONTRAST_NONE = 2;

    [NativeTypeName("#define PAN_CONTRAST_VERY_LOW 3")]
    public const int PAN_CONTRAST_VERY_LOW = 3;

    [NativeTypeName("#define PAN_CONTRAST_LOW 4")]
    public const int PAN_CONTRAST_LOW = 4;

    [NativeTypeName("#define PAN_CONTRAST_MEDIUM_LOW 5")]
    public const int PAN_CONTRAST_MEDIUM_LOW = 5;

    [NativeTypeName("#define PAN_CONTRAST_MEDIUM 6")]
    public const int PAN_CONTRAST_MEDIUM = 6;

    [NativeTypeName("#define PAN_CONTRAST_MEDIUM_HIGH 7")]
    public const int PAN_CONTRAST_MEDIUM_HIGH = 7;

    [NativeTypeName("#define PAN_CONTRAST_HIGH 8")]
    public const int PAN_CONTRAST_HIGH = 8;

    [NativeTypeName("#define PAN_CONTRAST_VERY_HIGH 9")]
    public const int PAN_CONTRAST_VERY_HIGH = 9;

    [NativeTypeName("#define PAN_STROKE_GRADUAL_DIAG 2")]
    public const int PAN_STROKE_GRADUAL_DIAG = 2;

    [NativeTypeName("#define PAN_STROKE_GRADUAL_TRAN 3")]
    public const int PAN_STROKE_GRADUAL_TRAN = 3;

    [NativeTypeName("#define PAN_STROKE_GRADUAL_VERT 4")]
    public const int PAN_STROKE_GRADUAL_VERT = 4;

    [NativeTypeName("#define PAN_STROKE_GRADUAL_HORZ 5")]
    public const int PAN_STROKE_GRADUAL_HORZ = 5;

    [NativeTypeName("#define PAN_STROKE_RAPID_VERT 6")]
    public const int PAN_STROKE_RAPID_VERT = 6;

    [NativeTypeName("#define PAN_STROKE_RAPID_HORZ 7")]
    public const int PAN_STROKE_RAPID_HORZ = 7;

    [NativeTypeName("#define PAN_STROKE_INSTANT_VERT 8")]
    public const int PAN_STROKE_INSTANT_VERT = 8;

    [NativeTypeName("#define PAN_STRAIGHT_ARMS_HORZ 2")]
    public const int PAN_STRAIGHT_ARMS_HORZ = 2;

    [NativeTypeName("#define PAN_STRAIGHT_ARMS_WEDGE 3")]
    public const int PAN_STRAIGHT_ARMS_WEDGE = 3;

    [NativeTypeName("#define PAN_STRAIGHT_ARMS_VERT 4")]
    public const int PAN_STRAIGHT_ARMS_VERT = 4;

    [NativeTypeName("#define PAN_STRAIGHT_ARMS_SINGLE_SERIF 5")]
    public const int PAN_STRAIGHT_ARMS_SINGLE_SERIF = 5;

    [NativeTypeName("#define PAN_STRAIGHT_ARMS_DOUBLE_SERIF 6")]
    public const int PAN_STRAIGHT_ARMS_DOUBLE_SERIF = 6;

    [NativeTypeName("#define PAN_BENT_ARMS_HORZ 7")]
    public const int PAN_BENT_ARMS_HORZ = 7;

    [NativeTypeName("#define PAN_BENT_ARMS_WEDGE 8")]
    public const int PAN_BENT_ARMS_WEDGE = 8;

    [NativeTypeName("#define PAN_BENT_ARMS_VERT 9")]
    public const int PAN_BENT_ARMS_VERT = 9;

    [NativeTypeName("#define PAN_BENT_ARMS_SINGLE_SERIF 10")]
    public const int PAN_BENT_ARMS_SINGLE_SERIF = 10;

    [NativeTypeName("#define PAN_BENT_ARMS_DOUBLE_SERIF 11")]
    public const int PAN_BENT_ARMS_DOUBLE_SERIF = 11;

    [NativeTypeName("#define PAN_LETT_NORMAL_CONTACT 2")]
    public const int PAN_LETT_NORMAL_CONTACT = 2;

    [NativeTypeName("#define PAN_LETT_NORMAL_WEIGHTED 3")]
    public const int PAN_LETT_NORMAL_WEIGHTED = 3;

    [NativeTypeName("#define PAN_LETT_NORMAL_BOXED 4")]
    public const int PAN_LETT_NORMAL_BOXED = 4;

    [NativeTypeName("#define PAN_LETT_NORMAL_FLATTENED 5")]
    public const int PAN_LETT_NORMAL_FLATTENED = 5;

    [NativeTypeName("#define PAN_LETT_NORMAL_ROUNDED 6")]
    public const int PAN_LETT_NORMAL_ROUNDED = 6;

    [NativeTypeName("#define PAN_LETT_NORMAL_OFF_CENTER 7")]
    public const int PAN_LETT_NORMAL_OFF_CENTER = 7;

    [NativeTypeName("#define PAN_LETT_NORMAL_SQUARE 8")]
    public const int PAN_LETT_NORMAL_SQUARE = 8;

    [NativeTypeName("#define PAN_LETT_OBLIQUE_CONTACT 9")]
    public const int PAN_LETT_OBLIQUE_CONTACT = 9;

    [NativeTypeName("#define PAN_LETT_OBLIQUE_WEIGHTED 10")]
    public const int PAN_LETT_OBLIQUE_WEIGHTED = 10;

    [NativeTypeName("#define PAN_LETT_OBLIQUE_BOXED 11")]
    public const int PAN_LETT_OBLIQUE_BOXED = 11;

    [NativeTypeName("#define PAN_LETT_OBLIQUE_FLATTENED 12")]
    public const int PAN_LETT_OBLIQUE_FLATTENED = 12;

    [NativeTypeName("#define PAN_LETT_OBLIQUE_ROUNDED 13")]
    public const int PAN_LETT_OBLIQUE_ROUNDED = 13;

    [NativeTypeName("#define PAN_LETT_OBLIQUE_OFF_CENTER 14")]
    public const int PAN_LETT_OBLIQUE_OFF_CENTER = 14;

    [NativeTypeName("#define PAN_LETT_OBLIQUE_SQUARE 15")]
    public const int PAN_LETT_OBLIQUE_SQUARE = 15;

    [NativeTypeName("#define PAN_MIDLINE_STANDARD_TRIMMED 2")]
    public const int PAN_MIDLINE_STANDARD_TRIMMED = 2;

    [NativeTypeName("#define PAN_MIDLINE_STANDARD_POINTED 3")]
    public const int PAN_MIDLINE_STANDARD_POINTED = 3;

    [NativeTypeName("#define PAN_MIDLINE_STANDARD_SERIFED 4")]
    public const int PAN_MIDLINE_STANDARD_SERIFED = 4;

    [NativeTypeName("#define PAN_MIDLINE_HIGH_TRIMMED 5")]
    public const int PAN_MIDLINE_HIGH_TRIMMED = 5;

    [NativeTypeName("#define PAN_MIDLINE_HIGH_POINTED 6")]
    public const int PAN_MIDLINE_HIGH_POINTED = 6;

    [NativeTypeName("#define PAN_MIDLINE_HIGH_SERIFED 7")]
    public const int PAN_MIDLINE_HIGH_SERIFED = 7;

    [NativeTypeName("#define PAN_MIDLINE_CONSTANT_TRIMMED 8")]
    public const int PAN_MIDLINE_CONSTANT_TRIMMED = 8;

    [NativeTypeName("#define PAN_MIDLINE_CONSTANT_POINTED 9")]
    public const int PAN_MIDLINE_CONSTANT_POINTED = 9;

    [NativeTypeName("#define PAN_MIDLINE_CONSTANT_SERIFED 10")]
    public const int PAN_MIDLINE_CONSTANT_SERIFED = 10;

    [NativeTypeName("#define PAN_MIDLINE_LOW_TRIMMED 11")]
    public const int PAN_MIDLINE_LOW_TRIMMED = 11;

    [NativeTypeName("#define PAN_MIDLINE_LOW_POINTED 12")]
    public const int PAN_MIDLINE_LOW_POINTED = 12;

    [NativeTypeName("#define PAN_MIDLINE_LOW_SERIFED 13")]
    public const int PAN_MIDLINE_LOW_SERIFED = 13;

    [NativeTypeName("#define PAN_XHEIGHT_CONSTANT_SMALL 2")]
    public const int PAN_XHEIGHT_CONSTANT_SMALL = 2;

    [NativeTypeName("#define PAN_XHEIGHT_CONSTANT_STD 3")]
    public const int PAN_XHEIGHT_CONSTANT_STD = 3;

    [NativeTypeName("#define PAN_XHEIGHT_CONSTANT_LARGE 4")]
    public const int PAN_XHEIGHT_CONSTANT_LARGE = 4;

    [NativeTypeName("#define PAN_XHEIGHT_DUCKING_SMALL 5")]
    public const int PAN_XHEIGHT_DUCKING_SMALL = 5;

    [NativeTypeName("#define PAN_XHEIGHT_DUCKING_STD 6")]
    public const int PAN_XHEIGHT_DUCKING_STD = 6;

    [NativeTypeName("#define PAN_XHEIGHT_DUCKING_LARGE 7")]
    public const int PAN_XHEIGHT_DUCKING_LARGE = 7;
}
