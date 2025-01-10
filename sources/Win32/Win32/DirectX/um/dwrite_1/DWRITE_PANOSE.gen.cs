// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Explicit)]
public partial struct DWRITE_PANOSE
{
    [FieldOffset(0)]
    [NativeTypeName("UINT8[10]")]
    public _values_e__FixedBuffer values;

    [FieldOffset(0)]
    [NativeTypeName("UINT8")]
    public byte familyKind;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_dwrite_1_L758_C5")]
    public _text_e__Struct text;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_dwrite_1_L772_C5")]
    public _script_e__Struct script;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_dwrite_1_L786_C5")]
    public _decorative_e__Struct decorative;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_dwrite_1_L800_C5")]
    public _symbol_e__Struct symbol;

    public partial struct _text_e__Struct
    {
        [NativeTypeName("UINT8")]
        public byte familyKind;

        [NativeTypeName("UINT8")]
        public byte serifStyle;

        [NativeTypeName("UINT8")]
        public byte weight;

        [NativeTypeName("UINT8")]
        public byte proportion;

        [NativeTypeName("UINT8")]
        public byte contrast;

        [NativeTypeName("UINT8")]
        public byte strokeVariation;

        [NativeTypeName("UINT8")]
        public byte armStyle;

        [NativeTypeName("UINT8")]
        public byte letterform;

        [NativeTypeName("UINT8")]
        public byte midline;

        [NativeTypeName("UINT8")]
        public byte xHeight;
    }

    public partial struct _script_e__Struct
    {
        [NativeTypeName("UINT8")]
        public byte familyKind;

        [NativeTypeName("UINT8")]
        public byte toolKind;

        [NativeTypeName("UINT8")]
        public byte weight;

        [NativeTypeName("UINT8")]
        public byte spacing;

        [NativeTypeName("UINT8")]
        public byte aspectRatio;

        [NativeTypeName("UINT8")]
        public byte contrast;

        [NativeTypeName("UINT8")]
        public byte scriptTopology;

        [NativeTypeName("UINT8")]
        public byte scriptForm;

        [NativeTypeName("UINT8")]
        public byte finials;

        [NativeTypeName("UINT8")]
        public byte xAscent;
    }

    public partial struct _decorative_e__Struct
    {
        [NativeTypeName("UINT8")]
        public byte familyKind;

        [NativeTypeName("UINT8")]
        public byte decorativeClass;

        [NativeTypeName("UINT8")]
        public byte weight;

        [NativeTypeName("UINT8")]
        public byte aspect;

        [NativeTypeName("UINT8")]
        public byte contrast;

        [NativeTypeName("UINT8")]
        public byte serifVariant;

        [NativeTypeName("UINT8")]
        public byte fill;

        [NativeTypeName("UINT8")]
        public byte lining;

        [NativeTypeName("UINT8")]
        public byte decorativeTopology;

        [NativeTypeName("UINT8")]
        public byte characterRange;
    }

    public partial struct _symbol_e__Struct
    {
        [NativeTypeName("UINT8")]
        public byte familyKind;

        [NativeTypeName("UINT8")]
        public byte symbolKind;

        [NativeTypeName("UINT8")]
        public byte weight;

        [NativeTypeName("UINT8")]
        public byte spacing;

        [NativeTypeName("UINT8")]
        public byte aspectRatioAndContrast;

        [NativeTypeName("UINT8")]
        public byte aspectRatio94;

        [NativeTypeName("UINT8")]
        public byte aspectRatio119;

        [NativeTypeName("UINT8")]
        public byte aspectRatio157;

        [NativeTypeName("UINT8")]
        public byte aspectRatio163;

        [NativeTypeName("UINT8")]
        public byte aspectRatio211;
    }

    [InlineArray(10)]
    public partial struct _values_e__FixedBuffer
    {
        public byte e0;
    }
}
