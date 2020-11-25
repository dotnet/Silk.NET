// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using static Silk.NET.Numerics.Helper;

namespace Silk.NET.Numerics
{
    public static partial class Operations
    {
        private static void InitLog()
        {
            _logTblLookup = GC.AllocateUninitializedArray<uint>(771, true);
            int i = 0;
            _logTblLookup[i++] = 0x40000000; _logTblLookup[i++] =  0x0; _logTblLookup[i++] =  0x0; _logTblLookup[i++] =  0x3fff00ff; _logTblLookup[i++] =  0x3b7f8000; _logTblLookup[i++] =  0x32aa2b11; _logTblLookup[i++] =  0x3ffe03f8; _logTblLookup[i++] =  0x3bff0000; _logTblLookup[i++] =  0x3429ac42; _logTblLookup[i++] = 
            0x3ffd08e5; _logTblLookup[i++] =  0x3c3ee000; _logTblLookup[i++] =  0x350ebf02; _logTblLookup[i++] =  0x3ffc0fc1; _logTblLookup[i++] =  0x3c7e0000; _logTblLookup[i++] =  0x35a8b0fc; _logTblLookup[i++] =  0x3ffb1885; _logTblLookup[i++] =  0x3c9e7000; _logTblLookup[i++] = 
            0x36244347; _logTblLookup[i++] =  0x3ffa232d; _logTblLookup[i++] =  0x3cbdc000; _logTblLookup[i++] =  0x368d83eb; _logTblLookup[i++] =  0x3ff92fb2; _logTblLookup[i++] =  0x3cdcf000; _logTblLookup[i++] =  0x36e013d8; _logTblLookup[i++] =  0x3ff83e10; _logTblLookup[i++] = 
            0x3cfc1000; _logTblLookup[i++] =  0x361b0e78; _logTblLookup[i++] =  0x3ff74e40; _logTblLookup[i++] =  0x3d0d8000; _logTblLookup[i++] =  0x36d98924; _logTblLookup[i++] =  0x3ff6603e; _logTblLookup[i++] =  0x3d1cf000; _logTblLookup[i++] =  0x3687b9ff; _logTblLookup[i++] = 
            0x3ff57404; _logTblLookup[i++] =  0x3d2c5000; _logTblLookup[i++] =  0x36375f92; _logTblLookup[i++] =  0x3ff4898d; _logTblLookup[i++] =  0x3d3ba000; _logTblLookup[i++] =  0x3631ec66; _logTblLookup[i++] =  0x3ff3a0d5; _logTblLookup[i++] =  0x3d4ae000; _logTblLookup[i++] = 
            0x36830ec9; _logTblLookup[i++] =  0x3ff2b9d6; _logTblLookup[i++] =  0x3d5a1000; _logTblLookup[i++] =  0x36dd7119; _logTblLookup[i++] =  0x3ff1d48c; _logTblLookup[i++] =  0x3d693000; _logTblLookup[i++] =  0x3735c56e; _logTblLookup[i++] =  0x3ff0f0f1; _logTblLookup[i++] = 
            0x3d785000; _logTblLookup[i++] =  0x35c30046; _logTblLookup[i++] =  0x3ff00f01; _logTblLookup[i++] =  0x3d83a000; _logTblLookup[i++] =  0x37cc1acc; _logTblLookup[i++] =  0x3fef2eb7; _logTblLookup[i++] =  0x3d8b2000; _logTblLookup[i++] =  0x379b7752; _logTblLookup[i++] = 
            0x3fee500f; _logTblLookup[i++] =  0x3d929000; _logTblLookup[i++] =  0x37fb1785; _logTblLookup[i++] =  0x3fed7304; _logTblLookup[i++] =  0x3d9a0000; _logTblLookup[i++] =  0x37ebcb0e; _logTblLookup[i++] =  0x3fec9791; _logTblLookup[i++] =  0x3da17000; _logTblLookup[i++] = 
            0x375cbea6; _logTblLookup[i++] =  0x3febbdb3; _logTblLookup[i++] =  0x3da8d000; _logTblLookup[i++] =  0x37839f83; _logTblLookup[i++] =  0x3feae564; _logTblLookup[i++] =  0x3db03000; _logTblLookup[i++] =  0x36b1526f; _logTblLookup[i++] =  0x3fea0ea1; _logTblLookup[i++] = 
            0x3db78000; _logTblLookup[i++] =  0x37528ae5; _logTblLookup[i++] =  0x3fe93965; _logTblLookup[i++] =  0x3dbed000; _logTblLookup[i++] =  0x36ecdaf6; _logTblLookup[i++] =  0x3fe865ac; _logTblLookup[i++] =  0x3dc61000; _logTblLookup[i++] =  0x37a2eb19; _logTblLookup[i++] = 
            0x3fe79373; _logTblLookup[i++] =  0x3dcd5000; _logTblLookup[i++] =  0x37a12310; _logTblLookup[i++] =  0x3fe6c2b4; _logTblLookup[i++] =  0x3dd49000; _logTblLookup[i++] =  0x36da7496; _logTblLookup[i++] =  0x3fe5f36d; _logTblLookup[i++] =  0x3ddbc000; _logTblLookup[i++] = 
            0x37482bb1; _logTblLookup[i++] =  0x3fe52598; _logTblLookup[i++] =  0x3de2f000; _logTblLookup[i++] =  0x36a91eb8; _logTblLookup[i++] =  0x3fe45933; _logTblLookup[i++] =  0x3dea1000; _logTblLookup[i++] =  0x3789eb36; _logTblLookup[i++] =  0x3fe38e39; _logTblLookup[i++] = 
            0x3df13000; _logTblLookup[i++] =  0x3783b715; _logTblLookup[i++] =  0x3fe2c4a7; _logTblLookup[i++] =  0x3df85000; _logTblLookup[i++] =  0x36430046; _logTblLookup[i++] =  0x3fe1fc78; _logTblLookup[i++] =  0x3dff6000; _logTblLookup[i++] =  0x371131dc; _logTblLookup[i++] = 
            0x3fe135aa; _logTblLookup[i++] =  0x3e033000; _logTblLookup[i++] =  0x380a8965; _logTblLookup[i++] =  0x3fe07038; _logTblLookup[i++] =  0x3e06b000; _logTblLookup[i++] =  0x383f3e68; _logTblLookup[i++] =  0x3fdfac1f; _logTblLookup[i++] =  0x3e0a3000; _logTblLookup[i++] = 
            0x3842c234; _logTblLookup[i++] =  0x3fdee95c; _logTblLookup[i++] =  0x3e0db000; _logTblLookup[i++] =  0x38156a98; _logTblLookup[i++] =  0x3fde27eb; _logTblLookup[i++] =  0x3e113000; _logTblLookup[i++] =  0x375e3215; _logTblLookup[i++] =  0x3fdd67c9; _logTblLookup[i++] = 
            0x3e14a000; _logTblLookup[i++] =  0x38297c10; _logTblLookup[i++] =  0x3fdca8f1; _logTblLookup[i++] =  0x3e181000; _logTblLookup[i++] =  0x386b8c72; _logTblLookup[i++] =  0x3fdbeb62; _logTblLookup[i++] =  0x3e1b8000; _logTblLookup[i++] =  0x387e100f; _logTblLookup[i++] = 
            0x3fdb2f17; _logTblLookup[i++] =  0x3e1ef000; _logTblLookup[i++] =  0x38615876; _logTblLookup[i++] =  0x3fda740e; _logTblLookup[i++] =  0x3e226000; _logTblLookup[i++] =  0x3815b666; _logTblLookup[i++] =  0x3fd9ba42; _logTblLookup[i++] =  0x3e25d000; _logTblLookup[i++] = 
            0x36dbce69; _logTblLookup[i++] =  0x3fd901b2; _logTblLookup[i++] =  0x3e293000; _logTblLookup[i++] =  0x37e5e3a2; _logTblLookup[i++] =  0x3fd84a5a; _logTblLookup[i++] =  0x3e2c9000; _logTblLookup[i++] =  0x381c6ccc; _logTblLookup[i++] =  0x3fd79436; _logTblLookup[i++] = 
            0x3e2ff000; _logTblLookup[i++] =  0x38183854; _logTblLookup[i++] =  0x3fd6df44; _logTblLookup[i++] =  0x3e335000; _logTblLookup[i++] =  0x37cd4273; _logTblLookup[i++] =  0x3fd62b81; _logTblLookup[i++] =  0x3e36b000; _logTblLookup[i++] =  0x35fe719d; _logTblLookup[i++] = 
            0x3fd578e9; _logTblLookup[i++] =  0x3e3a0000; _logTblLookup[i++] =  0x37f8f540; _logTblLookup[i++] =  0x3fd4c77b; _logTblLookup[i++] =  0x3e3d5000; _logTblLookup[i++] =  0x38448108; _logTblLookup[i++] =  0x3fd41733; _logTblLookup[i++] =  0x3e40a000; _logTblLookup[i++] = 
            0x386050a2; _logTblLookup[i++] =  0x3fd3680d; _logTblLookup[i++] =  0x3e43f000; _logTblLookup[i++] =  0x38503290; _logTblLookup[i++] =  0x3fd2ba08; _logTblLookup[i++] =  0x3e474000; _logTblLookup[i++] =  0x38146f44; _logTblLookup[i++] =  0x3fd20d21; _logTblLookup[i++] = 
            0x3e4a9000; _logTblLookup[i++] =  0x373539e9; _logTblLookup[i++] =  0x3fd16154; _logTblLookup[i++] =  0x3e4dd000; _logTblLookup[i++] =  0x381b173f; _logTblLookup[i++] =  0x3fd0b6a0; _logTblLookup[i++] =  0x3e511000; _logTblLookup[i++] =  0x385e0ff1; _logTblLookup[i++] = 
            0x3fd00d01; _logTblLookup[i++] =  0x3e545000; _logTblLookup[i++] =  0x38767e44; _logTblLookup[i++] =  0x3fcf6475; _logTblLookup[i++] =  0x3e579000; _logTblLookup[i++] =  0x3864a740; _logTblLookup[i++] =  0x3fcebcf9; _logTblLookup[i++] =  0x3e5ad000; _logTblLookup[i++] = 
            0x3828cf48; _logTblLookup[i++] =  0x3fce168a; _logTblLookup[i++] =  0x3e5e1000; _logTblLookup[i++] =  0x3786742e; _logTblLookup[i++] =  0x3fcd7127; _logTblLookup[i++] =  0x3e614000; _logTblLookup[i++] =  0x38342ac6; _logTblLookup[i++] =  0x3fcccccd; _logTblLookup[i++] = 
            0x3e647000; _logTblLookup[i++] =  0x387be3cd; _logTblLookup[i++] =  0x3fcc2978; _logTblLookup[i++] =  0x3e67b000; _logTblLookup[i++] =  0x36d53827; _logTblLookup[i++] =  0x3fcb8728; _logTblLookup[i++] =  0x3e6ae000; _logTblLookup[i++] =  0x3685ad3f; _logTblLookup[i++] = 
            0x3fcae5d8; _logTblLookup[i++] =  0x3e6e0000; _logTblLookup[i++] =  0x385e5056; _logTblLookup[i++] =  0x3fca4588; _logTblLookup[i++] =  0x3e713000; _logTblLookup[i++] =  0x3803b715; _logTblLookup[i++] =  0x3fc9a634; _logTblLookup[i++] =  0x3e746000; _logTblLookup[i++] = 
            0x3494aa97; _logTblLookup[i++] =  0x3fc907da; _logTblLookup[i++] =  0x3e778000; _logTblLookup[i++] =  0x37adcbdc; _logTblLookup[i++] =  0x3fc86a79; _logTblLookup[i++] =  0x3e7aa000; _logTblLookup[i++] =  0x38052b26; _logTblLookup[i++] =  0x3fc7ce0c; _logTblLookup[i++] = 
            0x3e7dc000; _logTblLookup[i++] =  0x380c36af; _logTblLookup[i++] =  0x3fc73294; _logTblLookup[i++] =  0x3e807000; _logTblLookup[i++] =  0x37d88b5b; _logTblLookup[i++] =  0x3fc6980c; _logTblLookup[i++] =  0x3e820000; _logTblLookup[i++] =  0x371652d3; _logTblLookup[i++] = 
            0x3fc5fe74; _logTblLookup[i++] =  0x3e838000; _logTblLookup[i++] =  0x38dc2fe7; _logTblLookup[i++] =  0x3fc565c8; _logTblLookup[i++] =  0x3e851000; _logTblLookup[i++] =  0x3892713a; _logTblLookup[i++] =  0x3fc4ce08; _logTblLookup[i++] =  0x3e86a000; _logTblLookup[i++] = 
            0x37d6af35; _logTblLookup[i++] =  0x3fc43730; _logTblLookup[i++] =  0x3e882000; _logTblLookup[i++] =  0x38c5fcd7; _logTblLookup[i++] =  0x3fc3a13e; _logTblLookup[i++] =  0x3e89b000; _logTblLookup[i++] =  0x38070294; _logTblLookup[i++] =  0x3fc30c31; _logTblLookup[i++] = 
            0x3e8b3000; _logTblLookup[i++] =  0x38ae55d6; _logTblLookup[i++] =  0x3fc27806; _logTblLookup[i++] =  0x3e8cc000; _logTblLookup[i++] =  0x3652dd42; _logTblLookup[i++] =  0x3fc1e4bc; _logTblLookup[i++] =  0x3e8e4000; _logTblLookup[i++] =  0x3818c16a; _logTblLookup[i++] = 
            0x3fc15250; _logTblLookup[i++] =  0x3e8fc000; _logTblLookup[i++] =  0x387f9e49; _logTblLookup[i++] =  0x3fc0c0c1; _logTblLookup[i++] =  0x3e914000; _logTblLookup[i++] =  0x38a0fde8; _logTblLookup[i++] =  0x3fc0300c; _logTblLookup[i++] =  0x3e92c000; _logTblLookup[i++] = 
            0x38b00870; _logTblLookup[i++] =  0x3fbfa030; _logTblLookup[i++] =  0x3e944000; _logTblLookup[i++] =  0x38ad09ef; _logTblLookup[i++] =  0x3fbf112b; _logTblLookup[i++] =  0x3e95c000; _logTblLookup[i++] =  0x38981d5c; _logTblLookup[i++] =  0x3fbe82fa; _logTblLookup[i++] = 
            0x3e974000; _logTblLookup[i++] =  0x3862bae1; _logTblLookup[i++] =  0x3fbdf59d; _logTblLookup[i++] =  0x3e98c000; _logTblLookup[i++] =  0x37e392a9; _logTblLookup[i++] =  0x3fbd6910; _logTblLookup[i++] =  0x3e9a3000; _logTblLookup[i++] =  0x38eecd4c; _logTblLookup[i++] = 
            0x3fbcdd53; _logTblLookup[i++] =  0x3e9bb000; _logTblLookup[i++] =  0x38933160; _logTblLookup[i++] =  0x3fbc5264; _logTblLookup[i++] =  0x3e9d3000; _logTblLookup[i++] =  0x3798aad3; _logTblLookup[i++] =  0x3fbbc841; _logTblLookup[i++] =  0x3e9ea000; _logTblLookup[i++] = 
            0x38a7d2e1; _logTblLookup[i++] =  0x3fbb3ee7; _logTblLookup[i++] =  0x3ea02000; _logTblLookup[i++] =  0x37421a1b; _logTblLookup[i++] =  0x3fbab656; _logTblLookup[i++] =  0x3ea19000; _logTblLookup[i++] =  0x386f2a05; _logTblLookup[i++] =  0x3fba2e8c; _logTblLookup[i++] = 
            0x3ea30000; _logTblLookup[i++] =  0x38c5e10e; _logTblLookup[i++] =  0x3fb9a786; _logTblLookup[i++] =  0x3ea48000; _logTblLookup[i++] =  0x35d00801; _logTblLookup[i++] =  0x3fb92144; _logTblLookup[i++] =  0x3ea5f000; _logTblLookup[i++] =  0x37bf2aef; _logTblLookup[i++] = 
            0x3fb89bc3; _logTblLookup[i++] =  0x3ea76000; _logTblLookup[i++] =  0x38173260; _logTblLookup[i++] =  0x3fb81703; _logTblLookup[i++] =  0x3ea8d000; _logTblLookup[i++] =  0x382d872e; _logTblLookup[i++] =  0x3fb79301; _logTblLookup[i++] =  0x3eaa4000; _logTblLookup[i++] = 
            0x3822c3ae; _logTblLookup[i++] =  0x3fb70fbb; _logTblLookup[i++] =  0x3eabb000; _logTblLookup[i++] =  0x37ee2e8b; _logTblLookup[i++] =  0x3fb68d31; _logTblLookup[i++] =  0x3ead2000; _logTblLookup[i++] =  0x372ac3d3; _logTblLookup[i++] =  0x3fb60b61; _logTblLookup[i++] = 
            0x3eae8000; _logTblLookup[i++] =  0x38dedfac; _logTblLookup[i++] =  0x3fb58a48; _logTblLookup[i++] =  0x3eaff000; _logTblLookup[i++] =  0x38983854; _logTblLookup[i++] =  0x3fb509e7; _logTblLookup[i++] =  0x3eb16000; _logTblLookup[i++] =  0x3802f2ba; _logTblLookup[i++] = 
            0x3fb48a3a; _logTblLookup[i++] =  0x3eb2c000; _logTblLookup[i++] =  0x38dab982; _logTblLookup[i++] =  0x3fb40b41; _logTblLookup[i++] =  0x3eb43000; _logTblLookup[i++] =  0x38481e9b; _logTblLookup[i++] =  0x3fb38cfa; _logTblLookup[i++] =  0x3eb59000; _logTblLookup[i++] = 
            0x38dd911b; _logTblLookup[i++] =  0x3fb30f63; _logTblLookup[i++] =  0x3eb70000; _logTblLookup[i++] =  0x380eaa2c; _logTblLookup[i++] =  0x3fb2927c; _logTblLookup[i++] =  0x3eb86000; _logTblLookup[i++] =  0x38a1713c; _logTblLookup[i++] =  0x3fb21643; _logTblLookup[i++] = 
            0x3eb9c000; _logTblLookup[i++] =  0x38ebfb5e; _logTblLookup[i++] =  0x3fb19ab6; _logTblLookup[i++] =  0x3ebb3000; _logTblLookup[i++] =  0x379c2474; _logTblLookup[i++] =  0x3fb11fd4; _logTblLookup[i++] =  0x3ebc9000; _logTblLookup[i++] =  0x38255fdd; _logTblLookup[i++] = 
            0x3fb0a59b; _logTblLookup[i++] =  0x3ebdf000; _logTblLookup[i++] =  0x385e0a38; _logTblLookup[i++] =  0x3fb02c0b; _logTblLookup[i++] =  0x3ebf5000; _logTblLookup[i++] =  0x38783b83; _logTblLookup[i++] =  0x3fafb322; _logTblLookup[i++] =  0x3ec0b000; _logTblLookup[i++] = 
            0x38741da1; _logTblLookup[i++] =  0x3faf3ade; _logTblLookup[i++] =  0x3ec21000; _logTblLookup[i++] =  0x3851da1f; _logTblLookup[i++] =  0x3faec33e; _logTblLookup[i++] =  0x3ec37000; _logTblLookup[i++] =  0x38119a33; _logTblLookup[i++] =  0x3fae4c41; _logTblLookup[i++] = 
            0x3ec4d000; _logTblLookup[i++] =  0x374e1b05; _logTblLookup[i++] =  0x3fadd5e6; _logTblLookup[i++] =  0x3ec62000; _logTblLookup[i++] =  0x38dbe42c; _logTblLookup[i++] =  0x3fad602b; _logTblLookup[i++] =  0x3ec78000; _logTblLookup[i++] =  0x388f439b; _logTblLookup[i++] = 
            0x3faceb10; _logTblLookup[i++] =  0x3ec8e000; _logTblLookup[i++] =  0x37cfd68b; _logTblLookup[i++] =  0x3fac7692; _logTblLookup[i++] =  0x3eca3000; _logTblLookup[i++] =  0x38ca0e11; _logTblLookup[i++] =  0x3fac02b0; _logTblLookup[i++] =  0x3ecb9000; _logTblLookup[i++] = 
            0x38234113; _logTblLookup[i++] =  0x3fab8f6a; _logTblLookup[i++] =  0x3ecce000; _logTblLookup[i++] =  0x38cac08c; _logTblLookup[i++] =  0x3fab1cbe; _logTblLookup[i++] =  0x3ece4000; _logTblLookup[i++] =  0x37d605b8; _logTblLookup[i++] =  0x3faaaaab; _logTblLookup[i++] = 
            0x3ecf9000; _logTblLookup[i++] =  0x3891f660; _logTblLookup[i++] =  0x3faa392f; _logTblLookup[i++] =  0x3ed0e000; _logTblLookup[i++] =  0x38e0326b; _logTblLookup[i++] =  0x3fa9c84a; _logTblLookup[i++] =  0x3ed24000; _logTblLookup[i++] =  0x378121cb; _logTblLookup[i++] = 
            0x3fa957fb; _logTblLookup[i++] =  0x3ed39000; _logTblLookup[i++] =  0x3824966c; _logTblLookup[i++] =  0x3fa8e83f; _logTblLookup[i++] =  0x3ed4e000; _logTblLookup[i++] =  0x386c9a9a; _logTblLookup[i++] =  0x3fa87917; _logTblLookup[i++] =  0x3ed63000; _logTblLookup[i++] = 
            0x388c612c; _logTblLookup[i++] =  0x3fa80a81; _logTblLookup[i++] =  0x3ed78000; _logTblLookup[i++] =  0x38949924; _logTblLookup[i++] =  0x3fa79c7b; _logTblLookup[i++] =  0x3ed8d000; _logTblLookup[i++] =  0x388f075f; _logTblLookup[i++] =  0x3fa72f05; _logTblLookup[i++] = 
            0x3eda2000; _logTblLookup[i++] =  0x38777bcd; _logTblLookup[i++] =  0x3fa6c21e; _logTblLookup[i++] =  0x3edb7000; _logTblLookup[i++] =  0x38359d3d; _logTblLookup[i++] =  0x3fa655c4; _logTblLookup[i++] =  0x3edcc000; _logTblLookup[i++] =  0x37b12d26; _logTblLookup[i++] = 
            0x3fa5e9f7; _logTblLookup[i++] =  0x3ede0000; _logTblLookup[i++] =  0x38f04587; _logTblLookup[i++] =  0x3fa57eb5; _logTblLookup[i++] =  0x3edf5000; _logTblLookup[i++] =  0x38a6ced4; _logTblLookup[i++] =  0x3fa513fd; _logTblLookup[i++] =  0x3ee0a000; _logTblLookup[i++] = 
            0x381ff116; _logTblLookup[i++] =  0x3fa4a9cf; _logTblLookup[i++] =  0x3ee1e000; _logTblLookup[i++] =  0x38ebd3e7; _logTblLookup[i++] =  0x3fa44029; _logTblLookup[i++] =  0x3ee33000; _logTblLookup[i++] =  0x3874e3ff; _logTblLookup[i++] =  0x3fa3d70a; _logTblLookup[i++] = 
            0x3ee47000; _logTblLookup[i++] =  0x38fbe3cd; _logTblLookup[i++] =  0x3fa36e72; _logTblLookup[i++] =  0x3ee5c000; _logTblLookup[i++] =  0x3860744d; _logTblLookup[i++] =  0x3fa3065e; _logTblLookup[i++] =  0x3ee70000; _logTblLookup[i++] =  0x38d785c3; _logTblLookup[i++] = 
            0x3fa29ecf; _logTblLookup[i++] =  0x3ee85000; _logTblLookup[i++] =  0x37c75ce4; _logTblLookup[i++] =  0x3fa237c3; _logTblLookup[i++] =  0x3ee99000; _logTblLookup[i++] =  0x387e7e01; _logTblLookup[i++] =  0x3fa1d13a; _logTblLookup[i++] =  0x3eead000; _logTblLookup[i++] = 
            0x38bfcd71; _logTblLookup[i++] =  0x3fa16b31; _logTblLookup[i++] =  0x3eec1000; _logTblLookup[i++] =  0x38f392c5; _logTblLookup[i++] =  0x3fa105a9; _logTblLookup[i++] =  0x3eed6000; _logTblLookup[i++] =  0x3754f8b1; _logTblLookup[i++] =  0x3fa0a0a1; _logTblLookup[i++] = 
            0x3eeea000; _logTblLookup[i++] =  0x37d40984; _logTblLookup[i++] =  0x3fa03c17; _logTblLookup[i++] =  0x3eefe000; _logTblLookup[i++] =  0x38059907; _logTblLookup[i++] =  0x3f9fd80a; _logTblLookup[i++] =  0x3ef12000; _logTblLookup[i++] =  0x38081a7c; _logTblLookup[i++] = 
            0x3f9f747a; _logTblLookup[i++] =  0x3ef26000; _logTblLookup[i++] =  0x37e350d1; _logTblLookup[i++] =  0x3f9f1166; _logTblLookup[i++] =  0x3ef3a000; _logTblLookup[i++] =  0x3784c3ad; _logTblLookup[i++] =  0x3f9eaecd; _logTblLookup[i++] =  0x3ef4d000; _logTblLookup[i++] = 
            0x38fd32cc; _logTblLookup[i++] =  0x3f9e4cad; _logTblLookup[i++] =  0x3ef61000; _logTblLookup[i++] =  0x38cce923; _logTblLookup[i++] =  0x3f9deb07; _logTblLookup[i++] =  0x3ef75000; _logTblLookup[i++] =  0x38906320; _logTblLookup[i++] =  0x3f9d89d9; _logTblLookup[i++] = 
            0x3ef89000; _logTblLookup[i++] =  0x380f5faf; _logTblLookup[i++] =  0x3f9d2922; _logTblLookup[i++] =  0x3ef9c000; _logTblLookup[i++] =  0x38f2de41; _logTblLookup[i++] =  0x3f9cc8e1; _logTblLookup[i++] =  0x3efb0000; _logTblLookup[i++] =  0x3891fd38; _logTblLookup[i++] = 
            0x3f9c6917; _logTblLookup[i++] =  0x3efc4000; _logTblLookup[i++] =  0x37946dfd; _logTblLookup[i++] =  0x3f9c09c1; _logTblLookup[i++] =  0x3efd7000; _logTblLookup[i++] =  0x38ac47bc; _logTblLookup[i++] =  0x3f9baadf; _logTblLookup[i++] =  0x3efeb000; _logTblLookup[i++] = 
            0x379e41ec; _logTblLookup[i++] =  0x3f9b4c70; _logTblLookup[i++] =  0x3effe000; _logTblLookup[i++] =  0x3897042c; _logTblLookup[i++] =  0x3f9aee73; _logTblLookup[i++] =  0x3f008000; _logTblLookup[i++] =  0x397d5893; _logTblLookup[i++] =  0x3f9a90e8; _logTblLookup[i++] = 
            0x3f012000; _logTblLookup[i++] =  0x392952d3; _logTblLookup[i++] =  0x3f9a33cd; _logTblLookup[i++] =  0x3f01c000; _logTblLookup[i++] =  0x389eefce; _logTblLookup[i++] =  0x3f99d723; _logTblLookup[i++] =  0x3f025000; _logTblLookup[i++] =  0x396fced5; _logTblLookup[i++] = 
            0x3f997ae7; _logTblLookup[i++] =  0x3f02f000; _logTblLookup[i++] =  0x390a5e93; _logTblLookup[i++] =  0x3f991f1a; _logTblLookup[i++] =  0x3f039000; _logTblLookup[i++] =  0x37f97073; _logTblLookup[i++] =  0x3f98c3bb; _logTblLookup[i++] =  0x3f042000; _logTblLookup[i++] = 
            0x392e4426; _logTblLookup[i++] =  0x3f9868c8; _logTblLookup[i++] =  0x3f04c000; _logTblLookup[i++] =  0x385e9eae; _logTblLookup[i++] =  0x3f980e41; _logTblLookup[i++] =  0x3f055000; _logTblLookup[i++] =  0x393b5f67; _logTblLookup[i++] =  0x3f97b426; _logTblLookup[i++] = 
            0x3f05f000; _logTblLookup[i++] =  0x3865c84a; _logTblLookup[i++] =  0x3f975a75; _logTblLookup[i++] =  0x3f068000; _logTblLookup[i++] =  0x3931e65d; _logTblLookup[i++] =  0x3f97012e; _logTblLookup[i++] =  0x3f072000; _logTblLookup[i++] =  0x38130ba4; _logTblLookup[i++] = 
            0x3f96a850; _logTblLookup[i++] =  0x3f07b000; _logTblLookup[i++] =  0x39120e4e; _logTblLookup[i++] =  0x3f964fda; _logTblLookup[i++] =  0x3f084000; _logTblLookup[i++] =  0x3979cf17; _logTblLookup[i++] =  0x3f95f7cc; _logTblLookup[i++] =  0x3f08e000; _logTblLookup[i++] = 
            0x38b81788; _logTblLookup[i++] =  0x3f95a025; _logTblLookup[i++] =  0x3f097000; _logTblLookup[i++] =  0x3938caca; _logTblLookup[i++] =  0x3f9548e5; _logTblLookup[i++] =  0x3f0a1000; _logTblLookup[i++] =  0x37809491; _logTblLookup[i++] =  0x3f94f209; _logTblLookup[i++] = 
            0x3f0aa000; _logTblLookup[i++] =  0x38c3d2f5; _logTblLookup[i++] =  0x3f949b93; _logTblLookup[i++] =  0x3f0b3000; _logTblLookup[i++] =  0x392e55d6; _logTblLookup[i++] =  0x3f944581; _logTblLookup[i++] =  0x3f0bc000; _logTblLookup[i++] =  0x39755dec; _logTblLookup[i++] = 
            0x3f93efd2; _logTblLookup[i++] =  0x3f0c6000; _logTblLookup[i++] =  0x385c1fec; _logTblLookup[i++] =  0x3f939a86; _logTblLookup[i++] =  0x3f0cf000; _logTblLookup[i++] =  0x38e6b468; _logTblLookup[i++] =  0x3f93459c; _logTblLookup[i++] =  0x3f0d8000; _logTblLookup[i++] = 
            0x392a5abf; _logTblLookup[i++] =  0x3f92f114; _logTblLookup[i++] =  0x3f0e1000; _logTblLookup[i++] =  0x395c0fb9; _logTblLookup[i++] =  0x3f929cec; _logTblLookup[i++] =  0x3f0eb000; _logTblLookup[i++] =  0x3707f33c; _logTblLookup[i++] =  0x3f924925; _logTblLookup[i++] = 
            0x3f0f4000; _logTblLookup[i++] =  0x383ebce1; _logTblLookup[i++] =  0x3f91f5bd; _logTblLookup[i++] =  0x3f0fd000; _logTblLookup[i++] =  0x38a34b87; _logTblLookup[i++] =  0x3f91a2b4; _logTblLookup[i++] =  0x3f106000; _logTblLookup[i++] =  0x38dcd193; _logTblLookup[i++] = 
            0x3f915009; _logTblLookup[i++] =  0x3f10f000; _logTblLookup[i++] =  0x3905fe33; _logTblLookup[i++] =  0x3f90fdbc; _logTblLookup[i++] =  0x3f118000; _logTblLookup[i++] =  0x39186bdf; _logTblLookup[i++] =  0x3f90abcc; _logTblLookup[i++] =  0x3f121000; _logTblLookup[i++] = 
            0x3925b7a4; _logTblLookup[i++] =  0x3f905a38; _logTblLookup[i++] =  0x3f12a000; _logTblLookup[i++] =  0x392de74c; _logTblLookup[i++] =  0x3f900901; _logTblLookup[i++] =  0x3f133000; _logTblLookup[i++] =  0x3931009a; _logTblLookup[i++] =  0x3f8fb824; _logTblLookup[i++] = 
            0x3f13c000; _logTblLookup[i++] =  0x392f0945; _logTblLookup[i++] =  0x3f8f67a2; _logTblLookup[i++] =  0x3f145000; _logTblLookup[i++] =  0x392806fb; _logTblLookup[i++] =  0x3f8f177a; _logTblLookup[i++] =  0x3f14e000; _logTblLookup[i++] =  0x391bff61; _logTblLookup[i++] = 
            0x3f8ec7ab; _logTblLookup[i++] =  0x3f157000; _logTblLookup[i++] =  0x390af813; _logTblLookup[i++] =  0x3f8e7835; _logTblLookup[i++] =  0x3f160000; _logTblLookup[i++] =  0x38e9ed45; _logTblLookup[i++] =  0x3f8e2918; _logTblLookup[i++] =  0x3f169000; _logTblLookup[i++] = 
            0x38b4012f; _logTblLookup[i++] =  0x3f8dda52; _logTblLookup[i++] =  0x3f172000; _logTblLookup[i++] =  0x38686dc8; _logTblLookup[i++] =  0x3f8d8be3; _logTblLookup[i++] =  0x3f17b000; _logTblLookup[i++] =  0x37aa6542; _logTblLookup[i++] =  0x3f8d3dcb; _logTblLookup[i++] = 
            0x3f183000; _logTblLookup[i++] =  0x396b99a8; _logTblLookup[i++] =  0x3f8cf009; _logTblLookup[i++] =  0x3f18c000; _logTblLookup[i++] =  0x393d07d4; _logTblLookup[i++] =  0x3f8ca29c; _logTblLookup[i++] =  0x3f195000; _logTblLookup[i++] =  0x39099c89; _logTblLookup[i++] = 
            0x3f8c5584; _logTblLookup[i++] =  0x3f19e000; _logTblLookup[i++] =  0x38a2ba33; _logTblLookup[i++] =  0x3f8c08c1; _logTblLookup[i++] =  0x3f1a7000; _logTblLookup[i++] =  0x37a27674; _logTblLookup[i++] =  0x3f8bbc51; _logTblLookup[i++] =  0x3f1af000; _logTblLookup[i++] = 
            0x395276ea; _logTblLookup[i++] =  0x3f8b7034; _logTblLookup[i++] =  0x3f1b8000; _logTblLookup[i++] =  0x390bdaa4; _logTblLookup[i++] =  0x3f8b246b; _logTblLookup[i++] =  0x3f1c1000; _logTblLookup[i++] =  0x3880fe58; _logTblLookup[i++] =  0x3f8ad8f3; _logTblLookup[i++] = 
            0x3f1c9000; _logTblLookup[i++] =  0x397069ab; _logTblLookup[i++] =  0x3f8a8dcd; _logTblLookup[i++] =  0x3f1d2000; _logTblLookup[i++] =  0x391b9f3f; _logTblLookup[i++] =  0x3f8a42f8; _logTblLookup[i++] =  0x3f1db000; _logTblLookup[i++] =  0x38844a00; _logTblLookup[i++] = 
            0x3f89f874; _logTblLookup[i++] =  0x3f1e3000; _logTblLookup[i++] =  0x3963fffc; _logTblLookup[i++] =  0x3f89ae41; _logTblLookup[i++] =  0x3f1ec000; _logTblLookup[i++] =  0x39013539; _logTblLookup[i++] =  0x3f89645c; _logTblLookup[i++] =  0x3f1f5000; _logTblLookup[i++] = 
            0x37ce4dad; _logTblLookup[i++] =  0x3f891ac7; _logTblLookup[i++] =  0x3f1fd000; _logTblLookup[i++] =  0x392dc269; _logTblLookup[i++] =  0x3f88d181; _logTblLookup[i++] =  0x3f206000; _logTblLookup[i++] =  0x38749102; _logTblLookup[i++] =  0x3f888889; _logTblLookup[i++] = 
            0x3f20e000; _logTblLookup[i++] =  0x3947f423; _logTblLookup[i++] =  0x3f883fde; _logTblLookup[i++] =  0x3f217000; _logTblLookup[i++] =  0x389c6de0; _logTblLookup[i++] =  0x3f87f781; _logTblLookup[i++] =  0x3f21f000; _logTblLookup[i++] =  0x394ff17d; _logTblLookup[i++] = 
            0x3f87af70; _logTblLookup[i++] =  0x3f228000; _logTblLookup[i++] =  0x389a5134; _logTblLookup[i++] =  0x3f8767ab; _logTblLookup[i++] =  0x3f230000; _logTblLookup[i++] =  0x3945e10e; _logTblLookup[i++] =  0x3f872033; _logTblLookup[i++] =  0x3f239000; _logTblLookup[i++] = 
            0x38687e67; _logTblLookup[i++] =  0x3f86d905; _logTblLookup[i++] =  0x3f241000; _logTblLookup[i++] =  0x3929e8f5; _logTblLookup[i++] =  0x3f869223; _logTblLookup[i++] =  0x3f24a000; _logTblLookup[i++] =  0x37aa0e8c; _logTblLookup[i++] =  0x3f864b8a; _logTblLookup[i++] = 
            0x3f252000; _logTblLookup[i++] =  0x38f85db0; _logTblLookup[i++] =  0x3f86053c; _logTblLookup[i++] =  0x3f25a000; _logTblLookup[i++] =  0x395eb4ab; _logTblLookup[i++] =  0x3f85bf37; _logTblLookup[i++] =  0x3f263000; _logTblLookup[i++] =  0x38735f9a; _logTblLookup[i++] = 
            0x3f85797c; _logTblLookup[i++] =  0x3f26b000; _logTblLookup[i++] =  0x39169d1d; _logTblLookup[i++] =  0x3f853408; _logTblLookup[i++] =  0x3f273000; _logTblLookup[i++] =  0x396c08dc; _logTblLookup[i++] =  0x3f84eedd; _logTblLookup[i++] =  0x3f27c000; _logTblLookup[i++] = 
            0x38747ea0; _logTblLookup[i++] =  0x3f84a9fa; _logTblLookup[i++] =  0x3f284000; _logTblLookup[i++] =  0x3909e601; _logTblLookup[i++] =  0x3f84655e; _logTblLookup[i++] =  0x3f28c000; _logTblLookup[i++] =  0x3952605d; _logTblLookup[i++] =  0x3f842108; _logTblLookup[i++] = 
            0x3f295000; _logTblLookup[i++] =  0x37b4996f; _logTblLookup[i++] =  0x3f83dcf9; _logTblLookup[i++] =  0x3f29d000; _logTblLookup[i++] =  0x38ad05ba; _logTblLookup[i++] =  0x3f839930; _logTblLookup[i++] =  0x3f2a5000; _logTblLookup[i++] =  0x391233cd; _logTblLookup[i++] = 
            0x3f8355ad; _logTblLookup[i++] =  0x3f2ad000; _logTblLookup[i++] =  0x3949aa5a; _logTblLookup[i++] =  0x3f83126f; _logTblLookup[i++] =  0x3f2b5000; _logTblLookup[i++] =  0x397ceada; _logTblLookup[i++] =  0x3f82cf75; _logTblLookup[i++] =  0x3f2be000; _logTblLookup[i++] = 
            0x382fe66e; _logTblLookup[i++] =  0x3f828cc0; _logTblLookup[i++] =  0x3f2c6000; _logTblLookup[i++] =  0x38adb5cd; _logTblLookup[i++] =  0x3f824a4e; _logTblLookup[i++] =  0x3f2ce000; _logTblLookup[i++] =  0x38fb25fb; _logTblLookup[i++] =  0x3f820821; _logTblLookup[i++] = 
            0x3f2d6000; _logTblLookup[i++] =  0x3920261b; _logTblLookup[i++] =  0x3f81c636; _logTblLookup[i++] =  0x3f2de000; _logTblLookup[i++] =  0x393e9874; _logTblLookup[i++] =  0x3f81848e; _logTblLookup[i++] =  0x3f2e6000; _logTblLookup[i++] =  0x3958ee36; _logTblLookup[i++] = 
            0x3f814328; _logTblLookup[i++] =  0x3f2ee000; _logTblLookup[i++] =  0x396f2b8a; _logTblLookup[i++] =  0x3f810204; _logTblLookup[i++] =  0x3f2f7000; _logTblLookup[i++] =  0x35aa4906; _logTblLookup[i++] =  0x3f80c122; _logTblLookup[i++] =  0x3f2ff000; _logTblLookup[i++] = 
            0x3776d68c; _logTblLookup[i++] =  0x3f808081; _logTblLookup[i++] =  0x3f307000; _logTblLookup[i++] =  0x37cbd11e; _logTblLookup[i++] =  0x3f804020; _logTblLookup[i++] =  0x3f30f000; _logTblLookup[i++] =  0x37fbf692; _logTblLookup[i++] =  0x3f800000; _logTblLookup[i++] = 
            0x3f317000; _logTblLookup[i++] = 0x3805fdf4;
        }

        private static uint[] _logTblLookup;

        [MethodImpl(MaxOpt)]
        private static unsafe float CoreFastLog(float x)
        {
            [MethodImpl(MaxOpt)]
            static unsafe uint asuint(float x)
            {
                if (Sse.IsSupported)
                    return Vector128.CreateScalarUnsafe(x).AsUInt32().ToScalar(); // ToScalar "relies" on Sse (the fallback is garbage)
                else
                    return *(uint*)&x; // this produces bad codegen on < net5
            }

            [MethodImpl(MaxOpt)]
            static unsafe float asfloat(uint x)
            {
                if (Sse.IsSupported)
                    return Vector128.CreateScalarUnsafe(x).AsSingle().ToScalar(); // ToScalar "relies" on Sse (the fallback is garbage)
                else
                    return *(float*)&x; // this produces bad codegen on < net5
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

            int expo = (int)((ux >> EXPSHIFTBITS_SP32) - EMAX_SP32);
            float f_expo = (float)expo;

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
                const int MASK_MANT8 = 0x00008000;
                mant = ux & MANTBITS_SP32;
                mant1 = ux & MASK_MANT_ALL7;
                /*This step is needed for more accuracy */
                /* mant1 += ((ux & MASK_MANT8) << 1); */

                const int LOGF_N = 8;
                idx = mant1 >> (EXPSHIFTBITS_SP32 - LOGF_N);

                const int HALFEXPBITS_SP32 = 0b_111111_00000000_00000000_00000000;
                y = asfloat(mant | HALFEXPBITS_SP32);
                f = asfloat(mant1 | HALFEXPBITS_SP32);

                var tbl = ((uint*)Unsafe.AsPointer(ref _logTblLookup[0])) + (idx * 3);
                finv = asfloat(tbl[0]);
                var f_128_head = asfloat(tbl[1]);
                var f_128_tail = asfloat(tbl[2]);

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
