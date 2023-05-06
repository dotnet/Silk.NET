// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FONT_FEATURE_TAG")]
    public enum FontFeatureTag : int
    {
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_ALTERNATIVE_FRACTIONS")]
        AlternativeFractions = 0x63726661,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS_FROM_CAPITALS")]
        PetiteCapitalsFromCapitals = 0x63703263,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS_FROM_CAPITALS")]
        SmallCapitalsFromCapitals = 0x63733263,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_ALTERNATES")]
        ContextualAlternates = 0x746C6163,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_CASE_SENSITIVE_FORMS")]
        CaseSensitiveForms = 0x65736163,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_GLYPH_COMPOSITION_DECOMPOSITION")]
        GlyphCompositionDecomposition = 0x706D6363,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_LIGATURES")]
        ContextualLigatures = 0x67696C63,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_CAPITAL_SPACING")]
        CapitalSpacing = 0x70737063,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_SWASH")]
        ContextualSwash = 0x68777363,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_CURSIVE_POSITIONING")]
        CursivePositioning = 0x73727563,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_DEFAULT")]
        Default = 0x746C6664,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_DISCRETIONARY_LIGATURES")]
        DiscretionaryLigatures = 0x67696C64,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_EXPERT_FORMS")]
        ExpertForms = 0x74707865,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_FRACTIONS")]
        Fractions = 0x63617266,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_FULL_WIDTH")]
        FullWidth = 0x64697766,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_HALF_FORMS")]
        HalfForms = 0x666C6168,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_HALANT_FORMS")]
        HalantForms = 0x6E6C6168,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_ALTERNATE_HALF_WIDTH")]
        AlternateHalfWidth = 0x746C6168,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_HISTORICAL_FORMS")]
        HistoricalForms = 0x74736968,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_HORIZONTAL_KANA_ALTERNATES")]
        HorizontalKanaAlternates = 0x616E6B68,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_HISTORICAL_LIGATURES")]
        HistoricalLigatures = 0x67696C68,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_HALF_WIDTH")]
        HalfWidth = 0x64697768,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_HOJO_KANJI_FORMS")]
        HojoKanjiForms = 0x6F6A6F68,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_JIS04_FORMS")]
        Jis04Forms = 0x3430706A,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_JIS78_FORMS")]
        Jis78Forms = 0x3837706A,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_JIS83_FORMS")]
        Jis83Forms = 0x3338706A,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_JIS90_FORMS")]
        Jis90Forms = 0x3039706A,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_KERNING")]
        Kerning = 0x6E72656B,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STANDARD_LIGATURES")]
        StandardLigatures = 0x6167696C,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_LINING_FIGURES")]
        LiningFigures = 0x6D756E6C,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_LOCALIZED_FORMS")]
        LocalizedForms = 0x6C636F6C,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_MARK_POSITIONING")]
        MarkPositioning = 0x6B72616D,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_MATHEMATICAL_GREEK")]
        MathematicalGreek = 0x6B72676D,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_MARK_TO_MARK_POSITIONING")]
        MarkToMarkPositioning = 0x6B6D6B6D,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_ALTERNATE_ANNOTATION_FORMS")]
        AlternateAnnotationForms = 0x746C616E,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_NLC_KANJI_FORMS")]
        NlcKanjiForms = 0x6B636C6E,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_OLD_STYLE_FIGURES")]
        OldStyleFigures = 0x6D756E6F,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_ORDINALS")]
        Ordinals = 0x6E64726F,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_ALTERNATE_WIDTH")]
        ProportionalAlternateWidth = 0x746C6170,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS")]
        PetiteCapitals = 0x70616370,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_FIGURES")]
        ProportionalFigures = 0x6D756E70,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_WIDTHS")]
        ProportionalWidths = 0x64697770,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_QUARTER_WIDTHS")]
        QuarterWidths = 0x64697771,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_REQUIRED_LIGATURES")]
        RequiredLigatures = 0x67696C72,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_RUBY_NOTATION_FORMS")]
        RubyNotationForms = 0x79627572,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_ALTERNATES")]
        StylisticAlternates = 0x746C6173,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_SCIENTIFIC_INFERIORS")]
        ScientificInferiors = 0x666E6973,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS")]
        SmallCapitals = 0x70636D73,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_SIMPLIFIED_FORMS")]
        SimplifiedForms = 0x6C706D73,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_1")]
        StylisticSet1 = 0x31307373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_2")]
        StylisticSet2 = 0x32307373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_3")]
        StylisticSet3 = 0x33307373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_4")]
        StylisticSet4 = 0x34307373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_5")]
        StylisticSet5 = 0x35307373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_6")]
        StylisticSet6 = 0x36307373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_7")]
        StylisticSet7 = 0x37307373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_8")]
        StylisticSet8 = 0x38307373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_9")]
        StylisticSet9 = 0x39307373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_10")]
        StylisticSet10 = 0x30317373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_11")]
        StylisticSet11 = 0x31317373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_12")]
        StylisticSet12 = 0x32317373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_13")]
        StylisticSet13 = 0x33317373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_14")]
        StylisticSet14 = 0x34317373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_15")]
        StylisticSet15 = 0x35317373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_16")]
        StylisticSet16 = 0x36317373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_17")]
        StylisticSet17 = 0x37317373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_18")]
        StylisticSet18 = 0x38317373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_19")]
        StylisticSet19 = 0x39317373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_20")]
        StylisticSet20 = 0x30327373,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_SUBSCRIPT")]
        Subscript = 0x73627573,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_SUPERSCRIPT")]
        Superscript = 0x73707573,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_SWASH")]
        Swash = 0x68737773,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_TITLING")]
        Titling = 0x6C746974,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_TRADITIONAL_NAME_FORMS")]
        TraditionalNameForms = 0x6D616E74,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_TABULAR_FIGURES")]
        TabularFigures = 0x6D756E74,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_TRADITIONAL_FORMS")]
        TraditionalForms = 0x64617274,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_THIRD_WIDTHS")]
        ThirdWidths = 0x64697774,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_UNICASE")]
        Unicase = 0x63696E75,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_VERTICAL_WRITING")]
        VerticalWriting = 0x74726576,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_VERTICAL_ALTERNATES_AND_ROTATION")]
        VerticalAlternatesAndRotation = 0x32747276,
        [NativeName("Name", "DWRITE_FONT_FEATURE_TAG_SLASHED_ZERO")]
        SlashedZero = 0x6F72657A,
    }
}
