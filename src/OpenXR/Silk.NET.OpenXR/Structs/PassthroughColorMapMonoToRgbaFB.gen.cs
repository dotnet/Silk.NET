// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPassthroughColorMapMonoToRgbaFB")]
    public unsafe partial struct PassthroughColorMapMonoToRgbaFB
    {
        public PassthroughColorMapMonoToRgbaFB
        (
            StructureType? type = StructureType.TypePassthroughColorMapMonoToRgbaFB,
            void* next = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
        /// <summary></summary>
        [NativeName("Type", "XrColor4f")]
        [NativeName("Type.Name", "XrColor4f")]
        [NativeName("Name", "textureColorMap")]
        public TextureColorMapBuffer TextureColorMap;

        public struct TextureColorMapBuffer
        {
            public Color4f Element0;
            public Color4f Element1;
            public Color4f Element2;
            public Color4f Element3;
            public Color4f Element4;
            public Color4f Element5;
            public Color4f Element6;
            public Color4f Element7;
            public Color4f Element8;
            public Color4f Element9;
            public Color4f Element10;
            public Color4f Element11;
            public Color4f Element12;
            public Color4f Element13;
            public Color4f Element14;
            public Color4f Element15;
            public Color4f Element16;
            public Color4f Element17;
            public Color4f Element18;
            public Color4f Element19;
            public Color4f Element20;
            public Color4f Element21;
            public Color4f Element22;
            public Color4f Element23;
            public Color4f Element24;
            public Color4f Element25;
            public Color4f Element26;
            public Color4f Element27;
            public Color4f Element28;
            public Color4f Element29;
            public Color4f Element30;
            public Color4f Element31;
            public Color4f Element32;
            public Color4f Element33;
            public Color4f Element34;
            public Color4f Element35;
            public Color4f Element36;
            public Color4f Element37;
            public Color4f Element38;
            public Color4f Element39;
            public Color4f Element40;
            public Color4f Element41;
            public Color4f Element42;
            public Color4f Element43;
            public Color4f Element44;
            public Color4f Element45;
            public Color4f Element46;
            public Color4f Element47;
            public Color4f Element48;
            public Color4f Element49;
            public Color4f Element50;
            public Color4f Element51;
            public Color4f Element52;
            public Color4f Element53;
            public Color4f Element54;
            public Color4f Element55;
            public Color4f Element56;
            public Color4f Element57;
            public Color4f Element58;
            public Color4f Element59;
            public Color4f Element60;
            public Color4f Element61;
            public Color4f Element62;
            public Color4f Element63;
            public Color4f Element64;
            public Color4f Element65;
            public Color4f Element66;
            public Color4f Element67;
            public Color4f Element68;
            public Color4f Element69;
            public Color4f Element70;
            public Color4f Element71;
            public Color4f Element72;
            public Color4f Element73;
            public Color4f Element74;
            public Color4f Element75;
            public Color4f Element76;
            public Color4f Element77;
            public Color4f Element78;
            public Color4f Element79;
            public Color4f Element80;
            public Color4f Element81;
            public Color4f Element82;
            public Color4f Element83;
            public Color4f Element84;
            public Color4f Element85;
            public Color4f Element86;
            public Color4f Element87;
            public Color4f Element88;
            public Color4f Element89;
            public Color4f Element90;
            public Color4f Element91;
            public Color4f Element92;
            public Color4f Element93;
            public Color4f Element94;
            public Color4f Element95;
            public Color4f Element96;
            public Color4f Element97;
            public Color4f Element98;
            public Color4f Element99;
            public Color4f Element100;
            public Color4f Element101;
            public Color4f Element102;
            public Color4f Element103;
            public Color4f Element104;
            public Color4f Element105;
            public Color4f Element106;
            public Color4f Element107;
            public Color4f Element108;
            public Color4f Element109;
            public Color4f Element110;
            public Color4f Element111;
            public Color4f Element112;
            public Color4f Element113;
            public Color4f Element114;
            public Color4f Element115;
            public Color4f Element116;
            public Color4f Element117;
            public Color4f Element118;
            public Color4f Element119;
            public Color4f Element120;
            public Color4f Element121;
            public Color4f Element122;
            public Color4f Element123;
            public Color4f Element124;
            public Color4f Element125;
            public Color4f Element126;
            public Color4f Element127;
            public Color4f Element128;
            public Color4f Element129;
            public Color4f Element130;
            public Color4f Element131;
            public Color4f Element132;
            public Color4f Element133;
            public Color4f Element134;
            public Color4f Element135;
            public Color4f Element136;
            public Color4f Element137;
            public Color4f Element138;
            public Color4f Element139;
            public Color4f Element140;
            public Color4f Element141;
            public Color4f Element142;
            public Color4f Element143;
            public Color4f Element144;
            public Color4f Element145;
            public Color4f Element146;
            public Color4f Element147;
            public Color4f Element148;
            public Color4f Element149;
            public Color4f Element150;
            public Color4f Element151;
            public Color4f Element152;
            public Color4f Element153;
            public Color4f Element154;
            public Color4f Element155;
            public Color4f Element156;
            public Color4f Element157;
            public Color4f Element158;
            public Color4f Element159;
            public Color4f Element160;
            public Color4f Element161;
            public Color4f Element162;
            public Color4f Element163;
            public Color4f Element164;
            public Color4f Element165;
            public Color4f Element166;
            public Color4f Element167;
            public Color4f Element168;
            public Color4f Element169;
            public Color4f Element170;
            public Color4f Element171;
            public Color4f Element172;
            public Color4f Element173;
            public Color4f Element174;
            public Color4f Element175;
            public Color4f Element176;
            public Color4f Element177;
            public Color4f Element178;
            public Color4f Element179;
            public Color4f Element180;
            public Color4f Element181;
            public Color4f Element182;
            public Color4f Element183;
            public Color4f Element184;
            public Color4f Element185;
            public Color4f Element186;
            public Color4f Element187;
            public Color4f Element188;
            public Color4f Element189;
            public Color4f Element190;
            public Color4f Element191;
            public Color4f Element192;
            public Color4f Element193;
            public Color4f Element194;
            public Color4f Element195;
            public Color4f Element196;
            public Color4f Element197;
            public Color4f Element198;
            public Color4f Element199;
            public Color4f Element200;
            public Color4f Element201;
            public Color4f Element202;
            public Color4f Element203;
            public Color4f Element204;
            public Color4f Element205;
            public Color4f Element206;
            public Color4f Element207;
            public Color4f Element208;
            public Color4f Element209;
            public Color4f Element210;
            public Color4f Element211;
            public Color4f Element212;
            public Color4f Element213;
            public Color4f Element214;
            public Color4f Element215;
            public Color4f Element216;
            public Color4f Element217;
            public Color4f Element218;
            public Color4f Element219;
            public Color4f Element220;
            public Color4f Element221;
            public Color4f Element222;
            public Color4f Element223;
            public Color4f Element224;
            public Color4f Element225;
            public Color4f Element226;
            public Color4f Element227;
            public Color4f Element228;
            public Color4f Element229;
            public Color4f Element230;
            public Color4f Element231;
            public Color4f Element232;
            public Color4f Element233;
            public Color4f Element234;
            public Color4f Element235;
            public Color4f Element236;
            public Color4f Element237;
            public Color4f Element238;
            public Color4f Element239;
            public Color4f Element240;
            public Color4f Element241;
            public Color4f Element242;
            public Color4f Element243;
            public Color4f Element244;
            public Color4f Element245;
            public Color4f Element246;
            public Color4f Element247;
            public Color4f Element248;
            public Color4f Element249;
            public Color4f Element250;
            public Color4f Element251;
            public Color4f Element252;
            public Color4f Element253;
            public Color4f Element254;
            public Color4f Element255;
            public ref Color4f this[int index]
            {
                get
                {
                    if (index > 255 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (Color4f* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<Color4f> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 256);
#endif
        }

    }
}
