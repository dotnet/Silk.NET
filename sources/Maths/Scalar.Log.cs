// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ported / adopted from https://github.com/amd/aocl-libm-ose/tree/master/src/optmized

/*
 * Copyright (C) 2008-2020 Advanced Micro Devices, Inc. All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 * 1. Redistributions of source code must retain the above copyright notice,
 *    this list of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright notice,
 *    this list of conditions and the following disclaimer in the documentation
 *    and/or other materials provided with the distribution.
 * 3. Neither the name of the copyright holder nor the names of its contributors
 *    may be used to endorse or promote products derived from this software without
 *    specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 * IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA,
 * OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 *
 */

using System;
using System.Runtime.CompilerServices;
#if SSE
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Silk.NET.Maths
{
    public static partial class Scalar
    {
        private static uint[] InitLog()
        {
#if POH
            var logTblLookup = GC.AllocateUninitializedArray<uint>(771, true);
#else
            var logTblLookup = new uint[771];
#endif
            int i = 0;
            logTblLookup[i++] = 0x40000000; logTblLookup[i++] = 0x0; logTblLookup[i++] = 0x0; logTblLookup[i++] = 0x3fff00ff; logTblLookup[i++] = 0x3b7f8000; logTblLookup[i++] = 0x32aa2b11; logTblLookup[i++] = 0x3ffe03f8; logTblLookup[i++] = 0x3bff0000; logTblLookup[i++] = 0x3429ac42; logTblLookup[i++] =
    0x3ffd08e5; logTblLookup[i++] = 0x3c3ee000; logTblLookup[i++] = 0x350ebf02; logTblLookup[i++] = 0x3ffc0fc1; logTblLookup[i++] = 0x3c7e0000; logTblLookup[i++] = 0x35a8b0fc; logTblLookup[i++] = 0x3ffb1885; logTblLookup[i++] = 0x3c9e7000; logTblLookup[i++] =
0x36244347; logTblLookup[i++] = 0x3ffa232d; logTblLookup[i++] = 0x3cbdc000; logTblLookup[i++] = 0x368d83eb; logTblLookup[i++] = 0x3ff92fb2; logTblLookup[i++] = 0x3cdcf000; logTblLookup[i++] = 0x36e013d8; logTblLookup[i++] = 0x3ff83e10; logTblLookup[i++] =
0x3cfc1000; logTblLookup[i++] = 0x361b0e78; logTblLookup[i++] = 0x3ff74e40; logTblLookup[i++] = 0x3d0d8000; logTblLookup[i++] = 0x36d98924; logTblLookup[i++] = 0x3ff6603e; logTblLookup[i++] = 0x3d1cf000; logTblLookup[i++] = 0x3687b9ff; logTblLookup[i++] =
0x3ff57404; logTblLookup[i++] = 0x3d2c5000; logTblLookup[i++] = 0x36375f92; logTblLookup[i++] = 0x3ff4898d; logTblLookup[i++] = 0x3d3ba000; logTblLookup[i++] = 0x3631ec66; logTblLookup[i++] = 0x3ff3a0d5; logTblLookup[i++] = 0x3d4ae000; logTblLookup[i++] =
0x36830ec9; logTblLookup[i++] = 0x3ff2b9d6; logTblLookup[i++] = 0x3d5a1000; logTblLookup[i++] = 0x36dd7119; logTblLookup[i++] = 0x3ff1d48c; logTblLookup[i++] = 0x3d693000; logTblLookup[i++] = 0x3735c56e; logTblLookup[i++] = 0x3ff0f0f1; logTblLookup[i++] =
0x3d785000; logTblLookup[i++] = 0x35c30046; logTblLookup[i++] = 0x3ff00f01; logTblLookup[i++] = 0x3d83a000; logTblLookup[i++] = 0x37cc1acc; logTblLookup[i++] = 0x3fef2eb7; logTblLookup[i++] = 0x3d8b2000; logTblLookup[i++] = 0x379b7752; logTblLookup[i++] =
0x3fee500f; logTblLookup[i++] = 0x3d929000; logTblLookup[i++] = 0x37fb1785; logTblLookup[i++] = 0x3fed7304; logTblLookup[i++] = 0x3d9a0000; logTblLookup[i++] = 0x37ebcb0e; logTblLookup[i++] = 0x3fec9791; logTblLookup[i++] = 0x3da17000; logTblLookup[i++] =
0x375cbea6; logTblLookup[i++] = 0x3febbdb3; logTblLookup[i++] = 0x3da8d000; logTblLookup[i++] = 0x37839f83; logTblLookup[i++] = 0x3feae564; logTblLookup[i++] = 0x3db03000; logTblLookup[i++] = 0x36b1526f; logTblLookup[i++] = 0x3fea0ea1; logTblLookup[i++] =
0x3db78000; logTblLookup[i++] = 0x37528ae5; logTblLookup[i++] = 0x3fe93965; logTblLookup[i++] = 0x3dbed000; logTblLookup[i++] = 0x36ecdaf6; logTblLookup[i++] = 0x3fe865ac; logTblLookup[i++] = 0x3dc61000; logTblLookup[i++] = 0x37a2eb19; logTblLookup[i++] =
0x3fe79373; logTblLookup[i++] = 0x3dcd5000; logTblLookup[i++] = 0x37a12310; logTblLookup[i++] = 0x3fe6c2b4; logTblLookup[i++] = 0x3dd49000; logTblLookup[i++] = 0x36da7496; logTblLookup[i++] = 0x3fe5f36d; logTblLookup[i++] = 0x3ddbc000; logTblLookup[i++] =
0x37482bb1; logTblLookup[i++] = 0x3fe52598; logTblLookup[i++] = 0x3de2f000; logTblLookup[i++] = 0x36a91eb8; logTblLookup[i++] = 0x3fe45933; logTblLookup[i++] = 0x3dea1000; logTblLookup[i++] = 0x3789eb36; logTblLookup[i++] = 0x3fe38e39; logTblLookup[i++] =
0x3df13000; logTblLookup[i++] = 0x3783b715; logTblLookup[i++] = 0x3fe2c4a7; logTblLookup[i++] = 0x3df85000; logTblLookup[i++] = 0x36430046; logTblLookup[i++] = 0x3fe1fc78; logTblLookup[i++] = 0x3dff6000; logTblLookup[i++] = 0x371131dc; logTblLookup[i++] =
0x3fe135aa; logTblLookup[i++] = 0x3e033000; logTblLookup[i++] = 0x380a8965; logTblLookup[i++] = 0x3fe07038; logTblLookup[i++] = 0x3e06b000; logTblLookup[i++] = 0x383f3e68; logTblLookup[i++] = 0x3fdfac1f; logTblLookup[i++] = 0x3e0a3000; logTblLookup[i++] =
0x3842c234; logTblLookup[i++] = 0x3fdee95c; logTblLookup[i++] = 0x3e0db000; logTblLookup[i++] = 0x38156a98; logTblLookup[i++] = 0x3fde27eb; logTblLookup[i++] = 0x3e113000; logTblLookup[i++] = 0x375e3215; logTblLookup[i++] = 0x3fdd67c9; logTblLookup[i++] =
0x3e14a000; logTblLookup[i++] = 0x38297c10; logTblLookup[i++] = 0x3fdca8f1; logTblLookup[i++] = 0x3e181000; logTblLookup[i++] = 0x386b8c72; logTblLookup[i++] = 0x3fdbeb62; logTblLookup[i++] = 0x3e1b8000; logTblLookup[i++] = 0x387e100f; logTblLookup[i++] =
0x3fdb2f17; logTblLookup[i++] = 0x3e1ef000; logTblLookup[i++] = 0x38615876; logTblLookup[i++] = 0x3fda740e; logTblLookup[i++] = 0x3e226000; logTblLookup[i++] = 0x3815b666; logTblLookup[i++] = 0x3fd9ba42; logTblLookup[i++] = 0x3e25d000; logTblLookup[i++] =
0x36dbce69; logTblLookup[i++] = 0x3fd901b2; logTblLookup[i++] = 0x3e293000; logTblLookup[i++] = 0x37e5e3a2; logTblLookup[i++] = 0x3fd84a5a; logTblLookup[i++] = 0x3e2c9000; logTblLookup[i++] = 0x381c6ccc; logTblLookup[i++] = 0x3fd79436; logTblLookup[i++] =
0x3e2ff000; logTblLookup[i++] = 0x38183854; logTblLookup[i++] = 0x3fd6df44; logTblLookup[i++] = 0x3e335000; logTblLookup[i++] = 0x37cd4273; logTblLookup[i++] = 0x3fd62b81; logTblLookup[i++] = 0x3e36b000; logTblLookup[i++] = 0x35fe719d; logTblLookup[i++] =
0x3fd578e9; logTblLookup[i++] = 0x3e3a0000; logTblLookup[i++] = 0x37f8f540; logTblLookup[i++] = 0x3fd4c77b; logTblLookup[i++] = 0x3e3d5000; logTblLookup[i++] = 0x38448108; logTblLookup[i++] = 0x3fd41733; logTblLookup[i++] = 0x3e40a000; logTblLookup[i++] =
0x386050a2; logTblLookup[i++] = 0x3fd3680d; logTblLookup[i++] = 0x3e43f000; logTblLookup[i++] = 0x38503290; logTblLookup[i++] = 0x3fd2ba08; logTblLookup[i++] = 0x3e474000; logTblLookup[i++] = 0x38146f44; logTblLookup[i++] = 0x3fd20d21; logTblLookup[i++] =
0x3e4a9000; logTblLookup[i++] = 0x373539e9; logTblLookup[i++] = 0x3fd16154; logTblLookup[i++] = 0x3e4dd000; logTblLookup[i++] = 0x381b173f; logTblLookup[i++] = 0x3fd0b6a0; logTblLookup[i++] = 0x3e511000; logTblLookup[i++] = 0x385e0ff1; logTblLookup[i++] =
0x3fd00d01; logTblLookup[i++] = 0x3e545000; logTblLookup[i++] = 0x38767e44; logTblLookup[i++] = 0x3fcf6475; logTblLookup[i++] = 0x3e579000; logTblLookup[i++] = 0x3864a740; logTblLookup[i++] = 0x3fcebcf9; logTblLookup[i++] = 0x3e5ad000; logTblLookup[i++] =
0x3828cf48; logTblLookup[i++] = 0x3fce168a; logTblLookup[i++] = 0x3e5e1000; logTblLookup[i++] = 0x3786742e; logTblLookup[i++] = 0x3fcd7127; logTblLookup[i++] = 0x3e614000; logTblLookup[i++] = 0x38342ac6; logTblLookup[i++] = 0x3fcccccd; logTblLookup[i++] =
0x3e647000; logTblLookup[i++] = 0x387be3cd; logTblLookup[i++] = 0x3fcc2978; logTblLookup[i++] = 0x3e67b000; logTblLookup[i++] = 0x36d53827; logTblLookup[i++] = 0x3fcb8728; logTblLookup[i++] = 0x3e6ae000; logTblLookup[i++] = 0x3685ad3f; logTblLookup[i++] =
0x3fcae5d8; logTblLookup[i++] = 0x3e6e0000; logTblLookup[i++] = 0x385e5056; logTblLookup[i++] = 0x3fca4588; logTblLookup[i++] = 0x3e713000; logTblLookup[i++] = 0x3803b715; logTblLookup[i++] = 0x3fc9a634; logTblLookup[i++] = 0x3e746000; logTblLookup[i++] =
0x3494aa97; logTblLookup[i++] = 0x3fc907da; logTblLookup[i++] = 0x3e778000; logTblLookup[i++] = 0x37adcbdc; logTblLookup[i++] = 0x3fc86a79; logTblLookup[i++] = 0x3e7aa000; logTblLookup[i++] = 0x38052b26; logTblLookup[i++] = 0x3fc7ce0c; logTblLookup[i++] =
0x3e7dc000; logTblLookup[i++] = 0x380c36af; logTblLookup[i++] = 0x3fc73294; logTblLookup[i++] = 0x3e807000; logTblLookup[i++] = 0x37d88b5b; logTblLookup[i++] = 0x3fc6980c; logTblLookup[i++] = 0x3e820000; logTblLookup[i++] = 0x371652d3; logTblLookup[i++] =
0x3fc5fe74; logTblLookup[i++] = 0x3e838000; logTblLookup[i++] = 0x38dc2fe7; logTblLookup[i++] = 0x3fc565c8; logTblLookup[i++] = 0x3e851000; logTblLookup[i++] = 0x3892713a; logTblLookup[i++] = 0x3fc4ce08; logTblLookup[i++] = 0x3e86a000; logTblLookup[i++] =
0x37d6af35; logTblLookup[i++] = 0x3fc43730; logTblLookup[i++] = 0x3e882000; logTblLookup[i++] = 0x38c5fcd7; logTblLookup[i++] = 0x3fc3a13e; logTblLookup[i++] = 0x3e89b000; logTblLookup[i++] = 0x38070294; logTblLookup[i++] = 0x3fc30c31; logTblLookup[i++] =
0x3e8b3000; logTblLookup[i++] = 0x38ae55d6; logTblLookup[i++] = 0x3fc27806; logTblLookup[i++] = 0x3e8cc000; logTblLookup[i++] = 0x3652dd42; logTblLookup[i++] = 0x3fc1e4bc; logTblLookup[i++] = 0x3e8e4000; logTblLookup[i++] = 0x3818c16a; logTblLookup[i++] =
0x3fc15250; logTblLookup[i++] = 0x3e8fc000; logTblLookup[i++] = 0x387f9e49; logTblLookup[i++] = 0x3fc0c0c1; logTblLookup[i++] = 0x3e914000; logTblLookup[i++] = 0x38a0fde8; logTblLookup[i++] = 0x3fc0300c; logTblLookup[i++] = 0x3e92c000; logTblLookup[i++] =
0x38b00870; logTblLookup[i++] = 0x3fbfa030; logTblLookup[i++] = 0x3e944000; logTblLookup[i++] = 0x38ad09ef; logTblLookup[i++] = 0x3fbf112b; logTblLookup[i++] = 0x3e95c000; logTblLookup[i++] = 0x38981d5c; logTblLookup[i++] = 0x3fbe82fa; logTblLookup[i++] =
0x3e974000; logTblLookup[i++] = 0x3862bae1; logTblLookup[i++] = 0x3fbdf59d; logTblLookup[i++] = 0x3e98c000; logTblLookup[i++] = 0x37e392a9; logTblLookup[i++] = 0x3fbd6910; logTblLookup[i++] = 0x3e9a3000; logTblLookup[i++] = 0x38eecd4c; logTblLookup[i++] =
0x3fbcdd53; logTblLookup[i++] = 0x3e9bb000; logTblLookup[i++] = 0x38933160; logTblLookup[i++] = 0x3fbc5264; logTblLookup[i++] = 0x3e9d3000; logTblLookup[i++] = 0x3798aad3; logTblLookup[i++] = 0x3fbbc841; logTblLookup[i++] = 0x3e9ea000; logTblLookup[i++] =
0x38a7d2e1; logTblLookup[i++] = 0x3fbb3ee7; logTblLookup[i++] = 0x3ea02000; logTblLookup[i++] = 0x37421a1b; logTblLookup[i++] = 0x3fbab656; logTblLookup[i++] = 0x3ea19000; logTblLookup[i++] = 0x386f2a05; logTblLookup[i++] = 0x3fba2e8c; logTblLookup[i++] =
0x3ea30000; logTblLookup[i++] = 0x38c5e10e; logTblLookup[i++] = 0x3fb9a786; logTblLookup[i++] = 0x3ea48000; logTblLookup[i++] = 0x35d00801; logTblLookup[i++] = 0x3fb92144; logTblLookup[i++] = 0x3ea5f000; logTblLookup[i++] = 0x37bf2aef; logTblLookup[i++] =
0x3fb89bc3; logTblLookup[i++] = 0x3ea76000; logTblLookup[i++] = 0x38173260; logTblLookup[i++] = 0x3fb81703; logTblLookup[i++] = 0x3ea8d000; logTblLookup[i++] = 0x382d872e; logTblLookup[i++] = 0x3fb79301; logTblLookup[i++] = 0x3eaa4000; logTblLookup[i++] =
0x3822c3ae; logTblLookup[i++] = 0x3fb70fbb; logTblLookup[i++] = 0x3eabb000; logTblLookup[i++] = 0x37ee2e8b; logTblLookup[i++] = 0x3fb68d31; logTblLookup[i++] = 0x3ead2000; logTblLookup[i++] = 0x372ac3d3; logTblLookup[i++] = 0x3fb60b61; logTblLookup[i++] =
0x3eae8000; logTblLookup[i++] = 0x38dedfac; logTblLookup[i++] = 0x3fb58a48; logTblLookup[i++] = 0x3eaff000; logTblLookup[i++] = 0x38983854; logTblLookup[i++] = 0x3fb509e7; logTblLookup[i++] = 0x3eb16000; logTblLookup[i++] = 0x3802f2ba; logTblLookup[i++] =
0x3fb48a3a; logTblLookup[i++] = 0x3eb2c000; logTblLookup[i++] = 0x38dab982; logTblLookup[i++] = 0x3fb40b41; logTblLookup[i++] = 0x3eb43000; logTblLookup[i++] = 0x38481e9b; logTblLookup[i++] = 0x3fb38cfa; logTblLookup[i++] = 0x3eb59000; logTblLookup[i++] =
0x38dd911b; logTblLookup[i++] = 0x3fb30f63; logTblLookup[i++] = 0x3eb70000; logTblLookup[i++] = 0x380eaa2c; logTblLookup[i++] = 0x3fb2927c; logTblLookup[i++] = 0x3eb86000; logTblLookup[i++] = 0x38a1713c; logTblLookup[i++] = 0x3fb21643; logTblLookup[i++] =
0x3eb9c000; logTblLookup[i++] = 0x38ebfb5e; logTblLookup[i++] = 0x3fb19ab6; logTblLookup[i++] = 0x3ebb3000; logTblLookup[i++] = 0x379c2474; logTblLookup[i++] = 0x3fb11fd4; logTblLookup[i++] = 0x3ebc9000; logTblLookup[i++] = 0x38255fdd; logTblLookup[i++] =
0x3fb0a59b; logTblLookup[i++] = 0x3ebdf000; logTblLookup[i++] = 0x385e0a38; logTblLookup[i++] = 0x3fb02c0b; logTblLookup[i++] = 0x3ebf5000; logTblLookup[i++] = 0x38783b83; logTblLookup[i++] = 0x3fafb322; logTblLookup[i++] = 0x3ec0b000; logTblLookup[i++] =
0x38741da1; logTblLookup[i++] = 0x3faf3ade; logTblLookup[i++] = 0x3ec21000; logTblLookup[i++] = 0x3851da1f; logTblLookup[i++] = 0x3faec33e; logTblLookup[i++] = 0x3ec37000; logTblLookup[i++] = 0x38119a33; logTblLookup[i++] = 0x3fae4c41; logTblLookup[i++] =
0x3ec4d000; logTblLookup[i++] = 0x374e1b05; logTblLookup[i++] = 0x3fadd5e6; logTblLookup[i++] = 0x3ec62000; logTblLookup[i++] = 0x38dbe42c; logTblLookup[i++] = 0x3fad602b; logTblLookup[i++] = 0x3ec78000; logTblLookup[i++] = 0x388f439b; logTblLookup[i++] =
0x3faceb10; logTblLookup[i++] = 0x3ec8e000; logTblLookup[i++] = 0x37cfd68b; logTblLookup[i++] = 0x3fac7692; logTblLookup[i++] = 0x3eca3000; logTblLookup[i++] = 0x38ca0e11; logTblLookup[i++] = 0x3fac02b0; logTblLookup[i++] = 0x3ecb9000; logTblLookup[i++] =
0x38234113; logTblLookup[i++] = 0x3fab8f6a; logTblLookup[i++] = 0x3ecce000; logTblLookup[i++] = 0x38cac08c; logTblLookup[i++] = 0x3fab1cbe; logTblLookup[i++] = 0x3ece4000; logTblLookup[i++] = 0x37d605b8; logTblLookup[i++] = 0x3faaaaab; logTblLookup[i++] =
0x3ecf9000; logTblLookup[i++] = 0x3891f660; logTblLookup[i++] = 0x3faa392f; logTblLookup[i++] = 0x3ed0e000; logTblLookup[i++] = 0x38e0326b; logTblLookup[i++] = 0x3fa9c84a; logTblLookup[i++] = 0x3ed24000; logTblLookup[i++] = 0x378121cb; logTblLookup[i++] =
0x3fa957fb; logTblLookup[i++] = 0x3ed39000; logTblLookup[i++] = 0x3824966c; logTblLookup[i++] = 0x3fa8e83f; logTblLookup[i++] = 0x3ed4e000; logTblLookup[i++] = 0x386c9a9a; logTblLookup[i++] = 0x3fa87917; logTblLookup[i++] = 0x3ed63000; logTblLookup[i++] =
0x388c612c; logTblLookup[i++] = 0x3fa80a81; logTblLookup[i++] = 0x3ed78000; logTblLookup[i++] = 0x38949924; logTblLookup[i++] = 0x3fa79c7b; logTblLookup[i++] = 0x3ed8d000; logTblLookup[i++] = 0x388f075f; logTblLookup[i++] = 0x3fa72f05; logTblLookup[i++] =
0x3eda2000; logTblLookup[i++] = 0x38777bcd; logTblLookup[i++] = 0x3fa6c21e; logTblLookup[i++] = 0x3edb7000; logTblLookup[i++] = 0x38359d3d; logTblLookup[i++] = 0x3fa655c4; logTblLookup[i++] = 0x3edcc000; logTblLookup[i++] = 0x37b12d26; logTblLookup[i++] =
0x3fa5e9f7; logTblLookup[i++] = 0x3ede0000; logTblLookup[i++] = 0x38f04587; logTblLookup[i++] = 0x3fa57eb5; logTblLookup[i++] = 0x3edf5000; logTblLookup[i++] = 0x38a6ced4; logTblLookup[i++] = 0x3fa513fd; logTblLookup[i++] = 0x3ee0a000; logTblLookup[i++] =
0x381ff116; logTblLookup[i++] = 0x3fa4a9cf; logTblLookup[i++] = 0x3ee1e000; logTblLookup[i++] = 0x38ebd3e7; logTblLookup[i++] = 0x3fa44029; logTblLookup[i++] = 0x3ee33000; logTblLookup[i++] = 0x3874e3ff; logTblLookup[i++] = 0x3fa3d70a; logTblLookup[i++] =
0x3ee47000; logTblLookup[i++] = 0x38fbe3cd; logTblLookup[i++] = 0x3fa36e72; logTblLookup[i++] = 0x3ee5c000; logTblLookup[i++] = 0x3860744d; logTblLookup[i++] = 0x3fa3065e; logTblLookup[i++] = 0x3ee70000; logTblLookup[i++] = 0x38d785c3; logTblLookup[i++] =
0x3fa29ecf; logTblLookup[i++] = 0x3ee85000; logTblLookup[i++] = 0x37c75ce4; logTblLookup[i++] = 0x3fa237c3; logTblLookup[i++] = 0x3ee99000; logTblLookup[i++] = 0x387e7e01; logTblLookup[i++] = 0x3fa1d13a; logTblLookup[i++] = 0x3eead000; logTblLookup[i++] =
0x38bfcd71; logTblLookup[i++] = 0x3fa16b31; logTblLookup[i++] = 0x3eec1000; logTblLookup[i++] = 0x38f392c5; logTblLookup[i++] = 0x3fa105a9; logTblLookup[i++] = 0x3eed6000; logTblLookup[i++] = 0x3754f8b1; logTblLookup[i++] = 0x3fa0a0a1; logTblLookup[i++] =
0x3eeea000; logTblLookup[i++] = 0x37d40984; logTblLookup[i++] = 0x3fa03c17; logTblLookup[i++] = 0x3eefe000; logTblLookup[i++] = 0x38059907; logTblLookup[i++] = 0x3f9fd80a; logTblLookup[i++] = 0x3ef12000; logTblLookup[i++] = 0x38081a7c; logTblLookup[i++] =
0x3f9f747a; logTblLookup[i++] = 0x3ef26000; logTblLookup[i++] = 0x37e350d1; logTblLookup[i++] = 0x3f9f1166; logTblLookup[i++] = 0x3ef3a000; logTblLookup[i++] = 0x3784c3ad; logTblLookup[i++] = 0x3f9eaecd; logTblLookup[i++] = 0x3ef4d000; logTblLookup[i++] =
0x38fd32cc; logTblLookup[i++] = 0x3f9e4cad; logTblLookup[i++] = 0x3ef61000; logTblLookup[i++] = 0x38cce923; logTblLookup[i++] = 0x3f9deb07; logTblLookup[i++] = 0x3ef75000; logTblLookup[i++] = 0x38906320; logTblLookup[i++] = 0x3f9d89d9; logTblLookup[i++] =
0x3ef89000; logTblLookup[i++] = 0x380f5faf; logTblLookup[i++] = 0x3f9d2922; logTblLookup[i++] = 0x3ef9c000; logTblLookup[i++] = 0x38f2de41; logTblLookup[i++] = 0x3f9cc8e1; logTblLookup[i++] = 0x3efb0000; logTblLookup[i++] = 0x3891fd38; logTblLookup[i++] =
0x3f9c6917; logTblLookup[i++] = 0x3efc4000; logTblLookup[i++] = 0x37946dfd; logTblLookup[i++] = 0x3f9c09c1; logTblLookup[i++] = 0x3efd7000; logTblLookup[i++] = 0x38ac47bc; logTblLookup[i++] = 0x3f9baadf; logTblLookup[i++] = 0x3efeb000; logTblLookup[i++] =
0x379e41ec; logTblLookup[i++] = 0x3f9b4c70; logTblLookup[i++] = 0x3effe000; logTblLookup[i++] = 0x3897042c; logTblLookup[i++] = 0x3f9aee73; logTblLookup[i++] = 0x3f008000; logTblLookup[i++] = 0x397d5893; logTblLookup[i++] = 0x3f9a90e8; logTblLookup[i++] =
0x3f012000; logTblLookup[i++] = 0x392952d3; logTblLookup[i++] = 0x3f9a33cd; logTblLookup[i++] = 0x3f01c000; logTblLookup[i++] = 0x389eefce; logTblLookup[i++] = 0x3f99d723; logTblLookup[i++] = 0x3f025000; logTblLookup[i++] = 0x396fced5; logTblLookup[i++] =
0x3f997ae7; logTblLookup[i++] = 0x3f02f000; logTblLookup[i++] = 0x390a5e93; logTblLookup[i++] = 0x3f991f1a; logTblLookup[i++] = 0x3f039000; logTblLookup[i++] = 0x37f97073; logTblLookup[i++] = 0x3f98c3bb; logTblLookup[i++] = 0x3f042000; logTblLookup[i++] =
0x392e4426; logTblLookup[i++] = 0x3f9868c8; logTblLookup[i++] = 0x3f04c000; logTblLookup[i++] = 0x385e9eae; logTblLookup[i++] = 0x3f980e41; logTblLookup[i++] = 0x3f055000; logTblLookup[i++] = 0x393b5f67; logTblLookup[i++] = 0x3f97b426; logTblLookup[i++] =
0x3f05f000; logTblLookup[i++] = 0x3865c84a; logTblLookup[i++] = 0x3f975a75; logTblLookup[i++] = 0x3f068000; logTblLookup[i++] = 0x3931e65d; logTblLookup[i++] = 0x3f97012e; logTblLookup[i++] = 0x3f072000; logTblLookup[i++] = 0x38130ba4; logTblLookup[i++] =
0x3f96a850; logTblLookup[i++] = 0x3f07b000; logTblLookup[i++] = 0x39120e4e; logTblLookup[i++] = 0x3f964fda; logTblLookup[i++] = 0x3f084000; logTblLookup[i++] = 0x3979cf17; logTblLookup[i++] = 0x3f95f7cc; logTblLookup[i++] = 0x3f08e000; logTblLookup[i++] =
0x38b81788; logTblLookup[i++] = 0x3f95a025; logTblLookup[i++] = 0x3f097000; logTblLookup[i++] = 0x3938caca; logTblLookup[i++] = 0x3f9548e5; logTblLookup[i++] = 0x3f0a1000; logTblLookup[i++] = 0x37809491; logTblLookup[i++] = 0x3f94f209; logTblLookup[i++] =
0x3f0aa000; logTblLookup[i++] = 0x38c3d2f5; logTblLookup[i++] = 0x3f949b93; logTblLookup[i++] = 0x3f0b3000; logTblLookup[i++] = 0x392e55d6; logTblLookup[i++] = 0x3f944581; logTblLookup[i++] = 0x3f0bc000; logTblLookup[i++] = 0x39755dec; logTblLookup[i++] =
0x3f93efd2; logTblLookup[i++] = 0x3f0c6000; logTblLookup[i++] = 0x385c1fec; logTblLookup[i++] = 0x3f939a86; logTblLookup[i++] = 0x3f0cf000; logTblLookup[i++] = 0x38e6b468; logTblLookup[i++] = 0x3f93459c; logTblLookup[i++] = 0x3f0d8000; logTblLookup[i++] =
0x392a5abf; logTblLookup[i++] = 0x3f92f114; logTblLookup[i++] = 0x3f0e1000; logTblLookup[i++] = 0x395c0fb9; logTblLookup[i++] = 0x3f929cec; logTblLookup[i++] = 0x3f0eb000; logTblLookup[i++] = 0x3707f33c; logTblLookup[i++] = 0x3f924925; logTblLookup[i++] =
0x3f0f4000; logTblLookup[i++] = 0x383ebce1; logTblLookup[i++] = 0x3f91f5bd; logTblLookup[i++] = 0x3f0fd000; logTblLookup[i++] = 0x38a34b87; logTblLookup[i++] = 0x3f91a2b4; logTblLookup[i++] = 0x3f106000; logTblLookup[i++] = 0x38dcd193; logTblLookup[i++] =
0x3f915009; logTblLookup[i++] = 0x3f10f000; logTblLookup[i++] = 0x3905fe33; logTblLookup[i++] = 0x3f90fdbc; logTblLookup[i++] = 0x3f118000; logTblLookup[i++] = 0x39186bdf; logTblLookup[i++] = 0x3f90abcc; logTblLookup[i++] = 0x3f121000; logTblLookup[i++] =
0x3925b7a4; logTblLookup[i++] = 0x3f905a38; logTblLookup[i++] = 0x3f12a000; logTblLookup[i++] = 0x392de74c; logTblLookup[i++] = 0x3f900901; logTblLookup[i++] = 0x3f133000; logTblLookup[i++] = 0x3931009a; logTblLookup[i++] = 0x3f8fb824; logTblLookup[i++] =
0x3f13c000; logTblLookup[i++] = 0x392f0945; logTblLookup[i++] = 0x3f8f67a2; logTblLookup[i++] = 0x3f145000; logTblLookup[i++] = 0x392806fb; logTblLookup[i++] = 0x3f8f177a; logTblLookup[i++] = 0x3f14e000; logTblLookup[i++] = 0x391bff61; logTblLookup[i++] =
0x3f8ec7ab; logTblLookup[i++] = 0x3f157000; logTblLookup[i++] = 0x390af813; logTblLookup[i++] = 0x3f8e7835; logTblLookup[i++] = 0x3f160000; logTblLookup[i++] = 0x38e9ed45; logTblLookup[i++] = 0x3f8e2918; logTblLookup[i++] = 0x3f169000; logTblLookup[i++] =
0x38b4012f; logTblLookup[i++] = 0x3f8dda52; logTblLookup[i++] = 0x3f172000; logTblLookup[i++] = 0x38686dc8; logTblLookup[i++] = 0x3f8d8be3; logTblLookup[i++] = 0x3f17b000; logTblLookup[i++] = 0x37aa6542; logTblLookup[i++] = 0x3f8d3dcb; logTblLookup[i++] =
0x3f183000; logTblLookup[i++] = 0x396b99a8; logTblLookup[i++] = 0x3f8cf009; logTblLookup[i++] = 0x3f18c000; logTblLookup[i++] = 0x393d07d4; logTblLookup[i++] = 0x3f8ca29c; logTblLookup[i++] = 0x3f195000; logTblLookup[i++] = 0x39099c89; logTblLookup[i++] =
0x3f8c5584; logTblLookup[i++] = 0x3f19e000; logTblLookup[i++] = 0x38a2ba33; logTblLookup[i++] = 0x3f8c08c1; logTblLookup[i++] = 0x3f1a7000; logTblLookup[i++] = 0x37a27674; logTblLookup[i++] = 0x3f8bbc51; logTblLookup[i++] = 0x3f1af000; logTblLookup[i++] =
0x395276ea; logTblLookup[i++] = 0x3f8b7034; logTblLookup[i++] = 0x3f1b8000; logTblLookup[i++] = 0x390bdaa4; logTblLookup[i++] = 0x3f8b246b; logTblLookup[i++] = 0x3f1c1000; logTblLookup[i++] = 0x3880fe58; logTblLookup[i++] = 0x3f8ad8f3; logTblLookup[i++] =
0x3f1c9000; logTblLookup[i++] = 0x397069ab; logTblLookup[i++] = 0x3f8a8dcd; logTblLookup[i++] = 0x3f1d2000; logTblLookup[i++] = 0x391b9f3f; logTblLookup[i++] = 0x3f8a42f8; logTblLookup[i++] = 0x3f1db000; logTblLookup[i++] = 0x38844a00; logTblLookup[i++] =
0x3f89f874; logTblLookup[i++] = 0x3f1e3000; logTblLookup[i++] = 0x3963fffc; logTblLookup[i++] = 0x3f89ae41; logTblLookup[i++] = 0x3f1ec000; logTblLookup[i++] = 0x39013539; logTblLookup[i++] = 0x3f89645c; logTblLookup[i++] = 0x3f1f5000; logTblLookup[i++] =
0x37ce4dad; logTblLookup[i++] = 0x3f891ac7; logTblLookup[i++] = 0x3f1fd000; logTblLookup[i++] = 0x392dc269; logTblLookup[i++] = 0x3f88d181; logTblLookup[i++] = 0x3f206000; logTblLookup[i++] = 0x38749102; logTblLookup[i++] = 0x3f888889; logTblLookup[i++] =
0x3f20e000; logTblLookup[i++] = 0x3947f423; logTblLookup[i++] = 0x3f883fde; logTblLookup[i++] = 0x3f217000; logTblLookup[i++] = 0x389c6de0; logTblLookup[i++] = 0x3f87f781; logTblLookup[i++] = 0x3f21f000; logTblLookup[i++] = 0x394ff17d; logTblLookup[i++] =
0x3f87af70; logTblLookup[i++] = 0x3f228000; logTblLookup[i++] = 0x389a5134; logTblLookup[i++] = 0x3f8767ab; logTblLookup[i++] = 0x3f230000; logTblLookup[i++] = 0x3945e10e; logTblLookup[i++] = 0x3f872033; logTblLookup[i++] = 0x3f239000; logTblLookup[i++] =
0x38687e67; logTblLookup[i++] = 0x3f86d905; logTblLookup[i++] = 0x3f241000; logTblLookup[i++] = 0x3929e8f5; logTblLookup[i++] = 0x3f869223; logTblLookup[i++] = 0x3f24a000; logTblLookup[i++] = 0x37aa0e8c; logTblLookup[i++] = 0x3f864b8a; logTblLookup[i++] =
0x3f252000; logTblLookup[i++] = 0x38f85db0; logTblLookup[i++] = 0x3f86053c; logTblLookup[i++] = 0x3f25a000; logTblLookup[i++] = 0x395eb4ab; logTblLookup[i++] = 0x3f85bf37; logTblLookup[i++] = 0x3f263000; logTblLookup[i++] = 0x38735f9a; logTblLookup[i++] =
0x3f85797c; logTblLookup[i++] = 0x3f26b000; logTblLookup[i++] = 0x39169d1d; logTblLookup[i++] = 0x3f853408; logTblLookup[i++] = 0x3f273000; logTblLookup[i++] = 0x396c08dc; logTblLookup[i++] = 0x3f84eedd; logTblLookup[i++] = 0x3f27c000; logTblLookup[i++] =
0x38747ea0; logTblLookup[i++] = 0x3f84a9fa; logTblLookup[i++] = 0x3f284000; logTblLookup[i++] = 0x3909e601; logTblLookup[i++] = 0x3f84655e; logTblLookup[i++] = 0x3f28c000; logTblLookup[i++] = 0x3952605d; logTblLookup[i++] = 0x3f842108; logTblLookup[i++] =
0x3f295000; logTblLookup[i++] = 0x37b4996f; logTblLookup[i++] = 0x3f83dcf9; logTblLookup[i++] = 0x3f29d000; logTblLookup[i++] = 0x38ad05ba; logTblLookup[i++] = 0x3f839930; logTblLookup[i++] = 0x3f2a5000; logTblLookup[i++] = 0x391233cd; logTblLookup[i++] =
0x3f8355ad; logTblLookup[i++] = 0x3f2ad000; logTblLookup[i++] = 0x3949aa5a; logTblLookup[i++] = 0x3f83126f; logTblLookup[i++] = 0x3f2b5000; logTblLookup[i++] = 0x397ceada; logTblLookup[i++] = 0x3f82cf75; logTblLookup[i++] = 0x3f2be000; logTblLookup[i++] =
0x382fe66e; logTblLookup[i++] = 0x3f828cc0; logTblLookup[i++] = 0x3f2c6000; logTblLookup[i++] = 0x38adb5cd; logTblLookup[i++] = 0x3f824a4e; logTblLookup[i++] = 0x3f2ce000; logTblLookup[i++] = 0x38fb25fb; logTblLookup[i++] = 0x3f820821; logTblLookup[i++] =
0x3f2d6000; logTblLookup[i++] = 0x3920261b; logTblLookup[i++] = 0x3f81c636; logTblLookup[i++] = 0x3f2de000; logTblLookup[i++] = 0x393e9874; logTblLookup[i++] = 0x3f81848e; logTblLookup[i++] = 0x3f2e6000; logTblLookup[i++] = 0x3958ee36; logTblLookup[i++] =
0x3f814328; logTblLookup[i++] = 0x3f2ee000; logTblLookup[i++] = 0x396f2b8a; logTblLookup[i++] = 0x3f810204; logTblLookup[i++] = 0x3f2f7000; logTblLookup[i++] = 0x35aa4906; logTblLookup[i++] = 0x3f80c122; logTblLookup[i++] = 0x3f2ff000; logTblLookup[i++] =
0x3776d68c; logTblLookup[i++] = 0x3f808081; logTblLookup[i++] = 0x3f307000; logTblLookup[i++] = 0x37cbd11e; logTblLookup[i++] = 0x3f804020; logTblLookup[i++] = 0x3f30f000; logTblLookup[i++] = 0x37fbf692; logTblLookup[i++] = 0x3f800000; logTblLookup[i++] =
0x3f317000; logTblLookup[i++] = 0x3805fdf4;

            return logTblLookup;
        }

        private static uint[] _logTblLookup = InitLog();

        [MethodImpl(MaxOpt)]
        private static unsafe float CoreFastLog(float x)
        {
            [MethodImpl(MaxOpt)]
            static unsafe uint asuint(float x)
            {
#if SSE
                if (Sse.IsSupported)
                    return Vector128.CreateScalarUnsafe(x).AsUInt32().ToScalar(); // ToScalar "relies" on Sse (the fallback is garbage)
                else
#endif
                return *(uint*) &x; // this produces bad codegen on < net5
            }

            [MethodImpl(MaxOpt)]
            static unsafe float asfloat(uint x)
            {
#if SSE
                if (Sse.IsSupported)
                    return Vector128.CreateScalarUnsafe(x).AsSingle().ToScalar(); // ToScalar "relies" on Sse (the fallback is garbage)
                else
#endif
                return *(float*) &x; // this produces bad codegen on < net5
            }

            uint ux = asuint(x);


            if (ux - 0x00800000 < 0x7f800000 - 0x00800000) // inverted because likeliness
            {
                goto EndCheck;
            }
            else
            {
                /* x < 0x1p-126 or inf or nan. */
                if (ux * 2 == 0)                /* log(0) = -inf */
                    return float.NegativeInfinity;
                if (ux == 0x7f800000)           /* log(inf) = inf */
                    return x;
                if ((ux & 0x80000000) > 0 || ux * 2 >= 0xff000000)
                    return float.NaN;

                /*
                 * 'x' has to be denormal, Normalize it
                 * there is a possibility that only the last (23'rd) bit is set
                 * Hence multiply by 2^23 to bring to 1.xxxxx format.
                 */
                ux = asuint(x * 8388608);
                ux -= 23 << 23;
            }

        EndCheck:
            const int EXPSHIFTBITS_SP32 = 23; // number of bits to shift left to get the exponent
            // exponent bias, calculated as (2^(k-1)) - 1, were k = number of bits used to encode the exponent
            const int EMAX_SP32 = 127;
            const int MANTBITS_SP32 = 0x007fffff; // the bits the mantissa takes up

            int expo = (int) ((ux >> EXPSHIFTBITS_SP32) - EMAX_SP32);
            float f_expo = (float) expo;

            const uint NEAR_ONE_LO = 0b111111011100000000000000000000; // BitConverter.SingleToInt32Bits(1 - 1 * 0.0625f);
            const uint NEAR_ONE_HI = 0b111111110101010000000000000000; // BitConverter.SingleToInt32Bits(1 + 1.0625f * 0.0625f);

            // Values not very close to 1, !(e^(-1/16) <= x <= e^(1/16)
            if (ux - NEAR_ONE_LO >= NEAR_ONE_HI - NEAR_ONE_LO)
            {
                /*
                 * Here onwards, 'x' is neither -ve, nor close to 1
                */
                uint mant, mant1, idx;
                float y, f, finv, r, r2, q, w;

                const int MASK_MANT_ALL7 = 0b_1111111_10000000_00000000;
                // const int MASK_MANT8 = 0x00008000;
                mant = ux & MANTBITS_SP32;
                mant1 = ux & MASK_MANT_ALL7;
                /*This step is needed for more accuracy */
                /* mant1 += ((ux & MASK_MANT8) << 1); */

                const int LOGF_N = 8;
                idx = mant1 >> (EXPSHIFTBITS_SP32 - LOGF_N);

                const int HALFEXPBITS_SP32 = 0b_111111_00000000_00000000_00000000;
                y = asfloat(mant | HALFEXPBITS_SP32);
                f = asfloat(mant1 | HALFEXPBITS_SP32);

                float f_128_head;
                float f_128_tail;
#if POH
                var tbl = ((uint*)Unsafe.AsPointer(ref _logTblLookup[0])) + (idx * 3);
                finv = asfloat(tbl[0]);
                f_128_head = asfloat(tbl[1]);
                f_128_tail = asfloat(tbl[2]);
#else
                fixed (uint* tbl = _logTblLookup)
                {
                    var p = tbl + (idx * 3);
                    finv = asfloat(p[0]);
                    f_128_head = asfloat(p[1]);
                    f_128_tail = asfloat(p[2]);
                }
#endif

                r = (f - y) * finv;
                const float C1 = .5f;
                const float C2 = 3.333333432674407958984375E-1f; // 1/3

                r2 = r * r;                 /* r^2 */
                q = r + (r2 * (C1 + r * C2));

                const float LOG2_TAIL = 1.18725025653839111328f * 0.00000762939f;
                q = (f_expo * LOG2_TAIL) - q;

                const float LOG2_HEAD = 1.3862762451171875f * 0.5f;
                w = (LOG2_HEAD * f_expo) + f_128_head;

                q = f_128_tail + q + w;

                return q;

            }
            else
            {
                [MethodImpl(MaxOpt)]
                static float InlineLog1Pf(float x)
                {
                    float r, r2, w;

                    r = x - 1.0f;

                    w = r / (2.0f + r);

                    float correction = w * r;

                    w += w;

                    float w2 = w * w;

                    const float A1 = 8.33333333333317923934e-02f;
                    const float A2 = 1.25000000037717509602e-02f;

                    r2 = (w * w2 * (A1 + A2 * w2)) - correction;

                    float f = r2 + r;

                    return f;
                }

                return InlineLog1Pf(x);
            }
        }
    }
}