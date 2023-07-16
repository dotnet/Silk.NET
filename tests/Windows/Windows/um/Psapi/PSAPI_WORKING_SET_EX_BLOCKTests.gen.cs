// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PSAPI_WORKING_SET_EX_BLOCK"/> struct.</summary>
public static unsafe partial class PSAPI_WORKING_SET_EX_BLOCKTests
{
    /// <summary>Validates that the <see cref = "PSAPI_WORKING_SET_EX_BLOCK"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PSAPI_WORKING_SET_EX_BLOCK>(), Is.EqualTo(sizeof(PSAPI_WORKING_SET_EX_BLOCK)));
    }

    /// <summary>Validates that the <see cref = "PSAPI_WORKING_SET_EX_BLOCK"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(PSAPI_WORKING_SET_EX_BLOCK).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "PSAPI_WORKING_SET_EX_BLOCK"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PSAPI_WORKING_SET_EX_BLOCK), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(PSAPI_WORKING_SET_EX_BLOCK), Is.EqualTo(4));
        }
    }
}