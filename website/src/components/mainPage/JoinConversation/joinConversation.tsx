import React from "react";
import styles from "./joinConversation.module.scss";
import Link from '@docusaurus/Link';

export default function JoinTheConversation(): JSX.Element {

    return (
        <div className={styles.body}>

            <h1 className={styles.title}>Joint the conversation!</h1>
            <h2 className={styles.title}>Talk to us on Discord or GitHub</h2>

            <div className={styles.wigdgetsContainer}>

                <div className={styles.discordWigdget}>

                    <div className={styles.topBar}></div>

                    <div className={styles.icon}></div>

                    <div className={styles.discordLogo}></div>

                    <div className={styles.content}>

                        <p>Active and fun community;</p>
                        <p>Quick answers and <span className={styles.channelLink}>help</span> channel;</p>
                        <p>News and announcements</p>

                    </div>

                    <Link to="https://discord.gg/DTHHXRt" className={styles.joinButton}>
                        Join Now!
                    </Link>

                </div>

                <div className={styles.githubWigdget}>

                    <div className={styles.header}>

                        <Link to="https://github.com" className={styles.githubLogo}></Link>

                        <div className={styles.breadcrumb}>
                            <Link to="https://github.com/dotnet">dotnet</Link>
                            <p>/</p>
                            <Link to="https://github.com/dotnet/Silk.NET">Silk.NET</Link>
                        </div>

                        <div className={styles.discussionsTitle}>
                            <svg aria-hidden="true" height="16" viewBox="0 0 16 16" version="1.1" width="16" data-view-component="true">
                                <path d="M1.75 1h8.5c.966 0 1.75.784 1.75 1.75v5.5A1.75 1.75 0 0 1 10.25 10H7.061l-2.574 2.573A1.458 1.458 0 0 1 2 11.543V10h-.25A1.75 1.75 0 0 1 0 8.25v-5.5C0 1.784.784 1 1.75 1ZM1.5 2.75v5.5c0 .138.112.25.25.25h1a.75.75 0 0 1 .75.75v2.19l2.72-2.72a.749.749 0 0 1 .53-.22h3.5a.25.25 0 0 0 .25-.25v-5.5a.25.25 0 0 0-.25-.25h-8.5a.25.25 0 0 0-.25.25Zm13 2a.25.25 0 0 0-.25-.25h-.5a.75.75 0 0 1 0-1.5h.5c.966 0 1.75.784 1.75 1.75v5.5A1.75 1.75 0 0 1 14.25 12H14v1.543a1.458 1.458 0 0 1-2.487 1.03L9.22 12.28a.749.749 0 0 1 .326-1.275.749.749 0 0 1 .734.215l2.22 2.22v-2.19a.75.75 0 0 1 .75-.75h1a.25.25 0 0 0 .25-.25Z"></path>
                            </svg>
                            Discussions
                        </div>

                    </div>

                    <div className={styles.content}>
                        <p>Contribute with:</p>
                        <div className={styles.list}>
                            <p>💡 ideas;</p>
                            <p>⏫ suggestions;</p>
                            <p>🐞 bug reports;</p>
                        </div>
                        <p>
                            And the future of Silk.NET directly with the
                            .NET team!
                        </p>
                    </div>

                    <Link to="https://github.com/dotnet/Silk.NET/discussions"
                    className={styles.joinButton}>New Discussion</Link>

                </div>

            </div>
        </div>
    );

}