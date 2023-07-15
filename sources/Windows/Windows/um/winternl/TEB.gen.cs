// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='TEB.xml' path='doc/member[@name="TEB"]/*'/>
public unsafe partial struct TEB
{
    /// <include file='TEB.xml' path='doc/member[@name="TEB.Reserved1"]/*'/>
    [NativeTypeName("PVOID[12]")]
    public _Reserved1_e__FixedBuffer Reserved1;
    /// <include file='TEB.xml' path='doc/member[@name="TEB.ProcessEnvironmentBlock"]/*'/>
    [NativeTypeName("PPEB")]
    public PEB* ProcessEnvironmentBlock;
    /// <include file='TEB.xml' path='doc/member[@name="TEB.Reserved2"]/*'/>
    [NativeTypeName("PVOID[399]")]
    public _Reserved2_e__FixedBuffer Reserved2;
    /// <include file='TEB.xml' path='doc/member[@name="TEB.Reserved3"]/*'/>
    [NativeTypeName("BYTE[1952]")]
    public fixed byte Reserved3[1952];
    /// <include file='TEB.xml' path='doc/member[@name="TEB.TlsSlots"]/*'/>
    [NativeTypeName("PVOID[64]")]
    public _TlsSlots_e__FixedBuffer TlsSlots;
    /// <include file='TEB.xml' path='doc/member[@name="TEB.Reserved4"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte Reserved4[8];
    /// <include file='TEB.xml' path='doc/member[@name="TEB.Reserved5"]/*'/>
    [NativeTypeName("PVOID[26]")]
    public _Reserved5_e__FixedBuffer Reserved5;
    /// <include file='TEB.xml' path='doc/member[@name="TEB.ReservedForOle"]/*'/>
    [NativeTypeName("PVOID")]
    public void* ReservedForOle;
    /// <include file='TEB.xml' path='doc/member[@name="TEB.Reserved6"]/*'/>
    [NativeTypeName("PVOID[4]")]
    public _Reserved6_e__FixedBuffer Reserved6;
    /// <include file='TEB.xml' path='doc/member[@name="TEB.TlsExpansionSlots"]/*'/>
    [NativeTypeName("PVOID")]
    public void* TlsExpansionSlots;
    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved1_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public void* e4;
        public void* e5;
        public void* e6;
        public void* e7;
        public void* e8;
        public void* e9;
        public void* e10;
        public void* e11;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved2_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public void* e4;
        public void* e5;
        public void* e6;
        public void* e7;
        public void* e8;
        public void* e9;
        public void* e10;
        public void* e11;
        public void* e12;
        public void* e13;
        public void* e14;
        public void* e15;
        public void* e16;
        public void* e17;
        public void* e18;
        public void* e19;
        public void* e20;
        public void* e21;
        public void* e22;
        public void* e23;
        public void* e24;
        public void* e25;
        public void* e26;
        public void* e27;
        public void* e28;
        public void* e29;
        public void* e30;
        public void* e31;
        public void* e32;
        public void* e33;
        public void* e34;
        public void* e35;
        public void* e36;
        public void* e37;
        public void* e38;
        public void* e39;
        public void* e40;
        public void* e41;
        public void* e42;
        public void* e43;
        public void* e44;
        public void* e45;
        public void* e46;
        public void* e47;
        public void* e48;
        public void* e49;
        public void* e50;
        public void* e51;
        public void* e52;
        public void* e53;
        public void* e54;
        public void* e55;
        public void* e56;
        public void* e57;
        public void* e58;
        public void* e59;
        public void* e60;
        public void* e61;
        public void* e62;
        public void* e63;
        public void* e64;
        public void* e65;
        public void* e66;
        public void* e67;
        public void* e68;
        public void* e69;
        public void* e70;
        public void* e71;
        public void* e72;
        public void* e73;
        public void* e74;
        public void* e75;
        public void* e76;
        public void* e77;
        public void* e78;
        public void* e79;
        public void* e80;
        public void* e81;
        public void* e82;
        public void* e83;
        public void* e84;
        public void* e85;
        public void* e86;
        public void* e87;
        public void* e88;
        public void* e89;
        public void* e90;
        public void* e91;
        public void* e92;
        public void* e93;
        public void* e94;
        public void* e95;
        public void* e96;
        public void* e97;
        public void* e98;
        public void* e99;
        public void* e100;
        public void* e101;
        public void* e102;
        public void* e103;
        public void* e104;
        public void* e105;
        public void* e106;
        public void* e107;
        public void* e108;
        public void* e109;
        public void* e110;
        public void* e111;
        public void* e112;
        public void* e113;
        public void* e114;
        public void* e115;
        public void* e116;
        public void* e117;
        public void* e118;
        public void* e119;
        public void* e120;
        public void* e121;
        public void* e122;
        public void* e123;
        public void* e124;
        public void* e125;
        public void* e126;
        public void* e127;
        public void* e128;
        public void* e129;
        public void* e130;
        public void* e131;
        public void* e132;
        public void* e133;
        public void* e134;
        public void* e135;
        public void* e136;
        public void* e137;
        public void* e138;
        public void* e139;
        public void* e140;
        public void* e141;
        public void* e142;
        public void* e143;
        public void* e144;
        public void* e145;
        public void* e146;
        public void* e147;
        public void* e148;
        public void* e149;
        public void* e150;
        public void* e151;
        public void* e152;
        public void* e153;
        public void* e154;
        public void* e155;
        public void* e156;
        public void* e157;
        public void* e158;
        public void* e159;
        public void* e160;
        public void* e161;
        public void* e162;
        public void* e163;
        public void* e164;
        public void* e165;
        public void* e166;
        public void* e167;
        public void* e168;
        public void* e169;
        public void* e170;
        public void* e171;
        public void* e172;
        public void* e173;
        public void* e174;
        public void* e175;
        public void* e176;
        public void* e177;
        public void* e178;
        public void* e179;
        public void* e180;
        public void* e181;
        public void* e182;
        public void* e183;
        public void* e184;
        public void* e185;
        public void* e186;
        public void* e187;
        public void* e188;
        public void* e189;
        public void* e190;
        public void* e191;
        public void* e192;
        public void* e193;
        public void* e194;
        public void* e195;
        public void* e196;
        public void* e197;
        public void* e198;
        public void* e199;
        public void* e200;
        public void* e201;
        public void* e202;
        public void* e203;
        public void* e204;
        public void* e205;
        public void* e206;
        public void* e207;
        public void* e208;
        public void* e209;
        public void* e210;
        public void* e211;
        public void* e212;
        public void* e213;
        public void* e214;
        public void* e215;
        public void* e216;
        public void* e217;
        public void* e218;
        public void* e219;
        public void* e220;
        public void* e221;
        public void* e222;
        public void* e223;
        public void* e224;
        public void* e225;
        public void* e226;
        public void* e227;
        public void* e228;
        public void* e229;
        public void* e230;
        public void* e231;
        public void* e232;
        public void* e233;
        public void* e234;
        public void* e235;
        public void* e236;
        public void* e237;
        public void* e238;
        public void* e239;
        public void* e240;
        public void* e241;
        public void* e242;
        public void* e243;
        public void* e244;
        public void* e245;
        public void* e246;
        public void* e247;
        public void* e248;
        public void* e249;
        public void* e250;
        public void* e251;
        public void* e252;
        public void* e253;
        public void* e254;
        public void* e255;
        public void* e256;
        public void* e257;
        public void* e258;
        public void* e259;
        public void* e260;
        public void* e261;
        public void* e262;
        public void* e263;
        public void* e264;
        public void* e265;
        public void* e266;
        public void* e267;
        public void* e268;
        public void* e269;
        public void* e270;
        public void* e271;
        public void* e272;
        public void* e273;
        public void* e274;
        public void* e275;
        public void* e276;
        public void* e277;
        public void* e278;
        public void* e279;
        public void* e280;
        public void* e281;
        public void* e282;
        public void* e283;
        public void* e284;
        public void* e285;
        public void* e286;
        public void* e287;
        public void* e288;
        public void* e289;
        public void* e290;
        public void* e291;
        public void* e292;
        public void* e293;
        public void* e294;
        public void* e295;
        public void* e296;
        public void* e297;
        public void* e298;
        public void* e299;
        public void* e300;
        public void* e301;
        public void* e302;
        public void* e303;
        public void* e304;
        public void* e305;
        public void* e306;
        public void* e307;
        public void* e308;
        public void* e309;
        public void* e310;
        public void* e311;
        public void* e312;
        public void* e313;
        public void* e314;
        public void* e315;
        public void* e316;
        public void* e317;
        public void* e318;
        public void* e319;
        public void* e320;
        public void* e321;
        public void* e322;
        public void* e323;
        public void* e324;
        public void* e325;
        public void* e326;
        public void* e327;
        public void* e328;
        public void* e329;
        public void* e330;
        public void* e331;
        public void* e332;
        public void* e333;
        public void* e334;
        public void* e335;
        public void* e336;
        public void* e337;
        public void* e338;
        public void* e339;
        public void* e340;
        public void* e341;
        public void* e342;
        public void* e343;
        public void* e344;
        public void* e345;
        public void* e346;
        public void* e347;
        public void* e348;
        public void* e349;
        public void* e350;
        public void* e351;
        public void* e352;
        public void* e353;
        public void* e354;
        public void* e355;
        public void* e356;
        public void* e357;
        public void* e358;
        public void* e359;
        public void* e360;
        public void* e361;
        public void* e362;
        public void* e363;
        public void* e364;
        public void* e365;
        public void* e366;
        public void* e367;
        public void* e368;
        public void* e369;
        public void* e370;
        public void* e371;
        public void* e372;
        public void* e373;
        public void* e374;
        public void* e375;
        public void* e376;
        public void* e377;
        public void* e378;
        public void* e379;
        public void* e380;
        public void* e381;
        public void* e382;
        public void* e383;
        public void* e384;
        public void* e385;
        public void* e386;
        public void* e387;
        public void* e388;
        public void* e389;
        public void* e390;
        public void* e391;
        public void* e392;
        public void* e393;
        public void* e394;
        public void* e395;
        public void* e396;
        public void* e397;
        public void* e398;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_TlsSlots_e__FixedBuffer.xml' path='doc/member[@name="_TlsSlots_e__FixedBuffer"]/*'/>
    public unsafe partial struct _TlsSlots_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public void* e4;
        public void* e5;
        public void* e6;
        public void* e7;
        public void* e8;
        public void* e9;
        public void* e10;
        public void* e11;
        public void* e12;
        public void* e13;
        public void* e14;
        public void* e15;
        public void* e16;
        public void* e17;
        public void* e18;
        public void* e19;
        public void* e20;
        public void* e21;
        public void* e22;
        public void* e23;
        public void* e24;
        public void* e25;
        public void* e26;
        public void* e27;
        public void* e28;
        public void* e29;
        public void* e30;
        public void* e31;
        public void* e32;
        public void* e33;
        public void* e34;
        public void* e35;
        public void* e36;
        public void* e37;
        public void* e38;
        public void* e39;
        public void* e40;
        public void* e41;
        public void* e42;
        public void* e43;
        public void* e44;
        public void* e45;
        public void* e46;
        public void* e47;
        public void* e48;
        public void* e49;
        public void* e50;
        public void* e51;
        public void* e52;
        public void* e53;
        public void* e54;
        public void* e55;
        public void* e56;
        public void* e57;
        public void* e58;
        public void* e59;
        public void* e60;
        public void* e61;
        public void* e62;
        public void* e63;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_Reserved5_e__FixedBuffer.xml' path='doc/member[@name="_Reserved5_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved5_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public void* e4;
        public void* e5;
        public void* e6;
        public void* e7;
        public void* e8;
        public void* e9;
        public void* e10;
        public void* e11;
        public void* e12;
        public void* e13;
        public void* e14;
        public void* e15;
        public void* e16;
        public void* e17;
        public void* e18;
        public void* e19;
        public void* e20;
        public void* e21;
        public void* e22;
        public void* e23;
        public void* e24;
        public void* e25;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_Reserved6_e__FixedBuffer.xml' path='doc/member[@name="_Reserved6_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved6_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}