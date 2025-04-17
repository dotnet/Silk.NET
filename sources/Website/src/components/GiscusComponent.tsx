import React from 'react';
import Giscus from "@giscus/react";
import { useColorMode } from '@docusaurus/theme-common';

export default function GiscusComponent() {
    const { colorMode } = useColorMode();

    return (
        <Giscus
            repo="dotnet/Silk.NET"
            repoId="MDEwOlJlcG9zaXRvcnkxOTEyMzIyNDA="
            category="Webpage Comments"
            categoryId="DIC_kwDOC2X48M4CT__i"
            mapping="pathname"
            strict="0"
            reactionsEnabled="1"
            emitMetadata="0"
            inputPosition="bottom"
            theme={colorMode}
            lang="en"
            loading="lazy"
        />
    );
}
