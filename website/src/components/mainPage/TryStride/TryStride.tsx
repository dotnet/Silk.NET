import React from "react";
import styles from "./TryStride.module.scss";
import Link from "@docusaurus/Link";

export default function TryStride(): JSX.Element {

    return (
        <div>

            <div className={styles.container}>

                <div className={styles.left}>

                    <h1 className={styles.title}>Not your cup of tea? Try Stride</h1>
                    <p>
                        Silk.NET is low-level and empowers the developer with complete control
                        over rendering. Because of this, we understand Silk.NET isn't for everyone.
                        If you fancy something more high-level, give Stride a shot! Stride is a 2D
                        & 3D game engine supported by the .NET Foundation.
                    </p>

                </div>

                <div className={styles.right}>

                    <img src="img/stride.svg" className={styles.strideLogo} draggable={false}></img>

                    <Link to="https://www.stride3d.net" className={styles.learnMore}>LEARN MORE</Link>

                </div>

            </div>
            
        </div>
    );

}