// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT"/> struct.</summary>
public static unsafe partial class WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECTTests
{
    /// <summary>Validates that the <see cref = "WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT>(), Is.EqualTo(sizeof(WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT)));
    }

    /// <summary>Validates that the <see cref = "WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT), Is.EqualTo(12));
        }
    }
}