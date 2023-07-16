// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SPC_STATEMENT_TYPE"/> struct.</summary>
public static unsafe partial class SPC_STATEMENT_TYPETests
{
    /// <summary>Validates that the <see cref = "SPC_STATEMENT_TYPE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SPC_STATEMENT_TYPE>(), Is.EqualTo(sizeof(SPC_STATEMENT_TYPE)));
    }

    /// <summary>Validates that the <see cref = "SPC_STATEMENT_TYPE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SPC_STATEMENT_TYPE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SPC_STATEMENT_TYPE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SPC_STATEMENT_TYPE), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SPC_STATEMENT_TYPE), Is.EqualTo(8));
        }
    }
}