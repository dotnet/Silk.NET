import React from "react";
import DocItemFooter from "@theme-original/DocItem/Footer";
import type DocItemFooterType from "@theme/DocItem/Footer";
import type { WrapperProps } from "@docusaurus/types";
import { useDoc } from "@docusaurus/plugin-content-docs/client";
import GiscusComponent from "@site/src/components/GiscusComponent";

type Props = WrapperProps<typeof DocItemFooterType>;

export default function DocItemFooterWrapper(props: Props): JSX.Element {
    const { metadata } = useDoc();
    const { comments = true } = metadata.frontMatter;

    return (
        <>
            <DocItemFooter {...props} />
            {comments && <GiscusComponent />}
        </>
    );
}
