import React from "react";
import styles from "./ReliableDepend.module.scss";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faHeartCirclePlus, faLightbulb, faWrench } from "@fortawesome/free-solid-svg-icons";

export default function RealiableAndDependable(): JSX.Element {

    return (
        <div className={styles.container}>

            <h1 className={styles.title}>Reliable & dependable</h1>

            <div className={styles.item}>

                <span className={styles.icon}>
                    <FontAwesomeIcon icon={faLightbulb}></FontAwesomeIcon>
                </span>

                <h2>Strong backing</h2>

                <p>
                    We're proud to be an official project under the benevolent .NET Foundation
                    umbrella - an independent, non-profit organization established to support
                    an innovative, commercially friendly, open-source ecosystem around the .NET
                    platform with corporate sponsorship from Microsoft, Amazon AWS, and many
                    others.
                </p>

                <p>
                    This means you can count on us not disappearing tomorrow, and continuing to
                    reamin under steady development; a guarantee that similar libraries just
                    can't provide.
                </p>

            </div>

            <div className={styles.item}>

                <span className={styles.icon}>
                    <FontAwesomeIcon icon={faWrench}></FontAwesomeIcon>
                </span>

                <h2>Continuously improving</h2>

                <p>
                    We're quick to develop and release new major versions for keeping up with
                    changes and new trends in the ecosystem. In addition, we're keen to create
                    infrastructure to make minor incremental improvments easy to implement.
                </p>

                <p>
                    We're happy to look at any idea the community has for us, large or small,
                    so feel free to chat to us if you think there's a way we can improve!
                </p>

            </div>

            <div className={styles.item}>

                <span className={styles.icon}>
                    <FontAwesomeIcon icon={faHeartCirclePlus}></FontAwesomeIcon>
                </span>

                <h2>Free & open-source</h2>

                <p>
                    Silk.NET is licensed under the very permissive MIT/X11 license, which means
                    that you can use Silk.NET in your commercial, non-commercial, hobby, or just
                    about any other kind of project.
                </p>

                <p>
                    We offer no commercial support, which means that everyone has equal access to
                    the best support the Silk.NET team can provide. And last but not least, we
                    have a thriving, friendly, and approachable community who, if we're unable to
                    for whatever reason, are happy to guide you in using our library.
                </p>

            </div>


        </div>
    );

}