// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DICONFIGUREDEVICESPARAMSA"/> struct.</summary>
public static unsafe partial class DICONFIGUREDEVICESPARAMSATests
{
    /// <summary>Validates that the <see cref = "DICONFIGUREDEVICESPARAMSA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DICONFIGUREDEVICESPARAMSA>(),
            Is.EqualTo(sizeof(DICONFIGUREDEVICESPARAMSA))
        );
    }

    /// <summary>Validates that the <see cref = "DICONFIGUREDEVICESPARAMSA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DICONFIGUREDEVICESPARAMSA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DICONFIGUREDEVICESPARAMSA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DICONFIGUREDEVICESPARAMSA), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(DICONFIGUREDEVICESPARAMSA), Is.EqualTo(64));
        }
    }
}
