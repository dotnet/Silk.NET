// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='DWRITE_PANOSE.xml' path='doc/member[@name="DWRITE_PANOSE"]/*' />
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct DWRITE_PANOSE
{
    /// <include file='DWRITE_PANOSE.xml' path='doc/member[@name="DWRITE_PANOSE.values"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("UINT8[10]")]
    public fixed byte values[10];

    /// <include file='DWRITE_PANOSE.xml' path='doc/member[@name="DWRITE_PANOSE.familyKind"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("UINT8")]
    public byte familyKind;

    /// <include file='DWRITE_PANOSE.xml' path='doc/member[@name="DWRITE_PANOSE.text"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_dwrite_1_L758_C5")]
    public _text_e__Struct text;

    /// <include file='DWRITE_PANOSE.xml' path='doc/member[@name="DWRITE_PANOSE.script"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_dwrite_1_L772_C5")]
    public _script_e__Struct script;

    /// <include file='DWRITE_PANOSE.xml' path='doc/member[@name="DWRITE_PANOSE.decorative"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_dwrite_1_L786_C5")]
    public _decorative_e__Struct decorative;

    /// <include file='DWRITE_PANOSE.xml' path='doc/member[@name="DWRITE_PANOSE.symbol"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_dwrite_1_L800_C5")]
    public _symbol_e__Struct symbol;

    /// <include file='_text_e__Struct.xml' path='doc/member[@name="_text_e__Struct"]/*' />
    public partial struct _text_e__Struct
    {
        /// <include file='_text_e__Struct.xml' path='doc/member[@name="_text_e__Struct.familyKind"]/*' />
        [NativeTypeName("UINT8")]
        public byte familyKind;

        /// <include file='_text_e__Struct.xml' path='doc/member[@name="_text_e__Struct.serifStyle"]/*' />
        [NativeTypeName("UINT8")]
        public byte serifStyle;

        /// <include file='_text_e__Struct.xml' path='doc/member[@name="_text_e__Struct.weight"]/*' />
        [NativeTypeName("UINT8")]
        public byte weight;

        /// <include file='_text_e__Struct.xml' path='doc/member[@name="_text_e__Struct.proportion"]/*' />
        [NativeTypeName("UINT8")]
        public byte proportion;

        /// <include file='_text_e__Struct.xml' path='doc/member[@name="_text_e__Struct.contrast"]/*' />
        [NativeTypeName("UINT8")]
        public byte contrast;

        /// <include file='_text_e__Struct.xml' path='doc/member[@name="_text_e__Struct.strokeVariation"]/*' />
        [NativeTypeName("UINT8")]
        public byte strokeVariation;

        /// <include file='_text_e__Struct.xml' path='doc/member[@name="_text_e__Struct.armStyle"]/*' />
        [NativeTypeName("UINT8")]
        public byte armStyle;

        /// <include file='_text_e__Struct.xml' path='doc/member[@name="_text_e__Struct.letterform"]/*' />
        [NativeTypeName("UINT8")]
        public byte letterform;

        /// <include file='_text_e__Struct.xml' path='doc/member[@name="_text_e__Struct.midline"]/*' />
        [NativeTypeName("UINT8")]
        public byte midline;

        /// <include file='_text_e__Struct.xml' path='doc/member[@name="_text_e__Struct.xHeight"]/*' />
        [NativeTypeName("UINT8")]
        public byte xHeight;
    }

    /// <include file='_script_e__Struct.xml' path='doc/member[@name="_script_e__Struct"]/*' />
    public partial struct _script_e__Struct
    {
        /// <include file='_script_e__Struct.xml' path='doc/member[@name="_script_e__Struct.familyKind"]/*' />
        [NativeTypeName("UINT8")]
        public byte familyKind;

        /// <include file='_script_e__Struct.xml' path='doc/member[@name="_script_e__Struct.toolKind"]/*' />
        [NativeTypeName("UINT8")]
        public byte toolKind;

        /// <include file='_script_e__Struct.xml' path='doc/member[@name="_script_e__Struct.weight"]/*' />
        [NativeTypeName("UINT8")]
        public byte weight;

        /// <include file='_script_e__Struct.xml' path='doc/member[@name="_script_e__Struct.spacing"]/*' />
        [NativeTypeName("UINT8")]
        public byte spacing;

        /// <include file='_script_e__Struct.xml' path='doc/member[@name="_script_e__Struct.aspectRatio"]/*' />
        [NativeTypeName("UINT8")]
        public byte aspectRatio;

        /// <include file='_script_e__Struct.xml' path='doc/member[@name="_script_e__Struct.contrast"]/*' />
        [NativeTypeName("UINT8")]
        public byte contrast;

        /// <include file='_script_e__Struct.xml' path='doc/member[@name="_script_e__Struct.scriptTopology"]/*' />
        [NativeTypeName("UINT8")]
        public byte scriptTopology;

        /// <include file='_script_e__Struct.xml' path='doc/member[@name="_script_e__Struct.scriptForm"]/*' />
        [NativeTypeName("UINT8")]
        public byte scriptForm;

        /// <include file='_script_e__Struct.xml' path='doc/member[@name="_script_e__Struct.finials"]/*' />
        [NativeTypeName("UINT8")]
        public byte finials;

        /// <include file='_script_e__Struct.xml' path='doc/member[@name="_script_e__Struct.xAscent"]/*' />
        [NativeTypeName("UINT8")]
        public byte xAscent;
    }

    /// <include file='_decorative_e__Struct.xml' path='doc/member[@name="_decorative_e__Struct"]/*' />
    public partial struct _decorative_e__Struct
    {
        /// <include file='_decorative_e__Struct.xml' path='doc/member[@name="_decorative_e__Struct.familyKind"]/*' />
        [NativeTypeName("UINT8")]
        public byte familyKind;

        /// <include file='_decorative_e__Struct.xml' path='doc/member[@name="_decorative_e__Struct.decorativeClass"]/*' />
        [NativeTypeName("UINT8")]
        public byte decorativeClass;

        /// <include file='_decorative_e__Struct.xml' path='doc/member[@name="_decorative_e__Struct.weight"]/*' />
        [NativeTypeName("UINT8")]
        public byte weight;

        /// <include file='_decorative_e__Struct.xml' path='doc/member[@name="_decorative_e__Struct.aspect"]/*' />
        [NativeTypeName("UINT8")]
        public byte aspect;

        /// <include file='_decorative_e__Struct.xml' path='doc/member[@name="_decorative_e__Struct.contrast"]/*' />
        [NativeTypeName("UINT8")]
        public byte contrast;

        /// <include file='_decorative_e__Struct.xml' path='doc/member[@name="_decorative_e__Struct.serifVariant"]/*' />
        [NativeTypeName("UINT8")]
        public byte serifVariant;

        /// <include file='_decorative_e__Struct.xml' path='doc/member[@name="_decorative_e__Struct.fill"]/*' />
        [NativeTypeName("UINT8")]
        public byte fill;

        /// <include file='_decorative_e__Struct.xml' path='doc/member[@name="_decorative_e__Struct.lining"]/*' />
        [NativeTypeName("UINT8")]
        public byte lining;

        /// <include file='_decorative_e__Struct.xml' path='doc/member[@name="_decorative_e__Struct.decorativeTopology"]/*' />
        [NativeTypeName("UINT8")]
        public byte decorativeTopology;

        /// <include file='_decorative_e__Struct.xml' path='doc/member[@name="_decorative_e__Struct.characterRange"]/*' />
        [NativeTypeName("UINT8")]
        public byte characterRange;
    }

    /// <include file='_symbol_e__Struct.xml' path='doc/member[@name="_symbol_e__Struct"]/*' />
    public partial struct _symbol_e__Struct
    {
        /// <include file='_symbol_e__Struct.xml' path='doc/member[@name="_symbol_e__Struct.familyKind"]/*' />
        [NativeTypeName("UINT8")]
        public byte familyKind;

        /// <include file='_symbol_e__Struct.xml' path='doc/member[@name="_symbol_e__Struct.symbolKind"]/*' />
        [NativeTypeName("UINT8")]
        public byte symbolKind;

        /// <include file='_symbol_e__Struct.xml' path='doc/member[@name="_symbol_e__Struct.weight"]/*' />
        [NativeTypeName("UINT8")]
        public byte weight;

        /// <include file='_symbol_e__Struct.xml' path='doc/member[@name="_symbol_e__Struct.spacing"]/*' />
        [NativeTypeName("UINT8")]
        public byte spacing;

        /// <include file='_symbol_e__Struct.xml' path='doc/member[@name="_symbol_e__Struct.aspectRatioAndContrast"]/*' />
        [NativeTypeName("UINT8")]
        public byte aspectRatioAndContrast;

        /// <include file='_symbol_e__Struct.xml' path='doc/member[@name="_symbol_e__Struct.aspectRatio94"]/*' />
        [NativeTypeName("UINT8")]
        public byte aspectRatio94;

        /// <include file='_symbol_e__Struct.xml' path='doc/member[@name="_symbol_e__Struct.aspectRatio119"]/*' />
        [NativeTypeName("UINT8")]
        public byte aspectRatio119;

        /// <include file='_symbol_e__Struct.xml' path='doc/member[@name="_symbol_e__Struct.aspectRatio157"]/*' />
        [NativeTypeName("UINT8")]
        public byte aspectRatio157;

        /// <include file='_symbol_e__Struct.xml' path='doc/member[@name="_symbol_e__Struct.aspectRatio163"]/*' />
        [NativeTypeName("UINT8")]
        public byte aspectRatio163;

        /// <include file='_symbol_e__Struct.xml' path='doc/member[@name="_symbol_e__Struct.aspectRatio211"]/*' />
        [NativeTypeName("UINT8")]
        public byte aspectRatio211;
    }
}
