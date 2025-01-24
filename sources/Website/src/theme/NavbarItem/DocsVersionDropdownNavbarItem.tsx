/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import React from 'react';
import DocsVersionDropdownNavbarItem from '@theme-original/NavbarItem/DocsVersionDropdownNavbarItem';
import {useActiveDocContext} from '@docusaurus/plugin-content-docs/client';

export default function DocsVersionDropdownNavbarItemWrapper(props) {
    // (CUSTOM) Hide version dropdown on non-versioned pages
    const activeDocContext = useActiveDocContext(props.docsPluginId);
    if (!activeDocContext.activeDoc) {
        return null;
    }

    return <DocsVersionDropdownNavbarItem {...props} />;
}
