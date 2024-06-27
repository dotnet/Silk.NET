import React from "react";
import styles from "./AllinOneSolution.module.scss";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faTrowelBricks, faMobileScreen, faFaceSmile } from "@fortawesome/free-solid-svg-icons";

export default function AllInOneSolution(): JSX.Element {

    return (
        <div className={styles.content}>

            <h1 className={styles.title}>An All-in-one solution</h1>
            
            <img src={'img/xplatpromo.png'} draggable={"false"}></img>

            <div className={styles.item}>
                <span><FontAwesomeIcon icon={faTrowelBricks}></FontAwesomeIcon></span>
                <p>First-party bindings for over 17 individual APIs</p>
            </div>

            <div className={styles.item}>
                <span><FontAwesomeIcon icon={faMobileScreen}></FontAwesomeIcon></span>
                <p>Official support for all major desktop & mobile platforms</p>
            </div>

            <div className={styles.item}>
                <span><FontAwesomeIcon icon={faFaceSmile}></FontAwesomeIcon></span>
                <p>Friendly and active community & developers</p>
            </div>

        </div>
    );

}