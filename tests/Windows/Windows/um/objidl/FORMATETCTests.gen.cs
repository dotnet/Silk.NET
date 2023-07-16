// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FORMATETC"/> struct.</summary>
public static unsafe partial class FORMATETCTests
{
    /// <summary>Validates that the <see cref = "FORMATETC"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FORMATETC>(), Is.EqualTo(sizeof(FORMATETC)));
    }

    /// <summary>Validates that the <see cref = "FORMATETC"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FORMATETC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FORMATETC"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(FORMATETC), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(FORMATETC), Is.EqualTo(20));
        }
    }
}