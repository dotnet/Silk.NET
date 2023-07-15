// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BASEBROWSERDATAXP"/> struct.</summary>
public static unsafe partial class BASEBROWSERDATAXPTests
{
    /// <summary>Validates that the <see cref = "BASEBROWSERDATAXP"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BASEBROWSERDATAXP>(), Is.EqualTo(sizeof(BASEBROWSERDATAXP)));
    }

    /// <summary>Validates that the <see cref = "BASEBROWSERDATAXP"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BASEBROWSERDATAXP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BASEBROWSERDATAXP"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BASEBROWSERDATAXP), Is.EqualTo(208));
        }
        else
        {
            Assert.That(sizeof(BASEBROWSERDATAXP), Is.EqualTo(128));
        }
    }
}