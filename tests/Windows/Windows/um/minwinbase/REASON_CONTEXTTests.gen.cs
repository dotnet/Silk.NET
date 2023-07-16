// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "REASON_CONTEXT"/> struct.</summary>
public static unsafe partial class REASON_CONTEXTTests
{
    /// <summary>Validates that the <see cref = "REASON_CONTEXT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<REASON_CONTEXT>(), Is.EqualTo(sizeof(REASON_CONTEXT)));
    }

    /// <summary>Validates that the <see cref = "REASON_CONTEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(REASON_CONTEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "REASON_CONTEXT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(REASON_CONTEXT), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(REASON_CONTEXT), Is.EqualTo(24));
        }
    }
}