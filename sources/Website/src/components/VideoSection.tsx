import clsx from "clsx";
import styles from './styles.module.css';
import Link from "@docusaurus/Link";

export function VideoSection({ children }): JSX.Element {
    return (
        <section className={clsx('container')}>
            <div className={clsx('row')}>
                <iframe src="https://www.youtube.com/embed/YApRxaB6upY"
                        title="YouTube video player" frameBorder="0"
                        allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
                        referrerPolicy="strict-origin-when-cross-origin"
                        allowFullScreen
                        className={clsx(styles.ytEmbed)}/>
                <div className={clsx(styles.silkRhs)}>
                    <h2>Silk.NET Lecture - Better Than OpenTK?</h2>
                    <p>
                        In this video NoNumberMan - a Silk.NET community member - will explain to you what
                        Silk.NET is, and how you can use it to make games in C#. Silk.NET has bindings for
                        OpenGL, OpenAL, OpenCL, and a whole lot more! Sounds a lot like OpenTK, doesn't it?
                        So... which one is better?
                    </p>
                    <Link
                        className={clsx('button button--primary', styles.silkBtn)}
                        to="https://www.youtube.com/watch?v=YApRxaB6upY">
                        Watch on YouTube
                    </Link>
                    <Link
                        className={clsx('button button--secondary', styles.silkBtn)}
                        to="/content">
                        Find More Content
                    </Link>
                </div>
            </div>
            <br/>
        </section>
    )
}
