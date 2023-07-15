// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EXCEPTION_RECORD"/> struct.</summary>
public static unsafe partial class EXCEPTION_RECORDTests
{
    /// <summary>Validates that the <see cref = "EXCEPTION_RECORD"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EXCEPTION_RECORD>(), Is.EqualTo(sizeof(EXCEPTION_RECORD)));
    }

    /// <summary>Validates that the <see cref = "EXCEPTION_RECORD"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EXCEPTION_RECORD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EXCEPTION_RECORD"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(EXCEPTION_RECORD), Is.EqualTo(152));
        }
        else
        {
            Assert.That(sizeof(EXCEPTION_RECORD), Is.EqualTo(80));
        }
    }
}