// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "COINSTALLER_CONTEXT_DATA"/> struct.</summary>
public static unsafe partial class COINSTALLER_CONTEXT_DATATests
{
    /// <summary>Validates that the <see cref = "COINSTALLER_CONTEXT_DATA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<COINSTALLER_CONTEXT_DATA>(),
            Is.EqualTo(sizeof(COINSTALLER_CONTEXT_DATA))
        );
    }

    /// <summary>Validates that the <see cref = "COINSTALLER_CONTEXT_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COINSTALLER_CONTEXT_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COINSTALLER_CONTEXT_DATA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(COINSTALLER_CONTEXT_DATA), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(COINSTALLER_CONTEXT_DATA), Is.EqualTo(12));
        }
    }
}
