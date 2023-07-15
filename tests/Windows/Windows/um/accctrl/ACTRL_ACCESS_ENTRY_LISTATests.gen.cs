// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ACTRL_ACCESS_ENTRY_LISTA"/> struct.</summary>
public static unsafe partial class ACTRL_ACCESS_ENTRY_LISTATests
{
    /// <summary>Validates that the <see cref = "ACTRL_ACCESS_ENTRY_LISTA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ACTRL_ACCESS_ENTRY_LISTA>(), Is.EqualTo(sizeof(ACTRL_ACCESS_ENTRY_LISTA)));
    }

    /// <summary>Validates that the <see cref = "ACTRL_ACCESS_ENTRY_LISTA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACTRL_ACCESS_ENTRY_LISTA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ACTRL_ACCESS_ENTRY_LISTA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ACTRL_ACCESS_ENTRY_LISTA), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(ACTRL_ACCESS_ENTRY_LISTA), Is.EqualTo(8));
        }
    }
}