// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "JOBOBJECT_BASIC_PROCESS_ID_LIST"/> struct.</summary>
public static unsafe partial class JOBOBJECT_BASIC_PROCESS_ID_LISTTests
{
    /// <summary>Validates that the <see cref = "JOBOBJECT_BASIC_PROCESS_ID_LIST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<JOBOBJECT_BASIC_PROCESS_ID_LIST>(), Is.EqualTo(sizeof(JOBOBJECT_BASIC_PROCESS_ID_LIST)));
    }

    /// <summary>Validates that the <see cref = "JOBOBJECT_BASIC_PROCESS_ID_LIST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(JOBOBJECT_BASIC_PROCESS_ID_LIST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "JOBOBJECT_BASIC_PROCESS_ID_LIST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(JOBOBJECT_BASIC_PROCESS_ID_LIST), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(JOBOBJECT_BASIC_PROCESS_ID_LIST), Is.EqualTo(12));
        }
    }
}