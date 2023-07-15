// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "KERB_RETRIEVE_KEY_TAB_RESPONSE"/> struct.</summary>
public static unsafe partial class KERB_RETRIEVE_KEY_TAB_RESPONSETests
{
    /// <summary>Validates that the <see cref = "KERB_RETRIEVE_KEY_TAB_RESPONSE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<KERB_RETRIEVE_KEY_TAB_RESPONSE>(), Is.EqualTo(sizeof(KERB_RETRIEVE_KEY_TAB_RESPONSE)));
    }

    /// <summary>Validates that the <see cref = "KERB_RETRIEVE_KEY_TAB_RESPONSE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KERB_RETRIEVE_KEY_TAB_RESPONSE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "KERB_RETRIEVE_KEY_TAB_RESPONSE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(KERB_RETRIEVE_KEY_TAB_RESPONSE), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(KERB_RETRIEVE_KEY_TAB_RESPONSE), Is.EqualTo(12));
        }
    }
}