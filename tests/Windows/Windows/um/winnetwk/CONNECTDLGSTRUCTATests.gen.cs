// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CONNECTDLGSTRUCTA"/> struct.</summary>
public static unsafe partial class CONNECTDLGSTRUCTATests
{
    /// <summary>Validates that the <see cref = "CONNECTDLGSTRUCTA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CONNECTDLGSTRUCTA>(), Is.EqualTo(sizeof(CONNECTDLGSTRUCTA)));
    }

    /// <summary>Validates that the <see cref = "CONNECTDLGSTRUCTA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CONNECTDLGSTRUCTA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CONNECTDLGSTRUCTA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CONNECTDLGSTRUCTA), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(CONNECTDLGSTRUCTA), Is.EqualTo(20));
        }
    }
}