// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SPC_INDIRECT_DATA_CONTENT"/> struct.</summary>
public static unsafe partial class SPC_INDIRECT_DATA_CONTENTTests
{
    /// <summary>Validates that the <see cref = "SPC_INDIRECT_DATA_CONTENT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SPC_INDIRECT_DATA_CONTENT>(), Is.EqualTo(sizeof(SPC_INDIRECT_DATA_CONTENT)));
    }

    /// <summary>Validates that the <see cref = "SPC_INDIRECT_DATA_CONTENT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SPC_INDIRECT_DATA_CONTENT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SPC_INDIRECT_DATA_CONTENT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SPC_INDIRECT_DATA_CONTENT), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(SPC_INDIRECT_DATA_CONTENT), Is.EqualTo(32));
        }
    }
}