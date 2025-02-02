/** @type {import('tailwindcss').Config} */
module.exports = {
    corePlugins: {
        preflight: false,
        container: false,
    },
    darkMode: ["class", '[data-theme="dark"]'],
    content: ["./src/**/*.{jsx,tsx,html}"],
    theme: {
        extend: {},
    },
    plugins: [],
}
