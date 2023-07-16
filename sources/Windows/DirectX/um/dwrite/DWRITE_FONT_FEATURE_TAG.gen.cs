// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG"]/*'/>
[NativeTypeName("int")]
public enum DWRITE_FONT_FEATURE_TAG : uint
{
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_ALTERNATIVE_FRACTIONS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_ALTERNATIVE_FRACTIONS = (unchecked(((uint)((byte)('c')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('f')) << 8) | (uint)((byte)('a')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS_FROM_CAPITALS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS_FROM_CAPITALS = (unchecked(((uint)((byte)('c')) << 24) | ((uint)((byte)('p')) << 16) | ((uint)((byte)('2')) << 8) | (uint)((byte)('c')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS_FROM_CAPITALS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS_FROM_CAPITALS = (unchecked(((uint)((byte)('c')) << 24) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('2')) << 8) | (uint)((byte)('c')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_ALTERNATES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_ALTERNATES = (unchecked(((uint)((byte)('t')) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('c')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_CASE_SENSITIVE_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_CASE_SENSITIVE_FORMS = (unchecked(((uint)((byte)('e')) << 24) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('c')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_GLYPH_COMPOSITION_DECOMPOSITION"]/*'/>
    DWRITE_FONT_FEATURE_TAG_GLYPH_COMPOSITION_DECOMPOSITION = (unchecked(((uint)((byte)('p')) << 24) | ((uint)((byte)('m')) << 16) | ((uint)((byte)('c')) << 8) | (uint)((byte)('c')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_LIGATURES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_LIGATURES = (unchecked(((uint)((byte)('g')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('l')) << 8) | (uint)((byte)('c')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_CAPITAL_SPACING"]/*'/>
    DWRITE_FONT_FEATURE_TAG_CAPITAL_SPACING = (unchecked(((uint)((byte)('p')) << 24) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('c')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_SWASH"]/*'/>
    DWRITE_FONT_FEATURE_TAG_CONTEXTUAL_SWASH = (unchecked(((uint)((byte)('h')) << 24) | ((uint)((byte)('w')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('c')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_CURSIVE_POSITIONING"]/*'/>
    DWRITE_FONT_FEATURE_TAG_CURSIVE_POSITIONING = (unchecked(((uint)((byte)('s')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('u')) << 8) | (uint)((byte)('c')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_DEFAULT"]/*'/>
    DWRITE_FONT_FEATURE_TAG_DEFAULT = (unchecked(((uint)((byte)('t')) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('f')) << 8) | (uint)((byte)('d')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_DISCRETIONARY_LIGATURES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_DISCRETIONARY_LIGATURES = (unchecked(((uint)((byte)('g')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('l')) << 8) | (uint)((byte)('d')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_EXPERT_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_EXPERT_FORMS = (unchecked(((uint)((byte)('t')) << 24) | ((uint)((byte)('p')) << 16) | ((uint)((byte)('x')) << 8) | (uint)((byte)('e')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_FRACTIONS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_FRACTIONS = (unchecked(((uint)((byte)('c')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('r')) << 8) | (uint)((byte)('f')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_FULL_WIDTH"]/*'/>
    DWRITE_FONT_FEATURE_TAG_FULL_WIDTH = (unchecked(((uint)((byte)('d')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('w')) << 8) | (uint)((byte)('f')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_HALF_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_HALF_FORMS = (unchecked(((uint)((byte)('f')) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('h')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_HALANT_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_HALANT_FORMS = (unchecked(((uint)((byte)('n')) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('h')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_ALTERNATE_HALF_WIDTH"]/*'/>
    DWRITE_FONT_FEATURE_TAG_ALTERNATE_HALF_WIDTH = (unchecked(((uint)((byte)('t')) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('h')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_HISTORICAL_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_HISTORICAL_FORMS = (unchecked(((uint)((byte)('t')) << 24) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('i')) << 8) | (uint)((byte)('h')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_HORIZONTAL_KANA_ALTERNATES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_HORIZONTAL_KANA_ALTERNATES = (unchecked(((uint)((byte)('a')) << 24) | ((uint)((byte)('n')) << 16) | ((uint)((byte)('k')) << 8) | (uint)((byte)('h')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_HISTORICAL_LIGATURES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_HISTORICAL_LIGATURES = (unchecked(((uint)((byte)('g')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('l')) << 8) | (uint)((byte)('h')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_HALF_WIDTH"]/*'/>
    DWRITE_FONT_FEATURE_TAG_HALF_WIDTH = (unchecked(((uint)((byte)('d')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('w')) << 8) | (uint)((byte)('h')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_HOJO_KANJI_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_HOJO_KANJI_FORMS = (unchecked(((uint)((byte)('o')) << 24) | ((uint)((byte)('j')) << 16) | ((uint)((byte)('o')) << 8) | (uint)((byte)('h')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_JIS04_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_JIS04_FORMS = (unchecked(((uint)((byte)('4')) << 24) | ((uint)((byte)('0')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('j')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_JIS78_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_JIS78_FORMS = (unchecked(((uint)((byte)('8')) << 24) | ((uint)((byte)('7')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('j')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_JIS83_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_JIS83_FORMS = (unchecked(((uint)((byte)('3')) << 24) | ((uint)((byte)('8')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('j')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_JIS90_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_JIS90_FORMS = (unchecked(((uint)((byte)('0')) << 24) | ((uint)((byte)('9')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('j')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_KERNING"]/*'/>
    DWRITE_FONT_FEATURE_TAG_KERNING = (unchecked(((uint)((byte)('n')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('e')) << 8) | (uint)((byte)('k')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STANDARD_LIGATURES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STANDARD_LIGATURES = (unchecked(((uint)((byte)('a')) << 24) | ((uint)((byte)('g')) << 16) | ((uint)((byte)('i')) << 8) | (uint)((byte)('l')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_LINING_FIGURES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_LINING_FIGURES = (unchecked(((uint)((byte)('m')) << 24) | ((uint)((byte)('u')) << 16) | ((uint)((byte)('n')) << 8) | (uint)((byte)('l')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_LOCALIZED_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_LOCALIZED_FORMS = (unchecked(((uint)((byte)('l')) << 24) | ((uint)((byte)('c')) << 16) | ((uint)((byte)('o')) << 8) | (uint)((byte)('l')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_MARK_POSITIONING"]/*'/>
    DWRITE_FONT_FEATURE_TAG_MARK_POSITIONING = (unchecked(((uint)((byte)('k')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('m')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_MATHEMATICAL_GREEK"]/*'/>
    DWRITE_FONT_FEATURE_TAG_MATHEMATICAL_GREEK = (unchecked(((uint)((byte)('k')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('g')) << 8) | (uint)((byte)('m')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_MARK_TO_MARK_POSITIONING"]/*'/>
    DWRITE_FONT_FEATURE_TAG_MARK_TO_MARK_POSITIONING = (unchecked(((uint)((byte)('k')) << 24) | ((uint)((byte)('m')) << 16) | ((uint)((byte)('k')) << 8) | (uint)((byte)('m')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_ALTERNATE_ANNOTATION_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_ALTERNATE_ANNOTATION_FORMS = (unchecked(((uint)((byte)('t')) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('n')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_NLC_KANJI_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_NLC_KANJI_FORMS = (unchecked(((uint)((byte)('k')) << 24) | ((uint)((byte)('c')) << 16) | ((uint)((byte)('l')) << 8) | (uint)((byte)('n')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_OLD_STYLE_FIGURES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_OLD_STYLE_FIGURES = (unchecked(((uint)((byte)('m')) << 24) | ((uint)((byte)('u')) << 16) | ((uint)((byte)('n')) << 8) | (uint)((byte)('o')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_ORDINALS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_ORDINALS = (unchecked(((uint)((byte)('n')) << 24) | ((uint)((byte)('d')) << 16) | ((uint)((byte)('r')) << 8) | (uint)((byte)('o')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_ALTERNATE_WIDTH"]/*'/>
    DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_ALTERNATE_WIDTH = (unchecked(((uint)((byte)('t')) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('p')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_PETITE_CAPITALS = (unchecked(((uint)((byte)('p')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('c')) << 8) | (uint)((byte)('p')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_FIGURES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_FIGURES = (unchecked(((uint)((byte)('m')) << 24) | ((uint)((byte)('u')) << 16) | ((uint)((byte)('n')) << 8) | (uint)((byte)('p')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_WIDTHS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_PROPORTIONAL_WIDTHS = (unchecked(((uint)((byte)('d')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('w')) << 8) | (uint)((byte)('p')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_QUARTER_WIDTHS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_QUARTER_WIDTHS = (unchecked(((uint)((byte)('d')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('w')) << 8) | (uint)((byte)('q')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_REQUIRED_LIGATURES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_REQUIRED_LIGATURES = (unchecked(((uint)((byte)('g')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('l')) << 8) | (uint)((byte)('r')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_RUBY_NOTATION_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_RUBY_NOTATION_FORMS = (unchecked(((uint)((byte)('y')) << 24) | ((uint)((byte)('b')) << 16) | ((uint)((byte)('u')) << 8) | (uint)((byte)('r')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_ALTERNATES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_ALTERNATES = (unchecked(((uint)((byte)('t')) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('a')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_SCIENTIFIC_INFERIORS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_SCIENTIFIC_INFERIORS = (unchecked(((uint)((byte)('f')) << 24) | ((uint)((byte)('n')) << 16) | ((uint)((byte)('i')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_SMALL_CAPITALS = (unchecked(((uint)((byte)('p')) << 24) | ((uint)((byte)('c')) << 16) | ((uint)((byte)('m')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_SIMPLIFIED_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_SIMPLIFIED_FORMS = (unchecked(((uint)((byte)('l')) << 24) | ((uint)((byte)('p')) << 16) | ((uint)((byte)('m')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_1"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_1 = (unchecked(((uint)((byte)('1')) << 24) | ((uint)((byte)('0')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_2"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_2 = (unchecked(((uint)((byte)('2')) << 24) | ((uint)((byte)('0')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_3"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_3 = (unchecked(((uint)((byte)('3')) << 24) | ((uint)((byte)('0')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_4"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_4 = (unchecked(((uint)((byte)('4')) << 24) | ((uint)((byte)('0')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_5"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_5 = (unchecked(((uint)((byte)('5')) << 24) | ((uint)((byte)('0')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_6"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_6 = (unchecked(((uint)((byte)('6')) << 24) | ((uint)((byte)('0')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_7"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_7 = (unchecked(((uint)((byte)('7')) << 24) | ((uint)((byte)('0')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_8"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_8 = (unchecked(((uint)((byte)('8')) << 24) | ((uint)((byte)('0')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_9"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_9 = (unchecked(((uint)((byte)('9')) << 24) | ((uint)((byte)('0')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_10"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_10 = (unchecked(((uint)((byte)('0')) << 24) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_11"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_11 = (unchecked(((uint)((byte)('1')) << 24) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_12"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_12 = (unchecked(((uint)((byte)('2')) << 24) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_13"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_13 = (unchecked(((uint)((byte)('3')) << 24) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_14"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_14 = (unchecked(((uint)((byte)('4')) << 24) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_15"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_15 = (unchecked(((uint)((byte)('5')) << 24) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_16"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_16 = (unchecked(((uint)((byte)('6')) << 24) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_17"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_17 = (unchecked(((uint)((byte)('7')) << 24) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_18"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_18 = (unchecked(((uint)((byte)('8')) << 24) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_19"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_19 = (unchecked(((uint)((byte)('9')) << 24) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_20"]/*'/>
    DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_20 = (unchecked(((uint)((byte)('0')) << 24) | ((uint)((byte)('2')) << 16) | ((uint)((byte)('s')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_SUBSCRIPT"]/*'/>
    DWRITE_FONT_FEATURE_TAG_SUBSCRIPT = (unchecked(((uint)((byte)('s')) << 24) | ((uint)((byte)('b')) << 16) | ((uint)((byte)('u')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_SUPERSCRIPT"]/*'/>
    DWRITE_FONT_FEATURE_TAG_SUPERSCRIPT = (unchecked(((uint)((byte)('s')) << 24) | ((uint)((byte)('p')) << 16) | ((uint)((byte)('u')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_SWASH"]/*'/>
    DWRITE_FONT_FEATURE_TAG_SWASH = (unchecked(((uint)((byte)('h')) << 24) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('w')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_TITLING"]/*'/>
    DWRITE_FONT_FEATURE_TAG_TITLING = (unchecked(((uint)((byte)('l')) << 24) | ((uint)((byte)('t')) << 16) | ((uint)((byte)('i')) << 8) | (uint)((byte)('t')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_TRADITIONAL_NAME_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_TRADITIONAL_NAME_FORMS = (unchecked(((uint)((byte)('m')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('n')) << 8) | (uint)((byte)('t')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_TABULAR_FIGURES"]/*'/>
    DWRITE_FONT_FEATURE_TAG_TABULAR_FIGURES = (unchecked(((uint)((byte)('m')) << 24) | ((uint)((byte)('u')) << 16) | ((uint)((byte)('n')) << 8) | (uint)((byte)('t')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_TRADITIONAL_FORMS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_TRADITIONAL_FORMS = (unchecked(((uint)((byte)('d')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('r')) << 8) | (uint)((byte)('t')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_THIRD_WIDTHS"]/*'/>
    DWRITE_FONT_FEATURE_TAG_THIRD_WIDTHS = (unchecked(((uint)((byte)('d')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('w')) << 8) | (uint)((byte)('t')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_UNICASE"]/*'/>
    DWRITE_FONT_FEATURE_TAG_UNICASE = (unchecked(((uint)((byte)('c')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('n')) << 8) | (uint)((byte)('u')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_VERTICAL_WRITING"]/*'/>
    DWRITE_FONT_FEATURE_TAG_VERTICAL_WRITING = (unchecked(((uint)((byte)('t')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('e')) << 8) | (uint)((byte)('v')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_VERTICAL_ALTERNATES_AND_ROTATION"]/*'/>
    DWRITE_FONT_FEATURE_TAG_VERTICAL_ALTERNATES_AND_ROTATION = (unchecked(((uint)((byte)('2')) << 24) | ((uint)((byte)('t')) << 16) | ((uint)((byte)('r')) << 8) | (uint)((byte)('v')))),
    /// <include file='DWRITE_FONT_FEATURE_TAG.xml' path='doc/member[@name="DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_SLASHED_ZERO"]/*'/>
    DWRITE_FONT_FEATURE_TAG_SLASHED_ZERO = (unchecked(((uint)((byte)('o')) << 24) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('e')) << 8) | (uint)((byte)('z')))),
}