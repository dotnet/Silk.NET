// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "MLOperatorSetId"/> struct.</summary>
public static unsafe partial class MLOperatorSetIdTests
{
    /// <summary>Validates that the <see cref = "MLOperatorSetId"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MLOperatorSetId>(), Is.EqualTo(sizeof(MLOperatorSetId)));
    }

    /// <summary>Validates that the <see cref = "MLOperatorSetId"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MLOperatorSetId).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MLOperatorSetId"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MLOperatorSetId), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(MLOperatorSetId), Is.EqualTo(8));
        }
    }
}