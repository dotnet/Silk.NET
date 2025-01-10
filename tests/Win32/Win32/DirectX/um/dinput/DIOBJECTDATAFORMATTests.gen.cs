// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DIOBJECTDATAFORMAT"/> struct.</summary>
public static unsafe partial class DIOBJECTDATAFORMATTests
{
    /// <summary>Validates that the <see cref = "DIOBJECTDATAFORMAT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIOBJECTDATAFORMAT>(), Is.EqualTo(sizeof(DIOBJECTDATAFORMAT)));
    }

    /// <summary>Validates that the <see cref = "DIOBJECTDATAFORMAT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIOBJECTDATAFORMAT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIOBJECTDATAFORMAT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DIOBJECTDATAFORMAT), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DIOBJECTDATAFORMAT), Is.EqualTo(16));
        }
    }
}
